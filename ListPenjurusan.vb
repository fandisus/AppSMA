Imports SistemAkademikSman.BusinessObject

Public Class ListPenjurusan

    Private Sub ListPenjurusanLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False
        Dim a = PenjurusanBusinessObject.GetList()
        DataGridView1.DataSource = a
    End Sub
End Class