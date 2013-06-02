

Imports Siak.BusinessModel.Interfaces
<Serializable()> _
Public Class GuruMataPelajaranModel
    Implements IGuruMataPelajaranModel

    Public Property Id() As Integer Implements IGuruMataPelajaranModel.Id
    Public Property MataPelajaranId() As Integer Implements IGuruMataPelajaranModel.MataPelajaranId
    Public Property GuruId() As Integer Implements IGuruMataPelajaranModel.GuruId
    Public Property Crud() As Integer Implements IGuruMataPelajaranModel.Crud

End Class