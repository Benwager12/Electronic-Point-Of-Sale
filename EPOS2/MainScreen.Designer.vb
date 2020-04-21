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
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel1.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnUpDirectory)
        Me.Panel1.Controls.Add(Me.lblNoButtons)
        Me.Panel1.Controls.Add(Me.btnNext)
        Me.Panel1.Controls.Add(Me.btnProduct1)
        Me.Panel1.Controls.Add(Me.btnPrev)
        Me.Panel1.Controls.Add(Me.btnProduct4)
        Me.Panel1.Controls.Add(Me.btnProduct3)
        Me.Panel1.Controls.Add(Me.btnProduct9)
        Me.Panel1.Controls.Add(Me.btnProduct5)
        Me.Panel1.Controls.Add(Me.btnProduct6)
        Me.Panel1.Controls.Add(Me.btnProduct8)
        Me.Panel1.Controls.Add(Me.btnProduct2)
        Me.Panel1.Controls.Add(Me.btnProduct7)
        Me.Panel1.Location = New System.Drawing.Point(12, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 374)
        Me.Panel1.TabIndex = 3
        '
        'btnUpDirectory
        '
        Me.btnUpDirectory.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpDirectory.Location = New System.Drawing.Point(196, 277)
        Me.btnUpDirectory.Name = "btnUpDirectory"
        Me.btnUpDirectory.Size = New System.Drawing.Size(187, 69)
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
        'MainScreen
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 512)
        Me.Controls.Add(Me.lblPOS)
        Me.Controls.Add(Me.btnFullscreen)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "MainScreen"
        Me.Text = "Point of Sale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFullscreen As Button
    Friend WithEvents lblPOS As Label
    Friend WithEvents Panel1 As Panel
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
End Class
