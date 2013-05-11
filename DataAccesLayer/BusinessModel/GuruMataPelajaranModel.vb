Namespace BusinessModel
    Public Class GuruMataPelajaranModel
        Private _ID As Integer
        Private _MataPelajaranID As Integer
        Private _GuruID As Integer
        Private _Crud As Integer

        Public Property Id() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property

        Public Property MataPelajaranId() As Integer
            Get
                Return _MataPelajaranID
            End Get
            Set(ByVal value As Integer)
                _MataPelajaranID = value
            End Set
        End Property

        Public Property GuruId() As Integer
            Get
                Return _GuruID
            End Get
            Set(ByVal value As Integer)
                _GuruID = value
            End Set
        End Property

        Public Property Crud() As Integer
            Get
                Return _Crud
            End Get
            Set(ByVal value As Integer)
                _Crud = value
            End Set
        End Property
    End Class
End Namespace