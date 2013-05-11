Imports System.Web.Services
Imports System.ComponentModel
Imports DataAccesLayer.BusinessModel
Imports DataAccesLayer.BusinessObject
Imports DataAccesLayer
Imports System.Collections.ObjectModel

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class MasterGuruService
    Inherits WebService

    <WebMethod()> _
    Public Function GetAllGuru() As Collection(Of MasterGuru)
        Return GuruBusinessObject.GetList()
    End Function

    <WebMethod()> _
    Public Function GetGuru(ByVal id As Integer) As MasterGuru
        Return GuruBusinessObject.GetGuru(id)
    End Function

    <WebMethod()> _
    Public Sub InsertGuru(ByVal mguru As MasterGuru)
        GuruBusinessObject.InsertGuru(mguru)
    End Sub

    <WebMethod()> _
    Public Sub UpdateGuru(ByVal mguru As MasterGuru)
        GuruBusinessObject.UpdateGuru(mguru)
    End Sub

    <WebMethod()> _
    Public Sub DeleteGuru(ByVal recordId As Integer)
        GuruBusinessObject.DeleteGuru(recordId)
    End Sub

    <WebMethod()> _
    Public Sub SubmitGuruMataPelajaran(ByVal mguru As Collection(Of GuruMataPelajaranModel))
        GuruBusinessObject.SubmitGuruMataPelajaran(mguru)
    End Sub

    <WebMethod()> _
    Public Function GetGuruByMataPelajaranTahunAjaran(ByVal matapelajaranid As Integer, ByVal tahun As Integer) As Collection(Of MasterGuru)
        Return GuruBusinessObject.GetGuru(matapelajaranid, tahun)
    End Function

    <WebMethod()> _
    Public Function GetGuruByName(ByVal text As String) As Collection(Of MasterGuru)
        Return GuruBusinessObject.GetListByName(text)
    End Function

End Class