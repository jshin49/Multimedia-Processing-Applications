Public Class frmRipple
    Inherits frmSpatialEffect

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
    Friend WithEvents lblFrequency As System.Windows.Forms.Label
    Friend WithEvents tbFrequency As System.Windows.Forms.TrackBar
    Friend WithEvents lblMagnitude As System.Windows.Forms.Label
    Friend WithEvents tbMagnitude As System.Windows.Forms.TrackBar

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnApply As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.lblFrequency = New System.Windows.Forms.Label()
        Me.tbFrequency = New System.Windows.Forms.TrackBar()
        Me.lblMagnitude = New System.Windows.Forms.Label()
        Me.tbMagnitude = New System.Windows.Forms.TrackBar()
        CType(Me.tbFrequency, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMagnitude, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(163, 140)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(128, 33)
        Me.btnApply.TabIndex = 8
        Me.btnApply.Text = "Apply"
        '
        'lblFrequency
        '
        Me.lblFrequency.AutoSize = True
        Me.lblFrequency.Location = New System.Drawing.Point(31, 83)
        Me.lblFrequency.Name = "lblFrequency"
        Me.lblFrequency.Size = New System.Drawing.Size(80, 15)
        Me.lblFrequency.TabIndex = 12
        Me.lblFrequency.Text = "Frequency:"
        '
        'tbFrequency
        '
        Me.tbFrequency.Location = New System.Drawing.Point(130, 78)
        Me.tbFrequency.Minimum = 1
        Me.tbFrequency.Name = "tbFrequency"
        Me.tbFrequency.Size = New System.Drawing.Size(295, 56)
        Me.tbFrequency.TabIndex = 11
        Me.tbFrequency.Value = 3
        '
        'lblMagnitude
        '
        Me.lblMagnitude.AutoSize = True
        Me.lblMagnitude.Location = New System.Drawing.Point(31, 24)
        Me.lblMagnitude.Name = "lblMagnitude"
        Me.lblMagnitude.Size = New System.Drawing.Size(79, 15)
        Me.lblMagnitude.TabIndex = 10
        Me.lblMagnitude.Text = "Magnitude:"
        '
        'tbMagnitude
        '
        Me.tbMagnitude.Location = New System.Drawing.Point(130, 20)
        Me.tbMagnitude.Maximum = 15
        Me.tbMagnitude.Minimum = 1
        Me.tbMagnitude.Name = "tbMagnitude"
        Me.tbMagnitude.Size = New System.Drawing.Size(295, 56)
        Me.tbMagnitude.TabIndex = 9
        Me.tbMagnitude.Value = 7
        '
        'frmRipple
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 18)
        Me.ClientSize = New System.Drawing.Size(461, 185)
        Me.Controls.Add(Me.lblFrequency)
        Me.Controls.Add(Me.tbFrequency)
        Me.Controls.Add(Me.lblMagnitude)
        Me.Controls.Add(Me.tbMagnitude)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRipple"
        Me.Text = "Ripple"
        CType(Me.tbFrequency, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMagnitude, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        ApplyEffect()
    End Sub

    Overrides Sub Process(ByRef input As Bitmap, ByRef output As Bitmap, ByVal rect As Rectangle)
        Ripple(input, output, rect, tbMagnitude.Value, tbFrequency.Value)
        frmMain.iObject(frmMain.currentImageIndex).Reset(output)
    End Sub
End Class
