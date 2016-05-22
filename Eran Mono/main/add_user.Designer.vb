<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_user
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
        Me.main_panel = New System.Windows.Forms.Panel()
        Me.adduser_lb = New System.Windows.Forms.Label()
        Me.add_bt = New System.Windows.Forms.Button()
        Me.address_lb = New System.Windows.Forms.Label()
        Me.address_txt = New System.Windows.Forms.TextBox()
        Me.back_bt = New System.Windows.Forms.Button()
        Me.main_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_panel
        '
        Me.main_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.main_panel.Controls.Add(Me.adduser_lb)
        Me.main_panel.Controls.Add(Me.add_bt)
        Me.main_panel.Controls.Add(Me.address_lb)
        Me.main_panel.Controls.Add(Me.address_txt)
        Me.main_panel.Controls.Add(Me.back_bt)
        Me.main_panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_panel.ForeColor = System.Drawing.Color.White
        Me.main_panel.Location = New System.Drawing.Point(21, 35)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(719, 458)
        Me.main_panel.TabIndex = 2
        '
        'adduser_lb
        '
        Me.adduser_lb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.adduser_lb.AutoSize = True
        Me.adduser_lb.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adduser_lb.Location = New System.Drawing.Point(315, 12)
        Me.adduser_lb.Name = "adduser_lb"
        Me.adduser_lb.Size = New System.Drawing.Size(89, 25)
        Me.adduser_lb.TabIndex = 17
        Me.adduser_lb.Text = "Add User"
        '
        'add_bt
        '
        Me.add_bt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.add_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.add_bt.Enabled = False
        Me.add_bt.FlatAppearance.BorderSize = 0
        Me.add_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_bt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_bt.Location = New System.Drawing.Point(296, 276)
        Me.add_bt.Name = "add_bt"
        Me.add_bt.Size = New System.Drawing.Size(126, 35)
        Me.add_bt.TabIndex = 16
        Me.add_bt.Text = "Add"
        Me.add_bt.UseVisualStyleBackColor = False
        '
        'address_lb
        '
        Me.address_lb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.address_lb.AutoSize = True
        Me.address_lb.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_lb.Location = New System.Drawing.Point(72, 222)
        Me.address_lb.Name = "address_lb"
        Me.address_lb.Size = New System.Drawing.Size(124, 25)
        Me.address_lb.TabIndex = 15
        Me.address_lb.Text = "Eran address:"
        '
        'address_txt
        '
        Me.address_txt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.address_txt.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.address_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.address_txt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.address_txt.Location = New System.Drawing.Point(202, 217)
        Me.address_txt.Name = "address_txt"
        Me.address_txt.Size = New System.Drawing.Size(314, 33)
        Me.address_txt.TabIndex = 14
        Me.address_txt.TabStop = False
        Me.address_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'back_bt
        '
        Me.back_bt.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.back_bt.BackgroundImage = Global.Eran_Mono.My.Resources.Resources.back
        Me.back_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.back_bt.FlatAppearance.BorderSize = 0
        Me.back_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_bt.Location = New System.Drawing.Point(12, 12)
        Me.back_bt.Name = "back_bt"
        Me.back_bt.Size = New System.Drawing.Size(32, 45)
        Me.back_bt.TabIndex = 13
        Me.back_bt.UseVisualStyleBackColor = False
        '
        'add_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 528)
        Me.Controls.Add(Me.main_panel)
        Me.Name = "add_user"
        Me.Text = "add_user"
        Me.main_panel.ResumeLayout(False)
        Me.main_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents back_bt As System.Windows.Forms.Button
    Friend WithEvents address_txt As System.Windows.Forms.TextBox
    Friend WithEvents address_lb As System.Windows.Forms.Label
    Friend WithEvents add_bt As System.Windows.Forms.Button
    Friend WithEvents adduser_lb As System.Windows.Forms.Label
End Class
