<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class debugUpdate
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tbProgress = New System.Windows.Forms.TextBox()
        Me.lblFilesCopied = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(4, 150)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(220, 150)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tbProgress
        '
        Me.tbProgress.Location = New System.Drawing.Point(100, 70)
        Me.tbProgress.Name = "tbProgress"
        Me.tbProgress.Size = New System.Drawing.Size(100, 22)
        Me.tbProgress.TabIndex = 3
        '
        'lblFilesCopied
        '
        Me.lblFilesCopied.AutoSize = True
        Me.lblFilesCopied.Location = New System.Drawing.Point(131, 238)
        Me.lblFilesCopied.Name = "lblFilesCopied"
        Me.lblFilesCopied.Size = New System.Drawing.Size(0, 17)
        Me.lblFilesCopied.TabIndex = 4
        '
        'debugUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 291)
        Me.Controls.Add(Me.lblFilesCopied)
        Me.Controls.Add(Me.tbProgress)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label1)
        Me.Name = "debugUpdate"
        Me.Text = "debugUpdate"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents tbProgress As TextBox
    Friend WithEvents lblFilesCopied As Label
End Class
