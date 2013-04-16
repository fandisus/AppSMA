Imports SistemAkademikSman.BusinessObject

Public Class FormGeneratePembagianKelas

    Private Sub FormGeneratePembagianKelasLoad(ByVal sender As System.Object, ByVal e As EventArgs) Handles MyBase.Load
        TextBoxTahunAjaran.Text = DateTime.Now.Year.ToString()
    End Sub

    Private Sub ButtonGenerateClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonGenerate.Click
        If CheckBoxPenjurusan.Checked Then
            GennerateDenganPenjurusan("IPA")
            GennerateDenganPenjurusan("IPS")
        Else
            GeneratePembagianKelas()
        End If
    End Sub

    Private Sub GeneratePembagianKelas()
        If Convert.ToInt32(TextBoxTahunAjaran.Text) < 2010 Then
            MessageBox.Show(Me, "Tahun Ajaran harus lebih besar dari Tahun 2010", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Convert.ToInt32(TextBoxTahunAngkatan.Text) < 2010 Then
            MessageBox.Show(Me, "Tahun Angkatan harus lebih besar dari Tahun 2010", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ComboBoxTingkat.Text.Length = 0 Then
            MessageBox.Show(Me, "Tahun Angkatan harus lebih besar dari Tahun 2010", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim listSiswa = SiswaBusinessObject.GetSiswaByTahunAngkatan(TextBoxTahunAngkatan.Text)
        If listSiswa.Count = 0 Then
            MessageBox.Show(Me, "Tidak data siswa Tahun Angkatan " + TextBoxTahunAngkatan.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim listKelas = KelasBusinessObject.GetKelasByTahunAjaran(Convert.ToInt32(TextBoxTahunAjaran.Text), Convert.ToInt32(ComboBoxTingkat.Text))
        If listKelas.Count = 0 Then
            MessageBox.Show(Me, "Tidak data kelas Tahun Ajaran " + TextBoxTahunAjaran.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim totalSiswa = listSiswa.Count
        Dim totalKelas = listKelas.Count
        Dim counterDistribution = 0
        Dim perempuan = listSiswa.Where(Function(nSiswa) nSiswa.JenisKelamin.ToLower().Equals("perempuan")).OrderBy(Function(nSiswa) nSiswa.Nama)
        Dim lakilaki = listSiswa.Where(Function(nSiswa) nSiswa.JenisKelamin.ToLower().Equals("laki-laki")).OrderBy(Function(nSiswa) nSiswa.Nama)
        Const letter As String = "abcdefghijklmnopqrstuvwxyz"

        For i As Integer = 0 To letter.Length - 1
            Dim alpha = letter.Substring(i, 1)
            Dim csiswa = perempuan.Where(Function(a) a.Nama.ToLower().StartsWith(alpha)) '.OrderBy(Function() rnd.Next())
            For Each j As MasterSiswa In csiswa
                PenjurusanBusinessObject.SetPenjurusan(j, listKelas(counterDistribution), Convert.ToInt32(TextBoxTahunAjaran.Text))
                If counterDistribution >= (totalKelas - 1) Then
                    counterDistribution = 0
                Else
                    counterDistribution += 1
                End If
            Next
        Next

        For i As Integer = 0 To letter.Length - 1
            Dim alpha = letter.Substring(i, 1)
            Dim csiswa = lakilaki.Where(Function(a) a.Nama.ToLower().StartsWith(alpha)) '.OrderBy(Function() rnd.Next())
            For Each j As MasterSiswa In csiswa
                PenjurusanBusinessObject.SetPenjurusan(j, listKelas(counterDistribution), Convert.ToInt32(TextBoxTahunAjaran.Text))
                If counterDistribution >= (totalKelas - 1) Then
                    counterDistribution = 0
                Else
                    counterDistribution += 1
                End If
            Next
        Next

    End Sub

    Private Sub GennerateDenganPenjurusan(ByVal jurusan As String)
        If Convert.ToInt32(TextBoxTahunAjaran.Text) < 2010 Then
            MessageBox.Show(Me, "Tahun Ajaran harus lebih besar dari Tahun 2010", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Convert.ToInt32(TextBoxTahunAngkatan.Text) < 2010 Then
            MessageBox.Show(Me, "Tahun Angkatan harus lebih besar dari Tahun 2010", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ComboBoxTingkat.Text.Length = 0 Then
            MessageBox.Show(Me, "Tahun Angkatan harus lebih besar dari Tahun 2010", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim listSiswaIpa = SiswaBusinessObject.GetSiswaByJurusan(TextBoxTahunAngkatan.Text, jurusan, Convert.ToInt32(TextBoxTahunAjaran.Text))
        If listSiswaIpa.Count = 0 Then
            MessageBox.Show(Me, "Tidak data siswa Tahun Angkatan " + TextBoxTahunAngkatan.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim listKelas = KelasBusinessObject.GetKelasByTahunAjaran(Convert.ToInt32(TextBoxTahunAjaran.Text), Convert.ToInt32(ComboBoxTingkat.Text), jurusan)
        If listKelas.Count = 0 Then
            MessageBox.Show(Me, "Tidak data kelas Tahun Ajaran " + TextBoxTahunAjaran.Text, "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim totalSiswa = listSiswaIpa.Count
        Dim totalKelas = listKelas.Count
        Dim counterDist = 0
        Dim perempuan = listSiswaIpa.Where(Function(nSiswa) nSiswa.JenisKelamin.ToLower().Equals("perempuan")).OrderBy(Function(nSiswa) nSiswa.Nama)
        Dim lakilaki = listSiswaIpa.Where(Function(nSiswa) nSiswa.JenisKelamin.ToLower().Equals("laki-laki")).OrderBy(Function(nSiswa) nSiswa.Nama)
        Const letter As String = "abcdefghijklmnopqrstuvwxyz"
        'Dim rnd As New System.Random

        For i As Integer = 0 To letter.Length - 1
            Dim alpha = letter.Substring(i, 1)
            Dim csiswa = perempuan.Where(Function(a) a.Nama.ToLower().StartsWith(alpha)) '.OrderBy(Function() rnd.Next())
            For Each j As MasterSiswa In csiswa
                PenjurusanBusinessObject.SetPenjurusan(j, listKelas(counterDist), Convert.ToInt32(TextBoxTahunAjaran.Text))
                If counterDist >= (totalKelas - 1) Then
                    counterDist = 0
                Else
                    counterDist += 1
                End If
            Next
        Next

        For i As Integer = 0 To letter.Length - 1
            Dim alpha = letter.Substring(i, 1)
            Dim csiswa = lakilaki.Where(Function(a) a.Nama.ToLower().StartsWith(alpha)) '.OrderBy(Function() rnd.Next())
            For Each j As MasterSiswa In csiswa
                PenjurusanBusinessObject.SetPenjurusan(j, listKelas(counterDist), Convert.ToInt32(TextBoxTahunAjaran.Text))
                If counterDist >= (totalKelas - 1) Then
                    counterDist = 0
                Else
                    counterDist += 1
                End If
            Next
        Next
    End Sub

    Private Sub ButtonCloseClick(ByVal sender As System.Object, ByVal e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub
End Class