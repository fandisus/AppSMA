Imports System.Net.Mail

Namespace BusinessObject

    Public Class SiswaBusinessObject
        Public Shared Function GetList() As List(Of MasterSiswa)
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterSiswa Order By data.ID Descending
                Return query.ToList()
            End Using
        End Function

        Public Shared Function GetSiswa(ByVal recordId As Integer) As MasterSiswa
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterSiswa Where data.ID = recordId
                Return query.ToList().FirstOrDefault()
            End Using
        End Function

        Public Shared Function GetSiswaByTahunAngkatan(ByVal tahun As String) As List(Of MasterSiswa)
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterSiswa Where data.NIS.StartsWith(tahun)
                Return query.ToList()
            End Using
        End Function

        Public Shared Function GetSiswaByJurusan(ByVal tahun As String, ByVal jurusan As String, ByVal tahunajaran As Integer) As List(Of MasterSiswa)
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.Penjurusan.Include("MasterSiswa") Where data.MasterSiswa.NIS.StartsWith(tahun) And data.TahunAjaran = tahunajaran And data.Jurusan.Equals(jurusan)
                Return (From penjurusan In query Select penjurusan.MasterSiswa).ToList()
            End Using
        End Function

        Public Shared Function GetSiswa(ByVal nis As String) As MasterSiswa
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterSiswa Where data.NIS = nis
                Return query.ToList().FirstOrDefault()
            End Using
        End Function

        Public Shared Sub InsertSiswa(ByVal siswa As MasterSiswa)
            ValidasiObject(siswa)
            Using entity As New SiakSmanEntities()
                entity.AddToMasterSiswa(siswa)
                entity.SaveChanges()
            End Using
        End Sub

        Private Shared Sub ValidasiObject(ByVal siswa As MasterSiswa)

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

        Public Shared Sub UpdateSiswa(ByVal siswa As MasterSiswa)
            ValidasiObject(siswa)
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.MasterSiswa Where data.ID = siswa.ID).FirstOrDefault()
                If (query Is Nothing) Then
                    Throw New Exception("Update failed, Data Siswa " + siswa.Nama + " tidak ditemukan")
                End If
                With query
                    .Agama = siswa.Agama
                    .Alamat = siswa.Alamat
                    .AlamatOrangTua = siswa.AlamatOrangTua
                    .Email = siswa.Email
                    .NIS = siswa.NIS
                    .JenisKelamin = siswa.JenisKelamin
                    .KodePos = siswa.KodePos
                    .KodePosOrangTua = siswa.KodePosOrangTua
                    .Kota = siswa.Kota
                    .KotaOrangTua = siswa.KotaOrangTua
                    .Nama = siswa.Nama
                    .NamaAyah = siswa.NamaAyah
                    .NamaIbu = siswa.NamaIbu
                    .NamaSMPAsal = siswa.NamaSMPAsal
                    .NoHP = siswa.NoHP
                    .NoHPOrangTua = siswa.NoHPOrangTua
                    .NoTelephone = siswa.NoTelephone
                    .NoTelephoneOrangTua = siswa.NoTelephoneOrangTua
                    .Photo = siswa.Photo
                    .TanggalMasuk = siswa.TanggalMasuk
                    .TanggalLahir = siswa.TanggalLahir
                    .TempatLahir = siswa.TempatLahir
                End With
                entity.SaveChanges()
            End Using
        End Sub

        Public Shared Sub DeleteSiswa(ByVal recordId As Integer)
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.MasterSiswa Where data.ID = recordId).FirstOrDefault()
                If (query Is Nothing) Then
                    Throw New Exception("Delete failed, Data Siswa tidak ditemukan")
                End If
                entity.DeleteObject(query)
                entity.SaveChanges()
            End Using
        End Sub
    End Class
End Namespace