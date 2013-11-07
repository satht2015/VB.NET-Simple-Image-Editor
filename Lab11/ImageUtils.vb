'filename: ImageUtils.vb
'This module contains various utility functions.
'Natacha Gabbamonte 0932340
'11/12/2011

Imports System.Drawing.Imaging

Module ImageUtils

    'This function checks to see if the filename has one of the following extensions:
    'jpg/png/bmp/gif
    'Parameter:
    'fileName is the file name that will be validated.
    Public Function isValidExtension(ByVal fileName As String) As Boolean
        Dim allExtensions As String() = New String() {".jpg", ".gif", ".png", ".bmp"}
        Dim extension As String
        Dim indexOfDot As Integer = fileName.IndexOf(".")

        If (indexOfDot <> -1) Then
            extension = fileName.Substring(indexOfDot)
            For Each ext In allExtensions
                If extension.Equals(ext) Then
                    Return True 'A match was found
                End If
            Next
        End If

        Return False 'No match found
    End Function

    'This function determines the format in which the picture will be saved.
    'Parameter:
    'fileName is the name of the future image.
    Public Function DetermineFormat(ByVal fileName As String) As ImageFormat
        Dim aFormat As ImageFormat = Nothing
        Select Case fileName.Substring(fileName.IndexOf("."))
            Case ".jpg"
                aFormat = ImageFormat.Jpeg
            Case ".gif"
                aFormat = ImageFormat.Gif
            Case ".png"
                aFormat = ImageFormat.Png
            Case ".bmp"
                aFormat = ImageFormat.Bmp
        End Select
        Return aFormat
    End Function

    'This function invert the colors of eahc pixel in a Bitmap
    'Parameters:
    'bm is the Bitmap to be inverted
    Public Sub Invert(ByVal bm As Bitmap)
        Dim maxWidth As Integer = bm.Width - 1
        Dim maxHeight As Integer = bm.Height - 1

        For x As Integer = 0 To maxWidth
            For y As Integer = 0 To maxHeight
                Dim aColor As Color = bm.GetPixel(x, y)
                Dim newColor As Color = Color.FromArgb(255 - aColor.R, 255 - aColor.G, 255 - aColor.B)
                bm.SetPixel(x, y, newColor)
            Next
        Next
    End Sub

    '***BONUS 1
    'This sub sets the colors of a Bitmap to grayscale.
    'Parameters:
    'bm is the Bitmap to be inverted
    Public Sub GrayScale(ByVal bm As Bitmap)
        Dim maxWidth As Integer = bm.Width - 1
        Dim maxHeight As Integer = bm.Height - 1
        Dim aPixel As Color
        Dim newColor As Integer

        For x As Integer = 0 To maxWidth
            For y As Integer = 0 To maxHeight
                aPixel = bm.GetPixel(x, y)
                newColor = (CInt(aPixel.R) + aPixel.B + aPixel.G) \ 3
                bm.SetPixel(x, y, Color.FromArgb(newColor, newColor, newColor))
            Next
        Next

    End Sub

    '***BONUS 1
    'This sub blurs the Bitmap sent in.
    'Parameters:
    'bm is the Bitmap to be blurred
    'degree represents the intensity of the blur, the higher it is,
    'the more blurry the image becomes.

    Public Sub Blur(ByVal bm As Bitmap, ByVal degree As Integer)

        Dim maxWidth As Integer = bm.Width - 1 - degree
        Dim maxHeight As Integer = bm.Height - 1 - degree
        Dim pixel1 As Color
        Dim otherPixel As Color
        Dim redValues As Integer
        Dim greenValues As Integer
        Dim blueValues As Integer
        Dim counter As Integer

        For x As Integer = degree To maxWidth
            For y As Integer = degree To maxHeight

                pixel1 = bm.GetPixel(x, y)
                redValues = pixel1.R
                greenValues = pixel1.G
                blueValues = pixel1.B
                counter = 1

                For i As Integer = 1 To degree
                    otherPixel = bm.GetPixel(x - i, y)
                    redValues += otherPixel.R
                    greenValues += otherPixel.G
                    blueValues += otherPixel.B

                    otherPixel = bm.GetPixel(x - i, y - i)
                    redValues += otherPixel.R
                    greenValues += otherPixel.G
                    blueValues += pixel1.B

                    otherPixel = bm.GetPixel(x, y - i)
                    redValues += otherPixel.R
                    greenValues += otherPixel.G
                    blueValues += otherPixel.B

                    otherPixel = bm.GetPixel(x - i, y + i)
                    redValues += otherPixel.R
                    greenValues += otherPixel.G
                    blueValues += otherPixel.B

                    otherPixel = bm.GetPixel(x + i, y)
                    redValues += otherPixel.R
                    greenValues += otherPixel.G
                    blueValues += otherPixel.B

                    otherPixel = bm.GetPixel(x + i, y + i)
                    redValues += otherPixel.R
                    greenValues += otherPixel.G
                    blueValues += otherPixel.B

                    otherPixel = bm.GetPixel(x, y + i)
                    redValues += otherPixel.R
                    greenValues += otherPixel.G
                    blueValues += otherPixel.B

                    counter += 7
                Next

                redValues \= counter
                greenValues \= counter
                blueValues \= counter

                bm.SetPixel(x, y, Color.FromArgb(redValues, greenValues, blueValues))

                For i As Integer = 1 To degree
                    bm.SetPixel(x + i, y, Color.FromArgb(redValues, greenValues, blueValues))
                    bm.SetPixel(x + i, y + i, Color.FromArgb(redValues, greenValues, blueValues))
                    bm.SetPixel(x, y + i, Color.FromArgb(redValues, greenValues, blueValues))
                    bm.SetPixel(x - i, y, Color.FromArgb(redValues, greenValues, blueValues))
                    bm.SetPixel(x, y - i, Color.FromArgb(redValues, greenValues, blueValues))
                    bm.SetPixel(x + i, y - i, Color.FromArgb(redValues, greenValues, blueValues))
                    bm.SetPixel(x - i, y - i, Color.FromArgb(redValues, greenValues, blueValues))
                Next
            Next
        Next

    End Sub

End Module
