<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnlogin = New MetroFramework.Controls.MetroButton()
        Me.txtusername = New MetroFramework.Controls.MetroTextBox()
        Me.txtpassword = New MetroFramework.Controls.MetroTextBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnlogin
        '
        Me.btnlogin.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnlogin.Location = New System.Drawing.Point(212, 360)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(148, 55)
        Me.btnlogin.TabIndex = 0
        Me.btnlogin.Text = "LOGIN"
        Me.btnlogin.UseSelectable = True
        '
        'txtusername
        '
        Me.txtusername.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtusername.Icon = CType(resources.GetObject("txtusername.Icon"), System.Drawing.Image)
        Me.txtusername.Lines = New String(-1) {}
        Me.txtusername.Location = New System.Drawing.Point(212, 213)
        Me.txtusername.MaxLength = 32767
        Me.txtusername.Name = "txtusername"
        Me.txtusername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtusername.PromptText = "User Name"
        Me.txtusername.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtusername.SelectedText = ""
        Me.txtusername.Size = New System.Drawing.Size(305, 39)
        Me.txtusername.TabIndex = 2
        Me.txtusername.UseSelectable = True
        '
        'txtpassword
        '
        Me.txtpassword.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtpassword.Icon = CType(resources.GetObject("txtpassword.Icon"), System.Drawing.Image)
        Me.txtpassword.Lines = New String(-1) {}
        Me.txtpassword.Location = New System.Drawing.Point(212, 268)
        Me.txtpassword.MaxLength = 32767
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.PromptText = "Password"
        Me.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.Size = New System.Drawing.Size(305, 39)
        Me.txtpassword.TabIndex = 3
        Me.txtpassword.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.MetroButton2.Location = New System.Drawing.Point(366, 360)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(148, 55)
        Me.MetroButton2.TabIndex = 0
        Me.MetroButton2.Text = "TUTUP"
        Me.MetroButton2.UseSelectable = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(184, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(362, 411)
        Me.Label4.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Lime
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(331, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1027, 581)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnlogin As MetroFramework.Controls.MetroButton
    Friend WithEvents txtusername As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtpassword As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
