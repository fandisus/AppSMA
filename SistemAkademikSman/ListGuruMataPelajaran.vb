Imports SistemAkademikSman.BusinessModel
Imports SistemAkademikSman.BusinessObject

Public Class ListGuruMataPelajaran

    Private Sub ListGuruMataPelajaranLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        TextBox1.Text = DateTime.Now.Year.ToString()
        LoadComboBarang()
        AddHandler DataGridView1.UserAddedRow, AddressOf DataGridViewUserAddedRow
        AddHandler DataGridView1.UserDeletingRow, AddressOf DataGridViewUserDeletingRow
        AddHandler DataGridView1.RowsAdded, AddressOf DataGridViewRowsAdded
    End Sub

    Private Sub DataGridViewRowsAdded(ByVal sender As Object, ByVal e As DataGridViewRowsAddedEventArgs)
        If DataGridView1.CurrentRow Is Nothing Then
            Return
        End If
        If DataGridView1.CurrentRow.Cells("Crud").Value Is Nothing Then
            DataGridView1.CurrentRow.Cells("Crud").Value = 1
        End If
    End Sub

    Private Sub DataGridViewUserDeletingRow(ByVal sender As Object, ByVal e As DataGridViewRowCancelEventArgs)
        If e.Row.Cells("Crud").Value = 1 Then
            e.Cancel = False
        ElseIf e.Row.Cells("Crud").Value = 0 Or e.Row.Cells("Crud").Value = 2 Then
            e.Row.DefaultCellStyle.BackColor = Color.Red
            e.Row.DefaultCellStyle.ForeColor = Color.WhiteSmoke
            e.Row.Cells("Crud").Value = 3
            e.Cancel = True
        ElseIf e.Row.Cells("Crud").Value = 3 Then
            e.Row.DefaultCellStyle.BackColor = Color.White
            e.Row.DefaultCellStyle.ForeColor = Color.Black
            e.Row.Cells("Crud").Value = 2
            e.Cancel = True
        End If
    End Sub

    Private Sub DataGridViewUserAddedRow(ByVal sender As Object, ByVal e As DataGridViewRowEventArgs)
        Dim row = DataGridView1.CurrentRow
        If Not row.IsNewRow Then
            If row.Cells("Crud").Value = 0 Then
                row.Cells("Crud").Value = 2
            End If
        End If
    End Sub

    Private Sub LoadComboBarang()
        DataGridView1.Rows.Clear()
        Dim mataPelajaranCombo = CType(DataGridView1.Columns("MataPelajaranID"), DataGridViewComboBoxColumn)
        mataPelajaranCombo.DisplayMember = "MataPelajaran"
        mataPelajaranCombo.ValueMember = "ID"
        mataPelajaranCombo.DataSource = MataPelajaraBusinessObject.GetList(Convert.ToInt32(TextBox1.Text))

        Dim source = MataPelajaraBusinessObject.GetMataPelajaran(GuruId, Convert.ToInt32(TextBox1.Text))
        For Each item In source
            Dim rows = DataGridView1.Rows(DataGridView1.Rows.Add())
            rows.Cells("Crud").Value = 0
            rows.Cells("ID").Value = item.ID
            rows.Cells("MataPelajaranID").Value = item.MasterMataPelajaran.ID
        Next
    End Sub

    Private Sub TextBox1KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadComboBarang()
        End If
        
    End Sub

    Private mGuruId As Integer

    Friend Property GuruId() As Integer
        Private Get
            Return mGuruId
        End Get
        Set(ByVal value As Integer)
            mGuruId = value
        End Set
    End Property

    Private Sub ButtonKeluarClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonKeluar.Click
        Close()
    End Sub

    Private Sub ButtonSimpanClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonSimpan.Click
        Try
            Dim list = New List(Of GuruMataPelajaranModel)
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.IsNewRow Then
                    Continue For
                End If
                Dim item = New GuruMataPelajaranModel
                item.Crud = Convert.ToInt32(row.Cells("Crud").Value)
                item.GuruId = GuruId
                item.MataPelajaranId = Convert.ToInt32(row.Cells("MataPelajaranID").Value)
                item.Id = Convert.ToInt32(row.Cells("ID").Value)
                list.Add(item)
            Next
            GuruBusinessObject.SubmitGuruMataPelajaran(list)
            MessageBox.Show(Me, "Mata pelajaran Guru berhasil Disimpan", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        Catch ex As Exception
            MessageBox.Show(Me, GetMessage(ex), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Private Shared Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If "X1234567890".IndexOf(e.KeyChar.ToString(), StringComparison.Ordinal) > 0 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class