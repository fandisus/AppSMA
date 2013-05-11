Imports SistemAkademikSman.BusinessObject
Imports Microsoft.Reporting.WinForms

Public Class ReportJadwalViewer

    Private Sub ReportJadwalViewerLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

       
    End Sub

    Public Sub ShowReport(ByVal kelasid As Integer, ByVal tahunaajaran As Integer)
        Try
            Dim businessObject As New JadwalMataPelajaranBusinessObject
            Dim list As New List(Of ReportJadwalModel)
            list.AddRange(businessObject.GetJadwalMataPelajaran(kelasid, tahunaajaran, "Senin"))
            list.AddRange(businessObject.GetJadwalMataPelajaran(kelasid, tahunaajaran, "Selasa"))
            list.AddRange(businessObject.GetJadwalMataPelajaran(kelasid, tahunaajaran, "Rabu"))
            list.AddRange(businessObject.GetJadwalMataPelajaran(kelasid, tahunaajaran, "Kamis"))
            list.AddRange(businessObject.GetJadwalMataPelajaran(kelasid, tahunaajaran, "Jumat"))
            Dim source As New ReportDataSource
            source.Name = "SistemAkademikSman_ReportJadwalModel"
            source.Value = list
            ReportViewer1.LocalReport.DataSources.Add(source)

            ReportViewer1.RefreshReport()
            Show()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class