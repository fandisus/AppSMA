Imports SistemAkademikSman.BusinessObject

Public Class FormReportKelasParameter

    Private Sub FormReportKelasParameterLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        TextBoxTahunAngkatan.Text = DateTime.Now.Year.ToString()
        ComboBoxTingkat.DisplayMember = "NamaKelas"
        ComboBoxTingkat.ValueMember = "ID"
        ComboBoxTingkat.DataSource = KelasBusinessObject.GetList()
    End Sub

    Private Sub Button1Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Dim cform As New FormReportKelas
        cform.ViewReport(Convert.ToInt32(TextBoxTahunAngkatan.Text), Convert.ToInt32(ComboBoxTingkat.SelectedValue))
    End Sub

    Private Sub ButtonCloseClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub
End Class