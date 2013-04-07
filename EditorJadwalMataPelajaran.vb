Imports SistemAkademikSman.BusinessObject

Public Class EditorJadwalMataPelajaran

    Private mlistForm As ListJadwalMataPelajaran

    Public Property ListForm() As ListJadwalMataPelajaran
        Get
            Return mlistForm
        End Get
        Set(ByVal value As ListJadwalMataPelajaran)
            mlistForm = value
        End Set
    End Property

    Public Sub Input()
        Text = "Input Jadwal Mata Pelajaran"
        TextBoxTahunAjaran.Text = DateTime.Now.Year.ToString()
        LoadKelas()
        LoadMataPelajaran()
        LoadGuru()
        Show()
    End Sub

    Private Sub LoadGuru()
        Dim sourceGuru = GuruBusinessObject.GetList().OrderBy(Function(a) a.Nama).ToList()
        For Each comboBox In From a As Control In SplitContainer1.Panel1.Controls _
                             Let comboBox1 = TryCast(a, ComboBox) _
                             Where (comboBox1 IsNot Nothing) _
                             Where a.Name.Contains("ComboBoxGuru") Select comboBox1
            comboBox.DisplayMember = "Nama"
            comboBox.ValueMember = "ID"
            comboBox.DataSource = sourceGuru.ToArray().Clone()
            comboBox.SelectedValue = String.Empty

        Next
    End Sub

    Private Sub MataPelajaranSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim source = CType(sender, ComboBox)
        Dim a = MataPelajaraBusinessObject.GetMataPelajaran(Convert.ToInt32(source.SelectedValue))
        RichTextBox1.Text = a.Silabus
    End Sub

    Private Sub LoadMataPelajaran()
        Dim masterMataPelajarans = MataPelajaraBusinessObject.GetList(Convert.ToInt32(TextBoxTahunAjaran.Text))
        For Each comboBox In From a As Control In SplitContainer1.Panel1.Controls _
                             Let comboBox1 = TryCast(a, ComboBox) _
                             Where (comboBox1 IsNot Nothing) _
                             Where a.Name.Contains("ComboBoxMatPel") Select comboBox1
            comboBox.DisplayMember = "MataPelajaran"
            comboBox.ValueMember = "ID"
            comboBox.DataSource = masterMataPelajarans.ToArray().Clone()
            comboBox.SelectedValue = String.Empty
            AddHandler comboBox.SelectedValueChanged, AddressOf MataPelajaranSelectedValueChanged
        Next
    End Sub

    Private Sub LoadKelas()
        ComboBoxKelas.DisplayMember = "NamaKelas"
        ComboBoxKelas.ValueMember = "ID"
        ComboBoxKelas.DataSource = KelasBusinessObject.GetList().ToList()
    End Sub

    Private Sub ButtonSimpanClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonSimpan.Click
        Dim result = MessageBox.Show(Me, "Simpan Jadwal Mata Pelajaran ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Return
        End If
        Dim jparent = New JadwalParent
        jparent.TahunAjaran = Convert.ToInt32(TextBoxTahunAjaran.Text)
        jparent.Hari = ComboBoxHari.Text
        jparent.Jurusan = ComboBoxJurusan.Text
        jparent.MasterKelas = KelasBusinessObject.GetKelas(Convert.ToInt32(ComboBoxKelas.SelectedValue))
        Dim jdetails As New List(Of JadwalDetail)()
        jdetails.Add(New JadwalDetail() With {.JamIndex = 1, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru1.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel1.SelectedValue)}})
        jdetails.Add(New JadwalDetail() With {.JamIndex = 2, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru2.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel2.SelectedValue)}})
        jdetails.Add(New JadwalDetail() With {.JamIndex = 3, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru3.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel3.SelectedValue)}})
        jdetails.Add(New JadwalDetail() With {.JamIndex = 4, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru4.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel4.SelectedValue)}})
        jdetails.Add(New JadwalDetail() With {.JamIndex = 5, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru5.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel5.SelectedValue)}})
        jdetails.Add(New JadwalDetail() With {.JamIndex = 6, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru6.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel6.SelectedValue)}})
        jdetails.Add(New JadwalDetail() With {.JamIndex = 7, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru7.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel7.SelectedValue)}})
        jdetails.Add(New JadwalDetail() With {.JamIndex = 8, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru8.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel8.SelectedValue)}})
        jdetails.Add(New JadwalDetail() With {.JamIndex = 9, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru9.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel9.SelectedValue)}})
        jdetails.Add(New JadwalDetail() With {.JamIndex = 10, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru10.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel10.SelectedValue)}})
        JadwalMataPelajaranBusinessObject.Save(jparent, jdetails)
    End Sub
End Class