Imports System.Data.SqlClient
Public Class kullanıcı
    Private ad As String
    Private soyad As String
    Private email As String
    Private kullanıcı_adı As String
    Private user_sifre As String
    Private baglanti As SqlConnection
    Private stp As SqlCommand
    Private Servername As String

    Public Property Adı As String
        Get
            Return ad
        End Get
        Set(value As String)
            ad = value
        End Set
    End Property
    Public Property soyadı As String
        Get
            Return soyad
        End Get
        Set(value As String)
            soyad = value
        End Set
    End Property
    Public Property emaili As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value

        End Set
    End Property
    Public WriteOnly Property user() As String
        Set(ByVal value As String)
            kullanıcı_adı = value
        End Set
    End Property
    Public WriteOnly Property user_password() As String
        Set(ByVal value As String)
            user_sifre = value
        End Set
    End Property

    Public WriteOnly Property Server() As String
        Set(ByVal value As String)
            Servername = value
        End Set
    End Property

    Public Function KayıtEkle() As Integer
        Try
            baglanti = New SqlConnection("server= DESKTOP-82R4PGR\SQLSERVER17TEST; Database = sinema ; Integrated Security = true")
            baglanti.Open()
        Catch hata As SqlClient.SqlException
            MessageBox.Show("Hata" & hata.Message)
        End Try
        stp = New SqlCommand()
        stp.CommandType = CommandType.StoredProcedure
        stp.CommandTimeout = 50

        stp.CommandText = "stpPersonelKaydet"
        stp.Connection = Baglanti

        Dim pad As New SqlParameter("@ad", SqlDbType.VarChar, 20)
        Dim psoyad As New SqlParameter("@soyad", SqlDbType.VarChar, 20)
        Dim pemail As New SqlParameter("@email", SqlDbType.NVarChar)
        Dim res As New SqlParameter("@res", SqlDbType.Int)

        pad.Direction = ParameterDirection.Input
        pad.Value = Ad
        stp.Parameters.Add(pad)

        psoyad.Direction = ParameterDirection.Input
        psoyad.Value = soyad
        stp.Parameters.Add(psoyad)

        pemail.Direction = ParameterDirection.Input
        pemail.Value = email
        stp.Parameters.Add(pemail)

        res.Direction = ParameterDirection.ReturnValue
        stp.Parameters.Add(res)

        Try
            stp.ExecuteNonQuery()
        Catch hata As SqlException

            If hata.Number.ToString = "18456" Then
                MessageBox.Show("Kullanıcı ismi veya şifresi hatalı", "Kullanıcı Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            If hata.Number.ToString = "2601" Then
                MessageBox.Show("Bu Kayıt Mevcut", "Kayıt Mevcut", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            'Return -1

        End Try

        Return res.Value

        '   MessageBox.Show(stp.Parameters.Item(3).Value)
    End Function
    Public Sub Sil()
        baglanti = New SqlConnection("server= DESKTOP-82R4PGR\SQLSERVER17TEST; Database = sinema ; Integrated Security = true")
        baglanti.Open()
        stp = New SqlCommand()
        stp.CommandType = CommandType.StoredProcedure
        stp.CommandTimeout = 20
        stp.CommandText = "stpPersonelSil"
        stp.Connection = baglanti

        Dim psoyad As New SqlParameter("@soyad", SqlDbType.VarChar, 20)
        Dim res As New SqlParameter("@res", SqlDbType.Int)


        psoyad.Direction = ParameterDirection.Input
        psoyad.Value = soyad
        stp.Parameters.Add(psoyad)

        res.Direction = ParameterDirection.ReturnValue
        stp.Parameters.Add(res)

        Try
            stp.ExecuteNonQuery()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try

        MsgBox(res.Value)

        ' MessageBox.Show(stp.Parameters.Item(1).Value)

    End Sub
    Public Function Listele() As DataSet

        baglanti = New SqlConnection("server=DESKTOP-82R4PGR\SQLSERVER17TEST; Database = sinema ; Integrated Security = true")
        Dim Adaptor As New SqlDataAdapter("select Ad, Soyad, email, FROM tblkullanıcı", baglanti)
        Dim ds As New DataSet()
        Try
            Adaptor.Fill(ds, "sicil")
        Catch Hata As SqlException
            If Hata.Number.ToString = "18456" Then
                MessageBox.Show("Kullanıcı ismi veya şifresi hatalı", "Kullanıcı Hata", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End Try
        Return ds
    End Function
End Class