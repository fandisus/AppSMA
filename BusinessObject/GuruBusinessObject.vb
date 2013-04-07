Imports System.Net.Mail

Namespace BusinessObject

    Friend Class GuruBusinessObject
        Public Shared Function GetList() As List(Of MasterGuru)
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterGuru Order By data.ID Descending
                Return query.ToList()
            End Using
        End Function

        Public Shared Function GetGuru(ByVal id As Integer) As MasterGuru
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterGuru Where data.ID = id Order By data.Nama
                Return query.ToList().FirstOrDefault()
            End Using
        End Function

        Public Shared Sub InsertGuru(ByVal mguru As MasterGuru)
            If mguru.Nama.Length = 0 Then
                Throw New Exception("Nama Guru harus diisi")
            End If
            If mguru.GuruID.Length = 0 Then
                Throw New Exception("ID Guru harus diisi")
            End If
            If mguru.NIP.Length = 0 Then
                Throw New Exception("NIP Guru harus diisi")
            End If
            If Not mguru.Email.Length = 0 Then
                Try
                    Dim a As New MailAddress(mguru.Email)
                Catch ex As Exception
                    Throw New Exception("Invalid format email")
                End Try
            End If
            Using entity As New SiakSmanEntities()
                entity.AddToMasterGuru(mguru)
                entity.SaveChanges()
            End Using
        End Sub

        Public Shared Sub UpdateGuru(ByVal mguru As MasterGuru)
            If mguru.Nama.Length = 0 Then
                Throw New Exception("Nama Guru harus diisi")
            End If
            If mguru.GuruID.Length = 0 Then
                Throw New Exception("ID Guru harus diisi")
            End If
            If mguru.NIP.Length = 0 Then
                Throw New Exception("NIP Guru harus diisi")
            End If
            If Not mguru.Email.Length = 0 Then
                Try
                    Dim a As New MailAddress(mguru.Email)
                Catch ex As Exception
                    Throw New Exception("Invalid format email")
                End Try
            End If
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.MasterGuru Where data.ID = mguru.ID).FirstOrDefault()
                If (query Is Nothing) Then
                    Throw New Exception("Update failed, Data Guru " + mguru.Nama + " tidak ditemukan")
                End If
                With query
                    .Agama = mguru.Agama
                    .Alamat = mguru.Alamat
                    .Email = mguru.Email
                    .GuruID = mguru.GuruID
                    .JenisKelamin = mguru.JenisKelamin
                    .KodePos = mguru.KodePos
                    .Kota = mguru.Kota
                    .NIP = mguru.NIP
                    .Nama = mguru.Nama
                    .NoHP = mguru.NoHP
                    .NoTelephone = mguru.NoTelephone
                    .Photo = mguru.Photo
                    .TanggalLahir = mguru.TanggalLahir
                    .TempatLahir = mguru.TempatLahir
                End With
                entity.SaveChanges()
            End Using
        End Sub

        Public Shared Sub DeleteGuru(ByVal recordId As Integer)
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.MasterGuru Where data.ID = recordId).FirstOrDefault()
                If (query Is Nothing) Then
                    Throw New Exception("Delete failed, Data Guru tidak ditemukan")
                End If
                entity.DeleteObject(query)
                entity.SaveChanges()
            End Using
        End Sub
    End Class
End Namespace