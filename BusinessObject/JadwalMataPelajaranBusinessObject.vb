Namespace BusinessObject
    Public Class JadwalMataPelajaranBusinessObject
        Public Shared Function ListJadwalMataPelajaran()
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.JadwalParent.Include("MasterKelas") Order By data.TahunAjaran Descending, data.MasterKelas.NamaKelas, data.Hari).ToList()
                Return query.Select(Function(a) New With {a.ID, a.Hari, a.Jurusan, a.TahunAjaran, .KelasID = a.MasterKelas.ID, a.MasterKelas.NamaKelas}).ToList()
            End Using
        End Function
    End Class
End Namespace