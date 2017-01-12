Imports System
Imports Newtonsoft.Json
Imports Ionic.BZip2
Imports System.Xml
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Public Class Main
    'LB_sha256.Text = sha_256(Path)
    Dim x As Integer
    Dim y As Integer
    Dim Storage As String
    Dim TempFolder As String
    Dim Data As String
    Dim BattlesDatajet As String
    Dim BattlesFolder As String
    Dim Storeddatajet As String
    Dim Normaldatajethash As String = "02fae986297f02fcd4a2ddcefc13ed025a31d2c4ccf943055565088531754477"
    Dim Hasheddatajetvalue As String
    Dim Password As String = "Secret"
    Dim CurrentHash As String
    Dim StoredDataDir As String
    Dim Working As New information
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
                If IO.File.Exists("Data.xml") = False Then
                    Dim settings As New XmlWriterSettings()
                    settings.Indent = True
                    Dim XmlWrt As XmlWriter = XmlWriter.Create("data.xml", settings)
                    With XmlWrt
                        .WriteStartDocument()
                        .WriteComment("This is the xml used for mod loader")
                        .WriteStartElement("ModLoader")
                        .WriteStartElement("Moddata")

                        '.WriteStartElement("FirstName")
                        '.WriteString("Alleo")
                        '.WriteEndElement()

                        '.WriteStartElement("LastName")
                        ' .WriteString("Indong")
                        ' .WriteEndElement()

                        '  .WriteEndElement()
                        .WriteEndDocument()
                        .Close()

                    End With
                Else

                End If
            End If
            lst_log.Items.Add("Mod found at the directory " & ofd.FileName)
            lst_modslist.Items.Add(System.IO.Path.GetFileName(ofd.FileName))
            x += 1
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
            MsgBox("Please enter atleast 2 items to be merged")
        Else
            lst_modslist.Items.Clear()
            lst_log.Items.Add("This has not yet been programed.")
        End If
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SteamFolder As String 'The directory to the steam folder
        Dim Storeddatajetpath 'The directory to the data.jet in the %appdata%\BloonsModLoader

        Storage = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BloonsModLoader") 'Makes %appdata%\BloonsModLoader
        Storeddatajetpath = IO.Path.Combine(Storage, "datajet") 'Directory for the data.jet containing folder (Used in copy and pasting)
        TempFolder = IO.Path.Combine(Storage, "Temp") 'Directory to the temp folder, This is where all the merging will be done
        StoredDataDir = IO.Path.Combine(Storage, "Stored")

        If My.Computer.FileSystem.DirectoryExists(Storage) = False Then 'Checks if %appdata%\BloonsModLoader exists
            My.Computer.FileSystem.CreateDirectory(Storage) 'Because it doesns't exist, Create it.
            MsgBox("Bloons mod loader has detected that this is your first time openining this program, If this is not true or you have any errors then please PM Me on discord @Ben#3874") 'Contact information because the program may be operating incorrectly.
        End If

        If My.Computer.FileSystem.DirectoryExists(Storeddatajetpath) = False Then 'Checks if %appdata%\BloonsModLoader\datajet exists
            My.Computer.FileSystem.CreateDirectory(Storeddatajetpath) 'If it doesn't exist, Create it.
        End If

        If My.Computer.FileSystem.DirectoryExists(TempFolder) = False Then 'Checks if %appdata%\BloonsModLoader\Temp exists (The merging folder)
            My.Computer.FileSystem.CreateDirectory(TempFolder) 'If it doesnt exist, Create it.
        End If

        If My.Computer.FileSystem.DirectoryExists(StoredDataDir) = False Then 'Checks if %appdata%\BloonsModLoader\Stored exists (Stores mods and directories for prefabs
            My.Computer.FileSystem.CreateDirectory(StoredDataDir) 'If it doesn;t exists, Create it.
        End If

        'The below code checks if there is a data.jet file in %appdata%\BloonsModLoader\datajet\data.jet, If it doesn't exist is copies it from %steamfolder%\Steamapps\Common\Bloons TD Battles\Assets\Data.jet
        SteamFolder = My.Computer.Registry.GetValue( 'Searches the registry for the steam folder location
    "HKEY_CURRENT_USER\Software\Valve\Steam", "Steampath", Nothing) 'Folder location is used for finding battles

        BattlesFolder = IO.Path.Combine(SteamFolder, "SteamApps\Common\Bloons TD Battles") 'Creates a variable for the battles folder
        BattlesDatajet = IO.Path.Combine(BattlesFolder, "Assets\data.jet") 'Creates a variable for the adta.jet
        Storeddatajet = IO.Path.Combine(Storeddatajetpath, "data.jet") 'Creates the destination for the copy and paste

        If My.Computer.FileSystem.DirectoryExists(BattlesFolder) = False Then 'Checks if the battles folder is installed
            MsgBox("Bloons TD Battles does not seem to be installed, Exiting program") 'If the folder doesn't exist, Battles isn't installed
            Close()
        End If
        If My.Computer.FileSystem.FileExists(Storeddatajet) Then 'If doesn;t exist, copy it from the battles folder
        ElseIf My.Computer.FileSystem.FileExists(BattlesDatajet) = True Then 'Checks if the data.jet in the steam folder exists
            CurrentHash = sha_256(BattlesDatajet) 'Hashes the file, Checks if it's the current updates (4.0)
        Else
            MsgBox("Error, Data.jet not found") 'Battles is not installed, But the data.jet does not exist
        End If
        If CurrentHash = "02fae986297f02fcd4a2ddcefc13ed025a31d2c4ccf943055565088531754477" Then 'Checks if the data.jet is modded
            MsgBox("Bloons Mod Loader will now copy the data.jet from " & BattlesDatajet & "  To  " & Storeddatajetpath & Environment.NewLine & "This Is a one time installation, You will not need to do this again unless you delete the data.jet in the destination.") 'Tells user that this is a one time installation
            Try 'Method used for reporting errors in a debugable format to the user
                System.IO.File.Copy(BattlesDatajet, Storeddatajet) 'Copies the steam data.jet to a location where it will not change
            Catch ex As Exception 'The below displays the error, If there is one.
                MsgBox(ex.ToString())
                Close()
            End Try
            MsgBox("Copying Has been completed!") 'Tells the user that the program has succesfully copied withotu any errors
        Else
            MsgBox("Error, Please make sure that you are using an unmodified data.jet", Environment.NewLine, "Either copy and paste an unmodified data.jet or delete your current data.jet and verify integrity of game cache") 'Tells user to use an unmodified data.jet so that the mod loader can function properly
            Close()
        End If
    End Sub

    'Anything below this comment is not my code, Credit goes to http://us.informatiweb.net/

    Function sha_256(ByVal file_name As String)

        Return hash_generator("sha256", file_name)

    End Function

    Function hash_generator(ByVal hash_type As String, ByVal file_name As String)

        Dim hash
        If hash_type.ToLower = "sha256" Then
            hash = SHA256.Create()
        End If

        Dim hashValue() As Byte

        Dim fileStream As FileStream = File.OpenRead(file_name)
        fileStream.Position = 0
        hashValue = hash.ComputeHash(fileStream)
        Dim hash_hex = PrintByteArray(hashValue)
        fileStream.Close()

        Return hash_hex

    End Function

    Public Function PrintByteArray(ByVal array() As Byte)

        Dim hex_value As String = ""

        Dim i As Integer
        For i = 0 To array.Length - 1

            hex_value += array(i).ToString("X2")

        Next i

        Return hex_value.ToLower

    End Function

End Class