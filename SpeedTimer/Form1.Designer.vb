<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.timerLabel = New System.Windows.Forms.Label()
        Me.timerButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.totalAvgChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pretimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ao5Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bestLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ao100Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.worstLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.totalAvgChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'timerLabel
        '
        Me.timerLabel.AutoSize = True
        Me.timerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerLabel.Location = New System.Drawing.Point(-1, 18)
        Me.timerLabel.Name = "timerLabel"
        Me.timerLabel.Size = New System.Drawing.Size(200, 76)
        Me.timerLabel.TabIndex = 0
        Me.timerLabel.Text = "00.00"
        '
        'timerButton
        '
        Me.timerButton.BackColor = System.Drawing.Color.Yellow
        Me.timerButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.timerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.timerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.timerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerButton.Location = New System.Drawing.Point(12, 99)
        Me.timerButton.Name = "timerButton"
        Me.timerButton.Size = New System.Drawing.Size(158, 83)
        Me.timerButton.TabIndex = 1
        Me.timerButton.Text = "Ready!"
        Me.timerButton.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'totalAvgChart
        '
        ChartArea1.Name = "ChartArea1"
        Me.totalAvgChart.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.totalAvgChart.Legends.Add(Legend1)
        Me.totalAvgChart.Location = New System.Drawing.Point(236, 307)
        Me.totalAvgChart.Name = "totalAvgChart"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Legend = "Legend1"
        Series1.Name = "AllTimes"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "HalfTimes"
        Me.totalAvgChart.Series.Add(Series1)
        Me.totalAvgChart.Series.Add(Series2)
        Me.totalAvgChart.Size = New System.Drawing.Size(436, 210)
        Me.totalAvgChart.TabIndex = 2
        Me.totalAvgChart.Text = "Chart1"
        '
        'pretimer
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.worstLabel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ao100Label)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ao5Label)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.bestLabel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 307)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 210)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stats"
        '
        'ao5Label
        '
        Me.ao5Label.AutoSize = True
        Me.ao5Label.Location = New System.Drawing.Point(52, 49)
        Me.ao5Label.Name = "ao5Label"
        Me.ao5Label.Size = New System.Drawing.Size(34, 13)
        Me.ao5Label.TabIndex = 3
        Me.ao5Label.Text = "00.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ao5:"
        '
        'bestLabel
        '
        Me.bestLabel.AutoSize = True
        Me.bestLabel.Location = New System.Drawing.Point(52, 25)
        Me.bestLabel.Name = "bestLabel"
        Me.bestLabel.Size = New System.Drawing.Size(34, 13)
        Me.bestLabel.TabIndex = 1
        Me.bestLabel.Text = "00.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Best: "
        '
        'ao100Label
        '
        Me.ao100Label.AutoSize = True
        Me.ao100Label.Location = New System.Drawing.Point(52, 62)
        Me.ao100Label.Name = "ao100Label"
        Me.ao100Label.Size = New System.Drawing.Size(34, 13)
        Me.ao100Label.TabIndex = 5
        Me.ao100Label.Text = "00.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ao100:"
        '
        'worstLabel
        '
        Me.worstLabel.AutoSize = True
        Me.worstLabel.Location = New System.Drawing.Point(52, 37)
        Me.worstLabel.Name = "worstLabel"
        Me.worstLabel.Size = New System.Drawing.Size(34, 13)
        Me.worstLabel.TabIndex = 7
        Me.worstLabel.Text = "00.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Worst: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(260, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "White"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Control
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(260, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Green"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Control
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(375, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Blue"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(259, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Yellow"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Control
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(375, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Red"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Control
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Orange
        Me.Label10.Location = New System.Drawing.Point(375, 135)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Orange"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 538)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.totalAvgChart)
        Me.Controls.Add(Me.timerButton)
        Me.Controls.Add(Me.timerLabel)
        Me.Name = "mainForm"
        Me.Text = "SpeedTimer"
        CType(Me.totalAvgChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timerLabel As Label
    Friend WithEvents timerButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents totalAvgChart As DataVisualization.Charting.Chart
    Friend WithEvents pretimer As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents bestLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ao5Label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ao100Label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents worstLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
