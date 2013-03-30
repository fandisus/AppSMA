<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListKelas
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ButtonRefresh = New System.Windows.Forms.Button
        Me.ButtonHapus = New System.Windows.Forms.Button
        Me.ButtonSimpan = New System.Windows.Forms.Button
        Me.ButtonUbah = New System.Windows.Forms.Button
        Me.ButtonTambah = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxKeterangan = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxKelas = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxTingkat = New System.Windows.Forms.TextBox
        Me.TextBoxTahunAjaran = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TahunAjaran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tingkat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaKelas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Keterangan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonRefresh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonHapus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonSimpan)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonUbah)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonTambah)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxKeterangan)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxKelas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxTingkat)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxTahunAjaran)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(897, 581)
        Me.SplitContainer1.SplitterDistance = 175
        Me.SplitContainer1.TabIndex = 0
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(357, 137)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 32
        Me.ButtonRefresh.Text = "&Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(273, 137)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 31
        Me.ButtonHapus.Text = "&Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(189, 137)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 30
        Me.ButtonSimpan.Text = "&Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(108, 137)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUbah.TabIndex = 29
        Me.ButtonUbah.Text = "&Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(27, 137)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 28
        Me.ButtonTambah.Text = "&Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Keterangan"
        '
        'TextBoxKeterangan
        '
        Me.TextBoxKeterangan.Location = New System.Drawing.Point(108, 97)
        Me.TextBoxKeterangan.Name = "TextBoxKeterangan"
        Me.TextBoxKeterangan.Size = New System.Drawing.Size(380, 21)
        Me.TextBoxKeterangan.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Kelas"
        '
        'TextBoxKelas
        '
        Me.TextBoxKelas.Location = New System.Drawing.Point(108, 70)
        Me.TextBoxKelas.Name = "TextBoxKelas"
        Me.TextBoxKelas.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxKelas.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Kelas / Tingkat"
        '
        'TextBoxTingkat
        '
        Me.TextBoxTingkat.Location = New System.Drawing.Point(108, 43)
        Me.TextBoxTingkat.Name = "TextBoxTingkat"
        Me.TextBoxTingkat.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxTingkat.TabIndex = 2
        '
        'TextBoxTahunAjaran
        '
        Me.TextBoxTahunAjaran.Location = New System.Drawing.Point(108, 16)
        Me.TextBoxTahunAjaran.Name = "TextBoxTahunAjaran"
        Me.TextBoxTahunAjaran.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxTahunAjaran.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tahun Ajaran"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.TahunAjaran, Me.Tingkat, Me.NamaKelas, Me.Keterangan})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(897, 402)
        Me.DataGridView1.TabIndex = 0
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'TahunAjaran
        '
        Me.TahunAjaran.DataPropertyName = "TahunAjaran"
        Me.TahunAjaran.HeaderText = "Tahun Ajaran"
        Me.TahunAjaran.Name = "TahunAjaran"
        Me.TahunAjaran.ReadOnly = True
        '
        'Tingkat
        '
        Me.Tingkat.DataPropertyName = "Tingkat"
        Me.Tingkat.HeaderText = "Kelas/Tingkat"
        Me.Tingkat.Name = "Tingkat"
        Me.Tingkat.ReadOnly = True
        '
        'NamaKelas
        '
        Me.NamaKelas.DataPropertyName = "NamaKelas"
        Me.NamaKelas.HeaderText = "Nama Kelas"
        Me.NamaKelas.Name = "NamaKelas"
        Me.NamaKelas.ReadOnly = True
        '
        'Keterangan
        '
        Me.Keterangan.DataPropertyName = "Keterangan"
        Me.Keterangan.HeaderText = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ReadOnly = True
        Me.Keterangan.Width = 400
        '
        'ListKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(897, 581)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ListKelas"
        Me.ShowInTaskbar = False
        Me.Text = "Data Kelas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBoxTahunAjaran As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKelas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTingkat As System.Windows.Forms.TextBox
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TahunAjaran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tingkat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaKelas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Keterangan As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
