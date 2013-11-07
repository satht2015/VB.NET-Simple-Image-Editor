<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResizingBitmap
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
        Me.inputGroupBox = New System.Windows.Forms.GroupBox()
        Me.heightTextBox = New System.Windows.Forms.TextBox()
        Me.widthTextBox = New System.Windows.Forms.TextBox()
        Me.aspectRatioCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pixelsRadioButton = New System.Windows.Forms.RadioButton()
        Me.percentRadioButton = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.okButton = New System.Windows.Forms.Button()
        Me.aCancelButton = New System.Windows.Forms.Button()
        Me.inputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'inputGroupBox
        '
        Me.inputGroupBox.Controls.Add(Me.heightTextBox)
        Me.inputGroupBox.Controls.Add(Me.widthTextBox)
        Me.inputGroupBox.Controls.Add(Me.aspectRatioCheckBox)
        Me.inputGroupBox.Controls.Add(Me.Label3)
        Me.inputGroupBox.Controls.Add(Me.Label2)
        Me.inputGroupBox.Controls.Add(Me.pixelsRadioButton)
        Me.inputGroupBox.Controls.Add(Me.percentRadioButton)
        Me.inputGroupBox.Controls.Add(Me.Label1)
        Me.inputGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputGroupBox.Location = New System.Drawing.Point(20, 18)
        Me.inputGroupBox.Name = "inputGroupBox"
        Me.inputGroupBox.Size = New System.Drawing.Size(245, 190)
        Me.inputGroupBox.TabIndex = 0
        Me.inputGroupBox.TabStop = False
        Me.inputGroupBox.Text = "Resize"
        '
        'heightTextBox
        '
        Me.heightTextBox.Location = New System.Drawing.Point(106, 102)
        Me.heightTextBox.Name = "heightTextBox"
        Me.heightTextBox.Size = New System.Drawing.Size(109, 21)
        Me.heightTextBox.TabIndex = 7
        Me.heightTextBox.Text = "100"
        '
        'widthTextBox
        '
        Me.widthTextBox.Location = New System.Drawing.Point(106, 69)
        Me.widthTextBox.Name = "widthTextBox"
        Me.widthTextBox.Size = New System.Drawing.Size(109, 21)
        Me.widthTextBox.TabIndex = 6
        Me.widthTextBox.Text = "100"
        '
        'aspectRatioCheckBox
        '
        Me.aspectRatioCheckBox.AutoSize = True
        Me.aspectRatioCheckBox.Checked = True
        Me.aspectRatioCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.aspectRatioCheckBox.Location = New System.Drawing.Point(52, 152)
        Me.aspectRatioCheckBox.Name = "aspectRatioCheckBox"
        Me.aspectRatioCheckBox.Size = New System.Drawing.Size(140, 19)
        Me.aspectRatioCheckBox.TabIndex = 5
        Me.aspectRatioCheckBox.Text = "Maintain aspect ratio"
        Me.aspectRatioCheckBox.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Height:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Width:"
        '
        'pixelsRadioButton
        '
        Me.pixelsRadioButton.AutoSize = True
        Me.pixelsRadioButton.Location = New System.Drawing.Point(169, 25)
        Me.pixelsRadioButton.Name = "pixelsRadioButton"
        Me.pixelsRadioButton.Size = New System.Drawing.Size(58, 19)
        Me.pixelsRadioButton.TabIndex = 2
        Me.pixelsRadioButton.Text = "Pixels"
        Me.pixelsRadioButton.UseVisualStyleBackColor = True
        '
        'percentRadioButton
        '
        Me.percentRadioButton.AutoSize = True
        Me.percentRadioButton.Checked = True
        Me.percentRadioButton.Location = New System.Drawing.Point(62, 25)
        Me.percentRadioButton.Name = "percentRadioButton"
        Me.percentRadioButton.Size = New System.Drawing.Size(88, 19)
        Me.percentRadioButton.TabIndex = 1
        Me.percentRadioButton.TabStop = True
        Me.percentRadioButton.Text = "Percentage"
        Me.percentRadioButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "By:"
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(46, 223)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(84, 27)
        Me.okButton.TabIndex = 1
        Me.okButton.Text = "OK"
        Me.okButton.UseVisualStyleBackColor = True
        '
        'aCancelButton
        '
        Me.aCancelButton.Location = New System.Drawing.Point(154, 223)
        Me.aCancelButton.Name = "aCancelButton"
        Me.aCancelButton.Size = New System.Drawing.Size(84, 27)
        Me.aCancelButton.TabIndex = 2
        Me.aCancelButton.Text = "Cancel"
        Me.aCancelButton.UseVisualStyleBackColor = True
        '
        'ResizingBitmap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.aCancelButton)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.inputGroupBox)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "ResizingBitmap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resize"
        Me.inputGroupBox.ResumeLayout(False)
        Me.inputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inputGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents aspectRatioCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pixelsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents percentRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents heightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents widthTextBox As System.Windows.Forms.TextBox
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents aCancelButton As System.Windows.Forms.Button
End Class
