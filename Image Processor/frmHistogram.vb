Public Class frmHistogram
    Inherits frmEffect

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents lblPlanes As System.Windows.Forms.Label
    Friend WithEvents cboPlane As System.Windows.Forms.ComboBox
    Friend WithEvents btnAutoContrast As System.Windows.Forms.Button
    Friend WithEvents picHistogram As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.picHistogram = New System.Windows.Forms.PictureBox()
        Me.lblPlanes = New System.Windows.Forms.Label()
        Me.cboPlane = New System.Windows.Forms.ComboBox()
        Me.btnAutoContrast = New System.Windows.Forms.Button()
        CType(Me.picHistogram, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(99, 255)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(128, 35)
        Me.btnShow.TabIndex = 8
        Me.btnShow.Text = "Show"
        '
        'picHistogram
        '
        Me.picHistogram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picHistogram.Location = New System.Drawing.Point(19, 62)
        Me.picHistogram.Name = "picHistogram"
        Me.picHistogram.Size = New System.Drawing.Size(432, 178)
        Me.picHistogram.TabIndex = 10
        Me.picHistogram.TabStop = False
        '
        'lblPlanes
        '
        Me.lblPlanes.AutoSize = True
        Me.lblPlanes.Location = New System.Drawing.Point(19, 21)
        Me.lblPlanes.Name = "lblPlanes"
        Me.lblPlanes.Size = New System.Drawing.Size(95, 15)
        Me.lblPlanes.TabIndex = 12
        Me.lblPlanes.Text = "Histogram of:"
        '
        'cboPlane
        '
        Me.cboPlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlane.FormattingEnabled = True
        Me.cboPlane.Items.AddRange(New Object() {"Value", "Red", "Green", "Blue"})
        Me.cboPlane.Location = New System.Drawing.Point(139, 17)
        Me.cboPlane.Name = "cboPlane"
        Me.cboPlane.Size = New System.Drawing.Size(312, 23)
        Me.cboPlane.TabIndex = 11
        '
        'btnAutoContrast
        '
        Me.btnAutoContrast.Location = New System.Drawing.Point(233, 255)
        Me.btnAutoContrast.Name = "btnAutoContrast"
        Me.btnAutoContrast.Size = New System.Drawing.Size(128, 35)
        Me.btnAutoContrast.TabIndex = 13
        Me.btnAutoContrast.Text = "Auto Contrast"
        '
        'frmHistogram
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 18)
        Me.ClientSize = New System.Drawing.Size(510, 302)
        Me.Controls.Add(Me.btnAutoContrast)
        Me.Controls.Add(Me.lblPlanes)
        Me.Controls.Add(Me.cboPlane)
        Me.Controls.Add(Me.picHistogram)
        Me.Controls.Add(Me.btnShow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHistogram"
        Me.Text = "Histogram"
        CType(Me.picHistogram, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Histogram(0 To 255) As Integer
    Private sort(0 To 255) As Point
    Dim max As Integer = 0
    Dim min As Integer = 0
    Dim median As Integer = 0

    Private Sub frmHistogram_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cboPlane.SelectedIndex = 0
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        ' Clear the histogram using Array.Clear here
        Array.Clear(Histogram, 0, 256)
        ApplyEffect()
        picHistogram.Refresh()
    End Sub

    Overrides Function Process(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer) As Color
        Dim color As Color = image.GetPixel(x, y)

        ' Count the histogram using the selected colour plane here
        ' Note: there are 256 boxes in the histogram
        Dim red As Integer = color.R
        Dim green As Integer = color.G
        Dim blue As Integer = color.B

        If cboPlane.SelectedIndex = 0 Then
            ' Convert the colour to a grayscale value here
            Dim value As Integer = (red + green + blue) / 3
            Histogram(value) += 1
        ElseIf cboPlane.SelectedIndex = 1 Then
            Histogram(red) += 1
        ElseIf cboPlane.SelectedIndex = 2 Then
            Histogram(green) += 1
        Else
            Histogram(blue) += 2
        End If

        Return color
    End Function

    Private Sub picHistogram_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picHistogram.Paint
        Dim g As Graphics = e.Graphics()
        g.Clear(Color.White)

        Dim i As Integer
        For i = 0 To 255
            If Histogram(i) > max Then
                max = Histogram(i)
            End If
            If Histogram(i) < MinimizeBox Then
                min = Histogram(i)
            End If
        Next

        If max > 0 Then
            Dim x As Integer, y As Integer
            For x = 0 To picHistogram.ClientRectangle.Width - 1
                y = (1.0# - Histogram(x / (picHistogram.ClientRectangle.Width - 1) * 255) / max) * (picHistogram.ClientRectangle.Height - 1)
                g.DrawLine(Pens.Black, x, picHistogram.ClientRectangle.Height - 1, x, y)
            Next
        End If
    End Sub

    Private Sub btnAutoContrast_Click(sender As Object, e As EventArgs) Handles btnAutoContrast.Click
        sortHistogram()

        Dim selectedImageForm As frmImage = DirectCast(Me.MdiParent, frmMain).selectedImageForm

        If selectedImageForm.selectedArea.IsEmpty() Then
            MsgBox("Please select an area for application of the selected filter")
            Return
        End If

        Dim buffer As Bitmap = selectedImageForm.image.Clone()
        selectedImageForm.RemoveDashRect()
        Expansion(buffer)

        selectedImageForm.SetPicture(buffer.Clone())
        frmMain.iObject(frmMain.currentImageIndex).Reset(buffer.Clone())
        selectedImageForm.DrawDashRect()

        btnShow.PerformClick()
    End Sub

    Private Sub Expansion(ByRef image As Bitmap)
        Dim red, green, blue As Integer
        Dim maxred, maxgreen, maxblue As Integer
        Dim minred As Integer = 255
        Dim mingreen As Integer = 255
        Dim minblue As Integer = 255
        For x As Integer = 0 To image.Width - 1
            For y As Integer = 0 To image.Height - 1
                red = image.GetPixel(x, y).R
                green = image.GetPixel(x, y).G
                blue = image.GetPixel(x, y).B
                If red > maxred Then maxred = red
                If red < minred Then minred = red
                If green > maxgreen Then maxgreen = green
                If green < mingreen Then mingreen = green
                If blue > maxblue Then maxblue = blue
                If blue < minblue Then minblue = blue
            Next y
        Next x

        Dim ExpansionR As Double = 255.0 / (maxred - minred)
        Dim ExpansionG As Double = 255.0 / (maxgreen - mingreen)
        Dim ExpansionB As Double = 255.0 / (maxblue - minblue)

        For x As Integer = 0 To image.Width - 1
            For y As Integer = 0 To image.Height - 1
                red = image.GetPixel(x, y).R
                red = Math.Floor(CDbl(red - minred) * ExpansionR)
                red = modImage.ClipByte(red)
                green = image.GetPixel(x, y).G
                green = Math.Floor(CDbl(green - mingreen) * ExpansionG)
                green = modImage.ClipByte(green)
                blue = image.GetPixel(x, y).B
                blue = Math.Floor(CDbl(blue - minblue) * ExpansionB)
                blue = modImage.ClipByte(blue)
                image.SetPixel(x, y, Color.FromArgb(red, green, blue))
            Next y
        Next x
    End Sub

    Private Sub swapPoint(ByRef point1 As Point, ByRef point2 As Point)
        Dim temp As Point = point1
        point1 = point2
        point2 = temp
    End Sub

    Private Sub sortHistogram()
        For i As Integer = 0 To 255
            sort(i).X = Histogram(i)
            sort(i).Y = i
        Next i

        For outer As Integer = sort.Length - 1 To 0 Step -1
            For inner As Integer = 0 To outer - 1 Step 1
                If sort(inner).X > sort(inner + 1).X Then
                    swapPoint(sort(inner), sort(inner + 1))
                End If
            Next inner
        Next outer
        min = sort(0).X
        max = sort(255).X
        median = sort(255 / 2).X
    End Sub
End Class
