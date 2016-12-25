Imports System.IO

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
        ofdstart()
    End Sub

    Public Sub ofdstart()
        Dim OpeningDIR = My.Computer.Registry.GetValue(
        "HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Shell Folders", "{374DE290-123F-4565-9164-39C4925E467B}", Nothing)
        OpenFileDialog1.InitialDirectory = OpeningDIR
        OpenFileDialog1.Filter = "Jet files (*.jet)|*.jet| Mod files (*.mod)|*.mod"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            lst_modslist.Items.Add(System.IO.Path.GetFileName(OpenFileDialog1.FileName))
        Else
            MsgBox("Error, Please select valid data.")
        End If
    End Sub

    Private Sub btn_removemod_Click(sender As Object, e As EventArgs) Handles btn_removemod.Click
        lst_modslist.Items.Remove(lst_modslist.SelectedIndex)
    End Sub
End Class
