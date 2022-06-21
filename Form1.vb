Imports System.Collections.Specialized
Imports System.Net.Mail
Imports System.Net.Mail.MailAddress
Imports Microsoft.VisualBasic.CompilerServices



Public Class Form1

    Private cbData As IDataObject = Clipboard.GetDataObject()

    Private cbContent As String
    Private iCount As Integer
    Private copyCount As Integer
    Private unkCount As Integer

    Private coUnique As Collection
    Private currentCB As String
    Private sTmrEnable As Boolean
    Private sCBLock As Boolean
    Private sAddressCollection As MailAddressCollection
    Private sFavoriteCollection As StringCollection
    Private sRecentCollection As StringCollection
    Private sRankedCollection As StringCollection
    Private _searchOption = SearchType.SRCH_NOM




    Private sLinkRecipient As String = "Unspecified"

    Enum SearchType
        SRCH_NOM
        'SRCH_CASE_SENSITIVE
        'SRCH_WHOLE_WORD
        SRCH_EXACT
        NUM_SRCH_TYPES
    End Enum



    '----------------------------------------------------------------------------
    Private Sub addMsg(msg As String)
    Dim prfx As String
    Dim totMsg As String

    '---Get the method name
    prfx = (New System.Diagnostics.StackTrace).GetFrame(1).GetMethod.Name


    If msg IsNot "" Then

      If msg = "s" Then
        totMsg = prfx + "->Start"

      ElseIf msg = "d" Then
        totMsg = prfx + "->Done"
      Else

        totMsg = prfx + "->" + msg
      End If

    Else
      totMsg = prfx
    End If

        Debug.Print(totMsg)
    End Sub


  '----------------------------------------------------------------------------
  Private Sub addStrVar(var As String)
    'Dim varObj As Object
    Dim varName As String
    Dim prfx As String
    Dim totMsg As String

    'varObj = var
    varName = NameOf(var)

    '---Get the method name
    prfx = (New System.Diagnostics.StackTrace).GetFrame(1).GetMethod.Name
    totMsg = prfx & "->" & varName & ":" & var

    Debug.WriteLine(totMsg)
  End Sub


  '----------------------------------------------------------------------------
  Private Sub addIntVar(var As Integer)
    Dim varObj As Object
    Dim varName As String
    Dim prfx As String
    Dim totMsg As String

    '---Get the method name
    prfx = (New System.Diagnostics.StackTrace).GetFrame(1).GetMethod.Name

    '---Create object with passed argumente
    varObj = var

    '---Get the variable name
    varName = NameOf(varObj)

    '---Assemble the complete method
    totMsg = prfx & "->" & varName & ":" & var

    Debug.WriteLine(totMsg)

  End Sub


  '----------------------------------------------------------------------------
  Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    formInit()
  End Sub


  '----------------------------------------------------------------------------
  Public Sub formInit()
    addMsg("s")
    addStrVar("VarTest")

    addIntVar("121")
    copyCount = 0
    unkCount = 0
    iCount = 0
    cbContent = ""
    coUnique = New Collection
    currentCB = ""
    sRecentCollection = New StringCollection()
    sFavoriteCollection = New StringCollection()
    sRankedCollection = New StringCollection()
    sTmrEnable = True
    sCBLock = False

    Timer1.Enabled = sTmrEnable



    loadSettings()
    updateGui()
    tbxMaxTotalBufferSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "maxBufferTotalSize"))
    tbxMaxItemSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", My.Settings, "maxBufferItemSize"))

    addMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub recent_Sort(descAcend As Boolean)
    Dim idx As Integer
    Dim count As Integer = sRecentCollection.Count
    Dim list As New List(Of String)

    If count > 1 Then
      addMsg("More than one item in lbx: sort")
      idx = 0
      For Each str As String In sRecentCollection
        list.Add(str)
      Next

      If descAcend Then
        list.Sort()
      Else
        list.Reverse()
      End If

      sRecentCollection.Clear()
      sRecentCollection.AddRange(list.ToArray)

    Else
      addMsg("One or less items in LB: nothing to sort")

    End If

    updateGui()
    addMsg("Done")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub favoriteSort(descAcend As Boolean)
    Dim idx As Integer
    Dim count As Integer = sFavoriteCollection.Count
    Dim list As New List(Of String)

    If count > 1 Then
      addMsg("More than one item in lbx: sort")
      idx = 0
      For Each str As String In sFavoriteCollection
        addMsg("Populate temp string array for sorting")
        list.Add(str)
      Next

      If descAcend Then
        addMsg("Sort Desc")
        list.Sort()
      Else
        addMsg("Sort Asc")
        list.Reverse()
      End If

      addMsg("clear str collection")
      sFavoriteCollection.Clear()

      addMsg("Repopulate")
      sFavoriteCollection.AddRange(list.ToArray)

    Else
      addMsg("One or less items in LB: nothing to sort")

    End If

    updateGui()
    addMsg("Done")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub loadSettings()
    addMsg("Load Settings")

    '---load Collections
    loadSettingCollection(My.Settings.recentCollection, sRecentCollection)
    loadSettingCollection(My.Settings.favoriteCollection, sFavoriteCollection)



    addMsg("Loaded Settings")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub loadSettingCollection(ByRef srcColl As StringCollection, ByRef destColl As StringCollection)
    Dim tempSize As Integer
    If srcColl Is Nothing Then
      addMsg("Source Collection Is Empty")

    Else
      addMsg("Assign RT recents")
      '----Insert the current buffer with duplicates filtered out
      tspbProg.Maximum = srcColl.Count
      tspbProg.Value = 0
      For Each r In srcColl
        tempSize = r.Length()
        addMsg("Size:" & tempSize)
        If destColl.Contains(r) Then
          addMsg("Skipping duplicate")
        ElseIf tempSize > My.Settings.maxBufferItemSize Then
          addMsg("Skipping item: Exceeds max (" & My.Settings.maxBufferItemSize & "b) item size")
        Else
          addMsg("Adding recent")
          destColl.Add(r)
        End If
        tspbProg.Value += 1
      Next

    End If
  End Sub


  Private Function filterCollection(ByRef srcColl As StringCollection)

    '---Temp collection to hold filtered recents list 
    Dim tmpColl = New StringCollection()


    '----Insert the current buffer with duplicates filtered out
    For Each r In srcColl
      If tmpColl.Contains(r) Then
        addMsg("Skipping duplicate")
      Else
        addMsg("Adding recent")
        tmpColl.Add(r)
      End If
    Next

    Return tmpColl
  End Function


  '----------------------------------------------------------------------------
  Private Sub updateSettings()

    My.Settings.recentCollection = filterCollection(sRecentCollection)
    My.Settings.favoriteCollection = filterCollection(sFavoriteCollection)


    addMsg("Setting updated")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub updateGui()

    'tsslCmd.Text = Strings.Left(currentCB, 64)

    tstbClipboard.Text = Strings.Left(currentCB, 64)



    tsslCopyCount.Text = "Copy Count:" & copyCount
    tsslCOCout.Text = "CO Count:" & coUnique.Count
    tsslCount.Text = iCount
    tbxMaxItemSize.Text = My.Settings.maxBufferItemSize
    tbxMaxTotalBufferSize.Text = My.Settings.maxBufferTotalSize

    lbxRecent.DataSource = Nothing
    lbxFavorites.DataSource = Nothing

    lbxRecent.DataSource = sRecentCollection
    lbxFavorites.DataSource = sFavoriteCollection
    tbpRecent.Text = "Recent - " & lbxRecent.Items.Count

    '---Toolstrip menu item enable handling---
    If lbxRecent.Items.Count < 1 Then
      tsmiCopyToFav.Enabled = False
      tsmiRemoveBuff.Enabled = False
      tsmiGoToTop.Enabled = False
      tsmiGoToBottom.Enabled = False
      tsmiCopy.Enabled = False

    Else
      tsmiCopyToFav.Enabled = True
      tsmiRemoveBuff.Enabled = True
      tsmiGoToTop.Enabled = True
      tsmiGoToBottom.Enabled = True
      tsmiCopy.Enabled = True
    End If

    If lbxFavorites.Items.Count < 1 Then
      tsmiRemoveFav.Enabled = False
      tsmiMoveToTop.Enabled = False
      tsmiMoveDown.Enabled = False
      tsmiMoveDown.Enabled = False
    Else
      tsmiRemoveFav.Enabled = True
      tsmiMoveToTop.Enabled = True
      tsmiMoveDown.Enabled = True
      tsmiMoveDown.Enabled = True
    End If


  End Sub


  '----------------------------------------------------------------------------
  Private Sub pushBufferList()
    sRecentCollection.Add(currentCB)

  End Sub

  '----------------------------------------------------------------------------
  Private Function isDupInColl(ByRef sColl As StringCollection)
    Dim cbDupCnt As Integer = 0

    For Each d As String In sColl
      If currentCB = d Then
        cbDupCnt += 1

      End If
    Next
    Return cbDupCnt
  End Function

  '----------------------------------------------------------------------------
  Private Sub pushUniqueList()

    If isDupInColl(sRankedCollection) = 0 Then
      sRankedCollection.Insert(0, currentCB)
    End If

  End Sub


  '----------------------------------------------------------------------------
  Private Sub pushFavoriteList()
    If isDupInColl(sFavoriteCollection) = 0 Then
      sFavoriteCollection.Insert(0, currentCB)
    End If


  End Sub

  Private Function playSound(fullPath As String) As Boolean

    If System.IO.File.Exists(fullPath) Then
      My.Computer.Audio.Play(fullPath)
      Return True
    Else
      Console.WriteLine("Error: Invalid file path")
      'MsgBox("Errorr: Invalid file path", vbOKOnly, "File Error!")
      Return False
    End If
  End Function



  '----------------------------------------------------------------------------
  Private Function procNewCBData() As Integer
    If cbContent <> "" Then
      'addMsg("Not empty")
      If My.Settings.enableAlertSound Then
        If playSound(My.Settings.copyAlertSoundFile) Then
        Else
          My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
        End If
      End If


      addMsg("New CB content")
      currentCB = cbContent
      pushBufferList()
      pushUniqueList()

      copyCount += 1

      updateGui()

      Return 1
    Else
      'addMsg("empty")
      Return 0
    End If
  End Function

  '----------------------------------------------------------------------------
  Private Sub getClipboardContent()
    Static ntCnt As Integer = 0
    Static typeStr As String = "NA"

    If My.Computer.Clipboard.ContainsText() Then
      If cbContent <> My.Computer.Clipboard.GetText() And sCBLock = False Then
        cbContent = My.Computer.Clipboard.GetText()

        tsslPollStat.Text = "Text"
        If procNewCBData() Then
          tsslCmd.Text = "New"
        End If
        updateGui()
      End If

    ElseIf My.Computer.Clipboard.ContainsAudio() Then
      tsslPollStat.Text = "Audio"

    ElseIf My.Computer.Clipboard.ContainsImage() Then
      tsslPollStat.Text = "Image"

    ElseIf My.Computer.Clipboard.ContainsData(DataFormats.UnicodeText) Then
      tsslPollStat.Text = "Data"

    Else
      unkCount += 1
      tsslPollStat.Text = "Unknown" & unkCount

    End If

  End Sub

    Private Sub find()
        Dim start As Integer = 0
        Dim idx As Integer
        Dim foundCnt As Integer
        Dim searchStr = tstbRecentFind.Text
        lbxRecent.SelectionMode = SelectionMode.MultiSimple
        lbxRecent.SelectedItems.Clear()

        If searchStr IsNot "" Then
            If _searchOption = SearchType.SRCH_EXACT Then
                idx = lbxRecent.FindStringExact(searchStr, start)
            Else
                idx = lbxRecent.FindString(searchStr, start)
            End If
            Do While idx <> -1 And start < lbxRecent.Items.Count
                lbxRecent.SetSelected(idx, True)
                If _searchOption = SearchType.SRCH_EXACT Then
                    idx = lbxRecent.FindStringExact(searchStr, start)
                Else
                    idx = lbxRecent.FindString(searchStr, start)
                End If
                start += 1
            Loop


            If idx > -1 Then
                tsslResult.Text = "Found " & foundCnt.ToString & " instances"
            Else
                tsslResult.Text = "String not found"
            End If

        Else
            tsslResult.Text = "Search String Empty"
        End If

    End Sub

    '----------------------------------------------------------------------------
    Private Sub btnGetCB_Click(sender As Object, e As EventArgs)
    addMsg("s")
    getClipboardContent()
    addMsg("d")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub hndlClipboardChanged(sender As Object, e As EventArgs) Handles Timer1.Tick
    If sCBLock = False Then
      getClipboardContent()
      iCount += 1
    Else

    End If
    sCBLock = False

  End Sub



  '----------------------------------------------------------------------------
  Private Sub assignCB(nText As String)
    If nText <> "" Then
      addMsg("Assign the CB to the dbl clicked item data")
      My.Computer.Clipboard.SetText(nText)

    End If
  End Sub

  '----------------------------------------------------------------------------
  Private Sub setCBData(nText)
    addMsg("s")
    sCBLock = True
    addMsg("Set the current CB to " & nText)
    currentCB = nText
    assignCB(currentCB)
    updateGui()
    sCBLock = False
    addMsg("d")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub setCBDataFromSC(ByRef sColl As StringCollection, ByVal idx As Integer)
    addMsg("s")
    Dim nText As String
    sCBLock = True
    If sColl.Count > 0 Then
      addMsg("Get clipboard buffer item data")
      nText = sColl.Item(idx)
      setCBData(nText)
    Else
      addMsg("lbxClipboard buffer is empty")
    End If

    addMsg("d")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub clearClipboard()
    addMsg("Clear Clipboard")
    My.Computer.Clipboard.Clear()
    tstbClipboard.Text = "<empty>"
    tsslCmd.Text = "Clear Clipboard"
    addMsg("d")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub clearBuffer()

    sRecentCollection.Clear()

    lbxRecent.DataSource = Nothing

    lbxRecent.DataSource = sRecentCollection
    lbxRecent.Text = "<empty>"
    lbxRecent.Invalidate()

    tsslCmd.Text = "Clear Buffer"
    addMsg("d")
    updateGui()
  End Sub

  '----------------------------------------------------------------------------
  Private Sub clearFavorites()

  End Sub


    ''----------------------------------------------------------------------------
    'Sub createMail(body As String, subj As String)
    '  addMsg("s")
    '  Try
    '    addMsg("Create Message")
    '    Dim newMsg As New MailMessage()
    '    newMsg.From = sEmailOdie
    '    newMsg.To.Add(sEmailOdie)
    '    newMsg.Subject = subj
    '    newMsg.Body = body

    '    'New MailAddress("suzypeterson@mac.com", "Suzy")

    '    addMsg("Create SMTP Client")
    '    Dim smtpServer As New SmtpClient()
    '    Dim userState As Object = newMsg
    '    addMsg("Create Credentials")
    '    smtpServer.Credentials = New Net.NetworkCredential("odie@odiesystems.com", "!!Jerome19")


    '    addMsg("Set SMTP")
    '    smtpServer.Port = 587
    '    smtpServer.Host = "smtp.dreamhost.com"

    '    addMsg("Set callback")
    '    AddHandler smtpServer.SendCompleted, AddressOf sendCompleted
    '    addMsg("Sending...")

    '    smtpServer.SendAsync(newMsg, userState)

    '    addMsg("Msg sent asynchronosly")

    '  Catch ex As Exception
    '    Console.ForegroundColor = ConsoleColor.Red
    '    addMsg("Class -> ClassStorage, Method -> MyContactByMail, Error -> " & ex.Message)
    '    Console.WriteLine("Class -> ClassStorage, Method -> MyContactByMail, Error -> " & ex.Message)
    '  End Try

    '  addMsg("d")

    'End Sub


    ''----------------------------------------------------------------------------
    'Private Sub sendCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    '  Dim tmpStr As String
    '  If e.Cancelled Then
    '    tmpStr = "Mail send was cancelled"
    '    addMsg(tmpStr)
    '    MsgBox(tmpStr, vbOKOnly, "Error")
    '  ElseIf e.Error IsNot Nothing Then
    '    tmpStr = "Mail failed to send:" + e.Error.Message
    '    addMsg(tmpStr)
    '    MsgBox(tmpStr, vbOKOnly, "SMTP Error")
    '  Else
    '    tmpStr = "Mail Sent"
    '    addMsg(tmpStr)
    '    MsgBox(tmpStr, vbOKOnly, "Mail Status")
    '  End If
    'End Sub

    '----------------------------------------------------------------------------


    Private Sub lbxFavorites_DoubleClick(sender As Object, e As EventArgs) Handles lbxFavorites.DoubleClick
    addMsg("lbxFavorites.DoubleClick")
    setCBDataFromSC(sFavoriteCollection, sender.SelectedIndex)
  End Sub


    '----------------------------------------------------------------------------
    Private Sub lbxRecent_MouseHover(sender As Object, e As EventArgs)
        ToolTip1.SetToolTip(lbxRecent, currentCB)
    End Sub


    '----------------------------------------------------------------------------
    Private Sub tstbClipboard_MouseHover(sender As Object, e As EventArgs)
    'ToolTip1.SetToolTip(tstbClipboard, currentCB)
    tstbClipboard.ToolTipText = currentCB
  End Sub



  '----------------------------------------------------------------------------
  Private Sub tsmiCopyToFav_Click(sender As Object, e As EventArgs) Handles tsmiCopyToFav.Click
    Dim idx As Integer = lbxRecent.SelectedIndex
    If idx >= 0 Then
      addMsg("Selected Index:" & idx)

      sCBLock = True
      addMsg("Get clipboard buffer item data")
      currentCB = lbxRecent.Items(idx)

      If currentCB <> "" Then
        addMsg("Insert item into favorites")
        pushFavoriteList()

      End If
      updateGui()
    Else
      addMsg("Invalid index")

    End If
  End Sub


  '----------------------------------------------------------------------------
  Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
    updateSettings()
  End Sub


  '----------------------------------------------------------------------------
  Private Sub tsmiMoveUp_Click(sender As Object, e As EventArgs) Handles tsmiMoveUp.Click
    Dim idx = lbxFavorites.SelectedIndex

    If (idx >= 0) Then
      addMsg("Move Fav Up")

      If (idx > 0 And sFavoriteCollection.Count > idx) Then


        Dim tmpStr = sFavoriteCollection.Item(idx)
        sFavoriteCollection.Item(idx) = sFavoriteCollection.Item(idx - 1)
        sFavoriteCollection.Item(idx - 1) = tmpStr
        updateGui()


      End If
    Else
      addMsg("Invalid index")
    End If
  End Sub

  '----------------------------------------------------------------------------
  Private Sub tsmiMoveDown_Click(sender As Object, e As EventArgs) Handles tsmiMoveDown.Click
    Dim idx = lbxFavorites.SelectedIndex
    If (idx >= 0) Then

      addMsg("Move Fav Down")

      If (idx < (sFavoriteCollection.Count - 1) And sFavoriteCollection.Count > 1) Then


        Dim tmpStr = sFavoriteCollection.Item(idx)
        sFavoriteCollection.Item(idx) = sFavoriteCollection.Item(idx + 1)
        sFavoriteCollection.Item(idx + 1) = tmpStr
        updateGui()

      End If
    Else
      addMsg("Invalid index")
    End If
  End Sub

  Private Sub tsmiMoveToTop_Click(sender As Object, e As EventArgs) Handles tsmiMoveToTop.Click
    Dim idx = lbxFavorites.SelectedIndex
    Dim tmpStr As String = ""
    If (idx > 0 And sFavoriteCollection.Count > 0) Then

      addMsg("Move Fav To Top (to index 0)")

      If idx < sFavoriteCollection.Count Then

        tmpStr = sFavoriteCollection.Item(idx)
        For i = idx To 1 Step -1

          sFavoriteCollection.Item(i) = sFavoriteCollection.Item(i - 1)
        Next
        sFavoriteCollection.Item(0) = tmpStr
        updateGui()
      End If
    Else
      addMsg("Invalid index")
    End If
  End Sub

  Private Sub GoToTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiGoToTop.Click
    lbxRecent.SelectedIndex = 0
  End Sub

  Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click
    Dim tmpIdx As Integer = sender.SelectedIndex
    If tmpIdx < 0 Then
      tmpIdx = 0
    End If
    setCBDataFromSC(sFavoriteCollection, tmpIdx)
  End Sub

  Private Sub GoToBottomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiGoToBottom.Click
    Dim tmpIdx As Integer = lbxRecent.Items.Count - 1
    If tmpIdx < 0 Then
      tmpIdx = 0
    End If
    lbxRecent.SelectedIndex = tmpIdx

  End Sub


  Private Sub tsmiRemoveFav_Click(sender As Object, e As EventArgs) Handles tsmiRemoveFav.Click
    Dim idx = lbxFavorites.SelectedIndex
    If idx >= 0 Then
      sFavoriteCollection.RemoveAt(idx)
      updateGui()
    End If
  End Sub

  Private Sub tsmiRemoveBuff_Click(sender As Object, e As EventArgs) Handles tsmiRemoveBuff.Click
    Dim idx = lbxRecent.SelectedIndex
    If idx >= 0 Then
      sRecentCollection.RemoveAt(idx)
      updateGui()
    End If
  End Sub

  Private Sub tsbtClearBuffer_Click(sender As Object, e As EventArgs) Handles tsbtClearBuffer.Click
    clearBuffer()
  End Sub

  Private Sub tsbtClearCB_Click(sender As Object, e As EventArgs) Handles tsbtClearCB.Click
    clearClipboard()
  End Sub


  Private Sub btnTestSound_Click(sender As Object, e As EventArgs) Handles btnTestSound.Click
    playSound(My.Settings.copyAlertSoundFile)
  End Sub

  Private Sub btnBrowseAudioFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseAudioFolder.Click
    If fbdSoundFolder.ShowDialog = DialogResult.OK Then
      My.Settings.soundFolder = fbdSoundFolder.SelectedPath
      ofdSoundFile.InitialDirectory = My.Settings.soundFolder
    End If
  End Sub

  Private Sub btnPickSoundFile_Click(sender As Object, e As EventArgs) Handles btnPickSoundFile.Click
    If ofdSoundFile.ShowDialog = DialogResult.OK Then
      My.Settings.copyAlertSoundFile = ofdSoundFile.FileName
    End If

  End Sub

  Private Sub btnShowFolder_Click(sender As Object, e As EventArgs) Handles btnShowFolder.Click
    Process.Start("explorer.exe", My.Settings.soundFolder)
  End Sub

  Private Sub tstbClipboard_DoubleClick(sender As Object, e As EventArgs) Handles tstbClipboard.DoubleClick
    addMsg("lbxRecent.DoubleClick")
    setCBDataFromSC(sFavoriteCollection, sender.SelectedIndex)
    setCBData(tstbClipboard.Text)
  End Sub

  Private Sub tsbtClearConsole_Click(sender As Object, e As EventArgs)
    addMsg("tsbtClearConsole.Click")
  End Sub

  Private Sub tsmiSortAToZ_Click(sender As Object, e As EventArgs) Handles tsmiSortAToZ.Click
    addMsg("Click")
    recent_Sort(True)
  End Sub

  Private Sub tsmiSortZToA_Click(sender As Object, e As EventArgs) Handles tsmiSortZToA.Click
    addMsg("Click")
    recent_Sort(False)

  End Sub

    Private Sub lbxRecent_DoubleClick(sender As Object, e As EventArgs) Handles lbxRecent.DoubleClick
        addMsg("DoubleClick")
        setCBDataFromSC(sRecentCollection, sender.SelectedIndex)
    End Sub

    Private Sub tsmiSortAToZ1_Click(sender As Object, e As EventArgs) Handles tsmiSortAToZ1.Click
        favoriteSort(False)
    End Sub

    Private Sub tsmiSortZToA1_Click(sender As Object, e As EventArgs) Handles tsmiSortZToA1.Click
        favoriteSort(True)

    End Sub

    Private Sub cmsRecentMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsRecentMenu.Opening

    End Sub

    Private Sub cmsFavorites_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsFavorites.Opening

    End Sub

    Private Sub tsbtRecentFind_Click(sender As Object, e As EventArgs) Handles tsbtRecentFind.Click
        find()

    End Sub

    Private Sub tstbRecentFind_Click(sender As Object, e As EventArgs) Handles tstbRecentFind.Click
        tstbRecentFind.Text = ""
    End Sub

    Private Sub tstbRecentFind_KeyDown(sender As Object, e As KeyEventArgs) Handles tstbRecentFind.KeyDown
        If e.KeyCode = Keys.Enter Then
            find()
        End If
    End Sub

    Private Sub tsbtRecentCase_Click(sender As Object, e As EventArgs) Handles tsbtRecentCase.Click
        If tsbtRecentCase.Checked Or tsbtRecentWhole.Checked Then
            _searchOption = SearchType.SRCH_EXACT
        Else

            _searchOption = SearchType.SRCH_NOM
        End If


    End Sub
End Class