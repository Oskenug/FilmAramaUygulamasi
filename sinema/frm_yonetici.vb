Imports System.Data.SqlClient
Public Class frm_yonetici
    Dim connection As New SqlConnection("Server = DESKTOP-82R4PGR\SQLSERVER17TEST; Database = sinema; Integrated Security = true")

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_kayit.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Hide()
        frm_kategori.Show()
    End Sub



    Private Sub frm_yonetici_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim deleteQuery As String = "delete from Table_Flm Where film_no = '" & idtxt.Text & "'"
        ExecuteQuery(deleteQuery)
        MessageBox.Show("Film Silindi")
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim insertQuery As String = " INSERT INTO Table_Flm(film_adi,film_yili,film_no) VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"

        ExecuteQuery(insertQuery)


        MessageBox.Show("Kayıt Eklendi")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Yöneticiİşlemleri.Show()
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim connectionString As String = "Server = DESKTOP-82R4PGR\SQLSERVER17TEST; Database = sinema; Integrated Security = true"
        Dim sql As String = "SELECT * FROM Table_Flm"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Table_Flm")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Table_Flm"
    End Sub
End Class
