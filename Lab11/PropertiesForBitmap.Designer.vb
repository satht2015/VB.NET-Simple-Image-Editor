<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PropertiesForBitmap
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.widthTextBox = New System.Windows.Forms.TextBox()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.selectColorButton = New System.Windows.Forms.Button()
        Me.okButton = New System.Windows.Forms.Button()
        Me.aCancelButton = New System.Windows.Forms.Button()
        Me.colorTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.inputGroupBox = New System.Windows.Forms.GroupBox()
        Me.inputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Width:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Height:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Background Color:"
        '
        'widthTextBox
        '
        Me.widthTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.widthTextBox.Location = New System.Drawing.Point(109, 30)
        Me.widthTextBox.Name = "widthTextBox"
        Me.widthTextBox.Size = New System.Drawing.Size(106, 22)
        Me.widthTextBox.TabIndex = 0
        '
        'heightTextBox
        '
        Me.heightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.heightTextBox.Location = New System.Drawing.Point(109, 72)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.Size = New System.Drawing.Size(106, 22)
        Me.heightTextBox.TabIndex = 1
        '
        'selectColorButton
        '
        Me.selectColorButton.Location = New System.Drawing.Point(155, 144)
        Me.selectColorButton.Name = "selectColorButton"
        Me.selectColorButton.Size = New System.Drawing.Size(83, 22)
        Me.selectColorButton.TabIndex = 3
        Me.selectColorButton.Text = "Select Color"
        Me.selectColorButton.UseVisualStyleBackColor = True
        '
        'okButton
        '
        Me.okButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.okButton.Location = New System.Drawing.Point(48, 200)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(84, 27)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'aCancelButton
        '
        Me.aCancelButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aCancelButton.Location = New System.Drawing.Point(147, 200)
        Me.aCancelButton.Name = "aCancelButton"
        Me.aCancelButton.Size = New System.Drawing.Size(84, 27)
        Me.aCancelButton.TabIndex = 2
        Me.aCancelButton.Text = "Cancel"
        Me.aCancelButton.UseVisualStyleBackColor = True
        '
        'colorTextBox
        '
        Me.colorTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorTextBox.Location = New System.Drawing.Point(151, 116)
        Me.colorTextBox.Name = "colorTextBox"
        Me.colorTextBox.Size = New System.Drawing.Size(83, 22)
        Me.colorTextBox.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(128, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "#"
        '
        'inputGroupBox
        '
        Me.inputGroupBox.Controls.Add(Me.Label5)
        Me.inputGroupBox.Controls.Add(Me.colorTextBox)
        Me.inputGroupBox.Controls.Add(Me.selectColorButton)
        Me.inputGroupBox.Controls.Add(Me.heightTextBox)
        Me.inputGroupBox.Controls.Add(Me.widthTextBox)
        Me.inputGroupBox.Controls.Add(Me.Label3)
        Me.inputGroupBox.Controls.Add(Me.Label2)
        Me.inputGroupBox.Controls.Add(Me.Label1)
        Me.inputGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputGroupBox.Location = New System.Drawing.Point(14, 15)
        Me.inputGroupBox.Name = "inputGroupBox"
        Me.inputGroupBox.Size = New System.Drawing.Size(251, 176)
        Me.inputGroupBox.TabIndex = 0
        Me.inputGroupBox.TabStop = False
        Me.inputGroupBox.Text = "Properties"
        '
        'PropertiesForBitmap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 245)
        Me.Controls.Add(Me.inputGroupBox)
        Me.Controls.Add(Me.aCancelButton)
        Me.Controls.Add(Me.okButton)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(294, 283)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(294, 283)
        Me.Name = "PropertiesForBitmap"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "New Image"
        Me.inputGroupBox.ResumeLayout(False)
        Me.inputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents widthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents heightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents selectColorButton As System.Windows.Forms.Button
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents aCancelButton As System.Windows.Forms.Button
    Friend WithEvents colorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents inputGroupBox As System.Windows.Forms.GroupBox
End Class
