<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Akzaer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Akzaer))
        Me.GunaElipse5 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.T2 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaElipse4 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.Play_btn = New System.Windows.Forms.PictureBox()
        Me.btnVolum = New Guna.UI.WinForms.GunaTrackBar()
        Me.Vol_btn = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Header_Panel = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MPVP = New System.Windows.Forms.Panel()
        Me.label10 = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.E_2 = New System.Windows.Forms.PictureBox()
        Me.E_3 = New System.Windows.Forms.PictureBox()
        Me.E_1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.Play_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vol_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Header_Panel.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.E_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.E_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.E_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse5
        '
        Me.GunaElipse5.Radius = 20
        Me.GunaElipse5.TargetControl = Me.TextBox1
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Janna LT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(37, 251)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(1447, 556)
        Me.TextBox1.TabIndex = 1132
        Me.TextBox1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "اختار الاذكار اولا."
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'T2
        '
        '
        'GunaElipse4
        '
        Me.GunaElipse4.Radius = 20
        Me.GunaElipse4.TargetControl = Me.Panel2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Controls.Add(Me.Play_btn)
        Me.Panel2.Controls.Add(Me.btnVolum)
        Me.Panel2.Controls.Add(Me.Vol_btn)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(128, 176)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1259, 68)
        Me.Panel2.TabIndex = 1131
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.ProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.ProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.ProgressBar1.Location = New System.Drawing.Point(193, 22)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar1.Size = New System.Drawing.Size(503, 25)
        Me.ProgressBar1.TabIndex = 1097
        '
        'Play_btn
        '
        Me.Play_btn.BackgroundImage = CType(resources.GetObject("Play_btn.BackgroundImage"), System.Drawing.Image)
        Me.Play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Play_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Play_btn.Enabled = False
        Me.Play_btn.Location = New System.Drawing.Point(864, 6)
        Me.Play_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Play_btn.Name = "Play_btn"
        Me.Play_btn.Size = New System.Drawing.Size(51, 55)
        Me.Play_btn.TabIndex = 862
        Me.Play_btn.TabStop = False
        '
        'btnVolum
        '
        Me.btnVolum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolum.Location = New System.Drawing.Point(985, 21)
        Me.btnVolum.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolum.Name = "btnVolum"
        Me.btnVolum.Size = New System.Drawing.Size(133, 28)
        Me.btnVolum.TabIndex = 863
        Me.btnVolum.TrackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVolum.TrackHoverColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVolum.TrackIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVolum.TrackPressedColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'Vol_btn
        '
        Me.Vol_btn.BackgroundImage = CType(resources.GetObject("Vol_btn.BackgroundImage"), System.Drawing.Image)
        Me.Vol_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Vol_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Vol_btn.Location = New System.Drawing.Point(923, 6)
        Me.Vol_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Vol_btn.Name = "Vol_btn"
        Me.Vol_btn.Size = New System.Drawing.Size(51, 55)
        Me.Vol_btn.TabIndex = 864
        Me.Vol_btn.TabStop = False
        Me.Vol_btn.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Janna LT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1124, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 55)
        Me.Label3.TabIndex = 867
        Me.Label3.Text = "50%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Janna LT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(696, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 55)
        Me.Label2.TabIndex = 866
        Me.Label2.Text = "00.00.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Janna LT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(41, 7)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 55)
        Me.Label7.TabIndex = 865
        Me.Label7.Text = "00.00.00"
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 20
        Me.GunaElipse3.TargetControl = Me
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 20
        Me.GunaElipse2.TargetControl = Me.Panel1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GunaButton2)
        Me.Panel1.Controls.Add(Me.GunaButton1)
        Me.Panel1.Location = New System.Drawing.Point(365, 65)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 105)
        Me.Panel1.TabIndex = 1130
        '
        'GunaButton2
        '
        Me.GunaButton2.Animated = True
        Me.GunaButton2.AnimationHoverSpeed = 1.0!
        Me.GunaButton2.AnimationSpeed = 1.0!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.White
        Me.GunaButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton2.BorderSize = 3
        Me.GunaButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Janna LT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton2.Image = Nothing
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(79, 17)
        Me.GunaButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.White
        Me.GunaButton2.Radius = 20
        Me.GunaButton2.Size = New System.Drawing.Size(297, 69)
        Me.GunaButton2.TabIndex = 1129
        Me.GunaButton2.Text = "اذكار المساء"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.Animated = True
        Me.GunaButton1.AnimationHoverSpeed = 1.0!
        Me.GunaButton1.AnimationSpeed = 1.0!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.White
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton1.BorderSize = 3
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Janna LT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.GunaButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(384, 17)
        Me.GunaButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.White
        Me.GunaButton1.Radius = 20
        Me.GunaButton1.Size = New System.Drawing.Size(297, 69)
        Me.GunaButton1.TabIndex = 1128
        Me.GunaButton1.Text = "اذكار الصباح"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 20
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.Header_Panel
        '
        'Header_Panel
        '
        Me.Header_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Header_Panel.Controls.Add(Me.TextBox2)
        Me.Header_Panel.Controls.Add(Me.MPVP)
        Me.Header_Panel.Controls.Add(Me.label10)
        Me.Header_Panel.Controls.Add(Me.PictureBox10)
        Me.Header_Panel.Controls.Add(Me.Label4)
        Me.Header_Panel.Controls.Add(Me.GunaButton3)
        Me.Header_Panel.Controls.Add(Me.E_2)
        Me.Header_Panel.Controls.Add(Me.E_3)
        Me.Header_Panel.Controls.Add(Me.E_1)
        Me.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Header_Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.Header_Panel.Name = "Header_Panel"
        Me.Header_Panel.Size = New System.Drawing.Size(1516, 50)
        Me.Header_Panel.TabIndex = 1129
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(79, 22)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(12, 11)
        Me.TextBox2.TabIndex = 1129
        Me.TextBox2.Visible = False
        '
        'MPVP
        '
        Me.MPVP.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MPVP.Location = New System.Drawing.Point(79, 6)
        Me.MPVP.Margin = New System.Windows.Forms.Padding(4)
        Me.MPVP.Name = "MPVP"
        Me.MPVP.Size = New System.Drawing.Size(13, 12)
        Me.MPVP.TabIndex = 1128
        Me.MPVP.Visible = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Font = New System.Drawing.Font("Janna LT", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(693, -2)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(99, 55)
        Me.label10.TabIndex = 1097
        Me.label10.Text = "الاذكار"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Location = New System.Drawing.Point(1421, 6)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox10.TabIndex = 1070
        Me.PictureBox10.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1425, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 1069
        Me.Label4.Visible = False
        '
        'GunaButton3
        '
        Me.GunaButton3.Animated = True
        Me.GunaButton3.AnimationHoverSpeed = 1.0!
        Me.GunaButton3.AnimationSpeed = 1.0!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton3.BorderSize = 3
        Me.GunaButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.GunaButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton3.Location = New System.Drawing.Point(119, 4)
        Me.GunaButton3.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.White
        Me.GunaButton3.Radius = 20
        Me.GunaButton3.Size = New System.Drawing.Size(13, 12)
        Me.GunaButton3.TabIndex = 1065
        Me.GunaButton3.Text = "تحميل السورة"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'E_2
        '
        Me.E_2.BackColor = System.Drawing.Color.Transparent
        Me.E_2.BackgroundImage = CType(resources.GetObject("E_2.BackgroundImage"), System.Drawing.Image)
        Me.E_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.E_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.E_2.Location = New System.Drawing.Point(1373, 7)
        Me.E_2.Margin = New System.Windows.Forms.Padding(4)
        Me.E_2.Name = "E_2"
        Me.E_2.Size = New System.Drawing.Size(43, 39)
        Me.E_2.TabIndex = 1068
        Me.E_2.TabStop = False
        '
        'E_3
        '
        Me.E_3.BackColor = System.Drawing.Color.Transparent
        Me.E_3.BackgroundImage = CType(resources.GetObject("E_3.BackgroundImage"), System.Drawing.Image)
        Me.E_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.E_3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.E_3.Location = New System.Drawing.Point(13, 6)
        Me.E_3.Margin = New System.Windows.Forms.Padding(4)
        Me.E_3.Name = "E_3"
        Me.E_3.Size = New System.Drawing.Size(43, 39)
        Me.E_3.TabIndex = 718
        Me.E_3.TabStop = False
        '
        'E_1
        '
        Me.E_1.BackColor = System.Drawing.Color.Transparent
        Me.E_1.BackgroundImage = CType(resources.GetObject("E_1.BackgroundImage"), System.Drawing.Image)
        Me.E_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.E_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.E_1.Location = New System.Drawing.Point(1467, 6)
        Me.E_1.Margin = New System.Windows.Forms.Padding(4)
        Me.E_1.Name = "E_1"
        Me.E_1.Size = New System.Drawing.Size(43, 39)
        Me.E_1.TabIndex = 1067
        Me.E_1.TabStop = False
        '
        'Akzaer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1516, 815)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Header_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Akzaer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Akzaer"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Play_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vol_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Header_Panel.ResumeLayout(False)
        Me.Header_Panel.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.E_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.E_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.E_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse5 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents T2 As Timer
    Friend WithEvents GunaElipse4 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProgressBar1 As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents Play_btn As PictureBox
    Friend WithEvents btnVolum As Guna.UI.WinForms.GunaTrackBar
    Friend WithEvents Vol_btn As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Header_Panel As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MPVP As Panel
    Friend WithEvents label10 As Label
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents E_2 As PictureBox
    Friend WithEvents E_3 As PictureBox
    Friend WithEvents E_1 As PictureBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
End Class
