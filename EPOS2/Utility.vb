Imports System.IO

Public Class Utility
    Public Class Page
        Public PageObjects As List(Of PageObject) = New List(Of PageObject)
    End Class

    Public Class PageObject
        Public ItemID As Integer
        Public PathPlacement As String
        Public Type As ObjectType
    End Class

    Public Enum ObjectType As Byte
        Item
        Folder
        Page
    End Enum

    Public Class Product
        Public Name As String
        Public Price As Double
        Public ImagePath As String
    End Class

    Public Shared Function ProcessPath(ByVal RawPath As String)
        Dim workingDirectory As String = String.Join("\", Values.Folders)
        Dim newPath As String = Path.Combine(Directory.GetCurrentDirectory(), "EPOS Resources") + "\"

        If RawPath.StartsWith("\") Then
            newPath += workingDirectory + RawPath
        Else
            newPath = Path.Combine(newPath, RawPath)
        End If
        Return newPath
    End Function

    Public Shared Function ProcessPage(ByVal Path As String)
        If Not File.Exists(Path) Then
            MsgBox("Page file does not exist", MsgBoxStyle.Critical, "Page nonexistant")
            Return Nothing
        End If

        Dim Objects As String() = File.ReadAllLines(Path)
        Dim page As Page = New Page()

        For Each PObject In Objects
            Dim tempPobj As PageObject = New PageObject()
            Dim splitParts As String() = PObject.Split("^")

            If splitParts(0).ToLower = "folder" Then
                tempPobj.PathPlacement = ProcessPath(splitParts(1))
                If Not Directory.Exists(ProcessPath(tempPobj.PathPlacement)) Then
                    MsgBox("Folder '" + tempPobj.PathPlacement + "' does not exist.",
                           MsgBoxStyle.Information, "Folder does not exist")
                    Continue For
                End If

                tempPobj.Type = ObjectType.Folder
                page.PageObjects.Add(tempPobj)
            End If

            If splitParts(0).ToLower = "item" Then
                If Not IsNumeric(splitParts(1)) Then
                    MsgBox("The item '" + Str(splitParts(1)) + "' is not a number",
                           MsgBoxStyle.Information, "Not numeric")
                    Continue For
                End If
                tempPobj.ItemID = Int(splitParts(1))

                ' Checking if product exists
                If tempPobj.ItemID < 0 Or tempPobj.ItemID > Values.Products.Count Then
                    MsgBox("Product does not exist", MsgBoxStyle.Information, "Not a product")
                    Continue For
                End If

                tempPobj.Type = ObjectType.Item
                page.PageObjects.Add(tempPobj)
            End If

            If splitParts(0).ToLower = "page" Then
                ' Checking if path is valid
                If Not File.Exists(ProcessPath(splitParts(1))) Then
                    MsgBox("The path '" + Str(splitParts(1)) + "' is not valid",
                           MsgBoxStyle.Information, "Invalid path")
                    Continue For
                End If
                tempPobj.PathPlacement = splitParts(1)

                tempPobj.Type = ObjectType.Page
                page.PageObjects.Add(tempPobj)
            End If
        Next

        Return page
    End Function

    Public Shared Sub ProcessButton(tag As Object)
        Dim splitParts As String() = tag.Split("^")

        Select Case splitParts(0)
            Case "item"
                ' Added item to shopping cart
                Dim prod As Product = GetProduct(splitParts(1))
                Values.MSInstance.dataShoppingList.Rows.Add(prod.Name, String.Concat("£", prod.Price))

                updatePrice()
            Case "page"
                Values.CurrentPageNumber = 1
                FullPageLoad(splitParts(1))
            Case "folder"
                ' Gets all page files in a directory and puts it into a page file
                Dim P As Page = DirectoryAsPage(splitParts(1))
                ' Go a folder deeper
                Dim folderName As String = Path.GetFileName(splitParts(1)).Split("\")(0)
                Values.Folders.Add(folderName)
                ' Display it as a page
                Values.CurrentPage = P
                Values.CurrentPageNumber = 1
                LoadPage()
        End Select
    End Sub

    Public Shared Sub updatePrice()
        Throw New NotImplementedException()
    End Sub

    Public Shared Function DirectoryAsPage(ByVal unprocessed_path As String)
        ' Get all files in the path directory
        Dim P As Page = New Page()

        For Each file In Directory.EnumerateFiles(ProcessPath(unprocessed_path))
            ' If it isn't a page file, don't include it
            If Not file.EndsWith(".page") Then
                Continue For
            End If

            ' Create the page objects and fill them
            Dim tempPobj As PageObject = New PageObject()
            tempPobj.PathPlacement = String.Concat("\", Path.GetFileName(file))
            tempPobj.Type = ObjectType.Page

            ' Add the page objects to the page file
            P.PageObjects.Add(tempPobj)
        Next

        Return P
    End Function

    ' Collation of load functions
    Public Shared Sub FullPageLoad(ByVal Path As String)
        ' Processed unprocessed path
        Dim processedPath As String = ProcessPath(Path)
        ' Turn path into page
        Dim processedPage As Page = ProcessPage(processedPath)
        ' Load page into values
        Values.CurrentPage = processedPage
        ' Do a full page load
        Utility.LoadPage()
    End Sub

    ' Simple product lookup
    Public Shared Function GetProduct(ByVal ProductID As Integer)
        Return Values.Products.ElementAt(ProductID - 1)
    End Function

    ' Meat of the load page
    Public Shared Sub LoadPage()
        ' Grabbing current page
        Dim P As Page = Values.CurrentPage

        Dim MSInstance As MainScreen = Values.MSInstance
        ' Checks if there are any items on page, if not puts up a label.
        MSInstance.lblNoButtons.Visible = (P.PageObjects.Count <= 0 + (Values.CurrentPageNumber - 1) * 9)

        ' The previous and next buttons
        MSInstance.btnPrev.Visible = (Not Values.CurrentPageNumber = 1)
        MSInstance.btnNext.Visible = (Values.CurrentPageNumber = (P.PageObjects.Count - 1) \ 9)

        ' Changing each button the page
        ChangeButton(MSInstance.btnProduct1, P, 0 + 9 * (Values.CurrentPageNumber - 1))
        ChangeButton(MSInstance.btnProduct2, P, 1 + 9 * (Values.CurrentPageNumber - 1))
        ChangeButton(MSInstance.btnProduct3, P, 2 + 9 * (Values.CurrentPageNumber - 1))
        ChangeButton(MSInstance.btnProduct4, P, 3 + 9 * (Values.CurrentPageNumber - 1))
        ChangeButton(MSInstance.btnProduct5, P, 4 + 9 * (Values.CurrentPageNumber - 1))
        ChangeButton(MSInstance.btnProduct6, P, 5 + 9 * (Values.CurrentPageNumber - 1))
        ChangeButton(MSInstance.btnProduct7, P, 6 + 9 * (Values.CurrentPageNumber - 1))
        ChangeButton(MSInstance.btnProduct8, P, 7 + 9 * (Values.CurrentPageNumber - 1))
        ChangeButton(MSInstance.btnProduct9, P, 8 + 9 * (Values.CurrentPageNumber - 1))

        MSInstance.displayPage.Text = String.Concat("Page ", Values.CurrentPageNumber, "/", Math.Ceiling(P.PageObjects.Count / 9))
        MSInstance.btnUpDirectory.Visible = Not Values.Folders.Count = 0
    End Sub

    Private Shared Sub ChangeButton(ByVal Button As Button, ByVal P As Page, ByVal Number As Integer)
        Dim amountNeeded As Integer = Number + 1

        If P.PageObjects.Count >= Number + 1 Then
            Dim currentObject = P.PageObjects(Number)
            Select Case currentObject.Type
                Case ObjectType.Item
                    Button.Text = Values.Products(currentObject.ItemID - 1).Name
                    Button.Tag = String.Concat("item^", currentObject.ItemID)
                Case ObjectType.Folder
                    Button.Text = Path.GetFileName(currentObject.PathPlacement).Split("\")(0)
                    Button.Tag = String.Concat("folder^", currentObject.PathPlacement)
                Case ObjectType.Page
                    Dim endPath As String = Path.GetFileName(currentObject.PathPlacement).Split("\")(0)
                    Button.Text = endPath.Substring(0, endPath.Length - 5)
                    Button.Tag = String.Concat("page^", currentObject.PathPlacement)
            End Select
            Button.Visible = True
        Else
            Button.Visible = False
        End If
    End Sub

    Public Shared Sub LoadProducts()
        Dim products As String() = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(),
                                                                  "EPOS Resources") + "\products.prod")
        For Each product In products
            Dim splitParts As String() = product.Split("^")
            If Not IsNumeric(Replace(splitParts(1), ".", "", , 1)) Then
                MsgBox("The item '" + splitParts(1) + "' is not a decimal number.", MsgBoxStyle.Critical, "Not a decimal")
                Continue For
            End If

            Dim tempProd As Product = New Product()
            tempProd.Name = splitParts(0)
            tempProd.Price = CDbl(splitParts(1))
            tempProd.ImagePath = splitParts(2)

            Values.Products.Add(tempProd)
        Next
    End Sub
End Class
