Public Class balloon

    Private Sub balloon_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub balloon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(My.Computer.Screen.WorkingArea.Width, My.Computer.Screen.WorkingArea.Height - Me.Size.Height)
        slide.Enabled = True
        Me.TopMost = True
    End Sub

    Private Sub slide_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slide.Tick
        If Me.Location.X < My.Computer.Screen.WorkingArea.Width - Me.Size.Width + 1 Then
            slide.Enabled = False
            countDown.Enabled = True

            Me.Location = New Point(My.Computer.Screen.WorkingArea.Width - Me.Size.Width + 20, My.Computer.Screen.WorkingArea.Height - Me.Size.Height)
        End If
        Me.Location = New Point(Me.Location.X - 20, My.Computer.Screen.WorkingArea.Height - Me.Size.Height)

    End Sub

    Private Sub onlinestatus_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles closebt.Click
        Me.Close()
    End Sub

    Private Sub usernametxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usernametxt.Click
        selectUser()
    End Sub

    Friend Function selectUser()

        Me.Close()
        DialogResult = Windows.Forms.DialogResult.OK
        Me.Opacity = 0.8
        countDown.Enabled = False
        opacityOut.Enabled = False
    End Function

    Private Sub messagetxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles messagetxt.Click
        selectUser()
    End Sub

    Private Sub profileimg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profileimg.Click
        selectUser()
    End Sub

    Private Sub opacityOut_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opacityOut.Tick
        Me.Opacity -= 0.01
        If Me.Opacity = 0 Then
            opacityOut.Enabled = False
            Me.Opacity = 0.8

            DialogResult = Windows.Forms.DialogResult.None
            Me.Close()
        End If
    End Sub

    Private Sub countDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles countDown.Tick
        countDown.Enabled = False
        opacityOut.Enabled = True
    End Sub
End Class