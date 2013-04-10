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
        LoadMataPelajaran(Convert.ToInt32(TextBoxTahunAjaran.Text))
        LoadGuru()
        Show()
        AddHandler ButtonSimpan.Click, AddressOf SaveJadwalMatapelajaran
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

    Private Sub LoadMataPelajaran(ByVal tahunAjaran As Integer)
        Dim masterMataPelajarans = MataPelajaraBusinessObject.GetList(tahunAjaran)
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

    Private Sub SaveJadwalMatapelajaran(ByVal sender As System.Object, ByVal e As EventArgs)
        Try
            Dim result = MessageBox.Show(Me, "Simpan Jadwal Mata Pelajaran ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If
            Dim jparent As JadwalParent = CreateJadwalParent()
            Dim jdetails As List(Of JadwalDetail) = CreateJadwalDetail()
            JadwalMataPelajaranBusinessObject.Save(jparent, jdetails)
            ListForm.LoadData()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Function CreateJadwalParent() As JadwalParent

        Dim jparent = New JadwalParent
        jparent.TahunAjaran = Convert.ToInt32(TextBoxTahunAjaran.Text)
        jparent.Hari = ComboBoxHari.Text
        jparent.Jurusan = ComboBoxJurusan.Text
        jparent.MasterKelas = KelasBusinessObject.GetKelas(Convert.ToInt32(ComboBoxKelas.SelectedValue))
        Return jparent
    End Function

    Private Function CreateJadwalDetail()

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
        Return jdetails
    End Function

    Private currentId As Integer
    Public Sub Edit(ByVal cid As Integer)
        currentId = cid
        Text = "Edit Jadwal Mata Pelajaran"
        pjadwal = JadwalMataPelajaranBusinessObject.GetJadwalMataPelajaran(cid)
        LoadKelas()
        LoadMataPelajaran(pjadwal.TahunAjaran)
        LoadGuru()
        LoadJadwal(pjadwal)
        Show()
        AddHandler ButtonSimpan.Click, AddressOf UpdateMataPelajaran
    End Sub

    Private pjadwal As JadwalParent
    Private Sub UpdateMataPelajaran(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Dim result = MessageBox.Show(Me, "Update Jadwal Mata Pelajaran ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Return
            End If
            Dim jparent As JadwalParent = CreateJadwalParent()
            jparent.ID = currentId
            Dim jdetails As List(Of JadwalDetail) = UpdateJadwalDetail()
            JadwalMataPelajaranBusinessObject.Update(jparent, jdetails)
            ListForm.LoadData()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function UpdateJadwalDetail() As List(Of JadwalDetail)
        Dim jdetails As List(Of JadwalDetail) = (From o In pjadwal.JadwalDetail Where o.JamIndex = 1 Select New JadwalDetail() With {.ID = o.ID, .JamIndex = 1, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru1.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel1.SelectedValue)}}).ToList()


        jdetails.AddRange(From o In pjadwal.JadwalDetail Where o.JamIndex = 2 Select New JadwalDetail() With {.JamIndex = 2, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru2.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel2.SelectedValue)}})

        jdetails.AddRange(From o In pjadwal.JadwalDetail Where o.JamIndex = 3 Select New JadwalDetail() With {.JamIndex = 3, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru3.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel3.SelectedValue)}})

        jdetails.AddRange(From o In pjadwal.JadwalDetail Where o.JamIndex = 4 Select New JadwalDetail() With {.JamIndex = 4, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru4.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel4.SelectedValue)}})

        jdetails.AddRange(From o In pjadwal.JadwalDetail Where o.JamIndex = 5 Select New JadwalDetail() With {.JamIndex = 5, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru5.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel5.SelectedValue)}})

        jdetails.AddRange(From o In pjadwal.JadwalDetail Where o.JamIndex = 6 Select New JadwalDetail() With {.JamIndex = 6, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru6.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel6.SelectedValue)}})

        jdetails.AddRange(From o In pjadwal.JadwalDetail Where o.JamIndex = 7 Select New JadwalDetail() With {.JamIndex = 7, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru7.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel7.SelectedValue)}})

        jdetails.AddRange(From o In pjadwal.JadwalDetail Where o.JamIndex = 8 Select New JadwalDetail() With {.JamIndex = 8, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru8.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel8.SelectedValue)}})

        jdetails.AddRange(From o In pjadwal.JadwalDetail Where o.JamIndex = 9 Select New JadwalDetail() With {.JamIndex = 9, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru9.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel9.SelectedValue)}})

        jdetails.AddRange(From o In pjadwal.JadwalDetail Where o.JamIndex = 10 Select New JadwalDetail() With {.JamIndex = 10, .MasterGuru = New MasterGuru() With {.ID = ComboBoxGuru9.SelectedValue}, .MasterMataPelajaran = New MasterMataPelajaran() With {.ID = Convert.ToInt32(ComboBoxMatPel10.SelectedValue)}})
        Return jdetails
    End Function


    Private Sub LoadJadwal(ByVal jadwal As JadwalParent)
        TextBoxTahunAjaran.Text = jadwal.TahunAjaran
        ComboBoxKelas.SelectedValue = jadwal.MasterKelas.ID
        ComboBoxJurusan.Text = jadwal.Jurusan
        ComboBoxHari.Text = jadwal.Hari
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 1
            ComboBoxGuru1.SelectedValue = item.MasterGuru.ID
            ComboBoxMatPel1.SelectedValue = item.MasterMataPelajaran.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 2
            ComboBoxGuru2.SelectedValue = item.MasterGuru.ID
            ComboBoxMatPel2.SelectedValue = item.MasterMataPelajaran.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 3
            ComboBoxGuru3.SelectedValue = item.MasterGuru.ID
            ComboBoxMatPel3.SelectedValue = item.MasterMataPelajaran.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 4
            ComboBoxGuru4.SelectedValue = item.MasterGuru.ID
            ComboBoxMatPel4.SelectedValue = item.MasterMataPelajaran.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 5
            ComboBoxGuru5.SelectedValue = item.MasterGuru.ID
            ComboBoxMatPel5.SelectedValue = item.MasterMataPelajaran.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 6
            ComboBoxGuru6.SelectedValue = item.MasterGuru.ID
            ComboBoxMatPel6.SelectedValue = item.MasterMataPelajaran.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 7
            ComboBoxGuru7.SelectedValue = item.MasterGuru.ID
            ComboBoxMatPel7.SelectedValue = item.MasterMataPelajaran.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 8
            ComboBoxGuru8.SelectedValue = item.MasterGuru.ID
            ComboBoxMatPel8.SelectedValue = item.MasterMataPelajaran.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 9
            ComboBoxGuru9.SelectedValue = item.MasterGuru.ID
            ComboBoxMatPel9.SelectedValue = item.MasterMataPelajaran.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 10
            ComboBoxGuru10.SelectedValue = item.MasterGuru.ID
            ComboBoxMatPel10.SelectedValue = item.MasterMataPelajaran.ID
        Next
    End Sub
End Class