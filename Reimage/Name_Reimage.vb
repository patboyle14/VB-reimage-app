Imports System.Security
Imports System.Security.Permissions
Imports System.IO
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System.ComponentModel

Public Class name_reimage

    'declare all my shared strings and importat dim's
    Public strWhichDrive As String
    Public strParentFolder As String
    Public Shared strFullPath As String
    Dim strDestinationLocation As String = "C:\users\student" 'currently location
    Private bwUpdater As BackgroundWorker = New BackgroundWorker
    Private bwCopy As BackgroundWorker = New BackgroundWorker
    Dim TotalSize As Long = 0
    Dim TotalSize2 As Long = 0
    Public Shared updatingValue As Long
    Public Shared maxValue As Long

    'initialize my BW's
    Public Sub New()
        InitializeComponent()

        bwUpdater.WorkerReportsProgress = True
        bwUpdater.WorkerSupportsCancellation = True
        bwCopy.WorkerReportsProgress = True
        bwCopy.WorkerSupportsCancellation = True
        AddHandler bwUpdater.DoWork, AddressOf bwUpdater_DoWork
        AddHandler bwUpdater.ProgressChanged, AddressOf bwUpdater_ProgressChanged
        AddHandler bwUpdater.RunWorkerCompleted, AddressOf bwUpdater_RunWorkerCompleted
        AddHandler bwCopy.DoWork, AddressOf bwCopy_DoWork
        AddHandler bwCopy.RunWorkerCompleted, AddressOf bwCopy_RunWorkerCompleted

    End Sub

    Public Sub btnCopyMaster_Click(sender As Object, e As EventArgs) Handles btnCopyMaster.Click

        'check for blank input
        If txtParentFolder.Text = String.Empty Then
            MessageBox.Show("Must have an input for the folder to copy", "Blank Input", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            txtParentFolder.Focus()
            Exit Sub
        End If

        'set the parent copy folder text as strParentFolder string variable
        'this is the user inputting the file path besides drive.
        strParentFolder = txtParentFolder.Text

        'set strWhichDrive to the right drive
        If radDDrive.Checked = True Then
            strWhichDrive = "D:\"
        End If
        If radEDrive.Checked = True Then
            strWhichDrive = "E:\"
        End If
        If radFDrive.Checked = True Then
            strWhichDrive = "F:\"
        End If
        If radGDrive.Checked = True Then
            strWhichDrive = "G:\"
        End If

        'make full path a string (AKA F:\John Doe\)
        strFullPath = (strWhichDrive & strParentFolder)

        'error checking to make sure the folder exists
        If Not Directory.Exists(strFullPath) Then
            MessageBox.Show(strFullPath & " does not exist. Please verify that the folder name you entered exists.",
                             "Does not exist", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)
            Exit Sub
        End If

        'set up formatnumber for number of bytes
        TotalSize = 0 'Reset the counter
        Dim TheSize As Long = GetDirSize(strFullPath)

        'set up confirmationbox, if yes the copy continues
        Dim answer As DialogResult
        'call number of bytes and confirm
        answer = MessageBox.Show("Are you sure you want to copy " & FormatNumber(TheSize / 1024 / 1024, 1) & " megabytes from " & strFullPath & " to " & strDestinationLocation & " ?",
                                 "Yes/no sample", MessageBoxButtons.YesNo, MessageBoxIcon.Question)


        'This is the main calling sub. Change here to change button functions.
        If Not bwCopy.IsBusy = True Then
            If answer = vbYes Then 'if user says yes, then
                Try
                    'Call the workers
                    bwCopy.RunWorkerAsync()
                    bwUpdater.RunWorkerAsync()
                    btnCopyMaster.Enabled = False
                    btnCancel.Enabled = True
                Catch ex As System.IO.DirectoryNotFoundException ' error catch
                    MessageBox.Show("Directory not found " + ex.Message) ' error catch output
                End Try
            End If
        End If
    End Sub

    'main COPYFOLDER sub
    Public Sub CopyFolder(ByVal SourceFolder As String, ByVal DestFolder As String)
        'get amount of files in the main c:/users/<user> directory
        Dim xFilesCount = Directory.GetDirectories(SourceFolder).Length
        Dim xFilesTransferred As Integer = 0

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
                    CopyFolder(SubFolder, DestFolder & "\" & FileIO.FileSystem.GetDirectoryInfo(SubFolder).Name)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub


    'This sub does the copy on its own thread
    Public Sub bwCopy_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        CopyFolder(strFullPath, strDestinationLocation)
    End Sub


    'Progress update thread... use the worker to update and send value to the "progressupdate.e" return value, call later
    Private Sub bwUpdater_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        Dim worker As BackgroundWorker = CType(sender, BackgroundWorker)

        While (bwCopy.CancellationPending) = False
            If bwUpdater.CancellationPending = True Then
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
                bwUpdater.ReportProgress((updatingValue / maxValue) * 100)
            End If
        End While
    End Sub

    'when the updater is done, 
    Private Sub bwUpdater_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
    End Sub


    'Sub for AFTER the copy worker is done -- shut off the progress bar worker too
    Private Sub bwCopy_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then
            MessageBox.Show("Canceled!")
            bwUpdater.CancelAsync()
            btnCopyMaster.Enabled = True
        ElseIf e.Error IsNot Nothing Then
            MessageBox.Show("Error: " & e.Error.Message)
            bwUpdater.CancelAsync()
            btnCopyMaster.Enabled = True
        Else
            MessageBox.Show("All files copied! :)")
            ProgressBar1.Value = 100
            bwUpdater.CancelAsync()
            btnCopyMaster.Enabled = True
        End If

    End Sub

    'updater progress changed
    Private Sub bwUpdater_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        lblFilesCopied.Text = (updatingValue & " out of " & maxValue & " megabytes")
        ProgressBar1.Value = e.ProgressPercentage
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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If bwCopy.IsBusy Then
            Dim answer As DialogResult
            answer = MessageBox.Show("Are you sure you want to cancel this copy?",
                                     "Yes/no sample", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = vbYes Then 'if user says yes, then
                bwCopy.CancelAsync()
                MessageBox.Show("Copy cancelled.")
                ProgressBar1.Value = 0
                lblFilesCopied.Text = ""
                btnCopyMaster.Enabled = True
            End If
        End If
    End Sub
End Class
