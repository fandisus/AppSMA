Imports SistemAkademikSman.BusinessObject
Imports Microsoft.Reporting.WinForms

Public Class FormReportKelas

    Private Sub FormReportKelasLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Public Sub ViewReport(ByVal tahunajaran As Integer, ByVal kelasid As Integer)
        Try
            Show(MainForm)
            Dim list = PenjurusanBusinessObject.GetPenjurusan(tahunajaran, kelasid)
            Dim source As New ReportDataSource
            source.Name = "SistemAkademikSman_ReportKelasModel"
            source.Value = list
            ReportViewer1.LocalReport.DataSources.Add(source)
            ReportViewer1.RefreshReport()

        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class