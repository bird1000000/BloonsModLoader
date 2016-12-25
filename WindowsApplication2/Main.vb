

Public Class Main
    Dim x As Integer
    Private Sub btn_modlistup_Click(sender As Object, e As EventArgs) Handles btn_modlistup.Click 'Moves up the selected item

        If lst_modslist.SelectedIndex > 0 Then 'Make sure our item is not the first one on the list.
            Dim I = lst_modslist.SelectedIndex - 1 'Gets the position of the data, and moves it up one
            lst_modslist.Items.Insert(I, lst_modslist.SelectedItem) 'Refreshes the list
            lst_modslist.Items.RemoveAt(lst_modslist.SelectedIndex) 'Refreshes the list
            lst_modslist.SelectedIndex = I 'Resets the integer
        End If

    End Sub

    Private Sub btn_modlistdown_Click(sender As Object, e As EventArgs) Handles btn_modlistdown.Click 'Moves down the selected item

        If lst_modslist.SelectedIndex < lst_modslist.Items.Count - 1 Then 'Make sure our item is not the last one on the list.
            Dim I = lst_modslist.SelectedIndex + 2 'Gets the position of the data, and moves down one
            lst_modslist.Items.Insert(I, lst_modslist.SelectedItem) 'Refreshes the list
            lst_modslist.Items.RemoveAt(lst_modslist.SelectedIndex) 'Refreshes the list
            lst_modslist.SelectedIndex = I - 1 'Resets the integer

        End If
    End Sub

    Private Sub btn_AddMod_Click(sender As Object, e As EventArgs) Handles btn_AddMod.Click

        Using ofd As New OpenFileDialog 'Shortens OpenfileDialog to ofd
            Dim DownloadsPath = My.Computer.Registry.GetValue( 'Find the path to the downloads folder
                "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders\", "{374DE290-123F-4565-9164-39C4925E467B}", Nothing) ' Finds the registry value of the download path
            ofd.InitialDirectory = DownloadsPath 'the ofd opens at the downloads directory
            ofd.Filter = "Jet files (*.jet)|*.jet|Mod files (*.mod)|*.mod" 'forces you to use .jet files
            If ofd.ShowDialog() = DialogResult.OK Then
                If  Then

                End If
                lst_log.Items.Add("Mod found at the directory " & ofd.FileName)
                lst_modslist.Items.Add(System.IO.Path.GetFileName(ofd.FileName))
                x += 1
            End If
        End Using

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
    End Sub

    Private Sub btn_removemod_Click(sender As Object, e As EventArgs) Handles btn_removemod.Click
        lst_modslist.Items.Remove(lst_modslist.SelectedIndex)
        lst_log.Items.Add("Removing " & lst_modslist.SelectedItem & " from mod list")
        x -= 1


    End Sub

    Private Sub btn_modname_Click(sender As Object, e As EventArgs) Handles btn_modname.Click

    End Sub

    Private Sub btn_mergelist_Click(sender As Object, e As EventArgs) Handles btn_mergelist.Click
        lst_log.Items.Add("Merging " & x & " .jet/.mod files")
        If x < 2 Then
            MsgBox("Pleas enter atleast 2 items to be merged")
        Else
            lst_modslist.Items.Clear()
            lst_log.Items.Add("This has not yet been programed.")
        End If
    End Sub
End Class
