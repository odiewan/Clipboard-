<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.cmsFavorites = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiMoveUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMoveDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMoveToTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRemoveFav = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSortAToZ1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSortZToA1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmsRecentMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiCopyToFav = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRemoveBuff = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGoToTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGoToBottom = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSortAToZ = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiSortZToA = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ssMain = New System.Windows.Forms.StatusStrip()
        Me.tsslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslCmd = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslCopyCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslCOCout = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslPollStat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tspbProg = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnBrowseAudioFolder = New System.Windows.Forms.Button()
        Me.btnTestSound = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnPickSoundFile = New System.Windows.Forms.Button()
        Me.lbxFavorites = New System.Windows.Forms.ListBox()
        Me.Form1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.gbxClipboard = New System.Windows.Forms.GroupBox()
        Me.tbxClipboard = New System.Windows.Forms.TextBox()
        Me.cmmsClipboard = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToFavoritesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbHistory = New System.Windows.Forms.GroupBox()
        Me.tbctrlMain = New System.Windows.Forms.TabControl()
        Me.tpFavorites = New System.Windows.Forms.TabPage()
        Me.tbpRecent = New System.Windows.Forms.TabPage()
        Me.lbxRecent = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstbRecentFind = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtRecentFind = New System.Windows.Forms.ToolStripButton()
        Me.tsbtRecentCase = New System.Windows.Forms.ToolStripButton()
        Me.tsbtRecentWhole = New System.Windows.Forms.ToolStripButton()
        Me.tsslResult = New System.Windows.Forms.ToolStripLabel()
        Me.tpSettings = New System.Windows.Forms.TabPage()
        Me.gbSettings1 = New System.Windows.Forms.GroupBox()
        Me.btnShowFolder = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tbxMaxTotalBufferSize = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxMaxItemSize = New System.Windows.Forms.TextBox()
        Me.fbdSoundFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofdSoundFile = New System.Windows.Forms.OpenFileDialog()
        Me.cmsFavorites.SuspendLayout()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsRecentMenu.SuspendLayout()
        Me.ssMain.SuspendLayout()
        CType(Me.Form1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxClipboard.SuspendLayout()
        Me.cmmsClipboard.SuspendLayout()
        Me.gbHistory.SuspendLayout()
        Me.tbctrlMain.SuspendLayout()
        Me.tpFavorites.SuspendLayout()
        Me.tbpRecent.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.tpSettings.SuspendLayout()
        Me.gbSettings1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsFavorites
        '
        Me.cmsFavorites.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsFavorites.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMoveUp, Me.tsmiMoveDown, Me.tsmiMoveToTop, Me.tsmiRemoveFav, Me.tsmiSortAToZ1, Me.tsmiSortZToA1, Me.FindToolStripMenuItem})
        Me.cmsFavorites.Name = "cmsFavorites"
        Me.cmsFavorites.Size = New System.Drawing.Size(231, 172)
        '
        'tsmiMoveUp
        '
        Me.tsmiMoveUp.Name = "tsmiMoveUp"
        Me.tsmiMoveUp.Size = New System.Drawing.Size(230, 24)
        Me.tsmiMoveUp.Text = "Move Up"
        '
        'tsmiMoveDown
        '
        Me.tsmiMoveDown.Name = "tsmiMoveDown"
        Me.tsmiMoveDown.Size = New System.Drawing.Size(230, 24)
        Me.tsmiMoveDown.Text = "Move Down"
        '
        'tsmiMoveToTop
        '
        Me.tsmiMoveToTop.Name = "tsmiMoveToTop"
        Me.tsmiMoveToTop.Size = New System.Drawing.Size(230, 24)
        Me.tsmiMoveToTop.Text = "Move to Top"
        '
        'tsmiRemoveFav
        '
        Me.tsmiRemoveFav.Name = "tsmiRemoveFav"
        Me.tsmiRemoveFav.Size = New System.Drawing.Size(230, 24)
        Me.tsmiRemoveFav.Text = "Remove from Favorites"
        '
        'tsmiSortAToZ1
        '
        Me.tsmiSortAToZ1.Name = "tsmiSortAToZ1"
        Me.tsmiSortAToZ1.Size = New System.Drawing.Size(230, 24)
        Me.tsmiSortAToZ1.Text = "Sort Favorites A to Z"
        '
        'tsmiSortZToA1
        '
        Me.tsmiSortZToA1.Name = "tsmiSortZToA1"
        Me.tsmiSortZToA1.Size = New System.Drawing.Size(230, 24)
        Me.tsmiSortZToA1.Text = "Sort Favorites Z to A"
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(230, 24)
        Me.FindToolStripMenuItem.Text = "Find..."
        '
        'cmsRecentMenu
        '
        Me.cmsRecentMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmsRecentMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCopyToFav, Me.tsmiRemoveBuff, Me.tsmiGoToTop, Me.tsmiGoToBottom, Me.tsmiCopy, Me.tsmiSortAToZ, Me.tsmiSortZToA, Me.FindToolStripMenuItem1})
        Me.cmsRecentMenu.Name = "cmsBufferMenu"
        Me.cmsRecentMenu.Size = New System.Drawing.Size(187, 196)
        '
        'tsmiCopyToFav
        '
        Me.tsmiCopyToFav.Name = "tsmiCopyToFav"
        Me.tsmiCopyToFav.Size = New System.Drawing.Size(186, 24)
        Me.tsmiCopyToFav.Text = "Add to Favorites"
        '
        'tsmiRemoveBuff
        '
        Me.tsmiRemoveBuff.Name = "tsmiRemoveBuff"
        Me.tsmiRemoveBuff.Size = New System.Drawing.Size(186, 24)
        Me.tsmiRemoveBuff.Text = "Delete"
        '
        'tsmiGoToTop
        '
        Me.tsmiGoToTop.Name = "tsmiGoToTop"
        Me.tsmiGoToTop.Size = New System.Drawing.Size(186, 24)
        Me.tsmiGoToTop.Text = "Go to Top"
        '
        'tsmiGoToBottom
        '
        Me.tsmiGoToBottom.Name = "tsmiGoToBottom"
        Me.tsmiGoToBottom.Size = New System.Drawing.Size(186, 24)
        Me.tsmiGoToBottom.Text = "Go to Bottom"
        '
        'tsmiCopy
        '
        Me.tsmiCopy.Name = "tsmiCopy"
        Me.tsmiCopy.Size = New System.Drawing.Size(186, 24)
        Me.tsmiCopy.Text = "Copy"
        '
        'tsmiSortAToZ
        '
        Me.tsmiSortAToZ.Name = "tsmiSortAToZ"
        Me.tsmiSortAToZ.Size = New System.Drawing.Size(186, 24)
        Me.tsmiSortAToZ.Text = "Sort A to Z"
        '
        'tsmiSortZToA
        '
        Me.tsmiSortZToA.Name = "tsmiSortZToA"
        Me.tsmiSortZToA.Size = New System.Drawing.Size(186, 24)
        Me.tsmiSortZToA.Text = "Sort Z to A"
        '
        'FindToolStripMenuItem1
        '
        Me.FindToolStripMenuItem1.Name = "FindToolStripMenuItem1"
        Me.FindToolStripMenuItem1.Size = New System.Drawing.Size(186, 24)
        Me.FindToolStripMenuItem1.Text = "Find..."
        '
        'Timer1
        '
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'ssMain
        '
        Me.ssMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.tsslCount, Me.tsslCmd, Me.tsslCopyCount, Me.tsslCOCout, Me.tsslPollStat, Me.ToolStripStatusLabel1, Me.tspbProg})
        Me.ssMain.Location = New System.Drawing.Point(0, 385)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.ssMain.Size = New System.Drawing.Size(424, 26)
        Me.ssMain.TabIndex = 4
        Me.ssMain.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(50, 20)
        Me.tsslStatus.Text = "Ready"
        '
        'tsslCount
        '
        Me.tsslCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsslCount.Name = "tsslCount"
        Me.tsslCount.Size = New System.Drawing.Size(27, 20)
        Me.tsslCount.Text = "##"
        '
        'tsslCmd
        '
        Me.tsslCmd.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsslCmd.Name = "tsslCmd"
        Me.tsslCmd.Size = New System.Drawing.Size(40, 20)
        Me.tsslCmd.Text = "Cmd"
        '
        'tsslCopyCount
        '
        Me.tsslCopyCount.Name = "tsslCopyCount"
        Me.tsslCopyCount.Size = New System.Drawing.Size(86, 20)
        Me.tsslCopyCount.Text = "Copy Count"
        '
        'tsslCOCout
        '
        Me.tsslCOCout.Name = "tsslCOCout"
        Me.tsslCOCout.Size = New System.Drawing.Size(75, 20)
        Me.tsslCOCout.Text = "CO Count:"
        '
        'tsslPollStat
        '
        Me.tsslPollStat.Name = "tsslPollStat"
        Me.tsslPollStat.Size = New System.Drawing.Size(73, 20)
        Me.tsslPollStat.Text = "Polling: --"
        Me.tsslPollStat.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'tspbProg
        '
        Me.tspbProg.Name = "tspbProg"
        Me.tspbProg.Size = New System.Drawing.Size(133, 17)
        '
        'btnBrowseAudioFolder
        '
        Me.btnBrowseAudioFolder.Location = New System.Drawing.Point(353, 149)
        Me.btnBrowseAudioFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBrowseAudioFolder.Name = "btnBrowseAudioFolder"
        Me.btnBrowseAudioFolder.Size = New System.Drawing.Size(35, 28)
        Me.btnBrowseAudioFolder.TabIndex = 11
        Me.btnBrowseAudioFolder.Text = "..."
        Me.ToolTip1.SetToolTip(Me.btnBrowseAudioFolder, "Browse For Sound Folder")
        Me.btnBrowseAudioFolder.UseVisualStyleBackColor = True
        '
        'btnTestSound
        '
        Me.btnTestSound.ImageIndex = 0
        Me.btnTestSound.ImageList = Me.ImageList1
        Me.btnTestSound.Location = New System.Drawing.Point(348, 117)
        Me.btnTestSound.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTestSound.Name = "btnTestSound"
        Me.btnTestSound.Size = New System.Drawing.Size(35, 28)
        Me.btnTestSound.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btnTestSound, "Play Sound File")
        Me.btnTestSound.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "246.ico")
        '
        'btnPickSoundFile
        '
        Me.btnPickSoundFile.Image = Global.Clipboard_Test_Prj.My.Resources.Resources.Folder_action_open
        Me.btnPickSoundFile.Location = New System.Drawing.Point(304, 117)
        Me.btnPickSoundFile.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPickSoundFile.Name = "btnPickSoundFile"
        Me.btnPickSoundFile.Size = New System.Drawing.Size(36, 28)
        Me.btnPickSoundFile.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btnPickSoundFile, "Select Sound File")
        Me.btnPickSoundFile.UseVisualStyleBackColor = True
        '
        'lbxFavorites
        '
        Me.lbxFavorites.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbxFavorites.ContextMenuStrip = Me.cmsFavorites
        Me.lbxFavorites.DataSource = Me.Form1BindingSource1
        Me.lbxFavorites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxFavorites.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.lbxFavorites.FormattingEnabled = True
        Me.lbxFavorites.ItemHeight = 16
        Me.lbxFavorites.Location = New System.Drawing.Point(4, 4)
        Me.lbxFavorites.Margin = New System.Windows.Forms.Padding(4)
        Me.lbxFavorites.Name = "lbxFavorites"
        Me.lbxFavorites.ScrollAlwaysVisible = True
        Me.lbxFavorites.Size = New System.Drawing.Size(402, 264)
        Me.lbxFavorites.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.lbxFavorites, "lbxFav")
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'gbxClipboard
        '
        Me.gbxClipboard.AutoSize = True
        Me.gbxClipboard.BackColor = System.Drawing.SystemColors.Control
        Me.gbxClipboard.Controls.Add(Me.tbxClipboard)
        Me.gbxClipboard.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbxClipboard.Location = New System.Drawing.Point(0, 0)
        Me.gbxClipboard.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxClipboard.MinimumSize = New System.Drawing.Size(0, 37)
        Me.gbxClipboard.Name = "gbxClipboard"
        Me.gbxClipboard.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxClipboard.Size = New System.Drawing.Size(424, 65)
        Me.gbxClipboard.TabIndex = 13
        Me.gbxClipboard.TabStop = False
        Me.gbxClipboard.Text = "Current Clipboard"
        '
        'tbxClipboard
        '
        Me.tbxClipboard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbxClipboard.ContextMenuStrip = Me.cmmsClipboard
        Me.tbxClipboard.Location = New System.Drawing.Point(7, 22)
        Me.tbxClipboard.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxClipboard.Name = "tbxClipboard"
        Me.tbxClipboard.Size = New System.Drawing.Size(405, 22)
        Me.tbxClipboard.TabIndex = 14
        '
        'cmmsClipboard
        '
        Me.cmmsClipboard.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.cmmsClipboard.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.CopyToFavoritesToolStripMenuItem})
        Me.cmmsClipboard.Name = "cmmsClipboard"
        Me.cmmsClipboard.Size = New System.Drawing.Size(193, 52)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CopyToFavoritesToolStripMenuItem
        '
        Me.CopyToFavoritesToolStripMenuItem.Name = "CopyToFavoritesToolStripMenuItem"
        Me.CopyToFavoritesToolStripMenuItem.Size = New System.Drawing.Size(192, 24)
        Me.CopyToFavoritesToolStripMenuItem.Text = "Copy to Favorites"
        '
        'gbHistory
        '
        Me.gbHistory.Controls.Add(Me.tbctrlMain)
        Me.gbHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbHistory.Location = New System.Drawing.Point(0, 65)
        Me.gbHistory.Margin = New System.Windows.Forms.Padding(4)
        Me.gbHistory.Name = "gbHistory"
        Me.gbHistory.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.gbHistory.Size = New System.Drawing.Size(424, 320)
        Me.gbHistory.TabIndex = 0
        Me.gbHistory.TabStop = False
        Me.gbHistory.Text = "Clipboard History"
        '
        'tbctrlMain
        '
        Me.tbctrlMain.ContextMenuStrip = Me.cmsFavorites
        Me.tbctrlMain.Controls.Add(Me.tpFavorites)
        Me.tbctrlMain.Controls.Add(Me.tbpRecent)
        Me.tbctrlMain.Controls.Add(Me.tpSettings)
        Me.tbctrlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbctrlMain.Location = New System.Drawing.Point(3, 17)
        Me.tbctrlMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbctrlMain.Name = "tbctrlMain"
        Me.tbctrlMain.SelectedIndex = 0
        Me.tbctrlMain.Size = New System.Drawing.Size(418, 301)
        Me.tbctrlMain.TabIndex = 7
        '
        'tpFavorites
        '
        Me.tpFavorites.Controls.Add(Me.lbxFavorites)
        Me.tpFavorites.Location = New System.Drawing.Point(4, 25)
        Me.tpFavorites.Margin = New System.Windows.Forms.Padding(4)
        Me.tpFavorites.Name = "tpFavorites"
        Me.tpFavorites.Padding = New System.Windows.Forms.Padding(4)
        Me.tpFavorites.Size = New System.Drawing.Size(410, 272)
        Me.tpFavorites.TabIndex = 5
        Me.tpFavorites.Text = "Favorites"
        Me.tpFavorites.UseVisualStyleBackColor = True
        '
        'tbpRecent
        '
        Me.tbpRecent.Controls.Add(Me.lbxRecent)
        Me.tbpRecent.Controls.Add(Me.ToolStrip1)
        Me.tbpRecent.Location = New System.Drawing.Point(4, 25)
        Me.tbpRecent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbpRecent.Name = "tbpRecent"
        Me.tbpRecent.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbpRecent.Size = New System.Drawing.Size(410, 272)
        Me.tbpRecent.TabIndex = 0
        Me.tbpRecent.Text = "Recent"
        Me.tbpRecent.UseVisualStyleBackColor = True
        '
        'lbxRecent
        '
        Me.lbxRecent.ContextMenuStrip = Me.cmsRecentMenu
        Me.lbxRecent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxRecent.FormattingEnabled = True
        Me.lbxRecent.HorizontalScrollbar = True
        Me.lbxRecent.ItemHeight = 16
        Me.lbxRecent.Location = New System.Drawing.Point(3, 29)
        Me.lbxRecent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbxRecent.Name = "lbxRecent"
        Me.lbxRecent.ScrollAlwaysVisible = True
        Me.lbxRecent.Size = New System.Drawing.Size(404, 241)
        Me.lbxRecent.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstbRecentFind, Me.tsbtRecentFind, Me.tsbtRecentCase, Me.tsbtRecentWhole, Me.tsslResult})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(404, 27)
        Me.ToolStrip1.TabIndex = 7
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tstbRecentFind
        '
        Me.tstbRecentFind.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstbRecentFind.Name = "tstbRecentFind"
        Me.tstbRecentFind.Size = New System.Drawing.Size(132, 27)
        Me.tstbRecentFind.Text = "Search recent..."
        '
        'tsbtRecentFind
        '
        Me.tsbtRecentFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtRecentFind.Image = CType(resources.GetObject("tsbtRecentFind.Image"), System.Drawing.Image)
        Me.tsbtRecentFind.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtRecentFind.Name = "tsbtRecentFind"
        Me.tsbtRecentFind.Size = New System.Drawing.Size(29, 24)
        Me.tsbtRecentFind.Text = "ToolStripButton1"
        '
        'tsbtRecentCase
        '
        Me.tsbtRecentCase.CheckOnClick = True
        Me.tsbtRecentCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtRecentCase.Image = CType(resources.GetObject("tsbtRecentCase.Image"), System.Drawing.Image)
        Me.tsbtRecentCase.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtRecentCase.Name = "tsbtRecentCase"
        Me.tsbtRecentCase.Size = New System.Drawing.Size(29, 24)
        Me.tsbtRecentCase.Text = "ToolStripButton2"
        '
        'tsbtRecentWhole
        '
        Me.tsbtRecentWhole.CheckOnClick = True
        Me.tsbtRecentWhole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtRecentWhole.Image = CType(resources.GetObject("tsbtRecentWhole.Image"), System.Drawing.Image)
        Me.tsbtRecentWhole.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtRecentWhole.Name = "tsbtRecentWhole"
        Me.tsbtRecentWhole.Size = New System.Drawing.Size(40, 24)
        Me.tsbtRecentWhole.Text = "[ab]"
        Me.tsbtRecentWhole.ToolTipText = "Find whole word" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'tsslResult
        '
        Me.tsslResult.Name = "tsslResult"
        Me.tsslResult.Size = New System.Drawing.Size(84, 24)
        Me.tsslResult.Text = "Find Result:"
        '
        'tpSettings
        '
        Me.tpSettings.Controls.Add(Me.gbSettings1)
        Me.tpSettings.Location = New System.Drawing.Point(4, 25)
        Me.tpSettings.Margin = New System.Windows.Forms.Padding(4)
        Me.tpSettings.Name = "tpSettings"
        Me.tpSettings.Padding = New System.Windows.Forms.Padding(4)
        Me.tpSettings.Size = New System.Drawing.Size(410, 272)
        Me.tpSettings.TabIndex = 4
        Me.tpSettings.Text = "Settings"
        Me.tpSettings.UseVisualStyleBackColor = True
        '
        'gbSettings1
        '
        Me.gbSettings1.Controls.Add(Me.btnShowFolder)
        Me.gbSettings1.Controls.Add(Me.btnPickSoundFile)
        Me.gbSettings1.Controls.Add(Me.btnBrowseAudioFolder)
        Me.gbSettings1.Controls.Add(Me.btnTestSound)
        Me.gbSettings1.Controls.Add(Me.CheckBox1)
        Me.gbSettings1.Controls.Add(Me.Label5)
        Me.gbSettings1.Controls.Add(Me.TextBox4)
        Me.gbSettings1.Controls.Add(Me.TextBox3)
        Me.gbSettings1.Controls.Add(Me.tbxMaxTotalBufferSize)
        Me.gbSettings1.Controls.Add(Me.Label4)
        Me.gbSettings1.Controls.Add(Me.Label3)
        Me.gbSettings1.Controls.Add(Me.Label2)
        Me.gbSettings1.Controls.Add(Me.Label1)
        Me.gbSettings1.Controls.Add(Me.tbxMaxItemSize)
        Me.gbSettings1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbSettings1.Location = New System.Drawing.Point(4, 4)
        Me.gbSettings1.Margin = New System.Windows.Forms.Padding(4)
        Me.gbSettings1.Name = "gbSettings1"
        Me.gbSettings1.Padding = New System.Windows.Forms.Padding(4)
        Me.gbSettings1.Size = New System.Drawing.Size(402, 264)
        Me.gbSettings1.TabIndex = 0
        Me.gbSettings1.TabStop = False
        Me.gbSettings1.Text = "Settings"
        '
        'btnShowFolder
        '
        Me.btnShowFolder.Location = New System.Drawing.Point(284, 85)
        Me.btnShowFolder.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowFolder.Name = "btnShowFolder"
        Me.btnShowFolder.Size = New System.Drawing.Size(100, 28)
        Me.btnShowFolder.TabIndex = 13
        Me.btnShowFolder.Text = "Show Folder"
        Me.btnShowFolder.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = Global.Clipboard_Test_Prj.My.MySettings.Default.enableAlertSound
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Clipboard_Test_Prj.My.MySettings.Default, "enableAlertSound", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CheckBox1.Location = New System.Drawing.Point(193, 92)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 21)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Enabled"
        Me.CheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 92)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Enable Copy Alert Sound"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Clipboard_Test_Prj.My.MySettings.Default, "copyAlertSoundFile", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox4.Location = New System.Drawing.Point(99, 119)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(196, 22)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.Text = Global.Clipboard_Test_Prj.My.MySettings.Default.copyAlertSoundFile
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Clipboard_Test_Prj.My.MySettings.Default, "soundFolder", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.TextBox3.Location = New System.Drawing.Point(116, 151)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(223, 22)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = Global.Clipboard_Test_Prj.My.MySettings.Default.soundFolder
        '
        'tbxMaxTotalBufferSize
        '
        Me.tbxMaxTotalBufferSize.Location = New System.Drawing.Point(193, 55)
        Me.tbxMaxTotalBufferSize.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxMaxTotalBufferSize.Name = "tbxMaxTotalBufferSize"
        Me.tbxMaxTotalBufferSize.Size = New System.Drawing.Size(188, 22)
        Me.tbxMaxTotalBufferSize.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 155)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sounds Folder"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 123)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Alert Sound"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 59)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Max Total Buffer Size, bytes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Max Buffer Item Size, bytes:"
        '
        'tbxMaxItemSize
        '
        Me.tbxMaxItemSize.Location = New System.Drawing.Point(193, 23)
        Me.tbxMaxItemSize.Margin = New System.Windows.Forms.Padding(4)
        Me.tbxMaxItemSize.Name = "tbxMaxItemSize"
        Me.tbxMaxItemSize.Size = New System.Drawing.Size(188, 22)
        Me.tbxMaxItemSize.TabIndex = 0
        '
        'fbdSoundFolder
        '
        Me.fbdSoundFolder.SelectedPath = Global.Clipboard_Test_Prj.My.MySettings.Default.soundFolder
        '
        'ofdSoundFile
        '
        Me.ofdSoundFile.FileName = Global.Clipboard_Test_Prj.My.MySettings.Default.copyAlertSoundFile
        Me.ofdSoundFile.Filter = """WAV Audio File|*.wav|All Files|*.*"""
        Me.ofdSoundFile.InitialDirectory = "C:\Users\Odie\Documents\Media"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 411)
        Me.Controls.Add(Me.gbHistory)
        Me.Controls.Add(Me.gbxClipboard)
        Me.Controls.Add(Me.ssMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(438, 446)
        Me.Name = "Form1"
        Me.Text = "Clipboard++ 20220621"
        Me.cmsFavorites.ResumeLayout(False)
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsRecentMenu.ResumeLayout(False)
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        CType(Me.Form1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxClipboard.ResumeLayout(False)
        Me.gbxClipboard.PerformLayout()
        Me.cmmsClipboard.ResumeLayout(False)
        Me.gbHistory.ResumeLayout(False)
        Me.tbctrlMain.ResumeLayout(False)
        Me.tpFavorites.ResumeLayout(False)
        Me.tbpRecent.ResumeLayout(False)
        Me.tbpRecent.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tpSettings.ResumeLayout(False)
        Me.gbSettings1.ResumeLayout(False)
        Me.gbSettings1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents tsslStatus As ToolStripStatusLabel
    Friend WithEvents tsslCount As ToolStripStatusLabel
    Friend WithEvents tsslCmd As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents tsslCopyCount As ToolStripStatusLabel
    Friend WithEvents tsslCOCout As ToolStripStatusLabel
    Friend WithEvents tsslPollStat As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents cmsRecentMenu As ContextMenuStrip
    Friend WithEvents tsmiCopyToFav As ToolStripMenuItem
    Friend WithEvents cmsFavorites As ContextMenuStrip
    Friend WithEvents tsmiMoveUp As ToolStripMenuItem
    Friend WithEvents tsmiMoveDown As ToolStripMenuItem
    Friend WithEvents tsmiRemoveBuff As ToolStripMenuItem
    Friend WithEvents tsmiMoveToTop As ToolStripMenuItem
    Friend WithEvents Form1BindingSource As BindingSource
    Friend WithEvents tsmiGoToTop As ToolStripMenuItem
    Friend WithEvents tsmiGoToBottom As ToolStripMenuItem
    Friend WithEvents tsmiCopy As ToolStripMenuItem
    Friend WithEvents tsmiRemoveFav As ToolStripMenuItem
    Friend WithEvents tspbProg As ToolStripProgressBar
    Friend WithEvents gbxClipboard As GroupBox
    Friend WithEvents gbHistory As GroupBox
    Friend WithEvents tbctrlMain As TabControl
    Friend WithEvents tpFavorites As TabPage
    Friend WithEvents lbxFavorites As ListBox
    Friend WithEvents tbpRecent As TabPage
    Friend WithEvents tpSettings As TabPage
    Friend WithEvents gbSettings1 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents tbxMaxTotalBufferSize As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxMaxItemSize As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnTestSound As Button
    Friend WithEvents btnBrowseAudioFolder As Button
    Friend WithEvents fbdSoundFolder As FolderBrowserDialog
    Friend WithEvents ofdSoundFile As OpenFileDialog
    Friend WithEvents btnShowFolder As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Form1BindingSource1 As BindingSource
    Friend WithEvents tsmiSortAToZ As ToolStripMenuItem
    Friend WithEvents tsmiSortZToA As ToolStripMenuItem
    Friend WithEvents tsmiSortAToZ1 As ToolStripMenuItem
    Friend WithEvents tsmiSortZToA1 As ToolStripMenuItem
    Friend WithEvents btnPickSoundFile As Button
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lbxRecent As ListBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tstbRecentFind As ToolStripTextBox
    Friend WithEvents tsbtRecentFind As ToolStripButton
    Friend WithEvents tsbtRecentCase As ToolStripButton
    Friend WithEvents tsbtRecentWhole As ToolStripButton
    Friend WithEvents tsslResult As ToolStripLabel
    Friend WithEvents tbxClipboard As TextBox
    Friend WithEvents cmmsClipboard As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToFavoritesToolStripMenuItem As ToolStripMenuItem
End Class
