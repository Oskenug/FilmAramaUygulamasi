Imports System.Data.SqlClient
Imports System.Data

Public Class Yöneticiİşlemleri
    Dim connection As New SqlConnection("Server = DESKTOP-82R4PGR\SQLSERVER17TEST; Database = sinema; Integrated Security = true")

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        frm_yonetici.Show()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "Server = DESKTOP-82R4PGR\SQLSERVER17TEST; Database = sinema; Integrated Security = true"
        Dim sql As String = "SELECT * FROM Table_User"
        Dim connection As New SqlConnection(connectionString)
        Dim dataadapter As New SqlDataAdapter(sql, connection)
        Dim ds As New DataSet()
        connection.Open()
        dataadapter.Fill(ds, "Table_User")
        connection.Close()
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Table_User"
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uptadeQuery As String = "Update Table_User  Set Ad = '" & adtxt.Text & "',Soyad = '" & soyadtxt.Text & "',email = '" & emailtxt.Text & "',Kullanıcı_adı =  '" & idtxt.Text & "'WHERE Kullanıcı_adı ='" & idtxt.Text & "'"

        ExecuteQuery(uptadeQuery)
        MessageBox.Show("Güncellendi")
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim deleteQuery As String = "delete from Table_User Where Kullanıcı_adı = '" & idtxt.Text & "'"
        ExecuteQuery(deleteQuery)
        MessageBox.Show("Kullanıcı Silindi")
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim command As New SqlCommand("select * from Table_User where Kullanıcı_adı = @Kullanıcı_adı", connection)

        command.Parameters.Add("@Kullanıcı_adı", SqlDbType.NVarChar).Value = idtxt.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        adtxt.Text = ""
        soyadtxt.Text = ""
        emailtxt.Text = ""
        idtxt.Text = ""

        If table.Rows.Count() > 0 Then

            ' return only 1 row
            adtxt.Text = table.Rows(0)(0).ToString()
            soyadtxt.Text = table.Rows(0)(1).ToString()
            emailtxt.Text = table.Rows(0)(2).ToString()
            idtxt.Text = table.Rows(0)(3).ToString()

        Else

            MessageBox.Show("NO Data Found")

        End If
    End Sub
End Class