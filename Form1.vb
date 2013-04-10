Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rnd = New Random()
        Dim i = rnd.Next(0, 8)
        TabControl1.SelectTab(i)
    End Sub
End Class