Public Class frmEdge
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
    Friend WithEvents btnApply As System.Windows.Forms.Button
    Friend WithEvents slrStrength As System.Windows.Forms.TrackBar
    Friend WithEvents lblPlanes As System.Windows.Forms.Label
    Friend WithEvents cbEdge As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.slrStrength = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPlanes = New System.Windows.Forms.Label()
        Me.cbEdge = New System.Windows.Forms.ComboBox()
        CType(Me.slrStrength, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnApply
        '
        Me.btnApply.Location = New System.Drawing.Point(147, 114)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(192, 35)
        Me.btnApply.TabIndex = 22
        Me.btnApply.Text = "Apply"
        '
        'slrStrength
        '
        Me.slrStrength.LargeChange = 1
        Me.slrStrength.Location = New System.Drawing.Point(38, 55)
        Me.slrStrength.Maximum = 5
        Me.slrStrength.Minimum = 1
        Me.slrStrength.Name = "slrStrength"
        Me.slrStrength.Size = New System.Drawing.Size(423, 56)
        Me.slrStrength.TabIndex = 24
        Me.slrStrength.Value = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 22)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Strength"
        '
        'lblPlanes
        '
        Me.lblPlanes.AutoSize = True
        Me.lblPlanes.Location = New System.Drawing.Point(222, 22)
        Me.lblPlanes.Name = "lblPlanes"
        Me.lblPlanes.Size = New System.Drawing.Size(47, 15)
        Me.lblPlanes.TabIndex = 27
        Me.lblPlanes.Text = "Color:"
        '
        'cbEdge
        '
        Me.cbEdge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEdge.FormattingEnabled = True
        Me.cbEdge.Items.AddRange(New Object() {"Black", "White", "Sharpening"})
        Me.cbEdge.Location = New System.Drawing.Point(275, 18)
        Me.cbEdge.Name = "cbEdge"
        Me.cbEdge.Size = New System.Drawing.Size(173, 23)
        Me.cbEdge.TabIndex = 26
        '
        'frmEdge
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 18)
        Me.ClientSize = New System.Drawing.Size(505, 167)
        Me.Controls.Add(Me.lblPlanes)
        Me.Controls.Add(Me.cbEdge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.slrStrength)
        Me.Controls.Add(Me.btnApply)
        Me.Name = "frmEdge"
        Me.Text = "Edge"
        CType(Me.slrStrength, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmEdge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbEdge.SelectedIndex = 0 'color: 0 for black, 1 for white
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        ApplyEffect()
    End Sub

    Overrides Function Process(ByRef image As Bitmap, ByVal x As Integer, ByVal y As Integer) As Color
        Return Edge(image, x, y, slrStrength.Value, cbEdge.SelectedIndex)
    End Function
End Class
