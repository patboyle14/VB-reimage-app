﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radGDrive = New System.Windows.Forms.RadioButton()
        Me.radFDrive = New System.Windows.Forms.RadioButton()
        Me.radEDrive = New System.Windows.Forms.RadioButton()
        Me.radDDrive = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkChrome = New System.Windows.Forms.CheckBox()
        Me.chkWallpaper = New System.Windows.Forms.CheckBox()
        Me.chkStickyNotes = New System.Windows.Forms.CheckBox()
        Me.btnSwap = New System.Windows.Forms.Button()
        Me.Groupbox3 = New System.Windows.Forms.GroupBox()
        Me.btnDifferentUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtParentFolder = New System.Windows.Forms.TextBox()
        Me.btnCopyMaster = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Groupbox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radGDrive)
        Me.GroupBox1.Controls.Add(Me.radFDrive)
        Me.GroupBox1.Controls.Add(Me.radEDrive)
        Me.GroupBox1.Controls.Add(Me.radDDrive)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Which drive to copy from?"
        '
        'radGDrive
        '
        Me.radGDrive.AutoSize = True
        Me.radGDrive.Location = New System.Drawing.Point(19, 115)
        Me.radGDrive.Name = "radGDrive"
        Me.radGDrive.Size = New System.Drawing.Size(81, 21)
        Me.radGDrive.TabIndex = 3
        Me.radGDrive.Text = "G: Drive"
        Me.radGDrive.UseVisualStyleBackColor = True
        '
        'radFDrive
        '
        Me.radFDrive.AutoSize = True
        Me.radFDrive.Location = New System.Drawing.Point(19, 87)
        Me.radFDrive.Name = "radFDrive"
        Me.radFDrive.Size = New System.Drawing.Size(78, 21)
        Me.radFDrive.TabIndex = 2
        Me.radFDrive.Text = "F: Drive"
        Me.radFDrive.UseVisualStyleBackColor = True
        '
        'radEDrive
        '
        Me.radEDrive.AutoSize = True
        Me.radEDrive.Location = New System.Drawing.Point(19, 59)
        Me.radEDrive.Name = "radEDrive"
        Me.radEDrive.Size = New System.Drawing.Size(79, 21)
        Me.radEDrive.TabIndex = 1
        Me.radEDrive.Text = "E: Drive"
        Me.radEDrive.UseVisualStyleBackColor = True
        '
        'radDDrive
        '
        Me.radDDrive.AutoSize = True
        Me.radDDrive.Checked = True
        Me.radDDrive.Location = New System.Drawing.Point(19, 31)
        Me.radDDrive.Name = "radDDrive"
        Me.radDDrive.Size = New System.Drawing.Size(80, 21)
        Me.radDDrive.TabIndex = 0
        Me.radDDrive.TabStop = True
        Me.radDDrive.Text = "D: Drive"
        Me.radDDrive.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkChrome)
        Me.GroupBox2.Controls.Add(Me.chkWallpaper)
        Me.GroupBox2.Controls.Add(Me.chkStickyNotes)
        Me.GroupBox2.Location = New System.Drawing.Point(43, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 124)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Swap options"
        '
        'chkChrome
        '
        Me.chkChrome.AutoSize = True
        Me.chkChrome.Location = New System.Drawing.Point(19, 78)
        Me.chkChrome.Name = "chkChrome"
        Me.chkChrome.Size = New System.Drawing.Size(153, 21)
        Me.chkChrome.TabIndex = 2
        Me.chkChrome.Text = "Chrome Bookmarks"
        Me.chkChrome.UseVisualStyleBackColor = True
        '
        'chkWallpaper
        '
        Me.chkWallpaper.AutoSize = True
        Me.chkWallpaper.Location = New System.Drawing.Point(19, 50)
        Me.chkWallpaper.Name = "chkWallpaper"
        Me.chkWallpaper.Size = New System.Drawing.Size(94, 21)
        Me.chkWallpaper.TabIndex = 1
        Me.chkWallpaper.Text = "Wallpaper"
        Me.chkWallpaper.UseVisualStyleBackColor = True
        '
        'chkStickyNotes
        '
        Me.chkStickyNotes.AutoSize = True
        Me.chkStickyNotes.Location = New System.Drawing.Point(19, 22)
        Me.chkStickyNotes.Name = "chkStickyNotes"
        Me.chkStickyNotes.Size = New System.Drawing.Size(108, 21)
        Me.chkStickyNotes.TabIndex = 0
        Me.chkStickyNotes.Text = "Sticky Notes"
        Me.chkStickyNotes.UseVisualStyleBackColor = True
        '
        'btnSwap
        '
        Me.btnSwap.Location = New System.Drawing.Point(53, 337)
        Me.btnSwap.Name = "btnSwap"
        Me.btnSwap.Size = New System.Drawing.Size(179, 62)
        Me.btnSwap.TabIndex = 2
        Me.btnSwap.Text = "Copy swap options"
        Me.btnSwap.UseVisualStyleBackColor = True
        '
        'Groupbox3
        '
        Me.Groupbox3.Controls.Add(Me.btnDifferentUser)
        Me.Groupbox3.Controls.Add(Me.Label1)
        Me.Groupbox3.Controls.Add(Me.txtParentFolder)
        Me.Groupbox3.Location = New System.Drawing.Point(344, 30)
        Me.Groupbox3.Name = "Groupbox3"
        Me.Groupbox3.Size = New System.Drawing.Size(222, 178)
        Me.Groupbox3.TabIndex = 3
        Me.Groupbox3.TabStop = False
        Me.Groupbox3.Text = "Name of parent folder to copy"
        '
        'btnDifferentUser
        '
        Me.btnDifferentUser.Location = New System.Drawing.Point(46, 69)
        Me.btnDifferentUser.Name = "btnDifferentUser"
        Me.btnDifferentUser.Size = New System.Drawing.Size(125, 28)
        Me.btnDifferentUser.TabIndex = 2
        Me.btnDifferentUser.Text = "Different user?"
        Me.btnDifferentUser.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Default: C:\Users\Student"
        '
        'txtParentFolder
        '
        Me.txtParentFolder.Enabled = False
        Me.txtParentFolder.Location = New System.Drawing.Point(30, 114)
        Me.txtParentFolder.Name = "txtParentFolder"
        Me.txtParentFolder.Size = New System.Drawing.Size(153, 22)
        Me.txtParentFolder.TabIndex = 0
        '
        'btnCopyMaster
        '
        Me.btnCopyMaster.Location = New System.Drawing.Point(361, 249)
        Me.btnCopyMaster.Name = "btnCopyMaster"
        Me.btnCopyMaster.Size = New System.Drawing.Size(179, 54)
        Me.btnCopyMaster.TabIndex = 4
        Me.btnCopyMaster.Text = "Copy all user files (reimage)"
        Me.btnCopyMaster.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnSwap
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 424)
        Me.Controls.Add(Me.btnCopyMaster)
        Me.Controls.Add(Me.Groupbox3)
        Me.Controls.Add(Me.btnSwap)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Easy re-image"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Groupbox3.ResumeLayout(False)
        Me.Groupbox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radGDrive As RadioButton
    Friend WithEvents radFDrive As RadioButton
    Friend WithEvents radEDrive As RadioButton
    Friend WithEvents radDDrive As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkChrome As CheckBox
    Friend WithEvents chkWallpaper As CheckBox
    Friend WithEvents chkStickyNotes As CheckBox
    Friend WithEvents btnSwap As Button
    Friend WithEvents Groupbox3 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtParentFolder As TextBox
    Friend WithEvents btnCopyMaster As Button
    Friend WithEvents btnDifferentUser As Button
End Class