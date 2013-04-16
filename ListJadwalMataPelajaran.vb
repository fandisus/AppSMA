Imports SistemAkademikSman.BusinessObject

Public Class ListJadwalMataPelajaran

    Dim currentid As Integer
    Private _isadmin As Boolean

    Public Property IsAdministrator() As Boolean
        Get
            Return _isadmin
        End Get
        Set(ByVal value As Boolean)
            _isadmin = value
        End Set
    End Property

    Private Sub ListJadwalMataPelajaranLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadData()
        ButtonDelete.Enabled = IsAdministrator
        ButtonEdit.Enabled = IsAdministrator
        ButtonInput.Enabled = IsAdministrator
    End Sub

    Friend Sub LoadData()
        DataGridView1.DataSource = JadwalMataPelajaranBusinessObject.ListJadwalMataPelajaran()
    End Sub

    Private Sub ButtonInputClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonInput.Click
        Dim formPenerimaanBarang As New EditorJadwalMataPelajaran
        formPenerimaanBarang.MdiParent = MainForm
        formPenerimaanBarang.ListForm = Me
        formPenerimaanBarang.Input()
    End Sub

    Private Sub ButtonEditClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonEdit.Click
        Dim formPenerimaanBarang As New EditorJadwalMataPelajaran
        formPenerimaanBarang.MdiParent = MainForm
        formPenerimaanBarang.ListForm = Me
        formPenerimaanBarang.Edit(currentid)
    End Sub

    Private Sub ButtonDeleteClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonDelete.Click

        Try
            Dim result = MessageBox.Show(Me, "Delete Jadwal Mata Pelajaran ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If
            JadwalMataPelajaranBusinessObject.Delete(currentid)
            LoadData()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonRefreshClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonRefresh.Click
        LoadData()
    End Sub

    Private Sub DataGridView1RowStateChanged(ByVal sender As System.Object, ByVal e As Windows.Forms.DataGridViewRowStateChangedEventArgs) Handles DataGridView1.RowStateChanged
        If e.StateChanged <> DataGridViewElementStates.Selected Then
            Return
        End If
        If DataGridView1.SelectedRows.Count = 0 Then
            Return
        End If
        currentid = DataGridView1.SelectedRows(0).Cells("ID").Value
    End Sub

    Private Sub ButtonPrintJadwalClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonPrintJadwal.Click
        Dim a As New KelasDialog
        a.Show(Me)
    End Sub
End Class