Module modImage

    Private Function Negation(ByRef color As Color) As Color
        Dim red As Integer = color.R
        Dim green As Integer = color.G
        Dim blue As Integer = color.B

        red = 255 - red
        green = 255 - green
        blue = 255 - blue

        Return color.FromArgb(red, green, blue)
    End Function

    Public Sub outOfImage(ByRef image As Bitmap, ByRef x As Integer, ByRef y As Integer)
        'out of image cases
        If x < 0 Then x = 0
        If y < 0 Then y = 0
        If x > image.Width - 1 Then x = image.Width - 1
        If y > image.Height - 1 Then y = image.Height - 1
    End Sub

    Private Sub blurColor(ByRef image As Bitmap, ByRef color As Integer, ByVal colType As String, ByVal x As Integer, ByVal y As Integer)
        outOfImage(image, x, y)
        Select Case colType
            Case "R"
                color += image.GetPixel(x, y).R
            Case "G"
                color += image.GetPixel(x, y).G
            Case "B"
                color += image.GetPixel(x, y).B
        End Select
    End Sub

    ' This function applies blur on a pixel using a different size of kernel
    Public Function Blur(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer, ByVal size As Integer) As Color
        Dim red As Integer
        Dim green As Integer
        Dim blue As Integer

        ' Apply blur on the pixel based on the size here

        For i As Integer = x - size To x + size
            For j As Integer = y - size To y + size
                blurColor(image, red, "R", i, j)
                blurColor(image, green, "G", i, j)
                blurColor(image, blue, "B", i, j)
            Next j
        Next i
        red = red / ((2 * size + 1) ^ 2)
        green = green / ((2 * size + 1) ^ 2)
        blue = blue / ((2 * size + 1) ^ 2)

        Return Color.FromArgb(red, green, blue)
    End Function

    Private Sub edgeColor(ByRef image As Bitmap, ByRef color As Integer, ByVal colType As String, _
                          ByVal x As Integer, ByVal y As Integer, ByVal strength As Integer)
        outOfImage(image, x, y)
        Select Case colType
            Case "R"
                color -= strength * image.GetPixel(x, y).R
            Case "G"
                color -= strength * image.GetPixel(x, y).G
            Case "B"
                color -= strength * image.GetPixel(x, y).B
        End Select
    End Sub

    ' This function applies edge on a pixel
    Public Function Edge(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer, _
                         ByVal strength As Integer, ByVal index As Integer) As Color
        Dim red As Integer = 8 * strength * image.GetPixel(x, y).R ' 4 for edge, 5 for sharpen
        Dim green As Integer = 8 * strength * image.GetPixel(x, y).G
        Dim blue As Integer = 8 * strength * image.GetPixel(x, y).B

        If index = 2 Then
            red += image.GetPixel(x, y).R
            green += image.GetPixel(x, y).G
            blue += image.GetPixel(x, y).B
        End If

        ' Apply edge on the pixel using a simple edge kernel here
        '
        ' -1s -1s -1s
        ' -1s  8s -1s
        ' -1s -1s -1s

        For i As Integer = x - 1 To x + 1
            For j As Integer = y - 1 To y + 1
                If i = x And j = y Then
                    Continue For
                End If
                edgeColor(image, red, "R", i, j, strength)
                edgeColor(image, green, "G", i, j, strength)
                edgeColor(image, blue, "B", i, j, strength)
            Next j
        Next i

        ' handle negative cases
        red = ClipByte(Math.Abs(red))
        green = ClipByte(Math.Abs(green))
        blue = ClipByte(Math.Abs(blue))

        If index = 1 Then
            'image.SetPixel(x, y, Negation(image.GetPixel(x, y)))
            red = 255 - red
            green = 255 - green
            blue = 255 - blue
        End If

        Return Color.FromArgb(red, green, blue)
    End Function

    ' This function applies roughen on a pixel using a deviation from 0 to 1
    Public Function Roughen(ByVal color As Color, ByVal deviation As Double, _
                            ByVal isHue As Boolean, ByVal isSat As Boolean, ByVal isVal As Boolean) As Color
        Dim red As Integer = color.R
        Dim green As Integer = color.G
        Dim blue As Integer = color.B
        Dim hue As Integer
        Dim saturation As Double
        Dim value As Double

        RGB2HSV(red, green, blue, hue, saturation, value)

        Randomize()
        Dim rndDevH As Double = (2 * deviation) * (Rnd()) - deviation
        Dim rndDevS As Double = (2 * deviation) * (Rnd()) - deviation
        Dim rndDevV As Double = (2 * deviation) * (Rnd()) - deviation

        ' Adjust the HSV component of the colour using the deviation here
        If isHue Then
            hue += rndDevH * 360 Mod 360
            hue = ClipByte(hue)
        End If
        If isSat Then
            saturation += rndDevS
            saturation = ClipFloat(saturation)
        End If
        If isVal Then
            value += rndDevV
            value = ClipFloat(value)
        End If

        HSV2RGB(hue, saturation, value, red, green, blue)

        Return color.FromArgb(red, green, blue)
    End Function

    Public Sub sineMelt(ByRef rect As Rectangle, ByRef displacement() As Integer, _
                        ByVal amplitude As Integer, ByVal cycle As Integer)
        For i As Integer = 0 To rect.Width
            displacement(i) = Math.Abs(amplitude * Math.Sin(2 * Math.PI * cycle * (i / rect.Width)))
        Next i
    End Sub

    Public Sub randomMelt(ByVal rect As Rectangle, ByRef displacement() As Integer, _
                          ByVal useSine As Boolean, ByVal offset As Integer, ByVal period As Integer)
        'Reset values
        Dim x As Integer = 0
        Dim currentOffset As Integer = 0

        'A loop to go through each column from left to right
        Do While x < rect.Width
            'Period is a random number from 1 to maximum value set by slider
            Dim currentPeriod As Integer = 1 + Rnd() * (period - 1)
            Dim sign As Integer

            'Sign is a random choice, either -1 (down) or 1 (up)
            If Rnd() >= 0.5 Then
                sign = 1
            Else
                sign = -1
            End If

            'A loop to generate the displacements for the current period
            For i As Integer = x To x + currentPeriod - 1
                If i > rect.Width Then Exit For
                'For each column i, create the random offset
                currentOffset = currentOffset + sign * Rnd() * offset
                If currentOffset < 0 Then
                    currentOffset = -1 * currentOffset
                    sign = -1 * sign
                End If

                If useSine Then
                    displacement(i) += currentOffset
                Else
                    displacement(i) = currentOffset
                End If
            Next i
            x += currentPeriod
        Loop

    End Sub

    Public Sub angledMelt(ByVal input As Bitmap, ByVal output As Bitmap, ByVal rect As Rectangle, _
                          ByVal useSine As Boolean, ByVal amplitude As Integer, ByVal cycle As Integer, _
                          ByVal useRandom As Boolean, ByVal offset As Integer, ByVal period As Integer, _
                          ByVal angle As Integer)
        Dim temp1 As Bitmap = output.Clone()
        Rotate(input, temp1, rect, 360 - angle, frmMain.iObject, frmMain.currentImageIndex)
        Dim temp2 As Bitmap = temp1.Clone()
        Melt(temp1, temp2, rect, useSine, amplitude, cycle, useRandom, offset, period, 0)
        Dim temp3 As Bitmap = temp2.Clone()
        frmMain.iObject(frmMain.currentImageIndex).Reset(temp2.Clone())
        Rotate(temp2, temp3, rect, angle, frmMain.iObject, frmMain.currentImageIndex, True)
        frmMain.iObject(frmMain.currentImageIndex).Reset(temp3.Clone())
    End Sub

    ' This function applies melt on an input image
    Public Sub Melt(ByRef input As Bitmap, ByRef output As Bitmap, ByVal rect As Rectangle, _
                    ByVal useSine As Boolean, ByVal amplitude As Integer, ByVal cycle As Integer, _
                    ByVal useRandom As Boolean, ByVal offset As Integer, ByVal period As Integer, _
                    ByVal angle As Integer)

        Dim x, y As Integer
        Dim freq As Integer = 4
        Dim mag As Integer = 10
        For x = 0 To input.Width - 1
            For y = 0 To input.Height - 1
                Dim temp As Double
                temp = Math.Sin(y * Math.PI / 180 * freq)
                Dim sx As Integer = Math.Floor(temp * mag + x)
                temp = Math.Sin(x * Math.PI / 180 * freq)
                Dim sy As Integer = Math.Floor(temp * mag + y)
                Dim c As Color = Nothing
                If sx < 0 Or sx >= input.Width - 1 Or sy < 0 Or sy >= input.Height Then
                    c = Color.Black
                Else
                    c = input.GetPixel(sx, sy)
                End If
                output.SetPixel(x, y, c)
            Next y
        Next x

        'Dim displacement(0 To rect.Width) As Integer
        'If angle > 0 Then
        '    angledMelt(input, output, rect, useSine, amplitude, cycle, useRandom, offset, period, angle)
        '    output = frmMain.iObject(frmMain.currentImageIndex).originalImage.Clone()
        '    Exit Sub
        'End If

        '' Apply melt to the selected area here
        'If useSine Then
        '    sineMelt(rect, displacement, amplitude, cycle)
        '    If useRandom Then 'combination: both are checked
        '        randomMelt(rect, displacement, True, offset, period)
        '    End If
        'ElseIf useRandom Then
        '    randomMelt(rect, displacement, False, offset, period)
        'Else
        '    MsgBox("Error: You need to select at least one method")
        '    Exit Sub
        'End If

        'For i As Integer = rect.Left To rect.Right
        '    For j As Integer = rect.Top To rect.Bottom
        '        Dim displace As Integer = j - displacement(i - rect.X)
        '        If displace > rect.Bottom Then
        '            displace = rect.Bottom 'set it to inside rect if it reaches out. 
        '        ElseIf displace < rect.Top Then
        '            displace = rect.Top
        '        End If
        '        'Output to a new image
        '        If i < 0 Or displace < 0 Or i >= input.Width Or displace >= input.Height Or j >= output.Height Then
        '            Continue For
        '        Else
        '            output.SetPixel(i, j, input.GetPixel(i, displace))
        '        End If
        '    Next j
        'Next i
    End Sub

    ' This function applies rotation on an input image
    Public Sub Rotate(ByRef input As Bitmap, ByRef output As Bitmap, ByVal rect As Rectangle, ByVal angle As Integer, ByRef iObject() As frmMain.imageObject, ByVal currentIndex As Integer, Optional ByVal isMelt As Boolean = False)
        ' Apply rotation to the selected area here
        Dim originalImage As Bitmap = iObject(currentIndex).originalImage.Clone()
        Dim rotatedImage As Bitmap = iObject(currentIndex).rotatedImage.Clone()
        Dim rotatedLayer As Bitmap
        iObject(currentIndex).currentAngle += angle
        angle = iObject(currentIndex).currentAngle
        If angle > 360 Then
            angle -= 360
            iObject(currentIndex).currentAngle = angle
        End If

        If angle = 0 Or (angle Mod 360 = 0 And rect.Width = input.Width - 1 And rect.Height = input.Height - 1) Then
            output = originalImage
            iObject(currentIndex).rotatedImage = originalImage
            Exit Sub
        ElseIf angle Mod 180 = 0 And rect.Width = input.Width - 1 And rect.Height = input.Height - 1 Then
            output = originalImage
            output.RotateFlip(RotateFlipType.Rotate180FlipNone)
            If Not rotatedLayer Is Nothing Then
                rotatedLayer.RotateFlip(RotateFlipType.Rotate180FlipNone)
            End If
            iObject(currentIndex).rotatedImage = output.Clone()
            Exit Sub
        ElseIf angle = 360 Then
            output = originalImage
            iObject(currentIndex).rotatedImage = originalImage
            Exit Sub
        End If

        input = originalImage
        Dim newImage As Bitmap = input.Clone()
        newImage.MakeTransparent(Color.Transparent)
        For i As Integer = 0 To newImage.Width - 1
            For j As Integer = 0 To newImage.Height - 1
                newImage.SetPixel(i, j, Color.Transparent)
            Next j
        Next i

        Dim center As New Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2)
        Dim scanWidth As Integer = Math.Abs(rect.Width * Math.Cos(angle * Math.PI / 180) + rect.Height * Math.Sin(angle * Math.PI / 180))
        Dim scanHeight As Integer = Math.Abs(rect.Height * Math.Cos(angle * Math.PI / 180) + rect.Width * Math.Sin(angle * Math.PI / 180))
        If (90 < angle And angle < 180) Or angle > 270 Or angle < 0 Then
            Dim anglep As Integer
            If 90 < angle And angle < 180 Then
                anglep = angle - 90
            ElseIf angle > 270 Then
                anglep = angle - 270
            Else
                anglep *= -1
            End If
            scanHeight = Math.Abs(rect.Width * Math.Cos(anglep * Math.PI / 180) + rect.Height * Math.Sin(anglep * Math.PI / 180))
            scanWidth = Math.Abs(rect.Height * Math.Cos(anglep * Math.PI / 180) + rect.Width * Math.Sin(anglep * Math.PI / 180))
        End If

        'Working backwards
        For x As Integer = center.X - scanWidth / 2 To Math.Floor(center.X + scanWidth / 2)
            For y As Integer = center.Y - scanHeight / 2 To Math.Floor(center.Y + scanHeight / 2)
                If x < 0 Or y < 0 Then
                    Continue For
                End If
                Dim distX As Integer = x - center.X
                Dim distY As Integer = y - center.Y
                Dim source As New Point(Math.Cos(angle * Math.PI / 180) * distX + Math.Sin(angle * Math.PI / 180) * distY, _
                                        -Math.Sin(angle * Math.PI / 180) * distX + Math.Cos(angle * Math.PI / 180) * distY)
                source.X += center.X
                source.Y += center.Y

                If x < input.Width And y < input.Height Then
                    If (rect.Left <= source.X And source.X <= rect.Right) And (rect.Top <= source.Y And source.Y <= rect.Bottom) Then
                        newImage.SetPixel(x, y, input.GetPixel(source.X, source.Y))
                        'Interpolation(newImage, x, y)
                    End If
                End If
            Next y
        Next x

        If Not iObject(currentIndex).rotatedLayer Is Nothing Then
            rotatedLayer = iObject(currentIndex).rotatedLayer
            Dim prevImage As Bitmap = rotatedLayer
            For i As Integer = 0 To input.Width - 1
                For j As Integer = 0 To input.Height - 1
                    Dim prevImageColor As Color = prevImage.GetPixel(i, j)
                    If prevImageColor.Name <> "ffffff" Then
                        input.SetPixel(i, j, Color.Black)
                    End If
                Next j
            Next i
        Else
            For i As Integer = rect.Left To rect.Right
                For j As Integer = rect.Top To rect.Bottom
                    input.SetPixel(i, j, Color.Black)
                Next j
            Next i
        End If

        For i As Integer = 0 To input.Width - 1
            For j As Integer = 0 To input.Height - 1
                Dim newImageColor As Color = newImage.GetPixel(i, j)
                If newImageColor.Name <> "ffffff" Then
                    input.SetPixel(i, j, newImage.GetPixel(i, j))
                End If
            Next j
        Next i

        rotatedLayer = newImage.Clone()
        output = input.Clone()
        iObject(currentIndex).rotatedImage = output.Clone()
    End Sub

    Public Sub Ripple(ByRef input As Bitmap, ByRef output As Bitmap, ByVal rect As Rectangle, _
                      ByVal magnitude As Integer, ByVal frequency As Integer)
        Dim center As New Point(rect.X + rect.Width / 2, rect.Y + rect.Height / 2)
        Dim totalRadius As Double = Math.Sqrt(rect.Width ^ 2 + rect.Height ^ 2) / 4

        For x As Integer = rect.Left To rect.Right
            For y As Integer = rect.Top To rect.Bottom
                Dim radiusX As Double = x - center.X
                Dim radiusY As Double = y - center.Y
                Dim newradius As Double = Math.Sqrt(radiusX ^ 2 + radiusY ^ 2)
                newradius += magnitude * Math.Sin(2 * Math.PI * frequency * (newradius / totalRadius))

                Dim angle As Double = Math.Atan2(radiusY, radiusX)

                Dim newRadiusX As Integer = newradius * Math.Cos(angle) + center.X
                Dim newRadiusY As Integer = newradius * Math.Sin(angle) + center.Y

                If (rect.Left <= newRadiusX And newRadiusX <= rect.Right) And (rect.Top <= newRadiusY And newRadiusY <= rect.Bottom) Then
                    output.SetPixel(x, y, input.GetPixel(newRadiusX, newRadiusY))
                End If
            Next y
        Next x
    End Sub

    Public Sub bgRemoval(ByRef output As Bitmap, ByRef iObject() As frmMain.imageObject, _
                         ByVal currentIndex As Integer, ByVal rect As Rectangle, _
                         ByRef pixel As frmBgRemoval.PixCell, ByVal threshold As Double, ByVal direction As Integer)
        Dim currentImage As Bitmap = iObject(currentIndex).originalImage.Clone()
        Dim queueCells As New Queue()
        Dim pixelFilled(rect.Width, rect.Height) As Boolean

        queueCells.Enqueue(pixel)
        While queueCells.Count > 0
            pixel = queueCells.Dequeue()
            If rect.Left <= pixel.x And pixel.x <= rect.Right Then
                If rect.Top <= pixel.y And pixel.y <= rect.Bottom Then
                    Dim r1, r2, g1, g2, b1, b2 As Integer
                    Dim newColor As Color = currentImage.GetPixel(pixel.x, pixel.y)
                    r1 = pixel.color.R
                    r2 = newColor.R
                    g1 = pixel.color.G
                    g2 = newColor.G
                    b1 = pixel.color.B
                    b2 = newColor.B

                    Dim similarity1 As Double = Math.Abs((r2 - r1 + g2 - g1 + b2 - b1) / 765)
                    Dim similarity As Double = Math.Abs(((r2 - r1) ^ 2 + (g2 - g1) ^ 2 + (b2 - b1) ^ 2) / 255 ^ 2)

                    If similarity < threshold And pixelFilled(pixel.x, pixel.y) = False Then
                        currentImage.SetPixel(pixel.x, pixel.y, Color.White)
                        pixelFilled(pixel.x, pixel.y) = True

                        queueCells.Enqueue(New frmBgRemoval.PixCell(pixel.x - 1, pixel.y, newColor))
                        queueCells.Enqueue(New frmBgRemoval.PixCell(pixel.x + 1, pixel.y, newColor))
                        queueCells.Enqueue(New frmBgRemoval.PixCell(pixel.x, pixel.y - 1, newColor))
                        queueCells.Enqueue(New frmBgRemoval.PixCell(pixel.x, pixel.y + 1, newColor))
                        If direction = 1 Then
                            queueCells.Enqueue(New frmBgRemoval.PixCell(pixel.x - 1, pixel.y - 1, newColor))
                            queueCells.Enqueue(New frmBgRemoval.PixCell(pixel.x + 1, pixel.y - 1, newColor))
                            queueCells.Enqueue(New frmBgRemoval.PixCell(pixel.x - 1, pixel.y + 1, newColor))
                            queueCells.Enqueue(New frmBgRemoval.PixCell(pixel.x + 1, pixel.y + 1, newColor))
                        End If
                    End If
                End If
            End If
        End While

        iObject(currentIndex).Reset(currentImage)
        output = currentImage.Clone()
    End Sub

    Public Sub RGB2HSV(ByVal red As Integer, ByVal green As Integer, ByVal blue As Integer, ByRef h As Double, ByRef s As Double, ByRef v As Double)
        Dim max, min As Double
        Dim r As Double, g As Double, b As Double

        r = red / 255.0
        g = green / 255.0
        b = blue / 255.0
        'Convert RGB to [0,1]

        'Then get the max and min of r,g,b
        max = r
        If max < g Then max = g
        If max < b Then max = b
        min = r
        If min > g Then min = g
        If min > b Then min = b

        v = max 'this is value v

        'next calculate saturation, s 
        If max = 0 Then
            s = 0
        Else
            s = (max - min) / max
        End If

        ' The last step is hue, h
        If s = 0 Then
            h = -1
        Else
            If r = max Then
                h = (g - b) / (max - min)
            ElseIf g = max Then
                h = 2 + (b - r) / (max - min)
            ElseIf b = max Then
                h = 4 + (r - g) / (max - min)
            End If

            h = h * 60
            If h < 0 Then
                h = h + 360
            End If
        End If
    End Sub

    Private Sub HSV2RGB(ByVal h As Double, ByVal s As Double, ByVal v As Double, ByRef red As Integer, ByRef green As Integer, ByRef blue As Integer)
        Dim r As Double, g As Double, b As Double
        Dim i As Double, f As Double, p As Double, q As Double, t As Double

        If s = 0 Then
            r = v
            g = v
            b = v
        Else
            If h = 360 Then
                h = 0
            End If
            h = h / 60
            i = Int(h)

            f = h - i
            p = v * (1 - s)
            q = v * (1 - (s * f))
            t = v * (1 - (s * (1 - f)))

            Select Case i
                Case 0
                    r = v
                    g = t
                    b = p
                Case 1
                    r = q
                    g = v
                    b = p
                Case 2
                    r = p
                    g = v
                    b = t
                Case 3
                    r = p
                    g = q
                    b = v
                Case 4
                    r = t
                    g = p
                    b = v
                Case 5
                    r = v
                    g = p
                    b = q
            End Select
        End If

        red = CInt(r * 255.0)
        green = CInt(g * 255.0)
        blue = CInt(b * 255.0)

        red = ClipByte(red)
        green = ClipByte(green)
        blue = ClipByte(blue)
    End Sub

    ' This function clips a value into the range of 0 to 255
    Public Function ClipByte(ByRef value As Integer) As Integer
        If value > 255 Then
            Return 255
        ElseIf value < 0 Then
            Return 0
        End If
        Return value
    End Function

    ' This function clips a value into the range of 0 to 1
    Private Function ClipFloat(ByRef value As Double) As Double
        If value > 1 Then
            Return 1
        ElseIf value < 0 Then
            Return 0
        End If
        Return value
    End Function

    ' This function gets a pixel from the image without going out of bounds
    Private Function GetPixel(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer) As Color
        If x < 0 Then
            x = 0
        ElseIf x > image.Width - 1 Then
            x = image.Width - 1
        End If
        If y < 0 Then
            y = 0
        ElseIf y > image.Height - 1 Then
            y = image.Height - 1
        End If
        Return image.GetPixel(x, y)
    End Function

    ' This function returns the interpolation of four pixels around an x and y position
    Private Function Interpolation(ByRef image As Bitmap, ByVal x As Double, ByVal y As Double) As Color
        Dim bx As Integer = Math.Floor(x)
        Dim by As Integer = Math.Floor(y)
        Dim a As Double, b As Double, a0 As Double, a1 As Double, a2 As Double, a3 As Double
        Dim red As Double, green As Double, blue As Double

        a = x - bx
        b = y - by

        a0 = (1 - a) * (1 - b)
        a1 = a * (1 - b)
        a2 = (1 - a) * b
        a3 = a * b

        red = GetPixel(image, bx, by).R * a0 + GetPixel(image, bx + 1, by).R * a1 + GetPixel(image, bx, by + 1).R * a2 + GetPixel(image, bx + 1, by + 1).R * a3
        green = GetPixel(image, bx, by).G * a0 + GetPixel(image, bx + 1, by).G * a1 + GetPixel(image, bx, by + 1).G * a2 + GetPixel(image, bx + 1, by + 1).G * a3
        blue = GetPixel(image, bx, by).B * a0 + GetPixel(image, bx + 1, by).B * a1 + GetPixel(image, bx, by + 1).B * a2 + GetPixel(image, bx + 1, by + 1).B * a3

        Return Color.FromArgb(red, green, blue)
    End Function

End Module

