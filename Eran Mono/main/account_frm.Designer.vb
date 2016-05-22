<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class account_frm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.notification_cb = New System.Windows.Forms.CheckBox()
        Me.eran_adr_txt = New System.Windows.Forms.Label()
        Me.login_bt = New System.Windows.Forms.Button()
        Me.username_txt = New System.Windows.Forms.TextBox()
        Me.profile_img = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.profile_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Panel1.Controls.Add(Me.notification_cb)
        Me.Panel1.Controls.Add(Me.eran_adr_txt)
        Me.Panel1.Controls.Add(Me.login_bt)
        Me.Panel1.Controls.Add(Me.username_txt)
        Me.Panel1.Controls.Add(Me.profile_img)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(526, 481)
        Me.Panel1.TabIndex = 0
        '
        'notification_cb
        '
        Me.notification_cb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.notification_cb.AutoSize = True
        Me.notification_cb.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notification_cb.Location = New System.Drawing.Point(45, 274)
        Me.notification_cb.Name = "notification_cb"
        Me.notification_cb.Size = New System.Drawing.Size(107, 25)
        Me.notification_cb.TabIndex = 16
        Me.notification_cb.Text = "notification"
        Me.notification_cb.UseVisualStyleBackColor = True
        '
        'eran_adr_txt
        '
        Me.eran_adr_txt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.eran_adr_txt.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eran_adr_txt.ForeColor = System.Drawing.SystemColors.Control
        Me.eran_adr_txt.Location = New System.Drawing.Point(41, 222)
        Me.eran_adr_txt.Name = "eran_adr_txt"
        Me.eran_adr_txt.Size = New System.Drawing.Size(445, 28)
        Me.eran_adr_txt.TabIndex = 14
        Me.eran_adr_txt.Text = "Eran address: 00000000000000000000000000000000"
        Me.eran_adr_txt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'login_bt
        '
        Me.login_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.login_bt.BackgroundImage = Global.Eran_Mono.My.Resources.Resources.back
        Me.login_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.login_bt.FlatAppearance.BorderSize = 0
        Me.login_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_bt.Location = New System.Drawing.Point(12, 12)
        Me.login_bt.Name = "login_bt"
        Me.login_bt.Size = New System.Drawing.Size(32, 45)
        Me.login_bt.TabIndex = 13
        Me.login_bt.UseVisualStyleBackColor = False
        '
        'username_txt
        '
        Me.username_txt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.username_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.username_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username_txt.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txt.ForeColor = System.Drawing.Color.White
        Me.username_txt.Location = New System.Drawing.Point(136, 170)
        Me.username_txt.Name = "username_txt"
        Me.username_txt.Size = New System.Drawing.Size(255, 28)
        Me.username_txt.TabIndex = 12
        Me.username_txt.Text = "username"
        Me.username_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'profile_img
        '
        Me.profile_img.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.profile_img.BackgroundImage = Global.Eran_Mono.My.Resources.Resources.profilimage
        Me.profile_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.profile_img.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profile_img.Location = New System.Drawing.Point(226, 90)
        Me.profile_img.Name = "profile_img"
        Me.profile_img.Size = New System.Drawing.Size(74, 74)
        Me.profile_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.profile_img.TabIndex = 11
        Me.profile_img.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "PNG|*.png|JPEG|.*jpeg|BMP|*.bmp|GIF|*.gif|JPG|*jpg"
        '
        'account_frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 493)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "account_frm"
        Me.Text = "account_frm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.profile_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents username_txt As System.Windows.Forms.TextBox
    Friend WithEvents profile_img As System.Windows.Forms.PictureBox
    Friend WithEvents login_bt As System.Windows.Forms.Button
    Friend WithEvents eran_adr_txt As System.Windows.Forms.Label
    Friend WithEvents notification_cb As System.Windows.Forms.CheckBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
