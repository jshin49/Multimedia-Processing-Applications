Module modEffect

    Private Function Abs(ByVal value As Integer) As Integer
        Return IIf(value < 0, value * -1, value)
    End Function

    Public Function IsKeyframe(ByRef input1 As Bitmap, ByRef input2 As Bitmap, _
                               ByVal threshold As Double, ByVal similarity As Double) As Boolean

        ' input1 and input2 are successive frames in the video
        ' threshold is the percentage of colour difference between two pixels in order to consider that they are different
        ' similarity is the percentage of same/similar pixels in the frame so that the two frames are considered similar

        ' *** Add your code here
        ' Remember you only have to compare the central area of the frames
        Dim totalPixelsAssessed As Integer = 0 'total pixels in the central area
        Dim differentPixels As Integer = 0 ' num of pixels considered to be different
        For x As Integer = input1.Width / 4 To input1.Width * 3 / 4
            For y As Integer = input1.Height / 4 To input1.Height * 3 / 4
                Dim pixel1 As Color = input1.GetPixel(x, y)
                Dim pixel2 As Color = input2.GetPixel(x, y)
                Dim r1 As Integer = pixel1.R
                Dim r2 As Integer = pixel2.R
                Dim g1 As Integer = pixel1.G
                Dim g2 As Integer = pixel2.G
                Dim b1 As Integer = pixel1.B
                Dim b2 As Integer = pixel2.B

                Dim colorDiff As Double = (Abs(r2 - r1) + Abs(g2 - g1) + Abs(b2 - b1)) / 765
                If colorDiff >= threshold Then
                    differentPixels += 1
                End If
                totalPixelsAssessed += 1
            Next y
        Next x

        Dim difference As Double = differentPixels / totalPixelsAssessed
        If difference >= similarity Then
            Return True
        End If

        Return False
    End Function

    Public Function FadeIn(ByRef input As Bitmap, ByVal startRate As Double, ByVal currentIndex As Integer, _
                           ByVal startFrame As Integer, ByVal endFrame As Integer) As Bitmap

        Dim output As New Bitmap(input.Width, input.Height, Imaging.PixelFormat.Format24bppRgb)

        ' *** Add your code here
        Dim ratio As Double = (currentIndex - startFrame) / (endFrame - startFrame)
        Dim multiplier As Double = ratio
        For x As Integer = 0 To input.Width - 1
            For y As Integer = 0 To input.Height - 1
                Dim color As Color = input.GetPixel(x, y)
                Dim red As Integer = color.R * multiplier
                Dim green As Integer = color.G * multiplier
                Dim blue As Integer = color.B * multiplier
                output.SetPixel(x, y, color.FromArgb(red, green, blue))
            Next y
        Next x

        Return output
    End Function

    Public Function FadeOut(ByRef input As Bitmap, ByVal endRate As Double, _
                            ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer) As Bitmap

        Dim output As New Bitmap(input.Width, input.Height, Imaging.PixelFormat.Format24bppRgb)

        ' *** Add your code here
        Dim ratio As Double = (currentIndex - startFrame) / (endFrame - startFrame)
        Dim multiplier As Double = 1 - ratio
        For x As Integer = 0 To input.Width - 1
            For y As Integer = 0 To input.Height - 1
                Dim color As Color = input.GetPixel(x, y)
                Dim red As Integer = color.R * multiplier
                Dim green As Integer = color.G * multiplier
                Dim blue As Integer = color.B * multiplier
                output.SetPixel(x, y, color.FromArgb(red, green, blue))
            Next y
        Next x

        Return output
    End Function

    Public Function MotionBlur(ByRef input As Bitmap, ByVal blurCount As Integer, _
                               ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer, ByVal newOp As Boolean, _
                               ByVal dirname As String) As Bitmap
        Dim output As New Bitmap(input.Width, input.Height, Imaging.PixelFormat.Format24bppRgb)

        Static Dim bufferR(input.Width - 1, input.Height - 1) As Integer
        Static Dim bufferG(input.Width - 1, input.Height - 1) As Integer
        Static Dim bufferB(input.Width - 1, input.Height - 1) As Integer


        ' *** Add your code here

        ' You need to initialize the buffers at the start of the operation


        Return output
    End Function

    Public Sub sineMelt(ByVal usesine As Boolean, ByRef input As Bitmap, _
                        ByRef displacement() As Integer, ByVal amplitude As Integer, ByVal cycle As Integer)
        If Not usesine Then
            Exit Sub
        End If

        For i As Integer = 0 To input.Width - 1
            displacement(i) = Math.Abs(amplitude * Math.Sin(2 * Math.PI * cycle * (i / input.Width - 1)))
        Next i
    End Sub

    Public Sub randomMelt(ByVal useRandom As Boolean, ByVal usesine As Boolean, ByRef input As Bitmap, _
                          ByRef displacement() As Integer, ByVal offset As Integer, ByVal period As Integer)

        If Not useRandom Then
            Exit Sub
        End If

        'Reset values
        Dim x As Integer = 0
        Dim currentOffset As Integer = 0

        'A loop to go through each column from left to right
        Do While x < input.Width - 1
            Randomize()

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
                If i >= input.Width Then Exit For
                'For each column i, create the random offset
                Randomize()
                currentOffset += sign * Rnd() * offset

                If currentOffset < 0 Then
                    currentOffset *= -1
                    sign *= -1
                End If

                If usesine Then
                    displacement(i) += currentOffset
                Else
                    displacement(i) = currentOffset
                End If
            Next i
            x += currentPeriod
        Loop

    End Sub

    Public Function Melt(ByRef input As Bitmap, _
                         ByVal useSine As Boolean, ByVal amplitude As Integer, ByVal cycle As Integer, _
                         ByVal useRandom As Boolean, ByVal offset As Integer, ByVal period As Integer, _
                         ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer, ByVal newOp As Boolean) As Bitmap

        Dim output As New Bitmap(input.Width, input.Height, Imaging.PixelFormat.Format24bppRgb)
        Static Dim displacement(0 To input.Width - 1) As Integer
        Static Dim initial As Boolean = False

        ' *** Add your code here
        ' Apply melt to the selected area here
        If Not initial Then
            sineMelt(useSine, input, displacement, amplitude, cycle)
            randomMelt(useRandom, useSine, input, displacement, offset, period)
            initial = True
        End If

        Dim ratio As Double = (currentIndex - startFrame) / (endFrame - startFrame)

        For x As Integer = 0 To input.Width - 1
            For y As Integer = 0 To input.Height - 1
                Dim newY As Integer = y - (displacement(x) * ratio)
                output.SetPixel(x, y, GetPixel(input, x, newY))
            Next y
        Next x

        Return output
    End Function

    Private Sub wipeTransition(ByRef input1 As Bitmap, ByRef input2 As Bitmap, ByRef output As Bitmap, _
                               ByVal type As Integer, ByVal ratio As Double, _
                               ByVal startFrame As Integer, ByVal endFrame As Integer)

        For x As Integer = 0 To input1.Width - 1
            For y As Integer = 0 To input1.Height - 1
                Select Case type
                    Case 0  ' From Top
                        If y / input1.Height < ratio Then
                            output.SetPixel(x, y, GetPixel(input2, x * input2.Width / input1.Width, y * input2.Height / input1.Height))
                        Else
                            output.SetPixel(x, y, GetPixel(input1, x, y))
                        End If
                    Case 1  ' From Bottom
                        If (input1.Height - 1 - y) / input1.Height < ratio Then
                            output.SetPixel(x, y, GetPixel(input2, x * input2.Width / input1.Width, y * input2.Height / input1.Height))
                        Else
                            output.SetPixel(x, y, GetPixel(input1, x, y))
                        End If
                    Case 2  ' From Right
                        If (input1.Width - 1 - x) / input1.Width < ratio Then
                            output.SetPixel(x, y, GetPixel(input2, x * input2.Width / input1.Width, y * input2.Height / input1.Height))
                        Else
                            output.SetPixel(x, y, GetPixel(input1, x, y))
                        End If
                    Case 3  ' From Left
                        If x / input1.Width < ratio Then
                            output.SetPixel(x, y, GetPixel(input2, x * input2.Width / input1.Width, y * input2.Height / input1.Height))
                        Else
                            output.SetPixel(x, y, GetPixel(input1, x, y))
                        End If
                End Select
            Next y
        Next x
    End Sub

    Private Sub lineTransition(ByRef input1 As Bitmap, ByRef input2 As Bitmap, ByRef output As Bitmap, _
                               ByVal ratio As Integer, ByRef lineFilled() As Boolean, ByVal isFull As Boolean, _
                               ByVal startFrame As Integer, ByVal endFrame As Integer)
        If Not isFull Then
            For i As Integer = 0 To ratio
                Randomize()
                Dim randomY As Integer = Rnd() * (input1.Height - 1)
                If Not lineFilled(randomY) Then
                    lineFilled(randomY) = True
                Else
                    i -= 1
                    Continue For
                End If
            Next i

            For x As Integer = 0 To input1.Width - 1
                For y As Integer = 0 To input1.Height - 1
                    If lineFilled(y) Then
                        output.SetPixel(x, y, GetPixel(input2, x * input2.Width / input1.Width, y * input2.Height / input1.Height))
                    Else
                        output.SetPixel(x, y, GetPixel(input1, x, y))
                    End If
                Next y
            Next x
        Else
            output = input2.Clone()
        End If

    End Sub

    Public Function Transition(ByRef input1 As Bitmap, ByRef input2 As Bitmap, ByVal type As Integer, ByVal wipe As Integer, ByVal duration As Double, _
                               ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer, ByVal newOp As Boolean) As Bitmap

        Dim output As New Bitmap(input1.Width, input1.Height, Imaging.PixelFormat.Format24bppRgb)
        Static Dim lineFilled(0 To input1.Height - 1) As Boolean ' store used y positions for line transition
        ' The parameter duration is the time spanned by the transition effect
        ' at the middle of the selected video segment
        '
        ' For example,
        ' if startFrame = 20, endFrame = 80 and duration = 0.5,
        ' the transition lasts for (80 - 20) * 0.5 = 30 frames and
        ' the transition starts at frame (80 - 20 - 30) / 2 + 20 = 35
        '
        ' Similarly,
        ' if startFrame = 60, endFrame = 100 and duration = 0.25,
        ' the transition lasts for (100 - 60) * 0.25 = 10 frames and
        ' the transition starts at frame (100 - 60 - 10) / 2 + 60 = 75

        ' *** Add your code here
        Dim length As Integer = (endFrame - startFrame) * duration
        startFrame = (endFrame - startFrame - length) / 2 + startFrame
        endFrame = startFrame + length
        If currentIndex < startFrame Then Return input1 ' Added Line
        Dim ratio As Double = (currentIndex - startFrame) / (endFrame - startFrame)

        'If currentIndex >= endFrame Then
        '    For x As Integer = 0 To output.Width - 1x
        '        For y As Integer = 0 To output.Height - 1
        '            output.SetPixel(x, y, modEffect.GetPixel(input2, x * input2.Width / input1.Width, y * input2.Height / input1.Height))
        '        Next y
        '    Next x
        '    Return output
        'End If

        Select Case type
            Case 0
                wipeTransition(input1, input2, output, wipe, ratio, startFrame, endFrame)
            Case 1
                Dim isFull As Boolean = True
                For i As Integer = 0 To input1.Height - 1
                    If Not lineFilled(i) Then
                        isFull = False
                        Exit For
                    End If
                Next i
                lineTransition(input1, input2, output, Math.Floor((input1.Height - 1) / length), lineFilled, isFull, startFrame, endFrame)
        End Select
        Return output
    End Function

    Public Function TimeShift(ByRef input1 As Bitmap, ByRef input2 As Bitmap, ByVal cutOffPos As Double, _
                               ByVal currentIndex As Integer, ByVal startFrame As Integer, ByVal endFrame As Integer, ByVal newOp As Boolean) As Bitmap
        Dim output As New Bitmap(input1.Width, input1.Height, Imaging.PixelFormat.Format24bppRgb)

        Return output
    End Function

    ' Get the pixel from the bitmap with the boundary pixels correctly handled
    Public Function GetPixel(ByRef bitmap As Bitmap, ByVal x As Short, ByVal y As Short) As Color
        If x < 0 Then
            x = 0
        ElseIf x > bitmap.Width - 1 Then
            x = bitmap.Width - 1
        End If

        If y < 0 Then
            y = 0
        ElseIf y > bitmap.Height - 1 Then
            y = bitmap.Height - 1
        End If

        GetPixel = bitmap.GetPixel(x, y)
    End Function

    ' Clipping function
    Private Function Clip(ByVal value As Integer) As Integer
        If value > 255 Then
            Return 255
        ElseIf value < 0 Then
            Return 0
        End If
        Return value
    End Function

End Module
