Imports System.Net.Mail

Namespace BusinessObject
    Public Class KelasBusinessObject
        Public Shared Function GetList() As List(Of MasterKelas)
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterKelas Order By data.TahunAjaran Descending, data.Tingkat Ascending, data.NamaKelas Ascending
                Return query.ToList()
            End Using
        End Function

        Public Shared Function GetKelas(ByVal id As Integer) As MasterKelas
            Using entity As New SiakSmanEntities()
                Dim query = From data In entity.MasterKelas Where data.ID = id
                Return query.ToList().FirstOrDefault()
            End Using
        End Function
        Public Shared Sub InsertKelas(ByVal kelas As MasterKelas)
            Validasi(kelas)
            Using entity As New SiakSmanEntities()
                entity.AddToMasterKelas(kelas)
                entity.SaveChanges()
            End Using
        End Sub

        Private Shared Sub Validasi(ByVal kelas As MasterKelas)

            If kelas.TahunAjaran = 0 Then
                Throw New Exception("Tahun Ajaran harus diisi")
            End If
            If kelas.Tingkat = 0 Then
                Throw New Exception("Kelas / Tingkat harus diisi")
            End If
            If kelas.NamaKelas.Length = 0 Then
                Throw New Exception("Nama Kelas harus diisi")
            End If
        End Sub

        Public Shared Sub UpdateKelas(ByVal kelas As MasterKelas)
            Validasi(kelas)
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.MasterKelas Where data.ID = kelas.ID).FirstOrDefault()
                If (query Is Nothing) Then
                    Throw New Exception("Update failed, Data Kelas " + kelas.NamaKelas + " tidak ditemukan")
                End If
                With query
                    .Keterangan = kelas.Keterangan
                    .NamaKelas = kelas.NamaKelas
                    .TahunAjaran = kelas.TahunAjaran
                    .Tingkat = kelas.Tingkat
                End With
                entity.SaveChanges()
            End Using
        End Sub

        Public Shared Sub DeleteKelas(ByVal recordId As Integer)
            Using entity As New SiakSmanEntities()
                Dim query = (From data In entity.MasterKelas Where data.ID = recordId).FirstOrDefault()
                If (query Is Nothing) Then
                    Throw New Exception("Delete failed, Data Kelas tidak ditemukan")
                End If
                entity.DeleteObject(query)
                entity.SaveChanges()
            End Using
        End Sub
    End Class
End Namespace