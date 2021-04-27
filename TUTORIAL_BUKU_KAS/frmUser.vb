Imports System.Data.Odbc
Imports System.Security.Cryptography
Public Class frmUser

    Sub null()
        txtnama.Clear()
        txtpassword.Clear()
        txtkodeuser.Clear()
        cbstatus.ResetText()
        txtkodeuser.Focus()
    End Sub
    Sub data_baru()
        txtnama.Clear()
        txtpassword.Clear()
        cbstatus.ResetText()
        txtnama.Focus()
    End Sub
    Sub tampil_data()
        DA = New OdbcDataAdapter("SELECT KODE_USER,USER_NAME,STATUS FROM TBL_USER", konek)
        DS = New DataSet
        DA.Fill(DS)
        Tabel.DataSource = DS.Tables(0)

        Tabel.ReadOnly = True
        Tabel.Columns(1).Width = 250

    End Sub
   
    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KONEKSIDB()
        Call null()
        Call tampil_data()
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        Call null()
    End Sub

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        If txtkodeuser.Text = "" Or txtnama.Text = "" Or txtpassword.Text = "" Or cbstatus.Text = "" Then
            MsgBox("Data belum lengkap, Harap Lengkapi", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_USER WHERE KODE_USER = '" & txtkodeuser.Text & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpan_data As String = "INSERT TBL_USER values ('" & txtkodeuser.Text & "','" _
                                            & txtnama.Text & "','" _
                                            & (MD5(txtpassword.Text)) & "','" _
                                            & cbstatus.Text & "' )"
                CMD = New OdbcCommand(simpan_data, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil simpan", vbInformation, "Pesan")
                Call null()
                Call tampil_data()
            Else
                'untuk melakukan edit data di database
                Dim edit_data As String = "UPDATE TBL_USER SET USER_NAME='" & txtnama.Text & _
                    "', STATUS='" & cbstatus.Text & _
                    "' where KODE_USER='" & txtkodeuser.Text & "'"
                CMD = New OdbcCommand(edit_data, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Edit", vbInformation, "Pesan")
                Call data_baru()
                Call tampil_data()

            End If
        End If
    End Sub

    Private Sub Tabel_CellMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Tabel.CellMouseClick
        On Error Resume Next
        txtkodeuser.Text = Tabel.Rows(e.RowIndex).Cells(0).Value
        CMD = New OdbcCommand("SELECT * FROM TBL_USER where kode_user='" & txtkodeuser.Text & "'", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkodeuser.Text = DR.Item("KODE_USER")
            txtnama.Text = DR.Item("USER_NAME")
            'txtpassword.Text = DR.Item("PASSWORD")
            cbstatus.Text = DR.Item("STATUS")
        Else
            txtkodeuser.Text = ""
            txtnama.Text = ""
            txtpassword.Text = ""
            cbstatus.Text = ""
        End If
    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click
        Try
            If txtkodeuser.Text = "" Then
                MsgBox("Data Yang akan di hapus belum di pilih")
                Exit Sub
            Else
                If MessageBox.Show("Apakah ada ini yakin di hapus", "Pemberitahuan", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Dim hapus_data As String = "DELETE FROM TBL_USER WHERE KODE_USER ='" & txtkodeuser.Text & "'"
                    CMD = New OdbcCommand(hapus_data, konek)
                    CMD.ExecuteReader()
                    Call tampil_data()
                    Call null()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btntutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

   
    Private Sub btntutup_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntutup.Click
        Me.Close()
    End Sub

    Private Sub Tabel_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Tabel.CellContentClick

    End Sub
End Class