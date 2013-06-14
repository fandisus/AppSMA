Imports System.Web.Services
Imports System.ComponentModel
Imports System.Collections.ObjectModel
Imports Siak.Business.Models
Imports Siak.Core

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class MasterSiswaService
    Inherits WebService

    <WebMethod()> _
    Public Sub SaveSiswa(model As SiswaModel)
        Using siswaCore = New SiswaCore()
            siswaCore.SaveSiswa(model)
        End Using
    End Sub

    <WebMethod()> _
    Public Sub UpdateSiswa(model As SiswaModel)
        Using siswaCore = New SiswaCore()
            siswaCore.UpdateSiswa(model)
        End Using
    End Sub

    <WebMethod()> _
    Public Sub DeleteSiswa(siswaid As Integer)
        Using siswaCore = New SiswaCore()
            siswaCore.DeleteSiswa(siswaid)
        End Using
    End Sub

    <WebMethod()> _
    Public Function GetListSiswa() As Collection(Of SiswaModel)
        Using siswaCore = New SiswaCore()
            Return New Collection(Of SiswaModel)(siswaCore.GetListSiswa().ToList().ConvertAll(Function(model) CType(model, SiswaModel)))
        End Using
    End Function

    <WebMethod()> _
    Public Function GetListByName(ByVal nama As String) As Collection(Of SiswaModel)
        Using siswaCore = New SiswaCore()
            Return New Collection(Of SiswaModel)(siswaCore.GetListByName(nama).ToList().ConvertAll(Function(model) CType(model, SiswaModel)))
        End Using
    End Function

    <WebMethod()> _
    Public Function GetListByNis(ByVal nis As String) As Collection(Of SiswaModel)
        Using siswaCore = New SiswaCore()
            Return New Collection(Of SiswaModel)(siswaCore.GetListByNis(nis).ToList().ConvertAll(Function(model) CType(model, SiswaModel)))
        End Using
    End Function

    <WebMethod()> _
    Public Function GetSiswa(ByVal recordId As Integer) As SiswaModel
        Using siswaCore = New SiswaCore()
            Return TryCast(siswaCore.GetSiswa(recordId), SiswaModel)
        End Using
    End Function

    <WebMethod()> _
    Public Function GetSiswaByJurusan(ByVal tahun As String, ByVal jurusan As String, ByVal tahunajaran As Integer) As Collection(Of SiswaModel)
        Using siswaCore = New SiswaCore()
            Return New Collection(Of SiswaModel)(siswaCore.GetSiswaByJurusan(tahun, jurusan, tahunajaran).ToList().ConvertAll(Function(model) CType(model, SiswaModel)))
        End Using
    End Function

    <WebMethod()> _
    Public Function GetSiswaByTahunAngkatan(ByVal tahun As String) As Collection(Of SiswaModel)
        Using siswaCore = New SiswaCore()
            Return New Collection(Of SiswaModel)(siswaCore.GetSiswaByTahunAngkatan(tahun).ToList().ConvertAll(Function(model) CType(model, SiswaModel)))
        End Using
    End Function

End Class