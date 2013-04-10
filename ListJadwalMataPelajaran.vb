Imports SistemAkademikSman.BusinessObject

Public Class ListJadwalMataPelajaran

    Dim currentid As Integer
    Private Sub ListJadwalMataPelajaranLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadData()
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

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonDelete.Click

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
End Class