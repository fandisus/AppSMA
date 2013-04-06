Imports SistemAkademikSman.BusinessObject

Public Class ListJadwalMataPelajaran

    Private Sub ListJadwalMataPelajaranLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = JadwalMataPelajaranBusinessObject.ListJadwalMataPelajaran()
    End Sub

    Private Sub ButtonInputClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonInput.Click
        Dim formPenerimaanBarang As New EditorJadwalMataPelajaran
        formPenerimaanBarang.MdiParent = MainForm
        formPenerimaanBarang.ListForm = Me
        formPenerimaanBarang.Input()
    End Sub

    Private Sub ButtonEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEdit.Click

    End Sub

    Private Sub ButtonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDelete.Click

    End Sub

    Private Sub ButtonRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefresh.Click

    End Sub
End Class