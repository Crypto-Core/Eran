<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fileTransfers
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
        Me.back_bt = New System.Windows.Forms.Button()
        Me.adduser_lb = New System.Windows.Forms.Label()
        Me.main_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_panel
        '
        Me.main_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.main_panel.Controls.Add(Me.adduser_lb)
        Me.main_panel.Controls.Add(Me.back_bt)
        Me.main_panel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_panel.ForeColor = System.Drawing.Color.White
        Me.main_panel.Location = New System.Drawing.Point(0, 0)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(718, 457)
        Me.main_panel.TabIndex = 2
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
        'adduser_lb
        '
        Me.adduser_lb.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.adduser_lb.AutoSize = True
        Me.adduser_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adduser_lb.Location = New System.Drawing.Point(304, 12)
        Me.adduser_lb.Name = "adduser_lb"
        Me.adduser_lb.Size = New System.Drawing.Size(111, 24)
        Me.adduser_lb.TabIndex = 18
        Me.adduser_lb.Text = "Filetransfers"
        '
        'fileTransfers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 456)
        Me.Controls.Add(Me.main_panel)
        Me.Name = "fileTransfers"
        Me.Text = "fileTransfers"
        Me.main_panel.ResumeLayout(False)
        Me.main_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents back_bt As System.Windows.Forms.Button
    Friend WithEvents adduser_lb As System.Windows.Forms.Label
End Class
