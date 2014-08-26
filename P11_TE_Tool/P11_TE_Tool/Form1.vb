Imports System.IO
Public Class Form1

    Private Sub ButComDlog_Click(sender As Object, e As EventArgs) Handles ButComDlog.Click
        Dim RefDir, NewDir As String
        Dim RefFName(100), NewFName(100) As String
        Dim i, ii, iii As Long
        Dim FNameField(), RenFName, NoDirName As String
        Dim Err As Long
        Dim fileReader As System.IO.StreamReader
        Dim stringReader, Fstringreader() As String
        Dim strDummy, ProdName, DestNewDir, DestRefDir, TempDir, SrcDir, RefTPRev, NewTPRev As String
        'Dim wfile As System.IO.StreamWriter
        '\\proj607.sin.infineon.com\mc_p11\

        LabelStatus.Enabled = True
        LabelStatus.Visible = True
        LabelStatus.Text = "Processing..."

        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\P11_TE_Tool.ini") Then GoTo ErrorEnd
        fileReader = My.Computer.FileSystem.OpenTextFileReader(Application.StartupPath & "\P11_TE_Tool.ini")
        i = 0
        Do While fileReader.Peek <> -1
            stringReader = fileReader.ReadLine()
            Do While InStr(stringReader, " ", 0) > 1
                stringReader = Replace(Trim(stringReader), " ", "")
            Loop
            Fstringreader = Split(stringReader, ",")
            MsgBox(Fstringreader(0) & "  =  " & Fstringreader(1))
            i += 1
        Loop

        fileReader.Close()


        TempDir = "C:\Temp\Compare"
        If Len(TBoxRefRev.Text) >= 4 Then RefTPRev = Mid(TBoxRefRev.Text, 1, 1) & Mid(TBoxRefRev.Text, 3, 2) Else RefTPRev = TBoxRefRev.Text
        If Len(TBoxNewRev.Text) >= 4 Then NewTPRev = Mid(TBoxNewRev.Text, 1, 1) & Mid(TBoxNewRev.Text, 3, 2) Else NewTPRev = TBoxNewRev.Text
        ProdName = TBoxProd.Text
        If RefTPRev = "" And NewTPRev = "" And ProdName = "" Then GoTo endNow

        DestNewDir = ""
        DestRefDir = ""
        If ProdName = "M2682" Or ProdName = "M2662" Or ProdName = "M2663" Or ProdName = "M2673" Or ProdName = "M2620" Or ProdName = "M2643" Or ProdName = "M2623" Then
            DestNewDir = "\\proj607.sin.infineon.com\mc_p11\" & ProdName & "\TP_Release_Doc\" & ProdName & "_" & NewTPRev & "\12_CMT\" & "DlogCompare\" & NewTPRev
            DestRefDir = "\\proj607.sin.infineon.com\mc_p11\" & ProdName & "\TP_Release_Doc\" & ProdName & "_" & NewTPRev & "\12_CMT\" & "DlogCompare\" & RefTPRev
            If My.Computer.FileSystem.DirectoryExists(DestNewDir) Then System.IO.Directory.Delete(DestNewDir, True)
            If My.Computer.FileSystem.DirectoryExists(DestRefDir) Then System.IO.Directory.Delete(DestRefDir, True)
            My.Computer.FileSystem.CreateDirectory(DestNewDir)
            My.Computer.FileSystem.CreateDirectory(DestRefDir)
        Else : GoTo endNow
        End If



        If My.Computer.FileSystem.DirectoryExists(TempDir & "\Ref") Then System.IO.Directory.Delete(TempDir & "\Ref", True)
        If My.Computer.FileSystem.DirectoryExists(TempDir & "\New") Then System.IO.Directory.Delete(TempDir & "\New", True)
        If My.Computer.FileSystem.DirectoryExists(TempDir & "\Ref") Then System.IO.Directory.Delete(TempDir & "\" & RefTPRev, True)
        If My.Computer.FileSystem.DirectoryExists(TempDir & "\New") Then System.IO.Directory.Delete(TempDir & "\" & NewTPRev, True)
        My.Computer.FileSystem.CreateDirectory(TempDir & "\Ref")
        My.Computer.FileSystem.CreateDirectory(TempDir & "\New")
        My.Computer.FileSystem.CreateDirectory(TempDir & "\" & RefTPRev)
        My.Computer.FileSystem.CreateDirectory(TempDir & "\" & NewTPRev)

        If TBoxRefTP.Text = "" And TBoxNewTP.Text = "" Then GoTo endNow
        'If My.Computer.FileSystem.DirectoryExists(TBoxRefTP.Text) And My.Computer.FileSystem.DirectoryExists(TBoxNewTP.Text) And My.Computer.FileSystem.DirectoryExists("C:\Temp") Then GoTo endNow

        'System.IO.Directory.Delete(TempDir & "\Ref", True)
        'System.IO.Directory.Delete(TempDir & "\New", True)



        SrcDir = TBoxRefTP.Text
        My.Computer.FileSystem.CopyDirectory(SrcDir, TempDir & "\Ref", True)
        SrcDir = TBoxNewTP.Text
        My.Computer.FileSystem.CopyDirectory(SrcDir, TempDir & "\New", True)

        RefDir = TempDir & "\Ref" & "\"
        i = 0
        For Each DirFile As String In My.Computer.FileSystem.GetFiles(TempDir & "\Ref")
            strDummy = DirFile
            DirFile = Replace(DirFile, RefDir, "")
            FNameField = Split(DirFile, "_")
            If UBound(FNameField) <= 5 Then
                My.Computer.FileSystem.DeleteFile(strDummy)
                GoTo skipRefFile
            End If
            RefFName(i) = strDummy
            If UBound(FNameField) > 5 Then
                FNameField(1) = Mid(FNameField(1), 1, Len(FNameField(1)) - 5) & "REV" & Mid(FNameField(1), Len(FNameField(1)) - 1, 2)
                If IsNumeric(FNameField(UBound(FNameField) - 1)) Then FNameField(UBound(FNameField) - 1) = "x"
            End If
            RenFName = ""
            For iii = 0 To UBound(FNameField)
                RenFName = RenFName & "_" & FNameField(iii)
            Next
            RenFName = Mid(RenFName, 2, Len(RenFName) - 1)
            Err = renFile(CStr(RefFName(i)), CStr(RenFName))
            i = i + 1
SkipRefFile:
        Next


        NewDir = TempDir & "\New" & "\"
        ii = 0
        For Each DirFile As String In My.Computer.FileSystem.GetFiles(TempDir & "\New")
            NewFName(i) = DirFile
            strDummy = DirFile
            DirFile = Replace(DirFile, NewDir, "")
            FNameField = Split(DirFile, "_")
            If UBound(FNameField) <= 5 Then
                My.Computer.FileSystem.DeleteFile(strDummy)
                GoTo skipNewFile
            End If
            NewFName(i) = strDummy
            If UBound(FNameField) > 5 Then
                FNameField(1) = Mid(FNameField(1), 1, Len(FNameField(1)) - 5) & "REV" & Mid(FNameField(1), Len(FNameField(1)) - 1, 2)
                If IsNumeric(FNameField(UBound(FNameField) - 1)) Then FNameField(UBound(FNameField) - 1) = "x"
            End If
            RenFName = ""
            For iii = 0 To UBound(FNameField)
                RenFName = RenFName & "_" & FNameField(iii)
            Next
            RenFName = Mid(RenFName, 2, Len(RenFName) - 1)
            Err = renFile(CStr(NewFName(i)), CStr(RenFName))
            ii = ii + 1
SkipNewFile:
        Next


        For Each DirFile As String In My.Computer.FileSystem.GetFiles(TempDir & "\Ref")
            NoDirName = Replace(DirFile, RefDir, "")
            fileReader = My.Computer.FileSystem.OpenTextFileReader(DirFile)
            Using wfile As StreamWriter = New StreamWriter("C:\Temp\Compare\" & RefTPRev & "\" & NoDirName & "_compare.txt")
                Do While fileReader.Peek <> -1
                    stringReader = fileReader.ReadLine()
                    Do While InStr(stringReader, "  ", 0) > 1
                        stringReader = Replace(Trim(stringReader), "  ", " ")
                    Loop
                    Fstringreader = Split(stringReader, " ")
                    If UBound(Fstringreader) >= 4 Then
                        If (IsNumeric(Fstringreader(0)) And IsNumeric(Fstringreader(1)) And Fstringreader(2) = "PASS") Or (IsNumeric(Fstringreader(0)) And IsNumeric(Fstringreader(1)) And Fstringreader(2) = "FAIL") Then
                            wfile.WriteLine(stringReader)
                        End If
                    End If
                Loop
            End Using
            fileReader.Close()
        Next

        For Each DirFile As String In My.Computer.FileSystem.GetFiles(TempDir & "\New")
            NoDirName = Replace(DirFile, NewDir, "")
            fileReader = My.Computer.FileSystem.OpenTextFileReader(DirFile)
            Using wfile As StreamWriter = New StreamWriter("C:\Temp\Compare\" & NewTPRev & "\" & NoDirName & "_compare.txt")
                Do While fileReader.Peek <> -1
                    stringReader = fileReader.ReadLine()
                    Do While InStr(stringReader, "  ", 0) > 1
                        stringReader = Replace(Trim(stringReader), "  ", " ")
                    Loop
                    Fstringreader = Split(stringReader, " ")
                    If UBound(Fstringreader) >= 4 Then
                        If (IsNumeric(Fstringreader(0)) And IsNumeric(Fstringreader(1)) And Fstringreader(2) = "PASS") Or (IsNumeric(Fstringreader(0)) And IsNumeric(Fstringreader(1)) And Fstringreader(2) = "FAIL") Then
                            wfile.WriteLine(stringReader)
                        End If
                    End If
                Loop
            End Using
            fileReader.Close()
        Next

        My.Computer.FileSystem.CopyDirectory("C:\Temp\Compare\" & NewTPRev, DestNewDir, True)
        My.Computer.FileSystem.CopyDirectory("C:\Temp\Compare\" & RefTPRev, DestRefDir, True)
        Threading.Thread.Sleep(5000)
endNow:
        MsgBox("Processing Done!")
        On Error Resume Next
        If My.Computer.FileSystem.DirectoryExists("C:\Temp\Compare") Then
            Threading.Thread.Sleep(5000)
            System.IO.Directory.Delete("C:\Temp\Compare", True)
        End If
ErrorEnd:
        LabelStatus.Text = "Ready."
        Me.Close()
    End Sub

    Function getDirList(StrDir As String) As String
        Dim StrDummy As String

        StrDummy = ""
        For Each DirFile As String In My.Computer.FileSystem.GetFiles(StrDir)

            StrDummy = StrDummy & vbCrLf & DirFile
        Next



        getDirList = StrDummy

    End Function

    Function renFile(strFile1 As String, strFile2 As String) As Long
        renFile = 1
        On Error Resume Next

        My.Computer.FileSystem.RenameFile(strFile1, strFile2)

        renFile = 0

    End Function
End Class
