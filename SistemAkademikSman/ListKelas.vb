Imports SistemAkademikSman.BusinessObject

Public Class ListKelas

    Private isAddNew As Boolean
    Private recordId As Integer

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
        DataGridView1.DataSource = KelasBusinessObject.GetList()
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
        Dim kelas = KelasBusinessObject.GetKelas(recordId)
        If kelas Is Nothing Then
            Return
        End If
        TextBoxKelas.Text = kelas.NamaKelas
        TextBoxKeterangan.Text = kelas.Keterangan
        TextBoxTahunAjaran.Text = kelas.TahunAjaran
        TextBoxTingkat.Text = kelas.Tingkat
        SetControl(False)
    End Sub

    Private Sub ListKelasLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        TextBoxTahunAjaran.Focus()
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = KelasBusinessObject.GetList()
        AddHandler DataGridView1.SelectionChanged, AddressOf DataGridViewSelectionChanged
    End Sub

    Private Sub DataGridViewSelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
        ViewState()
        LoadRecord()
    End Sub

    Private Shared Sub TextBoxTahunAjaranKeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles TextBoxTahunAjaran.KeyPress, TextBoxTingkat.KeyPress
        If ".1234567890".IndexOf(e.KeyChar.ToString(), StringComparison.Ordinal) > 0 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
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

    Private Sub ButtonSimpanClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonSimpan.Click
        If isAddNew Then
            InsertKelas()
        Else
            UpdateKelas()
        End If
    End Sub

    Private Sub ButtonHapusClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonHapus.Click
        If MessageBox.Show(Me, "Hapus data kelas " + TextBoxKelas.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            KelasBusinessObject.DeleteKelas(recordId)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonRefreshClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        LoadList()
    End Sub

    Private Sub InsertKelas()
        If MessageBox.Show(Me, "Simpan data kelas " + TextBoxKelas.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim kelas As New MasterKelas
            PopulateKelas(kelas)
            KelasBusinessObject.InsertKelas(kelas)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub PopulateKelas(ByVal kelas As MasterKelas)
        kelas.Keterangan = TextBoxKeterangan.Text
        kelas.NamaKelas = TextBoxKelas.Text
        kelas.TahunAjaran = TextBoxTahunAjaran.Text
        kelas.Tingkat = TextBoxTingkat.Text
    End Sub

    Private Sub UpdateKelas()
        If MessageBox.Show(Me, "Update data kelas " + TextBoxKelas.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If
        Try
            Dim kelas As New MasterKelas
            PopulateKelas(kelas)
            kelas.ID = recordId
            KelasBusinessObject.UpdateKelas(kelas)
            LoadList()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class