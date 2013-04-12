Public Class PenjurusanBusinessObject

    Public Shared Function GetList()
        Using entity As New SiakSmanEntities()
            Dim query = From data In entity.Penjurusan.Include("MasterKelas").Include("MasterSiswa") Order By data.TahunAjaran Descending, data.MasterKelas.NamaKelas, data.MasterSiswa.Nama

            Return query.Select(Function(a) New With {a.ID, a.BahasaIndonesia, a.BahasaInggris, a.Biologi, a.Ekonomi, a.Fisika, a.Geografi, a.Jurusan, a.Kimia, .KelasID = a.MasterKelas.ID, a.MasterKelas.NamaKelas, a.MasterSiswa.Nama, a.Matematika, a.NilaiRataRata, a.Sosiologi, a.TahunAjaran, a.TanggalPenilaian, a.MasterSiswa.NIS}).ToList()
        End Using
    End Function
End Class
