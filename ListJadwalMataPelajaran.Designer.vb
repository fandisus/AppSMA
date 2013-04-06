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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TahunAjaran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KelasID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaKelas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jurusan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hari = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ButtonInput = New System.Windows.Forms.Button
        Me.ButtonEdit = New System.Windows.Forms.Button
        Me.ButtonDelete = New System.Windows.Forms.Button
        Me.ButtonRefresh = New System.Windows.Forms.Button
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
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonRefresh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonDelete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonInput)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(903, 468)
        Me.SplitContainer1.SplitterDistance = 47
        Me.SplitContainer1.TabIndex = 2
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
        Me.DataGridView1.Size = New System.Drawing.Size(903, 417)
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
        'ButtonInput
        '
        Me.ButtonInput.Location = New System.Drawing.Point(12, 12)
        Me.ButtonInput.Name = "ButtonInput"
        Me.ButtonInput.Size = New System.Drawing.Size(75, 23)
        Me.ButtonInput.TabIndex = 0
        Me.ButtonInput.Text = "Input"
        Me.ButtonInput.UseVisualStyleBackColor = True
        '
        'ButtonEdit
        '
        Me.ButtonEdit.Location = New System.Drawing.Point(93, 12)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit.TabIndex = 1
        Me.ButtonEdit.Text = "Edit"
        Me.ButtonEdit.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(174, 12)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 2
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(255, 12)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 3
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ListJadwalMataPelajaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(903, 468)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ListJadwalMataPelajaran"
        Me.ShowInTaskbar = False
        Me.Text = "List Jadwal Mata Pelajaran"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TahunAjaran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KelasID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaKelas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hari As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonEdit As System.Windows.Forms.Button
    Friend WithEvents ButtonInput As System.Windows.Forms.Button
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
End Class
