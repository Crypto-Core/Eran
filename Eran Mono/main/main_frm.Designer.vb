<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_frm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_frm))
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.userlist_viewer = New System.Windows.Forms.ListView()
        Me.username_column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.address_column = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.onlineIMGlist = New System.Windows.Forms.ImageList(Me.components)
        Me.user_top_panel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.chat_panel = New System.Windows.Forms.Panel()
        Me.MessagesBox = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.encryption_lb = New System.Windows.Forms.Label()
        Me.PartnerAdress = New System.Windows.Forms.Label()
        Me.PartnerName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InMessege = New System.Windows.Forms.TextBox()
        Me.message_in_menu = New System.Windows.Forms.Panel()
        Me.menu = New System.Windows.Forms.Panel()
        Me.help_bt = New System.Windows.Forms.Button()
        Me.tools_bt = New System.Windows.Forms.Button()
        Me.account_bt = New System.Windows.Forms.Button()
        Me.users_bt = New System.Windows.Forms.Button()
        Me.file_bt = New System.Windows.Forms.Button()
        Me.UserListViewerContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.loginStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UsersStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AccountStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.conStateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OnlineStateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.OnlineContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Slide = New System.Windows.Forms.Timer(Me.components)
        Me.encryption_context = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.onlinestatus_bt = New System.Windows.Forms.Button()
        Me.profile_img = New System.Windows.Forms.PictureBox()
        Me.lock_bt = New System.Windows.Forms.Button()
        Me.PartnerProfilImage = New System.Windows.Forms.PictureBox()
        Me.rec_bt = New System.Windows.Forms.Button()
        Me.alert_bt = New System.Windows.Forms.Button()
        Me.sendfile_bt = New System.Windows.Forms.Button()
        Me.DeleteUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.adduser_bt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BusyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfflineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.main_panel.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.user_top_panel.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.chat_panel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.message_in_menu.SuspendLayout()
        Me.menu.SuspendLayout()
        Me.UserListViewerContext.SuspendLayout()
        Me.loginStrip.SuspendLayout()
        Me.UsersStrip.SuspendLayout()
        Me.AccountStrip.SuspendLayout()
        Me.ToolsStrip.SuspendLayout()
        Me.HelpStrip.SuspendLayout()
        Me.OnlineContext.SuspendLayout()
        Me.encryption_context.SuspendLayout()
        CType(Me.profile_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartnerProfilImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'main_panel
        '
        Me.main_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.main_panel.Controls.Add(Me.SplitContainer1)
        Me.main_panel.Controls.Add(Me.menu)
        Me.main_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main_panel.Location = New System.Drawing.Point(0, 0)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(988, 561)
        Me.main_panel.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 29)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.userlist_viewer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.user_top_panel)
        Me.SplitContainer1.Panel1MinSize = 246
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.CausesValidation = False
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(988, 532)
        Me.SplitContainer1.SplitterDistance = 292
        Me.SplitContainer1.TabIndex = 6
        '
        'userlist_viewer
        '
        Me.userlist_viewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.userlist_viewer.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userlist_viewer.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.username_column, Me.address_column})
        Me.userlist_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userlist_viewer.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userlist_viewer.ForeColor = System.Drawing.SystemColors.Window
        Me.userlist_viewer.FullRowSelect = True
        Me.userlist_viewer.LargeImageList = Me.onlineIMGlist
        Me.userlist_viewer.Location = New System.Drawing.Point(0, 124)
        Me.userlist_viewer.MultiSelect = False
        Me.userlist_viewer.Name = "userlist_viewer"
        Me.userlist_viewer.ShowItemToolTips = True
        Me.userlist_viewer.Size = New System.Drawing.Size(292, 408)
        Me.userlist_viewer.SmallImageList = Me.onlineIMGlist
        Me.userlist_viewer.TabIndex = 2
        Me.userlist_viewer.UseCompatibleStateImageBehavior = False
        Me.userlist_viewer.View = System.Windows.Forms.View.Tile
        '
        'username_column
        '
        Me.username_column.Text = "Username"
        Me.username_column.Width = 243
        '
        'address_column
        '
        Me.address_column.Text = "Address"
        '
        'onlineIMGlist
        '
        Me.onlineIMGlist.ImageStream = CType(resources.GetObject("onlineIMGlist.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.onlineIMGlist.TransparentColor = System.Drawing.Color.Transparent
        Me.onlineIMGlist.Images.SetKeyName(0, "offline16.png")
        Me.onlineIMGlist.Images.SetKeyName(1, "busy16.png")
        Me.onlineIMGlist.Images.SetKeyName(2, "online16.png")
        '
        'user_top_panel
        '
        Me.user_top_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.user_top_panel.Controls.Add(Me.onlinestatus_bt)
        Me.user_top_panel.Controls.Add(Me.profile_img)
        Me.user_top_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.user_top_panel.Location = New System.Drawing.Point(0, 0)
        Me.user_top_panel.Name = "user_top_panel"
        Me.user_top_panel.Size = New System.Drawing.Size(292, 124)
        Me.user_top_panel.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel3.Controls.Add(Me.SplitContainer2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(692, 532)
        Me.Panel3.TabIndex = 5
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.SplitContainer2.Panel1.Controls.Add(Me.chat_panel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.InMessege)
        Me.SplitContainer2.Panel2.Controls.Add(Me.rec_bt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.message_in_menu)
        Me.SplitContainer2.Size = New System.Drawing.Size(692, 532)
        Me.SplitContainer2.SplitterDistance = 445
        Me.SplitContainer2.SplitterWidth = 2
        Me.SplitContainer2.TabIndex = 0
        '
        'chat_panel
        '
        Me.chat_panel.Controls.Add(Me.MessagesBox)
        Me.chat_panel.Controls.Add(Me.Panel4)
        Me.chat_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chat_panel.Location = New System.Drawing.Point(0, 0)
        Me.chat_panel.Name = "chat_panel"
        Me.chat_panel.Size = New System.Drawing.Size(692, 445)
        Me.chat_panel.TabIndex = 2
        '
        'MessagesBox
        '
        Me.MessagesBox.AutoWordSelection = True
        Me.MessagesBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.MessagesBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MessagesBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MessagesBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MessagesBox.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessagesBox.ForeColor = System.Drawing.Color.White
        Me.MessagesBox.HideSelection = False
        Me.MessagesBox.Location = New System.Drawing.Point(0, 91)
        Me.MessagesBox.Name = "MessagesBox"
        Me.MessagesBox.ReadOnly = True
        Me.MessagesBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.MessagesBox.Size = New System.Drawing.Size(692, 354)
        Me.MessagesBox.TabIndex = 1
        Me.MessagesBox.Text = " "
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel4.Controls.Add(Me.encryption_lb)
        Me.Panel4.Controls.Add(Me.lock_bt)
        Me.Panel4.Controls.Add(Me.PartnerProfilImage)
        Me.Panel4.Controls.Add(Me.PartnerAdress)
        Me.Panel4.Controls.Add(Me.PartnerName)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(692, 91)
        Me.Panel4.TabIndex = 0
        '
        'encryption_lb
        '
        Me.encryption_lb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.encryption_lb.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.encryption_lb.Location = New System.Drawing.Point(570, 65)
        Me.encryption_lb.Name = "encryption_lb"
        Me.encryption_lb.Size = New System.Drawing.Size(117, 18)
        Me.encryption_lb.TabIndex = 14
        Me.encryption_lb.Text = "..."
        Me.encryption_lb.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PartnerAdress
        '
        Me.PartnerAdress.AutoSize = True
        Me.PartnerAdress.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PartnerAdress.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartnerAdress.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.PartnerAdress.Location = New System.Drawing.Point(88, 53)
        Me.PartnerAdress.Name = "PartnerAdress"
        Me.PartnerAdress.Size = New System.Drawing.Size(48, 13)
        Me.PartnerAdress.TabIndex = 1
        Me.PartnerAdress.Text = "Address"
        '
        'PartnerName
        '
        Me.PartnerName.AutoSize = True
        Me.PartnerName.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PartnerName.Location = New System.Drawing.Point(83, 8)
        Me.PartnerName.Name = "PartnerName"
        Me.PartnerName.Size = New System.Drawing.Size(155, 45)
        Me.PartnerName.TabIndex = 0
        Me.PartnerName.Text = "Username"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(241, 208)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select a Chat user"
        '
        'InMessege
        '
        Me.InMessege.BackColor = System.Drawing.Color.Gray
        Me.InMessege.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InMessege.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InMessege.Enabled = False
        Me.InMessege.Font = New System.Drawing.Font("Segoe UI Semilight", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InMessege.ForeColor = System.Drawing.SystemColors.Info
        Me.InMessege.Location = New System.Drawing.Point(0, 36)
        Me.InMessege.Multiline = True
        Me.InMessege.Name = "InMessege"
        Me.InMessege.Size = New System.Drawing.Size(650, 49)
        Me.InMessege.TabIndex = 0
        '
        'message_in_menu
        '
        Me.message_in_menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.message_in_menu.Controls.Add(Me.alert_bt)
        Me.message_in_menu.Controls.Add(Me.sendfile_bt)
        Me.message_in_menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.message_in_menu.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message_in_menu.Location = New System.Drawing.Point(0, 0)
        Me.message_in_menu.Name = "message_in_menu"
        Me.message_in_menu.Size = New System.Drawing.Size(692, 36)
        Me.message_in_menu.TabIndex = 1
        '
        'menu
        '
        Me.menu.Controls.Add(Me.help_bt)
        Me.menu.Controls.Add(Me.tools_bt)
        Me.menu.Controls.Add(Me.account_bt)
        Me.menu.Controls.Add(Me.users_bt)
        Me.menu.Controls.Add(Me.file_bt)
        Me.menu.Dock = System.Windows.Forms.DockStyle.Top
        Me.menu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(988, 29)
        Me.menu.TabIndex = 0
        '
        'help_bt
        '
        Me.help_bt.AutoSize = True
        Me.help_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.help_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.help_bt.FlatAppearance.BorderSize = 0
        Me.help_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.help_bt.Location = New System.Drawing.Point(249, 0)
        Me.help_bt.Name = "help_bt"
        Me.help_bt.Size = New System.Drawing.Size(52, 29)
        Me.help_bt.TabIndex = 12
        Me.help_bt.Text = "Help"
        Me.help_bt.UseVisualStyleBackColor = False
        '
        'tools_bt
        '
        Me.tools_bt.AutoSize = True
        Me.tools_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.tools_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.tools_bt.FlatAppearance.BorderSize = 0
        Me.tools_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tools_bt.Location = New System.Drawing.Point(194, 0)
        Me.tools_bt.Name = "tools_bt"
        Me.tools_bt.Size = New System.Drawing.Size(55, 29)
        Me.tools_bt.TabIndex = 11
        Me.tools_bt.Text = "Tools"
        Me.tools_bt.UseVisualStyleBackColor = False
        '
        'account_bt
        '
        Me.account_bt.AutoSize = True
        Me.account_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.account_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.account_bt.FlatAppearance.BorderSize = 0
        Me.account_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.account_bt.Location = New System.Drawing.Point(118, 0)
        Me.account_bt.Name = "account_bt"
        Me.account_bt.Size = New System.Drawing.Size(76, 29)
        Me.account_bt.TabIndex = 10
        Me.account_bt.Text = "Account"
        Me.account_bt.UseVisualStyleBackColor = False
        '
        'users_bt
        '
        Me.users_bt.AutoSize = True
        Me.users_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.users_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.users_bt.FlatAppearance.BorderSize = 0
        Me.users_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.users_bt.Location = New System.Drawing.Point(59, 0)
        Me.users_bt.Name = "users_bt"
        Me.users_bt.Size = New System.Drawing.Size(59, 29)
        Me.users_bt.TabIndex = 9
        Me.users_bt.Text = "Users"
        Me.users_bt.UseVisualStyleBackColor = False
        '
        'file_bt
        '
        Me.file_bt.AutoSize = True
        Me.file_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.file_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.file_bt.FlatAppearance.BorderSize = 0
        Me.file_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.file_bt.Location = New System.Drawing.Point(0, 0)
        Me.file_bt.Name = "file_bt"
        Me.file_bt.Size = New System.Drawing.Size(59, 29)
        Me.file_bt.TabIndex = 8
        Me.file_bt.Text = "Login"
        Me.file_bt.UseVisualStyleBackColor = False
        '
        'UserListViewerContext
        '
        Me.UserListViewerContext.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.UserListViewerContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteUserToolStripMenuItem, Me.CopyAddressToolStripMenuItem})
        Me.UserListViewerContext.Name = "UserListViewerContext"
        Me.UserListViewerContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.UserListViewerContext.Size = New System.Drawing.Size(148, 48)
        '
        'loginStrip
        '
        Me.loginStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.loginStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TestToolStripMenuItem})
        Me.loginStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.loginStrip.Name = "loginStrip"
        Me.loginStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.loginStrip.Size = New System.Drawing.Size(95, 26)
        '
        'UsersStrip
        '
        Me.UsersStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.UsersStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsersStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.adduser_bt})
        Me.UsersStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.UsersStrip.Name = "loginStrip"
        Me.UsersStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.UsersStrip.Size = New System.Drawing.Size(125, 26)
        '
        'AccountStrip
        '
        Me.AccountStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.AccountStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ExportAccountToolStripMenuItem, Me.ImportAccountToolStripMenuItem, Me.ToolStripMenuItem13, Me.ToolStripMenuItem11})
        Me.AccountStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.AccountStrip.Name = "loginStrip"
        Me.AccountStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.AccountStrip.ShowImageMargin = False
        Me.AccountStrip.ShowItemToolTips = False
        Me.AccountStrip.Size = New System.Drawing.Size(131, 136)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripMenuItem1.Text = "Disconnect"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripMenuItem2.Text = "Connection"
        '
        'ExportAccountToolStripMenuItem
        '
        Me.ExportAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ExportAccountToolStripMenuItem.Name = "ExportAccountToolStripMenuItem"
        Me.ExportAccountToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ExportAccountToolStripMenuItem.Text = "Export Account"
        '
        'ImportAccountToolStripMenuItem
        '
        Me.ImportAccountToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ImportAccountToolStripMenuItem.Name = "ImportAccountToolStripMenuItem"
        Me.ImportAccountToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ImportAccountToolStripMenuItem.Text = "Import Account"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripMenuItem13.Text = "Setting"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(130, 22)
        Me.ToolStripMenuItem11.Text = "File Transfers"
        '
        'ToolsStrip
        '
        Me.ToolsStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ToolsStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem7})
        Me.ToolsStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolsStrip.Name = "loginStrip"
        Me.ToolsStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolsStrip.Size = New System.Drawing.Size(132, 48)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItem3.Text = "Setting"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(131, 22)
        Me.ToolStripMenuItem7.Text = "Send Ping"
        '
        'HelpStrip
        '
        Me.HelpStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.HelpStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem9})
        Me.HelpStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.HelpStrip.Name = "loginStrip"
        Me.HelpStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.HelpStrip.Size = New System.Drawing.Size(152, 48)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem4.Text = "About"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(151, 22)
        Me.ToolStripMenuItem9.Text = "Check Update"
        '
        'conStateTimer
        '
        Me.conStateTimer.Interval = 10
        '
        'OnlineStateTimer
        '
        '
        'OnlineContext
        '
        Me.OnlineContext.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.OnlineContext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnlineContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem10, Me.BusyToolStripMenuItem, Me.OfflineToolStripMenuItem})
        Me.OnlineContext.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.OnlineContext.Name = "loginStrip"
        Me.OnlineContext.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.OnlineContext.Size = New System.Drawing.Size(111, 70)
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Slide
        '
        Me.Slide.Interval = 1
        '
        'encryption_context
        '
        Me.encryption_context.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.encryption_context.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem12})
        Me.encryption_context.Name = "encryption_context"
        Me.encryption_context.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.encryption_context.Size = New System.Drawing.Size(170, 26)
        '
        'onlinestatus_bt
        '
        Me.onlinestatus_bt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.onlinestatus_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.onlinestatus_bt.FlatAppearance.BorderSize = 0
        Me.onlinestatus_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.onlinestatus_bt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onlinestatus_bt.Image = Global.Eran_Mono.My.Resources.Resources.offline16
        Me.onlinestatus_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.onlinestatus_bt.Location = New System.Drawing.Point(90, 86)
        Me.onlinestatus_bt.Name = "onlinestatus_bt"
        Me.onlinestatus_bt.Size = New System.Drawing.Size(113, 32)
        Me.onlinestatus_bt.TabIndex = 12
        Me.onlinestatus_bt.Text = "Offline"
        Me.onlinestatus_bt.UseVisualStyleBackColor = False
        '
        'profile_img
        '
        Me.profile_img.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.profile_img.BackgroundImage = Global.Eran_Mono.My.Resources.Resources.profilimage
        Me.profile_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.profile_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profile_img.Image = Global.Eran_Mono.My.Resources.Resources.offlineR
        Me.profile_img.Location = New System.Drawing.Point(109, 6)
        Me.profile_img.Name = "profile_img"
        Me.profile_img.Size = New System.Drawing.Size(74, 74)
        Me.profile_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.profile_img.TabIndex = 10
        Me.profile_img.TabStop = False
        '
        'lock_bt
        '
        Me.lock_bt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lock_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lock_bt.Enabled = False
        Me.lock_bt.FlatAppearance.BorderSize = 0
        Me.lock_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lock_bt.Image = Global.Eran_Mono.My.Resources.Resources.unlock
        Me.lock_bt.Location = New System.Drawing.Point(605, 18)
        Me.lock_bt.Name = "lock_bt"
        Me.lock_bt.Size = New System.Drawing.Size(45, 44)
        Me.lock_bt.TabIndex = 13
        Me.lock_bt.Text = "&"
        Me.lock_bt.UseVisualStyleBackColor = False
        '
        'PartnerProfilImage
        '
        Me.PartnerProfilImage.BackgroundImage = Global.Eran_Mono.My.Resources.Resources.profilimage
        Me.PartnerProfilImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PartnerProfilImage.Image = Global.Eran_Mono.My.Resources.Resources.offlineR
        Me.PartnerProfilImage.Location = New System.Drawing.Point(3, 8)
        Me.PartnerProfilImage.Name = "PartnerProfilImage"
        Me.PartnerProfilImage.Size = New System.Drawing.Size(74, 74)
        Me.PartnerProfilImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PartnerProfilImage.TabIndex = 13
        Me.PartnerProfilImage.TabStop = False
        '
        'rec_bt
        '
        Me.rec_bt.AutoSize = True
        Me.rec_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rec_bt.Dock = System.Windows.Forms.DockStyle.Right
        Me.rec_bt.FlatAppearance.BorderSize = 0
        Me.rec_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rec_bt.Image = Global.Eran_Mono.My.Resources.Resources.recoff24
        Me.rec_bt.Location = New System.Drawing.Point(650, 36)
        Me.rec_bt.Name = "rec_bt"
        Me.rec_bt.Size = New System.Drawing.Size(42, 49)
        Me.rec_bt.TabIndex = 18
        Me.rec_bt.UseVisualStyleBackColor = False
        '
        'alert_bt
        '
        Me.alert_bt.AutoSize = True
        Me.alert_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.alert_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.alert_bt.FlatAppearance.BorderSize = 0
        Me.alert_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.alert_bt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alert_bt.Image = Global.Eran_Mono.My.Resources.Resources._1456843663_bell
        Me.alert_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.alert_bt.Location = New System.Drawing.Point(99, 0)
        Me.alert_bt.Name = "alert_bt"
        Me.alert_bt.Size = New System.Drawing.Size(78, 36)
        Me.alert_bt.TabIndex = 14
        Me.alert_bt.Text = "Alert!"
        Me.alert_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.alert_bt.UseVisualStyleBackColor = False
        '
        'sendfile_bt
        '
        Me.sendfile_bt.AutoSize = True
        Me.sendfile_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.sendfile_bt.Dock = System.Windows.Forms.DockStyle.Left
        Me.sendfile_bt.FlatAppearance.BorderSize = 0
        Me.sendfile_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sendfile_bt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sendfile_bt.Image = Global.Eran_Mono.My.Resources.Resources.add
        Me.sendfile_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.sendfile_bt.Location = New System.Drawing.Point(0, 0)
        Me.sendfile_bt.Name = "sendfile_bt"
        Me.sendfile_bt.Size = New System.Drawing.Size(99, 36)
        Me.sendfile_bt.TabIndex = 13
        Me.sendfile_bt.Text = "Send file"
        Me.sendfile_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.sendfile_bt.UseVisualStyleBackColor = False
        '
        'DeleteUserToolStripMenuItem
        '
        Me.DeleteUserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DeleteUserToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DeleteUserToolStripMenuItem.Image = Global.Eran_Mono.My.Resources.Resources.cancel
        Me.DeleteUserToolStripMenuItem.Name = "DeleteUserToolStripMenuItem"
        Me.DeleteUserToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.DeleteUserToolStripMenuItem.Text = "Delete user"
        '
        'CopyAddressToolStripMenuItem
        '
        Me.CopyAddressToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CopyAddressToolStripMenuItem.Image = Global.Eran_Mono.My.Resources.Resources.Copy_16
        Me.CopyAddressToolStripMenuItem.Name = "CopyAddressToolStripMenuItem"
        Me.CopyAddressToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CopyAddressToolStripMenuItem.Text = "Copy Address"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TestToolStripMenuItem.Image = Global.Eran_Mono.My.Resources.Resources.cancel
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.TestToolStripMenuItem.Text = "Exit"
        '
        'adduser_bt
        '
        Me.adduser_bt.ForeColor = System.Drawing.Color.White
        Me.adduser_bt.Image = Global.Eran_Mono.My.Resources.Resources.add
        Me.adduser_bt.Name = "adduser_bt"
        Me.adduser_bt.Size = New System.Drawing.Size(124, 22)
        Me.adduser_bt.Text = "Add User"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem5.Image = Global.Eran_Mono.My.Resources.Resources.key
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem5.Text = "Show PublicKey"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ToolStripMenuItem6.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem6.Image = Global.Eran_Mono.My.Resources.Resources.key
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(164, 22)
        Me.ToolStripMenuItem6.Text = "Show Server key"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem10.Image = Global.Eran_Mono.My.Resources.Resources.online16
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(110, 22)
        Me.ToolStripMenuItem10.Text = "Online"
        '
        'BusyToolStripMenuItem
        '
        Me.BusyToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BusyToolStripMenuItem.Image = Global.Eran_Mono.My.Resources.Resources.busy16
        Me.BusyToolStripMenuItem.Name = "BusyToolStripMenuItem"
        Me.BusyToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.BusyToolStripMenuItem.Text = "Busy"
        '
        'OfflineToolStripMenuItem
        '
        Me.OfflineToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OfflineToolStripMenuItem.Image = Global.Eran_Mono.My.Resources.Resources.offline16
        Me.OfflineToolStripMenuItem.Name = "OfflineToolStripMenuItem"
        Me.OfflineToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.OfflineToolStripMenuItem.Text = "Offline"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem12.Image = Global.Eran_Mono.My.Resources.Resources.refresh16
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem12.Text = "Renew encryption"
        '
        'main_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(988, 561)
        Me.Controls.Add(Me.main_panel)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(660, 428)
        Me.Name = "main_frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eran Mono"
        Me.main_panel.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.user_top_panel.ResumeLayout(False)
        Me.user_top_panel.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.chat_panel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.message_in_menu.ResumeLayout(False)
        Me.message_in_menu.PerformLayout()
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.UserListViewerContext.ResumeLayout(False)
        Me.loginStrip.ResumeLayout(False)
        Me.UsersStrip.ResumeLayout(False)
        Me.AccountStrip.ResumeLayout(False)
        Me.ToolsStrip.ResumeLayout(False)
        Me.HelpStrip.ResumeLayout(False)
        Me.OnlineContext.ResumeLayout(False)
        Me.encryption_context.ResumeLayout(False)
        CType(Me.profile_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartnerProfilImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents user_top_panel As System.Windows.Forms.Panel
    Friend WithEvents menu As System.Windows.Forms.Panel
    Friend WithEvents file_bt As System.Windows.Forms.Button
    Friend WithEvents loginStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents TestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents help_bt As System.Windows.Forms.Button
    Friend WithEvents tools_bt As System.Windows.Forms.Button
    Friend WithEvents account_bt As System.Windows.Forms.Button
    Friend WithEvents users_bt As System.Windows.Forms.Button
    Friend WithEvents UsersStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents adduser_bt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpStrip As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents profile_img As System.Windows.Forms.PictureBox
    Friend WithEvents conStateTimer As System.Windows.Forms.Timer
    Friend WithEvents OnlineStateTimer As System.Windows.Forms.Timer
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents onlineIMGlist As System.Windows.Forms.ImageList
    Friend WithEvents UserListViewerContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DeleteUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents onlinestatus_bt As System.Windows.Forms.Button
    Friend WithEvents OnlineContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BusyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OfflineToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PartnerName As System.Windows.Forms.Label
    Friend WithEvents InMessege As System.Windows.Forms.TextBox
    Friend WithEvents PartnerProfilImage As System.Windows.Forms.PictureBox
    Friend WithEvents PartnerAdress As System.Windows.Forms.Label
    Friend WithEvents userlist_viewer As System.Windows.Forms.ListView
    Friend WithEvents username_column As System.Windows.Forms.ColumnHeader
    Friend WithEvents address_column As System.Windows.Forms.ColumnHeader
    Friend WithEvents MessagesBox As System.Windows.Forms.RichTextBox
    Friend WithEvents message_in_menu As System.Windows.Forms.Panel
    Friend WithEvents alert_bt As System.Windows.Forms.Button
    Friend WithEvents sendfile_bt As System.Windows.Forms.Button
    Friend WithEvents lock_bt As System.Windows.Forms.Button
    Friend WithEvents rec_bt As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents chat_panel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents encryption_lb As System.Windows.Forms.Label
    Friend WithEvents Slide As System.Windows.Forms.Timer
    Friend WithEvents encryption_context As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem

End Class
