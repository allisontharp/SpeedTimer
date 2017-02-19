<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateSolve
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
        Me.StartColorCombobox = New System.Windows.Forms.ComboBox()
        Me.updateSolveButton = New System.Windows.Forms.Button()
        Me.solveid = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Updated Start Color:"
        '
        'StartColorCombobox
        '
        Me.StartColorCombobox.FormattingEnabled = True
        Me.StartColorCombobox.Items.AddRange(New Object() {"White", "Yellow", "Green", "Blue", "Red", "Orange"})
        Me.StartColorCombobox.Location = New System.Drawing.Point(121, 22)
        Me.StartColorCombobox.Name = "StartColorCombobox"
        Me.StartColorCombobox.Size = New System.Drawing.Size(121, 21)
        Me.StartColorCombobox.TabIndex = 1
        '
        'updateSolveButton
        '
        Me.updateSolveButton.Location = New System.Drawing.Point(15, 55)
        Me.updateSolveButton.Name = "updateSolveButton"
        Me.updateSolveButton.Size = New System.Drawing.Size(227, 44)
        Me.updateSolveButton.TabIndex = 2
        Me.updateSolveButton.Text = "Update Start Color"
        Me.updateSolveButton.UseVisualStyleBackColor = True
        '
        'solveid
        '
        Me.solveid.AutoSize = True
        Me.solveid.Location = New System.Drawing.Point(121, 9)
        Me.solveid.Name = "solveid"
        Me.solveid.Size = New System.Drawing.Size(40, 13)
        Me.solveid.TabIndex = 3
        Me.solveid.Text = "solveid"
        Me.solveid.Visible = False
        '
        'UpdateSolve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 113)
        Me.Controls.Add(Me.solveid)
        Me.Controls.Add(Me.updateSolveButton)
        Me.Controls.Add(Me.StartColorCombobox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "UpdateSolve"
        Me.Text = "UpdateSolve"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents updateSolveButton As Button
    Friend WithEvents StartColorCombobox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents solveid As Label
End Class
