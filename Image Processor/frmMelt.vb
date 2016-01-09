Public Class frmMelt
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents gbxSine As System.Windows.Forms.GroupBox
    Friend WithEvents tbAmplitude As System.Windows.Forms.TrackBar
    Friend WithEvents lblAmplitude As System.Windows.Forms.Label
    Friend WithEvents lblCycle As System.Windows.Forms.Label
    Friend WithEvents tbCycle As System.Windows.Forms.TrackBar
    Friend WithEvents gbxRandom As System.Windows.Forms.GroupBox
    Friend WithEvents lblPeriod As System.Windows.Forms.Label
    Friend WithEvents tbPeriod As System.Windows.Forms.TrackBar
    Friend WithEvents lblOffset As System.Windows.Forms.Label
    Friend WithEvents cbxSine As System.Windows.Forms.CheckBox
    Friend WithEvents cbxRandom As System.Windows.Forms.CheckBox
    Friend WithEvents tbMeltAngle As System.Windows.Forms.TrackBar
    Friend WithEvents gbxRoughen As System.Windows.Forms.GroupBox
    Friend WithEvents lblWeak As System.Windows.Forms.Label
    Friend WithEvents lblStrong As System.Windows.Forms.Label
    Friend WithEvents lblMeltAngle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbOffset As System.Windows.Forms.TrackBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.gbxSine = New System.Windows.Forms.GroupBox()
        Me.cbxSine = New System.Windows.Forms.CheckBox()
        Me.lblCycle = New System.Windows.Forms.Label()
        Me.tbCycle = New System.Windows.Forms.TrackBar()
        Me.lblAmplitude = New System.Windows.Forms.Label()
        Me.tbAmplitude = New System.Windows.Forms.TrackBar()
        Me.gbxRandom = New System.Windows.Forms.GroupBox()
        Me.cbxRandom = New System.Windows.Forms.CheckBox()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.tbPeriod = New System.Windows.Forms.TrackBar()
        Me.lblOffset = New System.Windows.Forms.Label()
        Me.tbOffset = New System.Windows.Forms.TrackBar()
        Me.tbMeltAngle = New System.Windows.Forms.TrackBar()
        Me.gbxRoughen = New System.Windows.Forms.GroupBox()
        Me.lblWeak = New System.Windows.Forms.Label()
        Me.lblStrong = New System.Windows.Forms.Label()
        Me.lblMeltAngle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxSine.SuspendLayout()
        CType(Me.tbCycle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbAmplitude, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRandom.SuspendLayout()
        CType(Me.tbPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbMeltAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxRoughen.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(168, 468)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(128, 33)
        Me.btnApply.TabIndex = 8
        Me.btnApply.Text = "Apply"
        '
        'gbxSine
        '
        Me.gbxSine.Controls.Add(Me.cbxSine)
        Me.gbxSine.Controls.Add(Me.lblCycle)
        Me.gbxSine.Controls.Add(Me.tbCycle)
        Me.gbxSine.Controls.Add(Me.lblAmplitude)
        Me.gbxSine.Controls.Add(Me.tbAmplitude)
        Me.gbxSine.Location = New System.Drawing.Point(19, 17)
        Me.gbxSine.Name = "gbxSine"
        Me.gbxSine.Size = New System.Drawing.Size(432, 145)
        Me.gbxSine.TabIndex = 10
        Me.gbxSine.TabStop = False
        '
        'cbxSine
        '
        Me.cbxSine.AutoSize = True
        Me.cbxSine.Location = New System.Drawing.Point(10, -1)
        Me.cbxSine.Name = "cbxSine"
        Me.cbxSine.Size = New System.Drawing.Size(150, 19)
        Me.cbxSine.TabIndex = 12
        Me.cbxSine.Text = "Sine Displacement"
        Me.cbxSine.UseVisualStyleBackColor = True
        '
        'lblCycle
        '
        Me.lblCycle.AutoSize = True
        Me.lblCycle.Location = New System.Drawing.Point(19, 89)
        Me.lblCycle.Name = "lblCycle"
        Me.lblCycle.Size = New System.Drawing.Size(49, 15)
        Me.lblCycle.TabIndex = 6
        Me.lblCycle.Text = "Cycle:"
        '
        'tbCycle
        '
        Me.tbCycle.Location = New System.Drawing.Point(118, 84)
        Me.tbCycle.Minimum = 1
        Me.tbCycle.Name = "tbCycle"
        Me.tbCycle.Size = New System.Drawing.Size(295, 56)
        Me.tbCycle.TabIndex = 5
        Me.tbCycle.Value = 3
        '
        'lblAmplitude
        '
        Me.lblAmplitude.AutoSize = True
        Me.lblAmplitude.Location = New System.Drawing.Point(19, 30)
        Me.lblAmplitude.Name = "lblAmplitude"
        Me.lblAmplitude.Size = New System.Drawing.Size(74, 15)
        Me.lblAmplitude.TabIndex = 4
        Me.lblAmplitude.Text = "Amplitude:"
        '
        'tbAmplitude
        '
        Me.tbAmplitude.Location = New System.Drawing.Point(118, 26)
        Me.tbAmplitude.Minimum = 1
        Me.tbAmplitude.Name = "tbAmplitude"
        Me.tbAmplitude.Size = New System.Drawing.Size(295, 56)
        Me.tbAmplitude.TabIndex = 0
        Me.tbAmplitude.Value = 7
        '
        'gbxRandom
        '
        Me.gbxRandom.Controls.Add(Me.cbxRandom)
        Me.gbxRandom.Controls.Add(Me.lblPeriod)
        Me.gbxRandom.Controls.Add(Me.tbPeriod)
        Me.gbxRandom.Controls.Add(Me.lblOffset)
        Me.gbxRandom.Controls.Add(Me.tbOffset)
        Me.gbxRandom.Location = New System.Drawing.Point(19, 176)
        Me.gbxRandom.Name = "gbxRandom"
        Me.gbxRandom.Size = New System.Drawing.Size(432, 145)
        Me.gbxRandom.TabIndex = 11
        Me.gbxRandom.TabStop = False
        '
        'cbxRandom
        '
        Me.cbxRandom.AutoSize = True
        Me.cbxRandom.Location = New System.Drawing.Point(10, -1)
        Me.cbxRandom.Name = "cbxRandom"
        Me.cbxRandom.Size = New System.Drawing.Size(175, 19)
        Me.cbxRandom.TabIndex = 13
        Me.cbxRandom.Text = "Random Displacement"
        Me.cbxRandom.UseVisualStyleBackColor = True
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(19, 89)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(54, 15)
        Me.lblPeriod.TabIndex = 6
        Me.lblPeriod.Text = "Period:"
        '
        'tbPeriod
        '
        Me.tbPeriod.Location = New System.Drawing.Point(118, 84)
        Me.tbPeriod.Minimum = 1
        Me.tbPeriod.Name = "tbPeriod"
        Me.tbPeriod.Size = New System.Drawing.Size(295, 56)
        Me.tbPeriod.TabIndex = 5
        Me.tbPeriod.Value = 3
        '
        'lblOffset
        '
        Me.lblOffset.AutoSize = True
        Me.lblOffset.Location = New System.Drawing.Point(19, 30)
        Me.lblOffset.Name = "lblOffset"
        Me.lblOffset.Size = New System.Drawing.Size(52, 15)
        Me.lblOffset.TabIndex = 4
        Me.lblOffset.Text = "Offset:"
        '
        'tbOffset
        '
        Me.tbOffset.Location = New System.Drawing.Point(118, 26)
        Me.tbOffset.Minimum = 1
        Me.tbOffset.Name = "tbOffset"
        Me.tbOffset.Size = New System.Drawing.Size(295, 56)
        Me.tbOffset.TabIndex = 0
        Me.tbOffset.Value = 3
        '
        'tbMeltAngle
        '
        Me.tbMeltAngle.LargeChange = 30
        Me.tbMeltAngle.Location = New System.Drawing.Point(19, 26)
        Me.tbMeltAngle.Maximum = 359
        Me.tbMeltAngle.Name = "tbMeltAngle"
        Me.tbMeltAngle.Size = New System.Drawing.Size(394, 56)
        Me.tbMeltAngle.TabIndex = 0
        Me.tbMeltAngle.TickFrequency = 30
        '
        'gbxRoughen
        '
        Me.gbxRoughen.Controls.Add(Me.lblWeak)
        Me.gbxRoughen.Controls.Add(Me.lblStrong)
        Me.gbxRoughen.Controls.Add(Me.tbMeltAngle)
        Me.gbxRoughen.Location = New System.Drawing.Point(19, 343)
        Me.gbxRoughen.Name = "gbxRoughen"
        Me.gbxRoughen.Size = New System.Drawing.Size(432, 108)
        Me.gbxRoughen.TabIndex = 12
        Me.gbxRoughen.TabStop = False
        Me.gbxRoughen.Text = "Angle of Rotation"
        '
        'lblWeak
        '
        Me.lblWeak.AutoSize = True
        Me.lblWeak.Location = New System.Drawing.Point(30, 69)
        Me.lblWeak.Name = "lblWeak"
        Me.lblWeak.Size = New System.Drawing.Size(15, 15)
        Me.lblWeak.TabIndex = 3
        Me.lblWeak.Text = "0"
        '
        'lblStrong
        '
        Me.lblStrong.AutoSize = True
        Me.lblStrong.Location = New System.Drawing.Point(371, 69)
        Me.lblStrong.Name = "lblStrong"
        Me.lblStrong.Size = New System.Drawing.Size(31, 15)
        Me.lblStrong.TabIndex = 5
        Me.lblStrong.Text = "359"
        '
        'lblMeltAngle
        '
        Me.lblMeltAngle.AutoSize = True
        Me.lblMeltAngle.Location = New System.Drawing.Point(89, 468)
        Me.lblMeltAngle.Name = "lblMeltAngle"
        Me.lblMeltAngle.Size = New System.Drawing.Size(0, 15)
        Me.lblMeltAngle.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 468)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Angle:"
        '
        'frmMelt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 18)
        Me.ClientSize = New System.Drawing.Size(479, 524)
        Me.Controls.Add(Me.lblMeltAngle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbxRoughen)
        Me.Controls.Add(Me.gbxRandom)
        Me.Controls.Add(Me.gbxSine)
        Me.Controls.Add(Me.btnApply)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMelt"
        Me.Text = "Melt"
        Me.gbxSine.ResumeLayout(False)
        Me.gbxSine.PerformLayout()
        CType(Me.tbCycle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbAmplitude, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRandom.ResumeLayout(False)
        Me.gbxRandom.PerformLayout()
        CType(Me.tbPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbOffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbMeltAngle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxRoughen.ResumeLayout(False)
        Me.gbxRoughen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMelt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxSine.Checked = True
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        ApplyEffect()
    End Sub

    Overrides Sub Process(ByRef input As Bitmap, ByRef output As Bitmap, ByVal rect As Rectangle)
        Melt(input, output, rect, cbxSine.Checked, tbAmplitude.Value, tbCycle.Value, cbxRandom.Checked, tbOffset.Value, tbPeriod.Value, tbMeltAngle.Value)
        frmMain.iObject(frmMain.currentImageIndex).Reset(output)
    End Sub

    Private Sub tbMeltAngle_ValueChanged(sender As Object, e As EventArgs) Handles tbMeltAngle.ValueChanged
        lblMeltAngle.Text = tbMeltAngle.Value
    End Sub
End Class
