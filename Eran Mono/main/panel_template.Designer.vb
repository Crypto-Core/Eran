<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class panel_template
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
        Me.login_bt = New System.Windows.Forms.Button()
        Me.main_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'main_panel
        '
        Me.main_panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.main_panel.Controls.Add(Me.login_bt)
        Me.main_panel.Font = New System.Drawing.Font("Ubuntu", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.main_panel.ForeColor = System.Drawing.Color.White
        Me.main_panel.Location = New System.Drawing.Point(12, 10)
        Me.main_panel.Name = "main_panel"
        Me.main_panel.Size = New System.Drawing.Size(719, 458)
        Me.main_panel.TabIndex = 1
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
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 479)
        Me.Controls.Add(Me.main_panel)
        Me.Name = "about"
        Me.Text = "about"
        Me.main_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents main_panel As System.Windows.Forms.Panel
    Friend WithEvents login_bt As System.Windows.Forms.Button
End Class
