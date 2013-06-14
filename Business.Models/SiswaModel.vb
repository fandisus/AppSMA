Imports Siak.BusinessModel.Interfaces
<Serializable()> _
Public Class SiswaModel
    Implements ISiswaModel

    Public Property ID() As Integer Implements ISiswaModel.ID
    Public Property Agama() As String Implements ISiswaModel.Agama
    Public Property Alamat() As String Implements ISiswaModel.Alamat
    Public Property AlamatOrangTua() As String Implements ISiswaModel.AlamatOrangTua
    Public Property Email() As String Implements ISiswaModel.Email
    Public Property JenisKelamin() As String Implements ISiswaModel.JenisKelamin
    Public Property KodePos() As String Implements ISiswaModel.KodePos
    Public Property KodePosOrangTua() As String Implements ISiswaModel.KodePosOrangTua
    Public Property Kota() As String Implements ISiswaModel.Kota
    Public Property KotaOrangTua() As String Implements ISiswaModel.KotaOrangTua
    Public Property Nama() As String Implements ISiswaModel.Nama
    Public Property NamaAyah() As String Implements ISiswaModel.NamaAyah
    Public Property NamaIbu() As String Implements ISiswaModel.NamaIbu
    Public Property NamaSMPAsal() As String Implements ISiswaModel.NamaSMPAsal
    Public Property NoHP() As String Implements ISiswaModel.NoHP
    Public Property NoHPOrangTua() As String Implements ISiswaModel.NoHPOrangTua
    Public Property NoTelephone() As String Implements ISiswaModel.NoTelephone
    Public Property NoTelephoneOrangTua() As String Implements ISiswaModel.NoTelephoneOrangTua
    Public Property Penjurusan() As String Implements ISiswaModel.Penjurusan
    Public Property TempatLahir() As String Implements ISiswaModel.TempatLahir
    Public Property Photo() As Byte() Implements ISiswaModel.Photo
    Public Property TanggalLahir() As Date Implements ISiswaModel.TanggalLahir
    Public Property TanggalMasuk() As Date Implements ISiswaModel.TanggalMasuk
    Public Property NIS() As String Implements ISiswaModel.NIS
End Class