Imports System.ComponentModel
Imports System.IO
Imports System.Security.Permissions

Partial Public Class debugUpdate
    Private bw As BackgroundWorker = New BackgroundWorker
    Private bwCopy As BackgroundWorker = New BackgroundWorker
    Dim TotalSize As Long = 0
    Dim TotalSize2 As Long = 0
    Public Shared strFullPath As String = "C:\users\student\pattest2"
    Dim strDestinationLocation As String = "D:\users\student\"
    Public Shared updatingValue As Long
    Public Shared maxValue As Long

    Public Sub New()
        InitializeComponent()

        bw.WorkerReportsProgress = True
        bw.WorkerSupportsCancellation = True
        bwCopy.WorkerReportsProgress = True
        bwCopy.WorkerSupportsCancellation = True
        AddHandler bw.DoWork, AddressOf bw_DoWork
        AddHandler bw.ProgressChanged, AddressOf bw_ProgressChanged
        AddHandler bw.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
        AddHandler bwCopy.DoWork, AddressOf bwCopy_DoWork
        AddHandler bwCopy.RunWorkerCompleted, AddressOf bwCopy_RunWorkerCompleted

    End Sub
    Private Sub bw_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        While (bwCopy.CancellationPending) = False
            If bw.CancellationPending = True Then
                e.Cancel = True
            Else
                ' Perform a time consuming operation and report progress.
                TotalSize = 0
                Dim TheSize As Long = GetDirSize(strFullPath)
                maxValue = (FormatNumber(TheSize / 1024 / 1024, 1))

                'keep getting the value of the new folder
                TotalSize2 = 0
                Dim TheSize2 As Long = GetDirSize2(strDestinationLocation)
                updatingValue = (FormatNumber(TheSize2 / 1024 / 1024, 1))
                System.Threading.Thread.Sleep(500)
                bw.ReportProgress((updatingValue / maxValue) * 100)
            End If
        End While
    End Sub
    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then
            Me.tbProgress.Text = "Canceled!"
        ElseIf e.Error IsNot Nothing Then
            Me.tbProgress.Text = "Error: " & e.Error.Message
        Else
            Me.tbProgress.Text = "Done!"
        End If
    End Sub
    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        Me.tbProgress.Text = e.ProgressPercentage.ToString() & "%"
        lblFilesCopied.Text = (updatingValue & " out of " & maxValue & " megabytes")
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If Not bw.IsBusy = True Then
            bw.RunWorkerAsync()
            bwCopy.RunWorkerAsync()

        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If bw.WorkerSupportsCancellation = True Then
            bw.CancelAsync()
        End If
    End Sub


    'get the directory size in bytes of a folder and return it as 'totalsize'
    Public Function GetDirSize(RootFolder As String) As Long
        Dim FolderInfo = New IO.DirectoryInfo(RootFolder)
        If ((FolderInfo.Attributes And FileAttributes.ReparsePoint) = FileAttributes.ReparsePoint) = False Then
            If (FolderInfo.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden = False Then
                If (FolderInfo.Attributes And FileIOPermissionAccess.Write) = FileIOPermissionAccess.Write = False Then
                    For Each File In FolderInfo.GetFiles
                        TotalSize += File.Length
                    Next
                End If
            End If
        End If
        If ((FolderInfo.Attributes And FileAttributes.ReparsePoint) = FileAttributes.ReparsePoint) = False Then
            If (FolderInfo.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden = False Then
                If (FolderInfo.Attributes And FileIOPermissionAccess.Write) = FileIOPermissionAccess.Write = False Then
                    For Each SubFolderInfo In FolderInfo.GetDirectories
                        GetDirSize(SubFolderInfo.FullName)
                    Next
                End If
            End If
        End If
        Return TotalSize
    End Function


    'same thing, but different names to do the same counters on a different file simultaneously
    Public Function GetDirSize2(RootFolder As String) As Long
        Dim FolderInfo2 = New IO.DirectoryInfo(RootFolder)
        For Each File2 In FolderInfo2.GetFiles : TotalSize2 += File2.Length
        Next
        For Each SubFolderInfo2 In FolderInfo2.GetDirectories
            If ((SubFolderInfo2.Attributes And FileAttributes.ReparsePoint) = FileAttributes.ReparsePoint) = False Then
                If (SubFolderInfo2.Attributes And FileAttributes.Hidden) = FileAttributes.Hidden = False Then
                    If (SubFolderInfo2.Attributes And FileIOPermissionAccess.Write) = FileIOPermissionAccess.Write = False Then
                        GetDirSize2(SubFolderInfo2.FullName)
                    End If
                End If
            End If
        Next
        Return TotalSize2
    End Function


    'main COPYFOLDER sub
    Public Sub CopyFolder(ByVal SourceFolder As String, ByVal DestFolder As String)
        'get amount of files in the main c:/users/<user> directory
        Dim xFilesCount = Directory.GetDirectories(SourceFolder).Length
        Dim xFilesTransferred As Integer = 0

        Try
            'do "file" copies in c:/users/<user> directory
            For Each item In FileIO.FileSystem.GetFiles(SourceFolder)
                Try
                    'don't copy hidde files
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
                    CopyFolder(SubFolder, DestFolder & "\" & FileIO.FileSystem.GetDirectoryInfo(SubFolder).Name)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub

    Public Sub bwCopy_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        CopyFolder(strFullPath, strDestinationLocation)
    End Sub
    Private Sub bwCopy_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)

        MessageBox.Show("Background work done")
        'shut off the timer
        bw.CancelAsync()

    End Sub

End Class