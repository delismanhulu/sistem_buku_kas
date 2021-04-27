<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKasKeluar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        Me.txttanggal = New System.Windows.Forms.DateTimePicker()
        Me.txturaian = New System.Windows.Forms.TextBox()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.txtkeluar = New System.Windows.Forms.TextBox()
        Me.txtbukti = New System.Windows.Forms.TextBox()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBLTOTAL = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btntutup = New MetroFramework.Controls.MetroButton()
        Me.btnsimpan = New MetroFramework.Controls.MetroButton()
        Me.btnhapus = New MetroFramework.Controls.MetroButton()
        Me.btntambah = New MetroFramework.Controls.MetroButton()
        Me.TABEL1 = New System.Windows.Forms.DataGridView()
        CType(Me.TABEL1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdate.Location = New System.Drawing.Point(270, 401)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(123, 51)
        Me.btnUpdate.TabIndex = 37
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseSelectable = True
        '
        'txttanggal
        '
        Me.txttanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttanggal.Location = New System.Drawing.Point(616, 74)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(167, 26)
        Me.txttanggal.TabIndex = 36
        '
        'txturaian
        '
        Me.txturaian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txturaian.Location = New System.Drawing.Point(151, 104)
        Me.txturaian.Multiline = True
        Me.txturaian.Name = "txturaian"
        Me.txturaian.Size = New System.Drawing.Size(632, 60)
        Me.txturaian.TabIndex = 32
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(616, 173)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(167, 26)
        Me.txtCari.TabIndex = 31
        '
        'txtkeluar
        '
        Me.txtkeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkeluar.Location = New System.Drawing.Point(151, 167)
        Me.txtkeluar.Name = "txtkeluar"
        Me.txtkeluar.Size = New System.Drawing.Size(249, 26)
        Me.txtkeluar.TabIndex = 33
        '
        'txtbukti
        '
        Me.txtbukti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbukti.Location = New System.Drawing.Point(151, 76)
        Me.txtbukti.Name = "txtbukti"
        Me.txtbukti.Size = New System.Drawing.Size(249, 26)
        Me.txtbukti.TabIndex = 35
        '
        'txtkode
        '
        Me.txtkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(151, 47)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(249, 26)
        Me.txtkode.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Uraian"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Pengeluaran"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 20)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Transaksi Kas Keluar"
        '
        'LBLTOTAL
        '
        Me.LBLTOTAL.AutoSize = True
        Me.LBLTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOTAL.Location = New System.Drawing.Point(626, 417)
        Me.LBLTOTAL.Name = "LBLTOTAL"
        Me.LBLTOTAL.Size = New System.Drawing.Size(49, 20)
        Me.LBLTOTAL.TabIndex = 24
        Me.LBLTOTAL.Text = "Total"
        Me.LBLTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(546, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Cari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(545, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Nomor Bukti"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Kode Transaksi"
        '
        'btntutup
        '
        Me.btntutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntutup.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btntutup.Location = New System.Drawing.Point(531, 401)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(80, 51)
        Me.btntutup.TabIndex = 21
        Me.btntutup.Text = "TUTUP"
        Me.btntutup.UseSelectable = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsimpan.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnsimpan.Location = New System.Drawing.Point(141, 401)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(123, 51)
        Me.btnsimpan.TabIndex = 22
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseSelectable = True
        '
        'btnhapus
        '
        Me.btnhapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhapus.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnhapus.Location = New System.Drawing.Point(402, 401)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(123, 51)
        Me.btnhapus.TabIndex = 19
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseSelectable = True
        '
        'btntambah
        '
        Me.btntambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntambah.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btntambah.Location = New System.Drawing.Point(12, 401)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(123, 51)
        Me.btntambah.TabIndex = 20
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseSelectable = True
        '
        'TABEL1
        '
        Me.TABEL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TABEL1.Location = New System.Drawing.Point(12, 202)
        Me.TABEL1.Name = "TABEL1"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TABEL1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TABEL1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.TABEL1.Size = New System.Drawing.Size(771, 193)
        Me.TABEL1.TabIndex = 18
        '
        'frmKasKeluar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 458)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.txturaian)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.txtkeluar)
        Me.Controls.Add(Me.txtbukti)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LBLTOTAL)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btntutup)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.TABEL1)
        Me.Name = "frmKasKeluar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmKasKeluar"
        CType(Me.TABEL1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
    Friend WithEvents txttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txturaian As System.Windows.Forms.TextBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents txtkeluar As System.Windows.Forms.TextBox
    Friend WithEvents txtbukti As System.Windows.Forms.TextBox
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LBLTOTAL As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btntutup As MetroFramework.Controls.MetroButton
    Friend WithEvents btnsimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents btnhapus As MetroFramework.Controls.MetroButton
    Friend WithEvents btntambah As MetroFramework.Controls.MetroButton
    Friend WithEvents TABEL1 As System.Windows.Forms.DataGridView
End Class
