Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Class Helper
    Public Shared s As New SaveFileDialog()
    Public Shared contador As Integer

    Public Shared Sub DefineCapture(ByVal image As System.Drawing.Image)


        contador = 0


        s.FileName = "image" '+ CStr(pontotit)
        ' Default file name
        's.DefaultExt = ".jpg"
        ' Default file extension
        's.Filter = "image (.jpg)|*.jpg"
        ' Filter files by extension
        ' Show save file dialog box
        ' Process save file dialog box results
        s.ShowDialog()


        'If s.ShowDialog() = DialogResult.OK Then
        ' Save Image
        'Dim filename As String = s.FileName
        'Dim fstream As New FileStream(filename, FileMode.Create)
        'image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg)

        'fstream.Close()

        'End If
    End Sub









    Public Shared Sub SaveImageCapture(ByVal image As System.Drawing.Image)

        ' While contador < 3
        contador = contador + 1

        'Dim s As New SaveFileDialog()
        's.FileName = "zumbi" '+ CStr(pontotit)
        ' Default file name
        's.DefaultExt = ".Jpg"
        ' Default file extension
        's.Filter = "zumbi (.jpg)|*.jpg"
        ' Filter files by extension
        ' Show save file dialog box
        ' Process save file dialog box results
        'If s.ShowDialog() = DialogResult.OK Then
        ' Save Image
        Dim filename As String = s.FileName + CStr(contador) + ".jpg"
        Dim fstream As New FileStream(filename, FileMode.Create)
        image.Save(fstream, System.Drawing.Imaging.ImageFormat.Jpeg)

        fstream.Close()
        ' End While
        'End If
    End Sub

    Public Shared Function GetImageAverageRGB(image As System.Drawing.Image) As System.Drawing.Color
        Using bmp = New Drawing.Bitmap(image)
            Dim reds As Long
            Dim greens As Long
            Dim blues As Long

            For x = 0 To bmp.Width - 1
                For y = 0 To bmp.Height - 1
                    With bmp.GetPixel(x, y)
                        reds += .R
                        greens += .G
                        blues += .B
                    End With
                Next
            Next

            Dim count = bmp.Height * bmp.Width
            Return System.Drawing.Color.FromArgb(reds / count, greens / count, blues / count)
        End Using
    End Function


End Class