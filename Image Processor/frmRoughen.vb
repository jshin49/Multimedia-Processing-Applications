Public Class frmRoughen
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
    Friend WithEvents gbxRoughen As System.Windows.Forms.GroupBox
    Friend WithEvents lblWeak As System.Windows.Forms.Label
    Friend WithEvents lblMedium As System.Windows.Forms.Label
    Friend WithEvents lblStrong As System.Windows.Forms.Label
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents cbHue As System.Windows.Forms.CheckBox
    Friend WithEvents cbValue As System.Windows.Forms.CheckBox
    Friend WithEvents cbSaturation As System.Windows.Forms.CheckBox
    Friend WithEvents tbRoughen As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbxRoughen = New System.Windows.Forms.GroupBox()
        Me.lblWeak = New System.Windows.Forms.Label()
        Me.lblMedium = New System.Windows.Forms.Label()
        Me.lblStrong = New System.Windows.Forms.Label()
        Me.tbRoughen = New System.Windows.Forms.TrackBar()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.cbHue = New System.Windows.Forms.CheckBox()
        Me.cbValue = New System.Windows.Forms.CheckBox()
        Me.cbSaturation = New System.Windows.Forms.CheckBox()
        Me.gbxRoughen.SuspendLayout()
        CType(Me.tbRoughen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxRoughen
        '
        Me.gbxRoughen.Controls.Add(Me.lblWeak)
        Me.gbxRoughen.Controls.Add(Me.lblMedium)
        Me.gbxRoughen.Controls.Add(Me.lblStrong)
        Me.gbxRoughen.Controls.Add(Me.tbRoughen)
        Me.gbxRoughen.Location = New System.Drawing.Point(19, 85)
        Me.gbxRoughen.Name = "gbxRoughen"
        Me.gbxRoughen.Size = New System.Drawing.Size(432, 108)
        Me.gbxRoughen.TabIndex = 9
        Me.gbxRoughen.TabStop = False
        Me.gbxRoughen.Text = "Strength of Roughen"
        '
        'lblWeak
        '
        Me.lblWeak.AutoSize = True
        Me.lblWeak.Location = New System.Drawing.Point(11, 69)
        Me.lblWeak.Name = "lblWeak"
        Me.lblWeak.Size = New System.Drawing.Size(44, 15)
        Me.lblWeak.TabIndex = 3
        Me.lblWeak.Text = "Weak"
        '
        'lblMedium
        '
        Me.lblMedium.AutoSize = True
        Me.lblMedium.Location = New System.Drawing.Point(146, 69)
        Me.lblMedium.Name = "lblMedium"
        Me.lblMedium.Size = New System.Drawing.Size(57, 15)
        Me.lblMedium.TabIndex = 4
        Me.lblMedium.Text = "Medium"
        '
        'lblStrong
        '
        Me.lblStrong.AutoSize = True
        Me.lblStrong.Location = New System.Drawing.Point(360, 69)
        Me.lblStrong.Name = "lblStrong"
        Me.lblStrong.Size = New System.Drawing.Size(50, 15)
        Me.lblStrong.TabIndex = 5
        Me.lblStrong.Text = "Strong"
        '
        'tbRoughen
        '
        Me.tbRoughen.LargeChange = 10
        Me.tbRoughen.Location = New System.Drawing.Point(19, 26)
        Me.tbRoughen.Maximum = 50
        Me.tbRoughen.Name = "tbRoughen"
        Me.tbRoughen.Size = New System.Drawing.Size(394, 56)
        Me.tbRoughen.TabIndex = 0
        Me.tbRoughen.TickFrequency = 10
        Me.tbRoughen.Value = 10
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(171, 209)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(128, 33)
        Me.btnApply.TabIndex = 8
        Me.btnApply.Text = "Apply"
        '
        'cbHue
        '
        Me.cbHue.AutoSize = True
        Me.cbHue.Location = New System.Drawing.Point(33, 34)
        Me.cbHue.Name = "cbHue"
        Me.cbHue.Size = New System.Drawing.Size(55, 19)
        Me.cbHue.TabIndex = 13
        Me.cbHue.Text = "Hue"
        Me.cbHue.UseVisualStyleBackColor = True
        '
        'cbValue
        '
        Me.cbValue.AutoSize = True
        Me.cbValue.Checked = True
        Me.cbValue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbValue.Location = New System.Drawing.Point(374, 34)
        Me.cbValue.Name = "cbValue"
        Me.cbValue.Size = New System.Drawing.Size(64, 19)
        Me.cbValue.TabIndex = 14
        Me.cbValue.Text = "Value"
        Me.cbValue.UseVisualStyleBackColor = True
        '
        'cbSaturation
        '
        Me.cbSaturation.AutoSize = True
        Me.cbSaturation.Location = New System.Drawing.Point(208, 34)
        Me.cbSaturation.Name = "cbSaturation"
        Me.cbSaturation.Size = New System.Drawing.Size(95, 19)
        Me.cbSaturation.TabIndex = 15
        Me.cbSaturation.Text = "Saturation"
        Me.cbSaturation.UseVisualStyleBackColor = True
        '
        'frmRoughen
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 18)
        Me.ClientSize = New System.Drawing.Size(471, 259)
        Me.Controls.Add(Me.cbSaturation)
        Me.Controls.Add(Me.cbValue)
        Me.Controls.Add(Me.cbHue)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.gbxRoughen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRoughen"
        Me.Text = "Roughen"
        Me.gbxRoughen.ResumeLayout(False)
        Me.gbxRoughen.PerformLayout()
        CType(Me.tbRoughen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        ApplyEffect()
    End Sub

    Overrides Function Process(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer) As Color
        Return Roughen(image.GetPixel(x, y), tbRoughen.Value / 100.0#, cbHue.Checked, cbSaturation.Checked, cbValue.Checked)
    End Function
End Class
