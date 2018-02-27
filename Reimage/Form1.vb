Imports System.Security
Imports System.Security.Permissions
Imports System.IO
Imports Microsoft.VisualBasic.FileIO.FileSystem

Public Class frmMain

    Public Function GetDirSize(RootFolder As String) As Long
        Dim FolderInfo = New IO.DirectoryInfo(RootFolder)
        For Each File In FolderInfo.GetFiles : TotalSize += File.Length
        Next
        For Each SubFolderInfo In FolderInfo.GetDirectories : GetDirSize(SubFolderInfo.FullName)
        Next
        Return TotalSize
    End Function

    Dim TotalSize As Long = 0
    Public strWhichDrive As String
    Public strParentFolder As String
    Dim strDestinationLocation As String = "C:\users\student" 'currently location

    'ideally will be: Dim strDestinationLocation As String = "C:\Users\" 
    ' potentially change that to the same string as the input master

    Public Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets the default text to student when form loads
        txtParentFolder.Text = "student"
    End Sub

    Public Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        Dim strChromePathD As String = "D:\Users\student\AppData\Local\Google\Chrome\User Data\Default\Bookmarks"
        Dim strChromePathE As String = "E:\Users\student\AppData\Local\Google\Chrome\User Data\Default\Bookmarks"
        Dim strChromePathF As String = "F:\Users\student\AppData\Local\Google\Chrome\User Data\Default\Bookmarks"
        Dim strChromePathG As String = "G:\Users\student\AppData\Local\Google\Chrome\User Data\Default\Bookmarks"
        Dim strChromeDestination As String = "C:\Users\student\AppData\Local\Google\Chrome\User Data\Default\Bookmarks"
        Dim strWallpaperPathD As String = "D:\Users\student\AppData\roaming\microsoft\windows\themes\TranscodedWallpaper"
        Dim strWallpaperPathE As String = "E:\Users\student\AppData\roaming\microsoft\windows\themes\TranscodedWallpaper"
        Dim strWallpaperPathF As String = "F:\Users\student\AppData\roaming\microsoft\windows\themes\TranscodedWallpaper"
        Dim strWallpaperPathG As String = "G:\Users\student\AppData\roaming\microsoft\windows\themes\TranscodedWallpaper"
        Dim strWallpaperDestination As String = "C:\Users\Student\AppData\roaming\microsoft\windows\themes\TranscodedWallPaper"
        Dim strStickynotesPathD As String = "D:\Users\student\AppData\Roaming\Microsoft\Sticky Notes"
        Dim strStickynotesPathE As String = "E:\Users\student\AppData\Roaming\Microsoft\Sticky Notes"
        Dim strStickynotesPathF As String = "F:\Users\student\AppData\Roaming\Microsoft\Sticky Notes"
        Dim strStickynotesPathG As String = "G:\Users\student\AppData\Roaming\Microsoft\Sticky Notes"
        Dim strStickynotesDestination As String = "C:\Users\student\AppData\Roaming\Microsoft\Sticky Notes"

        'check which radio button is checked
        'set strWhichDrive to the drive letter

        'D drive
        If radDDrive.Checked = True Then
            strWhichDrive = "D:\Users\"
            If chkChrome.Checked = True Then ' if chrome is checked then
                Try
                    FileIO.FileSystem.CopyFile(strChromePathD, strChromeDestination, True) ' try to copy it
                    MessageBox.Show("Bookmarks copied.") ' output if it succeeds
                Catch ex As System.IO.FileNotFoundException ' if the directory doesn't exist then
                    MessageBox.Show("File not found: " + ex.Message) ' show error message
                End Try
            End If
            If chkStickyNotes.Checked Then
                Try
                    FileIO.FileSystem.CopyDirectory(strStickynotesPathD, strStickynotesDestination, True)
                    MessageBox.Show("Sticky notes copied.")
                Catch ex As System.IO.DirectoryNotFoundException
                    MessageBox.Show("Directory not found: " + ex.Message)
                End Try
            End If
            If chkWallpaper.Checked Then
                Try
                    FileIO.FileSystem.CopyFile(strWallpaperPathD, strWallpaperDestination, True)
                    MessageBox.Show("Wallpaper copied.")
                Catch ex As System.IO.FileNotFoundException
                    MessageBox.Show("File not found: " + ex.Message)
                End Try
            End If
        End If


        'E drive
        If radEDrive.Checked = True Then
            strWhichDrive = "E:\Users\"
            If chkChrome.Checked = True Then
                Try
                    FileIO.FileSystem.CopyFile(strChromePathE, strChromeDestination, True)
                    MessageBox.Show("Bookmarks copied.")
                Catch ex As System.IO.FileNotFoundException
                    MessageBox.Show("File not found: " + ex.Message)
                End Try
            End If
            If chkStickyNotes.Checked Then
                Try
                    FileIO.FileSystem.CopyDirectory(strStickynotesPathE, strStickynotesDestination, True)
                    MessageBox.Show("Sticky notes copied.")
                Catch ex As System.IO.DirectoryNotFoundException
                    MessageBox.Show("Directory not found: " + ex.Message)
                End Try
            End If
            If chkWallpaper.Checked Then
                Try
                    FileIO.FileSystem.CopyFile(strWallpaperPathE, strWallpaperDestination, True)
                    MessageBox.Show("Wallpaper copied.")
                Catch ex As System.IO.FileNotFoundException
                    MessageBox.Show("Directory not found: " + ex.Message)
                End Try
            End If
        End If

        ' F drive
        If radFDrive.Checked = True Then
            strWhichDrive = "F:\Users\"
            If chkChrome.Checked = True Then
                Try
                    FileIO.FileSystem.CopyFile(strChromePathF, strChromeDestination, True)
                    MessageBox.Show("Bookmarks copied.")
                Catch ex As System.IO.FileNotFoundException
                    MessageBox.Show("File not found: " + ex.Message)
                End Try
            End If
            If chkStickyNotes.Checked Then
                Try
                    FileIO.FileSystem.CopyDirectory(strStickynotesPathF, strStickynotesDestination, True)
                    MessageBox.Show("Sticky notes copied.")
                Catch ex As System.IO.DirectoryNotFoundException
                    MessageBox.Show("Directory not found: " + ex.Message)
                End Try
            End If
            If chkWallpaper.Checked Then
                Try
                    FileIO.FileSystem.CopyFile(strWallpaperPathF, strWallpaperDestination, True)
                    MessageBox.Show("Wallpaper copied.")
                Catch ex As System.IO.FileNotFoundException
                    MessageBox.Show("File not found: " + ex.Message)
                End Try
            End If

            'G drive
        ElseIf radGDrive.Checked = True Then
            strWhichDrive = "G:\Users\"
            If chkChrome.Checked = True Then
                Try
                    FileIO.FileSystem.CopyFile(strChromePathG, strChromeDestination, True)
                    MessageBox.Show("Bookmarks copied.")
                Catch ex As System.IO.FileNotFoundException
                    MessageBox.Show("File not found: " + ex.Message)
                End Try
            End If
            If chkStickyNotes.Checked Then
                Try
                    FileIO.FileSystem.CopyDirectory(strStickynotesPathG, strStickynotesDestination, True)
                    MessageBox.Show("Sticky notes copied.")
                Catch ex As System.IO.DirectoryNotFoundException
                    MessageBox.Show("Directory not found: " + ex.Message)
                End Try
            End If
            If chkWallpaper.Checked Then
                Try
                    FileIO.FileSystem.CopyFile(strWallpaperPathG, strWallpaperDestination, True)
                    MessageBox.Show("Wallpaper copied.")
                Catch ex As System.IO.FileNotFoundException
                    MessageBox.Show("File not found: " + ex.Message)
                End Try
            End If
        End If

    End Sub

    Public Sub btnCopyMaster_Click(sender As Object, e As EventArgs) Handles btnCopyMaster.Click
        Dim strFullPath As String


        'check for blank input
        If txtParentFolder.Text = String.Empty Then

            MessageBox.Show("Must have an input for the folder to copy", "Blank Input", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation)

            txtParentFolder.Focus()

            Exit Sub

        End If

        'set the parent copy folder text as strParentFolder string variable
        'this is the user inputting the file path besides drive. usually will be "student", 
        'Default to student On form load
        strParentFolder = txtParentFolder.Text

        'set strWhichDrive to the right drive
        If radDDrive.Checked = True Then
            strWhichDrive = "D:\Users\"
        End If
        If radEDrive.Checked = True Then
            strWhichDrive = "E:\Users\"
        End If
        If radFDrive.Checked = True Then
            strWhichDrive = "F:\Users\"
        End If
        If radGDrive.Checked = True Then
            strWhichDrive = "G:\Users\"
        End If

        'counter to check total file size of what you're copying
        '  Dim TheSize As Long
        ' Dim beforeCounter As String
        'Try
        'TotalSize = 0 'Reset the counter
        'TheSize = GetDirSize(strWhichDrive & strParentFolder)
        'beforeCounter = CStr((FormatNumber(TheSize / 1024 / 1024, 1) & " Megabytes" & vbCr))
        'Catch ex As System.IO.DirectoryNotFoundException ' error catch
        'MessageBox.Show("Directory not found: " + ex.Message) ' error catch output
        'Exit Sub
        'End Try

        'make full path a string
        strFullPath = (strWhichDrive & strParentFolder)

        'set up confirmationbox, if yes the copy continues
        Dim answer As DialogResult
        answer = MessageBox.Show("You are about to copy " & strFullPath & " to " & strDestinationLocation & " - continue?",
                                 "Yes/no sample", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If answer = vbYes Then 'if user says yes, then
            Try
                'call copyfolder method
                CopyFolder(strFullPath, strDestinationLocation)
                'FileIO.FileSystem.CopyDirectory(strWhichDrive & strParentFolder, strDestinationLocation, True)
                MessageBox.Show("All files copied")
            Catch ex As System.IO.DirectoryNotFoundException ' error catch
                MessageBox.Show("Directory not found " + ex.Message) ' error catch output
            End Try
        End If
    End Sub

    Private Sub btnDifferentUser_Click(sender As Object, e As EventArgs) Handles btnDifferentUser.Click
        'toggle textbox enable or not
        txtParentFolder.Enabled = Not txtParentFolder.Enabled
    End Sub
    Public Sub CopyFolder(ByVal SourceFolder As String, ByVal DestFolder As String)
        'get amount of files in main directory
        Dim xFilesCount = Directory.GetFiles(SourceFolder).Length
        'counter for progress bar
        Dim xFilesTransferred As Integer = 0
        'copy files try method
        Try
            For Each item In FileIO.FileSystem.GetFiles(SourceFolder)
                Try
                    'say what file we're copying at the moment
                    lblCurrentFile.Refresh()
                    lblCurrentFile.Text = FileIO.FileSystem.GetName(item)
                    'copy file
                    FileIO.FileSystem.CopyFile(item, DestFolder & "\" & FileIO.FileSystem.GetFileInfo(item).Name)
                    'iterator to count files
                    xFilesTransferred += 1

                    'update progress bar
                    ProgressBar1.Value = xFilesTransferred * 100 / xFilesCount
                    ProgressBar1.Update()
                Catch ex As Exception

                End Try
            Next
        Catch ex As Exception

        End Try

        'copy subfolders
        Try
            For Each SubFolder In FileIO.FileSystem.GetDirectories(SourceFolder)
                CopyFolder(SubFolder, DestFolder & "\" & FileIO.FileSystem.GetDirectoryInfo(SubFolder).Name)
            Next
        Catch ex As Exception

        End Try
    End Sub

End Class
