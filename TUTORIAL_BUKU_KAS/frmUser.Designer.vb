<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.txtkodeuser = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btntambah = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbstatus = New System.Windows.Forms.ComboBox()
        Me.Tabel = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnsimpan = New MetroFramework.Controls.MetroButton()
        Me.btnhapus = New MetroFramework.Controls.MetroButton()
        Me.btntutup = New MetroFramework.Controls.MetroButton()
        CType(Me.Tabel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtkodeuser
        '
        Me.txtkodeuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodeuser.Location = New System.Drawing.Point(140, 42)
        Me.txtkodeuser.Name = "txtkodeuser"
        Me.txtkodeuser.Size = New System.Drawing.Size(401, 26)
        Me.txtkodeuser.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode User"
        '
        'btntambah
        '
        Me.btntambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntambah.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btntambah.Location = New System.Drawing.Point(10, 349)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(123, 51)
        Me.btntambah.TabIndex = 5
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseSelectable = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User/Nama"
        '
        'txtnama
        '
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(140, 71)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(401, 26)
        Me.txtnama.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(140, 100)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(401, 26)
        Me.txtpassword.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'cbstatus
        '
        Me.cbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbstatus.FormattingEnabled = True
        Me.cbstatus.Items.AddRange(New Object() {"Admin", "User"})
        Me.cbstatus.Location = New System.Drawing.Point(140, 131)
        Me.cbstatus.Name = "cbstatus"
        Me.cbstatus.Size = New System.Drawing.Size(401, 28)
        Me.cbstatus.TabIndex = 6
        '
        'Tabel
        '
        Me.Tabel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabel.Location = New System.Drawing.Point(10, 169)
        Me.Tabel.Name = "Tabel"
        Me.Tabel.Size = New System.Drawing.Size(531, 174)
        Me.Tabel.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "FORM USER"
        '
        'btnsimpan
        '
        Me.btnsimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsimpan.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnsimpan.Location = New System.Drawing.Point(139, 349)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(123, 51)
        Me.btnsimpan.TabIndex = 9
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseSelectable = True
        '
        'btnhapus
        '
        Me.btnhapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhapus.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnhapus.Location = New System.Drawing.Point(267, 349)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(123, 51)
        Me.btnhapus.TabIndex = 5
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseSelectable = True
        '
        'btntutup
        '
        Me.btntutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntutup.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btntutup.Location = New System.Drawing.Point(396, 349)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(123, 51)
        Me.btntutup.TabIndex = 9
        Me.btntutup.Text = "TUTUP"
        Me.btntutup.UseSelectable = True
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 407)
        Me.Controls.Add(Me.btntutup)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Tabel)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.cbstatus)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtkodeuser)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUser"
        CType(Me.Tabel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtkodeuser As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btntambah As MetroFramework.Controls.MetroButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Tabel As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnsimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents btnhapus As MetroFramework.Controls.MetroButton
    Friend WithEvents btntutup As MetroFramework.Controls.MetroButton
End Class
