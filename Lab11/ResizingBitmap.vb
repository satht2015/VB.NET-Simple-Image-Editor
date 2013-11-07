'filename: ResizingBitmap.vb
'This form is used to collect information for the resizing of a bitmap.
'Natacha Gabbamonte 0932340
'11/12/2011

Public Class ResizingBitmap

    'The original bitmap's size
    Private initialHeight As Integer
    Private initialWidth As Integer

    'This property is to know if the user canceled.
    Public Property Canceled As Boolean = True

    '2-parameter constructor
    Public Sub New(ByVal width As Integer, ByVal height As Integer)
        InitializeComponent()
        initialWidth = width
        initialHeight = height
    End Sub

    'Handles KeyPress event for the textboxes, only allowing integers.
    Private Sub widthAndHeightTextBox_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles heightTextBox.KeyPress, widthTextBox.KeyPress
        Select Case e.KeyChar
            Case "0"c To "9"c, ControlChars.Back
                'These are all valid.
            Case Else
                e.Handled = True
        End Select
    End Sub

    'Validates the user's input once the focus is lost.
    Private Sub widthTextBox_LostFocus(sender As Object, e As System.EventArgs) Handles widthTextBox.LostFocus
        validateWidthAndHeight(widthTextBox, heightTextBox, initialWidth, initialHeight)
    End Sub

    'Validates the user's input once the focus is lost.
    Private Sub heightTextBox_LostFocus(sender As Object, e As System.EventArgs) Handles heightTextBox.LostFocus
        validateWidthAndHeight(heightTextBox, widthTextBox, initialHeight, initialWidth)
    End Sub

    'This validates both the width and height textboxes.
    Private Sub validateWidthAndHeight(ByVal validatingTextBox As TextBox, ByVal otherTextBox As TextBox, ByVal validatingInitial As Integer, ByVal otherInitial As Integer)
        Dim anInt As Integer
        If percentRadioButton.Checked Then
            If validatingTextBox.Text.Equals("") Then
                validatingTextBox.Text = "100"
            ElseIf Integer.TryParse(validatingTextBox.Text, anInt) Then
                If anInt > 500 Then
                    validatingTextBox.Text = "500"

                ElseIf anInt = 0 Then
                    validatingTextBox.Text = "1"
                End If
            Else
                validatingTextBox.Text = "500"
            End If
            If aspectRatioCheckBox.Checked Then
                otherTextBox.Text = validatingTextBox.Text
            End If
        Else
            If validatingTextBox.Text.Equals("") Then
                validatingTextBox.Text = validatingInitial
                anInt = validatingInitial
            ElseIf Integer.TryParse(validatingTextBox.Text, anInt) Then
                If anInt > 5000 Then
                    validatingTextBox.Text = "5000"
                    anInt = 5000
                ElseIf anInt = 0 Then
                    validatingTextBox.Text = "1"
                    anInt = 1
                End If
            Else
                anInt = 5000
                validatingTextBox.Text = "5000"
            End If

            If aspectRatioCheckBox.Checked Then
                Dim ratio As Double = anInt / validatingInitial
                Dim newValue As Integer = CInt(otherInitial * ratio)
                otherTextBox.Text = CStr(CInt(otherInitial * ratio))
                If newValue > 5000 Then
                    ratio = newValue / 5000
                    otherTextBox.Text = "5000"
                    validatingTextBox.Text = CStr(CInt(CInt(validatingTextBox.Text) / ratio))
                End If
            End If

        End If
    End Sub

    'Changes the initial values in the textboxes to percentages
    Private Sub percentRadioButton_CheckedChanged(sender As Object, e As System.EventArgs) Handles percentRadioButton.CheckedChanged
        If percentRadioButton.Checked Then
            widthTextBox.Text = "100"
            heightTextBox.Text = "100"
        End If
    End Sub

    'Changes the initial values in the textboxes to pixels
    Private Sub pixelsRadioButton_CheckedChanged(sender As Object, e As System.EventArgs) Handles pixelsRadioButton.CheckedChanged
        If pixelsRadioButton.Checked Then
            widthTextBox.Text = CStr(initialWidth)
            heightTextBox.Text = CStr(initialHeight)
        End If
    End Sub

    'Cancel button click event handler.
    Private Sub aCancelButton_Click(sender As System.Object, e As System.EventArgs) Handles aCancelButton.Click
        Me.Close()
    End Sub

    'OK button click event handler.
    Private Sub okButton_Click(sender As System.Object, e As System.EventArgs) Handles okButton.Click
        Canceled = False
        Me.Close()
    End Sub
End Class