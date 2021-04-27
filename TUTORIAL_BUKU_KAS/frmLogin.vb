Imports System.Data.Odbc
Imports System.Security.Cryptography
Public Class frmLogin

    Private Sub MetroButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetroButton2.Click
        Me.Close()

    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Try
            If txtusername.Text = "" Then
                MsgBox("Username masih kosong", vbCritical, "Pesan")
                Exit Sub
            ElseIf txtpassword.Text = "" Then
                MsgBox("Password masih kosong", vbCritical, "Pesan")
                Exit Sub
            End If


            CMD = New OdbcCommand("select * from tbl_user where kode_user = '" & txtusername.Text & "' and password='" & (MD5(txtpassword.Text)) & "'", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                frmUtama.PANEL1.Text = DR.Item("kode_user")
                frmUtama.PANEL2.Text = DR.Item("user_name")
                frmUtama.PANEL3.Text = DR.Item("status")
                frmUtama.Show()
                Me.Hide()
            ElseIf Not DR.HasRows Then
                MsgBox("Username dan password tidak ditemukan didatabase", vbCritical, "Pesan")
                Exit Sub

            End If
        Catch ex As Exception

        End Try
        


    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KONEKSIDB()
    End Sub

    Private Sub txtusername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtusername.Click

    End Sub

    Private Sub txtusername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtusername.KeyPress
        If e.KeyChar = Chr(13) Then
            txtpassword.Focus()

        End If
    End Sub

    Private Sub txtpassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtpassword.Click

    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        If e.KeyChar = Chr(13) Then
            btnlogin.PerformClick()
        End If
    End Sub
End Class