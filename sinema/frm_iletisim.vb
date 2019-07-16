Imports System.Net.Mail
Public Class frm_iletisim
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frm_kayit.Show()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        frm_kategori.Show()
    End Sub

    Private Sub frm_iletisim_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'YAPIM AŞAMASINDA
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If TextBox1.Text = "" Then
            MsgBox("E-Mail Kısmı Boş bırakılamaz", MsgBoxStyle.Critical)
        ElseIf TextBox2.Text = "" Then
            MsgBox("Şifre Kısmı Boş bırakılamaz", MsgBoxStyle.Critical)
        Else
            Dim mail As New MailMessage

        End If

    End Sub
End Class
