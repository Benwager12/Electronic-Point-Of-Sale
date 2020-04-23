Imports System.IO
Imports EPOS2.Utility

Public Class MainScreen

    Dim res As New Resizer

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        res.FindAllControls(Me)
        createResources()
        Utility.LoadProducts()
        Values.MSInstance = Me

        Utility.FullPageLoad("index.page")
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

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        Values.CurrentPageNumber -= 1
        Utility.LoadPage()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Values.CurrentPageNumber += 1
        Utility.LoadPage()
    End Sub

    Private Sub btnProduct1_Click(sender As Object, e As EventArgs) Handles btnProduct1.Click
        Utility.ProcessButton(btnProduct1.Tag)
    End Sub

    Private Sub btnProduct2_Click(sender As Object, e As EventArgs) Handles btnProduct2.Click
        Utility.ProcessButton(btnProduct2.Tag)
    End Sub

    Private Sub btnProduct3_Click(sender As Object, e As EventArgs) Handles btnProduct3.Click
        Utility.ProcessButton(btnProduct3.Tag)
    End Sub

    Private Sub btnProduct4_Click(sender As Object, e As EventArgs) Handles btnProduct4.Click
        Utility.ProcessButton(btnProduct4.Tag)
    End Sub

    Private Sub btnProduct5_Click(sender As Object, e As EventArgs) Handles btnProduct5.Click
        Utility.ProcessButton(btnProduct5.Tag)
    End Sub

    Private Sub btnProduct6_Click(sender As Object, e As EventArgs) Handles btnProduct6.Click
        Utility.ProcessButton(btnProduct6.Tag)
    End Sub

    Private Sub btnProduct7_Click(sender As Object, e As EventArgs) Handles btnProduct7.Click
        Utility.ProcessButton(btnProduct7.Tag)
    End Sub

    Private Sub btnProduct8_Click(sender As Object, e As EventArgs) Handles btnProduct8.Click
        Utility.ProcessButton(btnProduct8.Tag)
    End Sub

    Private Sub btnProduct9_Click(sender As Object, e As EventArgs) Handles btnProduct9.Click
        Utility.ProcessButton(btnProduct9.Tag)
    End Sub

    Private Sub dataShoppingList_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dataShoppingList.UserDeletedRow
        Utility.updatePrice()
    End Sub

    Private Sub btnIndex_Click(sender As Object, e As EventArgs) Handles btnIndex.Click
        Values.CurrentPageNumber = 1
        Utility.FullPageLoad("index.page")
    End Sub
End Class
