Imports System.Net.Mail
Imports Siak.Business.Models
Imports Siak.DataAccesLayer
Imports Siak.BusinessModel.Interfaces

Public Class SiswaCore
    Implements IDisposable

    Public Sub SaveSiswa(model As ISiswaModel)
        ValidasiObject(model)
        Using dataaccess = New SiswaDataObject()
            dataaccess.Insert(model)
        End Using
    End Sub

    Public Sub UpdateSiswa(model As ISiswaModel)
        ValidasiObject(model)
        Using dataaccess = New SiswaDataObject()
            dataaccess.Update(model)
        End Using
    End Sub

    Public Sub DeleteSiswa(siswaid As Integer)
        'TODO VALIDATION HERE
        Using dataaccess = New SiswaDataObject()
            dataaccess.Delete(siswaid)
        End Using
    End Sub

    Public Function GetListSiswa() As IList(Of ISiswaModel)
        'TODO VALIDATION HERE
        Using dataaccess = New SiswaDataObject()
            Return dataaccess.GetList().ToList()
        End Using
    End Function

    Public Function GetListByName(ByVal nama As String) As IList(Of ISiswaModel)
        Using dataaccess = New SiswaDataObject()
            Return dataaccess.GetListByName(nama)
        End Using
    End Function

    Public Function GetListByNis(ByVal nis As String) As IList(Of ISiswaModel)
        Using dataaccess = New SiswaDataObject()
            Return dataaccess.GetListByNis(nis)
        End Using
    End Function

    Public Function GetSiswa(ByVal recordId As Integer) As ISiswaModel
        Using dataaccess = New SiswaDataObject()
            Return dataaccess.Gets(recordId)
        End Using
    End Function

    Public Function GetSiswaByJurusan(ByVal tahun As String, ByVal jurusan As String, ByVal tahunajaran As Integer) As IList(Of ISiswaModel)
        Using dataaccess = New SiswaDataObject()
            Return dataaccess.GetSiswaByJurusan(tahun, jurusan, tahunajaran)
        End Using
    End Function

    Public Function GetSiswaByTahunAngkatan(ByVal tahun As String) As IList(Of ISiswaModel)
        Using dataaccess = New SiswaDataObject()
            Return dataaccess.GetSiswaByTahunAngkatan(tahun)
        End Using
    End Function

    Private Shared Sub ValidasiObject(ByVal siswa As ISiswaModel)
        If siswa.Nama.Length = 0 Then
            Throw New Exception("Nama Siswa harus diisi")
        End If
        If siswa.NIS.Length = 0 Then
            Throw New Exception("No Induk Siswa harus diisi")
        End If
        If Not siswa.Email.Length = 0 Then
            Try
                Dim a As New MailAddress(siswa.Email)
            Catch ex As Exception
                Throw New Exception("Invalid format email")
            End Try
        End If
    End Sub

    Public Sub Dispose() Implements IDisposable.Dispose

    End Sub

End Class
