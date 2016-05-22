Imports System.IO

Module userlist
    Friend AES As New AESEncrypt
    Friend UserList As New List(Of UserList_)
    Friend Structure UserList_
        Dim Username As String
        Dim Address As String
    End Structure
    Friend Function load_userlist() As Object
        If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini") Then
            main_frm.userlist_viewer.Items.Clear()
            Dim ini As New IniFile
            Dim read_ini_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
            Dim target_enc As Byte()
            AES.Decode(read_ini_bytes, target_enc, EranAPI.Account.Password, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim ini_mem As New MemoryStream(target_enc)
            ini.LoadFromMemory(ini_mem)
            For Each s As IniFile.IniSection In ini.Sections
                For Each k As IniFile.IniSection.IniKey In s.Keys
                    If UserList.Exists(Function(x) x.Address = s.Name) = False Then
                        Dim addUsr As New UserList_
                        addUsr.Address = k.Value
                        addUsr.Username = s.Name
                        UserList.Add(addUsr)
                        With main_frm.userlist_viewer.Items.Add(s.Name, 0)
                            .UseItemStyleForSubItems = False
                            With .SubItems.Add(k.Value)
                                .ForeColor = Color.Gray
                                .Font = New Font("Arial", 8)
                            End With
                        End With
                    Else

                    End If


                Next : Next
            For Each sendGetState As ListViewItem In main_frm.userlist_viewer.Items

                main_frm.API.SendToServer("/adress " & EranAPI.Account.Address & "; /to " & sendGetState.SubItems(1).Text & "; /get_state True; /get_username 1; /state " & EranAPI.Account.OnlineState & ";")
                'main_frm.API.SendToServer("/adress " & EranAPI.Account.Address & "; /to " & sendGetState.SubItems(1).Text & "; /state 0;")
            Next

        Else : End If

    End Function
    Friend Function del_user(ByVal Address As String)
        Dim ini As New IniFile
        If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini") Then
            'Dim index As Integer = UserList.FindIndex(Function(x) x.Address = Address)
            'UserList.RemoveAt(index)
            Dim read_enc_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
            Dim dec_trg_byte As Byte()

            AES.Decode(read_enc_bytes, dec_trg_byte, EranAPI.Account.Password, AESEncrypt.ALGO.RIJNDAEL, 4096)
            Dim mem_ As New MemoryStream(dec_trg_byte)
            ini.LoadFromMemory(mem_)
            For Each tt As IniFile.IniSection In ini.Sections
                For Each tu As IniFile.IniSection.IniKey In tt.Keys
                    If tu.GetValue = Address Then
                        MsgBox(tt.Name)
                        ini.RemoveSection(tt.Name)
                    End If
                Next
            Next

            Dim save_trg_enc As Byte()
            AES.Encode(ini.SavetoByte(), save_trg_enc, EranAPI.Account.Password, AESEncrypt.ALGO.RIJNDAEL, 4096)
            File.WriteAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini", save_trg_enc)

        End If

    End Function
    Friend Function add_user(ByVal Username As String, ByVal Address As String)
        If Address.Length = 32 Then
            Dim ini As New IniFile
            If File.Exists(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini") Then
                Dim read_enc_bytes As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
                Dim dec_trg_byte As Byte()

                AES.Decode(read_enc_bytes, dec_trg_byte, EranAPI.Account.Password, AESEncrypt.ALGO.RIJNDAEL, 4096)
                Dim mem_ As New MemoryStream(dec_trg_byte)
                ini.LoadFromMemory(mem_)
                ini.AddSection(Username)
                ini.SetKeyValue(Username, "adress", Address)
                Dim save_trg_enc As Byte()
                AES.Encode(ini.SavetoByte(), save_trg_enc, EranAPI.Account.Password, AESEncrypt.ALGO.RIJNDAEL, 4096)
                File.WriteAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini", save_trg_enc)
                load_userlist()
            Else
                ini.AddSection(Username)
                ini.SetKeyValue(Username, "adress", Address)
                Dim ini_save_byte As Byte()
                ini_save_byte = ini.SavetoByte()
                Dim save_trg_enc As Byte()
                AES.Encode(ini_save_byte, save_trg_enc, EranAPI.Account.Password, AESEncrypt.ALGO.RIJNDAEL, 4096)
                File.WriteAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini", save_trg_enc)
                load_userlist()
            End If
        Else
            MsgBox("It's not a Eran adress!", MsgBoxStyle.Exclamation, "Eran adress")
        End If
    End Function

    Friend Function is_in_list(ByVal address As String) As Boolean
        Dim readUsrLST As Byte() = File.ReadAllBytes(My.Application.Info.DirectoryPath & OS.OS_slash & "userlist.ini")
        Dim decryptTarget As Byte()
        AES.Decode(readUsrLST, decryptTarget, EranAPI.Account.Password, AESEncrypt.ALGO.RIJNDAEL, 4096)
        Dim memStream As New MemoryStream(decryptTarget)
        Dim ini As New IniFile
        ini.LoadFromMemory(memStream)
        For Each tt As IniFile.IniSection In ini.Sections
            For Each tu As IniFile.IniSection.IniKey In tt.Keys
                If tu.GetValue = address Then
                    Return True
                    Exit Function
                End If
            Next
        Next
        Return False
    End Function
End Module
