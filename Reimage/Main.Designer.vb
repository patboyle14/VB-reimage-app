<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnYoga370 = New System.Windows.Forms.Button()
        Me.btnOther = New System.Windows.Forms.Button()
        Me.lblUserInfo = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(189, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What type of copy are you doing?"
        '
        'btnYoga370
        '
        Me.btnYoga370.Location = New System.Drawing.Point(203, 225)
        Me.btnYoga370.Name = "btnYoga370"
        Me.btnYoga370.Size = New System.Drawing.Size(189, 47)
        Me.btnYoga370.TabIndex = 1
        Me.btnYoga370.Text = "From external data HDD"
        Me.btnYoga370.UseVisualStyleBackColor = True
        '
        'btnOther
        '
        Me.btnOther.Location = New System.Drawing.Point(203, 163)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(189, 44)
        Me.btnOther.TabIndex = 2
        Me.btnOther.Text = "Directly from user HDD"
        Me.btnOther.UseVisualStyleBackColor = True
        '
        'lblUserInfo
        '
        Me.lblUserInfo.AutoSize = True
        Me.lblUserInfo.BackColor = System.Drawing.SystemColors.Control
        Me.lblUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUserInfo.Location = New System.Drawing.Point(39, 310)
        Me.lblUserInfo.Name = "lblUserInfo"
        Me.lblUserInfo.Size = New System.Drawing.Size(577, 19)
        Me.lblUserInfo.TabIndex = 3
        Me.lblUserInfo.Text = "------------------------- For use by Bryant University Laptop Central only. -----" &
    "--------------------"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!)
        Me.RichTextBox1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.RichTextBox1.Location = New System.Drawing.Point(96, 55)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(424, 47)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = "Easy re-image program v1.2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(214, 352)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(219, 168)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 523)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.lblUserInfo)
        Me.Controls.Add(Me.btnOther)
        Me.Controls.Add(Me.btnYoga370)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main"
        Me.Text = "Easy re-image v1.2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnYoga370 As Button
    Friend WithEvents btnOther As Button
    Friend WithEvents lblUserInfo As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
