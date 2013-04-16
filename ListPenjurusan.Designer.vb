<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListPenjurusan
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
        Me.ButtonGeneratePembagianKelas = New System.Windows.Forms.Button
        Me.TextBoxTahunAjaran = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TextBoxJurusan = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBoxRatarata = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TextBoxSosiologi = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBoxGeografi = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBoxEkonomi = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TextBoxBiologi = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TextBoxKimia = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TextBoxFisika = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBoxMatematika = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBoxBahasaInggris = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBoxBahasaIndonesia = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ButtonRefresh = New System.Windows.Forms.Button
        Me.ButtonHapus = New System.Windows.Forms.Button
        Me.ButtonSimpan = New System.Windows.Forms.Button
        Me.ButtonUbah = New System.Windows.Forms.Button
        Me.ButtonTambah = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBoxNamaSiswa = New System.Windows.Forms.TextBox
        Me.TextBoxNis = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NIS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nama = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NamaKelas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TahunAjaran = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BahasaIndonesia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BahasaInggris = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Matematika = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Fisika = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Kimia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Biologi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ekonomi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Geografi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Sosiologi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NilaiRataRata = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TanggalPenilaian = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jurusan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.KelasID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ButtonLaporan = New System.Windows.Forms.Button
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonLaporan)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonGeneratePembagianKelas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxTahunAjaran)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxJurusan)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxRatarata)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxSosiologi)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxGeografi)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxEkonomi)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxBiologi)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxKimia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxFisika)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxMatematika)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxBahasaInggris)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxBahasaIndonesia)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonRefresh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonHapus)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonSimpan)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonUbah)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonTambah)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxNamaSiswa)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxNis)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(979, 616)
        Me.SplitContainer1.SplitterDistance = 258
        Me.SplitContainer1.TabIndex = 2
        '
        'ButtonGeneratePembagianKelas
        '
        Me.ButtonGeneratePembagianKelas.Location = New System.Drawing.Point(438, 219)
        Me.ButtonGeneratePembagianKelas.Name = "ButtonGeneratePembagianKelas"
        Me.ButtonGeneratePembagianKelas.Size = New System.Drawing.Size(152, 23)
        Me.ButtonGeneratePembagianKelas.TabIndex = 56
        Me.ButtonGeneratePembagianKelas.Text = "Generate Pembagian Kelas"
        Me.ButtonGeneratePembagianKelas.UseVisualStyleBackColor = True
        '
        'TextBoxTahunAjaran
        '
        Me.TextBoxTahunAjaran.Location = New System.Drawing.Point(108, 12)
        Me.TextBoxTahunAjaran.Name = "TextBoxTahunAjaran"
        Me.TextBoxTahunAjaran.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxTahunAjaran.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(29, 15)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Tahun Ajaran"
        '
        'TextBoxJurusan
        '
        Me.TextBoxJurusan.Location = New System.Drawing.Point(314, 188)
        Me.TextBoxJurusan.Name = "TextBoxJurusan"
        Me.TextBoxJurusan.ReadOnly = True
        Me.TextBoxJurusan.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxJurusan.TabIndex = 54
        Me.TextBoxJurusan.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(264, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Jurusan"
        '
        'TextBoxRatarata
        '
        Me.TextBoxRatarata.Location = New System.Drawing.Point(108, 188)
        Me.TextBoxRatarata.Name = "TextBoxRatarata"
        Me.TextBoxRatarata.ReadOnly = True
        Me.TextBoxRatarata.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxRatarata.TabIndex = 52
        Me.TextBoxRatarata.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(51, 191)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Rata-rata"
        '
        'TextBoxSosiologi
        '
        Me.TextBoxSosiologi.Location = New System.Drawing.Point(529, 144)
        Me.TextBoxSosiologi.Name = "TextBoxSosiologi"
        Me.TextBoxSosiologi.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxSosiologi.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(473, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Sosiologi"
        '
        'TextBoxGeografi
        '
        Me.TextBoxGeografi.Location = New System.Drawing.Point(529, 118)
        Me.TextBoxGeografi.Name = "TextBoxGeografi"
        Me.TextBoxGeografi.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxGeografi.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(471, 121)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Geografi"
        '
        'TextBoxEkonomi
        '
        Me.TextBoxEkonomi.Location = New System.Drawing.Point(529, 92)
        Me.TextBoxEkonomi.Name = "TextBoxEkonomi"
        Me.TextBoxEkonomi.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxEkonomi.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(473, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Ekonomi"
        '
        'TextBoxBiologi
        '
        Me.TextBoxBiologi.Location = New System.Drawing.Point(314, 144)
        Me.TextBoxBiologi.Name = "TextBoxBiologi"
        Me.TextBoxBiologi.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxBiologi.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(270, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Biologi"
        '
        'TextBoxKimia
        '
        Me.TextBoxKimia.Location = New System.Drawing.Point(314, 118)
        Me.TextBoxKimia.Name = "TextBoxKimia"
        Me.TextBoxKimia.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxKimia.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(276, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Kimia"
        '
        'TextBoxFisika
        '
        Me.TextBoxFisika.Location = New System.Drawing.Point(314, 92)
        Me.TextBoxFisika.Name = "TextBoxFisika"
        Me.TextBoxFisika.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxFisika.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(274, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Fisika"
        '
        'TextBoxMatematika
        '
        Me.TextBoxMatematika.Location = New System.Drawing.Point(108, 144)
        Me.TextBoxMatematika.Name = "TextBoxMatematika"
        Me.TextBoxMatematika.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxMatematika.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Matematika"
        '
        'TextBoxBahasaInggris
        '
        Me.TextBoxBahasaInggris.Location = New System.Drawing.Point(108, 118)
        Me.TextBoxBahasaInggris.Name = "TextBoxBahasaInggris"
        Me.TextBoxBahasaInggris.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxBahasaInggris.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Bahasa Inggris"
        '
        'TextBoxBahasaIndonesia
        '
        Me.TextBoxBahasaIndonesia.Location = New System.Drawing.Point(108, 92)
        Me.TextBoxBahasaIndonesia.Name = "TextBoxBahasaIndonesia"
        Me.TextBoxBahasaIndonesia.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxBahasaIndonesia.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Bahasa Indonesia"
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Location = New System.Drawing.Point(357, 219)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRefresh.TabIndex = 15
        Me.ButtonRefresh.Text = "&Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonHapus
        '
        Me.ButtonHapus.Location = New System.Drawing.Point(273, 219)
        Me.ButtonHapus.Name = "ButtonHapus"
        Me.ButtonHapus.Size = New System.Drawing.Size(75, 23)
        Me.ButtonHapus.TabIndex = 14
        Me.ButtonHapus.Text = "&Hapus"
        Me.ButtonHapus.UseVisualStyleBackColor = True
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Location = New System.Drawing.Point(189, 219)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSimpan.TabIndex = 13
        Me.ButtonSimpan.Text = "&Simpan"
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'ButtonUbah
        '
        Me.ButtonUbah.Location = New System.Drawing.Point(108, 219)
        Me.ButtonUbah.Name = "ButtonUbah"
        Me.ButtonUbah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUbah.TabIndex = 12
        Me.ButtonUbah.Text = "&Ubah"
        Me.ButtonUbah.UseVisualStyleBackColor = True
        '
        'ButtonTambah
        '
        Me.ButtonTambah.Location = New System.Drawing.Point(27, 219)
        Me.ButtonTambah.Name = "ButtonTambah"
        Me.ButtonTambah.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTambah.TabIndex = 11
        Me.ButtonTambah.Text = "&Tambah"
        Me.ButtonTambah.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama Siswa"
        '
        'TextBoxNamaSiswa
        '
        Me.TextBoxNamaSiswa.Location = New System.Drawing.Point(108, 66)
        Me.TextBoxNamaSiswa.Name = "TextBoxNamaSiswa"
        Me.TextBoxNamaSiswa.ReadOnly = True
        Me.TextBoxNamaSiswa.Size = New System.Drawing.Size(306, 21)
        Me.TextBoxNamaSiswa.TabIndex = 4
        Me.TextBoxNamaSiswa.TabStop = False
        '
        'TextBoxNis
        '
        Me.TextBoxNis.Location = New System.Drawing.Point(108, 39)
        Me.TextBoxNis.Name = "TextBoxNis"
        Me.TextBoxNis.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxNis.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(77, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIS"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NIS, Me.Nama, Me.NamaKelas, Me.TahunAjaran, Me.BahasaIndonesia, Me.BahasaInggris, Me.Matematika, Me.Fisika, Me.Kimia, Me.Biologi, Me.Ekonomi, Me.Geografi, Me.Sosiologi, Me.NilaiRataRata, Me.TanggalPenilaian, Me.Jurusan, Me.KelasID})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(979, 354)
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
        'NIS
        '
        Me.NIS.DataPropertyName = "NIS"
        Me.NIS.HeaderText = "NIS"
        Me.NIS.Name = "NIS"
        Me.NIS.ReadOnly = True
        '
        'Nama
        '
        Me.Nama.DataPropertyName = "Nama"
        Me.Nama.HeaderText = "Nama"
        Me.Nama.Name = "Nama"
        Me.Nama.ReadOnly = True
        '
        'NamaKelas
        '
        Me.NamaKelas.DataPropertyName = "NamaKelas"
        Me.NamaKelas.HeaderText = "NamaKelas"
        Me.NamaKelas.Name = "NamaKelas"
        Me.NamaKelas.ReadOnly = True
        '
        'TahunAjaran
        '
        Me.TahunAjaran.DataPropertyName = "TahunAjaran"
        Me.TahunAjaran.HeaderText = "TahunAjaran"
        Me.TahunAjaran.Name = "TahunAjaran"
        Me.TahunAjaran.ReadOnly = True
        '
        'BahasaIndonesia
        '
        Me.BahasaIndonesia.DataPropertyName = "BahasaIndonesia"
        Me.BahasaIndonesia.HeaderText = "BahasaIndonesia"
        Me.BahasaIndonesia.Name = "BahasaIndonesia"
        Me.BahasaIndonesia.ReadOnly = True
        '
        'BahasaInggris
        '
        Me.BahasaInggris.DataPropertyName = "BahasaInggris"
        Me.BahasaInggris.HeaderText = "BahasaInggris"
        Me.BahasaInggris.Name = "BahasaInggris"
        Me.BahasaInggris.ReadOnly = True
        '
        'Matematika
        '
        Me.Matematika.DataPropertyName = "Matematika"
        Me.Matematika.HeaderText = "Matematika"
        Me.Matematika.Name = "Matematika"
        Me.Matematika.ReadOnly = True
        '
        'Fisika
        '
        Me.Fisika.DataPropertyName = "Fisika"
        Me.Fisika.HeaderText = "Fisika"
        Me.Fisika.Name = "Fisika"
        Me.Fisika.ReadOnly = True
        '
        'Kimia
        '
        Me.Kimia.DataPropertyName = "Kimia"
        Me.Kimia.HeaderText = "Kimia"
        Me.Kimia.Name = "Kimia"
        Me.Kimia.ReadOnly = True
        '
        'Biologi
        '
        Me.Biologi.DataPropertyName = "Biologi"
        Me.Biologi.HeaderText = "Biologi"
        Me.Biologi.Name = "Biologi"
        Me.Biologi.ReadOnly = True
        '
        'Ekonomi
        '
        Me.Ekonomi.DataPropertyName = "Ekonomi"
        Me.Ekonomi.HeaderText = "Ekonomi"
        Me.Ekonomi.Name = "Ekonomi"
        Me.Ekonomi.ReadOnly = True
        '
        'Geografi
        '
        Me.Geografi.DataPropertyName = "Geografi"
        Me.Geografi.HeaderText = "Geografi"
        Me.Geografi.Name = "Geografi"
        Me.Geografi.ReadOnly = True
        '
        'Sosiologi
        '
        Me.Sosiologi.DataPropertyName = "Sosiologi"
        Me.Sosiologi.HeaderText = "Sosiologi"
        Me.Sosiologi.Name = "Sosiologi"
        Me.Sosiologi.ReadOnly = True
        '
        'NilaiRataRata
        '
        Me.NilaiRataRata.DataPropertyName = "NilaiRataRata"
        Me.NilaiRataRata.HeaderText = "NilaiRataRata"
        Me.NilaiRataRata.Name = "NilaiRataRata"
        Me.NilaiRataRata.ReadOnly = True
        '
        'TanggalPenilaian
        '
        Me.TanggalPenilaian.DataPropertyName = "TanggalPenilaian"
        Me.TanggalPenilaian.HeaderText = "TanggalPenilaian"
        Me.TanggalPenilaian.Name = "TanggalPenilaian"
        Me.TanggalPenilaian.ReadOnly = True
        '
        'Jurusan
        '
        Me.Jurusan.DataPropertyName = "Jurusan"
        Me.Jurusan.HeaderText = "Jurusan"
        Me.Jurusan.Name = "Jurusan"
        Me.Jurusan.ReadOnly = True
        '
        'KelasID
        '
        Me.KelasID.DataPropertyName = "KelasID"
        Me.KelasID.HeaderText = "KelasID"
        Me.KelasID.Name = "KelasID"
        Me.KelasID.ReadOnly = True
        Me.KelasID.Visible = False
        '
        'ButtonLaporan
        '
        Me.ButtonLaporan.Location = New System.Drawing.Point(596, 219)
        Me.ButtonLaporan.Name = "ButtonLaporan"
        Me.ButtonLaporan.Size = New System.Drawing.Size(106, 23)
        Me.ButtonLaporan.TabIndex = 57
        Me.ButtonLaporan.Text = "Laporan"
        Me.ButtonLaporan.UseVisualStyleBackColor = True
        '
        'ListPenjurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 616)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "ListPenjurusan"
        Me.Text = "Form Penjurusan"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ButtonRefresh As System.Windows.Forms.Button
    Friend WithEvents ButtonHapus As System.Windows.Forms.Button
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
    Friend WithEvents ButtonUbah As System.Windows.Forms.Button
    Friend WithEvents ButtonTambah As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNamaSiswa As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNis As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxSosiologi As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBoxGeografi As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxEkonomi As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBiologi As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKimia As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFisika As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMatematika As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBahasaInggris As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxBahasaIndonesia As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxJurusan As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRatarata As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NIS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NamaKelas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TahunAjaran As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BahasaIndonesia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BahasaInggris As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Matematika As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fisika As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Kimia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Biologi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ekonomi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Geografi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sosiologi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NilaiRataRata As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TanggalPenilaian As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KelasID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TextBoxTahunAjaran As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ButtonGeneratePembagianKelas As System.Windows.Forms.Button
    Friend WithEvents ButtonLaporan As System.Windows.Forms.Button
End Class
