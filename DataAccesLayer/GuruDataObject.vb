Imports System.Net.Mail
Imports DataAccesLayer.BusinessModel
Imports System.Collections.ObjectModel
Imports BusinessModel.Interfaces
Imports Business.Models


Public Class GuruDataObject

    Public Shared Function GetList() As IEnumerable(Of IGuruModel)
        Using entity As New SiakSmanEntities()
            Dim query = From data In entity.MasterGuru Order By data.ID Descending Select data
            Dim masterGurus = query.ToList()
            Return (From guru In masterGurus Select PopulateGuruToModel(guru)).Cast(Of IGuruModel)().ToList()
        End Using
    End Function

    Private Shared Function PopulateGuruToModel(ByVal guru As MasterGuru) As GuruModel
        Dim guruModel = New GuruModel()
        With guruModel
            .Agama = guru.Agama
            .Alamat = guru.Alamat
            .Email = guru.Email
            .GuruID = guru.GuruID
            .ID = guru.ID
            .JenisKelamin = guru.JenisKelamin
            .KodePos = guru.KodePos
            .Kota = guru.Kota
            .NIP = guru.NIP
            .Nama = guru.Nama
            .NoHP = guru.NoHP
            .NoTelephone = guru.NoTelephone
            .Photo = guru.Photo
            .TanggalLahir = guru.TanggalLahir
            .TempatLahir = guru.TempatLahir
        End With
        Return guruModel
    End Function

    Public Shared Function GetGuru(ByVal id As Integer) As IGuruModel
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.MasterGuru Where data.ID = id Order By data.Nama Select data).ToList().FirstOrDefault()
            Return PopulateGuruToModel(query)
        End Using
    End Function

    Public Sub InsertGuru(ByVal mguru As IGuruModel)
        Using entity As New SiakSmanEntities()
            entity.AddToMasterGuru(mguru)
            entity.SaveChanges()
        End Using
    End Sub

    Public Sub UpdateGuru(ByVal mguru As IGuruModel)
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

    Public Sub DeleteGuru(ByVal recordId As Integer)
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.MasterGuru Where data.ID = recordId).FirstOrDefault()
            If (query Is Nothing) Then
                Throw New Exception("Delete failed, Data Guru tidak ditemukan")
            End If
            entity.DeleteObject(query)
            entity.SaveChanges()
        End Using
    End Sub

    Public Shared Sub SubmitGuruMataPelajaran(ByVal mguru As IEnumerable(Of GuruMataPelajaranModel))
        If mguru.Count() = 0 Then
            Throw New Exception("Tidak ada list Mata Pelajaran untuk Guru")
        End If

        Using entity As New SiakSmanEntities()
            If entity.Connection.State <> ConnectionState.Open Then
                entity.Connection.Open()
            End If
            Using transaction = entity.Connection.BeginTransaction
                For Each model As GuruMataPelajaranModel In mguru
                    If model.Crud = 1 Then
                        Dim item = New GuruMataPelajaran
                        item.MasterGuru = (From data In entity.MasterGuru Where data.ID = model.GuruId).FirstOrDefault()
                        item.MasterMataPelajaran = (From data In entity.MasterMataPelajaran Where data.ID = model.MataPelajaranId).FirstOrDefault()
                        entity.AddToGuruMataPelajaran(item)
                        entity.SaveChanges()
                    ElseIf model.Crud = 2 Then
                        Dim item = (From data In entity.GuruMataPelajaran Where data.ID = model.Id).FirstOrDefault()
                        item.MasterGuru = (From data In entity.MasterGuru Where data.ID = model.GuruId).FirstOrDefault()
                        item.MasterMataPelajaran = (From data In entity.MasterMataPelajaran Where data.ID = model.MataPelajaranId).FirstOrDefault()
                        entity.SaveChanges()
                    ElseIf model.Crud = 3 Then
                        Dim item = (From data In entity.GuruMataPelajaran Where data.ID = model.Id).FirstOrDefault()
                        entity.DeleteObject(item)
                        entity.SaveChanges()
                    End If
                Next
                transaction.Commit()
            End Using
            If entity.Connection.State <> ConnectionState.Closed Then
                entity.Connection.Close()
            End If
        End Using
    End Sub

    Public Shared Function GetGuru(ByVal matapelajaranid As Integer, ByVal tahun As Integer) As IEnumerable(Of MasterGuru)
        Using entity As New SiakSmanEntities()
            Dim query = From data In entity.GuruMataPelajaran.Include("MasterGuru").Include("MasterMataPelajaran") Where data.MasterMataPelajaran.ID = matapelajaranid And data.MasterMataPelajaran.TahunAjaran = tahun Select data.MasterGuru
            Return query.ToList()
        End Using
    End Function

    Public Shared Function GetListByName(ByVal text As String) As Collection(Of MasterGuru)
        Using entity As New SiakSmanEntities()
            Dim query = From data In entity.MasterGuru Where data.Nama.Contains(text) Order By data.ID Descending Select data
            Return query.ToList().AsEnumerable()
        End Using
    End Function
End Class