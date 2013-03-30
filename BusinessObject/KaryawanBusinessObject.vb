Imports System.Net.Mail

Namespace BusinessObject

    Public Class KaryawanBusinessObject


        Public Shared Function GetList() As List(Of MasterKaryawan)
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterKaryawan Order By data.ID Descending
                Return query.ToList()
            End Using
        End Function

        Public Shared Function GetKaryawan(ByVal recordId As Integer) As MasterKaryawan
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterKaryawan Where data.ID = recordId
                Return query.ToList().FirstOrDefault()
            End Using
        End Function

        Public Shared Sub InsertKaryawan(ByVal masterKaryawan As MasterKaryawan)
            If masterKaryawan.Nama.Length = 0 Then
                Throw New Exception("Nama Karyawan harus diisi")
            End If
            If masterKaryawan.KaryawanID.Length = 0 Then
                Throw New Exception("ID Karyawan harus diisi")
            End If
            If masterKaryawan.NIP.Length = 0 Then
                Throw New Exception("NIP Karyawan harus diisi")
            End If
            If Not masterKaryawan.Email.Length = 0 Then
                Try
                    Dim a As New MailAddress(masterKaryawan.Email)
                Catch ex As Exception
                    Throw New Exception("Invalid format email")
                End Try
            End If
            Using entity As New SiakSmanEntities()
                entity.AddToMasterKaryawan(masterKaryawan)
                entity.SaveChanges()
            End Using
        End Sub

        Public Shared Sub UpdateKaryawan(ByVal masterKaryawan As MasterKaryawan)
            If masterKaryawan.Nama.Length = 0 Then
                Throw New Exception("Nama Karyawan harus diisi")
            End If
            If masterKaryawan.KaryawanID.Length = 0 Then
                Throw New Exception("ID Karyawan harus diisi")
            End If
            If masterKaryawan.NIP.Length = 0 Then
                Throw New Exception("NIP Karyawan harus diisi")
            End If
            If Not masterKaryawan.Email.Length = 0 Then
                Try
                    Dim a As New MailAddress(masterKaryawan.Email)
                Catch ex As Exception
                    Throw New Exception("Invalid format email")
                End Try
            End If
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.MasterKaryawan Where data.ID = masterKaryawan.ID).FirstOrDefault()
                If (query Is Nothing) Then
                    Throw New Exception("Update failed, Data Karyawan " + masterKaryawan.Nama + " tidak ditemukan")
                End If
                With query
                    .Agama = masterKaryawan.Agama
                    .Alamat = masterKaryawan.Alamat
                    .Email = masterKaryawan.Email
                    .KaryawanID = masterKaryawan.KaryawanID
                    .JenisKelamin = masterKaryawan.JenisKelamin
                    .KodePos = masterKaryawan.KodePos
                    .Kota = masterKaryawan.Kota
                    .NIP = masterKaryawan.NIP
                    .Nama = masterKaryawan.Nama
                    .NoHP = masterKaryawan.NoHP
                    .NoTelephone = masterKaryawan.NoTelephone
                    .Photo = masterKaryawan.Photo
                    .TanggalLahir = masterKaryawan.TanggalLahir
                    .TempatLahir = masterKaryawan.TempatLahir
                End With
                entity.SaveChanges()
            End Using
        End Sub

        Public Shared Sub DeleteKaryawan(ByVal recordId As Integer)
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.MasterKaryawan Where data.ID = recordId).FirstOrDefault()
                If (query Is Nothing) Then
                    Throw New Exception("Delete failed, Data Karyawan tidak ditemukan")
                End If
                entity.DeleteObject(query)
                entity.SaveChanges()
            End Using
        End Sub
    End Class
End Namespace