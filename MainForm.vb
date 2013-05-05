Public Class MainForm

    Private login As FormLogin

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        login = New FormLogin()

        AddHandler login.ButtonLogin.Click, AddressOf OnClickLogin
        AddHandler login.ButtonCancel.Click, AddressOf OnCancelLogin
        AddHandler login.TextBoxPassword.KeyDown, AddressOf onPasswordKeyDown
        login.ShowDialog()

    End Sub

    Private Sub OnPasswordKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            DoLogin()
        End If
    End Sub

    Private CurrentUser As MasterUser

    Private Sub OnCancelLogin(ByVal sender As Object, ByVal e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub OnClickLogin(ByVal sender As Object, ByVal e As EventArgs)
        DoLogin()
    End Sub

    Private Sub DoLogin()

        CurrentUser = UserBusinessObject.GetUser(login.TextBoxUserName.Text, login.TextBoxPassword.Text)
        If CurrentUser Is Nothing Then
            MessageBox.Show(Me, "Invalid username atau password, cek kembali username & password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        login.Close()
        If Not CurrentUser.IsAdministrator Then
            DataSiswaToolStripMenuItem.Enabled = False
            DataKaryawanToolStripMenuItem.Enabled = False
            DataGuruToolStripMenuItem.Enabled = False
            DataKelasToolStripMenuItem.Enabled = False
            PenjurusanToolStripMenuItem.Enabled = False
            DataUserToolStripMenuItem.Enabled = False
        End If
    End Sub

    Private Sub DataGuruToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DataGuruToolStripMenuItem.Click
        Dim vform As New ListGuru
        vform.MdiParent = Me
        vform.Show()
    End Sub

    Private Sub DataKaryawanToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        Dim vform As New ListKaryawan
        vform.MdiParent = Me
        vform.Show()
    End Sub

    Private Sub CascadeToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        LayoutMdi(Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub TileHorizontalToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        LayoutMdi(Windows.Forms.MdiLayout.TileHorizontal)
    End Sub

    Private Sub TileVerticalToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        LayoutMdi(Windows.Forms.MdiLayout.TileVertical)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        LayoutMdi(Windows.Forms.MdiLayout.ArrangeIcons)
    End Sub

    Private Sub DataSiswaToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DataSiswaToolStripMenuItem.Click
        Dim vform As New ListSiswa
        vform.MdiParent = Me
        vform.Show()
    End Sub

    Private Sub DataKelasToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DataKelasToolStripMenuItem.Click
        Dim vform As New ListKelas
        vform.MdiParent = Me
        vform.Show()
    End Sub

    Private Sub DataMataPelajaranToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DataMataPelajaranToolStripMenuItem.Click
        Dim vform As New ListMataPelajaran
        vform.MdiParent = Me
        vform.IsAdministrator = CurrentUser.IsAdministrator
        vform.Show()
    End Sub

    Private Sub JadwalMataPelajaranToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JadwalMataPelajaranToolStripMenuItem.Click
        Dim vform As New ListJadwalMataPelajaran
        vform.MdiParent = Me
        vform.IsAdministrator = CurrentUser.IsAdministrator
        vform.Show()
    End Sub

    Private Sub PenjurusanToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjurusanToolStripMenuItem.Click
        Dim vform As New ListPenjurusan
        vform.MdiParent = Me
        vform.Show()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataUserToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles DataUserToolStripMenuItem.Click
        Dim fform As New ListUser
        fform.MdiParent = Me
        fform.Show()
    End Sub


    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()

    End Sub
End Class
