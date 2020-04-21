Imports System.IO

Public Class Utility
    Public Class Page
        Public PageObjects As List(Of PageObject) = New List(Of PageObject)
    End Class

    Public Class PageObject
        Public ItemID As Integer
        Public FolderPlacement As String
        Public Type As ObjectType
    End Class

    Public Enum ObjectType As Byte
        Item
        Folder
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
            newPath += workingDirectory + RawPath.Substring(1)
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
        If Objects.Count > 9 Then
            MsgBox("More than 9 objects on page (max of 9)", MsgBoxStyle.Critical,
                   "More objects than expected")
            Return Nothing
        End If

        Dim page As Page = New Page()

        For Each PObject In Objects
            Dim tempPobj As PageObject = New PageObject()
            Dim splitParts As String() = PObject.Split("^")

            If splitParts(0).ToLower = "folder" Then
                tempPobj.folderPlacement = ProcessPath(splitParts(1))
                If Not Directory.Exists(tempPobj.folderPlacement) Then
                    MsgBox("Folder '" + tempPobj.folderPlacement + "' does not exist.",
                           MsgBoxStyle.Information, "Folder does not exist")
                    Continue For
                End If
                tempPobj.Type = ObjectType.Folder
            End If

            If splitParts(0).ToLower = "item" Then
                If Not IsNumeric(splitParts(1)) Then
                    MsgBox("The item '" + Str(splitParts(1)) + "' is not a number",
                           MsgBoxStyle.Information, "Not numeric")
                    Continue For
                End If
                tempPobj.itemID = Int(splitParts(1))
                ' TODO: Check if products file has this number

                tempPobj.Type = ObjectType.Item
            End If

            page.PageObjects.Add(tempPobj)
        Next

        Return page
    End Function

    Public Shared Sub LoadPage(ByVal MS As MainScreen, ByVal P As Page)
        MS.lblNoButtons.Visible = (P.PageObjects.Count = 0)

        ChangeButton(MS.btnProduct1, P, 0)
        ChangeButton(MS.btnProduct2, P, 1)
        ChangeButton(MS.btnProduct3, P, 2)
        ChangeButton(MS.btnProduct4, P, 3)
        ChangeButton(MS.btnProduct5, P, 4)
        ChangeButton(MS.btnProduct6, P, 5)
        ChangeButton(MS.btnProduct7, P, 6)
        ChangeButton(MS.btnProduct8, P, 7)
        ChangeButton(MS.btnProduct9, P, 8)
    End Sub

    Private Shared Sub ChangeButton(ByVal Button As Button, ByVal P As Page, ByVal Number As Integer)
        If P.PageObjects.Count > Number Then
            If P.PageObjects(Number).Type = ObjectType.Item Then
                Button.Text = Values.Products(P.PageObjects(Number).ItemID - 1).Name
            Else
                Button.Text = P.PageObjects(Number).FolderPlacement
            End If
            Button.Tag = If(P.PageObjects(Number).Type = ObjectType.Item,
                "item", String.Concat("folder^", P.PageObjects(Number).FolderPlacement))
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
