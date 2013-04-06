Public Class EditorJadwalMataPelajaran

    Private mlistForm As ListJadwalMataPelajaran

    Public Property ListForm() As ListJadwalMataPelajaran
        Get
            Return MlistForm
        End Get
        Set(ByVal value As ListJadwalMataPelajaran)
            mlistForm = value
        End Set
    End Property

    Public Sub Input()
        Text = "Input Jadwal Mata Pelajaran"
        Show()
    End Sub

End Class