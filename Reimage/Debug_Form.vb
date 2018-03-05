Imports System.ComponentModel
Imports System.IO
Imports Microsoft.VisualBasic.FileIO.FileSystem

Public Class Debug_Form
    Dim copyFrom As String = "D:\users\student"
    Dim copyTo As String = "C:\testCopy2"
    Dim TotalSize As Long = 0
    Dim TotalSize2 As Long = 0

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CopyFolder_Debug(copyFrom, copyTo)
        MessageBox.Show("Completed")
    End Sub

    Public Sub CopyFolder_Debug(ByVal SourceFolder As String, ByVal DestFolder As String)
        Try
            'do "file" copies in c:/users/<user> directory
            For Each item In FileIO.FileSystem.GetFiles(SourceFolder)
                Try
                    'don't copy hidden files
                    If (GetAttr(item) And vbHidden) = False Then
                        'copy all other files
                        FileIO.FileSystem.CopyFile(item, DestFolder & "\" & FileIO.FileSystem.GetFileInfo(item).Name)
                    End If
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try

        Try

            'for all directories in c:/users/<user>, copy them and recursively go through their files with the other method
            For Each SubFolder In FileIO.FileSystem.GetDirectories(SourceFolder)
                'as long as it's not hidden
                If (GetAttr(SubFolder) And vbHidden) = False Then
                    'copy the folder
                    CopyFolder_Debug(SubFolder, DestFolder & "\" & FileIO.FileSystem.GetDirectoryInfo(SubFolder).Name)

                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    'begin work
    Private Sub btnDebugWP_Click(sender As Object, e As EventArgs) Handles btnDebugWP.Click
        TotalSize = 0 'Reset the counter
        Dim TheSize As Long = GetDirSize(copyFrom)
        MsgBox(" You're about to transfer" & FormatNumber(TheSize / 1024 / 1024, 1) & " megabytes")
        BackgroundWorker1.RunWorkerAsync()
        Timer1.Enabled = True
    End Sub

    'during work
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        CopyFolder_Debug(copyFrom, copyTo)
    End Sub

    'after work
    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        ProgressBar1.Value = ProgressBar1.Maximum
        MessageBox.Show("Background work done")
        'shut off the timer
        Timer1.Enabled = False

    End Sub

    Public Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'get size of each dir every second and change them to progress bar values
        Dim updatingValue As Long
        Dim maxValue As Long

        'keep getting maxValue output
        TotalSize = 0
        Dim TheSize As Long = GetDirSize(copyFrom)
        maxValue = (FormatNumber(TheSize / 1024 / 1024, 1))

        'keep getting the value of the new folder
        TotalSize2 = 0
        Dim TheSize2 As Long = GetDirSize2(copyTo)
        updatingValue = (FormatNumber(TheSize2 / 1024 / 1024, 1))

        lblFilesCopied.Text = updatingValue & "Out of " & maxValue & " megabytes copied"

        ProgressBar1.Maximum = (maxValue / 100).ToString()
        ProgressBar1.Value = (updatingValue / 100).ToString()


        Label1.Text = Val(Label1.Text) - 1
        If Label1.Text = 0 Then Timer1.Enabled = False

    End Sub

    Public Function GetDirSize(RootFolder As String) As Long
        Dim FolderInfo = New IO.DirectoryInfo(RootFolder)
        For Each File In FolderInfo.GetFiles : TotalSize += File.Length
        Next
        For Each SubFolderInfo In FolderInfo.GetDirectories : GetDirSize(SubFolderInfo.FullName)
        Next
        Return TotalSize
    End Function
    Public Function GetDirSize2(RootFolder As String) As Long
        Dim FolderInfo2 = New IO.DirectoryInfo(RootFolder)
        For Each File2 In FolderInfo2.GetFiles : TotalSize2 += File2.Length
        Next
        For Each SubFolderInfo2 In FolderInfo2.GetDirectories
            If ((SubFolderInfo2.Attributes And FileAttributes.ReparsePoint) = FileAttributes.ReparsePoint) = False Then
                GetDirSize2(SubFolderInfo2.FullName)
            End If
        Next
        Return TotalSize2
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not DirectoryExists("C: \Users\student\AppData\Local\Packages\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe\LocalState") Then
            My.Computer.FileSystem.CreateDirectory("C: \Users\student\AppData\Local\Packages\Microsoft.MicrosoftStickyNotes_8wekyb3d8bbwe\LocalState")
        End If
    End Sub
End Class