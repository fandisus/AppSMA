Namespace BusinessObject
    Public Class JadwalMataPelajaranBusinessObject
        Public Shared Function ListJadwalMataPelajaran()
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.JadwalParent.Include("MasterKelas") Order By data.TahunAjaran Descending, data.MasterKelas.NamaKelas, data.Hari).ToList()
                Return query.Select(Function(a) New With {a.ID, a.Hari, a.Jurusan, a.TahunAjaran, .KelasID = a.MasterKelas.ID, a.MasterKelas.NamaKelas}).ToList()
            End Using
        End Function

        Public Shared Sub Save(ByVal parent As JadwalParent, ByVal details As List(Of JadwalDetail))
            Using entity As New SiakSmanEntities()
                Dim jparent = New JadwalParent
                jparent.Hari = parent.Hari
                jparent.Jurusan = parent.Jurusan
                jparent.MasterKelas = (From data In entity.MasterKelas Where data.ID = parent.MasterKelas.ID).FirstOrDefault()
                jparent.TahunAjaran = parent.TahunAjaran

                Dim jdetail = (From detail In details Select New JadwalDetail() With { _
                        .JamIndex = detail.JamIndex, _
                        .MasterGuru = (From data In entity.MasterGuru Where data.ID = detail.MasterGuru.ID).FirstOrDefault(), _
                        .MasterMataPelajaran = (From data In entity.MasterMataPelajaran Where data.ID = detail.MasterMataPelajaran.ID).FirstOrDefault() _
                        }).ToList()

                entity.Connection.Open()
                Using transaction = entity.Connection.BeginTransaction
                    entity.AddToJadwalParent(jparent)
                    'entity.SaveChanges()
                    For Each item As JadwalDetail In jdetail
                        jparent.JadwalDetail.Add(item)

                        'item.JadwalParent = parent
                        'entity.AddToJadwalDetail(item)
                    Next
                    entity.SaveChanges()
                    transaction.Commit()
                    entity.Connection.Close()
                End Using
            End Using
        End Sub
    End Class
End Namespace