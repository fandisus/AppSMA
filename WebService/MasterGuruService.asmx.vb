Imports System.Web.Services
Imports System.ComponentModel
Imports Siak.BusinessModel.Interfaces
Imports Siak.Business.Models
Imports Siak.Core
Imports System.Collections.ObjectModel

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class MasterGuruService
    Inherits WebService

    <WebMethod()> _
    Public Function GetAllGuru() As Collection(Of GuruModel)
        Using core = New GuruCore()
            Dim data = core.GetListGuru()
            Return New Collection(Of GuruModel)(data)
        End Using
    End Function

    <WebMethod()> _
    Public Function GetGuru(ByVal id As Integer) As GuruModel
        Using core = New GuruCore()
            Return TryCast(core.GetGuru(id), GuruModel)
        End Using
    End Function

    <WebMethod()> _
    Public Sub SaveGuru(ByVal mguru As GuruModel)
        Using core = New GuruCore()
            core.SaveGuru(mguru)
        End Using
    End Sub

    <WebMethod()> _
    Public Sub UpdateGuru(ByVal mguru As GuruModel)
        Using core = New GuruCore()
            core.UpdateGuru(mguru)
        End Using
    End Sub

    <WebMethod()> _
    Public Sub DeleteGuru(ByVal recordId As Integer)
        Using core = New GuruCore()
            core.DeleteGuru(recordId)
        End Using
    End Sub

    <WebMethod()> _
    Public Sub SubmitGuruMataPelajaran(ByVal mguru As GuruMataPelajaranModel())
        Using core = New GuruCore()
            core.SubmitGuruMataPelajaran(mguru.ToList())
        End Using
    End Sub

    <WebMethod()> _
    Public Function GetGuruByMataPelajaranTahunAjaran(ByVal matapelajaranid As Integer, ByVal tahun As Integer) As Collection(Of GuruModel)
        Using core = New GuruCore()
            Return CType(core.GetListGuru(matapelajaranid, tahun), Collection(Of GuruModel))
        End Using
    End Function

    <WebMethod()> _
    Public Function GetGuruByName(ByVal namaGuru As String) As Collection(Of GuruModel)
        Using core = New GuruCore()
            Return CType(core.GetListGuru(namaGuru), Collection(Of GuruModel))
        End Using
    End Function

End Class