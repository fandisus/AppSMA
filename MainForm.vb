Public Class MainForm

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
        vform.Show()
    End Sub

    Private Sub JadwalMataPelajaranToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JadwalMataPelajaranToolStripMenuItem.Click
        Dim vform As New ListJadwalMataPelajaran
        vform.MdiParent = Me
        vform.Show()
    End Sub

    Private Sub PenjurusanToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PenjurusanToolStripMenuItem.Click
        Dim vform As New ListPenjurusan
        vform.MdiParent = Me
        vform.Show()
    End Sub
End Class
