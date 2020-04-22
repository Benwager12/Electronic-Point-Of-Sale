<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnFullscreen = New System.Windows.Forms.Button()
        Me.lblPOS = New System.Windows.Forms.Label()
        Me.panelButtons = New System.Windows.Forms.Panel()
        Me.displayPage = New System.Windows.Forms.Button()
        Me.btnUpDirectory = New System.Windows.Forms.Button()
        Me.lblNoButtons = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnProduct1 = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnProduct4 = New System.Windows.Forms.Button()
        Me.btnProduct3 = New System.Windows.Forms.Button()
        Me.btnProduct9 = New System.Windows.Forms.Button()
        Me.btnProduct5 = New System.Windows.Forms.Button()
        Me.btnProduct6 = New System.Windows.Forms.Button()
        Me.btnProduct8 = New System.Windows.Forms.Button()
        Me.btnProduct2 = New System.Windows.Forms.Button()
        Me.btnProduct7 = New System.Windows.Forms.Button()
        Me.panelImageDisplay = New System.Windows.Forms.Panel()
        Me.dataShoppingList = New System.Windows.Forms.DataGridView()
        Me.itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblShoppingTotal = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.panelButtons.SuspendLayout()
        CType(Me.dataShoppingList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFullscreen
        '
        Me.btnFullscreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFullscreen.Location = New System.Drawing.Point(597, 12)
        Me.btnFullscreen.Name = "btnFullscreen"
        Me.btnFullscreen.Size = New System.Drawing.Size(191, 62)
        Me.btnFullscreen.TabIndex = 0
        Me.btnFullscreen.Text = "Enter Fullscreen"
        Me.btnFullscreen.UseVisualStyleBackColor = True
        '
        'lblPOS
        '
        Me.lblPOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOS.Location = New System.Drawing.Point(12, 12)
        Me.lblPOS.Name = "lblPOS"
        Me.lblPOS.Size = New System.Drawing.Size(576, 62)
        Me.lblPOS.TabIndex = 1
        Me.lblPOS.Text = "Point of Sale"
        '
        'panelButtons
        '
        Me.panelButtons.Controls.Add(Me.displayPage)
        Me.panelButtons.Controls.Add(Me.btnUpDirectory)
        Me.panelButtons.Controls.Add(Me.lblNoButtons)
        Me.panelButtons.Controls.Add(Me.btnNext)
        Me.panelButtons.Controls.Add(Me.btnProduct1)
        Me.panelButtons.Controls.Add(Me.btnPrev)
        Me.panelButtons.Controls.Add(Me.btnProduct4)
        Me.panelButtons.Controls.Add(Me.btnProduct3)
        Me.panelButtons.Controls.Add(Me.btnProduct9)
        Me.panelButtons.Controls.Add(Me.btnProduct5)
        Me.panelButtons.Controls.Add(Me.btnProduct6)
        Me.panelButtons.Controls.Add(Me.btnProduct8)
        Me.panelButtons.Controls.Add(Me.btnProduct2)
        Me.panelButtons.Controls.Add(Me.btnProduct7)
        Me.panelButtons.Location = New System.Drawing.Point(12, 77)
        Me.panelButtons.Name = "panelButtons"
        Me.panelButtons.Size = New System.Drawing.Size(598, 386)
        Me.panelButtons.TabIndex = 3
        '
        'displayPage
        '
        Me.displayPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayPage.Location = New System.Drawing.Point(196, 318)
        Me.displayPage.Name = "displayPage"
        Me.displayPage.Size = New System.Drawing.Size(187, 28)
        Me.displayPage.TabIndex = 27
        Me.displayPage.Text = "Page 1/1"
        Me.displayPage.UseVisualStyleBackColor = True
        '
        'btnUpDirectory
        '
        Me.btnUpDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpDirectory.Location = New System.Drawing.Point(196, 277)
        Me.btnUpDirectory.Name = "btnUpDirectory"
        Me.btnUpDirectory.Size = New System.Drawing.Size(187, 35)
        Me.btnUpDirectory.TabIndex = 26
        Me.btnUpDirectory.Text = "↑"
        Me.btnUpDirectory.UseVisualStyleBackColor = True
        '
        'lblNoButtons
        '
        Me.lblNoButtons.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoButtons.AutoSize = True
        Me.lblNoButtons.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoButtons.Location = New System.Drawing.Point(176, 123)
        Me.lblNoButtons.Name = "lblNoButtons"
        Me.lblNoButtons.Size = New System.Drawing.Size(321, 31)
        Me.lblNoButtons.TabIndex = 4
        Me.lblNoButtons.Text = "No Buttons On This Page"
        Me.lblNoButtons.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(389, 277)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(187, 69)
        Me.btnNext.TabIndex = 25
        Me.btnNext.Text = "→"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnProduct1
        '
        Me.btnProduct1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct1.Location = New System.Drawing.Point(3, 3)
        Me.btnProduct1.Name = "btnProduct1"
        Me.btnProduct1.Size = New System.Drawing.Size(187, 86)
        Me.btnProduct1.TabIndex = 15
        Me.btnProduct1.Text = "1"
        Me.btnProduct1.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(3, 277)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(187, 69)
        Me.btnPrev.TabIndex = 24
        Me.btnPrev.Text = "←"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnProduct4
        '
        Me.btnProduct4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct4.Location = New System.Drawing.Point(3, 95)
        Me.btnProduct4.Name = "btnProduct4"
        Me.btnProduct4.Size = New System.Drawing.Size(187, 86)
        Me.btnProduct4.TabIndex = 18
        Me.btnProduct4.Text = "4"
        Me.btnProduct4.UseVisualStyleBackColor = True
        '
        'btnProduct3
        '
        Me.btnProduct3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct3.Location = New System.Drawing.Point(389, 3)
        Me.btnProduct3.Name = "btnProduct3"
        Me.btnProduct3.Size = New System.Drawing.Size(187, 86)
        Me.btnProduct3.TabIndex = 17
        Me.btnProduct3.Text = "3"
        Me.btnProduct3.UseVisualStyleBackColor = True
        '
        'btnProduct9
        '
        Me.btnProduct9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct9.Location = New System.Drawing.Point(389, 187)
        Me.btnProduct9.Name = "btnProduct9"
        Me.btnProduct9.Size = New System.Drawing.Size(187, 86)
        Me.btnProduct9.TabIndex = 23
        Me.btnProduct9.Text = "9"
        Me.btnProduct9.UseVisualStyleBackColor = True
        '
        'btnProduct5
        '
        Me.btnProduct5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct5.Location = New System.Drawing.Point(196, 95)
        Me.btnProduct5.Name = "btnProduct5"
        Me.btnProduct5.Size = New System.Drawing.Size(187, 86)
        Me.btnProduct5.TabIndex = 19
        Me.btnProduct5.Text = "5"
        Me.btnProduct5.UseVisualStyleBackColor = True
        '
        'btnProduct6
        '
        Me.btnProduct6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct6.Location = New System.Drawing.Point(389, 95)
        Me.btnProduct6.Name = "btnProduct6"
        Me.btnProduct6.Size = New System.Drawing.Size(187, 86)
        Me.btnProduct6.TabIndex = 20
        Me.btnProduct6.Text = "6"
        Me.btnProduct6.UseVisualStyleBackColor = True
        '
        'btnProduct8
        '
        Me.btnProduct8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct8.Location = New System.Drawing.Point(196, 187)
        Me.btnProduct8.Name = "btnProduct8"
        Me.btnProduct8.Size = New System.Drawing.Size(187, 86)
        Me.btnProduct8.TabIndex = 22
        Me.btnProduct8.Text = "8"
        Me.btnProduct8.UseVisualStyleBackColor = True
        '
        'btnProduct2
        '
        Me.btnProduct2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct2.Location = New System.Drawing.Point(196, 3)
        Me.btnProduct2.Name = "btnProduct2"
        Me.btnProduct2.Size = New System.Drawing.Size(187, 86)
        Me.btnProduct2.TabIndex = 16
        Me.btnProduct2.Text = "2"
        Me.btnProduct2.UseVisualStyleBackColor = True
        '
        'btnProduct7
        '
        Me.btnProduct7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct7.Location = New System.Drawing.Point(3, 187)
        Me.btnProduct7.Name = "btnProduct7"
        Me.btnProduct7.Size = New System.Drawing.Size(187, 86)
        Me.btnProduct7.TabIndex = 21
        Me.btnProduct7.Text = "7"
        Me.btnProduct7.UseVisualStyleBackColor = True
        '
        'panelImageDisplay
        '
        Me.panelImageDisplay.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.panelImageDisplay.Location = New System.Drawing.Point(597, 77)
        Me.panelImageDisplay.Name = "panelImageDisplay"
        Me.panelImageDisplay.Size = New System.Drawing.Size(191, 181)
        Me.panelImageDisplay.TabIndex = 4
        '
        'dataShoppingList
        '
        Me.dataShoppingList.AllowUserToAddRows = False
        Me.dataShoppingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dataShoppingList.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dataShoppingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataShoppingList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemName, Me.itemPrice})
        Me.dataShoppingList.Location = New System.Drawing.Point(597, 273)
        Me.dataShoppingList.Name = "dataShoppingList"
        Me.dataShoppingList.ReadOnly = True
        Me.dataShoppingList.RowHeadersVisible = False
        Me.dataShoppingList.Size = New System.Drawing.Size(191, 150)
        Me.dataShoppingList.TabIndex = 5
        '
        'itemName
        '
        Me.itemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemName.HeaderText = "Name"
        Me.itemName.Name = "itemName"
        Me.itemName.ReadOnly = True
        '
        'itemPrice
        '
        Me.itemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.itemPrice.HeaderText = "Price"
        Me.itemPrice.Name = "itemPrice"
        Me.itemPrice.ReadOnly = True
        '
        'lblShoppingTotal
        '
        Me.lblShoppingTotal.AutoSize = True
        Me.lblShoppingTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShoppingTotal.Location = New System.Drawing.Point(12, 454)
        Me.lblShoppingTotal.Name = "lblShoppingTotal"
        Me.lblShoppingTotal.Size = New System.Drawing.Size(393, 42)
        Me.lblShoppingTotal.TabIndex = 6
        Me.lblShoppingTotal.Text = "The Shopping Total Is:"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(428, 454)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(112, 42)
        Me.lblAmount.TabIndex = 7
        Me.lblAmount.Text = "£0.00"
        '
        'MainScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 512)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblShoppingTotal)
        Me.Controls.Add(Me.dataShoppingList)
        Me.Controls.Add(Me.panelImageDisplay)
        Me.Controls.Add(Me.lblPOS)
        Me.Controls.Add(Me.btnFullscreen)
        Me.Controls.Add(Me.panelButtons)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "MainScreen"
        Me.Text = "Point of Sale"
        Me.panelButtons.ResumeLayout(False)
        Me.panelButtons.PerformLayout()
        CType(Me.dataShoppingList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFullscreen As Button
    Friend WithEvents lblPOS As Label
    Friend WithEvents panelButtons As Panel
    Friend WithEvents btnNext As Button
    Friend WithEvents btnProduct1 As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnProduct4 As Button
    Friend WithEvents btnProduct3 As Button
    Friend WithEvents btnProduct9 As Button
    Friend WithEvents btnProduct5 As Button
    Friend WithEvents btnProduct6 As Button
    Friend WithEvents btnProduct8 As Button
    Friend WithEvents btnProduct2 As Button
    Friend WithEvents btnProduct7 As Button
    Friend WithEvents lblNoButtons As Label
    Friend WithEvents btnUpDirectory As Button
    Friend WithEvents panelImageDisplay As Panel
    Friend WithEvents displayPage As Button
    Friend WithEvents dataShoppingList As DataGridView
    Friend WithEvents itemName As DataGridViewTextBoxColumn
    Friend WithEvents itemPrice As DataGridViewTextBoxColumn
    Friend WithEvents lblShoppingTotal As Label
    Friend WithEvents lblAmount As Label
End Class
