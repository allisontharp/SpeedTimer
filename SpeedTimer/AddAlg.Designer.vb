<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAlg
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NewAlgTextBox = New System.Windows.Forms.TextBox()
        Me.NewAlgSubmit = New System.Windows.Forms.Button()
        Me.AlgNameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Algorithm"
        '
        'NewAlgTextBox
        '
        Me.NewAlgTextBox.Location = New System.Drawing.Point(74, 15)
        Me.NewAlgTextBox.Name = "NewAlgTextBox"
        Me.NewAlgTextBox.Size = New System.Drawing.Size(213, 20)
        Me.NewAlgTextBox.TabIndex = 3
        '
        'NewAlgSubmit
        '
        Me.NewAlgSubmit.Location = New System.Drawing.Point(19, 41)
        Me.NewAlgSubmit.Name = "NewAlgSubmit"
        Me.NewAlgSubmit.Size = New System.Drawing.Size(268, 41)
        Me.NewAlgSubmit.TabIndex = 4
        Me.NewAlgSubmit.Text = "Submit"
        Me.NewAlgSubmit.UseVisualStyleBackColor = True
        '
        'AlgNameLabel
        '
        Me.AlgNameLabel.AutoSize = True
        Me.AlgNameLabel.Location = New System.Drawing.Point(16, 85)
        Me.AlgNameLabel.Name = "AlgNameLabel"
        Me.AlgNameLabel.Size = New System.Drawing.Size(50, 13)
        Me.AlgNameLabel.TabIndex = 5
        Me.AlgNameLabel.Text = "AlgName"
        Me.AlgNameLabel.Visible = False
        '
        'AddAlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 100)
        Me.Controls.Add(Me.AlgNameLabel)
        Me.Controls.Add(Me.NewAlgSubmit)
        Me.Controls.Add(Me.NewAlgTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AddAlg"
        Me.Text = "New Algorithm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents NewAlgTextBox As TextBox
    Friend WithEvents NewAlgSubmit As Button
    Friend WithEvents AlgNameLabel As Label
End Class
