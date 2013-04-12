Imports SistemAkademikSman.BusinessObject
Imports Microsoft.Reporting.WinForms

Public Class ReportJadwalViewer

    Private Sub ReportJadwalViewerLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load

       
    End Sub

    Public Sub ShowReport(ByVal kelasid As Integer, ByVal tahunaajaran As Integer, ByVal jurusan As String)
        Try
            Dim businessObject As New JadwalMataPelajaranBusinessObject
            Dim list As New List(Of ReportJadwalModel)
            list.AddRange(businessObject.GetJadwalMataPelajaran(kelasid, tahunaajaran, "Senin", jurusan))
            list.AddRange(businessObject.GetJadwalMataPelajaran(kelasid, tahunaajaran, "Selasa", jurusan))
            list.AddRange(businessObject.GetJadwalMataPelajaran(kelasid, tahunaajaran, "Rabu", jurusan))
            list.AddRange(businessObject.GetJadwalMataPelajaran(kelasid, tahunaajaran, "Kamis", jurusan))
            list.AddRange(businessObject.GetJadwalMataPelajaran(kelasid, tahunaajaran, "Jumat", jurusan))
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