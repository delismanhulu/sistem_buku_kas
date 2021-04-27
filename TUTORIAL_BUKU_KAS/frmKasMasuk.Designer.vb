<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKasMasuk
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TABEL1 = New System.Windows.Forms.DataGridView()
        Me.btntutup = New MetroFramework.Controls.MetroButton()
        Me.btnsimpan = New MetroFramework.Controls.MetroButton()
        Me.btnhapus = New MetroFramework.Controls.MetroButton()
        Me.btntambah = New MetroFramework.Controls.MetroButton()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbukti = New System.Windows.Forms.TextBox()
        Me.txturaian = New System.Windows.Forms.TextBox()
        Me.txttanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpenerimaan = New System.Windows.Forms.TextBox()
        Me.LBLTOTAL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnUpdate = New MetroFramework.Controls.MetroButton()
        CType(Me.TABEL1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TABEL1
        '
        Me.TABEL1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TABEL1.Location = New System.Drawing.Point(11, 202)
        Me.TABEL1.Name = "TABEL1"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TABEL1.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TABEL1.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.TABEL1.Size = New System.Drawing.Size(771, 193)
        Me.TABEL1.TabIndex = 0
        '
        'btntutup
        '
        Me.btntutup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntutup.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btntutup.Location = New System.Drawing.Point(530, 401)
        Me.btntutup.Name = "btntutup"
        Me.btntutup.Size = New System.Drawing.Size(80, 51)
        Me.btntutup.TabIndex = 12
        Me.btntutup.Text = "TUTUP"
        Me.btntutup.UseSelectable = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsimpan.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnsimpan.Location = New System.Drawing.Point(140, 401)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(123, 51)
        Me.btnsimpan.TabIndex = 13
        Me.btnsimpan.Text = "SIMPAN"
        Me.btnsimpan.UseSelectable = True
        '
        'btnhapus
        '
        Me.btnhapus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnhapus.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnhapus.Location = New System.Drawing.Point(401, 401)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(123, 51)
        Me.btnhapus.TabIndex = 10
        Me.btnhapus.Text = "HAPUS"
        Me.btnhapus.UseSelectable = True
        '
        'btntambah
        '
        Me.btntambah.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btntambah.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btntambah.Location = New System.Drawing.Point(11, 401)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(123, 51)
        Me.btntambah.TabIndex = 11
        Me.btntambah.Text = "TAMBAH"
        Me.btntambah.UseSelectable = True
        '
        'txtkode
        '
        Me.txtkode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkode.Location = New System.Drawing.Point(150, 47)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(249, 26)
        Me.txtkode.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Kode Transaksi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nomor Bukti"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Uraian"
        '
        'txtbukti
        '
        Me.txtbukti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbukti.Location = New System.Drawing.Point(150, 76)
        Me.txtbukti.Name = "txtbukti"
        Me.txtbukti.Size = New System.Drawing.Size(249, 26)
        Me.txtbukti.TabIndex = 15
        '
        'txturaian
        '
        Me.txturaian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txturaian.Location = New System.Drawing.Point(150, 104)
        Me.txturaian.Multiline = True
        Me.txturaian.Name = "txturaian"
        Me.txturaian.Size = New System.Drawing.Size(632, 60)
        Me.txturaian.TabIndex = 15
        '
        'txttanggal
        '
        Me.txttanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttanggal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txttanggal.Location = New System.Drawing.Point(615, 74)
        Me.txttanggal.Name = "txttanggal"
        Me.txttanggal.Size = New System.Drawing.Size(167, 26)
        Me.txttanggal.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(544, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Penerimaan"
        '
        'txtpenerimaan
        '
        Me.txtpenerimaan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpenerimaan.Location = New System.Drawing.Point(150, 167)
        Me.txtpenerimaan.Name = "txtpenerimaan"
        Me.txtpenerimaan.Size = New System.Drawing.Size(249, 26)
        Me.txtpenerimaan.TabIndex = 15
        '
        'LBLTOTAL
        '
        Me.LBLTOTAL.AutoSize = True
        Me.LBLTOTAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOTAL.Location = New System.Drawing.Point(625, 417)
        Me.LBLTOTAL.Name = "LBLTOTAL"
        Me.LBLTOTAL.Size = New System.Drawing.Size(49, 20)
        Me.LBLTOTAL.TabIndex = 14
        Me.LBLTOTAL.Text = "Total"
        Me.LBLTOTAL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(178, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Transaksi Kas Masuk"
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(615, 173)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(167, 26)
        Me.txtCari.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(545, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Cari"
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnUpdate.Location = New System.Drawing.Point(269, 401)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(123, 51)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "UPDATE"
        Me.btnUpdate.UseSelectable = True
        '
        'frmKasMasuk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 458)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txttanggal)
        Me.Controls.Add(Me.txturaian)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.txtpenerimaan)
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
        Me.Name = "frmKasMasuk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmKasMasuk"
        CType(Me.TABEL1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TABEL1 As System.Windows.Forms.DataGridView
    Friend WithEvents btntutup As MetroFramework.Controls.MetroButton
    Friend WithEvents btnsimpan As MetroFramework.Controls.MetroButton
    Friend WithEvents btnhapus As MetroFramework.Controls.MetroButton
    Friend WithEvents btntambah As MetroFramework.Controls.MetroButton
    Friend WithEvents txtkode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbukti As System.Windows.Forms.TextBox
    Friend WithEvents txturaian As System.Windows.Forms.TextBox
    Friend WithEvents txttanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtpenerimaan As System.Windows.Forms.TextBox
    Friend WithEvents LBLTOTAL As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As MetroFramework.Controls.MetroButton
End Class
