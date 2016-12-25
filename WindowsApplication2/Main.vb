Imports System.IO
Public Class Main

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
        Dim UserprofilePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        Dim Downloadspath As String = UserprofilePath.Insert(0, "Test")
        ' OpenFileDialog1.InitialDirectory = Downloadspath
        txt_setmodname.Text = UserprofilePath
        'OpenFileDialog1.ShowDialog()
    End Sub
End Class
