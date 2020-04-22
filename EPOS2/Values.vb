Imports EPOS2.Utility

Public Class Values

    Public Shared IsFullScreen As Boolean = False

    Public Shared Folders As List(Of String) = New List(Of String)

    Public Shared Sub RemoveFolder()
        If Folders.Count = 0 Then Return

        Folders.RemoveAt(Folders.Count - 1)
    End Sub

    Public Shared Products As List(Of Product) = New List(Of Product)

    Public Shared CurrentPageNumber As Integer = 1

    Public Shared CurrentPage As Page = Nothing

    Public Shared MSInstance As MainScreen = Nothing
End Class
