'filename: MDIMain.vb
'This is the MDI parent form for the application.
'Natacha Gabbamonte 0932340
'11/12/2011

Imports System.Drawing.Imaging

Public Class MDIMain

    'This variable keeps track of the images opened.
    Private imageForms As List(Of ImageWindow) = New List(Of ImageWindow)(0)
    'This will be used for the names of the NEW bitmaps
    Private count As Integer = 1

    'Open click
    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openToolStripMenuItem.Click

        Dim isValid As Boolean = TryOpenImage()

        'Checking to see if the image is not already opened. ***BONUS 2
        If (isValid) Then
            If (imageForms.Count <> 0) Then
                For i As Integer = 0 To imageForms.Count - 1
                    If imageForms(i).Text.Equals(mdiMainOpenFileDialog.FileName) Then
                        imageForms(i).Focus()
                        Exit Sub
                    End If
                Next
            End If

            'Creating a new ImageWindow with the selected file name
            Dim newImage As ImageWindow = New ImageWindow(mdiMainOpenFileDialog.FileName)
            newImage.MdiParent = Me
            newImage.Text = mdiMainOpenFileDialog.FileName

            'Adding the fileName and Form to arrays ***BONUS 2
            imageForms.Add(newImage)

            newImage.Show()
        End If
    End Sub

    'This prompts the user for a fileName, and keeps doing so until a 
    'valid fileName is entered or the cancel button is pressed.
    Private Function TryOpenImage() As Boolean
        Dim fileName As String
        Dim isValid As Boolean = False
        Dim result As DialogResult
        mdiMainOpenFileDialog.FileName = ""
        Do
            result = mdiMainOpenFileDialog.ShowDialog()
            If (result = DialogResult.Cancel) Then
                Exit Do 'User pressed Cancel
            End If
            fileName = mdiMainOpenFileDialog.FileName
            isValid = ImageUtils.isValidExtension(fileName)
            If (Not isValid) Then
                MessageBox.Show(fileName & Environment.NewLine & "This image editor cannot read this file." _
                                & Environment.NewLine() & "This is not a valid bitmap file, or its format" & _
                                " is not currently supported.", "Nat's Image Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Loop Until isValid

        Return isValid
    End Function

    'Exit click
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Cascade Tool click
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    'Tile Horizontal click
    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    'Tile Vertical click
    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    'New Click ***BONUS 4
    Private Sub newToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles newToolStripMenuItem.Click
        Dim emptyBitmapForm As PropertiesForBitmap = New PropertiesForBitmap()
        emptyBitmapForm.ShowDialog()

        If (emptyBitmapForm.Canceled = False) Then
            'Create the new Bitmap with the information collected.
            Dim HTMLColorCode As String = emptyBitmapForm.colorTextBox.Text
            Dim color As Color = color.FromArgb(Convert.ToInt32(HTMLColorCode.Substring(0, 2), 16), _
                                                Convert.ToInt32(HTMLColorCode.Substring(2, 2), 16), _
                                                Convert.ToInt32(HTMLColorCode.Substring(4), 16))
            Me.Cursor = Cursors.WaitCursor
            Dim newImageWindow As ImageWindow = New ImageWindow("Untitled-" & count, CInt(emptyBitmapForm.widthTextBox.Text), _
                                     CInt(emptyBitmapForm.heightTextBox.Text), color)
            newImageWindow.MdiParent = Me
            newImageWindow.Text = "Untitled-" & count
            newImageWindow.Show()
            Me.Cursor = Cursors.Default
            count += 1
        End If
    End Sub

    'This returns the list of all the open ImageWindows
    Public Function getImageForms() As List(Of ImageWindow)
        Return imageForms
    End Function
End Class
