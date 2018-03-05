<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class name_reimage
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFilesCopied = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnCopyMaster = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radGDrive = New System.Windows.Forms.RadioButton()
        Me.radFDrive = New System.Windows.Forms.RadioButton()
        Me.radEDrive = New System.Windows.Forms.RadioButton()
        Me.radDDrive = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtParentFolder = New System.Windows.Forms.TextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.BG_NameImage = New System.ComponentModel.BackgroundWorker()
        Me.BG_CountFiles = New System.ComponentModel.BackgroundWorker()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Copied:"
        '
        'lblFilesCopied
        '
        Me.lblFilesCopied.AutoSize = True
        Me.lblFilesCopied.Location = New System.Drawing.Point(235, 340)
        Me.lblFilesCopied.Name = "lblFilesCopied"
        Me.lblFilesCopied.Size = New System.Drawing.Size(0, 17)
        Me.lblFilesCopied.TabIndex = 13
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(91, 360)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(570, 23)
        Me.ProgressBar1.TabIndex = 12
        '
        'btnCopyMaster
        '
        Me.btnCopyMaster.Location = New System.Drawing.Point(147, 283)
        Me.btnCopyMaster.Name = "btnCopyMaster"
        Me.btnCopyMaster.Size = New System.Drawing.Size(179, 54)
        Me.btnCopyMaster.TabIndex = 11
        Me.btnCopyMaster.Text = "Start reimage"
        Me.btnCopyMaster.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radGDrive)
        Me.GroupBox1.Controls.Add(Me.radFDrive)
        Me.GroupBox1.Controls.Add(Me.radEDrive)
        Me.GroupBox1.Controls.Add(Me.radDDrive)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 173)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drive letter of transfer data HDD"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(404, 142)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Folder name to copy from:"
        '
        'txtParentFolder
        '
        Me.txtParentFolder.Location = New System.Drawing.Point(360, 167)
        Me.txtParentFolder.Name = "txtParentFolder"
        Me.txtParentFolder.Size = New System.Drawing.Size(301, 22)
        Me.txtParentFolder.TabIndex = 15
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(317, 39)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(312, 53)
        Me.RichTextBox1.TabIndex = 16
        Me.RichTextBox1.Text = "Please note: you should have already copied the student data to the external HDD." &
    " This is the transfer of data back to the computer."
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Location = New System.Drawing.Point(433, 283)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(179, 54)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'name_reimage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 429)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txtParentFolder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFilesCopied)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnCopyMaster)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "name_reimage"
        Me.Text = "Easy re-image v1.0"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents lblFilesCopied As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnCopyMaster As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radGDrive As RadioButton
    Friend WithEvents radFDrive As RadioButton
    Friend WithEvents radEDrive As RadioButton
    Friend WithEvents radDDrive As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtParentFolder As TextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents BG_NameImage As System.ComponentModel.BackgroundWorker
    Friend WithEvents BG_CountFiles As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnCancel As Button
End Class
