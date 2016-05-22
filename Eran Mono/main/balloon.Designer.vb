<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class balloon
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
        Me.slide = New System.Windows.Forms.Timer(Me.components)
        Me.closebt = New System.Windows.Forms.Button()
        Me.usernametxt = New System.Windows.Forms.Label()
        Me.profileimg = New System.Windows.Forms.PictureBox()
        Me.messagetxt = New System.Windows.Forms.Label()
        Me.opacityOut = New System.Windows.Forms.Timer(Me.components)
        Me.countDown = New System.Windows.Forms.Timer(Me.components)
        CType(Me.profileimg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'slide
        '
        Me.slide.Interval = 1
        '
        'closebt
        '
        Me.closebt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.closebt.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.closebt.FlatAppearance.BorderSize = 0
        Me.closebt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closebt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closebt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.closebt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.closebt.Location = New System.Drawing.Point(331, 4)
        Me.closebt.Name = "closebt"
        Me.closebt.Size = New System.Drawing.Size(24, 24)
        Me.closebt.TabIndex = 13
        Me.closebt.Text = "X"
        Me.closebt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.closebt.UseVisualStyleBackColor = False
        '
        'usernametxt
        '
        Me.usernametxt.AutoSize = True
        Me.usernametxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.usernametxt.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernametxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.usernametxt.Location = New System.Drawing.Point(82, 9)
        Me.usernametxt.Name = "usernametxt"
        Me.usernametxt.Size = New System.Drawing.Size(77, 25)
        Me.usernametxt.TabIndex = 14
        Me.usernametxt.Text = "User XY"
        '
        'profileimg
        '
        Me.profileimg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.profileimg.Image = Global.Eran_Mono.My.Resources.Resources.profilimage
        Me.profileimg.Location = New System.Drawing.Point(12, 9)
        Me.profileimg.Name = "profileimg"
        Me.profileimg.Size = New System.Drawing.Size(64, 64)
        Me.profileimg.TabIndex = 15
        Me.profileimg.TabStop = False
        '
        'messagetxt
        '
        Me.messagetxt.AutoSize = True
        Me.messagetxt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.messagetxt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.messagetxt.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.messagetxt.Location = New System.Drawing.Point(82, 33)
        Me.messagetxt.Name = "messagetxt"
        Me.messagetxt.Size = New System.Drawing.Size(54, 17)
        Me.messagetxt.TabIndex = 16
        Me.messagetxt.Text = "User XY"
        '
        'opacityOut
        '
        Me.opacityOut.Interval = 10
        '
        'countDown
        '
        Me.countDown.Interval = 2000
        '
        'balloon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(360, 82)
        Me.Controls.Add(Me.messagetxt)
        Me.Controls.Add(Me.profileimg)
        Me.Controls.Add(Me.usernametxt)
        Me.Controls.Add(Me.closebt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "balloon"
        Me.Opacity = 0.8R
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "balloon"
        CType(Me.profileimg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents slide As System.Windows.Forms.Timer
    Friend WithEvents closebt As System.Windows.Forms.Button
    Friend WithEvents usernametxt As System.Windows.Forms.Label
    Friend WithEvents profileimg As System.Windows.Forms.PictureBox
    Friend WithEvents messagetxt As System.Windows.Forms.Label
    Friend WithEvents opacityOut As System.Windows.Forms.Timer
    Friend WithEvents countDown As System.Windows.Forms.Timer
End Class
