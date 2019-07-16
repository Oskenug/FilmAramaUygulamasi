
Imports System.Xml
Public Class Form1
    Dim f As New Film
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        frm_kategori.Show()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xml As XmlDocument = New XmlDocument

        xml.Load(("http://www.omdbapi.com/?s=" + ComboBox2.Text + "&r=xml&apikey=95afa224"))

        For Each icerik As XmlElement In xml.SelectNodes("root/result")

            filmtxt.Text = icerik.GetAttribute("title")
            yıltxt.Text = icerik.GetAttribute("year")

        Next

        xml.Load(("http://www.omdbapi.com/?t=" + filmtxt.Text + "&y=" + yıltxt.Text + "&plot=full&r=xml&apikey=95afa224"))
        For Each icerik As XmlElement In xml.SelectNodes("root/movie")
            PictureBox1.ImageLocation = icerik.GetAttribute("poster")
            filmtxt.Text = icerik.GetAttribute("title")
            yıltxt.Text = icerik.GetAttribute("year")
            ktgrtxt.Text = icerik.GetAttribute("genre")
            oyuncutxt.Text = icerik.GetAttribute("actors")
            drctrtxt.Text = icerik.GetAttribute("director")
            aciklmatxt.Text = icerik.GetAttribute("plot")
            imdbtxt.Text = icerik.GetAttribute("imdbRating")
        Next
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        ComboBox2.Items.Clear()
        Dim xml As XmlDocument = New XmlDocument
        Dim liste As New List(Of Film)
        xml.Load(("http://www.omdbapi.com/?s=" + TextBox1.Text + "&r=xml&apikey=95afa224"))
        For Each icerik As XmlElement In xml.SelectNodes("root/result")
            Dim f As New Film
            f.title = icerik.GetAttribute("title")
            f.yil = icerik.GetAttribute("year")
            liste.Add(f)



            ComboBox2.Items.Add(f.title)
        Next

        MessageBox.Show("Filmin Tam Adını Seçiniz")
    End Sub
End Class