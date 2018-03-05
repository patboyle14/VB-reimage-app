<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Debug_Form
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
        Me.components = New System.ComponentModel.Container()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnDebugWP = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFilesCopied = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(82, 132)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 31)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Debug"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnDebugWP
        '
        Me.btnDebugWP.Location = New System.Drawing.Point(32, 202)
        Me.btnDebugWP.Name = "btnDebugWP"
        Me.btnDebugWP.Size = New System.Drawing.Size(159, 65)
        Me.btnDebugWP.TabIndex = 4
        Me.btnDebugWP.Text = "Debug - WP"
        Me.btnDebugWP.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(32, 32)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(576, 22)
        Me.ProgressBar1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 17)
        Me.Label3.TabIndex = 6
        '
        'BackgroundWorker1
        '
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "65"
        '
        'lblFilesCopied
        '
        Me.lblFilesCopied.AutoSize = True
        Me.lblFilesCopied.Location = New System.Drawing.Point(301, 88)
        Me.lblFilesCopied.Name = "lblFilesCopied"
        Me.lblFilesCopied.Size = New System.Drawing.Size(0, 17)
        Me.lblFilesCopied.TabIndex = 9
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(321, 169)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(247, 23)
        Me.ProgressBar2.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(433, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Debug_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 299)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.lblFilesCopied)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnDebugWP)
        Me.Controls.Add(Me.Button4)
        Me.Name = "Debug_Form"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As Button
    Friend WithEvents btnDebugWP As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFilesCopied As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Button1 As Button
End Class
