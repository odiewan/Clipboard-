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
        Me.gbxClipboard = New System.Windows.Forms.GroupBox()
        Me.gbBuffer = New System.Windows.Forms.GroupBox()
        Me.tbctrlBuffer = New System.Windows.Forms.TabControl()
        Me.tpFavorites = New System.Windows.Forms.TabPage()
        Me.lbxFavorites = New System.Windows.Forms.ListBox()
        Me.cmsFavorites = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiMoveUp = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMoveDown = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiMoveToTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRemoveFav = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbpBufferRaw = New System.Windows.Forms.TabPage()
        Me.lbxClipboardBuffer = New System.Windows.Forms.ListBox()
        Me.cmsBufferMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmiCopyToFav = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiRemoveBuff = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGoToTop = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiGoToBottom = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmiCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.tpLinks = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbxLinks = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbxEmailTo = New System.Windows.Forms.ComboBox()
        Me.btnFwdLink = New System.Windows.Forms.Button()
        Me.tpSettings = New System.Windows.Forms.TabPage()
        Me.gbSettings1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.tbxMaxTotalBufferSize = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxMaxItemSize = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstbClipboard = New System.Windows.Forms.ToolStripTextBox()
        Me.tsbtClearCB = New System.Windows.Forms.ToolStripButton()
        Me.tsbtClearBuffer = New System.Windows.Forms.ToolStripButton()
        Me.tsbtClearFavorites = New System.Windows.Forms.ToolStripButton()
        Me.gbConsole = New System.Windows.Forms.GroupBox()
        Me.lbxConsole = New System.Windows.Forms.ListBox()
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
        Me.EventLog1 = New System.Diagnostics.EventLog()
        CType(Me.splMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splMain.Panel1.SuspendLayout()
        Me.splMain.Panel2.SuspendLayout()
        Me.splMain.SuspendLayout()
        Me.gbxClipboard.SuspendLayout()
        Me.gbBuffer.SuspendLayout()
        Me.tbctrlBuffer.SuspendLayout()
        Me.tpFavorites.SuspendLayout()
        Me.cmsFavorites.SuspendLayout()
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpBufferRaw.SuspendLayout()
        Me.cmsBufferMenu.SuspendLayout()
        Me.tpLinks.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.tpSettings.SuspendLayout()
        Me.gbSettings1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.gbConsole.SuspendLayout()
        Me.ssMain.SuspendLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCBContents
        '
        Me.lblCBContents.AutoEllipsis = True
        Me.lblCBContents.AutoSize = True
        Me.lblCBContents.Location = New System.Drawing.Point(65, 54)
        Me.lblCBContents.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCBContents.Name = "lblCBContents"
        Me.lblCBContents.Size = New System.Drawing.Size(33, 13)
        Me.lblCBContents.TabIndex = 0
        Me.lblCBContents.Text = "None"
        '
        'splMain
        '
        Me.splMain.Location = New System.Drawing.Point(0, 0)
        Me.splMain.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.splMain.Name = "splMain"
        Me.splMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splMain.Panel1
        '
        Me.splMain.Panel1.BackColor = System.Drawing.Color.Lime
        Me.splMain.Panel1.Controls.Add(Me.gbxClipboard)
        Me.splMain.Panel1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.splMain.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.splMain.Panel1MinSize = 50
        '
        'splMain.Panel2
        '
        Me.splMain.Panel2.Controls.Add(Me.gbConsole)
        Me.splMain.Panel2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.splMain.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.splMain.Panel2MinSize = 15
        Me.splMain.Size = New System.Drawing.Size(599, 509)
        Me.splMain.SplitterDistance = 410
        Me.splMain.SplitterWidth = 8
        Me.splMain.TabIndex = 3
        '
        'gbxClipboard
        '
        Me.gbxClipboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.gbxClipboard.Controls.Add(Me.gbBuffer)
        Me.gbxClipboard.Controls.Add(Me.ToolStrip1)
        Me.gbxClipboard.Controls.Add(Me.lblCBContents)
        Me.gbxClipboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbxClipboard.Location = New System.Drawing.Point(0, 0)
        Me.gbxClipboard.MinimumSize = New System.Drawing.Size(0, 30)
        Me.gbxClipboard.Name = "gbxClipboard"
        Me.gbxClipboard.Size = New System.Drawing.Size(599, 400)
        Me.gbxClipboard.TabIndex = 12
        Me.gbxClipboard.TabStop = False
        Me.gbxClipboard.Text = "Current Clipboard"
        '
        'gbBuffer
        '
        Me.gbBuffer.Controls.Add(Me.tbctrlBuffer)
        Me.gbBuffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbBuffer.Location = New System.Drawing.Point(3, 41)
        Me.gbBuffer.Name = "gbBuffer"
        Me.gbBuffer.Padding = New System.Windows.Forms.Padding(2)
        Me.gbBuffer.Size = New System.Drawing.Size(593, 356)
        Me.gbBuffer.TabIndex = 0
        Me.gbBuffer.TabStop = False
        Me.gbBuffer.Text = "Clipboard History"
        '
        'tbctrlBuffer
        '
        Me.tbctrlBuffer.Controls.Add(Me.tpFavorites)
        Me.tbctrlBuffer.Controls.Add(Me.tbpBufferRaw)
        Me.tbctrlBuffer.Controls.Add(Me.tpLinks)
        Me.tbctrlBuffer.Controls.Add(Me.tpSettings)
        Me.tbctrlBuffer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbctrlBuffer.Location = New System.Drawing.Point(2, 15)
        Me.tbctrlBuffer.Margin = New System.Windows.Forms.Padding(2)
        Me.tbctrlBuffer.Name = "tbctrlBuffer"
        Me.tbctrlBuffer.SelectedIndex = 0
        Me.tbctrlBuffer.Size = New System.Drawing.Size(589, 339)
        Me.tbctrlBuffer.TabIndex = 7
        '
        'tpFavorites
        '
        Me.tpFavorites.Controls.Add(Me.lbxFavorites)
        Me.tpFavorites.Location = New System.Drawing.Point(4, 22)
        Me.tpFavorites.Name = "tpFavorites"
        Me.tpFavorites.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFavorites.Size = New System.Drawing.Size(581, 313)
        Me.tpFavorites.TabIndex = 5
        Me.tpFavorites.Text = "Favorites"
        Me.tpFavorites.UseVisualStyleBackColor = True
        '
        'lbxFavorites
        '
        Me.lbxFavorites.ContextMenuStrip = Me.cmsFavorites
        Me.lbxFavorites.DataSource = Me.Form1BindingSource
        Me.lbxFavorites.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxFavorites.FormattingEnabled = True
        Me.lbxFavorites.Location = New System.Drawing.Point(3, 3)
        Me.lbxFavorites.Name = "lbxFavorites"
        Me.lbxFavorites.ScrollAlwaysVisible = True
        Me.lbxFavorites.Size = New System.Drawing.Size(575, 307)
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
    'tbpBufferRaw
    '
    Me.tbpBufferRaw.Controls.Add(Me.lbxClipboardBuffer)
        Me.tbpBufferRaw.Location = New System.Drawing.Point(4, 22)
        Me.tbpBufferRaw.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpBufferRaw.Name = "tbpBufferRaw"
        Me.tbpBufferRaw.Padding = New System.Windows.Forms.Padding(2)
        Me.tbpBufferRaw.Size = New System.Drawing.Size(581, 313)
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
        Me.lbxClipboardBuffer.Size = New System.Drawing.Size(577, 309)
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
        'tpLinks
        '
        Me.tpLinks.Controls.Add(Me.Panel5)
        Me.tpLinks.Controls.Add(Me.Panel4)
        Me.tpLinks.Location = New System.Drawing.Point(4, 22)
        Me.tpLinks.Name = "tpLinks"
        Me.tpLinks.Padding = New System.Windows.Forms.Padding(3)
        Me.tpLinks.Size = New System.Drawing.Size(581, 313)
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
        Me.Panel5.Size = New System.Drawing.Size(575, 278)
        Me.Panel5.TabIndex = 2
        '
        'lbxLinks
        '
        Me.lbxLinks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxLinks.FormattingEnabled = True
        Me.lbxLinks.Location = New System.Drawing.Point(0, 0)
        Me.lbxLinks.Name = "lbxLinks"
        Me.lbxLinks.Size = New System.Drawing.Size(575, 278)
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
        Me.Panel4.Size = New System.Drawing.Size(575, 29)
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
        'tpSettings
        '
        Me.tpSettings.Controls.Add(Me.gbSettings1)
        Me.tpSettings.Location = New System.Drawing.Point(4, 22)
        Me.tpSettings.Name = "tpSettings"
        Me.tpSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpSettings.Size = New System.Drawing.Size(581, 313)
        Me.tpSettings.TabIndex = 4
        Me.tpSettings.Text = "Settings"
        Me.tpSettings.UseVisualStyleBackColor = True
        '
        'gbSettings1
        '
        Me.gbSettings1.Controls.Add(Me.TextBox4)
        Me.gbSettings1.Controls.Add(Me.TextBox3)
        Me.gbSettings1.Controls.Add(Me.tbxMaxTotalBufferSize)
        Me.gbSettings1.Controls.Add(Me.Label4)
        Me.gbSettings1.Controls.Add(Me.Label3)
        Me.gbSettings1.Controls.Add(Me.Label2)
        Me.gbSettings1.Controls.Add(Me.Label1)
        Me.gbSettings1.Controls.Add(Me.tbxMaxItemSize)
        Me.gbSettings1.Location = New System.Drawing.Point(6, 6)
        Me.gbSettings1.Name = "gbSettings1"
        Me.gbSettings1.Size = New System.Drawing.Size(571, 134)
        Me.gbSettings1.TabIndex = 0
        Me.gbSettings1.TabStop = False
        Me.gbSettings1.Text = "Settings"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(145, 97)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(145, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 6
        '
        'tbxMaxTotalBufferSize
        '
        Me.tbxMaxTotalBufferSize.Location = New System.Drawing.Point(145, 45)
        Me.tbxMaxTotalBufferSize.Name = "tbxMaxTotalBufferSize"
        Me.tbxMaxTotalBufferSize.Size = New System.Drawing.Size(100, 20)
        Me.tbxMaxTotalBufferSize.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Max Total Buffer Size, bytes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Max Buffer Item Size, bytes:"
        '
        'tbxMaxItemSize
        '
        Me.tbxMaxItemSize.Location = New System.Drawing.Point(145, 19)
        Me.tbxMaxItemSize.Name = "tbxMaxItemSize"
        Me.tbxMaxItemSize.Size = New System.Drawing.Size(100, 20)
        Me.tbxMaxItemSize.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstbClipboard, Me.tsbtClearCB, Me.tsbtClearBuffer, Me.tsbtClearFavorites})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 16)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(593, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tstbClipboard
        '
        Me.tstbClipboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tstbClipboard.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tstbClipboard.Name = "tstbClipboard"
        Me.tstbClipboard.Size = New System.Drawing.Size(300, 25)
        Me.tstbClipboard.Text = "tstbClipboard"
        '
        'tsbtClearCB
        '
        Me.tsbtClearCB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtClearCB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtClearCB.Image = Global.Clipboard_Test_Prj.My.Resources.Resources.Clipboard_clear
        Me.tsbtClearCB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtClearCB.Name = "tsbtClearCB"
        Me.tsbtClearCB.Size = New System.Drawing.Size(23, 22)
        Me.tsbtClearCB.Text = "ToolStripButton1"
        '
        'tsbtClearBuffer
        '
        Me.tsbtClearBuffer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtClearBuffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtClearBuffer.Image = Global.Clipboard_Test_Prj.My.Resources.Resources.Delete
        Me.tsbtClearBuffer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtClearBuffer.Name = "tsbtClearBuffer"
        Me.tsbtClearBuffer.Size = New System.Drawing.Size(23, 22)
        Me.tsbtClearBuffer.Text = "Clear Buffer"
        '
        'tsbtClearFavorites
        '
        Me.tsbtClearFavorites.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtClearFavorites.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtClearFavorites.Image = CType(resources.GetObject("tsbtClearFavorites.Image"), System.Drawing.Image)
        Me.tsbtClearFavorites.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtClearFavorites.Name = "tsbtClearFavorites"
        Me.tsbtClearFavorites.Size = New System.Drawing.Size(23, 22)
        Me.tsbtClearFavorites.Text = "tsbtClearFavorites"
        '
        'gbConsole
        '
        Me.gbConsole.Controls.Add(Me.lbxConsole)
        Me.gbConsole.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbConsole.Location = New System.Drawing.Point(0, 0)
        Me.gbConsole.Name = "gbConsole"
        Me.gbConsole.Padding = New System.Windows.Forms.Padding(2)
        Me.gbConsole.Size = New System.Drawing.Size(599, 71)
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
        Me.lbxConsole.Size = New System.Drawing.Size(595, 54)
        Me.lbxConsole.TabIndex = 0
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
        'tspbProg
        '
        Me.tspbProg.Name = "tspbProg"
        Me.tspbProg.Size = New System.Drawing.Size(100, 16)
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
        Me.gbxClipboard.ResumeLayout(False)
        Me.gbxClipboard.PerformLayout()
        Me.gbBuffer.ResumeLayout(False)
        Me.tbctrlBuffer.ResumeLayout(False)
        Me.tpFavorites.ResumeLayout(False)
        Me.cmsFavorites.ResumeLayout(False)
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpBufferRaw.ResumeLayout(False)
        Me.cmsBufferMenu.ResumeLayout(False)
        Me.tpLinks.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.tpSettings.ResumeLayout(False)
        Me.gbSettings1.ResumeLayout(False)
        Me.gbSettings1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.gbConsole.ResumeLayout(False)
        Me.ssMain.ResumeLayout(False)
        Me.ssMain.PerformLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCBContents As Label
  Friend WithEvents splMain As SplitContainer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ssMain As StatusStrip
    Friend WithEvents tsslStatus As ToolStripStatusLabel
    Friend WithEvents tsslCount As ToolStripStatusLabel
    Friend WithEvents tsslCmd As ToolStripStatusLabel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents gbBuffer As GroupBox
    Friend WithEvents lbxClipboardBuffer As ListBox
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents tsslCopyCount As ToolStripStatusLabel
    Friend WithEvents tbctrlBuffer As TabControl
    Friend WithEvents tbpBufferRaw As TabPage
    Friend WithEvents tsslCOCout As ToolStripStatusLabel
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
    Friend WithEvents cmsFavorites As ContextMenuStrip
    Friend WithEvents tsmiMoveUp As ToolStripMenuItem
    Friend WithEvents tsmiMoveDown As ToolStripMenuItem
    Friend WithEvents gbxClipboard As GroupBox
    Friend WithEvents tsmiRemoveBuff As ToolStripMenuItem
    Friend WithEvents tsmiMoveToTop As ToolStripMenuItem
    Friend WithEvents Form1BindingSource As BindingSource
    Friend WithEvents tsmiGoToTop As ToolStripMenuItem
    Friend WithEvents tsmiGoToBottom As ToolStripMenuItem
    Friend WithEvents tsmiCopy As ToolStripMenuItem
    Friend WithEvents tsmiRemoveFav As ToolStripMenuItem
    Friend WithEvents tspbProg As ToolStripProgressBar
    Friend WithEvents tpSettings As TabPage
    Friend WithEvents gbSettings1 As GroupBox
    Friend WithEvents tbxMaxItemSize As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents tbxMaxTotalBufferSize As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents tpFavorites As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tstbClipboard As ToolStripTextBox
    Friend WithEvents tsbtClearCB As ToolStripButton
    Friend WithEvents tsbtClearBuffer As ToolStripButton
    Friend WithEvents tsbtClearFavorites As ToolStripButton
    Friend WithEvents gbConsole As GroupBox
    Friend WithEvents lbxConsole As ListBox
End Class
