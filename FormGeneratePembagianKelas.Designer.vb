<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGeneratePembagianKelas
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxTahunAjaran = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxTahunAngkatan = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CheckBoxPenjurusan = New System.Windows.Forms.CheckBox
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.ButtonGenerate = New System.Windows.Forms.Button
        Me.ComboBoxTingkat = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tahun Ajaran"
        '
        'TextBoxTahunAjaran
        '
        Me.TextBoxTahunAjaran.Location = New System.Drawing.Point(121, 21)
        Me.TextBoxTahunAjaran.Name = "TextBoxTahunAjaran"
        Me.TextBoxTahunAjaran.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxTahunAjaran.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tahun Angkatan "
        '
        'TextBoxTahunAngkatan
        '
        Me.TextBoxTahunAngkatan.Location = New System.Drawing.Point(121, 48)
        Me.TextBoxTahunAngkatan.Name = "TextBoxTahunAngkatan"
        Me.TextBoxTahunAngkatan.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxTahunAngkatan.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Tingkat / Kelas"
        '
        'CheckBoxPenjurusan
        '
        Me.CheckBoxPenjurusan.AutoSize = True
        Me.CheckBoxPenjurusan.Location = New System.Drawing.Point(121, 107)
        Me.CheckBoxPenjurusan.Name = "CheckBoxPenjurusan"
        Me.CheckBoxPenjurusan.Size = New System.Drawing.Size(203, 17)
        Me.CheckBoxPenjurusan.TabIndex = 6
        Me.CheckBoxPenjurusan.Text = "Pembagian Kelas Dengan Penjurusan"
        Me.CheckBoxPenjurusan.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(377, 221)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 7
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'ButtonGenerate
        '
        Me.ButtonGenerate.Location = New System.Drawing.Point(296, 221)
        Me.ButtonGenerate.Name = "ButtonGenerate"
        Me.ButtonGenerate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonGenerate.TabIndex = 8
        Me.ButtonGenerate.Text = "Generate"
        Me.ButtonGenerate.UseVisualStyleBackColor = True
        '
        'ComboBoxTingkat
        '
        Me.ComboBoxTingkat.FormattingEnabled = True
        Me.ComboBoxTingkat.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBoxTingkat.Location = New System.Drawing.Point(121, 75)
        Me.ComboBoxTingkat.Name = "ComboBoxTingkat"
        Me.ComboBoxTingkat.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxTingkat.TabIndex = 9
        '
        'FormGeneratePembagianKelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(464, 256)
        Me.Controls.Add(Me.ComboBoxTingkat)
        Me.Controls.Add(Me.ButtonGenerate)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.CheckBoxPenjurusan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxTahunAngkatan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxTahunAjaran)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FormGeneratePembagianKelas"
        Me.ShowInTaskbar = False
        Me.Text = "Form Generate Pembagian Kelas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTahunAjaran As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTahunAngkatan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxPenjurusan As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents ButtonGenerate As System.Windows.Forms.Button
    Friend WithEvents ComboBoxTingkat As System.Windows.Forms.ComboBox
End Class
