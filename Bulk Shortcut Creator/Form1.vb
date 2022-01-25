Public Class Form1


    Private Sub ButtonSRC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSRC.Click
        Dim Folder As String

        'FolderBrowserDialogSRC.RootFolder = Environment.SpecialFolder.MyMusic
        Folder = FolderBrowserDialogSRC.ShowDialog()
        SourcePathBox1.Text = FolderBrowserDialogSRC.SelectedPath

    End Sub



    Private Sub ButtonDST_Click(sender As Object, e As EventArgs) Handles ButtonDST.Click
        Dim Folder As String

        'FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        Folder = FolderBrowserDialogDST.ShowDialog()
        DSTPathBox.Text = FolderBrowserDialogDST.SelectedPath()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If SourcePathBox1.Text = "Select folder" Then Exit Sub
        If DSTPathBox.Text = "Select folder" Then Exit Sub
        If ExtBox.Text = "" Then Exit Sub
        If ComboBox1.Text = "" Then Exit Sub
        'On Error GoTo errorhandler

        Dim Mypath As String, myextension As String, myfile As String, mysearch As String, mysearchresult As Integer
        Mypath = SourcePathBox1.Text & "\"
        myextension = ExtBox.Text
        mysearch = ComboBox1.Text
        Dim extArray() As String = myextension.Split(","c)

        If mysearch = "This folder only" Then mysearchresult = 2
        If mysearch = "This folder and subfolders" Then mysearchresult = 3

        For Each foundfile As String In
                My.Computer.FileSystem.GetFiles(Mypath, mysearchresult, extArray)
            myfile = System.IO.Path.GetFileName(foundfile)
            Create_ShortCut(foundfile, DSTPathBox.Text, (myfile), Mypath, 4, 4)
            'ListBox1.Items.Add(foundfile)
            'foundfile = foundfile & vbCrLf
            'My.Computer.FileSystem.WriteAllText(DSTPathBox.Text & "\test.txt", foundfile & vbNewLine, True)
            'My.Computer.FileSystem.WriteAllText(DSTPathBox.Text & "\myfile.txt", myfile & vbNewLine, True)
            'MsgBox(foundfile)

        Next
        MsgBox("Done")
        'errorhandler:
        'MsgBox(Err.Description)
    End Sub

    Sub Create_ShortCut(ByVal TargetPath As String, ByVal ShortCutPath As String, ByVal ShortCutname As String, _
Optional ByVal WorkPath As String = "0", Optional ByVal Window_Style As Integer = 0, Optional ByVal IconNum As Integer = 0)


        Dim VbsObj As Object
        VbsObj = CreateObject("WScript.Shell")

        Dim MyShortcut As Object
        'ShortCutPath = VbsObj.SpecialFolders(ShortCutPath)
        MyShortcut = VbsObj.CreateShortcut(ShortCutPath & "\" & ShortCutname & ".lnk")
        MyShortcut.TargetPath = TargetPath
        MyShortcut.WorkingDirectory = WorkPath
        MyShortcut.WindowStyle = Window_Style
        'MyShortcut.IconLocation = "C:\WINDOWS\system32\SHELL32.dll," & IconNum
        MyShortcut.Save()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class
