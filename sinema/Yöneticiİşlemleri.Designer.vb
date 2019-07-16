<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Yöneticiİşlemleri
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.adtxt = New System.Windows.Forms.TextBox()
        Me.emailtxt = New System.Windows.Forms.TextBox()
        Me.soyadtxt = New System.Windows.Forms.TextBox()
        Me.idtxt = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'adtxt
        '
        Me.adtxt.Location = New System.Drawing.Point(130, 58)
        Me.adtxt.Name = "adtxt"
        Me.adtxt.Size = New System.Drawing.Size(114, 20)
        Me.adtxt.TabIndex = 4
        '
        'emailtxt
        '
        Me.emailtxt.Location = New System.Drawing.Point(130, 160)
        Me.emailtxt.Name = "emailtxt"
        Me.emailtxt.Size = New System.Drawing.Size(114, 20)
        Me.emailtxt.TabIndex = 5
        '
        'soyadtxt
        '
        Me.soyadtxt.Location = New System.Drawing.Point(130, 114)
        Me.soyadtxt.Name = "soyadtxt"
        Me.soyadtxt.Size = New System.Drawing.Size(114, 20)
        Me.soyadtxt.TabIndex = 6
        '
        'idtxt
        '
        Me.idtxt.Location = New System.Drawing.Point(130, 205)
        Me.idtxt.Name = "idtxt"
        Me.idtxt.Size = New System.Drawing.Size(114, 20)
        Me.idtxt.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(343, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(548, 238)
        Me.DataGridView1.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.sinema_proje.My.Resources.Resources.SİL
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.Location = New System.Drawing.Point(459, 349)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(210, 45)
        Me.Button3.TabIndex = 20
        Me.Button3.TabStop = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.sinema_proje.My.Resources.Resources.ARA
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.Location = New System.Drawing.Point(684, 349)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(210, 43)
        Me.Button4.TabIndex = 20
        Me.Button4.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.sinema_proje.My.Resources.Resources.göster
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Location = New System.Drawing.Point(229, 349)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(210, 45)
        Me.Button2.TabIndex = 20
        Me.Button2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.sinema_proje.My.Resources.Resources.GÜNCELLE
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(3, 349)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 44)
        Me.Button1.TabIndex = 20
        Me.Button1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.sinema_proje.My.Resources.Resources.btn_back
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 29)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Yöneticiİşlemleri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.sinema_proje.My.Resources.Resources.yonetici_islemleri
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(906, 454)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.idtxt)
        Me.Controls.Add(Me.soyadtxt)
        Me.Controls.Add(Me.emailtxt)
        Me.Controls.Add(Me.adtxt)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Yöneticiİşlemleri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Yöneticiİşlemleri"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents adtxt As TextBox
    Friend WithEvents emailtxt As TextBox
    Friend WithEvents soyadtxt As TextBox
    Friend WithEvents idtxt As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As PictureBox
    Friend WithEvents Button2 As PictureBox
    Friend WithEvents Button4 As PictureBox
    Friend WithEvents Button3 As PictureBox
End Class
