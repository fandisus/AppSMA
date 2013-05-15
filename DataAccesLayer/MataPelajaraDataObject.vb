Namespace BusinessObject
    Public Class MataPelajaraBusinessObject
        Public Shared Function GetList() As List(Of MasterMataPelajaran)
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterMataPelajaran Order By data.TahunAjaran Descending, data.MataPelajaran Ascending
                Return query.ToList()
            End Using
        End Function

        Public Shared Function GetList(ByVal tahunAjaran As Integer) As List(Of MasterMataPelajaran)
            If tahunAjaran <= 2010 Then
                Throw New Exception("Tahun Ajaran Harus Lebih Besar dari Tahun 2010")
            End If
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterMataPelajaran Where data.TahunAjaran = tahunAjaran Order By data.TahunAjaran Descending, data.MataPelajaran Ascending
                Return query.ToList()
            End Using
        End Function

        Public Shared Function GetMataPelajaran(ByVal id As Integer) As MasterMataPelajaran
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterMataPelajaran Where data.ID = id
                Return query.ToList().FirstOrDefault()
            End Using
        End Function

        Public Shared Function GetMataPelajaran(ByVal guruid As Integer, ByVal tahun As Integer) As List(Of GuruMataPelajaran)
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.GuruMataPelajaran.Include("MasterGuru").Include("MasterMataPelajaran") Where data.MasterGuru.ID = guruid And data.MasterMataPelajaran.TahunAjaran = tahun Select data
                Return query.ToList()
            End Using
        End Function

        Public Shared Sub InsertMataPelajaran(ByVal mataPelajaran As MasterMataPelajaran)
            Validasi(mataPelajaran)
            Using entity As New SiakSmanEntities()
                entity.AddToMasterMataPelajaran(mataPelajaran)
                entity.SaveChanges()
            End Using
        End Sub

        Private Shared Sub Validasi(ByVal mataPelajaran As MasterMataPelajaran)

            If mataPelajaran.TahunAjaran = 0 Then
                Throw New Exception("Tahun Ajaran harus diisi")
            End If
            If mataPelajaran.MataPelajaran.Length = 0 Then
                Throw New Exception("Nama Mata Pelajaran harus diisi")
            End If
        End Sub

        Public Shared Sub UpdateMataPelajaran(ByVal mataPelajaran As MasterMataPelajaran)
            Validasi(mataPelajaran)
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.MasterMataPelajaran Where data.ID = mataPelajaran.ID).FirstOrDefault()
                If (query Is Nothing) Then
                    Throw New Exception("Update failed, Data Mata Pelajaran " + mataPelajaran.MataPelajaran + " tidak ditemukan")
                End If
                With query
                    .MataPelajaran = mataPelajaran.MataPelajaran
                    .Silabus = mataPelajaran.Silabus
                    .TahunAjaran = mataPelajaran.TahunAjaran
                End With
                entity.SaveChanges()
            End Using
        End Sub

        Public Shared Sub DeleteMataPelajaran(ByVal recordId As Integer)
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.MasterMataPelajaran Where data.ID = recordId).FirstOrDefault()
                If (query Is Nothing) Then
                    Throw New Exception("Delete failed, Data Mata Pelajaran tidak ditemukan")
                End If
                entity.DeleteObject(query)
                entity.SaveChanges()
            End Using
        End Sub

    End Class
End Namespace