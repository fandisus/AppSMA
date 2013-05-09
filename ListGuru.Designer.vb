<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListGuru
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NIP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GuruID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.JenisKelamin = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TempatLahir = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TanggalLahir = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Agama = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Alamat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kota = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KodePos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoTelephone = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NoHP = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ButtonCari = New System.Windows.Forms.Button
        Me.ButtonCariNama = New System.Windows.Forms.Button
        Me.ButtonMataPelajaran = New System.Windows.Forms.Button
        Me.ButtonRefresh = New System.Windows.Forms.Button
        Me.ButtonHapus = New System.Windows.Forms.Button
        Me.ButtonSimpan = New System.Windows.Forms.Button
        Me.ButtonUbah = New System.Windows.Forms.Button
        Me.ButtonTambah = New System.Windows.Forms.Button
        Me.ButtonPhoto = New System.Windows.Forms.Button
        Me.PictureBoxPhoto = New System.Windows.Forms.PictureBox
        Me.TextBoxHP = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBoxTelephone = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBoxKodepos = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBoxKota = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBoxEmail = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ComboBoxAgama = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.DateTimePickerLahir = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBoxTempatLahir = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBoxJenisKelamin = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxNama = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TextBoxNIP = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBoxPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NIP, Me.GuruID, Me.Nama, Me.JenisKelamin, Me.TempatLahir, Me.TanggalLahir, Me.Agama, Me.Email, Me.Alamat, Me.Kota, Me.KodePos, Me.NoTelephone, Me.NoHP})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(876, 318)
        Me.DataGridView1.TabIndex = 1
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'NIP
        '
        Me.NIP.DataPropertyName = "NIP"
        Me.NIP.HeaderText = "NIP"
        Me.NIP.Name = "NIP"
        Me.NIP.ReadOnly = True
        Me.NIP.Width = 75
        '
        'GuruID
        '
        Me.GuruID.DataPropertyName = "GuruID"
        Me.GuruID.HeaderText = "ID"
        Me.GuruID.Name = "GuruID"
        Me.GuruID.ReadOnly = True
        Me.GuruID.Width = 45
        '
        'Nama
        '
        Me.Nama.DataPropertyName = "Nama"
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.ReadOnly = True
        Me.Nama.Width = 120
        '
        'JenisKelamin
        '
        Me.JenisKelamin.DataPropertyName = "JenisKelamin"
        Me.JenisKelamin.HeaderText = "Jenis Kelamin"
        Me.JenisKelamin.Name = "JenisKelamin"
        Me.JenisKelamin.ReadOnly = True
        '
        'TempatLahir
        '
        Me.TempatLahir.DataPropertyName = "TempatLahir"
        Me.TempatLahir.HeaderText = "Tempat Lahir"
        Me.TempatLahir.Name = "TempatLahir"
        Me.TempatLahir.ReadOnly = True
        Me.TempatLahir.Width = 130
        '
        'TanggalLahir
        '
        Me.TanggalLahir.DataPropertyName = "TanggalLahir"
        Me.TanggalLahir.HeaderText = "Tanggal Lahir"
        Me.TanggalLahir.Name = "TanggalLahir"
        Me.TanggalLahir.ReadOnly = True
        '
        'Agama
        '
        Me.Agama.DataPropertyName = "Agama"
        Me.Agama.HeaderText = "Agama"
        Me.Agama.Name = "Agama"
        Me.Agama.ReadOnly = True
        Me.Agama.Width = 115
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 210
        '
        'Alamat
        '
        Me.Alamat.DataPropertyName = "Alamat"
        Me.Alamat.HeaderText = "Alamat"
        Me.Alamat.Name = "Alamat"
        Me.Alamat.ReadOnly = True
        Me.Alamat.Width = 210
        '
        'Kota
        '
        Me.Kota.DataPropertyName = "Kota"
        Me.Kota.HeaderText = "Kota"
        Me.Kota.Name = "Kota"
        Me.Kota.ReadOnly = True
        Me.Kota.Width = 120
        '
        'KodePos
        '
        Me.KodePos.DataPropertyName = "KodePos"
        Me.KodePos.HeaderText = "KodePos"
        Me.KodePos.Name = "KodePos"
        Me.KodePos.ReadOnly = True
        Me.KodePos.Width = 60
        '
        'NoTelephone
        '
        Me.NoTelephone.DataPropertyName = "NoTelephone"
        Me.NoTelephone.HeaderText = "Telephone"
        Me.NoTelephone.Name = "NoTelephone"
        Me.NoTelephone.ReadOnly = True
        '
        'NoHP
        '
        Me.NoHP.DataPropertyName = "NoHP"
        Me.NoHP.HeaderText = "HP"
        Me.NoHP.Name = "NoHP"
        Me.NoHP.ReadOnly = True
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
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonCari)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonCariNama)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonMataPelajaran)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonRefresh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonHapus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonSimpan)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonUbah)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonTambah)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonPhoto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBoxPhoto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxHP)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxTelephone)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxKodepos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxKota)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxAlamat)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxEmail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBoxAgama)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePickerLahir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxTempatLahir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBoxJenisKelamin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxNama)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxNIP)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(876, 592)
        Me.SplitContainer1.SplitterDistance = 270
        Me.SplitContainer1.TabIndex = 2
        '
        'ButtonCari
        '
        Me.ButtonCari.Location = New System.Drawing.Point(543, 234)
        Me.ButtonCari.Name = "ButtonCari"
        Me.ButtonCari.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCari.TabIndex = 56
        Me.ButtonCari.Text = "&Cari"
        Me.ButtonCari.UseVisualStyleBackColor = True
        '
        'ButtonCariNama
        '
        Me.ButtonCariNama.Location = New System.Drawing.Point(369, 39)
        Me.ButtonCariNama.Name = "ButtonCariNama"
        Me.ButtonCariNama.Size = New System.Drawing.Size(37, 23)
        Me.ButtonCariNama.TabIndex = 55
        Me.ButtonCariNama.Text = "&Cari"
        Me.ButtonCariNama.UseVisualStyleBackColor = True
        '
        'ButtonMataPelajaran
        '
        Me.ButtonMataPelajaran.Location = New System.Drawing.Point(423, 234)
        Me.ButtonMataPelajaran.Name = "ButtonMataPelajaran"
        Me.ButtonMataPelajaran.Size = New System.Drawing.Size(114, 23)
        Me.ButtonMataPelajaran.TabIndex = 33
        Me.ButtonMataPelajaran.Text = "Set &Mata Pelajaran"
        Me.ButtonMataPelajaran.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(342, 234)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 32
        Me.ButtonRefresh.Text = "&Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(258, 234)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 31
        Me.ButtonHapus.Text = "&Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(174, 234)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 30
        Me.ButtonSimpan.Text = "&Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(93, 234)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUbah.TabIndex = 29
        Me.ButtonUbah.Text = "&Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(12, 234)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 28
        Me.ButtonTambah.Text = "&Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'ButtonPhoto
        '
        Me.ButtonPhoto.Location = New System.Drawing.Point(826, 229)
        Me.ButtonPhoto.Name = "ButtonPhoto"
        Me.ButtonPhoto.Size = New System.Drawing.Size(27, 23)
        Me.ButtonPhoto.TabIndex = 27
        Me.ButtonPhoto.Text = "..."
        Me.ButtonPhoto.UseVisualStyleBackColor = True
        '
        'PictureBoxPhoto
        '
        Me.PictureBoxPhoto.Location = New System.Drawing.Point(699, 123)
        Me.PictureBoxPhoto.Name = "PictureBoxPhoto"
        Me.PictureBoxPhoto.Size = New System.Drawing.Size(121, 129)
        Me.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxPhoto.TabIndex = 26
        Me.PictureBoxPhoto.TabStop = False
        '
        'TextBoxHP
        '
        Me.TextBoxHP.Location = New System.Drawing.Point(702, 93)
        Me.TextBoxHP.Name = "TextBoxHP"
        Me.TextBoxHP.Size = New System.Drawing.Size(133, 21)
        Me.TextBoxHP.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(676, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(20, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "HP"
        '
        'TextBoxTelephone
        '
        Me.TextBoxTelephone.Location = New System.Drawing.Point(532, 93)
        Me.TextBoxTelephone.Name = "TextBoxTelephone"
        Me.TextBoxTelephone.Size = New System.Drawing.Size(133, 21)
        Me.TextBoxTelephone.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(469, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Telephone"
        '
        'TextBoxKodepos
        '
        Me.TextBoxKodepos.Location = New System.Drawing.Point(730, 66)
        Me.TextBoxKodepos.Name = "TextBoxKodepos"
        Me.TextBoxKodepos.Size = New System.Drawing.Size(123, 21)
        Me.TextBoxKodepos.TabIndex = 21
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(676, 69)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Kodepos"
        '
        'TextBoxKota
        '
        Me.TextBoxKota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxKota.Location = New System.Drawing.Point(532, 66)
        Me.TextBoxKota.Name = "TextBoxKota"
        Me.TextBoxKota.Size = New System.Drawing.Size(133, 21)
        Me.TextBoxKota.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(497, 69)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Kota"
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxAlamat.Location = New System.Drawing.Point(532, 12)
        Me.TextBoxAlamat.Multiline = True
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(321, 48)
        Me.TextBoxAlamat.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(486, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Alamat"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(105, 174)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(207, 21)
        Me.TextBoxEmail.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(68, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Email"
        '
        'ComboBoxAgama
        '
        Me.ComboBoxAgama.FormattingEnabled = True
        Me.ComboBoxAgama.Items.AddRange(New Object() {"Islam", "Khatolik", "Kristen", "Budha", "Hindu", "Kong Hu-Cu", "Aliran Kepercayaan"})
        Me.ComboBoxAgama.Location = New System.Drawing.Point(105, 147)
        Me.ComboBoxAgama.Name = "ComboBoxAgama"
        Me.ComboBoxAgama.Size = New System.Drawing.Size(133, 21)
        Me.ComboBoxAgama.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Agama"
        '
        'DateTimePickerLahir
        '
        Me.DateTimePickerLahir.CustomFormat = "dd MMMM yyyy"
        Me.DateTimePickerLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerLahir.Location = New System.Drawing.Point(105, 120)
        Me.DateTimePickerLahir.Name = "DateTimePickerLahir"
        Me.DateTimePickerLahir.Size = New System.Drawing.Size(133, 21)
        Me.DateTimePickerLahir.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tanggal Lahir"
        '
        'TextBoxTempatLahir
        '
        Me.TextBoxTempatLahir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxTempatLahir.Location = New System.Drawing.Point(105, 93)
        Me.TextBoxTempatLahir.Name = "TextBoxTempatLahir"
        Me.TextBoxTempatLahir.Size = New System.Drawing.Size(133, 21)
        Me.TextBoxTempatLahir.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tempat Lahir"
        '
        'ComboBoxJenisKelamin
        '
        Me.ComboBoxJenisKelamin.FormattingEnabled = True
        Me.ComboBoxJenisKelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan"})
        Me.ComboBoxJenisKelamin.Location = New System.Drawing.Point(105, 66)
        Me.ComboBoxJenisKelamin.Name = "ComboBoxJenisKelamin"
        Me.ComboBoxJenisKelamin.Size = New System.Drawing.Size(133, 21)
        Me.ComboBoxJenisKelamin.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Jenis Kelamin"
        '
        'TextBoxNama
        '
        Me.TextBoxNama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNama.Location = New System.Drawing.Point(105, 39)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(258, 21)
        Me.TextBoxNama.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nama"
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(273, 12)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(133, 21)
        Me.TextBoxID.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID"
        '
        'TextBoxNIP
        '
        Me.TextBoxNIP.Location = New System.Drawing.Point(105, 12)
        Me.TextBoxNIP.Name = "TextBoxNIP"
        Me.TextBoxNIP.Size = New System.Drawing.Size(133, 21)
        Me.TextBoxNIP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'ListGuru
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(876, 592)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ListGuru"
        Me.ShowInTaskbar = False
        Me.Text = "Data Guru"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBoxPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNIP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKota As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxAgama As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerLahir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTempatLahir As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxJenisKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonPhoto As System.Windows.Forms.Button
    Friend WithEvents PictureBoxPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxHP As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTelephone As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKodepos As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GuruID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JenisKelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TempatLahir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggalLahir As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Agama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Alamat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KodePos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoTelephone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoHP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonMataPelajaran As System.Windows.Forms.Button
    Friend WithEvents ButtonCari As System.Windows.Forms.Button
    Friend WithEvents ButtonCariNama As System.Windows.Forms.Button
End Class
