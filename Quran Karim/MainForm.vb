Imports System.Drawing.Text
Imports System.Net
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json.Linq

Public Class MainForm
    Public Shared pfc As New PrivateFontCollection()
    Public Shared Web As New WebClient
    Dim jResults As JObject

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        jResults = JObject.Parse(Web.DownloadString("https://pastebin.com/raw/udPCLLr7"))
        If jResults("status").ToString().Trim = "Open" Then
            pfc.AddFontFile("Font.ttf")
            Me.label10.Font = New System.Drawing.Font(pfc.Families(0), 18, FontStyle.Bold)
            Me.GunaLabel1.Font = New System.Drawing.Font(pfc.Families(0), 15.75, FontStyle.Bold)
            Me.GunaButton1.Font = New System.Drawing.Font(pfc.Families(0), 18, FontStyle.Bold)
            Me.GunaButton2.Font = New System.Drawing.Font(pfc.Families(0), 18, FontStyle.Bold)

            WebBrowser1.Navigate(jResults("setting_link").ToString().Trim)

        Else
            Interaction.MsgBox(".البرنامج مغلق بواسطة الادمن او هناك مشكلة في الاتصال بالسيرفر", MsgBoxStyle.Information, Nothing)
            Application.Exit()
        End If
    End Sub
    Private Sub GunaCirclePictureBox1_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox1.Click
        Process.Start(jResults("MoSami_fb").ToString().Trim)
    End Sub

    Private Sub GunaCirclePictureBox2_Click(sender As Object, e As EventArgs) Handles GunaCirclePictureBox2.Click
        Process.Start(jResults("ALCaesar_fb").ToString().Trim)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Process.Start(jResults("WB").ToString().Trim)
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        QuranKarim.Show()
        Me.Hide()
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        TextBox1.Text = Regex.Unescape(WebBrowser1.DocumentText())
        GunaButton1.Visible = True
        GunaButton2.Visible = True

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Akzaer.Show()
        Me.Hide()
    End Sub
End Class