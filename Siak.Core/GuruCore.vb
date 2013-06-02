
Imports System.Net.Mail
Imports Siak.Business.Models
Imports Siak.DataAccesLayer
Imports Siak.BusinessModel.Interfaces

Public Class GuruCore
    Implements IDisposable

    Public Sub SaveGuru(gurumodel As IGuruModel)
        ValidateGuruModel(gurumodel)
        Using dataaccess = New GuruDataObject()
            dataaccess.Insert(CType(gurumodel, GuruModel))
        End Using
    End Sub

    Private Shared Sub ValidateGuruModel(ByVal gurumodel As IGuruModel)
        If gurumodel.Nama.Length = 0 Then
            Throw New Exception("Nama Guru harus diisi")
        End If
        If gurumodel.GuruID.Length = 0 Then
            Throw New Exception("ID Guru harus diisi")
        End If
        If gurumodel.NIP.Length = 0 Then
            Throw New Exception("NIP Guru harus diisi")
        End If
        If Not gurumodel.Email.Length = 0 Then
            Try
                Dim a As New MailAddress(gurumodel.Email)
            Catch ex As Exception
                Throw New Exception("Invalid format email")
            End Try
        End If
    End Sub

    Public Sub UpdateGuru(gurumodel As IGuruModel)
        ValidateGuruModel(gurumodel)
        Using dataaccess = New GuruDataObject()
            dataaccess.Update(CType(gurumodel, GuruModel))
        End Using
    End Sub

    Public Sub DeleteGuru(guruId As Integer)
        'TODO VALIDATION HERE
        Using dataaccess = New GuruDataObject()
            dataaccess.Delete(guruId)
        End Using
    End Sub

    Public Function GetListGuru() As IList(Of GuruModel)
        'TODO VALIDATION HERE
        Using dataaccess = New GuruDataObject()
            Return dataaccess.GetList()
        End Using
    End Function

    Public Function GetListGuru(ByVal matapelajaranid As Integer, ByVal tahun As Integer) As IEnumerable(Of IGuruModel)
        'TODO VALIDATION HERE
        Using dataaccess = New GuruDataObject()
            Return dataaccess.GetListGuru(matapelajaranid, tahun)
        End Using
    End Function

    Public Function GetGuru(id As Integer) As IGuruModel
        'TODO VALIDATION HERE
        Using dataaccess = New GuruDataObject()
            Return dataaccess.Gets(id)
        End Using
    End Function

    Public Function GetListGuru(ByVal namaGuru As String) As IEnumerable(Of IGuruModel)
        'TODO VALIDATION HERE
        Using dataaccess = New GuruDataObject()
            Return dataaccess.GetListByName(namaGuru)
        End Using
    End Function

    Public Sub SubmitGuruMataPelajaran(ByVal mguru As IEnumerable(Of GuruMataPelajaranModel))
        'TODO VALIDATION HERE
        Using dataaccess = New GuruDataObject()
            dataaccess.UpdateGuruMataPelajaran(mguru)
        End Using
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose

    End Sub

End Class
