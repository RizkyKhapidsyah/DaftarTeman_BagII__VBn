Public Class Form1
    Private listNama As New List(Of String)

    Private Sub tombolTambah_Click(sender As Object, e As EventArgs) Handles tombolTambah.Click
        'menambahkan nama ke List
        listNama.Add(teksNama.Text)

        'membersihkan kotak teks
        teksNama.Clear()
        teksNama.Focus()
    End Sub

    Private Sub tombolTampil_Click(sender As Object, e As EventArgs) Handles tombolTampil.Click
        'menampilkan semua nama pada kotak list
        Dim strNama As String

        listTeman.Items.Clear()
        For Each strNama In listNama
            listTeman.Items.Add(strNama) 'menambahkan pada kotak list
        Next
    End Sub
End Class
