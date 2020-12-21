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
        Me.lblCBContents = New System.Windows.Forms.Label()
        Me.splMain = New System.Windows.Forms.SplitContainer()
        Me.spcClipboardFavorites = New System.Windows.Forms.SplitContainer()
        Me.gbxClipboard = New System.Windows.Forms.GroupBox()
        Me.gbxFavorites = New System.Windows.Forms.GroupBox()
        Me.lbxFavorites = New System.Windows.Forms.ListBox()
        Me.cmsFavorites = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiMoveUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMoveDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMoveToTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRemoveFav = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbBuffer = New System.Windows.Forms.GroupBox()
        Me.tbctrlBuffer = New System.Windows.Forms.TabControl()
        Me.tbpBufferRaw = New System.Windows.Forms.TabPage()
        Me.lbxClipboardBuffer = New System.Windows.Forms.ListBox()
        Me.cmsBufferMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiCopyToFav = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRemoveBuff = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGoToTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGoToBottom = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbpUnique = New System.Windows.Forms.TabPage()
        Me.lbxUniqueBuffer = New System.Windows.Forms.ListBox()
        Me.tpInspect = New System.Windows.Forms.TabPage()
        Me.tbxInspect = New System.Windows.Forms.TextBox()
        Me.tpLinks = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbxLinks = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbxEmailTo = New System.Windows.Forms.ComboBox()
        Me.btnFwdLink = New System.Windows.Forms.Button()
        Me.gbConsole = New System.Windows.Forms.GroupBox()
        Me.lbxConsole = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClearClipboard = New System.Windows.Forms.Button()
        Me.btnClearBuffer = New System.Windows.Forms.Button()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.EventLog1 = New System.Diagnostics.EventLog()
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splMain.Panel1.SuspendLayout()
        Me.splMain.Panel2.SuspendLayout()
        Me.splMain.SuspendLayout()
        CType(Me.spcClipboardFavorites, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spcClipboardFavorites.Panel1.SuspendLayout()
        Me.spcClipboardFavorites.Panel2.SuspendLayout()
        Me.spcClipboardFavorites.SuspendLayout()
        Me.gbxClipboard.SuspendLayout()
        Me.gbxFavorites.SuspendLayout()
        Me.cmsFavorites.SuspendLayout()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbBuffer.SuspendLayout()
        Me.tbctrlBuffer.SuspendLayout()
        Me.tbpBufferRaw.SuspendLayout()
        Me.cmsBufferMenu.SuspendLayout()
        Me.tbpUnique.SuspendLayout()
        Me.tpInspect.SuspendLayout()
        Me.tpLinks.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.gbConsole.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ssMain.SuspendLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCBContents
        '
        Me.lblCBContents.AutoEllipsis = True
        Me.lblCBContents.AutoSize = True
        Me.lblCBContents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCBContents.Location = New System.Drawing.Point(3, 16)
        Me.lblCBContents.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCBContents.Name = "lblCBContents"
        Me.lblCBContents.Size = New System.Drawing.Size(33, 13)
        Me.lblCBContents.TabIndex = 0
        Me.lblCBContents.Text = "None"
        '
        'splMain
        '
        Me.splMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splMain.Location = New System.Drawing.Point(0, 0)
        Me.splMain.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.splMain.Name = "splMain"
        Me.splMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splMain.Panel1
        '
        Me.splMain.Panel1.Controls.Add(Me.spcClipboardFavorites)
        Me.splMain.Panel1.Controls.Add(Me.Panel3)
        Me.splMain.Panel1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.splMain.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.splMain.Panel1MinSize = 75
        '
        'splMain.Panel2
        '
        Me.splMain.Panel2.Controls.Add(Me.GroupBox1)
        Me.splMain.Panel2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.splMain.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.splMain.Size = New System.Drawing.Size(599, 509)
        Me.splMain.SplitterDistance = 174
        Me.splMain.SplitterWidth = 8
        Me.splMain.TabIndex = 3
        '
        'spcClipboardFavorites
        '
        Me.spcClipboardFavorites.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.spcClipboardFavorites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spcClipboardFavorites.Location = New System.Drawing.Point(0, 0)
        Me.spcClipboardFavorites.Name = "spcClipboardFavorites"
        Me.spcClipboardFavorites.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'spcClipboardFavorites.Panel1
        '
        Me.spcClipboardFavorites.Panel1.Controls.Add(Me.gbxClipboard)
        '
        'spcClipboardFavorites.Panel2
        '
        Me.spcClipboardFavorites.Panel2.Controls.Add(Me.gbxFavorites)
        Me.spcClipboardFavorites.Size = New System.Drawing.Size(599, 164)
        Me.spcClipboardFavorites.SplitterDistance = 42
        Me.spcClipboardFavorites.SplitterWidth = 10
        Me.spcClipboardFavorites.TabIndex = 12
        '
        'gbxClipboard
        '
        Me.gbxClipboard.Controls.Add(Me.lblCBContents)
        Me.gbxClipboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxClipboard.Location = New System.Drawing.Point(0, 0)
        Me.gbxClipboard.MinimumSize = New System.Drawing.Size(0, 40)
        Me.gbxClipboard.Name = "gbxClipboard"
        Me.gbxClipboard.Size = New System.Drawing.Size(597, 40)
        Me.gbxClipboard.TabIndex = 12
        Me.gbxClipboard.TabStop = False
        Me.gbxClipboard.Text = "Current Clipboard"
        '
        'gbxFavorites
        '
        Me.gbxFavorites.Controls.Add(Me.lbxFavorites)
        Me.gbxFavorites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxFavorites.Location = New System.Drawing.Point(0, 0)
        Me.gbxFavorites.Name = "gbxFavorites"
        Me.gbxFavorites.Size = New System.Drawing.Size(597, 110)
        Me.gbxFavorites.TabIndex = 13
        Me.gbxFavorites.TabStop = False
        Me.gbxFavorites.Text = "Favorites "
        '
        'lbxFavorites
        '
        Me.lbxFavorites.ContextMenuStrip = Me.cmsFavorites
        Me.lbxFavorites.DataSource = Me.Form1BindingSource
        Me.lbxFavorites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxFavorites.FormattingEnabled = True
        Me.lbxFavorites.Location = New System.Drawing.Point(3, 16)
        Me.lbxFavorites.Name = "lbxFavorites"
        Me.lbxFavorites.ScrollAlwaysVisible = True
        Me.lbxFavorites.Size = New System.Drawing.Size(591, 91)
        Me.lbxFavorites.TabIndex = 11
        '
        'cmsFavorites
        '
        Me.cmsFavorites.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiMoveUp, Me.tsmiMoveDown, Me.tsmiMoveToTop, Me.tsmiRemoveFav})
        Me.cmsFavorites.Name = "cmsFavorites"
        Me.cmsFavorites.Size = New System.Drawing.Size(197, 92)
        '
        'tsmiMoveUp
        '
        Me.tsmiMoveUp.Name = "tsmiMoveUp"
        Me.tsmiMoveUp.Size = New System.Drawing.Size(196, 22)
        Me.tsmiMoveUp.Text = "Move Up"
        '
        'tsmiMoveDown
        '
        Me.tsmiMoveDown.Name = "tsmiMoveDown"
        Me.tsmiMoveDown.Size = New System.Drawing.Size(196, 22)
        Me.tsmiMoveDown.Text = "Move Down"
        '
        'tsmiMoveToTop
        '
        Me.tsmiMoveToTop.Name = "tsmiMoveToTop"
        Me.tsmiMoveToTop.Size = New System.Drawing.Size(196, 22)
        Me.tsmiMoveToTop.Text = "Move to Top"
        '
        'tsmiRemoveFav
        '
        Me.tsmiRemoveFav.Name = "tsmiRemoveFav"
        Me.tsmiRemoveFav.Size = New System.Drawing.Size(196, 22)
        Me.tsmiRemoveFav.Text = "Remove from Favorites"
        '
        'Form1BindingSource
        '
        Me.Form1BindingSource.DataSource = GetType(Clipboard_Test_Prj.Form1)
        '
        'Panel3
        '
        Me.Panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel3.Controls.Add(Me.Splitter1)
        Me.Panel3.Location = New System.Drawing.Point(0, 45)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.MinimumSize = New System.Drawing.Size(288, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 117)
        Me.Panel3.TabIndex = 11
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(599, 10)
        Me.Splitter1.TabIndex = 13
        Me.Splitter1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(599, 307)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clipboard History"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SplitContainer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(2, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(595, 256)
        Me.Panel2.TabIndex = 7
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbBuffer)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbConsole)
        Me.SplitContainer1.Size = New System.Drawing.Size(595, 256)
        Me.SplitContainer1.SplitterDistance = 189
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 6
        '
        'gbBuffer
        '
        Me.gbBuffer.Controls.Add(Me.tbctrlBuffer)
        Me.gbBuffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbBuffer.Location = New System.Drawing.Point(0, 0)
        Me.gbBuffer.Name = "gbBuffer"
        Me.gbBuffer.Padding = New System.Windows.Forms.Padding(2)
        Me.gbBuffer.Size = New System.Drawing.Size(595, 189)
        Me.gbBuffer.TabIndex = 0
        Me.gbBuffer.TabStop = False
        Me.gbBuffer.Text = "Buffer"
        '
        'tbctrlBuffer
        '
        Me.tbctrlBuffer.Controls.Add(Me.tbpBufferRaw)
        Me.tbctrlBuffer.Controls.Add(Me.tbpUnique)
        Me.tbctrlBuffer.Controls.Add(Me.tpInspect)
        Me.tbctrlBuffer.Controls.Add(Me.tpLinks)
        Me.tbctrlBuffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbctrlBuffer.Location = New System.Drawing.Point(2, 15)
        Me.tbctrlBuffer.Margin = New System.Windows.Forms.Padding(2)
        Me.tbctrlBuffer.Name = "tbctrlBuffer"
        Me.tbctrlBuffer.SelectedIndex = 0
        Me.tbctrlBuffer.Size = New System.Drawing.Size(591, 172)
        Me.tbctrlBuffer.TabIndex = 7
        '
        'tbpBufferRaw
        '
        Me.tbpBufferRaw.Controls.Add(Me.lbxClipboardBuffer)
        Me.tbpBufferRaw.Location = New System.Drawing.Point(4, 22)
        Me.tbpBufferRaw.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpBufferRaw.Name = "tbpBufferRaw"
        Me.tbpBufferRaw.Padding = New System.Windows.Forms.Padding(2)
        Me.tbpBufferRaw.Size = New System.Drawing.Size(583, 146)
        Me.tbpBufferRaw.TabIndex = 0
        Me.tbpBufferRaw.Text = "Buffer"
        Me.tbpBufferRaw.UseVisualStyleBackColor = True
        '
        'lbxClipboardBuffer
        '
        Me.lbxClipboardBuffer.ContextMenuStrip = Me.cmsBufferMenu
        Me.lbxClipboardBuffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxClipboardBuffer.FormattingEnabled = True
        Me.lbxClipboardBuffer.HorizontalScrollbar = True
        Me.lbxClipboardBuffer.Location = New System.Drawing.Point(2, 2)
        Me.lbxClipboardBuffer.Margin = New System.Windows.Forms.Padding(2)
        Me.lbxClipboardBuffer.Name = "lbxClipboardBuffer"
        Me.lbxClipboardBuffer.ScrollAlwaysVisible = True
        Me.lbxClipboardBuffer.Size = New System.Drawing.Size(579, 142)
        Me.lbxClipboardBuffer.TabIndex = 6
        '
        'cmsBufferMenu
        '
        Me.cmsBufferMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiCopyToFav, Me.tsmiRemoveBuff, Me.tsmiGoToTop, Me.tsmiGoToBottom, Me.tsmiCopy})
        Me.cmsBufferMenu.Name = "cmsBufferMenu"
        Me.cmsBufferMenu.Size = New System.Drawing.Size(182, 114)
        '
        'tsmiCopyToFav
        '
        Me.tsmiCopyToFav.Name = "tsmiCopyToFav"
        Me.tsmiCopyToFav.Size = New System.Drawing.Size(181, 22)
        Me.tsmiCopyToFav.Text = "Move to Favorites"
        '
        'tsmiRemoveBuff
        '
        Me.tsmiRemoveBuff.Name = "tsmiRemoveBuff"
        Me.tsmiRemoveBuff.Size = New System.Drawing.Size(181, 22)
        Me.tsmiRemoveBuff.Text = "Remove from Buffer"
        '
        'tsmiGoToTop
        '
        Me.tsmiGoToTop.Name = "tsmiGoToTop"
        Me.tsmiGoToTop.Size = New System.Drawing.Size(181, 22)
        Me.tsmiGoToTop.Text = "Go to Top"
        '
        'tsmiGoToBottom
        '
        Me.tsmiGoToBottom.Name = "tsmiGoToBottom"
        Me.tsmiGoToBottom.Size = New System.Drawing.Size(181, 22)
        Me.tsmiGoToBottom.Text = "Go to Bottom"
        '
        'tsmiCopy
        '
        Me.tsmiCopy.Name = "tsmiCopy"
        Me.tsmiCopy.Size = New System.Drawing.Size(181, 22)
        Me.tsmiCopy.Text = "Copy"
        '
        'tbpUnique
        '
        Me.tbpUnique.Controls.Add(Me.lbxUniqueBuffer)
        Me.tbpUnique.Location = New System.Drawing.Point(4, 22)
        Me.tbpUnique.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpUnique.Name = "tbpUnique"
        Me.tbpUnique.Padding = New System.Windows.Forms.Padding(2)
        Me.tbpUnique.Size = New System.Drawing.Size(583, 146)
        Me.tbpUnique.TabIndex = 1
        Me.tbpUnique.Text = "Ranked Buffer"
        Me.tbpUnique.UseVisualStyleBackColor = True
        '
        'lbxUniqueBuffer
        '
        Me.lbxUniqueBuffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxUniqueBuffer.FormattingEnabled = True
        Me.lbxUniqueBuffer.Location = New System.Drawing.Point(2, 2)
        Me.lbxUniqueBuffer.Margin = New System.Windows.Forms.Padding(2)
        Me.lbxUniqueBuffer.Name = "lbxUniqueBuffer"
        Me.lbxUniqueBuffer.Size = New System.Drawing.Size(579, 142)
        Me.lbxUniqueBuffer.TabIndex = 0
        '
        'tpInspect
        '
        Me.tpInspect.Controls.Add(Me.tbxInspect)
        Me.tpInspect.Location = New System.Drawing.Point(4, 22)
        Me.tpInspect.Margin = New System.Windows.Forms.Padding(2)
        Me.tpInspect.Name = "tpInspect"
        Me.tpInspect.Padding = New System.Windows.Forms.Padding(2)
        Me.tpInspect.Size = New System.Drawing.Size(583, 146)
        Me.tpInspect.TabIndex = 2
        Me.tpInspect.Text = "Inspect"
        Me.tpInspect.UseVisualStyleBackColor = True
        '
        'tbxInspect
        '
        Me.tbxInspect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxInspect.Location = New System.Drawing.Point(2, 2)
        Me.tbxInspect.Margin = New System.Windows.Forms.Padding(2)
        Me.tbxInspect.Multiline = True
        Me.tbxInspect.Name = "tbxInspect"
        Me.tbxInspect.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbxInspect.Size = New System.Drawing.Size(579, 142)
        Me.tbxInspect.TabIndex = 0
        '
        'tpLinks
        '
        Me.tpLinks.Controls.Add(Me.Panel5)
        Me.tpLinks.Controls.Add(Me.Panel4)
        Me.tpLinks.Location = New System.Drawing.Point(4, 22)
        Me.tpLinks.Name = "tpLinks"
        Me.tpLinks.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLinks.Size = New System.Drawing.Size(583, 146)
        Me.tpLinks.TabIndex = 3
        Me.tpLinks.Text = "Links"
        Me.tpLinks.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lbxLinks)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 32)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(577, 111)
        Me.Panel5.TabIndex = 2
        '
        'lbxLinks
        '
        Me.lbxLinks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxLinks.FormattingEnabled = True
        Me.lbxLinks.Location = New System.Drawing.Point(0, 0)
        Me.lbxLinks.Name = "lbxLinks"
        Me.lbxLinks.Size = New System.Drawing.Size(577, 111)
        Me.lbxLinks.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cbxEmailTo)
        Me.Panel4.Controls.Add(Me.btnFwdLink)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(577, 29)
        Me.Panel4.TabIndex = 0
        '
        'cbxEmailTo
        '
        Me.cbxEmailTo.Enabled = False
        Me.cbxEmailTo.FormattingEnabled = True
        Me.cbxEmailTo.Location = New System.Drawing.Point(81, 4)
        Me.cbxEmailTo.Name = "cbxEmailTo"
        Me.cbxEmailTo.Size = New System.Drawing.Size(262, 21)
        Me.cbxEmailTo.TabIndex = 1
        Me.cbxEmailTo.Text = "Select Recipient"
        Me.ToolTip1.SetToolTip(Me.cbxEmailTo, "Select a recient to fwd copied links")
        '
        'btnFwdLink
        '
        Me.btnFwdLink.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnFwdLink.Enabled = False
        Me.btnFwdLink.Location = New System.Drawing.Point(0, 0)
        Me.btnFwdLink.Name = "btnFwdLink"
        Me.btnFwdLink.Size = New System.Drawing.Size(75, 27)
        Me.btnFwdLink.TabIndex = 0
        Me.btnFwdLink.Text = "Fwd"
        Me.ToolTip1.SetToolTip(Me.btnFwdLink, "Fwd selected link to selected recipient")
        Me.btnFwdLink.UseVisualStyleBackColor = True
        '
        'gbConsole
        '
        Me.gbConsole.Controls.Add(Me.lbxConsole)
        Me.gbConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbConsole.Location = New System.Drawing.Point(0, 0)
        Me.gbConsole.Name = "gbConsole"
        Me.gbConsole.Padding = New System.Windows.Forms.Padding(2)
        Me.gbConsole.Size = New System.Drawing.Size(595, 64)
        Me.gbConsole.TabIndex = 0
        Me.gbConsole.TabStop = False
        Me.gbConsole.Text = "Console"
        '
        'lbxConsole
        '
        Me.lbxConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxConsole.FormattingEnabled = True
        Me.lbxConsole.Location = New System.Drawing.Point(2, 15)
        Me.lbxConsole.Name = "lbxConsole"
        Me.lbxConsole.Size = New System.Drawing.Size(591, 47)
        Me.lbxConsole.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClearClipboard)
        Me.Panel1.Controls.Add(Me.btnClearBuffer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(2, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(595, 34)
        Me.Panel1.TabIndex = 6
        '
        'btnClearClipboard
        '
        Me.btnClearClipboard.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClearClipboard.Location = New System.Drawing.Point(75, 0)
        Me.btnClearClipboard.Name = "btnClearClipboard"
        Me.btnClearClipboard.Size = New System.Drawing.Size(87, 34)
        Me.btnClearClipboard.TabIndex = 7
        Me.btnClearClipboard.Text = "Clear Clipboard"
        Me.btnClearClipboard.UseVisualStyleBackColor = True
        '
        'btnClearBuffer
        '
        Me.btnClearBuffer.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnClearBuffer.Location = New System.Drawing.Point(0, 0)
        Me.btnClearBuffer.Name = "btnClearBuffer"
        Me.btnClearBuffer.Size = New System.Drawing.Size(75, 34)
        Me.btnClearBuffer.TabIndex = 6
        Me.btnClearBuffer.Text = "Clear Buffer"
        Me.btnClearBuffer.UseVisualStyleBackColor = True
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
        Me.ssMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslStatus, Me.tsslCount, Me.tsslCmd, Me.tsslCopyCount, Me.tsslCOCout, Me.tsslPollStat, Me.ToolStripStatusLabel1})
        Me.ssMain.Location = New System.Drawing.Point(0, 487)
        Me.ssMain.Name = "ssMain"
        Me.ssMain.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.ssMain.Size = New System.Drawing.Size(599, 22)
        Me.ssMain.TabIndex = 4
        Me.ssMain.Text = "StatusStrip1"
        '
        'tsslStatus
        '
        Me.tsslStatus.Name = "tsslStatus"
        Me.tsslStatus.Size = New System.Drawing.Size(39, 17)
        Me.tsslStatus.Text = "Ready"
        '
        'tsslCount
        '
        Me.tsslCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsslCount.Name = "tsslCount"
        Me.tsslCount.Size = New System.Drawing.Size(21, 17)
        Me.tsslCount.Text = "##"
        '
        'tsslCmd
        '
        Me.tsslCmd.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsslCmd.Name = "tsslCmd"
        Me.tsslCmd.Size = New System.Drawing.Size(33, 17)
        Me.tsslCmd.Text = "Cmd"
        '
        'tsslCopyCount
        '
        Me.tsslCopyCount.Name = "tsslCopyCount"
        Me.tsslCopyCount.Size = New System.Drawing.Size(71, 17)
        Me.tsslCopyCount.Text = "Copy Count"
        '
        'tsslCOCout
        '
        Me.tsslCOCout.Name = "tsslCOCout"
        Me.tsslCOCout.Size = New System.Drawing.Size(63, 17)
        Me.tsslCOCout.Text = "CO Count:"
        '
        'tsslPollStat
        '
        Me.tsslPollStat.Name = "tsslPollStat"
        Me.tsslPollStat.Size = New System.Drawing.Size(60, 17)
        Me.tsslPollStat.Text = "Polling: --"
        Me.tsslPollStat.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 509)
        Me.Controls.Add(Me.ssMain)
        Me.Controls.Add(Me.splMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(334, 373)
        Me.Name = "Form1"
        Me.Text = "Clipboard++"
        Me.splMain.Panel1.ResumeLayout(False)
        Me.splMain.Panel2.ResumeLayout(False)
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splMain.ResumeLayout(False)
        Me.spcClipboardFavorites.Panel1.ResumeLayout(False)
        Me.spcClipboardFavorites.Panel2.ResumeLayout(False)
        CType(Me.spcClipboardFavorites, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spcClipboardFavorites.ResumeLayout(False)
        Me.gbxClipboard.ResumeLayout(False)
        Me.gbxClipboard.PerformLayout()
        Me.gbxFavorites.ResumeLayout(False)
        Me.cmsFavorites.ResumeLayout(False)
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbBuffer.ResumeLayout(False)
        Me.tbctrlBuffer.ResumeLayout(False)
        Me.tbpBufferRaw.ResumeLayout(False)
        Me.cmsBufferMenu.ResumeLayout(False)
        Me.tbpUnique.ResumeLayout(False)
        Me.tpInspect.ResumeLayout(False)
        Me.tpInspect.PerformLayout()
        Me.tpLinks.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.gbConsole.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCBContents As Label
    Friend WithEvents splMain As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClearBuffer As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents tsslStatus As ToolStripStatusLabel
    Friend WithEvents tsslCount As ToolStripStatusLabel
    Friend WithEvents tsslCmd As ToolStripStatusLabel
    Friend WithEvents btnClearClipboard As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents gbBuffer As GroupBox
    Friend WithEvents lbxClipboardBuffer As ListBox
    Friend WithEvents gbConsole As GroupBox
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents lbxConsole As ListBox
    Friend WithEvents tsslCopyCount As ToolStripStatusLabel
    Friend WithEvents tbctrlBuffer As TabControl
    Friend WithEvents tbpBufferRaw As TabPage
    Friend WithEvents tbpUnique As TabPage
    Friend WithEvents lbxUniqueBuffer As ListBox
    Friend WithEvents tsslCOCout As ToolStripStatusLabel
    Friend WithEvents tpInspect As TabPage
    Friend WithEvents tbxInspect As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tsslPollStat As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents tpLinks As TabPage
    Friend WithEvents lbxLinks As ListBox

    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnFwdLink As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cbxEmailTo As ComboBox
    Friend WithEvents cmsBufferMenu As ContextMenuStrip
    Friend WithEvents tsmiCopyToFav As ToolStripMenuItem
    Friend WithEvents lbxFavorites As ListBox
    Friend WithEvents gbxFavorites As GroupBox
    Friend WithEvents cmsFavorites As ContextMenuStrip
    Friend WithEvents tsmiMoveUp As ToolStripMenuItem
    Friend WithEvents tsmiMoveDown As ToolStripMenuItem
    Friend WithEvents gbxClipboard As GroupBox
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents spcClipboardFavorites As SplitContainer
    Friend WithEvents tsmiRemoveBuff As ToolStripMenuItem
    Friend WithEvents tsmiMoveToTop As ToolStripMenuItem
    Friend WithEvents Form1BindingSource As BindingSource
    Friend WithEvents tsmiGoToTop As ToolStripMenuItem
    Friend WithEvents tsmiGoToBottom As ToolStripMenuItem
    Friend WithEvents tsmiCopy As ToolStripMenuItem
    Friend WithEvents tsmiRemoveFav As ToolStripMenuItem
End Class
