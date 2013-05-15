Public Class UserDataObject

    Public Shared Function GetList() As List(Of MasterUser)
        Using entity As New SiakSmanEntities()
            Dim query = From data In entity.MasterUser Order By data.Username
            Return query.ToList()
        End Using
    End Function

    Public Shared Function GetUser(ByVal id As Integer) As MasterUser
        Using entity As New SiakSmanEntities()
            Dim query = From data In entity.MasterUser Where data.ID = id
            Return query.ToList().FirstOrDefault()
        End Using
    End Function

    Public Shared Sub InsertUser(ByVal muser As MasterUser)
        'Validasi(kelas)
        Using entity As New SiakSmanEntities()
            entity.AddToMasterUser(muser)
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

    Public Shared Sub UpdateUser(ByVal muser As MasterUser)
        'Validasi(kelas)
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.MasterUser Where data.ID = muser.ID).FirstOrDefault()
            If (query Is Nothing) Then
                Throw New Exception("Update failed, Username " + muser.Username + " tidak ditemukan")
            End If
            With query
                .Username = muser.Username
                .Password = muser.Password
                .IsAdministrator = muser.IsAdministrator
            End With
            entity.SaveChanges()
        End Using
    End Sub

    Public Shared Sub DeleteUser(ByVal recordId As Integer)
        Using entity As New SiakSmanEntities()
            Dim query = (From data In entity.MasterUser Where data.ID = recordId).FirstOrDefault()
            If (query Is Nothing) Then
                Throw New Exception("Delete failed, Username tidak ditemukan")
            End If
            entity.DeleteObject(query)
            entity.SaveChanges()
        End Using
    End Sub

    Public Shared Function GetUser(ByVal username As String, ByVal password As String) As MasterUser
        Using entity As New SiakSmanEntities()
            Dim query = From data In entity.MasterUser Where data.Username = username And data.Password = password
            Return query.ToList().FirstOrDefault()
        End Using
    End Function
End Class
