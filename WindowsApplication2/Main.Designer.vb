<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Loader = New System.Windows.Forms.TabPage()
        Me.btn_AddMod = New System.Windows.Forms.Button()
        Me.btn_modlistdown = New System.Windows.Forms.Button()
        Me.btn_modlistup = New System.Windows.Forms.Button()
        Me.lst_modslist = New System.Windows.Forms.ListBox()
        Me.Settings = New System.Windows.Forms.TabPage()
        Me.Dev = New System.Windows.Forms.TabPage()
        Me.btn_removemod = New System.Windows.Forms.Button()
        Me.btn_modname = New System.Windows.Forms.Button()
        Me.Log = New System.Windows.Forms.TabPage()
        Me.Merge = New System.Windows.Forms.TabPage()
        Me.txt_setmodname = New System.Windows.Forms.TextBox()
        Me.lst_log = New System.Windows.Forms.ListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btn_mergemods = New System.Windows.Forms.Button()
        Me.btn_findmods = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_setpass = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.Loader.SuspendLayout()
        Me.Dev.SuspendLayout()
        Me.Log.SuspendLayout()
        Me.Merge.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Loader)
        Me.TabControl1.Controls.Add(Me.Merge)
        Me.TabControl1.Controls.Add(Me.Settings)
        Me.TabControl1.Controls.Add(Me.Dev)
        Me.TabControl1.Controls.Add(Me.Log)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(460, 438)
        Me.TabControl1.TabIndex = 0
        '
        'Loader
        '
        Me.Loader.Controls.Add(Me.txt_setmodname)
        Me.Loader.Controls.Add(Me.btn_modname)
        Me.Loader.Controls.Add(Me.btn_removemod)
        Me.Loader.Controls.Add(Me.btn_AddMod)
        Me.Loader.Controls.Add(Me.btn_modlistdown)
        Me.Loader.Controls.Add(Me.btn_modlistup)
        Me.Loader.Controls.Add(Me.lst_modslist)
        Me.Loader.Location = New System.Drawing.Point(4, 22)
        Me.Loader.Name = "Loader"
        Me.Loader.Padding = New System.Windows.Forms.Padding(3)
        Me.Loader.Size = New System.Drawing.Size(452, 412)
        Me.Loader.TabIndex = 0
        Me.Loader.Text = "Loader"
        Me.Loader.UseVisualStyleBackColor = True
        '
        'btn_AddMod
        '
        Me.btn_AddMod.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AddMod.Location = New System.Drawing.Point(290, 7)
        Me.btn_AddMod.Name = "btn_AddMod"
        Me.btn_AddMod.Size = New System.Drawing.Size(156, 45)
        Me.btn_AddMod.TabIndex = 3
        Me.btn_AddMod.Text = "ADD MOD"
        Me.btn_AddMod.UseVisualStyleBackColor = True
        '
        'btn_modlistdown
        '
        Me.btn_modlistdown.Location = New System.Drawing.Point(263, 32)
        Me.btn_modlistdown.Name = "btn_modlistdown"
        Me.btn_modlistdown.Size = New System.Drawing.Size(20, 20)
        Me.btn_modlistdown.TabIndex = 2
        Me.btn_modlistdown.Text = "-"
        Me.btn_modlistdown.UseVisualStyleBackColor = True
        '
        'btn_modlistup
        '
        Me.btn_modlistup.Location = New System.Drawing.Point(263, 6)
        Me.btn_modlistup.Name = "btn_modlistup"
        Me.btn_modlistup.Size = New System.Drawing.Size(20, 20)
        Me.btn_modlistup.TabIndex = 1
        Me.btn_modlistup.Text = "+"
        Me.btn_modlistup.UseVisualStyleBackColor = True
        '
        'lst_modslist
        '
        Me.lst_modslist.FormattingEnabled = True
        Me.lst_modslist.Location = New System.Drawing.Point(7, 7)
        Me.lst_modslist.Name = "lst_modslist"
        Me.lst_modslist.Size = New System.Drawing.Size(250, 394)
        Me.lst_modslist.TabIndex = 0
        '
        'Settings
        '
        Me.Settings.Location = New System.Drawing.Point(4, 22)
        Me.Settings.Name = "Settings"
        Me.Settings.Padding = New System.Windows.Forms.Padding(3)
        Me.Settings.Size = New System.Drawing.Size(452, 412)
        Me.Settings.TabIndex = 1
        Me.Settings.Text = "Settings"
        Me.Settings.UseVisualStyleBackColor = True
        '
        'Dev
        '
        Me.Dev.Controls.Add(Me.btn_setpass)
        Me.Dev.Controls.Add(Me.TextBox1)
        Me.Dev.Location = New System.Drawing.Point(4, 22)
        Me.Dev.Name = "Dev"
        Me.Dev.Size = New System.Drawing.Size(452, 412)
        Me.Dev.TabIndex = 2
        Me.Dev.Text = "Dev"
        Me.Dev.UseVisualStyleBackColor = True
        '
        'btn_removemod
        '
        Me.btn_removemod.Location = New System.Drawing.Point(263, 58)
        Me.btn_removemod.Name = "btn_removemod"
        Me.btn_removemod.Size = New System.Drawing.Size(183, 32)
        Me.btn_removemod.TabIndex = 4
        Me.btn_removemod.Text = "Remove Mod"
        Me.btn_removemod.UseVisualStyleBackColor = True
        '
        'btn_modname
        '
        Me.btn_modname.Location = New System.Drawing.Point(263, 122)
        Me.btn_modname.Name = "btn_modname"
        Me.btn_modname.Size = New System.Drawing.Size(183, 32)
        Me.btn_modname.TabIndex = 5
        Me.btn_modname.Text = "Change mod name"
        Me.btn_modname.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.Controls.Add(Me.lst_log)
        Me.Log.Location = New System.Drawing.Point(4, 22)
        Me.Log.Name = "Log"
        Me.Log.Size = New System.Drawing.Size(452, 412)
        Me.Log.TabIndex = 3
        Me.Log.Text = "Log"
        Me.Log.UseVisualStyleBackColor = True
        '
        'Merge
        '
        Me.Merge.Controls.Add(Me.btn_findmods)
        Me.Merge.Controls.Add(Me.btn_mergemods)
        Me.Merge.Controls.Add(Me.ComboBox2)
        Me.Merge.Controls.Add(Me.ComboBox1)
        Me.Merge.Location = New System.Drawing.Point(4, 22)
        Me.Merge.Name = "Merge"
        Me.Merge.Size = New System.Drawing.Size(452, 412)
        Me.Merge.TabIndex = 4
        Me.Merge.Text = "Merge"
        Me.Merge.UseVisualStyleBackColor = True
        '
        'txt_setmodname
        '
        Me.txt_setmodname.Location = New System.Drawing.Point(263, 96)
        Me.txt_setmodname.Name = "txt_setmodname"
        Me.txt_setmodname.Size = New System.Drawing.Size(183, 20)
        Me.txt_setmodname.TabIndex = 8
        Me.txt_setmodname.Text = "Insert Name Here"
        '
        'lst_log
        '
        Me.lst_log.FormattingEnabled = True
        Me.lst_log.Location = New System.Drawing.Point(4, 4)
        Me.lst_log.Name = "lst_log"
        Me.lst_log.Size = New System.Drawing.Size(445, 407)
        Me.lst_log.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(445, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(4, 138)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(445, 21)
        Me.ComboBox2.TabIndex = 1
        '
        'btn_mergemods
        '
        Me.btn_mergemods.Location = New System.Drawing.Point(4, 32)
        Me.btn_mergemods.Name = "btn_mergemods"
        Me.btn_mergemods.Size = New System.Drawing.Size(445, 100)
        Me.btn_mergemods.TabIndex = 2
        Me.btn_mergemods.Text = "Merge"
        Me.btn_mergemods.UseVisualStyleBackColor = True
        '
        'btn_findmods
        '
        Me.btn_findmods.Location = New System.Drawing.Point(4, 166)
        Me.btn_findmods.Name = "btn_findmods"
        Me.btn_findmods.Size = New System.Drawing.Size(445, 100)
        Me.btn_findmods.TabIndex = 3
        Me.btn_findmods.Text = "Find mods"
        Me.btn_findmods.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(445, 20)
        Me.TextBox1.TabIndex = 0
        '
        'btn_setpass
        '
        Me.btn_setpass.Location = New System.Drawing.Point(4, 31)
        Me.btn_setpass.Name = "btn_setpass"
        Me.btn_setpass.Size = New System.Drawing.Size(445, 100)
        Me.btn_setpass.TabIndex = 1
        Me.btn_setpass.Text = "Set Password"
        Me.btn_setpass.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = """Jet files (*.jet)|*.jet"""
        Me.OpenFileDialog1.InitialDirectory = "C:\"
        Me.OpenFileDialog1.Title = "Please select a file"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Main"
        Me.Text = "Bloons Mod Loader"
        Me.TabControl1.ResumeLayout(False)
        Me.Loader.ResumeLayout(False)
        Me.Loader.PerformLayout()
        Me.Dev.ResumeLayout(False)
        Me.Dev.PerformLayout()
        Me.Log.ResumeLayout(False)
        Me.Merge.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Loader As TabPage
    Friend WithEvents Settings As TabPage
    Friend WithEvents Dev As TabPage
    Friend WithEvents btn_modlistdown As Button
    Friend WithEvents btn_modlistup As Button
    Friend WithEvents lst_modslist As ListBox
    Friend WithEvents btn_AddMod As Button
    Friend WithEvents btn_removemod As Button
    Friend WithEvents btn_modname As Button
    Friend WithEvents txt_setmodname As TextBox
    Friend WithEvents Merge As TabPage
    Friend WithEvents Log As TabPage
    Friend WithEvents lst_log As ListBox
    Friend WithEvents btn_findmods As Button
    Friend WithEvents btn_mergemods As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents btn_setpass As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
