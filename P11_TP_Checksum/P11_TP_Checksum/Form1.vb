Public Class P11_Checksum

    Private Sub ButCksum_Click(sender As Object, e As EventArgs) Handles ButCksum.Click
        Dim CSLog, ZipFullName, ZipFName, FullPath, TempPath, StartPath As String
        Dim ShellError As Integer
        Dim TPFile As System.IO.FileInfo
        Dim fileReader As String

        LabelProcess.Visible = True
        LabelProcess.Refresh()

        TempPath = "c:\temp\"

        If Not My.Computer.FileSystem.DirectoryExists("H:\My Documents") Then
            MsgBox("This application requires connection to Infineon intranet.")
            GoTo endnow
        End If

        If Not My.Computer.FileSystem.DirectoryExists(TempPath) Then System.IO.Directory.CreateDirectory(TempPath)
        If Not My.Computer.FileSystem.DirectoryExists(TempPath) Then
            MsgBox("This application requires write access to c:\temp")
            GoTo endnow
        End If
        FullPath = TBoxCksum.Text
        If Not My.Computer.FileSystem.FileExists(FullPath) Then
            MsgBox("TP Zip File does not exist!")
            GoTo endnow
        End If
        StartPath = Application.StartupPath
        ' MsgBox(StartPath)
        If Not My.Computer.FileSystem.FileExists(StartPath & "\P11TPChecksum.cfg") Or _
            Not My.Computer.FileSystem.FileExists(StartPath & "\7za.exe") Then
            MsgBox("Error. Component files are missing!")
            GoTo endNow
        End If
        If InStr(FullPath, ".zip", 0) = 0 Then GoTo endnow
        If Mid(FullPath, 1, 1) = "\" Then
            MsgBox("This Program requires full path with drive letter to execute (not network links).")
            GoTo endnow
        End If
        TPFile = My.Computer.FileSystem.GetFileInfo(FullPath)
        ZipFullName = TPFile.Name
        ZipFName = Mid(ZipFullName, 1, Len(ZipFullName) - 4)
        FullPath = TPFile.DirectoryName
        CSLog = "ChecksumLog_" & ZipFName & ".txt"



        On Error Resume Next
        If My.Computer.FileSystem.DirectoryExists(TempPath & ZipFName) Then System.IO.Directory.Delete(TempPath & ZipFName, True)
        Threading.Thread.Sleep(1000)
        My.Computer.FileSystem.CopyFile(FullPath & "\" & ZipFullName, TempPath & ZipFullName, True)
        'My.Computer.FileSystem.CopyFile("\\proj607\mc_p11\P11_Others\P11_TE_Tools\7za.exe", TempPath & "7za.exe", True)
        My.Computer.FileSystem.CopyFile(StartPath & "\7za.exe", TempPath & "7za.exe", True)
        My.Computer.FileSystem.WriteAllText("c:\temp\RunChecksum.bat", vbCrLf & "attrib /D /S -R " & TempPath & ZipFName & "\*.*" & vbCrLf & "del /F /Q " & TempPath & ZipFName & vbCrLf & TempPath & "7za.exe x " & TempPath & ZipFName & ".zip -o" & TempPath & ZipFName & vbCrLf & "del c:\temp\RunChecksum.bat c:\temp\7za.exe", False)
        ShellError = Shell("c:\temp\RunChecksum.bat", AppWinStyle.Hide, True) ' AppWinStyle.Hide AppWinStyle.NormalFocus, True)

        'ShellError = 1
        'Do While ShellError = 1
        ' If My.Computer.FileSystem.DirectoryExists("c:\temp\RunChecksum.bat") Then ShellError = 1 Else ShellError = 0
        ' Loop

        'My.Computer.FileSystem.CopyFile("\\proj607\mc_p11\11_Others\P11_TE_Tools\P11TPChecksum.cfg", "c:\temp\fciv.exe", True)
        My.Computer.FileSystem.CopyFile(StartPath & "\P11TPChecksum.cfg", "c:\temp\fciv.exe", True)
        'My.Computer.FileSystem.WriteAllText("c:\temp\RunChecksum.bat", vbCrLf & "c:\temp\fciv.exe " & TempPath & ZipFName & " -r -wp > " & TempPath & CSLog & vbCrLf & "del c:\temp\RunChecksum.bat c:\temp\fciv.*", False)
        My.Computer.FileSystem.WriteAllText("c:\temp\RunChecksum.bat", vbCrLf & "c:\temp\fciv.exe " & TempPath & ZipFName & " -r > " & TempPath & CSLog & vbCrLf & "del c:\temp\RunChecksum.bat c:\temp\fciv.*", False)
        ShellError = Shell("c:\temp\RunChecksum.bat", AppWinStyle.Hide, True) 'AppWinStyle.Hide, True)

        If My.Computer.FileSystem.DirectoryExists(TempPath & ZipFName) Then System.IO.Directory.Delete(TempPath & ZipFName, True)
        Threading.Thread.Sleep(1000)
        My.Computer.FileSystem.WriteAllText("c:\temp\RunChecksum.bat", vbCrLf & "attrib /D /S -R " & TempPath & ZipFName & "\*.*" & vbCrLf & "del /F /Q " & TempPath & ZipFName & vbCrLf & TempPath & "7za.exe x " & TempPath & ZipFName & ".zip -o" & TempPath & ZipFName & vbCrLf & "del c:\temp\RunChecksum.bat c:\temp\7za.exe", False)
        ShellError = Shell("c:\temp\RunChecksum.bat", AppWinStyle.Hide, True) ' AppWinStyle.Hide, True)
        TBox1.Text = ""
        TBox1.Text = My.Computer.FileSystem.ReadAllText(TempPath & CSLog, System.Text.Encoding.UTF8)
        fileReader = My.Computer.FileSystem.ReadAllText(TempPath & CSLog).Replace("c:\temp\", "")
        My.Computer.FileSystem.WriteAllText(TempPath & CSLog, fileReader, False)
        fileReader = My.Computer.FileSystem.ReadAllText(TempPath & CSLog).Replace("// File Checksum Integrity Verifier version 2.05.", "")
        My.Computer.FileSystem.WriteAllText(TempPath & CSLog, fileReader, False)
        fileReader = My.Computer.FileSystem.ReadAllText(TempPath & CSLog).Replace("Errors have been reported to fciv.err", "")
        My.Computer.FileSystem.WriteAllText(TempPath & CSLog, fileReader, False)
        'Replace(TBox1.Text, "// File Checksum Integrity Verifier version 2.05.", "")
        'Replace(TBox1.Text, "c:\temp", "")
        'Replace(TBox1.Text, "Errors have been reported to fciv.err", "")
        'My.Computer.FileSystem.WriteAllText(TempPath & CSLog, TBox1.Text, False)
        My.Computer.FileSystem.CopyFile(TempPath & CSLog, FullPath & "\" & CSLog, True)
        System.IO.Directory.Delete(TempPath & ZipFName, True)
        System.IO.File.Delete(TempPath & ZipFullName)
        System.IO.File.Delete(TempPath & CSLog)
        System.IO.File.Delete(StartPath & "\fciv.err")
        MsgBox("Test Program checksum file created: " & FullPath & "\" & CSLog)

endNow:
        LabelProcess.Visible = False
    End Sub


End Class
