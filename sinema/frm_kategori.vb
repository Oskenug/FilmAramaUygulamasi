Imports System.Xml
Imports System.Data.SqlClient
Public Class frm_kategori
    Dim connection As New SqlConnection("Server = DESKTOP-82R4PGR\SQLSERVER17TEST; Database = sinema; Integrated Security = true")

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_kayit.Show()
    End Sub



    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        frm_iletisim.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        frm_kullanicigirisi.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Hide()
        frm_yonetici.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub grp_kategori_Enter(sender As Object, e As EventArgs) Handles grp_kategori.Enter
        Me.Show()
    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub
    Private Sub frm_kategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim c As Int16
        For c = 1 To 3

            Dim command As New SqlCommand("select * from Table_flm where film_no = @film_no", connection)
            Dim a As String
            Dim b As String


            command.Parameters.Add("@film_no", SqlDbType.NVarChar).Value = c
            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)
            a = table.Rows(0)(0).ToString()
            b = table.Rows(0)(1).ToString()
            If c = 1 Then
                Dim xml As XmlDocument = New XmlDocument
                xml.Load(("http://www.omdbapi.com/?t=" + a + "&y=" + b + "&plot=full&r=xml&apikey=95afa224"))
                For Each icerik As XmlElement In xml.SelectNodes("root/movie")
                    PictureBox1.ImageLocation = icerik.GetAttribute("poster")
                    Label4.Text = icerik.GetAttribute("title")
                Next
            End If
            If c = 2 Then
                Dim xml As XmlDocument = New XmlDocument
                xml.Load(("http://www.omdbapi.com/?t=" + a + "&y=" + b + "&plot=full&r=xml&apikey=95afa224"))
                For Each icerik As XmlElement In xml.SelectNodes("root/movie")
                    PictureBox2.ImageLocation = icerik.GetAttribute("poster")
                    Label5.Text = icerik.GetAttribute("title")
                Next
            End If
            If c = 3 Then
                Dim xml As XmlDocument = New XmlDocument
                xml.Load(("http://www.omdbapi.com/?t=" + a + "&y=" + b + "&plot=full&r=xml&apikey=95afa224"))
                For Each icerik As XmlElement In xml.SelectNodes("root/movie")
                    PictureBox3.ImageLocation = icerik.GetAttribute("poster")
                    Label6.Text = icerik.GetAttribute("title")
                Next
            End If
        Next
    End Sub

    Private Sub Label14_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Label14.LinkClicked
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim c As Int16
        c = 1

        Dim command As New SqlCommand("select * from Table_flm where film_no = @film_no", connection)
            Dim a As String
            Dim b As String


            command.Parameters.Add("@film_no", SqlDbType.NVarChar).Value = c
            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)
            a = table.Rows(0)(0).ToString()
            b = table.Rows(0)(1).ToString()

        Dim xml As XmlDocument = New XmlDocument
                xml.Load(("http://www.omdbapi.com/?t=" + a + "&y=" + b + "&plot=full&r=xml&apikey=95afa224"))
                For Each icerik As XmlElement In xml.SelectNodes("root/movie")

            TextBox1.Text = icerik.GetAttribute("title")
            TextBox2.Text = icerik.GetAttribute("year")
            TextBox3.Text = icerik.GetAttribute("genre")
            TextBox4.Text = icerik.GetAttribute("actors")
            TextBox5.Text = icerik.GetAttribute("director")
            TextBox6.Text = icerik.GetAttribute("plot")
            Label13.Text = icerik.GetAttribute("imdbRating")
        Next
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim c As Int16
        c = 2

        Dim command As New SqlCommand("select * from Table_flm where film_no = @film_no", connection)
        Dim a As String
        Dim b As String


        command.Parameters.Add("@film_no", SqlDbType.NVarChar).Value = c
        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)
        a = table.Rows(0)(0).ToString()
        b = table.Rows(0)(1).ToString()

        Dim xml As XmlDocument = New XmlDocument
        xml.Load(("http://www.omdbapi.com/?t=" + a + "&y=" + b + "&plot=full&r=xml&apikey=95afa224"))
        For Each icerik As XmlElement In xml.SelectNodes("root/movie")

            TextBox1.Text = icerik.GetAttribute("title")
            TextBox2.Text = icerik.GetAttribute("year")
            TextBox3.Text = icerik.GetAttribute("genre")
            TextBox4.Text = icerik.GetAttribute("actors")
            TextBox5.Text = icerik.GetAttribute("director")
            TextBox6.Text = icerik.GetAttribute("plot")
            Label13.Text = icerik.GetAttribute("imdbRating")
        Next

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim c As Int16
        c = 3

        Dim command As New SqlCommand("select * from Table_flm where film_no = @film_no", connection)
        Dim a As String
        Dim b As String


        command.Parameters.Add("@film_no", SqlDbType.NVarChar).Value = c
        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)
        a = table.Rows(0)(0).ToString()
        b = table.Rows(0)(1).ToString()

        Dim xml As XmlDocument = New XmlDocument
        xml.Load(("http://www.omdbapi.com/?t=" + a + "&y=" + b + "&plot=full&r=xml&apikey=95afa224"))
        For Each icerik As XmlElement In xml.SelectNodes("root/movie")

            TextBox1.Text = icerik.GetAttribute("title")
            TextBox2.Text = icerik.GetAttribute("year")
            TextBox3.Text = icerik.GetAttribute("genre")
            TextBox4.Text = icerik.GetAttribute("actors")
            TextBox5.Text = icerik.GetAttribute("director")
            TextBox6.Text = icerik.GetAttribute("plot")
            Label13.Text = icerik.GetAttribute("imdbRating")
        Next


    End Sub
End Class
