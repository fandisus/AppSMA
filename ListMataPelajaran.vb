Imports SistemAkademikSman.BusinessObject

Public Class ListMataPelajaran

    Private isAddNew As Boolean
    Private recordId As Integer
    Private _isadmin As Boolean

    Public Property IsAdministrator() As Boolean
        Get
            Return _isadmin
        End Get
        Set(ByVal value As Boolean)
            _isadmin = value
        End Set
    End Property

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
        DataGridView1.DataSource = MataPelajaraBusinessObject.GetList()
    End Sub

    Private Sub ClearAllField()
        For Each control As Control In From control1 As Control In SplitContainer1.Panel1.Controls Where Not (TypeOf control1 Is Button) And Not (TypeOf control1 Is Label)
            control.Text = ""
        Next
    End Sub

    Private Sub LoadRecord()
        If DataGridView1.CurrentRow Is Nothing Then
            Return
        End If
        recordId = Convert.ToInt32(DataGridView1.CurrentRow.Cells("ID").Value)
        Dim kelas = MataPelajaraBusinessObject.GetMataPelajaran(recordId)
        If kelas Is Nothing Then
            Return
        End If
        TextBoxMataPelajaran.Text = kelas.MataPelajaran
        TextBoxSilabus.Text = kelas.Silabus
        TextBoxTahunAjaran.Text = kelas.TahunAjaran
        SetControl(False)
    End Sub

    Private Sub TextBoxTahunAjaran_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxTahunAjaran.KeyPress
        If ".1234567890".IndexOf(e.KeyChar.ToString(), StringComparison.Ordinal) > 0 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub ListMataPelajaranLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

        TextBoxTahunAjaran.Focus()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = MataPelajaraBusinessObject.GetList()
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridViewSelectionChanged
        
        
    End Sub

    Private Sub DataGridViewSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        ViewState()
        LoadRecord()
        If Not IsAdministrator Then
            ButtonHapus.Enabled = IsAdministrator
            ButtonTambah.Enabled = IsAdministrator
            ButtonSimpan.Enabled = IsAdministrator
            ButtonUbah.Enabled = IsAdministrator
        End If
    End Sub

    Private Sub ButtonTambahClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonTambah.Click
        InsertState()
        ClearAllField()
        SetControl(True)
    End Sub

    Private Sub ButtonRefreshClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        LoadList()
    End Sub

    Private Sub ButtonUbahClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonUbah.Click
        EditState()
        SetControl(True)
    End Sub

    Private Sub ButtonSimpanClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonSimpan.Click
        If isAddNew Then
            InsertMataPelajaran()
        Else
            UpdateMataPelajaran()
        End If
    End Sub

    Private Sub ButtonHapusClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonHapus.Click
        If MessageBox.Show(Me, "Hapus data kelas " + TextBoxMataPelajaran.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            MataPelajaraBusinessObject.DeleteMataPelajaran(recordId)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub InsertMataPelajaran()
        If MessageBox.Show(Me, "Simpan data mata pelajaran " + TextBoxMataPelajaran.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim masterMataPelajaran As New MasterMataPelajaran
            PopulateMataPelajaran(masterMataPelajaran)
            MataPelajaraBusinessObject.InsertMataPelajaran(masterMataPelajaran)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateMataPelajaran(ByVal mataPelajaran As MasterMataPelajaran)
        mataPelajaran.Silabus = TextBoxSilabus.Text
        mataPelajaran.MataPelajaran = TextBoxMataPelajaran.Text
        MataPelajaran.TahunAjaran = TextBoxTahunAjaran.Text
    End Sub

    Private Sub UpdateMataPelajaran()
        If MessageBox.Show(Me, "Update data mata pelajaran " + TextBoxMataPelajaran.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim masterMataPelajaran As New MasterMataPelajaran
            PopulateMataPelajaran(masterMataPelajaran)
            masterMataPelajaran.ID = recordId
            MataPelajaraBusinessObject.UpdateMataPelajaran(masterMataPelajaran)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class