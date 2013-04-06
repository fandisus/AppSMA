<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListJadwalMataPelajaran
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
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxSilabus = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxMataPelajaran = New System.Windows.Forms.TextBox
        Me.TextBoxTahunAjaran = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TahunAjaran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KelasID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaKelas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jurusan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hari = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxSilabus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxMataPelajaran)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxTahunAjaran)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(903, 468)
        Me.SplitContainer1.SplitterDistance = 175
        Me.SplitContainer1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Silabus"
        '
        'TextBoxSilabus
        '
        Me.TextBoxSilabus.Location = New System.Drawing.Point(108, 70)
        Me.TextBoxSilabus.Multiline = True
        Me.TextBoxSilabus.Name = "TextBoxSilabus"
        Me.TextBoxSilabus.Size = New System.Drawing.Size(380, 61)
        Me.TextBoxSilabus.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Kelas"
        '
        'TextBoxMataPelajaran
        '
        Me.TextBoxMataPelajaran.Location = New System.Drawing.Point(108, 43)
        Me.TextBoxMataPelajaran.Name = "TextBoxMataPelajaran"
        Me.TextBoxMataPelajaran.Size = New System.Drawing.Size(240, 20)
        Me.TextBoxMataPelajaran.TabIndex = 4
        '
        'TextBoxTahunAjaran
        '
        Me.TextBoxTahunAjaran.Location = New System.Drawing.Point(108, 16)
        Me.TextBoxTahunAjaran.Name = "TextBoxTahunAjaran"
        Me.TextBoxTahunAjaran.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTahunAjaran.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tahun Ajaran"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.TahunAjaran, Me.KelasID, Me.NamaKelas, Me.Jurusan, Me.Hari})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(903, 289)
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
        'KelasID
        '
        Me.KelasID.DataPropertyName = "KelasID"
        Me.KelasID.HeaderText = "KelasID"
        Me.KelasID.Name = "KelasID"
        Me.KelasID.ReadOnly = True
        Me.KelasID.Visible = False
        '
        'NamaKelas
        '
        Me.NamaKelas.DataPropertyName = "NamaKelas"
        Me.NamaKelas.HeaderText = "Kelas"
        Me.NamaKelas.Name = "NamaKelas"
        Me.NamaKelas.ReadOnly = True
        '
        'Jurusan
        '
        Me.Jurusan.DataPropertyName = "Jurusan"
        Me.Jurusan.HeaderText = "Jurusan"
        Me.Jurusan.Name = "Jurusan"
        Me.Jurusan.ReadOnly = True
        '
        'Hari
        '
        Me.Hari.DataPropertyName = "Hari"
        Me.Hari.HeaderText = "Hari"
        Me.Hari.Name = "Hari"
        Me.Hari.ReadOnly = True
        '
        'ListJadwalMataPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 468)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ListJadwalMataPelajaran"
        Me.ShowInTaskbar = False
        Me.Text = "List Jadwal Mata Pelajaran"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSilabus As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMataPelajaran As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTahunAjaran As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TahunAjaran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KelasID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaKelas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hari As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
