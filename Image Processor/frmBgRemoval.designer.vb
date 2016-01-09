<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBgRemoval
    Inherits MDIForm.frmSpatialEffect

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPlanes = New System.Windows.Forms.Label()
        Me.cbFloodFill = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.slrSimlarity = New System.Windows.Forms.TrackBar()
        Me.pbStart = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.slrSimlarity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlanes
        '
        Me.lblPlanes.AutoSize = True
        Me.lblPlanes.Location = New System.Drawing.Point(259, 43)
        Me.lblPlanes.Name = "lblPlanes"
        Me.lblPlanes.Size = New System.Drawing.Size(69, 15)
        Me.lblPlanes.TabIndex = 32
        Me.lblPlanes.Text = "Direction:"
        '
        'cbFloodFill
        '
        Me.cbFloodFill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFloodFill.FormattingEnabled = True
        Me.cbFloodFill.Items.AddRange(New Object() {"4 direction", "8 direction"})
        Me.cbFloodFill.Location = New System.Drawing.Point(334, 40)
        Me.cbFloodFill.Name = "cbFloodFill"
        Me.cbFloodFill.Size = New System.Drawing.Size(173, 23)
        Me.cbFloodFill.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(75, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 22)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Similarity"
        '
        'slrSimlarity
        '
        Me.slrSimlarity.LargeChange = 1
        Me.slrSimlarity.Location = New System.Drawing.Point(75, 76)
        Me.slrSimlarity.Minimum = 1
        Me.slrSimlarity.Name = "slrSimlarity"
        Me.slrSimlarity.Size = New System.Drawing.Size(423, 56)
        Me.slrSimlarity.TabIndex = 29
        Me.slrSimlarity.Value = 1
        '
        'pbStart
        '
        Me.pbStart.BackColor = System.Drawing.Color.Transparent
        Me.pbStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbStart.Location = New System.Drawing.Point(78, 155)
        Me.pbStart.Name = "pbStart"
        Me.pbStart.Size = New System.Drawing.Size(420, 326)
        Me.pbStart.TabIndex = 33
        Me.pbStart.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(75, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 22)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Starting Position"
        '
        'frmBgRemoval
        '
        Me.ClientSize = New System.Drawing.Size(571, 518)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbStart)
        Me.Controls.Add(Me.lblPlanes)
        Me.Controls.Add(Me.cbFloodFill)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.slrSimlarity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBgRemoval"
        Me.Text = "Background removal"
        CType(Me.slrSimlarity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPlanes As System.Windows.Forms.Label
    Friend WithEvents cbFloodFill As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents slrSimlarity As System.Windows.Forms.TrackBar
    Friend WithEvents pbStart As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
