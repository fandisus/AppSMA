Imports System.IO
Imports SistemAkademikSman.BusinessObject

Public Class ListKaryawan

    Private isAddNew As Boolean
    Private recordId As Integer

    Private Sub ListKaryawanLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        TextBoxNIP.Focus()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = KaryawanBusinessObject.GetList()
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridViewSelectionChanged
    End Sub

    Private Sub DataGridViewSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        ViewState()
        LoadRecord()
    End Sub

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
        For Each control As Control In From control1 As Control In SplitContainer1.Panel1.Controls Where Not (TypeOf control1 Is Button) And Not (TypeOf control1 Is Label)
            control.Enabled = value
        Next
    End Sub

    Private Sub LoadList()
        DataGridView1.DataSource = KaryawanBusinessObject.GetList()
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
        Dim karyawan = KaryawanBusinessObject.GetKaryawan(recordId)
        If karyawan Is Nothing Then
            Return
        End If
        TextBoxAlamat.Text = karyawan.Alamat
        TextBoxEmail.Text = karyawan.Email
        TextBoxHP.Text = karyawan.NoHP
        TextBoxID.Text = karyawan.KaryawanID
        TextBoxKodepos.Text = karyawan.KodePos
        TextBoxKota.Text = karyawan.Kota
        TextBoxNIP.Text = karyawan.NIP
        TextBoxNama.Text = karyawan.Nama
        TextBoxTelephone.Text = karyawan.NoTelephone
        TextBoxTempatLahir.Text = karyawan.TempatLahir
        ComboBoxAgama.Text = karyawan.Agama
        ComboBoxJenisKelamin.Text = karyawan.JenisKelamin
        DateTimePickerLahir.Value = karyawan.TanggalLahir
        If Not karyawan.Photo Is Nothing Then
            Using memstearm As New MemoryStream(karyawan.Photo)
                PictureBoxPhoto.Image = Image.FromStream(memstearm)
            End Using
        End If

        SetControl(False)
    End Sub

    Private Sub ButtonPhotoClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonPhoto.Click
        Using dialog = New OpenFileDialog
            dialog.Filter = "JPEG Files|*.jpg;*.jpeg;"
            dialog.InitialDirectory = Environment.SpecialFolder.MyDocuments
            dialog.Title = "Pilih File Photo Karyawan"
            If dialog.ShowDialog(Me) = DialogResult.OK Then
                PictureBoxPhoto.Image = Image.FromFile(dialog.FileName)
            End If
        End Using
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

    Private Sub ButtonRefreshClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        LoadList()
    End Sub

    Private Sub ButtonSimpanClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonSimpan.Click
        If isAddNew Then
            InsertKaryawan()
        Else
            UpdateKaryawan()
        End If
    End Sub

    Private Sub ButtonHapusClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonHapus.Click
        If MessageBox.Show(Me, "Hapus data Karyawan " + TextBoxNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            KaryawanBusinessObject.DeleteKaryawan(recordId)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, AppHelpers.GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertKaryawan()
        If MessageBox.Show(Me, "Simpan data Karyawan " + TextBoxNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim karyawan As New MasterKaryawan
            PopulateKaryawan(karyawan)
            KaryawanBusinessObject.InsertKaryawan(karyawan)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, AppHelpers.GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub PopulateKaryawan(ByVal mguru As MasterKaryawan)
        mguru.Agama = ComboBoxAgama.Text
        mguru.Alamat = TextBoxAlamat.Text
        mguru.Email = TextBoxEmail.Text
        mguru.KaryawanID = TextBoxID.Text
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

    Private Sub UpdateKaryawan()
        If MessageBox.Show(Me, "Update data Karyawan " + TextBoxNama.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim karyawan As New MasterKaryawan
            PopulateKaryawan(karyawan)
            karyawan.ID = recordId
            KaryawanBusinessObject.UpdateKaryawan(karyawan)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, AppHelpers.GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class