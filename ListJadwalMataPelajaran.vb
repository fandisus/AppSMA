Imports SistemAkademikSman.BusinessObject

Public Class ListJadwalMataPelajaran

    Private Sub ListJadwalMataPelajaranLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = JadwalMataPelajaranBusinessObject.ListJadwalMataPelajaran()
    End Sub
End Class