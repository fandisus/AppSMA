
Imports Siak.BusinessModel.Interfaces
Imports Siak.Business.Models


Public Class SiswaDataObject
    Inherits DataObjectBase(Of ISiswaModel)
    Public Overrides Function GetList() As IList(Of ISiswaModel)
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.MasterSiswa Order By data.ID Descending Select data).ToList()
            Return (From masterSiswa In query Select PopulateSiswaModel(masterSiswa)).ToList()
        End Using
    End Function

    Public Overrides Function Gets(ByVal recordId As Integer) As ISiswaModel
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.MasterSiswa Where data.ID = recordId Select data).ToList().FirstOrDefault()
            Return PopulateSiswaModel(query)
        End Using
    End Function

    Private Shared Function PopulateSiswaModel(ByVal siswa As MasterSiswa) As ISiswaModel
        If siswa Is Nothing Then
            Throw New Exception("Data Siswa Tidak Ditemukan")
        End If
        Dim model As ISiswaModel = New SiswaModel()
        With model
            .Agama = siswa.Agama
            .Alamat = siswa.Alamat
            .AlamatOrangTua = siswa.AlamatOrangTua
            .Email = siswa.Email
            .ID = siswa.ID
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
            .TanggalLahir = siswa.TanggalLahir
            .TanggalMasuk = siswa.TanggalMasuk
            .TempatLahir = siswa.TempatLahir
        End With
        Return model
    End Function

    Private Shared Function PopulateSiswaEntity(ByVal siswa As SiswaModel) As MasterSiswa
        If siswa Is Nothing Then
            Throw New Exception("Data Siswa Tidak Ditemukan")
        End If
        Dim model = New MasterSiswa
        With model
            .Agama = siswa.Agama
            .Alamat = siswa.Alamat
            .AlamatOrangTua = siswa.AlamatOrangTua
            .Email = siswa.Email
            .ID = siswa.ID
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
            .TanggalLahir = siswa.TanggalLahir
            .TanggalMasuk = siswa.TanggalMasuk
            .TempatLahir = siswa.TempatLahir
        End With
        Return model
    End Function

    Public Overrides Sub Insert(ByVal model As ISiswaModel)
        Using entity As New SiakSmanEntities()
            entity.AddToMasterSiswa(PopulateSiswaEntity(model))
            entity.SaveChanges()
        End Using
    End Sub

    Public Overrides Sub Update(ByVal siswa As ISiswaModel)
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

    Public Overrides Sub Delete(ByVal recordId As Integer)
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.MasterSiswa Where data.ID = recordId).FirstOrDefault()
            If (query Is Nothing) Then
                Throw New Exception("Delete failed, Data Siswa tidak ditemukan")
            End If
            entity.DeleteObject(query)
            entity.SaveChanges()
        End Using
    End Sub

    Public Function GetSiswaByTahunAngkatan(ByVal tahun As String) As IList(Of ISiswaModel)
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.MasterSiswa Where data.NIS.StartsWith(tahun) Select data).ToList()
            Return (From masterSiswa In query Select PopulateSiswaModel(masterSiswa)).ToList()
        End Using
    End Function

    Public Function GetSiswaByJurusan(ByVal tahun As String, ByVal jurusan As String, ByVal tahunajaran As Integer) As IList(Of ISiswaModel)
        Using entity As New SiakSmanEntities()
            Dim query = From data In entity.Penjurusan.Include("MasterSiswa") Where data.MasterSiswa.NIS.StartsWith(tahun) And data.TahunAjaran = tahunajaran And data.Jurusan.Equals(jurusan) Select data
            'Return (From penjurusan In query Select penjurusan.MasterSiswa).ToList()
            Return (From masterSiswa In (From penjurusan In query Select penjurusan.MasterSiswa).ToList() Select PopulateSiswaModel(masterSiswa)).ToList()
        End Using
    End Function


    Public Function GetListByName(ByVal nama As String) As IList(Of ISiswaModel)
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.MasterSiswa Where data.Nama.Contains(nama) Order By data.ID Descending Select data).ToList()
            Return (From masterSiswa In query Select PopulateSiswaModel(masterSiswa)).ToList()
        End Using
    End Function

    Public Function GetListByNis(ByVal nis As String) As IList(Of ISiswaModel)
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.MasterSiswa Where data.NIS.Contains(nis) Order By data.ID Descending Select data).ToList()
            Return (From masterSiswa In query Select PopulateSiswaModel(masterSiswa)).ToList()
        End Using
    End Function


End Class