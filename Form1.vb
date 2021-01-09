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

  Private locMaxBufferItemSize As Integer
  Private locMaxBufferTotalSize As Long

  Private coUnique As Collection
  Private currentCB As String

  Private sTmrEnable As Boolean
  Private sCBLock As Boolean
  Private sEmailSuzy As MailAddress
  Private sEmailOdie As MailAddress
  Private sAddressCollection As MailAddressCollection
  Private sFavoriteCollection As StringCollection
  Private sRecentCollection As StringCollection
  Private sRankedCollection As StringCollection



  Private sLinkRecipient As String = "Unspecified"

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

    Debug.WriteLine(totMsg)
    lbxConsole.Items.Insert(0, totMsg)
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
    lbxConsole.Items.Insert(0, totMsg)

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
    lbxConsole.Items.Insert(0, totMsg)

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

    addMsg("d")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub loadSettings()
    addMsg("Load Settings")
    Dim idx As Integer


    Dim tmpAddy00 As New MailAddress(My.Settings.defAddress00, My.Settings.defName00)
    Dim tmpAddy01 As New MailAddress(My.Settings.defAddress01, My.Settings.defName01)

    locMaxBufferItemSize = My.Settings.maxBufferItemSize
    locMaxBufferTotalSize = My.Settings.maxBufferTotalSize

    '---Init address Collection
    If My.Settings.addressCollection Is Nothing Then
      addMsg("My.Settings.addressCollection Is Nothing")
      sAddressCollection = New MailAddressCollection From {
      tmpAddy00,
      tmpAddy01
      }
    Else
      addMsg("Assign RT addresses")
      sAddressCollection = My.Settings.addressCollection

    End If

    '---load Collections
    loadSettingCollection(My.Settings.recentCollection, sRecentCollection)
    loadSettingCollection(My.Settings.favoriteCollection, sFavoriteCollection)

    '---Populate lists
    idx = 0
    For Each a In sAddressCollection
      cbxEmailTo.Items.Add(a)
      idx += 1
    Next

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
        ElseIf tempSize > locMaxBufferItemSize Then
          addMsg("Skipping item: Exceeds max (" & locMaxBufferItemSize & "b) item size")
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
    'My.Settings.addressCollection = sAddressCollection

    addMsg("Setting updated")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub updateGui()

    'tsslCmd.Text = Strings.Left(currentCB, 64)

    lblCBContents.Text = Strings.Left(currentCB, 64)



    tsslCopyCount.Text = "Copy Count:" & copyCount
    tsslCOCout.Text = "CO Count:" & coUnique.Count
    tsslCount.Text = iCount
    tbxMaxItemSize.Text = locMaxBufferItemSize
    tbxMaxTotalBufferSize.Text = locMaxBufferTotalSize

    lbxClipboardBuffer.DataSource = Nothing
    lbxFavorites.DataSource = Nothing

    lbxClipboardBuffer.DataSource = sRecentCollection
    lbxFavorites.DataSource = sFavoriteCollection
    lbxClipboardBuffer.SelectedIndex = lbxClipboardBuffer.Items.Count - 1

    'gbxFavorites.Text = "Favorites - " & lbxFavorites.Items.Count
    tbpBufferRaw.Text = "Buffer - " & lbxClipboardBuffer.Items.Count

    If lbxClipboardBuffer.Items.Count < 1 Then
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

    If lbxLinks.Items.Count > 0 Then
      btnFwdLink.Enabled = True
      cbxEmailTo.Enabled = True
    Else
      btnFwdLink.Enabled = False
      cbxEmailTo.Enabled = False

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


  '----------------------------------------------------------------------------
  Private Function procNewCBData() As Integer

    If cbContent <> "" Then
      'addMsg("Not empty")
      If System.IO.File.Exists("C:\Users\Odie\Music\Sounds\Camera Shutter Click.wav") Then
        My.Computer.Audio.Play("C:\Users\Odie\Music\Sounds\Camera Shutter Click.wav")
      Else
        My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
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
      'updateGui()


    ElseIf My.Computer.Clipboard.ContainsImage() Then

      tsslPollStat.Text = "Image"
      'updateGui()
    ElseIf My.Computer.Clipboard.ContainsData(DataFormats.UnicodeText) Then

      tsslPollStat.Text = "Data"
      'updateGui()

    Else
      unkCount += 1
      tsslPollStat.Text = "Unknown" & unkCount
      'updateGui()

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
  Private Sub btnClearBuffer_Click(sender As Object, e As EventArgs) Handles btnClearBuffer.Click
    addMsg("s")
    lbxClipboardBuffer.Items.Clear()
    lbxLinks.Items.Clear()
    lblCBContents.Text = "Clear Buffer"
    addMsg("d")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub assignCB()
    If currentCB <> "" Then
      addMsg("Assign the CB to the dbl clicked item data")
      My.Computer.Clipboard.SetText(currentCB)

    End If
  End Sub


  '----------------------------------------------------------------------------
  Private Sub setCBData(ByRef sColl As StringCollection, ByVal idx As Integer)
    addMsg("s")
    sCBLock = True
    addMsg("Get clipboard buffer item data")
    currentCB = sColl.Item(idx)
    assignCB()
    If currentCB <> "" Then
      addMsg("Copy clipboard buffer item to inspect tab")
      tbxInspect.Text = currentCB

    End If
    updateGui()
    sCBLock = False
    addMsg("d")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub lbxClipboardBuffer_DoubleClick(sender As Object, e As EventArgs) Handles lbxClipboardBuffer.DoubleClick
    addMsg("lbxClipboardBuffer.DoubleClick")
    setCBData(sRecentCollection, sender.SelectedIndex)
  End Sub


  Private Sub lbxUniqueBuffer_DoubleClick(sender As Object, e As EventArgs) Handles lbxUniqueBuffer.DoubleClick
    addMsg("lbxUniqueBuffer.DoubleClick")
    setCBData(sRankedCollection, sender.SelectedIndex)
  End Sub


  Private Sub lbxFavorites_DoubleClick(sender As Object, e As EventArgs) Handles lbxFavorites.DoubleClick
    addMsg("lbxFavorites.DoubleClick")
    setCBData(sFavoriteCollection, sender.SelectedIndex)
  End Sub


  '----------------------------------------------------------------------------
  Private Sub btnClearClipboard_Click(sender As Object, e As EventArgs) Handles btnClearClipboard.Click
    addMsg("Clear Clipboard")
    My.Computer.Clipboard.Clear()
    lblCBContents.Text = "<empty>"
    lbxUniqueBuffer.Text = "<empty>"
    lbxLinks.Text = "<empty>"
    tsslCmd.Text = "Clear Clipboard"
    addMsg("d")
  End Sub


  '----------------------------------------------------------------------------
  Private Sub lbxClipboardBuffer_MouseHover(sender As Object, e As EventArgs)
    ToolTip1.SetToolTip(lblCBContents, currentCB)
  End Sub


  '----------------------------------------------------------------------------
  Private Sub lblCBContents_MouseHover(sender As Object, e As EventArgs) Handles lblCBContents.MouseHover
    ToolTip1.SetToolTip(lbxClipboardBuffer, currentCB)
  End Sub


  '----------------------------------------------------------------------------
  Sub createMail(body As String, subj As String)
    addMsg("s")
    Try
      addMsg("Create Message")
      Dim newMsg As New MailMessage()
      newMsg.From = sEmailOdie
      newMsg.To.Add(sEmailOdie)
      newMsg.Subject = subj
      newMsg.Body = body

      'New MailAddress("suzypeterson@mac.com", "Suzy")

      addMsg("Create SMTP Client")
      Dim smtpServer As New SmtpClient()
      Dim userState As Object = newMsg
      addMsg("Create Credentials")
      smtpServer.Credentials = New Net.NetworkCredential("odie@odiesystems.com", "!!Jerome19")


      addMsg("Set SMTP")
      smtpServer.Port = 587
      smtpServer.Host = "smtp.dreamhost.com"

      addMsg("Set callback")
      AddHandler smtpServer.SendCompleted, AddressOf sendCompleted
      addMsg("Sending...")

      smtpServer.SendAsync(newMsg, userState)

      addMsg("Msg sent asynchronosly")

    Catch ex As Exception
      Console.ForegroundColor = ConsoleColor.Red
      addMsg("Class -> ClassStorage, Method -> MyContactByMail, Error -> " & ex.Message)
      Console.WriteLine("Class -> ClassStorage, Method -> MyContactByMail, Error -> " & ex.Message)
    End Try

    addMsg("d")

  End Sub


  '----------------------------------------------------------------------------
  Private Sub btnFwdLink_Click(sender As Object, e As EventArgs) Handles btnFwdLink.Click


    'createMail("This is a test", "Subj: Test")

    createMail(lbxLinks.Items(0).ToString, "Send a link")
  End Sub

  '----------------------------------------------------------------------------
  Private Sub sendCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    Dim tmpStr As String
    If e.Cancelled Then
      tmpStr = "Mail send was cancelled"
      addMsg(tmpStr)
      MsgBox(tmpStr, vbOKOnly, "Error")
    ElseIf e.Error IsNot Nothing Then
      tmpStr = "Mail failed to send:" + e.Error.Message
      addMsg(tmpStr)
      MsgBox(tmpStr, vbOKOnly, "SMTP Error")
    Else
      tmpStr = "Mail Sent"
      addMsg(tmpStr)
      MsgBox(tmpStr, vbOKOnly, "Mail Status")
    End If
  End Sub

  Private Sub cbxEmailTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEmailTo.SelectedIndexChanged
    sLinkRecipient = cbxEmailTo.Items(cbxEmailTo.SelectedIndex)
    addMsg("Fwd recipient email set to " & sLinkRecipient)

  End Sub


  '----------------------------------------------------------------------------
  Private Sub tsmiCopyToFav_Click(sender As Object, e As EventArgs) Handles tsmiCopyToFav.Click
    Dim idx As Integer = lbxClipboardBuffer.SelectedIndex
    If idx >= 0 Then
      addMsg("Selected Index:" & idx)

      sCBLock = True
      addMsg("Get clipboard buffer item data")
      currentCB = lbxClipboardBuffer.Items(idx)

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
    lbxClipboardBuffer.SelectedIndex = 0
  End Sub

  Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiCopy.Click
    Dim tmpIdx As Integer = sender.SelectedIndex
    If tmpIdx < 0 Then
      tmpIdx = 0
    End If
    setCBData(sFavoriteCollection, tmpIdx)
  End Sub

  Private Sub GoToBottomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles tsmiGoToBottom.Click
    Dim tmpIdx As Integer = lbxClipboardBuffer.Items.Count - 1
    If tmpIdx < 0 Then
      tmpIdx = 0
    End If
    lbxClipboardBuffer.SelectedIndex = tmpIdx

  End Sub


  Private Sub tsmiRemoveFav_Click(sender As Object, e As EventArgs) Handles tsmiRemoveFav.Click
    Dim idx = lbxFavorites.SelectedIndex
    If idx >= 0 Then
      sFavoriteCollection.RemoveAt(idx)
      updateGui()
    End If
  End Sub

  Private Sub tsmiRemoveBuff_Click(sender As Object, e As EventArgs) Handles tsmiRemoveBuff.Click
    Dim idx = lbxClipboardBuffer.SelectedIndex
    If idx >= 0 Then
      sRecentCollection.RemoveAt(idx)
      updateGui()
    End If
  End Sub
End Class