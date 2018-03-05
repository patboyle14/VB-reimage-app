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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnYoga370 = New System.Windows.Forms.Button()
        Me.btnOther = New System.Windows.Forms.Button()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(114, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What type of copy are you doing?"
        '
        'btnYoga370
        '
        Me.btnYoga370.Location = New System.Drawing.Point(117, 96)
        Me.btnYoga370.Name = "btnYoga370"
        Me.btnYoga370.Size = New System.Drawing.Size(189, 47)
        Me.btnYoga370.TabIndex = 1
        Me.btnYoga370.Text = "From external data HDD"
        Me.btnYoga370.UseVisualStyleBackColor = True
        '
        'btnOther
        '
        Me.btnOther.Location = New System.Drawing.Point(117, 174)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(189, 44)
        Me.btnOther.TabIndex = 2
        Me.btnOther.Text = "Directly from user HDD"
        Me.btnOther.UseVisualStyleBackColor = True
        '
        'btnDebug
        '
        Me.btnDebug.Location = New System.Drawing.Point(170, 249)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(82, 32)
        Me.btnDebug.TabIndex = 3
        Me.btnDebug.Text = "Debug"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(357, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 326)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.btnOther)
        Me.Controls.Add(Me.btnYoga370)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main"
        Me.Text = "Easy re-image v1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnYoga370 As Button
    Friend WithEvents btnOther As Button
    Friend WithEvents btnDebug As Button
    Friend WithEvents Button1 As Button
End Class
