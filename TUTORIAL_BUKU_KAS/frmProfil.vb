Imports System.Data.Odbc
Public Class frmProfil

    Private Sub frmProfil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KONEKSIDB()
        txtkode.Enabled = False
        On Error Resume Next
        CMD = New OdbcCommand("SELECT * FROM TBL_PROFIL LIMIT 1", konek)
        DR = CMD.ExecuteReader
        DR.Read()
        If DR.HasRows Then
            txtkode.Text = (DR.Item("KODE"))
            txtnama.Text = (DR.Item("NAMA"))
            txtalamat.Text = (DR.Item("ALAMAT"))
            txttelpon.Text = (DR.Item("TELEPON"))
            txtwebsite.Text = (DR.Item("WEB_SITE"))
            txtemail.Text = (DR.Item("EMAIL"))
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtnama.Text = "" Or txtkode.Text = "" Then
            MsgBox("Data Belum Lengkap", vbExclamation, "Pesan")
            Exit Sub
        Else
            CMD = New OdbcCommand("SELECT * FROM TBL_PROFIL WHERE KODE='" & txtkode.Text & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If Not DR.HasRows Then
                Dim simpan As String = "INSERT into tbl_profil (KODE,NAMA) values ('" & txtkode.Text & "','" _
                                       & txtnama.Text & "')"
                CMD = New OdbcCommand(simpan, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di simpan", vbInformation, "Berhasil")
            Else
                Dim edit_data As String = "UPDATE TBL_PROFIL SET NAMA='" & txtnama.Text & _
                    "',ALAMAT='" & txtalamat.Text & _
                    "',TELEPON='" & txttelpon.Text & _
                    "',WEB_SITE='" & txtwebsite.Text & _
                    "',EMAIL='" & txtemail.Text & _
                    "' where KODE ='" & txtkode.Text & "'"
                CMD = New OdbcCommand(edit_data, konek)
                CMD.ExecuteNonQuery()
                MsgBox("Data Berhasil di Update", vbInformation, "Berhasil")
            End If
        End If
        frmUtama.profil()
    End Sub
End Class