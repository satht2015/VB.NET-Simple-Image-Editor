'filename: PropertiesForBitmap.vb
'This form is used to collect information for a new bitmap.
'Natacha Gabbamonte 0932340
'11/12/2011

Public Class PropertiesForBitmap
    Private colorDialog As ColorDialog = New ColorDialog()
    Public Property Canceled As Boolean = True

    'The form's load event handler
    Private Sub PropertiesForBitmap_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        colorDialog.FullOpen = True
    End Sub

    'Select Color Click
    Private Sub SelectColorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectColorButton.Click
        colorDialog.ShowDialog()
        colorTextBox.Text = getHexValue(colorDialog.Color.R) & getHexValue(colorDialog.Color.G) & getHexValue(colorDialog.Color.B)
    End Sub

    'This returns the hex value of a value, always with two digits. 
    '(i.e 00, 0A)
    Private Function getHexValue(ByVal value As Byte)
        Dim hexStr As String = Hex(value)
        If (hexStr.Length = 1) Then
            hexStr = "0" & hexStr
        End If
        Return hexStr
    End Function

    'Handles KeyPress event for height and width text boxes.
    Private Sub widthAndHeightTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles widthTextBox.KeyPress, heightTextBox.KeyPress
        Dim textBox As TextBox = CType(sender, TextBox)
        If textBox.Text.Length = 4 Then
            If Not e.KeyChar = ControlChars.Back Then
                e.Handled = True
            End If
        End If

        Select Case e.KeyChar
            Case "0"c To "9"c, ControlChars.Back
                'These chars are the only accepted ones
            Case Else
                e.Handled = True
        End Select
    End Sub

    'Handles KeyPress event for the color text box.
    Private Sub colorTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles colorTextBox.KeyPress
        If colorTextBox.Text.Length = 6 Then
            If Not e.KeyChar = ControlChars.Back Then
                e.Handled = True
                Return
            End If
        End If
        Select Case e.KeyChar
            Case "0"c To "9"c, ControlChars.Back, "A"c, "B"c, "C"c, "D"c, "E"c, "F"c,
                "a"c, "b"c, "c"c, "d"c, "e"c, "f"c
                'These chars are the only accepted ones
            Case Else
                e.Handled = True
        End Select
    End Sub

    'The OK button click: validates user input.
    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click
        If widthTextBox.Text.Equals("") Then
            MessageBox.Show("Please enter a width.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            widthTextBox.Focus()
        ElseIf CInt(widthTextBox.Text) > 5000 Then
            MessageBox.Show("Please enter a width between 1 and 5000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            widthTextBox.Focus()
        ElseIf heightTextBox.Text.Equals("") Then
            MessageBox.Show("Please enter a height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            heightTextBox.Focus()
        ElseIf CInt(heightTextBox.Text) > 5000 Then
            MessageBox.Show("Please enter a height between 1 and 5000.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            widthTextBox.Focus()
        ElseIf colorTextBox.TextLength <> 6 Then
            MessageBox.Show("Please enter a valid color code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            colorTextBox.Focus()
        Else
            Canceled = False
            Me.Close()
        End If
    End Sub

    'The cancel button click handler.
    Private Sub aCancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aCancelButton.Click
        Me.Close()
    End Sub
End Class