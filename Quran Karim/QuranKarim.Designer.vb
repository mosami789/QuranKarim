<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuranKarim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuranKarim))
        Me.GunaElipse4 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse5 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Readers = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New Guna.UI.WinForms.GunaProgressBar()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaWinSwitch2 = New Guna.UI.WinForms.GunaWinSwitch()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Play_btn = New System.Windows.Forms.PictureBox()
        Me.btnVolum = New Guna.UI.WinForms.GunaTrackBar()
        Me.Vol_btn = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GunaElipse6 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.T2 = New System.Windows.Forms.Timer(Me.components)
        Me.Header_Panel = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.E_3 = New System.Windows.Forms.PictureBox()
        Me.E_2 = New System.Windows.Forms.PictureBox()
        Me.E_1 = New System.Windows.Forms.PictureBox()
        Me.MPVP = New System.Windows.Forms.Panel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaElipse3 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GunaTextbox1 = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Play_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vol_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.Header_Panel.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.E_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.E_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.E_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse4
        '
        Me.GunaElipse4.Radius = 15
        Me.GunaElipse4.TargetControl = Me.GunaLabel1
        '
        'GunaLabel1
        '
        Me.GunaLabel1.BackColor = System.Drawing.Color.White
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(73, 64)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(700, 48)
        Me.GunaLabel1.TabIndex = 1068
        Me.GunaLabel1.Text = "اختار القارئ  ثم السورة "
        Me.GunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GunaElipse5
        '
        Me.GunaElipse5.Radius = 15
        Me.GunaElipse5.TargetControl = Me.Readers
        '
        'Readers
        '
        Me.Readers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Readers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Readers.Font = New System.Drawing.Font("Janna LT", 12.8!, System.Drawing.FontStyle.Bold)
        Me.Readers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Readers.FormattingEnabled = True
        Me.Readers.IntegralHeight = False
        Me.Readers.ItemHeight = 39
        Me.Readers.Location = New System.Drawing.Point(0, 61)
        Me.Readers.Margin = New System.Windows.Forms.Padding(4)
        Me.Readers.Name = "Readers"
        Me.Readers.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Readers.Size = New System.Drawing.Size(464, 420)
        Me.Readers.TabIndex = 1069
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GunaWinSwitch2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Play_btn)
        Me.Panel1.Controls.Add(Me.btnVolum)
        Me.Panel1.Controls.Add(Me.Vol_btn)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(15, 118)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(817, 113)
        Me.Panel1.TabIndex = 1070
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BorderColor = System.Drawing.Color.Black
        Me.ProgressBar1.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.ProgressBar1.IdleColor = System.Drawing.Color.Gainsboro
        Me.ProgressBar1.Location = New System.Drawing.Point(156, 71)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar1.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar1.Size = New System.Drawing.Size(503, 25)
        Me.ProgressBar1.TabIndex = 1096
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Enabled = False
        Me.PictureBox2.Location = New System.Drawing.Point(625, 6)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(51, 55)
        Me.PictureBox2.TabIndex = 850
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(743, 6)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 55)
        Me.PictureBox1.TabIndex = 849
        Me.PictureBox1.TabStop = False
        '
        'GunaWinSwitch2
        '
        Me.GunaWinSwitch2.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaWinSwitch2.CheckedOffColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.GunaWinSwitch2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaWinSwitch2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaWinSwitch2.FillColor = System.Drawing.Color.White
        Me.GunaWinSwitch2.Location = New System.Drawing.Point(35, 20)
        Me.GunaWinSwitch2.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaWinSwitch2.Name = "GunaWinSwitch2"
        Me.GunaWinSwitch2.Size = New System.Drawing.Size(53, 27)
        Me.GunaWinSwitch2.TabIndex = 847
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(97, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 55)
        Me.Label5.TabIndex = 848
        Me.Label5.Text = "تشغيل تلقائي"
        '
        'Play_btn
        '
        Me.Play_btn.BackgroundImage = CType(resources.GetObject("Play_btn.BackgroundImage"), System.Drawing.Image)
        Me.Play_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Play_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Play_btn.Enabled = False
        Me.Play_btn.Location = New System.Drawing.Point(684, 6)
        Me.Play_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Play_btn.Name = "Play_btn"
        Me.Play_btn.Size = New System.Drawing.Size(51, 55)
        Me.Play_btn.TabIndex = 830
        Me.Play_btn.TabStop = False
        '
        'btnVolum
        '
        Me.btnVolum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVolum.Location = New System.Drawing.Point(369, 21)
        Me.btnVolum.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolum.Name = "btnVolum"
        Me.btnVolum.Size = New System.Drawing.Size(133, 28)
        Me.btnVolum.TabIndex = 831
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
        Me.Vol_btn.Location = New System.Drawing.Point(307, 6)
        Me.Vol_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.Vol_btn.Name = "Vol_btn"
        Me.Vol_btn.Size = New System.Drawing.Size(51, 55)
        Me.Vol_btn.TabIndex = 832
        Me.Vol_btn.TabStop = False
        Me.Vol_btn.Tag = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(508, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 36)
        Me.Label3.TabIndex = 846
        Me.Label3.Text = "50%"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(659, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 36)
        Me.Label2.TabIndex = 842
        Me.Label2.Text = "00.00.00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(4, 57)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 36)
        Me.Label7.TabIndex = 833
        Me.Label7.Text = "00.00.00"
        '
        'GunaElipse6
        '
        Me.GunaElipse6.Radius = 15
        Me.GunaElipse6.TargetControl = Me.Panel1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(4, 30)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(12, 11)
        Me.TextBox1.TabIndex = 1067
        Me.TextBox1.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "القرأن الكريم"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(164, 58)
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.ShowToolStripMenuItem.Text = "أظهار البرنامج"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.ExitToolStripMenuItem.Text = "إغلاق البرنامج"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(4, 19)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(12, 29)
        Me.TextBox2.TabIndex = 1063
        Me.TextBox2.Visible = False
        '
        'T2
        '
        '
        'Header_Panel
        '
        Me.Header_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Header_Panel.Controls.Add(Me.PictureBox10)
        Me.Header_Panel.Controls.Add(Me.label10)
        Me.Header_Panel.Controls.Add(Me.Label1)
        Me.Header_Panel.Controls.Add(Me.GunaButton3)
        Me.Header_Panel.Controls.Add(Me.Label4)
        Me.Header_Panel.Controls.Add(Me.E_3)
        Me.Header_Panel.Controls.Add(Me.E_2)
        Me.Header_Panel.Controls.Add(Me.E_1)
        Me.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Header_Panel.Margin = New System.Windows.Forms.Padding(4)
        Me.Header_Panel.Name = "Header_Panel"
        Me.Header_Panel.Size = New System.Drawing.Size(847, 50)
        Me.Header_Panel.TabIndex = 1065
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox10.Location = New System.Drawing.Point(744, 6)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(43, 39)
        Me.PictureBox10.TabIndex = 1095
        Me.PictureBox10.TabStop = False
        '
        'label10
        '
        Me.label10.AutoSize = True
        Me.label10.BackColor = System.Drawing.Color.Transparent
        Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(327, -2)
        Me.label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(149, 36)
        Me.label10.TabIndex = 1094
        Me.label10.Text = "القرأن الكريم"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 1098
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(724, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 1045
        Me.Label4.Visible = False
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
        'E_2
        '
        Me.E_2.BackColor = System.Drawing.Color.Transparent
        Me.E_2.BackgroundImage = CType(resources.GetObject("E_2.BackgroundImage"), System.Drawing.Image)
        Me.E_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.E_2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.E_2.Location = New System.Drawing.Point(699, 6)
        Me.E_2.Margin = New System.Windows.Forms.Padding(4)
        Me.E_2.Name = "E_2"
        Me.E_2.Size = New System.Drawing.Size(43, 39)
        Me.E_2.TabIndex = 725
        Me.E_2.TabStop = False
        '
        'E_1
        '
        Me.E_1.BackColor = System.Drawing.Color.Transparent
        Me.E_1.BackgroundImage = CType(resources.GetObject("E_1.BackgroundImage"), System.Drawing.Image)
        Me.E_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.E_1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.E_1.Location = New System.Drawing.Point(789, 6)
        Me.E_1.Margin = New System.Windows.Forms.Padding(4)
        Me.E_1.Name = "E_1"
        Me.E_1.Size = New System.Drawing.Size(43, 39)
        Me.E_1.TabIndex = 724
        Me.E_1.TabStop = False
        '
        'MPVP
        '
        Me.MPVP.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MPVP.Location = New System.Drawing.Point(16, 22)
        Me.MPVP.Margin = New System.Windows.Forms.Padding(4)
        Me.MPVP.Name = "MPVP"
        Me.MPVP.Size = New System.Drawing.Size(13, 12)
        Me.MPVP.TabIndex = 1064
        Me.MPVP.Visible = False
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.Header_Panel
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 20
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaElipse2
        '
        Me.GunaElipse2.Radius = 15
        Me.GunaElipse2.TargetControl = Me
        '
        'GunaElipse3
        '
        Me.GunaElipse3.Radius = 15
        Me.GunaElipse3.TargetControl = Me.ListBox1
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Enabled = False
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 30
        Me.ListBox1.Location = New System.Drawing.Point(16, 237)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ListBox1.Size = New System.Drawing.Size(345, 480)
        Me.ListBox1.TabIndex = 1066
        '
        'GunaTextbox1
        '
        Me.GunaTextbox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaTextbox1.BaseColor = System.Drawing.Color.White
        Me.GunaTextbox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextbox1.BorderSize = 1
        Me.GunaTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.GunaTextbox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaTextbox1.FocusedBaseColor = System.Drawing.Color.White
        Me.GunaTextbox1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextbox1.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextbox1.Font = New System.Drawing.Font("Janna LT", 14.0!, System.Drawing.FontStyle.Bold)
        Me.GunaTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaTextbox1.Location = New System.Drawing.Point(0, 0)
        Me.GunaTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GunaTextbox1.Name = "GunaTextbox1"
        Me.GunaTextbox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.GunaTextbox1.Radius = 5
        Me.GunaTextbox1.Size = New System.Drawing.Size(464, 54)
        Me.GunaTextbox1.TabIndex = 1099
        Me.GunaTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Readers)
        Me.Panel2.Controls.Add(Me.GunaTextbox1)
        Me.Panel2.Location = New System.Drawing.Point(368, 237)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(464, 481)
        Me.Panel2.TabIndex = 1100
        '
        'QuranKarim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 730)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Header_Panel)
        Me.Controls.Add(Me.MPVP)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "QuranKarim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Qurakarim"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Play_btn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vol_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.Header_Panel.ResumeLayout(False)
        Me.Header_Panel.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.E_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.E_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.E_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse4 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse5 As Guna.UI.WinForms.GunaElipse
    Private WithEvents Readers As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ProgressBar1 As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaWinSwitch2 As Guna.UI.WinForms.GunaWinSwitch
    Friend WithEvents Label5 As Label
    Friend WithEvents Play_btn As PictureBox
    Friend WithEvents btnVolum As Guna.UI.WinForms.GunaTrackBar
    Friend WithEvents Vol_btn As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GunaElipse6 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ShowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents T2 As Timer
    Friend WithEvents Header_Panel As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents label10 As Label
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label4 As Label
    Friend WithEvents E_3 As PictureBox
    Friend WithEvents E_2 As PictureBox
    Friend WithEvents E_1 As PictureBox
    Friend WithEvents MPVP As Panel
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaElipse3 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaTextbox1 As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Panel2 As Panel
End Class
