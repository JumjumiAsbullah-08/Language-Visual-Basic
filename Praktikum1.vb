# Language-Visual-Basic
    Bahasa Pemrograman Visual Basic
    PERTEMUAN KE 10
    DOSEN PENGAMPU : BAPAK. ZUFRIA ILKA 
    KOLEKSI DATA DENGAN LISTVIEW PRAKTIKUM 1

    Public Class Latihan1
    Sub BuatTabel()
        LV.Columns.Add("NPM", 90, HorizontalAlignment.Center)
        LV.Columns.Add("Nama", 100, HorizontalAlignment.Center)
        LV.Columns.Add("Jurusan", 100, HorizontalAlignment.Center)
        LV.Columns.Add("Jenjang", 90, HorizontalAlignment.Center)
        LV.Columns.Add("Tahun Masuk", 90, HorizontalAlignment.Center)
        LV.Columns.Add("Nilai Angka", 90, HorizontalAlignment.Center)
        LV.Columns.Add("Nilai Huruf", 90, HorizontalAlignment.Center)
        LV.View = View.Details
        LV.GridLines = True
        LV.FullRowSelect = True
    End Sub
    Sub IsiTabel()
        Dim isi As New ListViewItem
        isi.Text = txtnpm.Text
        isi.SubItems.Add(txtnama.Text)
        isi.SubItems.Add(txtjurusan.Text)
        isi.SubItems.Add(txtjenjang.Text)
        isi.SubItems.Add(txtmasuk.Text)
        isi.SubItems.Add(txtangka.Text)
        isi.SubItems.Add(txthuruf.Text)
        LV.Items.Add(isi)
    End Sub
    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        IsiTabel()
        txtnpm.Text = ""
        txtnama.Text = ""
        txtjurusan.Text = ""
        txtjenjang.Text = ""
        txtmasuk.Text = ""
        txtangka.Text = ""
        txthuruf.Text = ""
    End Sub
    Private Sub txtangka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtangka.KeyPress
        Dim tombol As Integer = Asc(e.KeyChar)
        If tombol = 13 Then
            If txtangka.Text >= 80 Then
                txthuruf.Text = "A"
            ElseIf txtangka.Text >= 70 Then
                txthuruf.Text = "B"
            ElseIf txtangka.Text >= 60 Then
                txthuruf.Text = "C"
            ElseIf txtangka.Text >= 50 Then
                txthuruf.Text = "D"
            Else
                txtangka.Text = "E"
            End If
            txtangka.Text = txtangka.Text
            txthuruf_TextChanged(sender, e)
        End If
    End Sub
    Private Sub txthuruf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txthuruf.TextChanged
    End Sub
    Private Sub txtnpm_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtnpm.TextChanged
        Dim j As String
        Me.txtmasuk.Text = "20" & Microsoft.VisualBasic.Mid(txtnpm.Text, 1, 2)
        j = Microsoft.VisualBasic.Mid(txtnpm.Text, 4, 2)
        If j = "01" Then
            Me.txtjurusan.Text = "FSH"
        ElseIf j = "02" Then
            Me.txtjurusan.Text = "FITK"
        ElseIf j = "03" Then
            Me.txtjurusan.Text = "FUSI"
        ElseIf j = "04" Then
            Me.txtjurusan.Text = "FDK"
        ElseIf j = "05" Then
            Me.txtjurusan.Text = "FEBI"
        ElseIf j = "06" Then
            Me.txtjurusan.Text = "FKM"
        ElseIf j = "07" Then
            Me.txtjurusan.Text = "FST"
        ElseIf j = "08" Then
            Me.txtjurusan.Text = "FIS"
        ElseIf j = "09" Then
            Me.txtjurusan.Text = "PASCA SARJANA"
        End If
        j = Microsoft.VisualBasic.Mid(txtnpm.Text, 3, 1)
        If j = "1" Then
            Me.txtjenjang.Text = "S-1"
        ElseIf j = "2" Then
            Me.txtjenjang.Text = "S-2"
        ElseIf j = "3" Then
            Me.txtjenjang.Text = "S-3"
        Else
            Me.txtjenjang.Text = "JENJANG SELANJUTNYA"
        End If
    End Sub
    Private Sub Latihan1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BuatTabel()
    End Sub
    Private Sub btnhapus_semua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus_semua.Click
        LV.Items.Clear()
    End Sub
    Private Sub btnhapus_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus_pilih.Click
        LV.Items.Remove(LV.SelectedItems(0))
    End Sub
    Private Sub btnbersih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbersih.Click
        Me.txtnpm.Text = ""
        Me.txtnama.Text = ""
        Me.txtjurusan.Text = ""
        Me.txtjenjang.Text = ""
        Me.txtmasuk.Text = ""
        Me.txtangka.Text = ""
        Me.txthuruf.Text = ""
    End Sub
    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        End
    End Sub
    End Class
