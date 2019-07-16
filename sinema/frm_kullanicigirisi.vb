Imports System.Data.SqlClient
Public Class frm_kullanicigirisi


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If CheckBox1.Checked = True Then
            Dim connection As New SqlConnection("Server = DESKTOP-82R4PGR\SQLSERVER17TEST; Database = sinema; Integrated Security = true")

            Dim command As New SqlCommand("select* from Table_Admin where ad = @Ad and admin_sifre = @Admin_sifre ", connection)

            command.Parameters.Add("@Ad", SqlDbType.VarChar).Value = txtad.Text

            command.Parameters.Add("@Admin_sifre", SqlDbType.VarChar).Value = txtsifre.Text



            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then

                MessageBox.Show("Gireemessiinn")

            Else
                Me.Hide()
                frm_yonetici.Show()

            End If
        Else

            Dim connection As New SqlConnection("Server = DESKTOP-82R4PGR\SQLSERVER17TEST; Database = sinema; Integrated Security = true")

            Dim command As New SqlCommand("select* from Table_User where kullanıcı_adı = @Kullanıcı_adı and user_sifre = @User_sifre ", connection)

            command.Parameters.Add("@Kullanıcı_adı", SqlDbType.VarChar).Value = txtad.Text

            command.Parameters.Add("@User_sifre", SqlDbType.VarChar).Value = txtsifre.Text



            Dim adapter As New SqlDataAdapter(command)

            Dim table As New DataTable()

            adapter.Fill(table)

            If table.Rows.Count() <= 0 Then

                MessageBox.Show("Gireemessiinn")

            Else
                Me.Hide()
                frm_kategori.Show()

            End If
        End If







    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Hide()
        frm_kayit.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        frm_sifremiUnuttum.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        frm_kategori.Show()
    End Sub


End Class
