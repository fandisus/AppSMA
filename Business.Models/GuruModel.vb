
Imports Siak.BusinessModel.Interfaces

<Serializable()> _
Public Class GuruModel
    Implements IGuruModel

    Public Property Nama() As String Implements IGuruModel.Nama
    Public Property ID() As Integer Implements IGuruModel.ID
    Public Property NIP() As String Implements IGuruModel.NIP
    Public Property GuruID() As String Implements IGuruModel.GuruID
    Public Property JenisKelamin() As String Implements IGuruModel.JenisKelamin
    Public Property TempatLahir() As String Implements IGuruModel.TempatLahir
    Public Property TanggalLahir() As Date Implements IGuruModel.TanggalLahir
    Public Property Agama() As String Implements IGuruModel.Agama
    Public Property Email() As String Implements IGuruModel.Email
    Public Property Alamat() As String Implements IGuruModel.Alamat
    Public Property Kota() As String Implements IGuruModel.Kota
    Public Property KodePos() As String Implements IGuruModel.KodePos
    Public Property NoTelephone() As String Implements IGuruModel.NoTelephone
    Public Property NoHP() As String Implements IGuruModel.NoHP
    Public Property Photo() As Byte() Implements IGuruModel.Photo

End Class
