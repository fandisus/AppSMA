Imports System.IO
Imports SistemAkademikSman.GuruServiceReference

Public Class ListGuru

    Private isAddNew As Boolean
    Private recordId As Integer
    Private Sub ListGuruLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        TextBoxNIP.Focus()
        DataGridView1.AutoGenerateColumns = False
        Try
            Using d = New MasterGuruServiceSoapClient()
                DataGridView1.DataSource = d.GetAllGuru().ToList()
                AddHandler DataGridView1.SelectionChanged, AddressOf DataGridViewSelectionChanged
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SearchState()
        ButtonTambah.Enabled = False
        ButtonSimpan.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = False
        ClearAllField()
        SetControl(False)
        TextBoxNama.Enabled = True
        ButtonCariNama.Enabled = True
    End Sub

    Private Sub InsertState()
        ButtonTambah.Enabled = False
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonMataPelajaran.Enabled = False
        ButtonCariNama.Enabled = False
        isAddNew = True
    End Sub

    Private Sub EditState()
        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = True
        ButtonUbah.Enabled = False
        ButtonSimpan.Enabled = True
        ButtonMataPelajaran.Enabled = True
        ButtonCariNama.Enabled = False
        isAddNew = False
    End Sub

    Private Sub ViewState()
        ButtonTambah.Enabled = True
        ButtonHapus.Enabled = False
        ButtonUbah.Enabled = True
        ButtonSimpan.Enabled = False
        ButtonMataPelajaran.Enabled = True
        ButtonCariNama.Enabled = False
    End Sub

    Private Sub DataGridViewSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        ViewState()
        LoadRecord()
    End Sub

    Private Sub LoadRecord()
        If DataGridView1.CurrentRow Is Nothing Then
            Return
        End If
        recordId = Convert.ToInt32(DataGridView1.CurrentRow.Cells("ID").Value)
        Dim mguru As GuruModel
        Using service = New MasterGuruServiceSoapClient()
            mguru = service.GetGuru(recordId)
        End Using
        If mguru Is Nothing Then
            Return
        End If
        TextBoxAlamat.Text = mguru.Alamat
        TextBoxEmail.Text = mguru.Email
        TextBoxHP.Text = mguru.NoHP
        TextBoxID.Text = mguru.GuruID
        TextBoxKodepos.Text = mguru.KodePos
        TextBoxKota.Text = mguru.Kota
        TextBoxNIP.Text = mguru.NIP
        TextBoxNama.Text = mguru.Nama
        TextBoxTelephone.Text = mguru.NoTelephone
        TextBoxTempatLahir.Text = mguru.TempatLahir
        ComboBoxAgama.Text = mguru.Agama
        ComboBoxJenisKelamin.Text = mguru.JenisKelamin
        DateTimePickerLahir.Value = mguru.TanggalLahir
        Using memstearm As New MemoryStream(mguru.Photo)
            PictureBoxPhoto.Image = Image.FromStream(memstearm)
        End Using
        SetControl(False)
    End Sub

    Private Sub ClearAllField()
        For Each control As Control In From control1 As Control In SplitContainer1.Panel1.Controls Where Not (TypeOf control1 Is Button) And Not (TypeOf control1 Is Label)
            control.Text = ""
        Next
        PictureBoxPhoto.Image = Nothing
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

    Private Sub SetControl(ByVal value As Boolean)

        For Each control As Control In From control1 As Control In SplitContainer1.Panel1.Controls Where Not (TypeOf control1 Is Button) And Not (TypeOf control1 Is Label)
            control.Enabled = value
        Next
    End Sub

    Private Sub ButtonRefreshClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        LoadList()
    End Sub

    Private Sub LoadList()
        Using masterGuruServiceSoapClient = New MasterGuruServiceSoapClient()
            DataGridView1.DataSource = masterGuruServiceSoapClient.GetAllGuru()
        End Using
    End Sub

    Private Sub ButtonSimpanClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonSimpan.Click
        If isAddNew Then
            InsertGuru()
        Else
            UpdateGuru()
        End If
    End Sub

    Private Sub InsertGuru()
        If MessageBox.Show(Me, "Simpan data Guru " + TextBoxNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim mguru As New GuruModel
            PopulateGuru(mguru)
            Using masterGuruServiceSoapClient = New MasterGuruServiceSoapClient()
                masterGuruServiceSoapClient.SaveGuru(mguru)
            End Using
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub PopulateGuru(ByVal mguru As GuruModel)
        mguru.Agama = ComboBoxAgama.Text
        mguru.Alamat = TextBoxAlamat.Text
        mguru.Email = TextBoxEmail.Text
        mguru.GuruID = TextBoxID.Text
        mguru.JenisKelamin = ComboBoxJenisKelamin.Text
        mguru.KodePos = TextBoxKodepos.Text
        mguru.Kota = TextBoxKota.Text
        mguru.NIP = TextBoxNIP.Text
        mguru.Nama = TextBoxNama.Text
        mguru.NoHP = TextBoxHP.Text
        mguru.NoTelephone = TextBoxTelephone.Text
        Dim photo As Image
        If PictureBoxPhoto.Image Is Nothing Then
            photo = Image.FromFile(Application.StartupPath + "\resume-photo.jpg")
            Using imgMemoryStream As MemoryStream = New MemoryStream()
                photo.Save(imgMemoryStream, Imaging.ImageFormat.Jpeg)
                Dim imgByteArray = imgMemoryStream.GetBuffer()
                mguru.Photo = imgByteArray
            End Using
        Else
            Dim bmp As New Bitmap(PictureBoxPhoto.Image)
            Using imgMemoryStream As MemoryStream = New MemoryStream()
                bmp.Save(imgMemoryStream, Imaging.ImageFormat.Jpeg)
                Dim imgByteArray = imgMemoryStream.GetBuffer()
                mguru.Photo = imgByteArray
            End Using
        End If
        mguru.TanggalLahir = DateTimePickerLahir.Value.Date
        mguru.TempatLahir = TextBoxTempatLahir.Text
    End Sub

    Private Sub UpdateGuru()
        If MessageBox.Show(Me, "Update data Guru " + TextBoxNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim mguru As New GuruModel
            PopulateGuru(mguru)
            mguru.ID = recordId
            Using masterGuruServiceSoapClient = New MasterGuruServiceSoapClient()
                masterGuruServiceSoapClient.UpdateGuru(mguru)
            End Using

            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonPhotoClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonPhoto.Click
        Using dialog = New OpenFileDialog
            dialog.Filter = "JPEG Files|*.jpg;*.jpeg;"
            dialog.InitialDirectory = Environment.SpecialFolder.MyDocuments
            dialog.Title = "Pilih File Photo Guru"
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                PictureBoxPhoto.Image = Image.FromFile(dialog.FileName)
            End If
        End Using
    End Sub

    Private Sub ButtonHapusClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonHapus.Click
        If MessageBox.Show(Me, "Hapus data Guru " + TextBoxNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Using masterGuruServiceSoapClient = New MasterGuruServiceSoapClient()
                masterGuruServiceSoapClient.DeleteGuru(recordId)
            End Using
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

   
    Private Sub ButtonMataPelajaranClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonMataPelajaran.Click
        Using dfrom As New ListGuruMataPelajaran
            dfrom.GuruId = recordId
            dfrom.ShowDialog(Me)
        End Using
    End Sub

    Private Sub ButtonCariClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonCari.Click
        SearchState()
        TextBoxNama.Select()
    End Sub

    Private Sub ButtonCariNamaClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonCariNama.Click
        Using masterGuruServiceSoapClient = New MasterGuruServiceSoapClient()
            masterGuruServiceSoapClient.GetGuruByName(TextBoxNama.Text)
        End Using
    End Sub
End Class