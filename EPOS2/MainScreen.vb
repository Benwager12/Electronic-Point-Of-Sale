Imports System.IO
Imports EPOS2.Utility

Public Class MainScreen

    Dim res As New Resizer

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        res.FindAllControls(Me)
        createResources()
        Utility.LoadProducts()

        FullPageLoad("index.page")
    End Sub

    Private Sub MainScreen_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        res.ResizeAllControls(Me)
    End Sub

    Private Sub fullScreenButton_Click(sender As Object, e As EventArgs) Handles btnFullscreen.Click
        Values.IsFullScreen = Not Values.IsFullScreen
        Select Case Values.IsFullScreen
            Case True
                btnFullscreen.Text = "Exit Fullscreen"
                FormBorderStyle = Windows.Forms.FormBorderStyle.None
                WindowState = FormWindowState.Maximized
                TopMost = True
            Case False
                btnFullscreen.Text = "Enter Fullscreen"
                FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
                TopMost = False
        End Select
    End Sub

    Private Sub createResources()
        If Not Directory.Exists("EPOS Resources") Then
            Directory.CreateDirectory("EPOS Resources")
            MsgBox("EPOS Resources folder created.", MsgBoxStyle.OkOnly, "Folder Created")
        End If

        If Not File.Exists("EPOS Resources/index.page") Then
            File.Create("EPOS Resources/index.page").Close()
            MsgBox("Index page created.", MsgBoxStyle.OkOnly, "File Created")
        End If

        If Not File.Exists("EPOS Resources/products.prod") Then
            File.Create("EPOS Resources/products.prod").Close()
            MsgBox("Products file created.", MsgBoxStyle.OkOnly, "File Created")
        End If
    End Sub

    Private Sub FullPageLoad(ByVal Path As String)
        Dim processedPath As String = Utility.ProcessPath(Path)
        Dim processedPage As Page = Utility.ProcessPage(processedPath)
        Utility.LoadPage(Me, processedPage)
    End Sub
End Class
