Public Class ReportJadwalModel
    Private _NamaKelas As String
    Private _TahunAjaran As Integer
    Private _WaliKelas As String
    Private _IndexJadwal As Integer
    Private _MataPelajaran As String

    Private _Hari As String

    Private _Jurusan As String

    Public Property Jurusan() As String
        Get
            Return _Jurusan
        End Get
        Set(ByVal value As String)
            _Jurusan = value
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

    Public Property TahunAjaran() As Integer
        Get
            Return _TahunAjaran
        End Get
        Set(ByVal value As Integer)
            _TahunAjaran = value
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

    Public Property Hari() As String
        Get
            Return _Hari
        End Get
        Set(ByVal value As String)
            _Hari = value
        End Set
    End Property

    Public Property IndexJadwal() As Integer
        Get
            Return _IndexJadwal
        End Get
        Set(ByVal value As Integer)
            _IndexJadwal = value
        End Set
    End Property

    Public Property MataPelajaran() As String
        Get
            Return _MataPelajaran
        End Get
        Set(ByVal value As String)
            _MataPelajaran = value
        End Set
    End Property
End Class
