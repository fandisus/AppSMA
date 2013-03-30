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

    Private Sub DataSiswaToolStripMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataSiswaToolStripMenuItem.Click
        Dim vform As New ListSiswa
        vform.MdiParent = Me
        vform.Show()
    End Sub
End Class
