Imports System.IO
Public Class account_frm

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles username_txt.GotFocus
        username_txt.BackColor = Color.FromArgb(45, 45, 45)

    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles username_txt.KeyDown
        If e.KeyData = Keys.Enter Then
            e.SuppressKeyPress = True
            EranAPI.Account.Aliasname = username_txt.Text
            Panel1.Focus()
            For Each sendName As ListViewItem In main_frm.userlist_viewer.Items

                main_frm.API.SendToServer("/adress " & EranAPI.Account.Address & "; /to " & sendName.SubItems(1).Text & "; /username " & username_txt.Text & ";")
            Next
        End If
    End Sub

    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles username_txt.LostFocus
        username_txt.BackColor = Color.FromArgb(40, 40, 40)
    End Sub

    Private Sub login_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_bt.Click

        Slider.slideOut_Control(Panel1)
    End Sub

    Private Sub profile_img_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles profile_img.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim new_bmp As Bitmap = CType(Bitmap.FromFile(OpenFileDialog1.FileName), Bitmap)
            Dim resize As Bitmap = New Bitmap(new_bmp, New Size(64, 64))
            profile_img.BackgroundImage = resize
            Dim mem_ As New MemoryStream
            resize.Save(mem_, System.Drawing.Imaging.ImageFormat.Png)
            Dim to_bs64 As String = Convert.ToBase64String(mem_.ToArray)
            EranAPI.Account.Profileimage = mem_.ToArray
            mem_.Close()
            Dim ini As New IniFile
            ini.Load(My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini")
            ini.SetKeyValue("account", "image", to_bs64)
            ini.Save(My.Application.Info.DirectoryPath & OS.OS_slash & "account.ini")
            Dim img_str As String = to_bs64
            For Each send_img As EranAPI.ChatSessions_ In main_frm.API.ChatSessions
                main_frm.API.SendToServer("/adress " & EranAPI.Account.Address & "; /to " & send_img.Address & "; /profil_image " & img_str & ";")
            Next
        End If
    End Sub
End Class