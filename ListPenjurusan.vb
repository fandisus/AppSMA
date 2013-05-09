Imports SistemAkademikSman.BusinessObject

Public Class ListPenjurusan


    Private isAddNew As Boolean
    Private recordId As Integer
    Private siswaId As Integer
    Private mkelasid As Integer

    Private Sub InsertState()
        ButtonTambah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = False
        ButtonSimpan.Enabled = True
        isAddNew = True
    End Sub

    Private Sub EditState()
        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = False
        ButtonSimpan.Enabled = True
        isAddNew = False
    End Sub

    Private Sub ViewState()
        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
    End Sub

    Private Sub SetControl(ByVal value As Boolean)
        For Each control As Control In From control1 As Control In SplitContainer1.Panel1.Controls Where (TypeOf control1 Is TextBox)
            CType(control, TextBox).ReadOnly = value
        Next
        TextBoxNamaSiswa.ReadOnly = True
        TextBoxRatarata.ReadOnly = True
        TextBoxJurusan.ReadOnly = True
    End Sub

    Private Sub ClearAllField()
        For Each control As Control In From control1 As Control In SplitContainer1.Panel1.Controls Where (TypeOf control1 Is TextBox)
            control.Text = ""
        Next
    End Sub

    Private Sub LoadRecord()
        If DataGridView1.CurrentRow Is Nothing Then
            Return
        End If
        recordId = Convert.ToInt32(DataGridView1.CurrentRow.Cells("ID").Value)
        Dim mpenjurusan = PenjurusanBusinessObject.GetPenjurusan(recordId)
        If mpenjurusan Is Nothing Then
            Return
        End If
        TextBoxTahunAjaran.Text = mpenjurusan.TahunAjaran
        TextBoxNamaSiswa.Text = mpenjurusan.MasterSiswa.Nama
        TextBoxNis.Text = mpenjurusan.MasterSiswa.NIS
        TextBoxBahasaIndonesia.Text = mpenjurusan.BahasaIndonesia.ToString("#,###")
        TextBoxBahasaInggris.Text = mpenjurusan.BahasaInggris.ToString("#,###")
        TextBoxMatematika.Text = mpenjurusan.Matematika.ToString("#,###")
        TextBoxFisika.Text = mpenjurusan.Fisika.ToString("#,###")
        TextBoxKimia.Text = mpenjurusan.Kimia.ToString("#,###")
        TextBoxBiologi.Text = mpenjurusan.Biologi.ToString("#,###")
        TextBoxEkonomi.Text = mpenjurusan.Ekonomi.ToString("#,###")
        TextBoxGeografi.Text = mpenjurusan.Geografi.ToString("#,###")
        TextBoxSosiologi.Text = mpenjurusan.Sosiologi.ToString("#,###")
        TextBoxRatarata.Text = mpenjurusan.NilaiRataRata
        TextBoxJurusan.Text = mpenjurusan.Jurusan
        siswaId = mpenjurusan.MasterSiswa.ID
        mkelasid = If(mpenjurusan.MasterKelas Is Nothing, 0, mpenjurusan.MasterKelas.ID)
        SetControl(True)
    End Sub

    Private Sub LoadList()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = PenjurusanBusinessObject.GetList()
    End Sub

    Private Sub ListPenjurusanLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadList()
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridViewSelectionChanged
    End Sub

    Private Sub DataGridViewSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        ViewState()
        LoadRecord()
    End Sub

    Private Sub TextBoxTahunAjaranKeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles TextBoxTahunAjaran.KeyPress, TextBoxBahasaIndonesia.KeyPress, TextBoxBahasaInggris.KeyPress, TextBoxMatematika.KeyPress, TextBoxFisika.KeyPress, TextBoxKimia.KeyPress, TextBoxBiologi.KeyPress, TextBoxEkonomi.KeyPress, TextBoxGeografi.KeyPress, TextBoxSosiologi.KeyPress, TextBoxRatarata.KeyPress, TextBoxRatarata.KeyPress
        If Char.IsNumber(e.KeyChar) Or Convert.ToChar(Keys.Back) = e.KeyChar Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub ButtonTambahClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonTambah.Click
        InsertState()
        ClearAllField()
        SetControl(False)
        TextBoxTahunAjaran.Text = DateTime.Now.Year.ToString()
    End Sub

    Private Sub ButtonUbahClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonUbah.Click
        EditState()
        SetControl(False)
    End Sub

    Private Sub ButtonSimpanClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonSimpan.Click
        If isAddNew Then
            InsertKelas()
        Else
            UpdateKelas()
        End If
    End Sub

    Private Sub UpdateKelas()
        If MessageBox.Show(Me, "Update data penjurusan " + TextBoxNamaSiswa.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim mjurusan As New Penjurusan
            PopulatePenjurusan(mjurusan)
            mjurusan.ID = recordId
            PenjurusanBusinessObject.UpdatePenjurusan(mjurusan)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertKelas()
        If MessageBox.Show(Me, "Simpan data penjurusan " + TextBoxNamaSiswa.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim mjurusan As New Penjurusan
            PopulatePenjurusan(mjurusan)
            PenjurusanBusinessObject.InsertPenjurusan(mjurusan)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulatePenjurusan(ByVal mPenjurusan As Penjurusan)
        With mPenjurusan
            .BahasaIndonesia = Convert.ToDecimal(TextBoxBahasaIndonesia.Text)
            .BahasaInggris = Convert.ToDecimal(TextBoxBahasaInggris.Text)
            .TahunAjaran = Convert.ToInt32(TextBoxTahunAjaran.Text)
            .Biologi = Convert.ToDecimal(TextBoxBiologi.Text)
            .Ekonomi = Convert.ToDecimal(TextBoxEkonomi.Text)
            .Fisika = Convert.ToDecimal(TextBoxFisika.Text)
            .Geografi = Convert.ToDecimal(TextBoxGeografi.Text)
            .Jurusan = TextBoxJurusan.Text
            .Kimia = Convert.ToDecimal(TextBoxKimia.Text)
            .MasterKelas = If(mkelasid = 0, Nothing, New MasterKelas() With {.ID = mkelasid})
            .MasterSiswa = New MasterSiswa() With {.ID = siswaId, .NIS = TextBoxNis.Text, .Nama = TextBoxNamaSiswa.Text}
            .Matematika = Convert.ToDecimal(TextBoxMatematika.Text)
            .NilaiRataRata = HitungNilaiRataRata()
            .Sosiologi = Convert.ToDecimal(TextBoxSosiologi.Text)
            .TanggalPenilaian = DateTime.Now
        End With
    End Sub

    Private Function HitungNilaiRataRata() As Decimal
        Try
            Dim a = (Convert.ToDecimal(TextBoxBahasaIndonesia.Text) + _
                Convert.ToDecimal(TextBoxBahasaInggris.Text) + _
                Convert.ToDecimal(TextBoxMatematika.Text) + _
                Convert.ToDecimal(TextBoxKimia.Text) + _
                Convert.ToDecimal(TextBoxFisika.Text) + _
                Convert.ToDecimal(TextBoxBiologi.Text)) / 6
            If a = 0 Then
                TextBoxJurusan.Text = ""
            Else
                If a < 70 Then
                    TextBoxJurusan.Text = "IPS"
                Else
                    TextBoxJurusan.Text = "IPA"
                End If
                Return a
            End If
        Catch ex As Exception
            Return 0
        End Try
        
    End Function

    Private Sub ButtonHapusClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonHapus.Click
        If MessageBox.Show(Me, "Hapus data penjurusan " + TextBoxNamaSiswa.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            PenjurusanBusinessObject.DeletePenjurusan(recordId)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonRefreshClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        LoadList()
    End Sub

    Private Sub TextBoxNisKeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles TextBoxNis.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim siswa = SiswaBusinessObject.GetSiswa(TextBoxNis.Text)
            If siswa Is Nothing Then
                Throw New Exception("Siswa dengan no NIS " + TextBoxNis.Text + " tidak ditemukan didatabase")
            End If
            TextBoxNamaSiswa.Text = siswa.Nama
            siswaId = siswa.ID
        End If
    End Sub


    Private Sub TextBoxBahasaIndonesiaTextChanged(ByVal sender As System.Object, ByVal e As EventArgs) Handles TextBoxBahasaIndonesia.TextChanged, TextBoxBahasaInggris.TextChanged, TextBoxMatematika.TextChanged, TextBoxFisika.TextChanged, TextBoxKimia.TextChanged, TextBoxBiologi.TextChanged
        TextBoxRatarata.Text = HitungNilaiRataRata().ToString("#.###,##")
    End Sub

    Private Sub ButtonGeneratePembagianKelasClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonGeneratePembagianKelas.Click
        Dim mform As New FormGeneratePembagianKelas
        mform.ShowDialog(Me)
    End Sub

    Private Sub ButtonLaporanClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonLaporan.Click
        Dim cform As New FormReportKelasParameter
        cform.MdiParent = MainForm
        cform.Show()
    End Sub
End Class