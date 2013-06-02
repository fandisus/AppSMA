Imports SistemAkademikSman.GuruServiceReference
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
        Using masterGuruServiceSoapClient = New MasterGuruServiceSoapClient()
            Dim sourceGuru = masterGuruServiceSoapClient.GetAllGuru().OrderBy(Function(a) a.Nama).ToList()
            For Each comboBox In From a As Control In SplitContainer1.Panel1.Controls _
                                 Let comboBox1 = TryCast(a, ComboBox) _
                                 Where (comboBox1 IsNot Nothing) _
                                 Where a.Name.Contains("ComboBoxGuru") Select comboBox1
                comboBox.DisplayMember = "Nama"
                comboBox.ValueMember = "ID"
                comboBox.DataSource = sourceGuru.ToArray().Clone()
                comboBox.SelectedValue = String.Empty
            Next
        End Using
        
    End Sub

    Private Sub MataPelajaranSelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim source = CType(sender, ComboBox)
        Dim data = MataPelajaraBusinessObject.GetMataPelajaran(Convert.ToInt32(source.SelectedValue))
        If data Is Nothing Then
            Return
        End If
        RichTextBox1.Text = data.Silabus
        Dim matapelcombo = CType(sender, ComboBox)
        Dim index = matapelcombo.Name.Replace("ComboBoxMatPel", "")
        Using masterGuruServiceSoapClient = New MasterGuruServiceSoapClient()
            For Each comboBox In From a As Control In SplitContainer1.Panel1.Controls _
                             Let comboBox1 = TryCast(a, ComboBox) _
                             Where (comboBox1 IsNot Nothing) _
                             Where a.Name.Contains("ComboBoxGuru" & index) Select comboBox1
                Dim sourceGuru = masterGuruServiceSoapClient.GetGuruByMataPelajaranTahunAjaran(Convert.ToInt32(matapelcombo.SelectedValue), Convert.ToInt32(TextBoxTahunAjaran.Text))
                comboBox.DisplayMember = "Nama"
                comboBox.ValueMember = "ID"
                comboBox.DataSource = sourceGuru.ToArray().Clone()
                comboBox.SelectedValue = String.Empty
            Next
        End Using
        
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
        ComboBoxKelas.DataSource = KelasBusinessObject.GetKelasByTahunAjaran(Convert.ToInt32(TextBoxTahunAjaran.Text)).ToList()
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
            Close()
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
        TextBoxTahunAjaran.Text = pjadwal.TahunAjaran
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
            Close()
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
            ComboBoxMatPel1.SelectedValue = item.MasterMataPelajaran.ID
            ComboBoxGuru1.SelectedValue = item.MasterGuru.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 2
            ComboBoxMatPel2.SelectedValue = item.MasterMataPelajaran.ID
            ComboBoxGuru2.SelectedValue = item.MasterGuru.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 3
            ComboBoxMatPel3.SelectedValue = item.MasterMataPelajaran.ID
            ComboBoxGuru3.SelectedValue = item.MasterGuru.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 4
            ComboBoxMatPel4.SelectedValue = item.MasterMataPelajaran.ID
            ComboBoxGuru4.SelectedValue = item.MasterGuru.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 5
            ComboBoxMatPel5.SelectedValue = item.MasterMataPelajaran.ID
            ComboBoxGuru5.SelectedValue = item.MasterGuru.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 6
            ComboBoxMatPel6.SelectedValue = item.MasterMataPelajaran.ID
            ComboBoxGuru6.SelectedValue = item.MasterGuru.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 7
            ComboBoxMatPel7.SelectedValue = item.MasterMataPelajaran.ID
            ComboBoxGuru7.SelectedValue = item.MasterGuru.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 8
            ComboBoxMatPel8.SelectedValue = item.MasterMataPelajaran.ID
            ComboBoxGuru8.SelectedValue = item.MasterGuru.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 9
            ComboBoxMatPel9.SelectedValue = item.MasterMataPelajaran.ID
            ComboBoxGuru9.SelectedValue = item.MasterGuru.ID
        Next
        For Each item As JadwalDetail In From item1 In jadwal.JadwalDetail Where item1.JamIndex = 10
            ComboBoxMatPel10.SelectedValue = item.MasterMataPelajaran.ID
            ComboBoxGuru10.SelectedValue = item.MasterGuru.ID
        Next
    End Sub

    Private Sub ButtonKeluarClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonKeluar.Click
        Close()
    End Sub

    Private Sub TextBoxTahunAjaran_KeyDown(ByVal sender As System.Object, ByVal e As Windows.Forms.KeyEventArgs) Handles TextBoxTahunAjaran.KeyDown
        If e.KeyCode = Keys.Enter Then
            LoadKelas()
            LoadMataPelajaran(Convert.ToInt32(TextBoxTahunAjaran.Text))
        End If
    End Sub
End Class