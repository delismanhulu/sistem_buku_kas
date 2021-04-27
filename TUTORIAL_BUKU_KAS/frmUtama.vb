Imports System.Data.Odbc
Public Class frmUtama

    Sub profil()
        Try
            CMD = New OdbcCommand("SELECT * FROM TBL_PROFIL LIMIT 1", konek)
            DR = CMD.ExecuteReader
            DR.Read()
            If DR.HasRows Then
                lblNama.Text = (DR.Item("NAMA"))
                lblAlamat.Text = (DR.Item("ALAMAT"))
            Else
                lblNama.Text = ""
                lblAlamat.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub
    Private Sub frmUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call KONEKSIDB()
        PANEL4.Text = Date.Now
        Call profil()

        If PANEL3.Text = "User" Then
            lbluser.Enabled = False
            lblprofil.Enabled = False
        Else
            lbluser.Enabled = True
            lblprofil.Enabled = True
        End If
      


    End Sub
    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblprofil.Click
        frmProfil.ShowDialog()
    End Sub
    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbluser.Click
        frmUser.ShowDialog()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        frmKasMasuk.ShowDialog()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        frmKasKeluar.ShowDialog()
    End Sub
End Class