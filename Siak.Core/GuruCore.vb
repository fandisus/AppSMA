Imports BusinessModel.Interfaces
Imports DataAccesLayer
Imports System.Net.Mail

Public Class GuruCore

    Public Sub SaveGuru(gurumodel As IGuruModel)
        Using dataaccess = New GuruDataObject()
            ValidateGuruModel(gurumodel)
            dataaccess.InsertGuru(gurumodel)
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
        Using dataaccess = New GuruDataObject()
            ValidateGuruModel(gurumodel)
            dataaccess.UpdateGuru(gurumodel)
        End Using
    End Sub

    Public Sub DeleteGuru(guruId As Integer)
        Using dataaccess = New GuruDataObject()
            dataaccess.DeleteGuru(guruId)
        End Using
    End Sub




End Class
