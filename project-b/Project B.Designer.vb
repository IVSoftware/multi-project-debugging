<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProjectBForm
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
        Me.ButtonDebugBreak = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonDebugBreak
        '
        Me.ButtonDebugBreak.Location = New System.Drawing.Point(50, 50)
        Me.ButtonDebugBreak.Name = "ButtonDebugBreak"
        Me.ButtonDebugBreak.Size = New System.Drawing.Size(180, 35)
        Me.ButtonDebugBreak.TabIndex = 1
        Me.ButtonDebugBreak.Text = "Debug Break"
        Me.ButtonDebugBreak.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 244)
        Me.Controls.Add(Me.ButtonDebugBreak)
        Me.Name = "Form1"
        Me.Text = "Project B"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonDebugBreak As Button
End Class
