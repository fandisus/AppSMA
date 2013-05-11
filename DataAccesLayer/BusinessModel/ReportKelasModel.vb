Public Class ReportKelasModel
    Private _NIS As String
    Private _NamaKelas As String
    Private _NamaSiswa As String
    Private _WaliKelas As String
    Private _TahunAjaran As Integer
    Private _JenisKelamin As String

    Public Property Nis() As String
        Get
            Return _NIS
        End Get
        Set(ByVal value As String)
            _NIS = value
        End Set
    End Property

    Public Property NamaKelas() As String
        Get
            Return _NamaKelas
        End Get
        Set(ByVal value As String)
            _NamaKelas = value
        End Set
    End Property

    Public Property NamaSiswa() As String
        Get
            Return _NamaSiswa
        End Get
        Set(ByVal value As String)
            _NamaSiswa = value
        End Set
    End Property

    Public Property WaliKelas() As String
        Get
            Return _WaliKelas
        End Get
        Set(ByVal value As String)
            _WaliKelas = value
        End Set
    End Property

    Public Property TahunAjaran() As Integer
        Get
            Return _TahunAjaran
        End Get
        Set(ByVal value As Integer)
            _TahunAjaran = value
        End Set
    End Property

    Public Property JenisKelamin() As String
        Get
            Return _JenisKelamin
        End Get
        Set(ByVal value As String)
            _JenisKelamin = value
        End Set
    End Property
End Class
