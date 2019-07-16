<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.filmtxt = New System.Windows.Forms.TextBox()
        Me.yıltxt = New System.Windows.Forms.TextBox()
        Me.ktgrtxt = New System.Windows.Forms.TextBox()
        Me.oyuncutxt = New System.Windows.Forms.TextBox()
        Me.drctrtxt = New System.Windows.Forms.TextBox()
        Me.aciklmatxt = New System.Windows.Forms.TextBox()
        Me.imdbtxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(163, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 20)
        Me.TextBox1.TabIndex = 13
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(532, 98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(419, 351)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(508, 15)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox2.TabIndex = 25
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.sinema_proje.My.Resources.Resources.btn_back
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(12, 411)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 34)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'filmtxt
        '
        Me.filmtxt.Location = New System.Drawing.Point(163, 94)
        Me.filmtxt.Name = "filmtxt"
        Me.filmtxt.Size = New System.Drawing.Size(248, 20)
        Me.filmtxt.TabIndex = 28
        '
        'yıltxt
        '
        Me.yıltxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.yıltxt.Location = New System.Drawing.Point(163, 137)
        Me.yıltxt.Name = "yıltxt"
        Me.yıltxt.Size = New System.Drawing.Size(248, 20)
        Me.yıltxt.TabIndex = 29
        '
        'ktgrtxt
        '
        Me.ktgrtxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ktgrtxt.Location = New System.Drawing.Point(163, 184)
        Me.ktgrtxt.Name = "ktgrtxt"
        Me.ktgrtxt.Size = New System.Drawing.Size(248, 20)
        Me.ktgrtxt.TabIndex = 30
        '
        'oyuncutxt
        '
        Me.oyuncutxt.Location = New System.Drawing.Point(163, 219)
        Me.oyuncutxt.Multiline = True
        Me.oyuncutxt.Name = "oyuncutxt"
        Me.oyuncutxt.Size = New System.Drawing.Size(248, 80)
        Me.oyuncutxt.TabIndex = 31
        '
        'drctrtxt
        '
        Me.drctrtxt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.drctrtxt.Location = New System.Drawing.Point(163, 310)
        Me.drctrtxt.Name = "drctrtxt"
        Me.drctrtxt.Size = New System.Drawing.Size(248, 20)
        Me.drctrtxt.TabIndex = 32
        '
        'aciklmatxt
        '
        Me.aciklmatxt.Location = New System.Drawing.Point(163, 345)
        Me.aciklmatxt.Multiline = True
        Me.aciklmatxt.Name = "aciklmatxt"
        Me.aciklmatxt.Size = New System.Drawing.Size(248, 87)
        Me.aciklmatxt.TabIndex = 34
        '
        'imdbtxt
        '
        Me.imdbtxt.Location = New System.Drawing.Point(912, 60)
        Me.imdbtxt.Name = "imdbtxt"
        Me.imdbtxt.Size = New System.Drawing.Size(36, 20)
        Me.imdbtxt.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 19)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Aranıcak Film"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 19)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Film Adı"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 19)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Film Yılı"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 19)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "Kategori"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 219)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 19)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Oyuncu İsimleri"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 309)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 19)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "Yönetmen"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 345)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 19)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Açıklama"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label15.Location = New System.Drawing.Point(430, 14)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 19)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Filmler"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(147, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(147, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(147, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(147, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(147, 313)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(147, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(147, 188)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(10, 13)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = ":"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(492, 18)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(10, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = ":"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label18.Location = New System.Drawing.Point(812, 60)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(94, 19)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "İMDB Puanı:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.sinema_proje.My.Resources.Resources.BUL
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(842, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 25)
        Me.Button1.TabIndex = 42
        Me.Button1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.sinema_proje.My.Resources.Resources.ARAFİLMARA
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(714, 14)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 25)
        Me.Button3.TabIndex = 43
        Me.Button3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sinema_proje.My.Resources.Resources.filmara
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(969, 457)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.imdbtxt)
        Me.Controls.Add(Me.aciklmatxt)
        Me.Controls.Add(Me.drctrtxt)
        Me.Controls.Add(Me.oyuncutxt)
        Me.Controls.Add(Me.ktgrtxt)
        Me.Controls.Add(Me.yıltxt)
        Me.Controls.Add(Me.filmtxt)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents filmtxt As TextBox
    Friend WithEvents yıltxt As TextBox
    Friend WithEvents ktgrtxt As TextBox
    Friend WithEvents oyuncutxt As TextBox
    Friend WithEvents drctrtxt As TextBox
    Friend WithEvents aciklmatxt As TextBox
    Friend WithEvents imdbtxt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Button1 As PictureBox
    Friend WithEvents Button3 As PictureBox
End Class
