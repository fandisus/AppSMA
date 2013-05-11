Imports System.IO
Imports SistemAkademikSman.BusinessObject

Public Class ListSiswa

    Private isAddNew As Boolean
    Private recordId As Integer

    Private Sub SearchState()
        ButtonTambah.Enabled = False
        ButtonSimpan.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = False
        ClearAllField()
        SetControl(False)
        TextBoxNama.Enabled = True
        TextBoxNIP.Enabled = True
        ButtonCariNama.Enabled = True
        ButtonCariNis.Enabled = True
    End Sub

    Private Sub InsertState()
        ButtonTambah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonCari.Enabled = False
        ButtonCariNama.Enabled = False
        ButtonCariNis.Enabled = False
        isAddNew = True
    End Sub

    Private Sub EditState()
        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonCari.Enabled = False
        ButtonCariNama.Enabled = False
        ButtonCariNis.Enabled = False
        isAddNew = False
    End Sub

    Private Sub ViewState()
        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonCari.Enabled = True
        ButtonCariNama.Enabled = False
        ButtonCariNis.Enabled = False
    End Sub

    Private Sub SetControl(ByVal value As Boolean)
        For Each control As Control In From control1 As Control In SplitContainer1.Panel1.Controls Where Not (TypeOf control1 Is Button) And Not (TypeOf control1 Is Label)
            control.Enabled = value
        Next
    End Sub

    Private Sub LoadList()
        DataGridView1.DataSource = SiswaBusinessObject.GetList()
    End Sub

    Private Sub ClearAllField()
        For Each control As Control In From control1 As Control In SplitContainer1.Panel1.Controls Where Not (TypeOf control1 Is Button) And Not (TypeOf control1 Is Label)
            control.Text = ""
        Next
        PictureBoxPhoto.Image = Nothing
    End Sub

    Private Sub LoadRecord()
        If DataGridView1.CurrentRow Is Nothing Then
            Return
        End If
        recordId = Convert.ToInt32(DataGridView1.CurrentRow.Cells("ID").Value)
        Dim siswa = SiswaBusinessObject.GetSiswa(recordId)
        If siswa Is Nothing Then
            Return
        End If
        PopulateData(siswa)
    End Sub

    Private Sub PopulateData(ByVal siswa As MasterSiswa)

        TextBoxAlamat.Text = siswa.Alamat
        TextBoxEmail.Text = siswa.Email
        TextBoxHP.Text = siswa.NoHP
        TextBoxKodepos.Text = siswa.KodePos
        TextBoxKota.Text = siswa.Kota
        TextBoxNIP.Text = siswa.NIS
        TextBoxNama.Text = siswa.Nama
        TextBoxTelephone.Text = siswa.NoTelephone
        TextBoxTempatLahir.Text = siswa.TempatLahir
        ComboBoxAgama.Text = siswa.Agama
        ComboBoxJenisKelamin.Text = siswa.JenisKelamin
        DateTimePickerLahir.Value = siswa.TanggalLahir
        If Not siswa.Photo Is Nothing Then
            Using memstearm As New MemoryStream(siswa.Photo)
                PictureBoxPhoto.Image = Image.FromStream(memstearm)
            End Using
        End If
        TextBoxNamaSmpAsal.Text = siswa.NamaSMPAsal
        DateTimePickerMasuk.Value = siswa.TanggalMasuk
        TextBoxNamaAyah.Text = siswa.NamaAyah
        TextBoxNamaIbu.Text = siswa.NamaIbu
        TextBoxAlamatOrtu.Text = siswa.AlamatOrangTua
        TextBoxKotaOrtu.Text = siswa.KotaOrangTua
        TextBoxKodeposOrtu.Text = siswa.KodePosOrangTua
        TextBoxTelpOrtu.Text = siswa.NoTelephoneOrangTua
        TextBoxHpOrtu.Text = siswa.NoHPOrangTua
        SetControl(False)
    End Sub

    Private Sub ListSiswaLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        TextBoxNIP.Focus()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = SiswaBusinessObject.GetList()
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridViewSelectionChanged
    End Sub

    Private Sub DataGridViewSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        ViewState()
        LoadRecord()
    End Sub

    Private Sub ButtonRefreshClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        LoadList()
    End Sub

    Private Sub ButtonTambahClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonTambah.Click
        InsertState()
        ClearAllField()
        SetControl(True)
    End Sub

    Private Sub ButtonUbahClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonUbah.Click
        EditState()
        SetControl(True)
    End Sub

    Private Sub ButtonHapusClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonHapus.Click
        If MessageBox.Show(Me, "Hapus data Siswa " + TextBoxNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            SiswaBusinessObject.DeleteSiswa(recordId)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, AppHelpers.GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonSimpanClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonSimpan.Click
        If isAddNew Then
            InsertSiswa()
        Else
            UpdateSiswa()
        End If
    End Sub

    Private Sub InsertSiswa()
        If MessageBox.Show(Me, "Simpan data Siswa " + TextBoxNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim siswa As New MasterSiswa
            PopulateSiswa(siswa)
            SiswaBusinessObject.InsertSiswa(siswa)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, AppHelpers.GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub PopulateSiswa(ByVal siswa As MasterSiswa)
        siswa.Agama = ComboBoxAgama.Text
        siswa.Alamat = TextBoxAlamat.Text
        siswa.Email = TextBoxEmail.Text
        siswa.JenisKelamin = ComboBoxJenisKelamin.Text
        siswa.KodePos = TextBoxKodepos.Text
        siswa.Kota = TextBoxKota.Text
        siswa.NIS = TextBoxNIP.Text
        siswa.Nama = TextBoxNama.Text
        siswa.NoHP = TextBoxHP.Text
        siswa.NoTelephone = TextBoxTelephone.Text
        Dim photo As Image
        If PictureBoxPhoto.Image Is Nothing Then
            photo = Image.FromFile(Application.StartupPath + "\resume-photo.jpg")
            Using imgMemoryStream As MemoryStream = New MemoryStream()
                photo.Save(imgMemoryStream, Imaging.ImageFormat.Jpeg)
                Dim imgByteArray = imgMemoryStream.GetBuffer()
                siswa.Photo = imgByteArray
            End Using
        Else
            Dim bmp As New Bitmap(PictureBoxPhoto.Image)
            Using imgMemoryStream As MemoryStream = New MemoryStream()
                bmp.Save(imgMemoryStream, Imaging.ImageFormat.Jpeg)
                Dim imgByteArray = imgMemoryStream.GetBuffer()
                siswa.Photo = imgByteArray
            End Using
        End If

        siswa.TanggalLahir = DateTimePickerLahir.Value.Date
        siswa.TempatLahir = TextBoxTempatLahir.Text
        siswa.TanggalMasuk = DateTimePickerMasuk.Value.Date
        siswa.NamaSMPAsal = TextBoxNamaSmpAsal.Text
        siswa.NamaAyah = TextBoxNamaAyah.Text
        siswa.NamaIbu = TextBoxNamaIbu.Text
        siswa.AlamatOrangTua = TextBoxAlamatOrtu.Text
        siswa.KotaOrangTua = TextBoxKotaOrtu.Text
        siswa.KodePosOrangTua = TextBoxKodeposOrtu.Text
        siswa.NoTelephoneOrangTua = TextBoxTelpOrtu.Text
        siswa.NoHPOrangTua = TextBoxHpOrtu.Text
    End Sub

    Private Sub UpdateSiswa()
        If MessageBox.Show(Me, "Update data Siswa " + TextBoxNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim siswa As New MasterSiswa
            PopulateSiswa(siswa)
            siswa.ID = recordId
            SiswaBusinessObject.UpdateSiswa(siswa)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, AppHelpers.GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonPhotoClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonPhoto.Click
        Using dialog = New OpenFileDialog
            dialog.Filter = "JPEG Files|*.jpg;*.jpeg;"
            dialog.InitialDirectory = Environment.SpecialFolder.MyDocuments
            dialog.Title = "Pilih File Photo Siswa"
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                PictureBoxPhoto.Image = Image.FromFile(dialog.FileName)
            End If
        End Using
    End Sub

    Private Sub ButtonCariClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonCari.Click
        SearchState()
        TextBoxNama.Select()
    End Sub

    Private Sub ButtonCariNamaClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonCariNama.Click
        DataGridView1.DataSource = SiswaBusinessObject.GetListByName(TextBoxNama.Text)
    End Sub

    Private Sub ButtonCariNisClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonCariNis.Click
        DataGridView1.DataSource = SiswaBusinessObject.GetListByNis(TextBoxNIP.Text)
    End Sub
End Class