'filename: ImageWindow.vb
'This class defines the MDI child window. An ImageWindow form can be
'created from a file in memory or simply with a width, height and 
'background color
'Natacha Gabbamonte 0932340
'11/12/2011

Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D

Public Class ImageWindow

    'The location of the Image
    Private fileName As String
    Private changed As Boolean = False
    Private isFromFile As Boolean = True

    'Variables needed for cropping
    Private copyOfBitmap As Bitmap
    Private cropX As Integer
    Private cropY As Integer
    Private cropWidth As Integer
    Private cropHeight As Integer
    Private cropPen As Pen
    Private cropStarted As Boolean = False

    'ImageWindow contructor for a file from memory
    Public Sub New(ByVal fileName As String)
        InitializeComponent()
        Me.fileName = fileName
        Dim bm As New Bitmap(fileName)
        LoadImage(bm)
    End Sub

    'ImageWIndow constructor for a new image
    Public Sub New(ByVal fileName As String, ByVal width As Integer, ByVal height As Integer, ByVal backColor As Color)
        InitializeComponent()
        Me.fileName = fileName
        isFromFile = False
        changed = True
        Dim newBitmap As Bitmap = New Bitmap(width, height, PixelFormat.Format16bppRgb555)

        For X As Integer = 0 To width - 1
            For Y As Integer = 0 To height - 1
                newBitmap.SetPixel(X, Y, backColor)
            Next
        Next

        LoadImage(newBitmap)
    End Sub

    Private Sub ImageWindow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Initializes the Crop tools
        cropPen = New Pen(Color.Black, 2)
        cropPen.DashStyle = DashStyle.Dash
    End Sub

    'Loads a bitmap image
    Private Sub LoadImage(ByVal bm As Bitmap)

        Dim width As Integer = bm.Width
        Dim height As Integer = bm.Height

        Dim fixedWidth As Integer = Me.Width - imageWindowPictureBox.Width
        Dim fixedHeight As Integer = Me.Height - imageWindowPictureBox.Height

        Dim ratio As Double = width / height

        If bm.Width < Me.Width AndAlso bm.Height < Me.Height Then
            Me.Height = bm.Height + fixedHeight
            Me.Width = bm.Width + fixedWidth
        Else
            If ratio > 1 Then
                Me.Height = (imageWindowPictureBox.Height / ratio) + fixedHeight
            Else
                Me.Width = (imageWindowPictureBox.Width * ratio) + fixedWidth
            End If
        End If
        imageWindowPictureBox.Image = bm
    End Sub

    'Closes the child window
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Saves an image.
    Private Function SaveBitmap(ByVal fileName As String) As Boolean
        Try
            If (ImageUtils.isValidExtension(fileName)) Then
                Dim newBitmap As Bitmap = New Bitmap(imageWindowPictureBox.Image)
                Dim format As ImageFormat = ImageUtils.DetermineFormat(fileName)
                imageWindowPictureBox.Image.Dispose()
                newBitmap.Save(fileName, format)
                imageWindowPictureBox.Image = newBitmap
                Me.fileName = fileName
                Me.Text = fileName
                If isFromFile = False Then
                    CType(Me.ParentForm, MDIMain).getImageForms.Add(Me)
                End If
                changed = False
                isFromFile = True
                Return True
            Else
                Return False
            End If
        Catch exc As Exception
            MessageBox.Show("Exception occured: " & exc.Message())
            Return False
        End Try
        changed = False
        If isFromFile = False Then
            CType(Me.ParentForm, MDIMain).getImageForms.Add(Me)
        End If
        isFromFile = True
        Return True
    End Function

    'Save Button
    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click
        If (isFromFile) Then
            SaveBitmap(fileName)
        Else
            SaveAsToolStripMenuItem.PerformClick()
        End If
    End Sub

    'Save As Button
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsToolStripMenuItem.Click
        saveAs()
    End Sub

    'This method takes care of asking the user for the location to save the image at.
    'It returns true if the user clicked on the cancel button.
    Private Function saveAs() As Boolean
        Dim isValid As Boolean = False
        Dim canceled As Boolean = False
        Dim result As DialogResult
        '***BONUS 5  Sets initial directory to the directory of the original file opened by this form.
        If (isFromFile) Then
            imageWindowSaveFileDialog.InitialDirectory = fileName.Substring(0, fileName.LastIndexOf("\"))
            imageWindowSaveFileDialog.FileName = fileName.Substring(fileName.LastIndexOf("\") + 1)
        End If
        Do
            result = imageWindowSaveFileDialog.ShowDialog()
            If (Not result = DialogResult.Cancel) Then
                If (SaveBitmap(imageWindowSaveFileDialog.FileName)) Then
                    isValid = True
                Else
                    MessageBox.Show("You have tried to save in an invalid format!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                canceled = True
                isValid = True
            End If
        Loop Until isValid

        Return canceled
    End Function

    'Inverts the colors of the Image
    Private Sub InvertToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvertToolStripMenuItem.Click
        Me.Parent.Cursor = Cursors.WaitCursor
        Dim aBitmap As Bitmap = imageWindowPictureBox.Image
        ImageUtils.Invert(aBitmap)
        imageWindowPictureBox.Image = aBitmap
        changed = True
        Me.Parent.Cursor = Cursors.Default
    End Sub

    'Converts a Bitmap to Grayscale.
    Private Sub GrayscaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrayscaleToolStripMenuItem.Click
        Me.Parent.Cursor = Cursors.WaitCursor
        Dim aBitmap As Bitmap = imageWindowPictureBox.Image
        ImageUtils.GrayScale(aBitmap)
        imageWindowPictureBox.Image = aBitmap
        changed = True
        Me.Parent.Cursor = Cursors.Default
    End Sub

    'This intercepts the form's closing event. It warns the user if the image has been changed since the last time it was saved.
    '***BONUS 3
    Private Sub ImageWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If changed Then
            Dim result As DialogResult
            result = MessageBox.Show("Do you want to save changes to " & fileName & "?", "Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                If isFromFile Then
                    SaveBitmap(fileName)
                    CType(Me.ParentForm, MDIMain).getImageForms.Remove(Me)
                Else 'Will go here if it is a NEW image
                    If (saveAs()) Then
                        'This means Cancel was pressed
                        'therefore we don't want to close.
                        e.Cancel = True
                    End If
                End If
            ElseIf result = DialogResult.Cancel Then
                e.Cancel = True
            Else
                CType(Me.ParentForm, MDIMain).getImageForms.Remove(Me)
            End If
        Else
            CType(Me.ParentForm, MDIMain).getImageForms.Remove(Me)
        End If

    End Sub

    'Resize button click ***BONUS 1
    Private Sub ResizeToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ResizeToolStripMenuItem.Click
        Dim aResizingBitmap As ResizingBitmap = New ResizingBitmap(imageWindowPictureBox.Image.Width, _
                                                                   imageWindowPictureBox.Image.Height)
        aResizingBitmap.ShowDialog()

        Me.Parent.Cursor = Cursors.WaitCursor

        'Use information gathered to make the appropriate changes.
        Dim newWidth As Integer
        Dim newHeight As Integer
        If Not aResizingBitmap.Canceled Then
            If aResizingBitmap.percentRadioButton.Checked Then
                newWidth = CInt(imageWindowPictureBox.Image.Width * _
                    (CInt(aResizingBitmap.widthTextBox.Text) / 100))
                newHeight = CInt(imageWindowPictureBox.Image.Height * _
                    (CInt(aResizingBitmap.heightTextBox.Text) / 100))
            Else
                newWidth = CInt(aResizingBitmap.widthTextBox.Text)
                newHeight = CInt(aResizingBitmap.heightTextBox.Text)
            End If

            Dim sourceBitmap As Bitmap = imageWindowPictureBox.Image
            Dim newBitmap As Bitmap = New Bitmap(newWidth, newHeight)

            Dim aGraphic As Graphics = Graphics.FromImage(newBitmap)
            aGraphic.DrawImage(sourceBitmap, 0, 0, newWidth + 1, newHeight + 1)

            imageWindowPictureBox.Image = newBitmap

            changed = True
            aGraphic.Dispose()
            sourceBitmap.Dispose()
        End If
        Me.Parent.Cursor = Cursors.Default
    End Sub

    'Blur button click ***BONUS 1
    'Parameter:
    'degree is the degree of the blur
    Private Sub blurImage(ByVal degree As Integer)
        Me.Parent.Cursor = Cursors.WaitCursor
        Dim aBitmap As Bitmap = imageWindowPictureBox.Image
        ImageUtils.Blur(aBitmap, degree)
        imageWindowPictureBox.Image = aBitmap
        changed = True
        Me.Parent.Cursor = Cursors.Default
    End Sub

    'Level 1 blur
    Private Sub Level1ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Level1ToolStripMenuItem.Click
        blurImage(1)
    End Sub

    'Level 2 blur
    Private Sub Level2ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Level2ToolStripMenuItem.Click
        blurImage(2)
    End Sub

    'Level 3 blur
    Private Sub Level3ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles Level3ToolStripMenuItem.Click
        blurImage(3)
    End Sub

    'When the CropTool is selected, then we must start a crop selection.
    '(BONUS 1 - Incomplete)
    Private Sub imageWindowPictureBox_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles imageWindowPictureBox.MouseDown
        If CropToolStripMenuItem.Checked Then
            'This means the Crop tool is activated.
            copyOfBitmap = imageWindowPictureBox.Image
            cropX = e.X - (Me.Width - imageWindowPictureBox.Width) \ 2
            cropY = e.Y - (Me.Height - imageWindowPictureBox.Height) \ 2
            cropStarted = True
        End If
    End Sub

    'When the CropTool is selected, the rectangle must be drawn.
    '(BONUS 1 - Incomplete)
    Private Sub imageWindowPictureBox_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles imageWindowPictureBox.MouseMove
        If cropStarted Then
            If CropToolStripMenuItem.Checked Then
                imageWindowPictureBox.Image = copyOfBitmap
                cropWidth = Math.Abs(e.X - cropX)
                cropHeight = Math.Abs(e.Y - cropY)
                imageWindowPictureBox.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)
            End If
        End If
    End Sub

    'MouseUp event when the CropTool is checked means that the region to
    'be cropped has been selected.
    '(BONUS 1 - Incomplete)
    Private Sub imageWindowPictureBox_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles imageWindowPictureBox.MouseUp
        If CropToolStripMenuItem.Checked Then
            'This means the Crop tool is activated.
            imageWindowPictureBox.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)
            Dim result As DialogResult
            result = MessageBox.Show("Are you sure you want to crop this image?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim newBitmap As Bitmap = New Bitmap(cropWidth, cropHeight)
                Dim aGraphic As Graphics = Graphics.FromImage(newBitmap)
                Dim aRectangle As Rectangle = New Rectangle(cropX, cropY, cropWidth, cropHeight)
                aGraphic.DrawImage(copyOfBitmap, 0, 0, aRectangle, GraphicsUnit.Pixel)
                imageWindowPictureBox.Image = newBitmap
                copyOfBitmap.Dispose()
                changed = True
            Else
                imageWindowPictureBox.Image = copyOfBitmap
            End If
            CropToolStripMenuItem.Checked = False
            cropStarted = False
        End If
    End Sub

    'This changes the cursor depending on if the CropTool is checked
    'or not.
    '(BONUS 1 - Incomplete)
    Private Sub CropToolStripMenuItem_CheckedChanged(sender As Object, e As System.EventArgs) Handles CropToolStripMenuItem.CheckedChanged
        If CropToolStripMenuItem.Checked = True Then
            Me.Parent.Cursor = Cursors.Cross
        Else
            Me.Parent.Cursor = Cursors.Default
        End If
    End Sub
End Class