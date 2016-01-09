Option Explicit On
Public Class frmMidiPiano
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code "
    Public Sub New()

        MyBase.New()
        'This call is required by the Windows Form Designer.
        Dim j As Integer
        If channel_data(0) Is Nothing Then 'check for error. not exactly sure..
            For j = 0 To 15
                channel_data(j) = New ChannelData
            Next j
        End If
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private WithEvents vsbVolume As System.Windows.Forms.VScrollBar
    Public WithEvents _key_15 As System.Windows.Forms.CheckBox
    Public WithEvents _key_13 As System.Windows.Forms.CheckBox
    Public WithEvents _key_10 As System.Windows.Forms.CheckBox
    Public WithEvents _key_8 As System.Windows.Forms.CheckBox
    Public WithEvents _key_6 As System.Windows.Forms.CheckBox
    Public WithEvents _key_3 As System.Windows.Forms.CheckBox
    Public WithEvents _key_1 As System.Windows.Forms.CheckBox
    Public WithEvents _key_16 As System.Windows.Forms.CheckBox
    Public WithEvents _key_14 As System.Windows.Forms.CheckBox
    Public WithEvents _key_12 As System.Windows.Forms.CheckBox
    Public WithEvents _key_11 As System.Windows.Forms.CheckBox
    Public WithEvents _key_9 As System.Windows.Forms.CheckBox
    Public WithEvents _key_7 As System.Windows.Forms.CheckBox
    Public WithEvents _key_5 As System.Windows.Forms.CheckBox
    Public WithEvents _key_4 As System.Windows.Forms.CheckBox
    Public WithEvents _key_2 As System.Windows.Forms.CheckBox
    Public WithEvents _key_0 As System.Windows.Forms.CheckBox
    Private WithEvents lblVolume As System.Windows.Forms.Label
    Public WithEvents mnuDevice0 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice1 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice2 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice3 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice4 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice5 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice6 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice7 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice8 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice9 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice10 As System.Windows.Forms.MenuItem
    Public WithEvents mnuDevice As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel0 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel1 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel2 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel3 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel4 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel5 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel6 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel7 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel8 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel9 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel10 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel11 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel12 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel13 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel14 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel15 As System.Windows.Forms.MenuItem
    Public WithEvents mnuChannel As System.Windows.Forms.MenuItem
    Public WithEvents mnuBaseNote As System.Windows.Forms.MenuItem
    Public mnuMain As System.Windows.Forms.MainMenu
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents gbxInstrument As System.Windows.Forms.GroupBox
    Friend WithEvents tbBankMSB As System.Windows.Forms.TrackBar
    Friend WithEvents tbInstrument As System.Windows.Forms.TrackBar
    Friend WithEvents lblBankMSB As System.Windows.Forms.Label
    Friend WithEvents tmrSequencer As System.Windows.Forms.Timer
    Friend WithEvents tclMidiFunction As System.Windows.Forms.TabControl
    Friend WithEvents tabDrumMachine As System.Windows.Forms.TabPage
    Friend WithEvents tabWhiteboard As System.Windows.Forms.TabPage
    Friend WithEvents gbxXAxis As System.Windows.Forms.GroupBox
    Friend WithEvents lblXValue As System.Windows.Forms.Label
    Friend WithEvents cboXTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblXTitle As System.Windows.Forms.Label
    Friend WithEvents lblXCaption As System.Windows.Forms.Label
    Friend WithEvents picWhiteboard As System.Windows.Forms.PictureBox
    Friend WithEvents gbxYAxis As System.Windows.Forms.GroupBox
    Friend WithEvents cboYTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblYTitle As System.Windows.Forms.Label
    Friend WithEvents lblYCaption As System.Windows.Forms.Label
    Friend WithEvents lblYValue As System.Windows.Forms.Label
    Public WithEvents btnDrumStop As System.Windows.Forms.Button
    Public WithEvents btnDrumStart As System.Windows.Forms.Button
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuOpen As System.Windows.Forms.MenuItem
    Public WithEvents tmrDrumPlayback As System.Windows.Forms.Timer
    Friend WithEvents LabelPanningRight As System.Windows.Forms.Label
    Friend WithEvents tabBasics As System.Windows.Forms.TabPage
    Friend WithEvents BtnPlayChord As System.Windows.Forms.Button
    Friend WithEvents BtnPlayNote As System.Windows.Forms.Button
    Friend WithEvents cbInstrument As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbChannel As System.Windows.Forms.TrackBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbPanning As System.Windows.Forms.TrackBar
    Friend WithEvents LabelPanning As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelPanningLeft As System.Windows.Forms.Label
    Friend WithEvents cbChord As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Public WithEvents btnRandomSelection As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cbDrum2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbDrum1 As System.Windows.Forms.ComboBox
    Public WithEvents btnResetDrum As System.Windows.Forms.Button
    Public WithEvents btnInverseDrum As System.Windows.Forms.Button
    Public WithEvents btnReverseDrum As System.Windows.Forms.Button
    Public WithEvents btnAddColumn As System.Windows.Forms.Button
    Public WithEvents btnAddRow As System.Windows.Forms.Button
    Friend WithEvents lblSeqFast As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSeqNormal As System.Windows.Forms.Label
    Friend WithEvents lblSeqSlow As System.Windows.Forms.Label
    Friend WithEvents tbSpeed As System.Windows.Forms.TrackBar
    Friend WithEvents tabSequencer As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tbTranspose As System.Windows.Forms.TrackBar
    Private WithEvents btnLoad As System.Windows.Forms.Button
    Private WithEvents btnLoop As System.Windows.Forms.Button
    Private WithEvents btnAppend As System.Windows.Forms.Button
    Private WithEvents btnRecord As System.Windows.Forms.Button
    Private WithEvents btnStop As System.Windows.Forms.Button
    Private WithEvents btnPlay As System.Windows.Forms.Button
    Private WithEvents btnRemoveSilence As System.Windows.Forms.Button
    Public WithEvents btnDeleteColumn As System.Windows.Forms.Button
    Public WithEvents btnDeleteRow As System.Windows.Forms.Button
    Public WithEvents btnLoadDrum As System.Windows.Forms.Button
    Public WithEvents picDrum As System.Windows.Forms.PictureBox
    Friend WithEvents lblInstrument As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.vsbVolume = New System.Windows.Forms.VScrollBar()
        Me._key_15 = New System.Windows.Forms.CheckBox()
        Me._key_13 = New System.Windows.Forms.CheckBox()
        Me._key_10 = New System.Windows.Forms.CheckBox()
        Me._key_8 = New System.Windows.Forms.CheckBox()
        Me._key_6 = New System.Windows.Forms.CheckBox()
        Me._key_3 = New System.Windows.Forms.CheckBox()
        Me._key_1 = New System.Windows.Forms.CheckBox()
        Me._key_16 = New System.Windows.Forms.CheckBox()
        Me._key_14 = New System.Windows.Forms.CheckBox()
        Me._key_12 = New System.Windows.Forms.CheckBox()
        Me._key_11 = New System.Windows.Forms.CheckBox()
        Me._key_9 = New System.Windows.Forms.CheckBox()
        Me._key_7 = New System.Windows.Forms.CheckBox()
        Me._key_5 = New System.Windows.Forms.CheckBox()
        Me._key_4 = New System.Windows.Forms.CheckBox()
        Me._key_2 = New System.Windows.Forms.CheckBox()
        Me._key_0 = New System.Windows.Forms.CheckBox()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.mnuChannel0 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel1 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel2 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel3 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel4 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel5 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel6 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel7 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel8 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel9 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel10 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel11 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel12 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel13 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel14 = New System.Windows.Forms.MenuItem()
        Me.mnuChannel15 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice0 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice1 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice2 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice3 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice4 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice5 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice6 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice7 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice8 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice9 = New System.Windows.Forms.MenuItem()
        Me.mnuDevice10 = New System.Windows.Forms.MenuItem()
        Me.mnuMain = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem()
        Me.mnuOpen = New System.Windows.Forms.MenuItem()
        Me.mnuDevice = New System.Windows.Forms.MenuItem()
        Me.mnuChannel = New System.Windows.Forms.MenuItem()
        Me.mnuBaseNote = New System.Windows.Forms.MenuItem()
        Me.gbxInstrument = New System.Windows.Forms.GroupBox()
        Me.lblSeqFast = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSeqNormal = New System.Windows.Forms.Label()
        Me.lblSeqSlow = New System.Windows.Forms.Label()
        Me.tbSpeed = New System.Windows.Forms.TrackBar()
        Me.LabelPanningRight = New System.Windows.Forms.Label()
        Me.tbBankMSB = New System.Windows.Forms.TrackBar()
        Me.tbInstrument = New System.Windows.Forms.TrackBar()
        Me.lblBankMSB = New System.Windows.Forms.Label()
        Me.lblInstrument = New System.Windows.Forms.Label()
        Me.tmrSequencer = New System.Windows.Forms.Timer(Me.components)
        Me.tclMidiFunction = New System.Windows.Forms.TabControl()
        Me.tabBasics = New System.Windows.Forms.TabPage()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cbChord = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelPanningLeft = New System.Windows.Forms.Label()
        Me.tbPanning = New System.Windows.Forms.TrackBar()
        Me.LabelPanning = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbChannel = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbInstrument = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPlayChord = New System.Windows.Forms.Button()
        Me.BtnPlayNote = New System.Windows.Forms.Button()
        Me.tabSequencer = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbTranspose = New System.Windows.Forms.TrackBar()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnLoop = New System.Windows.Forms.Button()
        Me.btnAppend = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnRemoveSilence = New System.Windows.Forms.Button()
        Me.tabWhiteboard = New System.Windows.Forms.TabPage()
        Me.gbxXAxis = New System.Windows.Forms.GroupBox()
        Me.lblXValue = New System.Windows.Forms.Label()
        Me.cboXTitle = New System.Windows.Forms.ComboBox()
        Me.lblXTitle = New System.Windows.Forms.Label()
        Me.lblXCaption = New System.Windows.Forms.Label()
        Me.picWhiteboard = New System.Windows.Forms.PictureBox()
        Me.gbxYAxis = New System.Windows.Forms.GroupBox()
        Me.cboYTitle = New System.Windows.Forms.ComboBox()
        Me.lblYTitle = New System.Windows.Forms.Label()
        Me.lblYCaption = New System.Windows.Forms.Label()
        Me.lblYValue = New System.Windows.Forms.Label()
        Me.tabDrumMachine = New System.Windows.Forms.TabPage()
        Me.btnLoadDrum = New System.Windows.Forms.Button()
        Me.btnDeleteColumn = New System.Windows.Forms.Button()
        Me.btnDeleteRow = New System.Windows.Forms.Button()
        Me.btnAddColumn = New System.Windows.Forms.Button()
        Me.btnAddRow = New System.Windows.Forms.Button()
        Me.btnResetDrum = New System.Windows.Forms.Button()
        Me.btnInverseDrum = New System.Windows.Forms.Button()
        Me.btnReverseDrum = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cbDrum2 = New System.Windows.Forms.ComboBox()
        Me.cbDrum1 = New System.Windows.Forms.ComboBox()
        Me.btnRandomSelection = New System.Windows.Forms.Button()
        Me.btnDrumStop = New System.Windows.Forms.Button()
        Me.btnDrumStart = New System.Windows.Forms.Button()
        Me.picDrum = New System.Windows.Forms.PictureBox()
        Me.tmrDrumPlayback = New System.Windows.Forms.Timer(Me.components)
        Me.gbxInstrument.SuspendLayout()
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbBankMSB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tclMidiFunction.SuspendLayout()
        Me.tabBasics.SuspendLayout()
        CType(Me.tbPanning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbChannel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSequencer.SuspendLayout()
        CType(Me.tbTranspose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabWhiteboard.SuspendLayout()
        Me.gbxXAxis.SuspendLayout()
        CType(Me.picWhiteboard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxYAxis.SuspendLayout()
        Me.tabDrumMachine.SuspendLayout()
        CType(Me.picDrum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsbVolume
        '
        Me.vsbVolume.LargeChange = 1
        Me.vsbVolume.Location = New System.Drawing.Point(32, 35)
        Me.vsbVolume.Maximum = 127
        Me.vsbVolume.Name = "vsbVolume"
        Me.vsbVolume.Size = New System.Drawing.Size(36, 171)
        Me.vsbVolume.TabIndex = 17
        Me.vsbVolume.TabStop = True
        '
        '_key_15
        '
        Me._key_15.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_15.BackColor = System.Drawing.Color.Black
        Me._key_15.ForeColor = System.Drawing.Color.White
        Me._key_15.Location = New System.Drawing.Point(567, 17)
        Me._key_15.Name = "_key_15"
        Me._key_15.Size = New System.Drawing.Size(26, 115)
        Me._key_15.TabIndex = 16
        Me._key_15.Text = ";"
        Me._key_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_15.UseVisualStyleBackColor = False
        '
        '_key_13
        '
        Me._key_13.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_13.BackColor = System.Drawing.Color.Black
        Me._key_13.ForeColor = System.Drawing.Color.White
        Me._key_13.Location = New System.Drawing.Point(515, 17)
        Me._key_13.Name = "_key_13"
        Me._key_13.Size = New System.Drawing.Size(28, 115)
        Me._key_13.TabIndex = 15
        Me._key_13.Text = "L"
        Me._key_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_13.UseVisualStyleBackColor = False
        '
        '_key_10
        '
        Me._key_10.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_10.BackColor = System.Drawing.Color.Black
        Me._key_10.ForeColor = System.Drawing.Color.White
        Me._key_10.Location = New System.Drawing.Point(413, 17)
        Me._key_10.Name = "_key_10"
        Me._key_10.Size = New System.Drawing.Size(27, 115)
        Me._key_10.TabIndex = 14
        Me._key_10.Text = "J"
        Me._key_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_10.UseVisualStyleBackColor = False
        '
        '_key_8
        '
        Me._key_8.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_8.BackColor = System.Drawing.Color.Black
        Me._key_8.ForeColor = System.Drawing.Color.White
        Me._key_8.Location = New System.Drawing.Point(361, 17)
        Me._key_8.Name = "_key_8"
        Me._key_8.Size = New System.Drawing.Size(28, 115)
        Me._key_8.TabIndex = 13
        Me._key_8.Text = "H"
        Me._key_8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_8.UseVisualStyleBackColor = False
        '
        '_key_6
        '
        Me._key_6.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_6.BackColor = System.Drawing.Color.Black
        Me._key_6.ForeColor = System.Drawing.Color.White
        Me._key_6.Location = New System.Drawing.Point(311, 17)
        Me._key_6.Name = "_key_6"
        Me._key_6.Size = New System.Drawing.Size(26, 115)
        Me._key_6.TabIndex = 12
        Me._key_6.Text = "G"
        Me._key_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_6.UseVisualStyleBackColor = False
        '
        '_key_3
        '
        Me._key_3.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_3.BackColor = System.Drawing.Color.Black
        Me._key_3.ForeColor = System.Drawing.Color.White
        Me._key_3.Location = New System.Drawing.Point(208, 17)
        Me._key_3.Name = "_key_3"
        Me._key_3.Size = New System.Drawing.Size(27, 115)
        Me._key_3.TabIndex = 11
        Me._key_3.Text = "D"
        Me._key_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_3.UseVisualStyleBackColor = False
        '
        '_key_1
        '
        Me._key_1.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_1.BackColor = System.Drawing.Color.Black
        Me._key_1.ForeColor = System.Drawing.Color.White
        Me._key_1.Location = New System.Drawing.Point(157, 17)
        Me._key_1.Name = "_key_1"
        Me._key_1.Size = New System.Drawing.Size(27, 115)
        Me._key_1.TabIndex = 10
        Me._key_1.Text = "S"
        Me._key_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_1.UseVisualStyleBackColor = False
        '
        '_key_16
        '
        Me._key_16.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_16.BackColor = System.Drawing.Color.White
        Me._key_16.ForeColor = System.Drawing.Color.Black
        Me._key_16.Location = New System.Drawing.Point(579, 17)
        Me._key_16.Name = "_key_16"
        Me._key_16.Size = New System.Drawing.Size(53, 189)
        Me._key_16.TabIndex = 9
        Me._key_16.Text = "/"
        Me._key_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_16.UseVisualStyleBackColor = False
        '
        '_key_14
        '
        Me._key_14.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_14.BackColor = System.Drawing.Color.White
        Me._key_14.ForeColor = System.Drawing.Color.Black
        Me._key_14.Location = New System.Drawing.Point(528, 17)
        Me._key_14.Name = "_key_14"
        Me._key_14.Size = New System.Drawing.Size(53, 189)
        Me._key_14.TabIndex = 8
        Me._key_14.Text = "."
        Me._key_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_14.UseVisualStyleBackColor = False
        '
        '_key_12
        '
        Me._key_12.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_12.BackColor = System.Drawing.Color.White
        Me._key_12.ForeColor = System.Drawing.Color.Black
        Me._key_12.Location = New System.Drawing.Point(477, 17)
        Me._key_12.Name = "_key_12"
        Me._key_12.Size = New System.Drawing.Size(52, 189)
        Me._key_12.TabIndex = 7
        Me._key_12.Text = ","
        Me._key_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_12.UseVisualStyleBackColor = False
        '
        '_key_11
        '
        Me._key_11.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_11.BackColor = System.Drawing.Color.White
        Me._key_11.ForeColor = System.Drawing.Color.Black
        Me._key_11.Location = New System.Drawing.Point(425, 17)
        Me._key_11.Name = "_key_11"
        Me._key_11.Size = New System.Drawing.Size(54, 189)
        Me._key_11.TabIndex = 6
        Me._key_11.Text = "M"
        Me._key_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_11.UseVisualStyleBackColor = False
        '
        '_key_9
        '
        Me._key_9.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_9.BackColor = System.Drawing.Color.White
        Me._key_9.ForeColor = System.Drawing.Color.Black
        Me._key_9.Location = New System.Drawing.Point(375, 17)
        Me._key_9.Name = "_key_9"
        Me._key_9.Size = New System.Drawing.Size(52, 189)
        Me._key_9.TabIndex = 5
        Me._key_9.Text = "N"
        Me._key_9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_9.UseVisualStyleBackColor = False
        '
        '_key_7
        '
        Me._key_7.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_7.BackColor = System.Drawing.Color.White
        Me._key_7.ForeColor = System.Drawing.Color.Black
        Me._key_7.Location = New System.Drawing.Point(323, 17)
        Me._key_7.Name = "_key_7"
        Me._key_7.Size = New System.Drawing.Size(53, 189)
        Me._key_7.TabIndex = 4
        Me._key_7.Text = "B"
        Me._key_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_7.UseVisualStyleBackColor = False
        '
        '_key_5
        '
        Me._key_5.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_5.BackColor = System.Drawing.Color.White
        Me._key_5.ForeColor = System.Drawing.Color.Black
        Me._key_5.Location = New System.Drawing.Point(272, 17)
        Me._key_5.Name = "_key_5"
        Me._key_5.Size = New System.Drawing.Size(53, 189)
        Me._key_5.TabIndex = 3
        Me._key_5.Text = "V"
        Me._key_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_5.UseVisualStyleBackColor = False
        '
        '_key_4
        '
        Me._key_4.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_4.BackColor = System.Drawing.Color.White
        Me._key_4.ForeColor = System.Drawing.Color.Black
        Me._key_4.Location = New System.Drawing.Point(221, 17)
        Me._key_4.Name = "_key_4"
        Me._key_4.Size = New System.Drawing.Size(52, 189)
        Me._key_4.TabIndex = 2
        Me._key_4.Text = "C"
        Me._key_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_4.UseVisualStyleBackColor = False
        '
        '_key_2
        '
        Me._key_2.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_2.BackColor = System.Drawing.Color.White
        Me._key_2.ForeColor = System.Drawing.Color.Black
        Me._key_2.Location = New System.Drawing.Point(169, 17)
        Me._key_2.Name = "_key_2"
        Me._key_2.Size = New System.Drawing.Size(54, 189)
        Me._key_2.TabIndex = 1
        Me._key_2.Text = "X"
        Me._key_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_2.UseVisualStyleBackColor = False
        '
        '_key_0
        '
        Me._key_0.Appearance = System.Windows.Forms.Appearance.Button
        Me._key_0.BackColor = System.Drawing.Color.White
        Me._key_0.ForeColor = System.Drawing.Color.Black
        Me._key_0.Location = New System.Drawing.Point(119, 17)
        Me._key_0.Name = "_key_0"
        Me._key_0.Size = New System.Drawing.Size(52, 189)
        Me._key_0.TabIndex = 0
        Me._key_0.Text = "Z"
        Me._key_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me._key_0.UseVisualStyleBackColor = False
        '
        'lblVolume
        '
        Me.lblVolume.AutoSize = True
        Me.lblVolume.Location = New System.Drawing.Point(25, 17)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(54, 15)
        Me.lblVolume.TabIndex = 18
        Me.lblVolume.Text = "Volume"
        '
        'mnuChannel0
        '
        Me.mnuChannel0.Index = 0
        Me.mnuChannel0.Text = "1"
        '
        'mnuChannel1
        '
        Me.mnuChannel1.Index = 1
        Me.mnuChannel1.Text = "2"
        '
        'mnuChannel2
        '
        Me.mnuChannel2.Index = 2
        Me.mnuChannel2.Text = "3"
        '
        'mnuChannel3
        '
        Me.mnuChannel3.Index = 3
        Me.mnuChannel3.Text = "4"
        '
        'mnuChannel4
        '
        Me.mnuChannel4.Index = 4
        Me.mnuChannel4.Text = "5"
        '
        'mnuChannel5
        '
        Me.mnuChannel5.Index = 5
        Me.mnuChannel5.Text = "6"
        '
        'mnuChannel6
        '
        Me.mnuChannel6.Index = 6
        Me.mnuChannel6.Text = "7"
        '
        'mnuChannel7
        '
        Me.mnuChannel7.Index = 7
        Me.mnuChannel7.Text = "8"
        '
        'mnuChannel8
        '
        Me.mnuChannel8.Index = 8
        Me.mnuChannel8.Text = "9"
        '
        'mnuChannel9
        '
        Me.mnuChannel9.Index = 9
        Me.mnuChannel9.Text = "10"
        '
        'mnuChannel10
        '
        Me.mnuChannel10.Index = 10
        Me.mnuChannel10.Text = "11"
        '
        'mnuChannel11
        '
        Me.mnuChannel11.Index = 11
        Me.mnuChannel11.Text = "12"
        '
        'mnuChannel12
        '
        Me.mnuChannel12.Index = 12
        Me.mnuChannel12.Text = "13"
        '
        'mnuChannel13
        '
        Me.mnuChannel13.Index = 13
        Me.mnuChannel13.Text = "14"
        '
        'mnuChannel14
        '
        Me.mnuChannel14.Index = 14
        Me.mnuChannel14.Text = "15"
        '
        'mnuChannel15
        '
        Me.mnuChannel15.Index = 15
        Me.mnuChannel15.Text = "16"
        '
        'mnuDevice0
        '
        Me.mnuDevice0.Index = 0
        Me.mnuDevice0.Text = ""
        '
        'mnuDevice1
        '
        Me.mnuDevice1.Enabled = False
        Me.mnuDevice1.Index = 1
        Me.mnuDevice1.Text = ""
        Me.mnuDevice1.Visible = False
        '
        'mnuDevice2
        '
        Me.mnuDevice2.Enabled = False
        Me.mnuDevice2.Index = 2
        Me.mnuDevice2.Text = ""
        Me.mnuDevice2.Visible = False
        '
        'mnuDevice3
        '
        Me.mnuDevice3.Enabled = False
        Me.mnuDevice3.Index = 3
        Me.mnuDevice3.Text = ""
        Me.mnuDevice3.Visible = False
        '
        'mnuDevice4
        '
        Me.mnuDevice4.Enabled = False
        Me.mnuDevice4.Index = 4
        Me.mnuDevice4.Text = ""
        Me.mnuDevice4.Visible = False
        '
        'mnuDevice5
        '
        Me.mnuDevice5.Enabled = False
        Me.mnuDevice5.Index = 5
        Me.mnuDevice5.Text = ""
        Me.mnuDevice5.Visible = False
        '
        'mnuDevice6
        '
        Me.mnuDevice6.Enabled = False
        Me.mnuDevice6.Index = 6
        Me.mnuDevice6.Text = ""
        Me.mnuDevice6.Visible = False
        '
        'mnuDevice7
        '
        Me.mnuDevice7.Enabled = False
        Me.mnuDevice7.Index = 7
        Me.mnuDevice7.Text = ""
        Me.mnuDevice7.Visible = False
        '
        'mnuDevice8
        '
        Me.mnuDevice8.Enabled = False
        Me.mnuDevice8.Index = 8
        Me.mnuDevice8.Text = ""
        Me.mnuDevice8.Visible = False
        '
        'mnuDevice9
        '
        Me.mnuDevice9.Enabled = False
        Me.mnuDevice9.Index = 9
        Me.mnuDevice9.Text = ""
        Me.mnuDevice9.Visible = False
        '
        'mnuDevice10
        '
        Me.mnuDevice10.Enabled = False
        Me.mnuDevice10.Index = 10
        Me.mnuDevice10.Text = ""
        Me.mnuDevice10.Visible = False
        '
        'mnuMain
        '
        Me.mnuMain.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuDevice, Me.mnuChannel, Me.mnuBaseNote})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuOpen})
        Me.mnuFile.Text = "Midi &File"
        '
        'mnuOpen
        '
        Me.mnuOpen.Index = 0
        Me.mnuOpen.Text = "&Open"
        '
        'mnuDevice
        '
        Me.mnuDevice.Index = 1
        Me.mnuDevice.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuDevice0, Me.mnuDevice1, Me.mnuDevice2, Me.mnuDevice3, Me.mnuDevice4, Me.mnuDevice5, Me.mnuDevice6, Me.mnuDevice7, Me.mnuDevice8, Me.mnuDevice9, Me.mnuDevice10})
        Me.mnuDevice.Text = "Midi &Device"
        '
        'mnuChannel
        '
        Me.mnuChannel.Index = 2
        Me.mnuChannel.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuChannel0, Me.mnuChannel1, Me.mnuChannel2, Me.mnuChannel3, Me.mnuChannel4, Me.mnuChannel5, Me.mnuChannel6, Me.mnuChannel7, Me.mnuChannel8, Me.mnuChannel9, Me.mnuChannel10, Me.mnuChannel11, Me.mnuChannel12, Me.mnuChannel13, Me.mnuChannel14, Me.mnuChannel15})
        Me.mnuChannel.Text = "&Channel"
        '
        'mnuBaseNote
        '
        Me.mnuBaseNote.Index = 3
        Me.mnuBaseNote.Text = "&Base Note"
        '
        'gbxInstrument
        '
        Me.gbxInstrument.Controls.Add(Me.lblSeqFast)
        Me.gbxInstrument.Controls.Add(Me.Label8)
        Me.gbxInstrument.Controls.Add(Me.lblSeqNormal)
        Me.gbxInstrument.Controls.Add(Me.lblSeqSlow)
        Me.gbxInstrument.Controls.Add(Me.tbSpeed)
        Me.gbxInstrument.Controls.Add(Me.LabelPanningRight)
        Me.gbxInstrument.Controls.Add(Me.tbBankMSB)
        Me.gbxInstrument.Controls.Add(Me.tbInstrument)
        Me.gbxInstrument.Controls.Add(Me.lblBankMSB)
        Me.gbxInstrument.Controls.Add(Me.lblInstrument)
        Me.gbxInstrument.Location = New System.Drawing.Point(651, 17)
        Me.gbxInstrument.Name = "gbxInstrument"
        Me.gbxInstrument.Size = New System.Drawing.Size(597, 189)
        Me.gbxInstrument.TabIndex = 22
        Me.gbxInstrument.TabStop = False
        Me.gbxInstrument.Text = "MIDI Instrument"
        '
        'lblSeqFast
        '
        Me.lblSeqFast.Location = New System.Drawing.Point(542, 166)
        Me.lblSeqFast.Name = "lblSeqFast"
        Me.lblSeqFast.Size = New System.Drawing.Size(39, 20)
        Me.lblSeqFast.TabIndex = 45
        Me.lblSeqFast.Text = "Fast"
        Me.lblSeqFast.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Play Speed:"
        '
        'lblSeqNormal
        '
        Me.lblSeqNormal.Location = New System.Drawing.Point(303, 166)
        Me.lblSeqNormal.Name = "lblSeqNormal"
        Me.lblSeqNormal.Size = New System.Drawing.Size(116, 20)
        Me.lblSeqNormal.TabIndex = 44
        Me.lblSeqNormal.Text = "Normal Speed"
        Me.lblSeqNormal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSeqSlow
        '
        Me.lblSeqSlow.Location = New System.Drawing.Point(116, 166)
        Me.lblSeqSlow.Name = "lblSeqSlow"
        Me.lblSeqSlow.Size = New System.Drawing.Size(45, 20)
        Me.lblSeqSlow.TabIndex = 43
        Me.lblSeqSlow.Text = "Slow"
        '
        'tbSpeed
        '
        Me.tbSpeed.Location = New System.Drawing.Point(124, 118)
        Me.tbSpeed.Maximum = 9
        Me.tbSpeed.Minimum = -9
        Me.tbSpeed.Name = "tbSpeed"
        Me.tbSpeed.Size = New System.Drawing.Size(460, 56)
        Me.tbSpeed.TabIndex = 42
        '
        'LabelPanningRight
        '
        Me.LabelPanningRight.AutoSize = True
        Me.LabelPanningRight.Location = New System.Drawing.Point(668, 187)
        Me.LabelPanningRight.Name = "LabelPanningRight"
        Me.LabelPanningRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelPanningRight.Size = New System.Drawing.Size(40, 15)
        Me.LabelPanningRight.TabIndex = 28
        Me.LabelPanningRight.Text = "Right"
        '
        'tbBankMSB
        '
        Me.tbBankMSB.LargeChange = 2
        Me.tbBankMSB.Location = New System.Drawing.Point(120, 78)
        Me.tbBankMSB.Maximum = 8
        Me.tbBankMSB.Name = "tbBankMSB"
        Me.tbBankMSB.Size = New System.Drawing.Size(464, 56)
        Me.tbBankMSB.TabIndex = 3
        '
        'tbInstrument
        '
        Me.tbInstrument.Location = New System.Drawing.Point(120, 26)
        Me.tbInstrument.Maximum = 127
        Me.tbInstrument.Name = "tbInstrument"
        Me.tbInstrument.Size = New System.Drawing.Size(464, 56)
        Me.tbInstrument.TabIndex = 2
        '
        'lblBankMSB
        '
        Me.lblBankMSB.AutoSize = True
        Me.lblBankMSB.Location = New System.Drawing.Point(16, 83)
        Me.lblBankMSB.Name = "lblBankMSB"
        Me.lblBankMSB.Size = New System.Drawing.Size(82, 15)
        Me.lblBankMSB.TabIndex = 1
        Me.lblBankMSB.Text = "Bank MSB:"
        '
        'lblInstrument
        '
        Me.lblInstrument.AutoSize = True
        Me.lblInstrument.Location = New System.Drawing.Point(16, 35)
        Me.lblInstrument.Name = "lblInstrument"
        Me.lblInstrument.Size = New System.Drawing.Size(78, 15)
        Me.lblInstrument.TabIndex = 0
        Me.lblInstrument.Text = "Instrument:"
        '
        'tmrSequencer
        '
        '
        'tclMidiFunction
        '
        Me.tclMidiFunction.Controls.Add(Me.tabBasics)
        Me.tclMidiFunction.Controls.Add(Me.tabSequencer)
        Me.tclMidiFunction.Controls.Add(Me.tabWhiteboard)
        Me.tclMidiFunction.Controls.Add(Me.tabDrumMachine)
        Me.tclMidiFunction.Location = New System.Drawing.Point(19, 221)
        Me.tclMidiFunction.Name = "tclMidiFunction"
        Me.tclMidiFunction.SelectedIndex = 0
        Me.tclMidiFunction.Size = New System.Drawing.Size(1307, 491)
        Me.tclMidiFunction.TabIndex = 23
        '
        'tabBasics
        '
        Me.tabBasics.Controls.Add(Me.btnReset)
        Me.tabBasics.Controls.Add(Me.cbChord)
        Me.tabBasics.Controls.Add(Me.Label7)
        Me.tabBasics.Controls.Add(Me.Label6)
        Me.tabBasics.Controls.Add(Me.LabelPanningLeft)
        Me.tabBasics.Controls.Add(Me.tbPanning)
        Me.tabBasics.Controls.Add(Me.LabelPanning)
        Me.tabBasics.Controls.Add(Me.Label5)
        Me.tabBasics.Controls.Add(Me.Label4)
        Me.tabBasics.Controls.Add(Me.Label3)
        Me.tabBasics.Controls.Add(Me.tbChannel)
        Me.tabBasics.Controls.Add(Me.Label2)
        Me.tabBasics.Controls.Add(Me.cbInstrument)
        Me.tabBasics.Controls.Add(Me.Label1)
        Me.tabBasics.Controls.Add(Me.BtnPlayChord)
        Me.tabBasics.Controls.Add(Me.BtnPlayNote)
        Me.tabBasics.Location = New System.Drawing.Point(4, 25)
        Me.tabBasics.Name = "tabBasics"
        Me.tabBasics.Padding = New System.Windows.Forms.Padding(3)
        Me.tabBasics.Size = New System.Drawing.Size(1299, 462)
        Me.tabBasics.TabIndex = 3
        Me.tabBasics.Text = "MIDI Basics"
        Me.tabBasics.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(505, 350)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(173, 63)
        Me.btnReset.TabIndex = 50
        Me.btnReset.Text = "MIDI Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'cbChord
        '
        Me.cbChord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbChord.Items.AddRange(New Object() {"Major Chord", "Minor Chord", "Dominant 7th", "Augmented 7th"})
        Me.cbChord.Location = New System.Drawing.Point(249, 216)
        Me.cbChord.Name = "cbChord"
        Me.cbChord.Size = New System.Drawing.Size(153, 23)
        Me.cbChord.TabIndex = 49
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(143, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 22)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Chord Type:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1071, 260)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(40, 15)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Right"
        '
        'LabelPanningLeft
        '
        Me.LabelPanningLeft.AutoSize = True
        Me.LabelPanningLeft.Location = New System.Drawing.Point(650, 260)
        Me.LabelPanningLeft.Name = "LabelPanningLeft"
        Me.LabelPanningLeft.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelPanningLeft.Size = New System.Drawing.Size(31, 15)
        Me.LabelPanningLeft.TabIndex = 46
        Me.LabelPanningLeft.Text = "Left"
        '
        'tbPanning
        '
        Me.tbPanning.BackColor = System.Drawing.SystemColors.Control
        Me.tbPanning.LargeChange = 64
        Me.tbPanning.Location = New System.Drawing.Point(647, 219)
        Me.tbPanning.Maximum = 127
        Me.tbPanning.Name = "tbPanning"
        Me.tbPanning.Size = New System.Drawing.Size(464, 56)
        Me.tbPanning.TabIndex = 22
        Me.tbPanning.TickFrequency = 127
        Me.tbPanning.Value = 63
        '
        'LabelPanning
        '
        Me.LabelPanning.AutoSize = True
        Me.LabelPanning.Location = New System.Drawing.Point(568, 224)
        Me.LabelPanning.Name = "LabelPanning"
        Me.LabelPanning.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelPanning.Size = New System.Drawing.Size(65, 15)
        Me.LabelPanning.TabIndex = 45
        Me.LabelPanning.Text = "Panning:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(1086, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 22)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "16"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(857, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 22)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "8"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(657, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 22)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "1"
        '
        'tbChannel
        '
        Me.tbChannel.BackColor = System.Drawing.SystemColors.Control
        Me.tbChannel.LargeChange = 1
        Me.tbChannel.Location = New System.Drawing.Point(647, 153)
        Me.tbChannel.Maximum = 15
        Me.tbChannel.Name = "tbChannel"
        Me.tbChannel.Size = New System.Drawing.Size(464, 56)
        Me.tbChannel.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(567, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Channel:"
        '
        'cbInstrument
        '
        Me.cbInstrument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInstrument.Items.AddRange(New Object() {"0. Acoustic Grand Piano", "1. Bright Acoustic Piano", "2. Electric Grand Piano", "3. Honky-tonk Piano", "4. Rhodes Piano", "5. Chorused Piano", "6. Harpsichord", "7. Clarinet", "8. Celesta", "9. Glockenspiel", "10. Music Box", "11. Vibraphone", "12. Marimba", "13. Xylophone", "14. Tubular Bells", "15. Dulcimer", "16. Hammond Organ", "17. Percussive Organ", "18. Rock Organ", "19. Church Organ", "20. Reed Organ", "21. Accordion", "22. Harmonica", "23. Tango Accordion", "24. Acoustic Guitar (nylon)", "25. Acoustic Guitar (steel)", "26. Electric Guitar (jazz)", "27. Electric Guitar (clean)", "28. Electric Guitar (muted)", "29. Overdriven Guitar", "30. Distortion Guitar", "31. Guitar Harmonics", "32. Acoustic Bass", "33. Electric Bass (finger)", "34. Electric Bass (pick)", "35. Fretless Bass", "36. Slap Bass 1", "37. Slap Bass 2", "38. Synth Bass 1", "39. Synth Bass 2", "40. Violin", "41. Viola", "42. Cello", "43. Contrabass", "44. Tremolo Strings", "45. Pizzicato Strings", "46. Orchestral Harp", "47. Timpani", "48. String Ensemble 1", "49. String Ensemble 2", "50. SynthStrings 1", "51. SynthStrings 2", "52. Choir Aahs", "53. Voice Oohs", "54. Synth Voice", "55. Orchestra Hit", "56. Trumpet", "57. Trombone", "58. Tuba", "59. Muted Trumpet", "60. French Horn", "61. Brass Section", "62. Synth Brass 1", "63. Synth Brass 2", "64. Soprano Sax", "65. Alto Sax", "66. Tenor Sax", "67. Baritone Sax", "68. Oboe", "69. English Horn", "70. Bassoon", "71. Clarinet", "72. Piccolo", "73. Flute", "74. Recorder", "75. Pan Flute", "76. Bottle Blow", "77. Shakuhachi", "78. Whistle", "79. Ocarina", "80. Lead 1 (square)", "81. Lead 2 (sawtooth)", "82. Lead 3 (calliope lead)", "83. Lead 4 (chiff lead)", "84. Lead 5 (charang)", "85. Lead 6 (voice)", "86. Lead 7 (fifths)", "87. Lead 8 (bass + lead)", "88. Pad 1 (new age)", "89. Pad 2 (warm)", "90. Pad 3 (polysynth)", "91. Pad 4 (choir)", "92. Pad 5 (bowed)", "93. Pad 6 (metallic)", "94. Pad 7 (halo)", "95. Pad 8 (sweep)", "96. FX 1 (rain)", "97. FX 2 (soundtrack)", "98. FX 3 (crystal)", "99. FX 4 (atmosphere)", "100. FX 5 (brightness)", "101. FX 6 (goblins)", "102. FX 7 (echoes)", "103. FX 8 (sci-fi)", "104. Sitar", "105. Banjo", "106. Shamisen", "107. Koto", "108. Kalimba", "109. Bagpipe", "110. Fiddle", "111. Shanai", "112. Tinkle Bell", "113. Agogo", "114. Steel Drums", "115. Woodblock", "116. Taiko Drum", "117. Melodic Tom", "118. Synth Drum", "119. Reverse Cymbal", "120. Guitar Fret Noise", "121. Breath Noise", "122. Seashore", "123. Bird Tweet", "124. Telephone Ring", "125. Helicopter", "126. Applause", "127. Gunshot"})
        Me.cbInstrument.Location = New System.Drawing.Point(660, 108)
        Me.cbInstrument.Name = "cbInstrument"
        Me.cbInstrument.Size = New System.Drawing.Size(153, 23)
        Me.cbInstrument.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(554, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 22)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Instrument:"
        '
        'BtnPlayChord
        '
        Me.BtnPlayChord.Location = New System.Drawing.Point(300, 111)
        Me.BtnPlayChord.Name = "BtnPlayChord"
        Me.BtnPlayChord.Size = New System.Drawing.Size(173, 63)
        Me.BtnPlayChord.TabIndex = 22
        Me.BtnPlayChord.Text = "Play Chord"
        Me.BtnPlayChord.UseVisualStyleBackColor = True
        '
        'BtnPlayNote
        '
        Me.BtnPlayNote.Location = New System.Drawing.Point(91, 111)
        Me.BtnPlayNote.Name = "BtnPlayNote"
        Me.BtnPlayNote.Size = New System.Drawing.Size(173, 65)
        Me.BtnPlayNote.TabIndex = 21
        Me.BtnPlayNote.Text = "Play Note"
        Me.BtnPlayNote.UseVisualStyleBackColor = True
        '
        'tabSequencer
        '
        Me.tabSequencer.Controls.Add(Me.Label10)
        Me.tabSequencer.Controls.Add(Me.Label11)
        Me.tabSequencer.Controls.Add(Me.Label12)
        Me.tabSequencer.Controls.Add(Me.Label9)
        Me.tabSequencer.Controls.Add(Me.tbTranspose)
        Me.tabSequencer.Controls.Add(Me.btnLoad)
        Me.tabSequencer.Controls.Add(Me.btnLoop)
        Me.tabSequencer.Controls.Add(Me.btnAppend)
        Me.tabSequencer.Controls.Add(Me.btnRecord)
        Me.tabSequencer.Controls.Add(Me.btnStop)
        Me.tabSequencer.Controls.Add(Me.btnPlay)
        Me.tabSequencer.Controls.Add(Me.btnRemoveSilence)
        Me.tabSequencer.Location = New System.Drawing.Point(4, 25)
        Me.tabSequencer.Name = "tabSequencer"
        Me.tabSequencer.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSequencer.Size = New System.Drawing.Size(1299, 462)
        Me.tabSequencer.TabIndex = 0
        Me.tabSequencer.Text = "MIDI Sequencer"
        Me.tabSequencer.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(606, 260)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 32)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "+60"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(376, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 45)
        Me.Label11.TabIndex = 44
        Me.Label11.Text = "0"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(176, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 32)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "-60"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(60, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 15)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Transpose:"
        '
        'tbTranspose
        '
        Me.tbTranspose.LargeChange = 15
        Me.tbTranspose.Location = New System.Drawing.Point(179, 210)
        Me.tbTranspose.Maximum = 60
        Me.tbTranspose.Minimum = -60
        Me.tbTranspose.Name = "tbTranspose"
        Me.tbTranspose.Size = New System.Drawing.Size(477, 56)
        Me.tbTranspose.TabIndex = 31
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(505, 73)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(152, 34)
        Me.btnLoad.TabIndex = 30
        Me.btnLoad.Text = "Load MIDI"
        '
        'btnLoop
        '
        Me.btnLoop.Location = New System.Drawing.Point(343, 73)
        Me.btnLoop.Name = "btnLoop"
        Me.btnLoop.Size = New System.Drawing.Size(152, 34)
        Me.btnLoop.TabIndex = 29
        Me.btnLoop.Text = "Loop"
        '
        'btnAppend
        '
        Me.btnAppend.Location = New System.Drawing.Point(19, 73)
        Me.btnAppend.Name = "btnAppend"
        Me.btnAppend.Size = New System.Drawing.Size(152, 34)
        Me.btnAppend.TabIndex = 28
        Me.btnAppend.Text = "Append"
        '
        'btnRecord
        '
        Me.btnRecord.Location = New System.Drawing.Point(19, 17)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(152, 34)
        Me.btnRecord.TabIndex = 20
        Me.btnRecord.Text = "Record"
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(181, 17)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(152, 34)
        Me.btnStop.TabIndex = 21
        Me.btnStop.Text = "Stop"
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(343, 17)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(152, 34)
        Me.btnPlay.TabIndex = 22
        Me.btnPlay.Text = "Play"
        '
        'btnRemoveSilence
        '
        Me.btnRemoveSilence.Location = New System.Drawing.Point(504, 17)
        Me.btnRemoveSilence.Name = "btnRemoveSilence"
        Me.btnRemoveSilence.Size = New System.Drawing.Size(152, 34)
        Me.btnRemoveSilence.TabIndex = 23
        Me.btnRemoveSilence.Text = "Remove Silence"
        '
        'tabWhiteboard
        '
        Me.tabWhiteboard.Controls.Add(Me.gbxXAxis)
        Me.tabWhiteboard.Controls.Add(Me.picWhiteboard)
        Me.tabWhiteboard.Controls.Add(Me.gbxYAxis)
        Me.tabWhiteboard.Location = New System.Drawing.Point(4, 25)
        Me.tabWhiteboard.Name = "tabWhiteboard"
        Me.tabWhiteboard.Size = New System.Drawing.Size(1299, 462)
        Me.tabWhiteboard.TabIndex = 2
        Me.tabWhiteboard.Text = "MIDI Whiteboard"
        Me.tabWhiteboard.UseVisualStyleBackColor = True
        '
        'gbxXAxis
        '
        Me.gbxXAxis.Controls.Add(Me.lblXValue)
        Me.gbxXAxis.Controls.Add(Me.cboXTitle)
        Me.gbxXAxis.Controls.Add(Me.lblXTitle)
        Me.gbxXAxis.Controls.Add(Me.lblXCaption)
        Me.gbxXAxis.Location = New System.Drawing.Point(519, 17)
        Me.gbxXAxis.Name = "gbxXAxis"
        Me.gbxXAxis.Size = New System.Drawing.Size(232, 110)
        Me.gbxXAxis.TabIndex = 40
        Me.gbxXAxis.TabStop = False
        Me.gbxXAxis.Text = "X - axis"
        '
        'lblXValue
        '
        Me.lblXValue.Location = New System.Drawing.Point(77, 33)
        Me.lblXValue.Name = "lblXValue"
        Me.lblXValue.Size = New System.Drawing.Size(76, 22)
        Me.lblXValue.TabIndex = 38
        '
        'cboXTitle
        '
        Me.cboXTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboXTitle.Items.AddRange(New Object() {"(none)", "instrument", "velocity", "pitch", "stereo position", "pitch bend"})
        Me.cboXTitle.Location = New System.Drawing.Point(64, 67)
        Me.cboXTitle.Name = "cboXTitle"
        Me.cboXTitle.Size = New System.Drawing.Size(153, 23)
        Me.cboXTitle.TabIndex = 37
        '
        'lblXTitle
        '
        Me.lblXTitle.Location = New System.Drawing.Point(13, 71)
        Me.lblXTitle.Name = "lblXTitle"
        Me.lblXTitle.Size = New System.Drawing.Size(51, 22)
        Me.lblXTitle.TabIndex = 36
        Me.lblXTitle.Text = "Title:"
        '
        'lblXCaption
        '
        Me.lblXCaption.Location = New System.Drawing.Point(13, 33)
        Me.lblXCaption.Name = "lblXCaption"
        Me.lblXCaption.Size = New System.Drawing.Size(64, 22)
        Me.lblXCaption.TabIndex = 0
        Me.lblXCaption.Text = "Value:"
        '
        'picWhiteboard
        '
        Me.picWhiteboard.BackColor = System.Drawing.Color.White
        Me.picWhiteboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picWhiteboard.Location = New System.Drawing.Point(19, 17)
        Me.picWhiteboard.Name = "picWhiteboard"
        Me.picWhiteboard.Size = New System.Drawing.Size(480, 415)
        Me.picWhiteboard.TabIndex = 39
        Me.picWhiteboard.TabStop = False
        '
        'gbxYAxis
        '
        Me.gbxYAxis.Controls.Add(Me.cboYTitle)
        Me.gbxYAxis.Controls.Add(Me.lblYTitle)
        Me.gbxYAxis.Controls.Add(Me.lblYCaption)
        Me.gbxYAxis.Controls.Add(Me.lblYValue)
        Me.gbxYAxis.Location = New System.Drawing.Point(519, 144)
        Me.gbxYAxis.Name = "gbxYAxis"
        Me.gbxYAxis.Size = New System.Drawing.Size(232, 111)
        Me.gbxYAxis.TabIndex = 41
        Me.gbxYAxis.TabStop = False
        Me.gbxYAxis.Text = "Y - axis"
        '
        'cboYTitle
        '
        Me.cboYTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYTitle.Items.AddRange(New Object() {"(none)", "instrument", "velocity", "pitch", "stereo position", "pitch bend"})
        Me.cboYTitle.Location = New System.Drawing.Point(64, 67)
        Me.cboYTitle.Name = "cboYTitle"
        Me.cboYTitle.Size = New System.Drawing.Size(153, 23)
        Me.cboYTitle.TabIndex = 37
        '
        'lblYTitle
        '
        Me.lblYTitle.Location = New System.Drawing.Point(13, 71)
        Me.lblYTitle.Name = "lblYTitle"
        Me.lblYTitle.Size = New System.Drawing.Size(51, 22)
        Me.lblYTitle.TabIndex = 36
        Me.lblYTitle.Text = "Title:"
        '
        'lblYCaption
        '
        Me.lblYCaption.Location = New System.Drawing.Point(13, 33)
        Me.lblYCaption.Name = "lblYCaption"
        Me.lblYCaption.Size = New System.Drawing.Size(64, 22)
        Me.lblYCaption.TabIndex = 0
        Me.lblYCaption.Text = "Value:"
        '
        'lblYValue
        '
        Me.lblYValue.Location = New System.Drawing.Point(77, 33)
        Me.lblYValue.Name = "lblYValue"
        Me.lblYValue.Size = New System.Drawing.Size(76, 22)
        Me.lblYValue.TabIndex = 39
        '
        'tabDrumMachine
        '
        Me.tabDrumMachine.Controls.Add(Me.btnLoadDrum)
        Me.tabDrumMachine.Controls.Add(Me.btnDeleteColumn)
        Me.tabDrumMachine.Controls.Add(Me.btnDeleteRow)
        Me.tabDrumMachine.Controls.Add(Me.btnAddColumn)
        Me.tabDrumMachine.Controls.Add(Me.btnAddRow)
        Me.tabDrumMachine.Controls.Add(Me.btnResetDrum)
        Me.tabDrumMachine.Controls.Add(Me.btnInverseDrum)
        Me.tabDrumMachine.Controls.Add(Me.btnReverseDrum)
        Me.tabDrumMachine.Controls.Add(Me.Label13)
        Me.tabDrumMachine.Controls.Add(Me.Label14)
        Me.tabDrumMachine.Controls.Add(Me.cbDrum2)
        Me.tabDrumMachine.Controls.Add(Me.cbDrum1)
        Me.tabDrumMachine.Controls.Add(Me.btnRandomSelection)
        Me.tabDrumMachine.Controls.Add(Me.btnDrumStop)
        Me.tabDrumMachine.Controls.Add(Me.btnDrumStart)
        Me.tabDrumMachine.Controls.Add(Me.picDrum)
        Me.tabDrumMachine.Location = New System.Drawing.Point(4, 25)
        Me.tabDrumMachine.Name = "tabDrumMachine"
        Me.tabDrumMachine.Padding = New System.Windows.Forms.Padding(3)
        Me.tabDrumMachine.Size = New System.Drawing.Size(1299, 462)
        Me.tabDrumMachine.TabIndex = 1
        Me.tabDrumMachine.Text = "Drum Machine"
        Me.tabDrumMachine.UseVisualStyleBackColor = True
        '
        'btnLoadDrum
        '
        Me.btnLoadDrum.Location = New System.Drawing.Point(338, 101)
        Me.btnLoadDrum.Name = "btnLoadDrum"
        Me.btnLoadDrum.Size = New System.Drawing.Size(161, 34)
        Me.btnLoadDrum.TabIndex = 55
        Me.btnLoadDrum.Text = "Load Drum"
        '
        'btnDeleteColumn
        '
        Me.btnDeleteColumn.Location = New System.Drawing.Point(317, 181)
        Me.btnDeleteColumn.Name = "btnDeleteColumn"
        Me.btnDeleteColumn.Size = New System.Drawing.Size(124, 34)
        Me.btnDeleteColumn.TabIndex = 54
        Me.btnDeleteColumn.Text = "Delete Column"
        '
        'btnDeleteRow
        '
        Me.btnDeleteRow.Location = New System.Drawing.Point(110, 181)
        Me.btnDeleteRow.Name = "btnDeleteRow"
        Me.btnDeleteRow.Size = New System.Drawing.Size(100, 34)
        Me.btnDeleteRow.TabIndex = 53
        Me.btnDeleteRow.Text = "Delete Row"
        '
        'btnAddColumn
        '
        Me.btnAddColumn.Location = New System.Drawing.Point(211, 181)
        Me.btnAddColumn.Name = "btnAddColumn"
        Me.btnAddColumn.Size = New System.Drawing.Size(105, 34)
        Me.btnAddColumn.TabIndex = 51
        Me.btnAddColumn.Text = "Add Column"
        '
        'btnAddRow
        '
        Me.btnAddRow.Location = New System.Drawing.Point(19, 181)
        Me.btnAddRow.Name = "btnAddRow"
        Me.btnAddRow.Size = New System.Drawing.Size(90, 34)
        Me.btnAddRow.TabIndex = 50
        Me.btnAddRow.Text = "Add Row"
        '
        'btnResetDrum
        '
        Me.btnResetDrum.Location = New System.Drawing.Point(442, 181)
        Me.btnResetDrum.Name = "btnResetDrum"
        Me.btnResetDrum.Size = New System.Drawing.Size(57, 34)
        Me.btnResetDrum.TabIndex = 49
        Me.btnResetDrum.Text = "Reset"
        '
        'btnInverseDrum
        '
        Me.btnInverseDrum.Location = New System.Drawing.Point(177, 141)
        Me.btnInverseDrum.Name = "btnInverseDrum"
        Me.btnInverseDrum.Size = New System.Drawing.Size(152, 34)
        Me.btnInverseDrum.TabIndex = 48
        Me.btnInverseDrum.Text = "Inverse Selection"
        '
        'btnReverseDrum
        '
        Me.btnReverseDrum.Location = New System.Drawing.Point(19, 141)
        Me.btnReverseDrum.Name = "btnReverseDrum"
        Me.btnReverseDrum.Size = New System.Drawing.Size(152, 34)
        Me.btnReverseDrum.TabIndex = 47
        Me.btnReverseDrum.Text = "Reverse Selection"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1009, 66)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Drum 2:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1009, 29)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 15)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Drum 1: "
        '
        'cbDrum2
        '
        Me.cbDrum2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDrum2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbDrum2.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        Me.cbDrum2.Location = New System.Drawing.Point(1076, 63)
        Me.cbDrum2.Name = "cbDrum2"
        Me.cbDrum2.Size = New System.Drawing.Size(149, 23)
        Me.cbDrum2.Sorted = True
        Me.cbDrum2.TabIndex = 31
        Me.cbDrum2.Tag = ""
        '
        'cbDrum1
        '
        Me.cbDrum1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDrum1.FormattingEnabled = True
        Me.cbDrum1.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        Me.cbDrum1.Location = New System.Drawing.Point(1076, 26)
        Me.cbDrum1.Name = "cbDrum1"
        Me.cbDrum1.Size = New System.Drawing.Size(149, 23)
        Me.cbDrum1.Sorted = True
        Me.cbDrum1.TabIndex = 30
        '
        'btnRandomSelection
        '
        Me.btnRandomSelection.Location = New System.Drawing.Point(338, 141)
        Me.btnRandomSelection.Name = "btnRandomSelection"
        Me.btnRandomSelection.Size = New System.Drawing.Size(161, 34)
        Me.btnRandomSelection.TabIndex = 28
        Me.btnRandomSelection.Text = "Random Selection"
        '
        'btnDrumStop
        '
        Me.btnDrumStop.Location = New System.Drawing.Point(177, 101)
        Me.btnDrumStop.Name = "btnDrumStop"
        Me.btnDrumStop.Size = New System.Drawing.Size(152, 34)
        Me.btnDrumStop.TabIndex = 27
        Me.btnDrumStop.Text = "Stop Drum"
        '
        'btnDrumStart
        '
        Me.btnDrumStart.Location = New System.Drawing.Point(19, 101)
        Me.btnDrumStart.Name = "btnDrumStart"
        Me.btnDrumStart.Size = New System.Drawing.Size(152, 34)
        Me.btnDrumStart.TabIndex = 26
        Me.btnDrumStart.Text = "Start Drum"
        '
        'picDrum
        '
        Me.picDrum.BackColor = System.Drawing.SystemColors.Window
        Me.picDrum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDrum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picDrum.Location = New System.Drawing.Point(19, 17)
        Me.picDrum.Name = "picDrum"
        Me.picDrum.Size = New System.Drawing.Size(968, 78)
        Me.picDrum.TabIndex = 25
        Me.picDrum.TabStop = False
        '
        'tmrDrumPlayback
        '
        Me.tmrDrumPlayback.Interval = 250
        '
        'frmMidiPiano
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 18)
        Me.ClientSize = New System.Drawing.Size(1338, 725)
        Me.Controls.Add(Me.vsbVolume)
        Me.Controls.Add(Me._key_15)
        Me.Controls.Add(Me._key_13)
        Me.Controls.Add(Me._key_10)
        Me.Controls.Add(Me._key_8)
        Me.Controls.Add(Me._key_6)
        Me.Controls.Add(Me._key_3)
        Me.Controls.Add(Me._key_1)
        Me.Controls.Add(Me._key_16)
        Me.Controls.Add(Me._key_14)
        Me.Controls.Add(Me._key_12)
        Me.Controls.Add(Me._key_11)
        Me.Controls.Add(Me._key_9)
        Me.Controls.Add(Me._key_7)
        Me.Controls.Add(Me._key_5)
        Me.Controls.Add(Me._key_4)
        Me.Controls.Add(Me._key_2)
        Me.Controls.Add(Me._key_0)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.tclMidiFunction)
        Me.Controls.Add(Me.gbxInstrument)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(11, 49)
        Me.Menu = Me.mnuMain
        Me.Name = "frmMidiPiano"
        Me.Text = "VB Midi Piano"
        Me.gbxInstrument.ResumeLayout(False)
        Me.gbxInstrument.PerformLayout()
        CType(Me.tbSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbBankMSB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tclMidiFunction.ResumeLayout(False)
        Me.tabBasics.ResumeLayout(False)
        Me.tabBasics.PerformLayout()
        CType(Me.tbPanning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbChannel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSequencer.ResumeLayout(False)
        Me.tabSequencer.PerformLayout()
        CType(Me.tbTranspose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabWhiteboard.ResumeLayout(False)
        Me.gbxXAxis.ResumeLayout(False)
        CType(Me.picWhiteboard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxYAxis.ResumeLayout(False)
        Me.tabDrumMachine.ResumeLayout(False)
        Me.tabDrumMachine.PerformLayout()
        CType(Me.picDrum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Public Class ChannelData
        Public instrument_m As Integer    ' Instrument value
        Public panning_m As Integer       ' Panning value
        Public bank_m As Integer          ' Bank value

        ' constructor
        Public Sub New()
            instrument_m = 0
            panning_m = 63
            bank_m = 0
        End Sub
    End Class

#Region "frmMidiPiano Members"
    Const INVALID_NOTE As Short = -1 ' Code for keyboard keys that we don't handle

    Dim numDevices As Integer ' number of midi output devices
    Dim curDevice As Integer ' current midi device
    Dim hmidi As Integer ' midi output handle
    Dim rc As Integer ' return code
    Dim midimsg As Integer ' midi output message buffer
    Dim channel As Short ' midi output channel
    Dim volume As Short ' midi volume
    Dim baseNote As Short ' the first note on our "piano"
    Dim playChord As Boolean
    Dim speed As Double = 1

    Dim key As CheckBoxArray ' an array of check box for keys
    Dim chan As MenuItemArray ' an array of menu item for channel
    Dim device As MenuItemArray ' an array of menu item for midi device

    ' for channel
    Dim channel_data(15) As ChannelData ' channel data array to store channel

    ' for recording
    Dim isRecording As Boolean ' recording status
    Dim isAppending As Boolean ' appending status
    Dim isLoop As Boolean ' loop status
    Dim isTranspose As Boolean ' transpose status
    Dim startTime As System.DateTime ' the time of starting recording
    Dim appendTime As System.DateTime ' the time of starting recording
    Dim endTime As System.DateTime ' the time of end of recording 
    Dim midiSequence As SequenceData ' store MIDI sequence
    Dim currentIndex As Integer ' store the current playing sequence index

    ' for MIDI whiteboard
    Dim lastMidiMessage As Integer = -1 ' previous MIDI message sent to the card
    Dim cbXselected As Short = 0 ' selection of the X axis
    Dim cbYselected As Short = 3 ' selection of the Y axis

    ' for drum machine
    Dim DRUM_INSTRUMENT As Short = 2
    Dim DRUM_SLOT As Short = 8
    Dim rowCount As Integer = 2
    Dim colCount As Integer = 8
    Dim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT) As Boolean ' Slot On/Off for the drum machine
    Dim drumNumber(DRUM_INSTRUMENT) As Short ' The instrument for the drums
    Dim drumMessageSent(DRUM_INSTRUMENT) As Boolean ' True if a note-on midi message for a drum is sent
    Dim prevInterval As Integer
    Dim listCb(5) As System.Windows.Forms.ComboBox
    Dim cbCount As Integer = 0
    Dim listLbl(5) As System.Windows.Forms.Label
    Dim lblCount As Integer = 0
    Dim ignoreEvent As Boolean = False
#End Region


#Region "function initControlArray()"


    Public Sub initControlArray()
        ' initialize key checkboxarray (not generated by vb)
        key = New CheckBoxArray

        AddHandler _key_0.MouseDown, AddressOf key_MouseDown
        AddHandler _key_0.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_0)

        AddHandler _key_1.MouseDown, AddressOf key_MouseDown
        AddHandler _key_1.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_1)

        AddHandler _key_2.MouseDown, AddressOf key_MouseDown
        AddHandler _key_2.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_2)

        AddHandler _key_3.MouseDown, AddressOf key_MouseDown
        AddHandler _key_3.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_3)

        AddHandler _key_4.MouseDown, AddressOf key_MouseDown
        AddHandler _key_4.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_4)

        AddHandler _key_5.MouseDown, AddressOf key_MouseDown
        AddHandler _key_5.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_5)

        AddHandler _key_6.MouseDown, AddressOf key_MouseDown
        AddHandler _key_6.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_6)

        AddHandler _key_7.MouseDown, AddressOf key_MouseDown
        AddHandler _key_7.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_7)

        AddHandler _key_8.MouseDown, AddressOf key_MouseDown
        AddHandler _key_8.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_8)

        AddHandler _key_9.MouseDown, AddressOf key_MouseDown
        AddHandler _key_9.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_9)

        AddHandler _key_10.MouseDown, AddressOf key_MouseDown
        AddHandler _key_10.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_10)

        AddHandler _key_11.MouseDown, AddressOf key_MouseDown
        AddHandler _key_11.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_11)

        AddHandler _key_12.MouseDown, AddressOf key_MouseDown
        AddHandler _key_12.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_12)

        AddHandler _key_13.MouseDown, AddressOf key_MouseDown
        AddHandler _key_13.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_13)

        AddHandler _key_14.MouseDown, AddressOf key_MouseDown
        AddHandler _key_14.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_14)

        AddHandler _key_15.MouseDown, AddressOf key_MouseDown
        AddHandler _key_15.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_15)

        AddHandler _key_16.MouseDown, AddressOf key_MouseDown
        AddHandler _key_16.MouseUp, AddressOf key_MouseUp
        key.AddNewCheckBox(_key_16)

        ' initialize channel menuitemarray (not generated by vb)
        chan = New MenuItemArray
        AddHandler mnuChannel0.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel0)

        AddHandler mnuChannel1.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel1)

        AddHandler mnuChannel2.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel2)

        AddHandler mnuChannel3.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel3)

        AddHandler mnuChannel4.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel4)

        AddHandler mnuChannel5.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel5)

        AddHandler mnuChannel6.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel6)

        AddHandler mnuChannel7.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel7)

        AddHandler mnuChannel8.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel8)

        AddHandler mnuChannel9.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel9)

        AddHandler mnuChannel10.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel10)

        AddHandler mnuChannel11.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel11)

        AddHandler mnuChannel12.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel12)

        AddHandler mnuChannel13.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel13)

        AddHandler mnuChannel14.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel14)

        AddHandler mnuChannel15.Click, AddressOf chan_Click
        chan.AddNewMenuItem(mnuChannel15)

        ' initialize device menuitemarray (not generated by vb)
        device = New MenuItemArray

        AddHandler mnuDevice0.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice0)

        AddHandler mnuDevice1.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice1)

        AddHandler mnuDevice2.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice2)

        AddHandler mnuDevice3.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice3)

        AddHandler mnuDevice4.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice4)

        AddHandler mnuDevice5.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice5)

        AddHandler mnuDevice6.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice6)

        AddHandler mnuDevice7.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice7)

        AddHandler mnuDevice8.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice8)

        AddHandler mnuDevice9.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice9)

        AddHandler mnuDevice10.Click, AddressOf device_Click
        device.AddNewMenuItem(mnuDevice10)
    End Sub
#End Region

    ' Set the value for the starting note of the piano
    Public Sub base_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBaseNote.Click
        Dim s As String
        Dim i As Short
        s = InputBox("Enter the new base note for the keyboard (0 - 111)", "Base note", CStr(baseNote))
        If IsNumeric(s) Then
            i = CShort(s)
            If i >= 0 And i < 112 Then
                baseNote = i
            End If
        End If
    End Sub

    ' Select the midi output channel
    Public Sub chan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.MenuItem).Index
        chan(channel).Checked = False
        channel = index
        tbChannel.Value = channel ' channel slider
        tbBankMSB.Value = channel_data(channel).bank_m
        tbInstrument.Value = channel_data(channel).instrument_m
        cbInstrument.SelectedIndex = tbInstrument.Value
        tbPanning.Value = channel_data(channel).panning_m
        chan(channel).Checked = True
    End Sub

    ' Open the midi device selected in the menu. The menu index equals the midi device number + 1.
    Public Sub device_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.MenuItem).Index
        device(curDevice + 1).Checked = False
        device(index).Checked = True
        curDevice = index - 1
        rc = midiOutClose(hmidi)
        rc = midiOutOpen(hmidi, curDevice, 0, 0, 0)
        If rc <> 0 Then
            MessageBox.Show("Couldn't open midi out, rc = " & rc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' If user presses a keyboard key, start the corresponding midi note
    Private Sub frmMidiPiano_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim KeyCode As Short = e.KeyCode

        StartNote(NoteFromKey(KeyCode))
    End Sub

    ' If user lifts a keyboard key, stop the corresponding midi note
    Private Sub frmMidiPiano_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Dim KeyCode As Short = e.KeyCode

        StopNote(NoteFromKey(KeyCode))
    End Sub

    Private Sub frmMidiPiano_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        Dim caps As MIDIOUTCAPS

        Try
            initControlArray()

            ' Set the first device as midi mapper
            device(0).Text = "MIDI Mapper"
            device(0).Visible = True
            device(0).Enabled = True

            ' Get the rest of the midi devices
            numDevices = midiOutGetNumDevs()
            For i = 0 To (numDevices - 1)
                midiOutGetDevCaps(i, caps, Len(caps))
                device(i + 1).Text = caps.szPname
                device(i + 1).Visible = True
                device(i + 1).Enabled = True
            Next

            ' Select the MIDI Mapper as the default device
            device_Click(device.Item(0), New System.EventArgs)

            ' Set the default channel
            channel = 0
            chan(channel).Checked = True

            ' Set the base note
            baseNote = 60

            ' Set volume range
            volume = 127
            vsbVolume.Value = vsbVolume.Maximum - volume

            midiSequence = Nothing
            isRecording = False

            cboXTitle.SelectedIndex = cbXselected
            cboYTitle.SelectedIndex = cbYselected

            'MIDI Basics Default
            cbInstrument.SelectedIndex = 0
            cbChord.SelectedIndex = 0
            cbChord.Enabled = False
            playChord = False

            'MIDI Sequencer Default
            btnPlay.Enabled = False
            btnRemoveSilence.Enabled = False
            btnLoop.Enabled = False
            btnAppend.Enabled = False
            isLoop = False
            isAppending = False

            ' Drum Machine Default
            btnDrumStop.Enabled = False
            drumNumber(1) = 60
            drumNumber(2) = 61
            cbDrum1.SelectedIndex = 25 ' Initialize cb index to 25
            cbDrum2.SelectedIndex = 26

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMidiPiano_Closed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        ' Close current midi device
        rc = midiOutClose(hmidi)
    End Sub

    ' Start a note when user click on it
    Public Sub key_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.CheckBox).Tag
        StartNote(index)
    End Sub

    ' Stop the note when user lifts the mouse button
    Public Sub key_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim index As Integer
        index = CType(sender, System.Windows.Forms.CheckBox).Tag
        StopNote(index)
    End Sub

    ' Press the button and send midi start event
    Private Sub StartNote(ByRef Index As Short)
        If Index = INVALID_NOTE Then
            Exit Sub
        End If
        If key(Index).CheckState = 1 Then
            Exit Sub
        End If

        key(Index).CheckState = System.Windows.Forms.CheckState.Checked
        midimsg = &H90 + ((baseNote + Index) * &H100) + (volume * &H10000) + channel
        sendMidiMsg(hmidi, midimsg)

        If playChord Then
            If (cbChord.SelectedIndex = 0) Then 'Major
                midimsg = &H90 + ((baseNote + Index + 4) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 7) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            ElseIf (cbChord.SelectedIndex = 1) Then 'Minor
                midimsg = &H90 + ((baseNote + Index + 3) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 7) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            ElseIf (cbChord.SelectedIndex = 2) Then 'Dominant 7th
                midimsg = &H90 + ((baseNote + Index + 4) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 7) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 10) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            ElseIf (cbChord.SelectedIndex = 3) Then 'Augmented 7th
                midimsg = &H90 + ((baseNote + Index + 4) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 8) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H90 + ((baseNote + Index + 11) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            End If
        End If
    End Sub

    ' Raise the button and send midi stop event
    Private Sub StopNote(ByRef Index As Short)
        If Index = INVALID_NOTE Then
            Exit Sub
        End If

        key(Index).CheckState = System.Windows.Forms.CheckState.Unchecked
        midimsg = &H80 + ((baseNote + Index + tbTranspose.Value) * &H100) + (volume * &H10000) + channel
        sendMidiMsg(hmidi, midimsg)

        If playChord Then
            If (cbChord.SelectedIndex = 0) Then 'Major
                midimsg = &H80 + ((baseNote + Index + 4) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 7) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            ElseIf (cbChord.SelectedIndex = 1) Then 'Minor
                midimsg = &H80 + ((baseNote + Index + 3) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 7) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            ElseIf (cbChord.SelectedIndex = 2) Then 'Dominant 7th
                midimsg = &H80 + ((baseNote + Index + 4) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 7) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 10) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            ElseIf (cbChord.SelectedIndex = 3) Then 'Augmented 7th
                midimsg = &H80 + ((baseNote + Index + 4) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 8) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
                midimsg = &H80 + ((baseNote + Index + 11) * &H100) + (volume * &H10000) + channel
                sendMidiMsg(hmidi, midimsg)
            End If
        End If
    End Sub

    ' Get the note corresponding to a keyboard key
    Private Function NoteFromKey(ByRef key As Short) As Short

        NoteFromKey = INVALID_NOTE

        Select Case key
            Case System.Windows.Forms.Keys.Z
                NoteFromKey = 0
            Case System.Windows.Forms.Keys.S
                NoteFromKey = 1
            Case System.Windows.Forms.Keys.X
                NoteFromKey = 2
            Case System.Windows.Forms.Keys.D
                NoteFromKey = 3
            Case System.Windows.Forms.Keys.C
                NoteFromKey = 4
            Case System.Windows.Forms.Keys.V
                NoteFromKey = 5
            Case System.Windows.Forms.Keys.G
                NoteFromKey = 6
            Case System.Windows.Forms.Keys.B
                NoteFromKey = 7
            Case System.Windows.Forms.Keys.H
                NoteFromKey = 8
            Case System.Windows.Forms.Keys.N
                NoteFromKey = 9
            Case System.Windows.Forms.Keys.J
                NoteFromKey = 10
            Case System.Windows.Forms.Keys.M
                NoteFromKey = 11
            Case 188 ' comma
                NoteFromKey = 12
            Case System.Windows.Forms.Keys.L
                NoteFromKey = 13
            Case 190 ' period
                NoteFromKey = 14
            Case 186 ' semicolon
                NoteFromKey = 15
            Case 191 ' forward slash
                NoteFromKey = 16
        End Select

    End Function

    ' Set the volume
    Private Sub vsbVolume_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles vsbVolume.Scroll
        Select Case e.Type
            Case System.Windows.Forms.ScrollEventType.EndScroll
                volume = vsbVolume.Maximum - e.NewValue
        End Select
    End Sub

    '
    '
    '''''''''''''''''''''''''''''''''''''''''MIDI Basics'''''''''''''''''''''''''''''''''''''''''
    '
    '

    ' Change the instrument by sending a program change message
    Private Sub tbInstrument_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbInstrument.ValueChanged
        ' Send a program change message for the instrument
        midimsg = &HC0 + (tbInstrument.Value * &H100) + channel
        sendMidiMsg(hmidi, midimsg)

        'store the instrument value in channel
        channel_data(channel).instrument_m = tbInstrument.Value
    End Sub

    Private Sub cbInstrument_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbInstrument.SelectedIndexChanged
        ' Send a program change message for the instrument
        tbInstrument.Value = cbInstrument.SelectedIndex

        midimsg = &HC0 + (cbInstrument.SelectedIndex * &H100) + channel
        sendMidiMsg(hmidi, midimsg)

        'store the instrument value in channel
        channel_data(channel).instrument_m = tbInstrument.Value
    End Sub

    Private Sub tbBankMSB_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbBankMSB.ValueChanged
        ' Send a control change message to change the bank
        midimsg = &HB0 + channel + (&H0 * &H100) + (tbBankMSB.Value * &H10000)
        sendMidiMsg(hmidi, midimsg)

        ' Resend a program change message for the instrument so that it comes into effect immediately
        midimsg = &HC0 + (tbInstrument.Value * &H100) + channel
        sendMidiMsg(hmidi, midimsg)

        'store the bank value in channel
        channel_data(channel).bank_m = tbBankMSB.Value
    End Sub

    Private Sub BtnPlayChord_Click(sender As Object, e As EventArgs) Handles BtnPlayChord.Click
        playChord = True
        cbChord.Enabled = True
    End Sub

    Private Sub BtnPlayNote_Click(sender As Object, e As EventArgs) Handles BtnPlayNote.Click
        playChord = False
        cbChord.Enabled = False
    End Sub

    Private Sub tbChannel_ValueChanged(sender As Object, e As EventArgs) Handles tbChannel.ValueChanged
        chan(channel).Checked = False
        channel = tbChannel.Value
        chan(channel).Checked = True
        tbBankMSB.Value = channel_data(channel).bank_m
        tbInstrument.Value = channel_data(channel).instrument_m
        cbInstrument.SelectedIndex = tbInstrument.Value
        tbPanning.Value = channel_data(channel).panning_m
    End Sub

    Private Sub tbPanning_ValueChanged(sender As Object, e As EventArgs) Handles tbPanning.ValueChanged
        midimsg = &HB0 + channel + (&HA * &H100) + (tbPanning.Value * &H10000)
        sendMidiMsg(hmidi, midimsg)

        'store the panning value in channel
        channel_data(channel).panning_m = tbPanning.Value
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim i As Integer
        For i = 0 To 15
            midimsg = &HB0 + i + (&H7B * &H100) ' all notes off msg
            sendMidiMsg(hmidi, midimsg)

            channel_data(i).bank_m = 0
            midimsg = &HB0 + i + (&H0 * &H100) + (channel_data(i).bank_m * &H10000)
            sendMidiMsg(hmidi, midimsg)

            midimsg = &HC0 + (tbInstrument.Value * &H100) + i
            sendMidiMsg(hmidi, midimsg)

            channel_data(i).instrument_m = 0
            midimsg = &HC0 + (channel_data(i).instrument_m * &H100) + i
            sendMidiMsg(hmidi, midimsg)

            channel_data(i).panning_m = 63
            midimsg = &HB0 + i + (&HA * &H100) + (channel_data(i).panning_m * &H10000)
            sendMidiMsg(hmidi, midimsg)

            tbBankMSB.Value = channel_data(channel).bank_m
            tbInstrument.Value = channel_data(channel).instrument_m
            cbInstrument.SelectedIndex = tbInstrument.Value
            tbPanning.Value = channel_data(channel).panning_m
        Next
    End Sub

    '
    '
    '''''''''''''''''''''''''''''''''''''''''MIDI Sequencer'''''''''''''''''''''''''''''''''''''''''
    '
    '

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        ' 2.1 Start recording a MIDI sequence
        ' Initialize the sequence data
        isRecording = True                 ' set the recording flag
        startTime = DateTime.Now           ' remember the time when recording starts

        ' the following two lines reset the midiSequence object
        midiSequence = Nothing             ' dump the midiSequence object
        midiSequence = New SequenceData    ' create a new midiSequence object

        ' Send the messages for the instrument so that the playback will match
        sendMidiMsg(hmidi, midimsg)

        btnRecord.Enabled = False
        btnPlay.Enabled = False
        btnStop.Enabled = True
        btnRemoveSilence.Enabled = False
        btnAppend.Enabled = False
        btnLoop.Enabled = False
        btnLoad.Enabled = False
    End Sub

    ' Stop recording MIDI sequence
    Private Sub btnStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStop.Click
        ' All notes off
        midimsg = &HB07B00 + channel ' all notes off msg to prevent stuck notes
        sendMidiMsg(hmidi, midimsg)

        ' 2.2 Stop recording a MIDI sequence
        ' Stop the recording
        isRecording = False
        isAppending = False
        isLoop = False

        ' 2.3 Play a MIDI sequence
        ' Stop the playback
        tmrSequencer.Enabled = False

        btnRecord.Enabled = True
        btnPlay.Enabled = True
        btnStop.Enabled = False
        btnRemoveSilence.Enabled = True
        btnAppend.Enabled = True
        btnLoop.Enabled = True
        btnLoad.Enabled = True
        tbSpeed.Enabled = True
    End Sub

    ' Play the MIDI sequence recorded
    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        If midiSequence Is Nothing Then
            Exit Sub
        End If

        ' 2.3 Play a MIDI sequence
        currentIndex = 0 ' Store the current index of the MIDI msg

        ' Start the timer using the time of the first sequencer message data
        Dim cur As Integer = CInt(midiSequence.data(0).time.TotalMilliseconds + 1) * speed
        tmrSequencer.Interval = IIf(cur < 1, 1, cur) ' Handling cases when interval becomes smaller then 1

        tmrSequencer.Enabled = True

        btnRecord.Enabled = False
        btnPlay.Enabled = False
        btnStop.Enabled = True
        btnRemoveSilence.Enabled = False
        btnAppend.Enabled = False
        btnLoop.Enabled = False
        btnLoad.Enabled = False
        tbSpeed.Enabled = False
    End Sub

    Private Sub tmrSequencer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrSequencer.Tick
        ' 2.3 Play a MIDI sequence
        ' Send the MIDI message of the current message and schedule the next one
        ' Stop the timer from running
        tmrSequencer.Enabled = False

        ' Consume all sequence data which is on time
        Dim currentTime As Double = midiSequence.data(currentIndex).time.TotalMilliseconds

        While currentTime >= midiSequence.data(currentIndex).time.TotalMilliseconds
            sendMidiMsg(hmidi, midiSequence.data(currentIndex).midiMsg)
            currentIndex += 1
            If currentIndex = midiSequence.dataLength Then
                Exit While
            End If
        End While

        If currentIndex < midiSequence.dataLength Then
            Dim cur As Integer
            cur = CInt((midiSequence.data(currentIndex).time.TotalMilliseconds - currentTime) + 1) * speed
            tmrSequencer.Interval = IIf(cur < 1, 1, cur) ' Handling cases when interval becomes smaller then 1
            tmrSequencer.Enabled = True
        ElseIf isLoop Then
            currentIndex = 0
            Dim cur As Integer
            cur = CInt((midiSequence.data(currentIndex).time.TotalMilliseconds - currentTime) + 1) * speed
            tmrSequencer.Interval = IIf(cur < 1, 1, cur) ' Handling cases when interval becomes smaller then 1
            tmrSequencer.Enabled = True
        Else
            btnRecord.Enabled = True
            btnPlay.Enabled = True
            btnStop.Enabled = False
            btnRemoveSilence.Enabled = True
            btnAppend.Enabled = True
            btnLoop.Enabled = True
            btnLoad.Enabled = True
            tbSpeed.Enabled = True
        End If
    End Sub

    ' Send a MIDI message and store the message
    Private Sub sendMidiMsg(ByVal hMidiOut As Integer, ByVal dwMsg As Integer)
        ' Send a MIDI message
        midiOutShortMsg(hMidiOut, dwMsg)

        ' 2.1 Start recording a MIDI sequence
        ' Store the message
        If isRecording Then
            If isAppending Then
                Dim curTime As TimeSpan = DateTime.Now.Subtract(appendTime)
                midiSequence.AddSequenceData(dwMsg, endTime - startTime + curTime)
            Else
                midiSequence.AddSequenceData(dwMsg, DateTime.Now.Subtract(startTime))
            End If
        End If

    End Sub

    Private Sub tbSpeed_Scroll(sender As Object, e As EventArgs) Handles tbSpeed.Scroll
        If tbSpeed.Value > 0 Then
            speed = 1 - tbSpeed.Value / 10.0
        Else
            speed = 1 - tbSpeed.Value / 10.0
        End If
    End Sub

    Private Sub btnRemoveSilence_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveSilence.Click
        If midiSequence Is Nothing Then
            Exit Sub
        End If

        ' 3.1 Remove silence at the start
        currentIndex = 0
        Dim bitMask As Short = &HF0
        Dim maskedData As Short = bitMask And midiSequence.data(currentIndex).midiMsg

        While maskedData <> &H90 And currentIndex < midiSequence.dataLength
            If currentIndex < midiSequence.dataLength - 1 Then
                currentIndex += 1
                maskedData = bitMask And midiSequence.data(currentIndex).midiMsg
            Else
                Exit While
            End If
        End While

        Dim t As System.TimeSpan = midiSequence.data(currentIndex).time 'save current interval from beginning
        Dim i As Integer
        For i = currentIndex To midiSequence.dataLength - 1
            midiSequence.data(i - currentIndex) = midiSequence.data(i) 'shift
            midiSequence.data(i - currentIndex).time -= t 'restore the interval
        Next i

        ReDim Preserve midiSequence.data(midiSequence.dataLength - currentIndex - 1)
        midiSequence.dataLength = midiSequence.dataLength - currentIndex
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim dlg As New OpenFileDialog
        Dim midiFile As MIDIFile
        Dim midiSequences() As SequenceData

        midiSequence = Nothing             ' dump the midiSequence object
        midiSequence = New SequenceData    ' create a new midiSequence object

        ' Ask for the MIDI file
        dlg.DefaultExt = "mid"
        dlg.Filter = "MIDI files (*.mid)|*.mid"
        dlg.Multiselect = False

        If dlg.ShowDialog() = DialogResult.OK Then
            ' Load the file into the MIDIFile structure
            midiFile = New MIDIFile(dlg.FileName)

            ' Convert the MIDI file into the SequenceData memory structure
            midiSequences = midiFile.ConvertToSequence()
            If midiSequences.Length > 0 Then
                ' Here the first track of the MIDI file is set into the sequencer memory
                midiSequence = midiSequences(0)
            End If
        End If
    End Sub

    Private Sub btnLoop_Click(sender As Object, e As EventArgs) Handles btnLoop.Click
        isLoop = True
    End Sub

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        ' 2.1 Start recording a MIDI sequence
        ' Initialize the sequence data
        isAppending = True ' set the appending flag
        isRecording = True ' set the recording flag

        appendTime = DateTime.Now
        endTime = startTime + midiSequence.data(midiSequence.dataLength - 1).time

        ' Send the messages for the instrument so that the playback will match
        sendMidiMsg(hmidi, midimsg)

        btnRecord.Enabled = False
        btnPlay.Enabled = False
        btnStop.Enabled = True
        btnRemoveSilence.Enabled = False
        btnAppend.Enabled = False
        btnLoop.Enabled = False
        btnLoad.Enabled = False
    End Sub

    Private Sub mnuOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOpen.Click
        Dim dlg As New OpenFileDialog
        Dim midiFile As MIDIFile
        Dim midiSequences() As SequenceData

        ' Ask for the MIDI file
        dlg.DefaultExt = "mid"
        dlg.Filter = "MIDI files (*.mid)|*.mid"
        dlg.Multiselect = False

        If dlg.ShowDialog() = DialogResult.OK Then
            ' Load the file into the MIDIFile structure
            midiFile = New MIDIFile(dlg.FileName)

            ' Convert the MIDI file into the SequenceData memory structure
            midiSequences = midiFile.ConvertToSequence()
            If midiSequences.Length > 0 Then
                ' Here the first track of the MIDI file is set into the sequencer memory
                midiSequence = midiSequences(0)
            End If
        End If
    End Sub

    Private Sub tbTranspose_ValueChanged(sender As Object, e As EventArgs) Handles tbTranspose.ValueChanged
        If Not midiSequence Is Nothing Then
            Dim i As Integer
            For i = 0 To midiSequence.dataLength - 1
                Dim bitMask As Short = &HE0 ' check for note on or off
                Dim maskedData As Short = bitMask And midiSequence.data(i).midiMsg
                If maskedData = &H90 Or maskedData = &H80 Then
                    Dim checkMidi As Integer = (midiSequence.data(i).midiMsg - volume * &H10000) / &H100 + tbTranspose.Value
                    If checkMidi > 127 Then
                        midiSequence.data(i).midiMsg += (127 - (checkMidi - tbTranspose.Value)) * &H100
                    ElseIf checkMidi < 0 Then
                        midiSequence.data(i).midiMsg += 0 * &H100
                    Else
                        midiSequence.data(i).midiMsg += tbTranspose.Value * &H100
                    End If
                End If
            Next i
        End If
    End Sub

    '
    '
    '''''''''''''''''''''''''''''''''''''''''MIDI Whiteboard'''''''''''''''''''''''''''''''''''''''''
    '
    '

    Private Function sendMsgForWhiteboard(ByVal x As Double, ByVal y As Double) As Integer
        Dim pitch As Integer
        Dim panning As Integer
        Dim pitchbend As Integer
        Dim lsb As Short
        Dim msb As Short

        ' Instrument is selected
        If cbXselected = 1 Or cbYselected = 1 Then
            tbInstrument.Value = IIf(cbXselected = 1, x * 127, y * 127)
            If cbXselected = 1 Then
                lblXValue.Text = tbInstrument.Value
            Else
                lblYValue.Text = tbInstrument.Value
            End If
            midimsg = &HC0 + channel + (tbInstrument.Value * &H100)
            sendMidiMsg(hmidi, midimsg)
        End If

        ' Velocity is selected
        If cbXselected = 2 Or cbYselected = 2 Then
            volume = IIf(cbXselected = 2, x * 127, y * 127)
            If cbXselected = 2 Then
                vsbVolume.Value = 127 - volume
                lblXValue.Text = 127 - vsbVolume.Value
            Else
                vsbVolume.Value = volume
                lblYValue.Text = 127 - vsbVolume.Value
            End If
        End If

        ' Pitch is selected
        If cbXselected = 3 Or cbYselected = 3 Then
            If cbXselected = 3 Then
                pitch = IIf(cbXselected = 3, x * 127, y * 127)
                lblXValue.Text = pitch
            Else
                pitch = 127 - IIf(cbXselected = 3, x * 127, y * 127)
                lblYValue.Text = pitch
            End If

            If lastMidiMessage <> -1 Then
                midimsg = lastMidiMessage And &HFFFFEF 'bit mask
                sendMidiMsg(hmidi, midimsg)
            End If
            midimsg = &H90 + (pitch * &H100) + (volume * &H10000) + channel
            sendMidiMsg(hmidi, midimsg)
            lastMidiMessage = midimsg
        End If

        ' Stereo Position
        If cbXselected = 4 Or cbYselected = 4 Then
            panning = 127 - IIf(cbXselected = 4, x * 127, y * 127)
            If cbXselected = 4 Then
                lblXValue.Text = panning
            Else
                lblYValue.Text = panning
            End If
            midimsg = &HB0 + channel + (&HA * &H100) + (panning * &H10000)
            sendMidiMsg(hmidi, midimsg)

            'store the panning value in channel
            'channel_data(channel).panning_m = tbPanning.Value
        End If

        ' Pitch Bend
        If cbXselected = 5 Or cbYselected = 5 Then
            pitchbend = 127 * 127 - IIf(cbXselected = 5, x * 127 * 127, y * 127 * 127)
            lsb = pitchbend Mod 128
            msb = Math.Floor(pitchbend / 128)

            If cbXselected = 5 Then
                lblXValue.Text = pitchbend
            Else
                lblYValue.Text = pitchbend
            End If

            'Construct the MIDI message
            midimsg = &HE0 + channel + lsb * &H100 + msb * &H10000
            'Send the message to the card
            midiOutShortMsg(hmidi, midimsg)
        End If
    End Function

    Private Sub picWhiteboard_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picWhiteboard.MouseMove
        ' Check the range of the x and y values
        Dim x As Double, y As Double
        If Not e.Button = MouseButtons.Left Or e.X < 0 Or e.X >= picWhiteboard.Width Or e.Y < 0 Or e.Y >= picWhiteboard.Height Then
            Exit Sub
        End If
        x = e.X / (picWhiteboard.Width - 1)
        y = e.Y / (picWhiteboard.Height - 1)
        ' Send MIDI messages based on the x and y range
        sendMsgForWhiteboard(x, y)
        ' Display the values in the x and y labels
    End Sub

    Private Sub cboXTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboXTitle.SelectedIndexChanged
        If cboXTitle.SelectedIndex = cbYselected Then
            cboXTitle.SelectedIndex = cbXselected
        Else
            cbXselected = cboXTitle.SelectedIndex
        End If
    End Sub

    Private Sub cboYTitle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboYTitle.SelectedIndexChanged
        If cboYTitle.SelectedIndex = cbXselected Then
            cboYTitle.SelectedIndex = cbYselected
        Else
            cbYselected = cboYTitle.SelectedIndex
        End If
    End Sub

    Private Sub picWhiteboard_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picWhiteboard.MouseDown
        picWhiteboard_MouseMove(sender, e)
    End Sub

    Private Sub picWhiteboard_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picWhiteboard.MouseUp
        If lastMidiMessage <> -1 Then
            midimsg = lastMidiMessage And &HFFFFEF
            sendMidiMsg(hmidi, midimsg)
            lastMidiMessage = -1
        End If
    End Sub

    '
    '
    '''''''''''''''''''''''''''''''''''''''''Drum Machine'''''''''''''''''''''''''''''''''''''''''
    '
    '

    ' Draw the drum slots in a PictureBox (picDrum) in two rows
    Private Sub DrawDrumConfiguration(ByVal g As Graphics)
        Dim Slot, Drum As Short
        Dim X1, X2 As Single
        Dim Y1, Y2 As Single
        Dim Width, Height As Single

        ' The width and height of a slot in the drum machine
        Width = picDrum.ClientRectangle.Width / DRUM_SLOT
        Height = picDrum.ClientRectangle.Height / DRUM_INSTRUMENT

        g.Clear(Color.White)

        'Create pens
        Dim blackBrush As New SolidBrush(Color.Black)
        Dim redPen As New Pen(Color.Red, 3)

        For Slot = 1 To DRUM_SLOT
            X1 = Width * (Slot - 1)
            X2 = Width * Slot

            For Drum = 1 To DRUM_INSTRUMENT
                Y1 = Height * (Drum - 1)
                Y2 = Height * Drum

                ' Draw a black box if the slot is selected
                If drumSlot(Drum, Slot) Then
                    g.FillRectangle(blackBrush, X1, Y1, Width, Height)
                End If
            Next
            g.DrawLine(redPen, X1, 0, X1, (picDrum.ClientRectangle.Height))
        Next

        ' Draw the red separators between the slots
        For Drum = 1 To DRUM_INSTRUMENT - 1
            g.DrawLine(redPen, 0, Height * Drum, (picDrum.ClientRectangle.Width), Height * Drum)
        Next
    End Sub

    Private Sub picDrum_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles picDrum.MouseDown
        Dim X As Single = e.X
        Dim Y As Single = e.Y
        Dim Drum, Slot As Short
        Dim Width, Height As Single

        Width = picDrum.ClientRectangle.Width / DRUM_SLOT
        Height = picDrum.ClientRectangle.Height / DRUM_INSTRUMENT

        ' Determine the slot where the user has selected
        Slot = Math.Floor(X / Width) + 1
        Drum = Math.Floor(Y / Height) + 1

        ' Set/unset the drum slot
        drumSlot(Drum, Slot) = Not drumSlot(Drum, Slot)

        ' Redraw the drum machine
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub tmrDrumPlayback_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDrumPlayback.Tick
        Static Slot As Short
        Static Slot_p As Short = 0
        Dim Drum As Short
        Dim X1, X2, Width As Single
        Dim bluePen As New Pen(Color.Blue, 3)
        Dim redPen As New Pen(Color.Red, 3)
        Dim g As Graphics = picDrum.CreateGraphics

        Width = picDrum.ClientRectangle.Width / DRUM_SLOT

        X1 = Width * (Slot_p - 1)
        X2 = Width * (Slot - 1)

        'Draw the red line to overwrite the blue line
        If Slot_p = 1 Then
            g.DrawLine(redPen, Width * (DRUM_SLOT - 1), 0, Width * (DRUM_SLOT - 1), (picDrum.ClientRectangle.Height))
        Else
            g.DrawLine(redPen, X1 - Width, 0, X1 - Width, (picDrum.ClientRectangle.Height))
        End If

        ' Initialize the slot number
        If Slot = 0 Then Slot = 1

        ' Start/Stop a drum for each row in the drum machine
        For Drum = 1 To DRUM_INSTRUMENT
            If drumMessageSent(Drum) Then
                ' You need to stop any drum note already sent to
                ' the midi card by checking the variable DrumMessageSent
                midimsg = &H80 + 9 + (drumNumber(Drum) * &H100) + (volume * &H10000)
                sendMidiMsg(hmidi, midimsg)
            End If

            If drumSlot(Drum, Slot) Then
                ' Here, a drum slot is selected that means you have to
                ' start a midi note with the drum sound
                midimsg = &H90 + 9 + (drumNumber(Drum) * &H100) + (volume * &H10000)
                sendMidiMsg(hmidi, midimsg)
                drumMessageSent(Drum) = True
            Else
                drumMessageSent(Drum) = False
            End If
        Next

        'Draw the blue line
        g.DrawLine(bluePen, X1, 0, X1, (picDrum.ClientRectangle.Height))

        'Save the current position
        Slot_p = Slot

        ' Increase the number by 1
        Slot = (Slot Mod DRUM_SLOT) + 1
    End Sub

    ' Draw the drum machine
    Private Sub picDrum_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles picDrum.Paint
        DrawDrumConfiguration(e.Graphics())
    End Sub

    Private Sub btnDrumstart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrumStart.Click
        ' start the drum timer
        prevInterval = tmrDrumPlayback.Interval
        tmrDrumPlayback.Interval = IIf(tmrDrumPlayback.Interval * speed < 1, 1, prevInterval * speed)
        tmrDrumPlayback.Enabled = True

        btnDrumStart.Enabled = False
        btnDrumStop.Enabled = True
        tbSpeed.Enabled = False
    End Sub

    Private Sub btnDrumstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDrumStop.Click
        Dim Drum As Short

        'ReDraw the drum machine
        DrawDrumConfiguration(picDrum.CreateGraphics())

        ' stop the drum timer
        tmrDrumPlayback.Enabled = False
        tmrDrumPlayback.Interval = prevInterval

        ' You need to stop any drum note already sent to the midi card
        For Drum = 0 To DRUM_INSTRUMENT - 1
            If drumMessageSent(Drum) Then
                midimsg = &H80 + 9 + (drumNumber(Drum) * &H100) + (volume * &H10000)
                midiOutShortMsg(hmidi, midimsg)
            End If
        Next

        btnDrumStart.Enabled = True
        btnDrumStop.Enabled = False
        tbSpeed.Enabled = True
    End Sub

    Private Sub picDisplay_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Dim g As Graphics = e.Graphics()

        g.Clear(Color.White)

        ' This code simply draws three rectangles on the picture box
        g.FillRectangle(Brushes.Black, 10, 10, 10, 2)
        g.FillRectangle(Brushes.Black, 20, 20, 10, 2)
        g.FillRectangle(Brushes.Black, 30, 30, 10, 2)
    End Sub

    Private Sub btnRandomSelection_Click(sender As Object, e As EventArgs) Handles btnRandomSelection.Click
        Randomize()
        Dim Drum, Slot As Short

        Dim RandomValue1 As Integer = CInt(Int((46 * Rnd()) + 0))
        Dim RandomValue2 As Integer = CInt(Int((46 * Rnd()) + 0))

        cbDrum1.SelectedIndex = RandomValue1
        cbDrum2.SelectedIndex = RandomValue2

        drumNumber(1) = cbDrum1.SelectedIndex + 35
        drumNumber(2) = cbDrum2.SelectedIndex + 35

        Dim i As Integer
        For i = 0 To cbCount - 1
            Dim RandInt As Integer = CInt(Int(46 * Rnd()) + 1)
            listCb(i).SelectedIndex = RandInt
            drumNumber(2 + i) = listCb(i).SelectedIndex + 35
        Next i

        For Drum = 1 To DRUM_INSTRUMENT
            For Slot = 1 To DRUM_SLOT
                ' Set/unset the drum slot        
                Dim RandInt As Integer = CInt(Int(100 * Rnd()) + 1)
                Dim RandomBool As Boolean
                If RandInt Mod 2 = 0 Then
                    RandomBool = True
                Else
                    RandomBool = False
                End If
                drumSlot(Drum, Slot) = RandomBool
            Next
        Next

        ' Redraw the drum machine
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub cbDrum1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDrum1.SelectedIndexChanged, cbDrum2.SelectedIndexChanged
        If ignoreEvent Then
            Exit Sub
        End If
        drumNumber(1) = cbDrum1.SelectedIndex + 35
        cbDrum1.SelectedValue = drumNumber(1)
        drumNumber(2) = cbDrum2.SelectedIndex + 35
        cbDrum2.SelectedValue = drumNumber(2)
    End Sub

    Private Sub resizeRow()
        Dim temp(DRUM_INSTRUMENT, DRUM_SLOT) As Boolean
        Dim i, j As Integer
        For i = 1 To DRUM_INSTRUMENT - 1
            For j = 1 To DRUM_SLOT
                temp(i, j) = drumSlot(i, j)
            Next j
        Next i
        ReDim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)
        drumSlot = temp
        ReDim Preserve drumNumber(DRUM_INSTRUMENT) ' The instrument for the drums
        ReDim Preserve drumMessageSent(DRUM_INSTRUMENT) ' True if a note-on midi message for a drum is sent
    End Sub

    Private Sub addRow()
        Me.picDrum.BackColor = System.Drawing.SystemColors.Window
        Me.picDrum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDrum.ForeColor = System.Drawing.SystemColors.WindowText
        Me.picDrum.Location = New System.Drawing.Point(19, 17)
        Me.picDrum.Name = "picDrum"
        Me.picDrum.Size = New System.Drawing.Size(968, 39 * rowCount)
        Me.picDrum.TabIndex = 25
        Me.picDrum.TabStop = False
    End Sub

    Private Sub addColumn()
        Me.picDrum.Location = New System.Drawing.Point(19, 17)
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub addLbl()
        Dim label As System.Windows.Forms.Label
        label = New System.Windows.Forms.Label()
        lblCount += 1
        listLbl(lblCount - 1) = label
        Me.tabDrumMachine.Controls.Add(label)
        label.AutoSize = True
        label.Location = New System.Drawing.Point(1009, 29 + 39 * (lblCount + 1))
        label.Name = "lblDrum" & lblCount + 2
        label.Size = New System.Drawing.Size(63, 15)
        label.TabIndex = 32
        label.Text = "Drum " + (lblCount + 2).ToString + ":"
    End Sub

    Private Sub deletelbl()
        Me.tabDrumMachine.Controls.Remove(listLbl(lblCount - 1))
        listLbl(lblCount - 1) = Nothing
        lblCount -= 1
    End Sub

    Private Sub addCb()
        Dim cbDrum As System.Windows.Forms.ComboBox
        cbDrum = New System.Windows.Forms.ComboBox()
        cbCount += 1
        listCb(cbCount - 1) = cbDrum
        Me.tabDrumMachine.Controls.Add(cbDrum)
        cbDrum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        cbDrum.FormattingEnabled = True
        cbDrum.Items.AddRange(New Object() {"35 Acoustic Bass Drum", "36 Bass Drum 1", "37 Side Stick", "38 Acoustic Snare", "39 Hand Clap", "40 Electric Snare ", "41 Low Floor Tom", "42 Closed Hi-Hat", "43 High Floor Tom", "44 Pedal Hi-Hat  ", "45 Low Tom ", "46 Open Hi-Hat ", "47 Low-Mid Tom ", "48 Hi-Mid Tom ", "49 Crash Cymbal 1 ", "50 High Tom ", "51 Ride Cymbal 1 ", "52 Chinese Cymbal ", "53 Ride Bell ", "54 Tambourine ", "55 Splash Cymbal ", "56 Cowbell ", "57 Crash Cymbal 2 ", "58 Vibraslap ", "59 Ride Cymbal 2 ", "60 Hi Bongo", "61 Low Bongo", "62 Mute Hi Conga", "63 Open Hi Conga ", "64 Low Conga ", "65 High Timbale ", "66 Low Timbale  ", "67 High Agogo ", "68 Low Agogo ", "69 Cabasa ", "70 Maracas ", "71 Short Whistle ", "72 Long Whistle ", "73 Short Guiro ", "74 Long Guiro ", "75 Claves ", "76 Hi Wood Block ", "77 Low Wood Block ", "78 Mute Cuica ", "79 Open Cuica ", "80 Mute Triangle ", "81 Open Triangle "})
        cbDrum.Location = New System.Drawing.Point(1076, 24 + 39 * (cbCount + 1))
        cbDrum.Name = "cbDrum" & cbCount + 2
        cbDrum.Size = New System.Drawing.Size(149, 23)
        cbDrum.Sorted = True
        cbDrum.TabIndex = 30
        AddHandler cbDrum.SelectedIndexChanged, AddressOf Me.cbDrum1_SelectedIndexChanged
        cbDrum.SelectedIndex = 26 + cbCount
        drumNumber(2 + cbCount) = drumNumber(2) + cbCount
    End Sub

    Private Sub deleteCb()
        Me.tabDrumMachine.Controls.Remove(listCb(cbCount - 1))
        listCb(cbCount - 1) = Nothing
        cbCount -= 1
    End Sub

    Private Sub moveBtn()
        'btnInverseDrum
        Me.btnInverseDrum.Location = New System.Drawing.Point(177, 141 + (rowCount - 2) * 39)

        'btnReverseDrum
        Me.btnReverseDrum.Location = New System.Drawing.Point(19, 141 + (rowCount - 2) * 39)

        'btnRandomSelection
        Me.btnRandomSelection.Location = New System.Drawing.Point(338, 141 + (rowCount - 2) * 39)

        'btnDrumStart
        Me.btnDrumStart.Location = New System.Drawing.Point(19, 101 + (rowCount - 2) * 39)

        'btnDrumStop
        Me.btnDrumStop.Location = New System.Drawing.Point(177, 101 + (rowCount - 2) * 39)

        'btnLoadDrum
        Me.btnLoadDrum.Location = New System.Drawing.Point(338, 101 + (rowCount - 2) * 39)

        'btnDeleteColumn
        Me.btnDeleteColumn.Location = New System.Drawing.Point(317, 181 + (rowCount - 2) * 39)

        'btnDeleteRow
        Me.btnDeleteRow.Location = New System.Drawing.Point(110, 181 + (rowCount - 2) * 39)

        'btnAddColumn
        Me.btnAddColumn.Location = New System.Drawing.Point(211, 181 + (rowCount - 2) * 39)

        'btnAddRow
        Me.btnAddRow.Location = New System.Drawing.Point(19, 181 + (rowCount - 2) * 39)

        'btnResetDrum
        Me.btnResetDrum.Location = New System.Drawing.Point(442, 181 + (rowCount - 2) * 39)
    End Sub

    Private Sub btnAddRow_Click(sender As Object, e As EventArgs) Handles btnAddRow.Click
        rowCount += 1
        DRUM_INSTRUMENT += 1
        If rowCount > 8 Then
            rowCount = 8
            DRUM_INSTRUMENT = 8
            Exit Sub
        End If
        resizeRow()
        addRow()
        addCb()
        addLbl()
        moveBtn()
    End Sub

    Private Sub btnAddColumn_Click(sender As Object, e As EventArgs) Handles btnAddColumn.Click
        colCount += 1
        DRUM_SLOT += 1
        If colCount > 16 Then
            colCount = 16
            DRUM_SLOT = 16
            Exit Sub
        End If
        ReDim Preserve drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)
        addColumn()
    End Sub

    Private Sub btnDeleteRow_Click(sender As Object, e As EventArgs) Handles btnDeleteRow.Click
        rowCount -= 1
        DRUM_INSTRUMENT -= 1
        If rowCount < 2 Then
            rowCount = 2
            DRUM_INSTRUMENT = 2
            Exit Sub
        End If
        resizeRow()
        addRow()
        deleteCb()
        deletelbl()
        moveBtn()
    End Sub

    Private Sub btnDeleteColumn_Click(sender As Object, e As EventArgs) Handles btnDeleteColumn.Click
        colCount -= 1
        DRUM_SLOT -= 1
        If colCount < 8 Then
            colCount = 8
            DRUM_SLOT = 8
            Exit Sub
        End If
        ReDim Preserve drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)
        addColumn()
    End Sub

    Private Sub btnResetDrum_Click(sender As Object, e As EventArgs) Handles btnResetDrum.Click
        btnLoadDrum.Enabled = True ' can only load drum again after reset

        DRUM_INSTRUMENT = 2
        rowCount = 2
        DRUM_SLOT = 8
        colCount = 8
        addRow()
        addColumn()
        moveBtn()

        ' Drum Machine Default
        drumNumber(1) = 60
        drumNumber(2) = 61
        cbDrum1.SelectedIndex = 25 ' Initialize cb index to 25
        cbDrum2.SelectedIndex = 26

        Dim i, j As Integer
        For i = 0 To cbCount - 1
            deleteCb()
        Next i

        For j = 0 To lblCount - 1
            deletelbl()
        Next j

        ReDim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)
        ReDim drumNumber(DRUM_INSTRUMENT) ' The instrument for the drums
        ReDim drumMessageSent(DRUM_INSTRUMENT)
        btnDrumStop.PerformClick()
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub btnReverseDrum_Click(sender As Object, e As EventArgs) Handles btnReverseDrum.Click
        Dim i, j As Integer
        For i = 1 To DRUM_INSTRUMENT
            For j = 1 To DRUM_SLOT / 2
                Dim temp As Boolean = drumSlot(i, j)
                drumSlot(i, j) = drumSlot(i, DRUM_SLOT - j + 1)
                drumSlot(i, DRUM_SLOT - j + 1) = temp
            Next j
        Next i
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub btnInverseDrum_Click(sender As Object, e As EventArgs) Handles btnInverseDrum.Click
        Dim i, j As Integer
        For i = 1 To DRUM_INSTRUMENT
            For j = 1 To DRUM_SLOT
                drumSlot(i, j) = IIf(drumSlot(i, j) = True, False, True)
            Next j
        Next i
        DrawDrumConfiguration(picDrum.CreateGraphics())
    End Sub

    Private Sub btnLoadDrum_Click(sender As Object, e As EventArgs) Handles btnLoadDrum.Click
        btnLoadDrum.Enabled = False  'can only load drum again after reset
        Dim dlg As New OpenFileDialog

        ' Ask for the txt file
        dlg.DefaultExt = "txt"
        dlg.Filter = "Text Files (*.txt)|*.txt"
        dlg.Multiselect = False

        ' Get num of rows, col, and val of instrument

        ' Resize array

        ' Fill array
        If dlg.ShowDialog() = DialogResult.OK Then
            Dim fileReader As New Microsoft.VisualBasic.FileIO.TextFieldParser(dlg.FileName)
            fileReader.TextFieldType = FileIO.FieldType.Delimited
            fileReader.SetDelimiters(" ")
            Dim readLine(0 To 2) As String

            Dim i, j As Integer
            i = 0
            j = 0
            While Not fileReader.EndOfData
                If (i = readLine.Length) Then
                    ReDim Preserve readLine(0 To i)
                End If

                Dim currentLine As String() = fileReader.ReadFields()
                Dim currentChar As String
                For Each currentChar In currentLine
                    readLine(i) += currentChar
                Next
                i += 1
            End While

            DRUM_INSTRUMENT = Integer.Parse(readLine(0)(0))
            DRUM_SLOT = Integer.Parse(readLine(0)(1))
            ReDim drumSlot(DRUM_INSTRUMENT, DRUM_SLOT)
            ReDim drumNumber(DRUM_INSTRUMENT)
            ReDim drumMessageSent(DRUM_INSTRUMENT)

            rowCount = DRUM_INSTRUMENT
            colCount = DRUM_SLOT

            For i = 0 To rowCount - 3
                addRow()
                addCb()
                addLbl()
                moveBtn()

            Next

            For i = 0 To colCount - 8
                addColumn()
            Next

            For i = 1 To DRUM_INSTRUMENT
                For j = 0 To readLine(i).Length
                    If j = DRUM_SLOT Then
                        drumNumber(i) = Integer.Parse(readLine(i)(j) + readLine(i)(j + 1))
                        Exit For
                    Else
                        drumSlot(i, j) = IIf(Integer.Parse(readLine(i)(j)) = 1, True, False)
                    End If
                Next j
            Next i

            ignoreEvent = True

            cbDrum1.SelectedIndex = drumNumber(1) - 35
            cbDrum1.SelectedValue = drumNumber(1)
            cbDrum2.SelectedIndex = drumNumber(2) - 35
            cbDrum2.SelectedValue = drumNumber(2)

            For i = 0 To rowCount - 3
                listCb(i).SelectedIndex = drumNumber(i + 2) - 35
                listCb(i).SelectedValue = drumNumber(i + 2)
            Next i


            fileReader.Close()
        End If
        DrawDrumConfiguration(picDrum.CreateGraphics())
        ignoreEvent = False
    End Sub
End Class