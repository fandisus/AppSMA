<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataSiswaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataGuruToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataKelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataMataPelajaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.JadwalMataPelajaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PenjurusanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataMasterToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.ReportToolStripMenuItem, Me.WindowToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(856, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'DataMasterToolStripMenuItem
        '
        Me.DataMasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataSiswaToolStripMenuItem, Me.DataGuruToolStripMenuItem, Me.DataKaryawanToolStripMenuItem, Me.DataKelasToolStripMenuItem, Me.DataMataPelajaranToolStripMenuItem})
        Me.DataMasterToolStripMenuItem.Name = "DataMasterToolStripMenuItem"
        Me.DataMasterToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.DataMasterToolStripMenuItem.Text = "&Data Master"
        '
        'DataSiswaToolStripMenuItem
        '
        Me.DataSiswaToolStripMenuItem.Name = "DataSiswaToolStripMenuItem"
        Me.DataSiswaToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DataSiswaToolStripMenuItem.Text = "Data &Siswa"
        '
        'DataGuruToolStripMenuItem
        '
        Me.DataGuruToolStripMenuItem.Name = "DataGuruToolStripMenuItem"
        Me.DataGuruToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DataGuruToolStripMenuItem.Text = "Data &Guru"
        '
        'DataKaryawanToolStripMenuItem
        '
        Me.DataKaryawanToolStripMenuItem.Name = "DataKaryawanToolStripMenuItem"
        Me.DataKaryawanToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DataKaryawanToolStripMenuItem.Text = "Data &Karyawan"
        '
        'DataKelasToolStripMenuItem
        '
        Me.DataKelasToolStripMenuItem.Name = "DataKelasToolStripMenuItem"
        Me.DataKelasToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DataKelasToolStripMenuItem.Text = "Data Ke&las"
        '
        'DataMataPelajaranToolStripMenuItem
        '
        Me.DataMataPelajaranToolStripMenuItem.Name = "DataMataPelajaranToolStripMenuItem"
        Me.DataMataPelajaranToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.DataMataPelajaranToolStripMenuItem.Text = "Data &Mata Pelajaran"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JadwalMataPelajaranToolStripMenuItem, Me.PenjurusanToolStripMenuItem})
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.TransaksiToolStripMenuItem.Text = "&Transaksi"
        '
        'JadwalMataPelajaranToolStripMenuItem
        '
        Me.JadwalMataPelajaranToolStripMenuItem.Name = "JadwalMataPelajaranToolStripMenuItem"
        Me.JadwalMataPelajaranToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.JadwalMataPelajaranToolStripMenuItem.Text = "&Jadwal Mata Pelajaran"
        '
        'PenjurusanToolStripMenuItem
        '
        Me.PenjurusanToolStripMenuItem.Name = "PenjurusanToolStripMenuItem"
        Me.PenjurusanToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.PenjurusanToolStripMenuItem.Text = "&Penjurusan"
        '
        'ReportToolStripMenuItem
        '
        Me.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem"
        Me.ReportToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ReportToolStripMenuItem.Text = "&Report"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "&Window"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(856, 457)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Sistem Akademik SMAN 5 Jakarta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataSiswaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGuruToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JadwalMataPelajaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenjurusanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataKelasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataMataPelajaranToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
