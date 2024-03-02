Imports System.Drawing.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq
Imports libmpv.Player


Public Class QuranKarim
    Friend Quran() As String = New String() {"الفَاتِحَة", "البَقَرَة", "آل عِمرَان", "النِّسَاء", "المَائدة", "الأنعَام", "الأعرَاف", "الأنفَال", "التوبَة", "يُونس", "هُود", "يُوسُف", "الرَّعْد", "إبراهِيم", "الحِجْر", "النَّحْل", "الإسْرَاء", "الكهْف", "مَريَم", "طه", "الأنبيَاء", "الحَج", "المُؤمنون", "النُّور", "الفُرْقان", "الشُّعَرَاء", "النَّمْل", "القَصَص", "العَنكبوت", "الرُّوم", "لقمَان", "السَّجدَة", "الأحزَاب", "سَبَأ", "فَاطِر", "يس", "الصَّافات", "ص", "الزُّمَر", "غَافِر", "فُصِّلَتْ", "الشُّورَى", "الزُّخْرُف", "الدخَان", "الجَاثيَة", "الأحْقاف", "محَمَّد", "الفَتْح", "الحُجرَات", "ق", "الذَّاريَات", "الطُّور", "النَّجْم", "القَمَر", "الرَّحمن", "الوَاقِعَة", "الحَديد", "المجَادلة", "الحَشر", "المُمتَحنَة", "الصَّف", "الجُمُعَة", "المنَافِقون", "التغَابُن", "الطلَاق", "التحْريم", "المُلْك", "القَلَم", "الحَاقَّة", "المعَارج", "نُوح", "الجِن", "المُزَّمِّل", "المُدَّثِّر", "القِيَامَة", "الإنسَان", "المُرسَلات", "النَّبَأ", "النّازعَات", "عَبَس", "التَّكوير", "الانفِطار", "المطفِّفِين", "الانْشِقَاق", "البرُوج", "الطَّارِق", "الأَعْلى", "الغَاشِية", "الفَجْر", "البَلَد", "الشَّمْس", "الليْل", "الضُّحَى", "الشَّرْح", "التِّين", "العَلَق", "القَدْر", "البَينَة", "الزلزَلة", "العَادِيات", "القَارِعة", "التَّكَاثر", "العَصْر", "الهُمَزَة", "الفِيل", "قُرَيْش", "المَاعُون", "الكَوْثَر", "الكَافِرُون", "النَّصر", "المَسَد", "الإخْلَاص", "الفَلَق", "النَّاس"}
    Dim naming As MatchCollection
    Dim channelurl As String
    Public player As MpvPlayer
    Dim x As String
    Dim xs As String = "noaudio"
    Dim VolumeValue As Integer
    Public Shared pfc As New PrivateFontCollection()
    Private originalItems As New List(Of String)
    Private originalItemsURL As New List(Of String)
    Dim Hour As Integer
    Dim Min As Integer
    Dim Second As Integer

    Private Sub E_1_Click(sender As Object, e As EventArgs) Handles E_1.Click
        End
    End Sub

    Private Sub E_3_Click(sender As Object, e As EventArgs) Handles E_3.Click
        If Me.TopMost = False Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub E_2_Click(sender As Object, e As EventArgs) Handles E_2.Click
#Disable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
        Me.WindowState = WindowState.Minimized
        NotifyIcon1.Visible = True
        Me.Hide()
#Enable Warning BC42025 ' Access of shared member, constant member, enum member or nested type through an instance
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Sub New()
        InitializeComponent()
        player = New MpvPlayer(MPVP.Handle) With {.[Loop] = True, .Volume = 100}
    End Sub

    Public Shared Function DecodeBase64(input As String) As String
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input))
    End Function

    Public Sub MpvPlay(url As String)
        Me.player.[Stop]()
        Me.player.PlaylistClear()
        If (url <> "") Then
            Me.player.Load(url, True)
            Me.player.[Resume]()
            Me.T2.Start()
        Else

        End If
        Me.Play_btn.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("StopPlay"), Image)
        x = "Stop"
    End Sub

    Private Sub Play_btn_Click(sender As Object, e As EventArgs) Handles Play_btn.Click
        If x = "Stop" Then
            Me.Play_btn.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("Play"), Image)
            Me.player.Pause()
            Me.T2.[Stop]()
            x = "Play"
        Else
            Me.Play_btn.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("StopPlay"), Image)
            Me.player.[Resume]()
            Me.T2.Start()
            x = "Stop"
        End If
    End Sub

    Private Sub Vol_btn_Click(sender As Object, e As EventArgs) Handles Vol_btn.Click
        If xs = "noaudio" Then
            VolumeValue = Me.btnVolum.Value
            Me.btnVolum.Value = 0
            Me.player.Volume = 0
            xs = "audio"
            Me.Vol_btn.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("VoMute"), Image)
        Else
            Me.btnVolum.Value = VolumeValue
            Me.player.Volume = Me.btnVolum.Value
            xs = "noaudio"
            Me.Vol_btn.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("VoulmeOn"), Image)
        End If
    End Sub

    Private Sub btnVolum_ValueChanged(sender As Object, e As EventArgs) Handles btnVolum.ValueChanged
        Me.player.Volume = Me.btnVolum.Value
        Me.Label3.Text = Me.btnVolum.Value & "%"
        If Me.btnVolum.Value = 0 Then
            Me.Vol_btn.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("VoMute"), Image)
        Else
            Me.Vol_btn.BackgroundImage = CType(My.Resources.ResourceManager.GetObject("VoulmeOn"), Image)
        End If
        xs = "noaudio"
    End Sub

    Private Sub QuranKarim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pfc.AddFontFile("Font.ttf")
        Me.ListBox1.Font = New System.Drawing.Font(pfc.Families(0), 15.75, FontStyle.Bold)
        Me.Readers.Font = New System.Drawing.Font(pfc.Families(0), 15, FontStyle.Bold)
        Me.Label5.Font = New System.Drawing.Font(pfc.Families(0), 15.75, FontStyle.Bold)
        Me.Label3.Font = New System.Drawing.Font(pfc.Families(0), 18, FontStyle.Bold)
        Me.label10.Font = New System.Drawing.Font(pfc.Families(0), 18, FontStyle.Bold)
        Me.Label2.Font = New System.Drawing.Font(pfc.Families(0), 18, FontStyle.Bold)
        Me.Label7.Font = New System.Drawing.Font(pfc.Families(0), 18, FontStyle.Bold)
        Me.GunaLabel1.Font = New System.Drawing.Font(pfc.Families(0), 15.75, FontStyle.Bold)
        Me.GunaTextbox1.Font = New System.Drawing.Font(pfc.Families(0), 14, FontStyle.Bold)

        Dim JosnFile As String = (My.Forms.MainForm.TextBox1.Text.Trim().ToString())
        naming = Regex.Matches(JosnFile, "(?<=letter"":"").+?(?="")")

        Dim parsejson As JObject = JObject.Parse(JosnFile)
        For i = 0 To (naming.Count - 1)
            Dim thedate = parsejson.SelectToken("reciters[" & i & "].name").ToString.Trim()
            Dim mpr3URL = parsejson.SelectToken("reciters[" & i & "].moshaf[0].server").ToString.Trim()
            Readers.Items.Add(i + 1 & " - " & thedate)
            originalItems.Add(i + 1 & " - " & thedate)
            originalItemsURL.Add(mpr3URL)
        Next

        For i = 0 To 113
            ListBox1.Items.Add(i + 1 & " - " & Quran(i))
        Next
    End Sub

    Private Sub Readers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Readers.SelectedIndexChanged
        Try
            If Me.ListBox1.Enabled = False Then
                Me.ListBox1.Enabled = True
            End If
            Dim inputString As String = Readers.SelectedItem.ToString.Replace(" - ", "")
            Dim regex As New Regex("\d+")
            Dim matches As MatchCollection = regex.Matches(inputString)
            Dim integersString As String = ""
            For Each match As Match In matches
                integersString &= match.Value & ""
            Next
            channelurl = originalItemsURL(integersString - 1)
            Dim regex2 As New Regex("[\u0600-\u06FF]+")
            Dim matches2 As MatchCollection = regex2.Matches(inputString)
            Dim arabicString As String = ""
            For Each match As Match In matches2
                arabicString &= match.Value & " "
            Next
            GunaLabel1.Text = arabicString
            Label1.Text = arabicString
        Catch ex As Exception
            MsgBox("  لا يوجد اتصال بالانترنت او هناك خطا بالاتصال بالسيرفر حاول مره اخري.")
            Application.Exit()
        End Try
    End Sub

    Private Sub T2_Tick(sender As Object, e As EventArgs) Handles T2.Tick
        Try
            Dim position As TimeSpan = Me.player.Position
            Me.Label7.Text = position.ToString("hh':'mm':'ss")
            Dim PlayerDuration As TimeSpan = Me.player.Duration
            Me.Label2.Text = PlayerDuration.ToString("hh':'mm':'ss")
            Hour = PlayerDuration.Hours * 3600
            Min = PlayerDuration.Minutes * 60
            Second = PlayerDuration.Seconds
            Me.ProgressBar1.Maximum = Second + Min + Hour
            Me.TextBox1.Text = position.Seconds
            If Me.ProgressBar1.Value > 2 Then
                If Me.ProgressBar1.Value = Me.ProgressBar1.Maximum Then
                    Me.player.[Stop]()
                    Me.player.PlaylistClear()
                End If
            End If
            If Me.GunaWinSwitch2.Checked = True Then
                If Me.ProgressBar1.Value > 2 Then
                    If Me.ProgressBar1.Value = Me.ProgressBar1.Maximum Then
                        ListBox1.SelectedIndex += 1
                    End If
                End If
            Else
                'nothing
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Try
            GunaLabel1.Text = Label1.Text & " - " & Quran(ListBox1.SelectedIndex.ToString())
            Me.Play_btn.Enabled = True
            Me.PictureBox1.Enabled = True
            Me.PictureBox2.Enabled = True
            Dim inputNumber As Integer = Integer.Parse(ListBox1.SelectedIndex.ToString() + 1)
            Dim formattedNumber As String = inputNumber.ToString().PadLeft(3, "0"c)
            MpvPlay(channelurl & "/" & formattedNumber & ".mp3")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If Me.ProgressBar1.Value = Me.ProgressBar1.Maximum Then
            Else
                Me.ProgressBar1.Value = Me.ProgressBar1.Value + 1
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            ListBox1.SelectedIndex -= 1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            ListBox1.SelectedIndex += 1
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GunaTextbox1_TextChanged(sender As Object, e As EventArgs) Handles GunaTextbox1.TextChanged
        Dim searchText As String = GunaTextbox1.Text.ToLower()
        Readers.Items.Clear()
        For Each item As String In originalItems
            If item.ToLower().Contains(searchText) Then
                Readers.Items.Add(item)
            End If
        Next
    End Sub
End Class