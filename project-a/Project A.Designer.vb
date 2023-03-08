<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectAForm
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
        Me.ButtonRunProjectB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonRunProjectB
        '
        Me.ButtonRunProjectB.Location = New System.Drawing.Point(50, 50)
        Me.ButtonRunProjectB.Name = "ButtonRunProjectB"
        Me.ButtonRunProjectB.Size = New System.Drawing.Size(180, 35)
        Me.ButtonRunProjectB.TabIndex = 0
        Me.ButtonRunProjectB.Text = "Run Project B"
        Me.ButtonRunProjectB.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 244)
        Me.Controls.Add(Me.ButtonRunProjectB)
        Me.Name = "Form1"
        Me.Text = "Project A"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonRunProjectB As Button
End Class
