<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReportKelasParameter
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
        Me.ComboBoxTingkat = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxTahunAngkatan = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtonClose = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ComboBoxTingkat
        '
        Me.ComboBoxTingkat.FormattingEnabled = True
        Me.ComboBoxTingkat.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBoxTingkat.Location = New System.Drawing.Point(110, 51)
        Me.ComboBoxTingkat.Name = "ComboBoxTingkat"
        Me.ComboBoxTingkat.Size = New System.Drawing.Size(100, 21)
        Me.ComboBoxTingkat.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Kelas"
        '
        'TextBoxTahunAngkatan
        '
        Me.TextBoxTahunAngkatan.Location = New System.Drawing.Point(110, 24)
        Me.TextBoxTahunAngkatan.Name = "TextBoxTahunAngkatan"
        Me.TextBoxTahunAngkatan.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTahunAngkatan.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tahun Ajaran"
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(255, 147)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(75, 23)
        Me.ButtonClose.TabIndex = 14
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(174, 147)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "View"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormReportKelasParameter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 183)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ComboBoxTingkat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxTahunAngkatan)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormReportKelasParameter"
        Me.ShowInTaskbar = False
        Me.Text = "Form Report Kelas Parameter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBoxTingkat As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTahunAngkatan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
