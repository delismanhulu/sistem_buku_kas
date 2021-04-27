Imports System.Data.Odbc
Public Class frmKasKeluar

    Sub kode_tanggal()
        CMD = New OdbcCommand("SELECT * FROM TBL_BUKU_KAS WHERE KODE IN(SELECT MAX(KODE) FROM TBL_BUKU_KAS)", konek)
        DR = CMD.ExecuteReader
        DR.Read()

        If Not DR.HasRows Then
            txtkode.Text = "KM" + Format(Now, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(DR.Item("KODE"), 3, 6) = Format(Now, "yyMMdd") Then
                txtkode.Text = Microsoft.VisualBasic.Right(DR.Item("KODE"), 8) + 1
                txtkode.Text = "KM" + txtkode.Text
            Else
                txtkode.Text = "KM" + Format(Now, "yyMMdd") + "01"
            End If
        End If
    End Sub
    Sub null()
        txtkode.Clear()
        txtCari.Clear()
        txtbukti.Clear()
        txtkeluar.Text = 0
        txturaian.Clear()
        txttanggal.Value = Date.Now
        txtbukti.Focus()
    End Sub
    Sub data_baru()
        txtCari.Clear()
        txtbukti.Clear()
        txtkeluar.Text = 0
        txturaian.Clear()
        txttanggal.Value = Date.Now
        txtbukti.Focus()
    End Sub
    Sub total_penerimaan()
        Dim hitung As Integer = 0
        For baris = 0 To TABEL1.RowCount - 1
            hitung = hitung + TABEL1.Rows(baris).Cells(4).Value
        Next
        LBLTOTAL.Text = hitung
        LBLTOTAL.Text = FormatNumber(LBLTOTAL.Text, 0)

    End Sub
    Sub tampil_data()
        Try
            DA = New OdbcDataAdapter("SELECT TANGGAL,KODE,NO_BUKTI,URAIAN,PENGELUARAN FROM TBL_BUKU_KAS WHERE PENGELUARAN > 0", konek)
            DS = New DataSet
            DA.Fill(DS)
            TABEL1.DataSource = DS.Tables(0)
            TABEL1.ReadOnly = True
            TABEL1.Columns(3).Width = 300

            TABEL1.Columns(4).DefaultCellStyle.Format = "###,###,###"
            Call total_penerimaan()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Dim masuk, keluar As Double

    Private Sub frmKasMasuk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KONEKSIDB()
        Call tampil_data()
        Call data_baru()
        Call kode_tanggal()
        txtkode.Enabled = False

    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call data_baru()
        Call kode_tanggal()
    End Sub


    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click

        If txtbukti.Text = "" Then
            MsgBox("Nomor Bukti Masih Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtkode.Text = "" Then
            MsgBox("Kode Masih Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txturaian.Text = "" Then
            MsgBox("Uraian Masih Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtkeluar.Text = "" Then
            MsgBox("Pengeluaran  Masih Kosong", vbExclamation, "Pesan")
            Exit Sub
        End If

        Dim tgl_transaksi, tgl, bulan, tahun As String
        tgl = txttanggal.Value.Day
        bulan = txttanggal.Value.Month
        tahun = txttanggal.Value.Year
        tgl_transaksi = tahun & "-" & bulan & "-" & tgl

        If CekRecord("select * from tbl_buku_kas where no_bukti='" & txtbukti.Text & "'") = True Then
            MsgBox("Nomor Bukti Sudah digunakan", vbExclamation, "Pesan")
            Exit Sub
        Else
            Dim simpan_data As String = "insert tbl_buku_kas (KODE,KODE_USER,NO_BUKTI,TANGGAL,URAIAN,PENGELUARAN) values ('" & txtkode.Text & "','" _
                                            & frmUtama.PANEL1.Text & "','" _
                                            & txtbukti.Text & "','" _
                                            & tgl_transaksi & "','" _
                                            & txturaian.Text & "','" _
                                            & keluar & "' )"
            CMD = New OdbcCommand(simpan_data, konek)
            CMD.ExecuteNonQuery()
            MsgBox("Data Berhasil simpan", vbInformation, "Pesan")
            Call tampil_data()
            Call kode_tanggal()
            Call data_baru()
        End If

    End Sub
    Private Sub txtkeluar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkeluar.TextChanged
        On Error Resume Next
        If txtkeluar.Text = "" Or Not IsNumeric(txtkeluar.Text) Then
            Exit Sub
        End If
        keluar = txtkeluar.Text
        txtkeluar.Text = Format(Val(keluar), "###,###")
        txtkeluar.SelectionStart = Len(txtkeluar.Text)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If txtbukti.Text = "" Then
            MsgBox("Nomor Bukti Masih Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtkode.Text = "" Then
            MsgBox("Kode Masih Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txturaian.Text = "" Then
            MsgBox("Uraian Masih Kosong", vbExclamation, "Pesan")
            Exit Sub
        ElseIf txtkeluar.Text = "" Then
            MsgBox("Pengeluaran  Masih Kosong", vbExclamation, "Pesan")
            Exit Sub
        End If

        Dim tgl_transaksi, tgl, bulan, tahun As String
        tgl = txttanggal.Value.Day
        bulan = txttanggal.Value.Month
        tahun = txttanggal.Value.Year
        tgl_transaksi = tahun & "-" & bulan & "-" & tgl

        Dim edit_data As String = "update tbl_buku_kas set no_bukti='" & txtbukti.Text & _
                   "', tanggal='" & tgl_transaksi & _
                   "', uraian='" & txturaian.Text & _
                   "', pengeluaran='" & keluar & _
                   "' where kode='" & txtkode.Text & "'"
        CMD = New OdbcCommand(edit_data, konek)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil di Edit", vbInformation, "Pesan")
        Call data_baru()
        Call tampil_data()
    End Sub

    Private Sub TABEL1_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles TABEL1.CellMouseClick
        On Error Resume Next
        txtkode.Text = TABEL1.Rows(e.RowIndex).Cells(1).Value
        CMD = New OdbcCommand("select * from tbl_buku_kas where kode='" & txtkode.Text & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkode.Text = DR.Item("KODE")
            txturaian.Text = DR.Item("URAIAN")
            txtkeluar.Text = DR.Item("PENGELUARAN")
            txtbukti.Text = DR.Item("NO_BUKTI")
            txttanggal.Value = DR.Item("TANGGAL")
        Else
            txtbukti.Text = ""
            txturaian.Text = ""
            txttanggal.Value = Date.Now
            txtkeluar.Text = 0
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Try
            If txtkode.Text = "" Then
                MsgBox("Data Yang akan di hapus belum di pilih")
                Exit Sub
            Else
                If MessageBox.Show("Apakah ada ini yakin di hapus", "Pemberitahuan", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim hapus_data As String = "delete from tbl_buku_kas where kode ='" & txtkode.Text & "'"
                    CMD = New OdbcCommand(hapus_data, konek)
                    CMD.ExecuteReader()
                    Call tampil_data()
                    Call data_baru()
                    Call kode_tanggal()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        Try
            DA = New OdbcDataAdapter("SELECT TANGGAL,KODE,NO_BUKTI,URAIAN,PENGELUARAN FROM TBL_BUKU_KAS WHERE PENGELUARAN > 0 AND URAIAN like '%" & txtCari.Text & "%'", konek)
            DS = New DataSet
            DA.Fill(DS)
            TABEL1.DataSource = DS.Tables(0)
            Call total_penerimaan()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class