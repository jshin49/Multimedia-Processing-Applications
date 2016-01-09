Public Class frmBgRemoval
    Inherits MDIForm.frmSpatialEffect

    Private x As Double
    Private y As Double

    Public Class PixCell
        Public x As Integer
        Public y As Integer
        Public color As Color

        Public Sub New(ByVal x As Integer, ByVal y As Integer, ByVal color As Color)
            Me.x = x
            Me.y = y
            Me.color = color
        End Sub
    End Class

    Public Sub frmBgRemoval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbFloodFill.SelectedIndex = 0
        Dim pbImage As Bitmap = frmMain.iObject(frmMain.currentImageIndex).originalImage.Clone()
        If Not DirectCast(Me.MdiParent, frmMain).selectedImageForm Is Nothing Then
            Dim selectedImageForm As frmImage = DirectCast(Me.MdiParent, frmMain).selectedImageForm

            If selectedImageForm.selectedArea.IsEmpty() Then
                MsgBox("Please select an area for application of the selected filter")
                Return
            End If

            Dim rect As Rectangle = selectedImageForm.selectedArea
            For i As Integer = 0 To pbImage.Width - 1
                For j As Integer = 0 To pbImage.Height - 1
                    If (rect.Left <= i And i <= rect.Right) And (rect.Top <= j And j <= rect.Bottom) Then
                        Continue For
                    Else
                        pbImage.SetPixel(i, j, Color.White)
                    End If
                Next j
            Next i
            pbStart.BackgroundImage = pbImage.Clone()
        Else
            MsgBox("Please open an image first")
        End If
    End Sub

    Overrides Sub Process(ByRef input As Bitmap, ByRef output As Bitmap, ByVal rect As Rectangle)
        bgRemoval(output, frmMain.iObject, frmMain.currentImageIndex, rect, New PixCell(x, y, input.GetPixel(x, y)), slrSimlarity.Value / 100.0, cbFloodFill.SelectedIndex)
    End Sub

    Private Sub pbStart_MouseClick(sender As Object, e As MouseEventArgs) Handles pbStart.MouseClick
        If Not e.Button = MouseButtons.Left Or e.X < 0 Or e.X >= pbStart.Width Or e.Y < 0 Or e.Y >= pbStart.Height Then
            Exit Sub
        End If
        x = e.X / (pbStart.Width - 1)
        y = e.Y / (pbStart.Height - 1)
        ApplyEffect()
        'bgRemoval(frmMain.iObject, frmMain.currentImageIndex, selectArea, x, y, slrSimlarity.Value / 10.0, cbFloodFill.SelectedIndex)
    End Sub
End Class
