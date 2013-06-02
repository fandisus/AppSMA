Imports SistemAkademikSman.SiswaServiceReference

Public Class PenjurusanBusinessObject

    Public Shared Function GetList()
        Using entity As New SiakSmanEntities()
            Dim query = From data In entity.Penjurusan.Include("MasterKelas").Include("MasterSiswa") Order By data.TanggalPenilaian Descending, data.TahunAjaran Descending, data.MasterKelas.NamaKelas, data.MasterSiswa.Nama

            Return query.Select(Function(a) New With {a.ID, a.BahasaIndonesia, a.BahasaInggris, a.Biologi, a.Ekonomi, a.Fisika, a.Geografi, a.Jurusan, a.Kimia, .KelasID = If(a.MasterKelas Is Nothing, 0, a.MasterKelas.ID), .NamaKelas = If(a.MasterKelas Is Nothing, "", a.MasterKelas.NamaKelas), a.MasterSiswa.Nama, a.Matematika, a.NilaiRataRata, a.Sosiologi, a.TahunAjaran, a.TanggalPenilaian, a.MasterSiswa.NIS}).ToList()
        End Using
    End Function

    Public Shared Function GetPenjurusan(ByVal id As Integer) As Penjurusan
        Using entity As New SiakSmanEntities()
            Dim query = From data In entity.Penjurusan.Include("MasterKelas").Include("MasterSiswa") Where data.ID = id
            Return query.ToList().FirstOrDefault()
        End Using
    End Function

    Public Shared Function GetPenjurusan(ByVal tahunajaran As Integer, ByVal kelasid As Integer)
        Using entity As New SiakSmanEntities()
            Dim query = From data In entity.Penjurusan.Include("MasterKelas").Include("MasterSiswa") Where data.TahunAjaran = tahunajaran And data.MasterKelas.ID = kelasid Order By data.MasterSiswa.Nama
            Return (From penjurusan In query Select New ReportKelasModel() With {.NamaKelas = penjurusan.MasterKelas.NamaKelas, .NamaSiswa = penjurusan.MasterSiswa.Nama, .Nis = penjurusan.MasterSiswa.NIS, .TahunAjaran = penjurusan.TahunAjaran, .WaliKelas = String.Empty, .JenisKelamin = penjurusan.MasterSiswa.JenisKelamin}).OrderBy(Function(a) a.NamaSiswa).ToList()
        End Using
    End Function

    Public Shared Sub InsertPenjurusan(ByVal mPenjurusan As Penjurusan)
        Validasi(mPenjurusan)

        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.Penjurusan.Include("MasterSiswa") Where data.MasterSiswa.ID = mPenjurusan.MasterSiswa.ID And data.TahunAjaran = mPenjurusan.TahunAjaran Select data).FirstOrDefault()
            If query Is Nothing Then
                Dim jPenjurusan = New Penjurusan
                With jPenjurusan
                    .BahasaIndonesia = mPenjurusan.BahasaIndonesia
                    .BahasaInggris = mPenjurusan.BahasaInggris
                    .Biologi = mPenjurusan.Biologi
                    .Ekonomi = mPenjurusan.Ekonomi
                    .Fisika = mPenjurusan.Fisika
                    .Geografi = mPenjurusan.Geografi
                    .Jurusan = mPenjurusan.Jurusan
                    .Kimia = mPenjurusan.Kimia
                    .MasterKelas = Nothing
                    .MasterSiswa = (From data In entity.MasterSiswa Where data.ID = mPenjurusan.MasterSiswa.ID Select data).FirstOrDefault()
                    .Matematika = mPenjurusan.Matematika
                    .NilaiRataRata = mPenjurusan.NilaiRataRata
                    .Sosiologi = mPenjurusan.Sosiologi
                    .TahunAjaran = mPenjurusan.TahunAjaran
                    .TanggalPenilaian = DateTime.Now
                End With
                entity.AddToPenjurusan(jPenjurusan)
            Else
                With query
                    .BahasaIndonesia = mPenjurusan.BahasaIndonesia
                    .BahasaInggris = mPenjurusan.BahasaInggris
                    .Biologi = mPenjurusan.Biologi
                    .Ekonomi = mPenjurusan.Ekonomi
                    .Fisika = mPenjurusan.Fisika
                    .Geografi = mPenjurusan.Geografi
                    .Jurusan = mPenjurusan.Jurusan
                    .Kimia = mPenjurusan.Kimia
                    .MasterKelas = Nothing
                    .Matematika = mPenjurusan.Matematika
                    .NilaiRataRata = mPenjurusan.NilaiRataRata
                    .Sosiologi = mPenjurusan.Sosiologi
                    .TahunAjaran = mPenjurusan.TahunAjaran
                    .TanggalPenilaian = DateTime.Now
                End With
            End If

            entity.SaveChanges()
        End Using
    End Sub

    Private Shared Sub Validasi(ByVal kelas As Penjurusan)

        If kelas.TahunAjaran < 2010 Then
            Throw New Exception("Tahun Ajaran harus lebih besar dari 2010")
        End If
        If kelas.MasterSiswa Is Nothing Then
            Throw New Exception("Siswa harus di isi")
        End If
    End Sub

    Public Shared Sub UpdatePenjurusan(ByVal mPenjurusan As Penjurusan)
        Validasi(mPenjurusan)
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.Penjurusan.Include("MasterSiswa") Where data.ID = mPenjurusan.ID).FirstOrDefault()
            If (query Is Nothing) Then
                Throw New Exception("Update failed, Data Penjurusan " + mPenjurusan.MasterSiswa.Nama + " tidak ditemukan")
            End If
            With query
                .BahasaIndonesia = mPenjurusan.BahasaIndonesia
                .BahasaInggris = mPenjurusan.BahasaInggris
                .TahunAjaran = mPenjurusan.TahunAjaran
                .Biologi = mPenjurusan.Biologi
                .Ekonomi = mPenjurusan.Ekonomi
                .Fisika = mPenjurusan.Fisika
                .Geografi = mPenjurusan.Geografi
                .Jurusan = mPenjurusan.Jurusan
                .Kimia = mPenjurusan.Kimia
                .MasterKelas = If(mPenjurusan.MasterKelas Is Nothing, Nothing, (From data In entity.MasterKelas Where data.ID = mPenjurusan.MasterKelas.ID Select data).FirstOrDefault())
                .MasterSiswa = (From data In entity.MasterSiswa Where data.ID = mPenjurusan.MasterSiswa.ID Select data).FirstOrDefault()
                .Matematika = mPenjurusan.Matematika
                .NilaiRataRata = mPenjurusan.NilaiRataRata
                .Sosiologi = mPenjurusan.Sosiologi
                .TahunAjaran = mPenjurusan.TahunAjaran
                .TanggalPenilaian = DateTime.Now
            End With
            entity.SaveChanges()
        End Using
    End Sub

    Public Shared Sub DeletePenjurusan(ByVal recordId As Integer)
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.Penjurusan Where data.ID = recordId).FirstOrDefault()
            If (query Is Nothing) Then
                Throw New Exception("Delete failed, Data Penjurusan tidak ditemukan")
            End If
            entity.DeleteObject(query)
            entity.SaveChanges()
        End Using
    End Sub

    Public Shared Sub SetPenjurusan(ByVal siswa As SiswaModel, ByVal kelas As MasterKelas, ByVal tahunajaran As Integer)
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.Penjurusan.Include("MasterKelas").Include("MasterSiswa") Where data.MasterSiswa.ID = siswa.ID And data.TahunAjaran = tahunajaran).FirstOrDefault()
            If (query Is Nothing) Then
                Return
            End If
            query.MasterKelas = (From data In entity.MasterKelas Where data.ID = kelas.ID).FirstOrDefault()
            entity.SaveChanges()
        End Using
    End Sub

End Class
