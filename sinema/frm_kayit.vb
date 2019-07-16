Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class frm_kayit
    Dim connection As New SqlConnection("Server = DESKTOP-82R4PGR\SQLSERVER17TEST; Database = sinema; Integrated Security = true")
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        frm_kullanicigirisi.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim par As String
        par = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If txt_ad.Text = String.Empty Or
            txt_email.Text = String.Empty Or
            txt_sifre.Text = String.Empty Or
            txt_soyad.Text = String.Empty Or
            txt_kullanıcı.Text = String.Empty Then

            MessageBox.Show("Boş Alan Bıraklılamaz!!")
        Else

            If Regex.IsMatch(txt_email.Text, par) Then
                Dim insertQuery As String = " INSERT INTO Table_User(Ad,Soyad,email,Kullanıcı_adı,User_sifre) VALUES('" & txt_ad.Text & "','" & txt_soyad.Text & "','" & txt_email.Text & "','" & txt_kullanıcı.Text & "','" & txt_sifre.Text & "')"
                ExecuteQuery(insertQuery)
                MessageBox.Show("Kayıt Eklendi")
            Else
                MessageBox.Show("Hatalı Mail Adresi Girdiniz!!")

            End If

        End If

    End Sub

    Public Sub ExecuteQuery(query As String)

        Dim command As New SqlCommand(query, connection)

        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub txt_ad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ad.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_soyad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_soyad.KeyPress

        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub


End Class
