Imports System.IO
Public Class main_frm
    Friend WithEvents API As New EranAPI
    Friend Shared AES As New AESEncrypt
    Friend isFormActiv As Boolean = False
    Private Sub login_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles file_bt.Click
        loginStrip.Show(file_bt, 0, file_bt.Height)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles users_bt.Click
        UsersStrip.Show(users_bt, 0, users_bt.Height)
    End Sub

    Private Sub account_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles account_bt.Click
        AccountStrip.Show(account_bt, 0, account_bt.Height)
    End Sub

    Private Sub tools_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tools_bt.Click
        ToolsStrip.Show(tools_bt, 0, tools_bt.Height)
    End Sub

    Private Sub help_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles help_bt.Click
        HelpStrip.Show(help_bt, 0, help_bt.Height)
    End Sub

    Private Sub main_frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        isFormActiv = True

    End Sub

    Private Sub main_frm_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        isFormActiv = False
    End Sub


    Private Sub main_frm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If authorizedCon = True Then
            API.Disconnect()
            Application.Exit()
        End If
        If userlist.UserList.Count > 0 Then
            Dim ini As New IniFile
            For Each tt In userlist.UserList
                ini.SetKeyValue(tt.Username, "adress", tt.Address)
            Next
            Dim save_trg_enc As Byte()
            AES.Encode(ini.SavetoByte(), save_trg_enc, EranAPI.Account.Password, AESEncrypt.ALGO.RIJNDAEL, 4096)
            File.WriteAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini", save_trg_enc)
        End If
        
    End Sub

    Private Sub main_frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load Panels

        
        If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini") Then
            main_panel.Hide()
            Me.Controls.Add(login.main_panel)
            login.main_panel.Show()
            Dim ini As New IniFile
            ini.Load(My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini")
            login.username_txt.Text = ini.GetKeyValue("account", "username")
            login.password_txt.Focus()
        Else
            main_panel.Hide()
            Me.Controls.Add(create_account.main_panel)
            create_account.main_panel.Show()
        End If
    End Sub
    Friend authorizedCon As Boolean = False
    Private Sub API_AuthorizedConnection(ByVal State As Boolean) Handles API.AuthorizedConnection
        connecting_frame.acc_veri_img.Visible = True
        If State = True Then
            authorizedCon = True

        Else
            authorizedCon = False   
        End If
    End Sub
    Friend connState As Boolean = False
    Private Sub API_ConnectionState(ByVal State As Boolean) Handles API.ConnectionState
        If State = True Then
            connState = True
        Else
            connState = False
        End If
    End Sub
    Private Sub conStateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles conStateTimer.Tick
        If authorizedCon = True Then
            'Wenn die Verbindung erfolgreich hergestellt wurde
            conStateTimer.Enabled = False
            connecting_frame.acc_veri_img.Image = My.Resources.accept
            connecting_frame.acc_veri_img.Visible = True
            Dim trd As New Threading.Thread(AddressOf countDown)
            trd.Start()
            OnlineStateTimer.Enabled = True
            
            load_userlist()
        Else
            connecting_frame.acc_veri_img.Image = My.Resources.cancel
            connecting_frame.acc_veri_img.Visible = True
        End If

        If connState = True Then
            connecting_frame.con_img.Image = My.Resources.accept
            connecting_frame.con_img.Visible = True
        Else
            connecting_frame.con_img.Image = My.Resources.cancel
            connecting_frame.con_img.Visible = True
        End If

    End Sub

    Sub countDown()
        For tt As Integer = 0 To 500000000 : Next
        connecting_frame.Panel1.Hide()
        main_panel.Show()
    End Sub

    Private Sub OnlineStatusTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnlineStateTimer.Tick
        Select Case EranAPI.Account.OnlineState
            Case 0
                profile_img.Image = My.Resources.offlineR
                onlinestatus_bt.Text = "Offline"
                onlinestatus_bt.Image = My.Resources.offline16
            Case 1
                profile_img.Image = My.Resources.busyR
                onlinestatus_bt.Text = "Busy"
                onlinestatus_bt.Image = My.Resources.busy16
            Case 2
                profile_img.Image = My.Resources.onlineR
                onlinestatus_bt.Text = "Online"
                onlinestatus_bt.Image = My.Resources.online16
        End Select
    End Sub
    Private Sub TestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem.Click
        If authorizedCon = True Then
            API.Disconnect()
            Application.Exit()
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        API.Disconnect()
        conStateTimer.Enabled = True
        main_panel.Hide()
        login.main_panel.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        MessageBox.Show("Server key: " & API.ServerKey, "Server key", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        MessageBox.Show("Public key: " & API.PublicKey, "Public key", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub eran_adr_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        For Each tt In userlist.UserList
            MsgBox(tt.Username)
        Next
    End Sub

    Private Sub API_IncomingData(ByVal Message() As Byte) Handles API.IncomingData
        On Error Resume Next
        Dim readStr As String = System.Text.UTF8Encoding.UTF8.GetChars(Message)
        Dim adress_ As String = parameter.read_parameter("/adress ", readStr)
        Dim to_ As String = parameter.read_parameter("/to ", readStr)

        'MsgBox(readStr)
        'Empfange Online Status eines Nutzers
        Dim state_ As String = parameter.read_parameter("/state ", readStr)
        If state_.Length > 0 Then
            Select Case state_
                Case 0
                    For Each tt As ListViewItem In userlist_viewer.Items
                        If tt.SubItems(1).Text = adress_ Then
                            tt.ImageIndex = state_
                        End If
                    Next
                    If PartnerAdress.Text = adress_ Then
                        PartnerProfilImage.Image = My.Resources.offlineR
                    End If
                Case 1
                    For Each tt As ListViewItem In userlist_viewer.Items
                        If tt.SubItems(1).Text = adress_ Then
                            tt.ImageIndex = state_
                        End If
                    Next
                    If PartnerAdress.Text = adress_ Then
                        PartnerProfilImage.Image = My.Resources.busyR
                    End If
                Case 2
                    For Each tt As ListViewItem In userlist_viewer.Items
                        If tt.SubItems(1).Text = adress_ Then
                            tt.ImageIndex = state_
                        End If
                    Next
                    If PartnerAdress.Text = adress_ Then
                        PartnerProfilImage.Image = My.Resources.onlineR
                    End If
            End Select
        End If

        'Empfange Aliasname eines Nutzers
        Dim username As String = parameter.read_parameter("/username ", readStr)
        If username.Length > 0 Then
            For Each tt As ListViewItem In userlist_viewer.Items
                If tt.SubItems(1).Text = adress_ Then
                    If userlist.UserList.Exists(Function(x) x.Address = adress_) = True Then
                        userlist.UserList.RemoveAt(userlist.UserList.FindIndex(Function(x) x.Address = adress_))
                        Dim addUsr As New UserList_
                        addUsr.Address = adress_
                        addUsr.Username = username
                        userlist.UserList.Add(addUsr)
                    Else
                        Dim addUsr As New UserList_
                        addUsr.Address = adress_
                        addUsr.Username = username
                        userlist.UserList.Add(addUsr)
                    End If

                    tt.Text = username
                End If
            Next
        End If
    End Sub

    Private Sub DeleteUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserToolStripMenuItem.Click

        On Error Resume Next
        Dim p As Integer = userlist_viewer.SelectedIndices(0)
        userlist.del_user(userlist_viewer.Items(p).Text)
        userlist_viewer.Items(p).Remove()

    End Sub

    Private Sub login_bt_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onlinestatus_bt.Click
        OnlineContext.Show(onlinestatus_bt, 0, onlinestatus_bt.Height)
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        API.SetOnlineState(2)

    End Sub

    Private Sub BusyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BusyToolStripMenuItem.Click
        API.SetOnlineState(1)
    End Sub

    Private Sub OfflineToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OfflineToolStripMenuItem.Click
        API.SetOnlineState(0)
    End Sub
    Friend ChatSessionList As New List(Of ChatSession)
    Friend Structure ChatSession
        Dim Address As String
        Dim Aliasname As String
        Dim ProfileImage As Image
        Dim Messages As String
    End Structure
    Private Sub API_IncomingMessage(ByVal Address As String, ByVal Aliasname As String, ByVal ExchangeKey As String, ByVal Message As String, ByVal ProfilImage As System.Drawing.Image) Handles API.IncomingMessage
        On Error Resume Next

        If ChatSessionList.Exists(Function(x) x.Address = Address) = True Then
            Dim readLastMSG As String = ChatSessionList.Item(ChatSessionList.FindIndex(Function(x) x.Address = Address)).Messages
            readLastMSG = readLastMSG & Aliasname & ": " & Message & vbNewLine
            ChatSessionList.RemoveAt(ChatSessionList.FindIndex(Function(x) x.Address = Address))
            Dim Chat As New ChatSession
            Chat.Address = Address
            Chat.Aliasname = Aliasname
            Chat.Messages = readLastMSG
            Chat.ProfileImage = ProfilImage
            ChatSessionList.Add(Chat)
            If PartnerAdress.Text = Address Then
                MessagesBox.Text = readLastMSG
            Else
                For Each tt As ListViewItem In userlist_viewer.Items
                    If tt.SubItems(1).Text = Address Then

                        tt.ForeColor = Color.FromArgb(0, 122, 204)
                        tt.Font = New Font("Ubuntu", 12, FontStyle.Bold)
                    End If

                Next
            End If
            If isFormActiv = False Then
                balloon.profileimg.Image = ProfilImage
                balloon.usernametxt.Text = Aliasname
                balloon.messagetxt.Text = Message
                If balloon.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.TopMost = True
                    Me.TopMost = False
                Else
                    Me.BringToFront()
                End If
            End If
        Else
            
            Dim Chat As New ChatSession
            Chat.Address = Address
            Chat.Aliasname = Aliasname
            Chat.Messages = Aliasname & ": " & Message & vbNewLine
            Chat.ProfileImage = ProfilImage
            ChatSessionList.Add(Chat)

            If PartnerAdress.Text = Address Then
                MessagesBox.Text = Aliasname & ": " & Message & vbNewLine
            Else
                For Each tt As ListViewItem In userlist_viewer.Items
                    If tt.SubItems(1).Text = Address Then
                        tt.ForeColor = Color.FromArgb(0, 122, 204)
                        tt.Font = New Font("Ubuntu", 12, FontStyle.Bold)
                    End If
                Next
            End If
            If isFormActiv = False Then
                balloon.usernametxt.Text = Aliasname
                balloon.messagetxt.Text = Message
                If balloon.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.TopMost = True
                    Me.TopMost = False
                End If
            End If
        End If

    End Sub

    Private Sub userlist_viewer_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles userlist_viewer.GotFocus

    End Sub

    Private Sub userlist_viewer_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles userlist_viewer.Invalidated

    End Sub

    Private Sub userlist_viewer_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles userlist_viewer.MouseClick
        Try
            Dim getIndex As Integer = userlist_viewer.SelectedIndices(0)
            'Check of Green
            If userlist_viewer.Items(getIndex).ForeColor = Color.FromArgb(0, 122, 204) Then
                userlist_viewer.Items(getIndex).ForeColor = Color.White
                userlist_viewer.Items(getIndex).Font = New Font("Ubuntu", 12, FontStyle.Regular)
            End If
            PartnerName.Text = userlist_viewer.Items(getIndex).Text
            PartnerAdress.Text = userlist_viewer.Items(getIndex).SubItems(1).Text
            Select Case userlist_viewer.Items(getIndex).ImageIndex
                Case 0
                    PartnerProfilImage.Image = My.Resources.offlineR
                Case 1
                    PartnerProfilImage.Image = My.Resources.busyR
                Case 2
                    PartnerProfilImage.Image = My.Resources.onlineR
            End Select
            If ChatSessionList.Exists(Function(x) x.Address = userlist_viewer.Items(getIndex).SubItems(1).Text) Then

                Dim getListIndex As Integer = ChatSessionList.FindIndex(Function(x) x.Address = userlist_viewer.Items(getIndex).SubItems(1).Text)
                PartnerProfilImage.BackgroundImage = ChatSessionList.Item(getListIndex).ProfileImage
                MessagesBox.Text = ChatSessionList.Item(getListIndex).Messages
                lock_bt.Enabled = True
                Label2.Text = "Encrypted!"
                lock_bt.Image = My.Resources.lock
                InMessege.Enabled = True
                InMessege.BackColor = Color.FromArgb(45, 45, 45)
            Else

                lock_bt.Enabled = False
                lock_bt.Image = My.Resources.unlock
                Label2.Text = "..."
                InMessege.Enabled = False
                InMessege.BackColor = Color.Gray
                PartnerProfilImage.BackgroundImage = My.Resources.profilimage
                MessagesBox.Text = ""

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PartnerAdress_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PartnerAdress.TextChanged
        Select Case EranAPI.Account.OnlineState
            Case 0

            Case Else
                API.SendToServer("/adress " & EranAPI.Account.Address & "; /to " & PartnerAdress.Text & ";")
                If API.isEncryptedUser(PartnerAdress.Text) = False Then
                    Dim trd As New Threading.Thread(AddressOf API.KeyExchange)
                    trd.Start(PartnerAdress.Text)
                End If
        End Select
       

    End Sub
    Private Sub InMessege_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InMessege.KeyDown
        If InMessege.TextLength = 0 Then : Else
            If e.KeyData = Keys.Enter Then
                API.SendToClient(PartnerAdress.Text, InMessege.Text)
                If ChatSessionList.Exists(Function(x) x.Address = PartnerAdress.Text) = True Then
                    Dim getIndex As Integer = ChatSessionList.FindIndex(Function(x) x.Address = PartnerAdress.Text)
                    ChatSessionList.RemoveAt(getIndex)
                End If
                Dim Chat As New ChatSession
                Chat.Address = PartnerAdress.Text
                Chat.Aliasname = PartnerName.Text
                Chat.Messages = MessagesBox.Text & EranAPI.Account.Aliasname & ": " & InMessege.Text & vbNewLine
                MessagesBox.Text = Chat.Messages
                Chat.ProfileImage = PartnerProfilImage.BackgroundImage
                ChatSessionList.Add(Chat)
            End If
        End If
    End Sub

    Private Sub InMessege_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles InMessege.KeyUp
        If e.KeyData = Keys.Enter Then
            InMessege.Text = ""

        End If
    End Sub

    Private Sub API_IncomingProfileImge(ByVal Img As System.Drawing.Image, ByVal Address As String) Handles API.IncomingProfileImge
        If PartnerAdress.Text = Address Then
            PartnerProfilImage.BackgroundImage = Img
            lock_bt.Image = My.Resources.lock
            lock_bt.Enabled = True
            InMessege.Enabled = True
            InMessege.BackColor = Color.FromArgb(45, 45, 45)
        End If
    End Sub

    Private Sub MessagesBox_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles MessagesBox.LinkClicked
        Process.Start(e.LinkText)

    End Sub

    Private Sub MessagesBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MessagesBox.TextChanged

    End Sub

    Sub scrollDown()
        MessagesBox.SelectionStart = MessagesBox.TextLength
        MessagesBox.ScrollToCaret()
    End Sub

    Private Sub TestToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub userlist_viewer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userlist_viewer.SelectedIndexChanged
        chat_panel.Show()
    End Sub

    Private Sub API_KeyExchangeStatus(ByVal Status As Integer, ByVal Address As String) Handles API.KeyExchangeStatus
        If Address = PartnerAdress.Text Then
            Select Case Status
                Case 0
                    Label2.Text = "Send my Public Key..."
                Case 1
                    Label2.Text = "Public Key sendet..."
                Case 2
                    Label2.Text = "Receive Public Key..."
                Case 3
                    Label2.Text = "Send encrypted key back..."
                Case 4
                    Label2.Text = "Decrypt key..."
                Case 5
                    Label2.Text = "Encrypted!"
                Case 6
                    Label2.Text = "Encryption broken!"
            End Select
        End If
        
    End Sub

    Private Sub profile_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_img.Click
        Slider.Slide(account_frm.Panel1)
        account_frm.username_txt.Text = EranAPI.Account.Aliasname
        account_frm.eran_adr_txt.Text = "Eran address: " & EranAPI.Account.Address
        Dim imgMem As New MemoryStream(EranAPI.Account.Profileimage)
        account_frm.profile_img.BackgroundImage = Image.FromStream(imgMem)
        profile_img.BackgroundImage = Image.FromStream(imgMem)
    End Sub



    Private Sub Button5_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseDown
        Button5.Image = My.Resources.recon24
    End Sub

    Private Sub Button5_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Button5.MouseUp
        Button5.Image = My.Resources.recoff24
    End Sub

    Private Sub lock_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lock_bt.Click
        Dim KeyIndex As Integer = API.ChatSessions.FindIndex(Function(x) x.Address = PartnerAdress.Text)
        Dim Key As String = API.ChatSessions(KeyIndex).Key
        MessageBox.Show(API.ChatSessions(KeyIndex).Aliasname & ": " & Key, "Key", MessageBoxButtons.OK, MessageBoxIcon.Information)
        
    End Sub

    Private Sub TestToolStripMenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        Slider.Slide(about.main_panel)
    End Sub

    Private Sub lock_bt_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lock_bt.MouseClick
        
    End Sub

    Private Sub lock_bt_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lock_bt.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            encryption_context.Show(lock_bt, -lock_bt.Width - 80, lock_bt.Height)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        API.SendToClient(PartnerAdress.Text, "/alert 1;")
    End Sub
End Class
