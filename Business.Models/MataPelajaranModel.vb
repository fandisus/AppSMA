Imports Siak.BusinessModel.Interfaces

Public Class MataPelajaranModel
    Implements IMataPelajaranModel

    Public Property ID() As Integer Implements IMataPelajaranModel.ID
    Public Property TahunAjaran() As String Implements IMataPelajaranModel.TahunAjaran
    Public Property MataPelajaran() As String Implements IMataPelajaranModel.MataPelajaran
    Public Property Silabus() As String Implements IMataPelajaranModel.Silabus
End Class
