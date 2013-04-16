Imports SistemAkademikSman.BusinessObject

Public Class KelasDialog

    Private Sub KelasDialogLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        TextBox1.Text = DateTime.Now.Year.ToString()
        ComboBox1.DisplayMember = "NamaKelas"
        ComboBox1.ValueMember = "ID"
        ComboBox1.DataSource = KelasBusinessObject.GetKelasByTahunAjaran(DateTime.Now.Year)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Private Sub TextBox1KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim i As Integer = 0
            Integer.TryParse(TextBox1.Text, i)
            ComboBox1.DisplayMember = "NamaKelas"
            ComboBox1.ValueMember = "ID"
            ComboBox1.DataSource = KelasBusinessObject.GetKelasByTahunAjaran(i)
            ComboBox1.SelectedText = ""
            ComboBox1.SelectedValue = Nothing
        End If
    End Sub

    Private Sub Button1Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Button2Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        Dim vform As New ReportJadwalViewer
        vform.MdiParent = MainForm
        vform.ShowReport(Convert.ToInt32(ComboBox1.SelectedValue), Convert.ToInt32(TextBox1.Text), ComboBox2.Text)
    End Sub
End Class