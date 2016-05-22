Imports System.IO
Public Class add_user
    Private aes As New AESEncrypt

    Private Sub back_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_bt.Click
        Slider.slideOut_Control(main_panel)
    End Sub


    Private Sub login_bt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add_bt.Click
        If is_in_list(address_txt.Text) Then
            MsgBox("Ja")
        Else
            userlist.add_user(address_txt.Text, address_txt.Text)
        End If

    End Sub

    Private Sub address_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles address_txt.TextChanged
        If address_txt.TextLength > 31 Then
            add_bt.Enabled = True
        Else
            add_bt.Enabled = False
        End If
    End Sub
End Class