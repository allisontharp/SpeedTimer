﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.timerLabel = New System.Windows.Forms.Label()
        Me.timerButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.totalAvgChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.pretimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.worstLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ao100Label = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ao5Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bestLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.whiteCB = New System.Windows.Forms.CheckBox()
        Me.greenCB = New System.Windows.Forms.CheckBox()
        Me.yellowCB = New System.Windows.Forms.CheckBox()
        Me.redCB = New System.Windows.Forms.CheckBox()
        Me.blueCB = New System.Windows.Forms.CheckBox()
        Me.orangeCB = New System.Windows.Forms.CheckBox()
        Me.whiteWorst = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.whiteAo100 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.whiteAo5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.whiteBest = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.whiteToday = New System.Windows.Forms.Label()
        Me.whiteTotal = New System.Windows.Forms.Label()
        Me.yellowTotal = New System.Windows.Forms.Label()
        Me.yellowToday = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.yellowWorst = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.yellowAo100 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.yellowAo5 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.yellowBest = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.redTotal = New System.Windows.Forms.Label()
        Me.redToday = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.redWorst = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.redAo100 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.redAo5 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.redBest = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.greenTotal = New System.Windows.Forms.Label()
        Me.greenToday = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.greenWorst = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.greenAo100 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.greenAo5 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.greenBest = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.orangeTotal = New System.Windows.Forms.Label()
        Me.orangeToday = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.orangeWorst = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.orangeAo100 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.orangeAo5 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.orangeBest = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.blueTotal = New System.Windows.Forms.Label()
        Me.blueToday = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.blueWorst = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.blueAo100 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.blueAo5 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.blueBest = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.allsolvesPlotPG = New System.Windows.Forms.TabPage()
        Me.recentsolvesDataPG = New System.Windows.Forms.TabPage()
        Me.recentSolvesDataGrid = New System.Windows.Forms.DataGridView()
        Me.recentSolves_Strip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UpdateStartColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSolveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.scrambleLabel = New System.Windows.Forms.Label()
        Me.scrambleButton = New System.Windows.Forms.Button()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.SpeedSolvePage = New System.Windows.Forms.TabPage()
        Me.PLLPage = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PLLScramble = New System.Windows.Forms.Label()
        Me.PLLScrambleButton = New System.Windows.Forms.Button()
        Me.PLLTimerLabel = New System.Windows.Forms.Label()
        Me.PLLTimerButton = New System.Windows.Forms.Button()
        Me.PLLAlg = New System.Windows.Forms.Label()
        Me.PLLPicture = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PLLList = New System.Windows.Forms.CheckedListBox()
        Me.PLLImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.UpdateAlgStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddAlgorithmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.totalAvgChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.allsolvesPlotPG.SuspendLayout()
        Me.recentsolvesDataPG.SuspendLayout()
        CType(Me.recentSolvesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.recentSolves_Strip.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.SpeedSolvePage.SuspendLayout()
        Me.PLLPage.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PLLPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UpdateAlgStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'timerLabel
        '
        Me.timerLabel.AutoSize = True
        Me.timerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerLabel.Location = New System.Drawing.Point(23, 39)
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
        Me.timerButton.Location = New System.Drawing.Point(36, 123)
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
        Me.totalAvgChart.Location = New System.Drawing.Point(6, 17)
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
        Me.totalAvgChart.Size = New System.Drawing.Size(436, 195)
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
        Me.GroupBox1.Location = New System.Drawing.Point(27, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(158, 102)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Stats"
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
        'whiteCB
        '
        Me.whiteCB.AutoSize = True
        Me.whiteCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.whiteCB.ForeColor = System.Drawing.Color.White
        Me.whiteCB.Location = New System.Drawing.Point(334, 15)
        Me.whiteCB.Name = "whiteCB"
        Me.whiteCB.Size = New System.Drawing.Size(68, 21)
        Me.whiteCB.TabIndex = 10
        Me.whiteCB.Text = "White"
        Me.whiteCB.UseVisualStyleBackColor = True
        '
        'greenCB
        '
        Me.greenCB.AutoSize = True
        Me.greenCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.greenCB.ForeColor = System.Drawing.Color.Lime
        Me.greenCB.Location = New System.Drawing.Point(640, 132)
        Me.greenCB.Name = "greenCB"
        Me.greenCB.Size = New System.Drawing.Size(72, 21)
        Me.greenCB.TabIndex = 11
        Me.greenCB.Text = "Green"
        Me.greenCB.UseVisualStyleBackColor = True
        '
        'yellowCB
        '
        Me.yellowCB.AutoSize = True
        Me.yellowCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yellowCB.ForeColor = System.Drawing.Color.Yellow
        Me.yellowCB.Location = New System.Drawing.Point(334, 132)
        Me.yellowCB.Name = "yellowCB"
        Me.yellowCB.Size = New System.Drawing.Size(73, 21)
        Me.yellowCB.TabIndex = 12
        Me.yellowCB.Text = "Yellow"
        Me.yellowCB.UseVisualStyleBackColor = True
        '
        'redCB
        '
        Me.redCB.AutoSize = True
        Me.redCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.redCB.ForeColor = System.Drawing.Color.Red
        Me.redCB.Location = New System.Drawing.Point(483, 132)
        Me.redCB.Name = "redCB"
        Me.redCB.Size = New System.Drawing.Size(56, 21)
        Me.redCB.TabIndex = 15
        Me.redCB.Text = "Red"
        Me.redCB.UseVisualStyleBackColor = True
        '
        'blueCB
        '
        Me.blueCB.AutoSize = True
        Me.blueCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blueCB.ForeColor = System.Drawing.Color.Blue
        Me.blueCB.Location = New System.Drawing.Point(640, 15)
        Me.blueCB.Name = "blueCB"
        Me.blueCB.Size = New System.Drawing.Size(59, 21)
        Me.blueCB.TabIndex = 14
        Me.blueCB.Text = "Blue"
        Me.blueCB.UseVisualStyleBackColor = True
        '
        'orangeCB
        '
        Me.orangeCB.AutoSize = True
        Me.orangeCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orangeCB.ForeColor = System.Drawing.Color.Orange
        Me.orangeCB.Location = New System.Drawing.Point(483, 15)
        Me.orangeCB.Name = "orangeCB"
        Me.orangeCB.Size = New System.Drawing.Size(81, 21)
        Me.orangeCB.TabIndex = 13
        Me.orangeCB.Text = "Orange"
        Me.orangeCB.UseVisualStyleBackColor = True
        '
        'whiteWorst
        '
        Me.whiteWorst.AutoSize = True
        Me.whiteWorst.Location = New System.Drawing.Point(402, 79)
        Me.whiteWorst.Name = "whiteWorst"
        Me.whiteWorst.Size = New System.Drawing.Size(34, 13)
        Me.whiteWorst.TabIndex = 15
        Me.whiteWorst.Text = "00.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(331, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Worst: "
        '
        'whiteAo100
        '
        Me.whiteAo100.AutoSize = True
        Me.whiteAo100.Location = New System.Drawing.Point(402, 104)
        Me.whiteAo100.Name = "whiteAo100"
        Me.whiteAo100.Size = New System.Drawing.Size(34, 13)
        Me.whiteAo100.TabIndex = 13
        Me.whiteAo100.Text = "00.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(331, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Ao100:"
        '
        'whiteAo5
        '
        Me.whiteAo5.AutoSize = True
        Me.whiteAo5.Location = New System.Drawing.Point(402, 91)
        Me.whiteAo5.Name = "whiteAo5"
        Me.whiteAo5.Size = New System.Drawing.Size(34, 13)
        Me.whiteAo5.TabIndex = 11
        Me.whiteAo5.Text = "00.00"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(331, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Ao5:"
        '
        'whiteBest
        '
        Me.whiteBest.AutoSize = True
        Me.whiteBest.Location = New System.Drawing.Point(402, 67)
        Me.whiteBest.Name = "whiteBest"
        Me.whiteBest.Size = New System.Drawing.Size(34, 13)
        Me.whiteBest.TabIndex = 9
        Me.whiteBest.Text = "00.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(331, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Best: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(331, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "TotalSolves: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(331, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "SolvesToday:"
        '
        'whiteToday
        '
        Me.whiteToday.AutoSize = True
        Me.whiteToday.Location = New System.Drawing.Point(402, 52)
        Me.whiteToday.Name = "whiteToday"
        Me.whiteToday.Size = New System.Drawing.Size(13, 13)
        Me.whiteToday.TabIndex = 18
        Me.whiteToday.Text = "0"
        '
        'whiteTotal
        '
        Me.whiteTotal.AutoSize = True
        Me.whiteTotal.Location = New System.Drawing.Point(402, 39)
        Me.whiteTotal.Name = "whiteTotal"
        Me.whiteTotal.Size = New System.Drawing.Size(13, 13)
        Me.whiteTotal.TabIndex = 19
        Me.whiteTotal.Text = "0"
        '
        'yellowTotal
        '
        Me.yellowTotal.AutoSize = True
        Me.yellowTotal.Location = New System.Drawing.Point(402, 156)
        Me.yellowTotal.Name = "yellowTotal"
        Me.yellowTotal.Size = New System.Drawing.Size(13, 13)
        Me.yellowTotal.TabIndex = 31
        Me.yellowTotal.Text = "0"
        '
        'yellowToday
        '
        Me.yellowToday.AutoSize = True
        Me.yellowToday.Location = New System.Drawing.Point(402, 169)
        Me.yellowToday.Name = "yellowToday"
        Me.yellowToday.Size = New System.Drawing.Size(13, 13)
        Me.yellowToday.TabIndex = 30
        Me.yellowToday.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(331, 169)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "SolvesToday:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(331, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 28
        Me.Label14.Text = "TotalSolves: "
        '
        'yellowWorst
        '
        Me.yellowWorst.AutoSize = True
        Me.yellowWorst.Location = New System.Drawing.Point(402, 196)
        Me.yellowWorst.Name = "yellowWorst"
        Me.yellowWorst.Size = New System.Drawing.Size(34, 13)
        Me.yellowWorst.TabIndex = 27
        Me.yellowWorst.Text = "00.00"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(331, 196)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "Worst: "
        '
        'yellowAo100
        '
        Me.yellowAo100.AutoSize = True
        Me.yellowAo100.Location = New System.Drawing.Point(402, 221)
        Me.yellowAo100.Name = "yellowAo100"
        Me.yellowAo100.Size = New System.Drawing.Size(34, 13)
        Me.yellowAo100.TabIndex = 25
        Me.yellowAo100.Text = "00.00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(331, 221)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Ao100:"
        '
        'yellowAo5
        '
        Me.yellowAo5.AutoSize = True
        Me.yellowAo5.Location = New System.Drawing.Point(402, 208)
        Me.yellowAo5.Name = "yellowAo5"
        Me.yellowAo5.Size = New System.Drawing.Size(34, 13)
        Me.yellowAo5.TabIndex = 23
        Me.yellowAo5.Text = "00.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(331, 208)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(29, 13)
        Me.Label20.TabIndex = 22
        Me.Label20.Text = "Ao5:"
        '
        'yellowBest
        '
        Me.yellowBest.AutoSize = True
        Me.yellowBest.Location = New System.Drawing.Point(402, 184)
        Me.yellowBest.Name = "yellowBest"
        Me.yellowBest.Size = New System.Drawing.Size(34, 13)
        Me.yellowBest.TabIndex = 21
        Me.yellowBest.Text = "00.00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(331, 184)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(34, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Best: "
        '
        'redTotal
        '
        Me.redTotal.AutoSize = True
        Me.redTotal.Location = New System.Drawing.Point(551, 156)
        Me.redTotal.Name = "redTotal"
        Me.redTotal.Size = New System.Drawing.Size(13, 13)
        Me.redTotal.TabIndex = 43
        Me.redTotal.Text = "0"
        '
        'redToday
        '
        Me.redToday.AutoSize = True
        Me.redToday.Location = New System.Drawing.Point(551, 169)
        Me.redToday.Name = "redToday"
        Me.redToday.Size = New System.Drawing.Size(13, 13)
        Me.redToday.TabIndex = 42
        Me.redToday.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(480, 169)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "SolvesToday:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(480, 156)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 13)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "TotalSolves: "
        '
        'redWorst
        '
        Me.redWorst.AutoSize = True
        Me.redWorst.Location = New System.Drawing.Point(551, 196)
        Me.redWorst.Name = "redWorst"
        Me.redWorst.Size = New System.Drawing.Size(34, 13)
        Me.redWorst.TabIndex = 39
        Me.redWorst.Text = "00.00"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(480, 196)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Worst: "
        '
        'redAo100
        '
        Me.redAo100.AutoSize = True
        Me.redAo100.Location = New System.Drawing.Point(551, 221)
        Me.redAo100.Name = "redAo100"
        Me.redAo100.Size = New System.Drawing.Size(34, 13)
        Me.redAo100.TabIndex = 37
        Me.redAo100.Text = "00.00"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(480, 221)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(41, 13)
        Me.Label24.TabIndex = 36
        Me.Label24.Text = "Ao100:"
        '
        'redAo5
        '
        Me.redAo5.AutoSize = True
        Me.redAo5.Location = New System.Drawing.Point(551, 208)
        Me.redAo5.Name = "redAo5"
        Me.redAo5.Size = New System.Drawing.Size(34, 13)
        Me.redAo5.TabIndex = 35
        Me.redAo5.Text = "00.00"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(480, 208)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(29, 13)
        Me.Label26.TabIndex = 34
        Me.Label26.Text = "Ao5:"
        '
        'redBest
        '
        Me.redBest.AutoSize = True
        Me.redBest.Location = New System.Drawing.Point(551, 184)
        Me.redBest.Name = "redBest"
        Me.redBest.Size = New System.Drawing.Size(34, 13)
        Me.redBest.TabIndex = 33
        Me.redBest.Text = "00.00"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(480, 184)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(34, 13)
        Me.Label28.TabIndex = 32
        Me.Label28.Text = "Best: "
        '
        'greenTotal
        '
        Me.greenTotal.AutoSize = True
        Me.greenTotal.Location = New System.Drawing.Point(708, 153)
        Me.greenTotal.Name = "greenTotal"
        Me.greenTotal.Size = New System.Drawing.Size(13, 13)
        Me.greenTotal.TabIndex = 55
        Me.greenTotal.Text = "0"
        '
        'greenToday
        '
        Me.greenToday.AutoSize = True
        Me.greenToday.Location = New System.Drawing.Point(708, 166)
        Me.greenToday.Name = "greenToday"
        Me.greenToday.Size = New System.Drawing.Size(13, 13)
        Me.greenToday.TabIndex = 54
        Me.greenToday.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(637, 166)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 13)
        Me.Label19.TabIndex = 53
        Me.Label19.Text = "SolvesToday:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(637, 153)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(69, 13)
        Me.Label23.TabIndex = 52
        Me.Label23.Text = "TotalSolves: "
        '
        'greenWorst
        '
        Me.greenWorst.AutoSize = True
        Me.greenWorst.Location = New System.Drawing.Point(708, 193)
        Me.greenWorst.Name = "greenWorst"
        Me.greenWorst.Size = New System.Drawing.Size(34, 13)
        Me.greenWorst.TabIndex = 51
        Me.greenWorst.Text = "00.00"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(637, 193)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(41, 13)
        Me.Label27.TabIndex = 50
        Me.Label27.Text = "Worst: "
        '
        'greenAo100
        '
        Me.greenAo100.AutoSize = True
        Me.greenAo100.Location = New System.Drawing.Point(708, 218)
        Me.greenAo100.Name = "greenAo100"
        Me.greenAo100.Size = New System.Drawing.Size(34, 13)
        Me.greenAo100.TabIndex = 49
        Me.greenAo100.Text = "00.00"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(637, 218)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(41, 13)
        Me.Label30.TabIndex = 48
        Me.Label30.Text = "Ao100:"
        '
        'greenAo5
        '
        Me.greenAo5.AutoSize = True
        Me.greenAo5.Location = New System.Drawing.Point(708, 205)
        Me.greenAo5.Name = "greenAo5"
        Me.greenAo5.Size = New System.Drawing.Size(34, 13)
        Me.greenAo5.TabIndex = 47
        Me.greenAo5.Text = "00.00"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(637, 205)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(29, 13)
        Me.Label32.TabIndex = 46
        Me.Label32.Text = "Ao5:"
        '
        'greenBest
        '
        Me.greenBest.AutoSize = True
        Me.greenBest.Location = New System.Drawing.Point(708, 181)
        Me.greenBest.Name = "greenBest"
        Me.greenBest.Size = New System.Drawing.Size(34, 13)
        Me.greenBest.TabIndex = 45
        Me.greenBest.Text = "00.00"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(637, 181)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(34, 13)
        Me.Label34.TabIndex = 44
        Me.Label34.Text = "Best: "
        '
        'orangeTotal
        '
        Me.orangeTotal.AutoSize = True
        Me.orangeTotal.Location = New System.Drawing.Point(551, 37)
        Me.orangeTotal.Name = "orangeTotal"
        Me.orangeTotal.Size = New System.Drawing.Size(13, 13)
        Me.orangeTotal.TabIndex = 67
        Me.orangeTotal.Text = "0"
        '
        'orangeToday
        '
        Me.orangeToday.AutoSize = True
        Me.orangeToday.Location = New System.Drawing.Point(551, 50)
        Me.orangeToday.Name = "orangeToday"
        Me.orangeToday.Size = New System.Drawing.Size(13, 13)
        Me.orangeToday.TabIndex = 66
        Me.orangeToday.Text = "0"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(480, 50)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 13)
        Me.Label25.TabIndex = 65
        Me.Label25.Text = "SolvesToday:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(480, 37)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(69, 13)
        Me.Label29.TabIndex = 64
        Me.Label29.Text = "TotalSolves: "
        '
        'orangeWorst
        '
        Me.orangeWorst.AutoSize = True
        Me.orangeWorst.Location = New System.Drawing.Point(551, 77)
        Me.orangeWorst.Name = "orangeWorst"
        Me.orangeWorst.Size = New System.Drawing.Size(34, 13)
        Me.orangeWorst.TabIndex = 63
        Me.orangeWorst.Text = "00.00"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(480, 77)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(41, 13)
        Me.Label33.TabIndex = 62
        Me.Label33.Text = "Worst: "
        '
        'orangeAo100
        '
        Me.orangeAo100.AutoSize = True
        Me.orangeAo100.Location = New System.Drawing.Point(551, 102)
        Me.orangeAo100.Name = "orangeAo100"
        Me.orangeAo100.Size = New System.Drawing.Size(34, 13)
        Me.orangeAo100.TabIndex = 61
        Me.orangeAo100.Text = "00.00"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(480, 102)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(41, 13)
        Me.Label36.TabIndex = 60
        Me.Label36.Text = "Ao100:"
        '
        'orangeAo5
        '
        Me.orangeAo5.AutoSize = True
        Me.orangeAo5.Location = New System.Drawing.Point(551, 89)
        Me.orangeAo5.Name = "orangeAo5"
        Me.orangeAo5.Size = New System.Drawing.Size(34, 13)
        Me.orangeAo5.TabIndex = 59
        Me.orangeAo5.Text = "00.00"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(480, 89)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(29, 13)
        Me.Label38.TabIndex = 58
        Me.Label38.Text = "Ao5:"
        '
        'orangeBest
        '
        Me.orangeBest.AutoSize = True
        Me.orangeBest.Location = New System.Drawing.Point(551, 65)
        Me.orangeBest.Name = "orangeBest"
        Me.orangeBest.Size = New System.Drawing.Size(34, 13)
        Me.orangeBest.TabIndex = 57
        Me.orangeBest.Text = "00.00"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(480, 65)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(34, 13)
        Me.Label40.TabIndex = 56
        Me.Label40.Text = "Best: "
        '
        'blueTotal
        '
        Me.blueTotal.AutoSize = True
        Me.blueTotal.Location = New System.Drawing.Point(708, 37)
        Me.blueTotal.Name = "blueTotal"
        Me.blueTotal.Size = New System.Drawing.Size(13, 13)
        Me.blueTotal.TabIndex = 79
        Me.blueTotal.Text = "0"
        '
        'blueToday
        '
        Me.blueToday.AutoSize = True
        Me.blueToday.Location = New System.Drawing.Point(708, 50)
        Me.blueToday.Name = "blueToday"
        Me.blueToday.Size = New System.Drawing.Size(13, 13)
        Me.blueToday.TabIndex = 78
        Me.blueToday.Text = "0"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(637, 50)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 13)
        Me.Label31.TabIndex = 77
        Me.Label31.Text = "SolvesToday:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(637, 37)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(69, 13)
        Me.Label35.TabIndex = 76
        Me.Label35.Text = "TotalSolves: "
        '
        'blueWorst
        '
        Me.blueWorst.AutoSize = True
        Me.blueWorst.Location = New System.Drawing.Point(708, 77)
        Me.blueWorst.Name = "blueWorst"
        Me.blueWorst.Size = New System.Drawing.Size(34, 13)
        Me.blueWorst.TabIndex = 75
        Me.blueWorst.Text = "00.00"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(637, 77)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(41, 13)
        Me.Label39.TabIndex = 74
        Me.Label39.Text = "Worst: "
        '
        'blueAo100
        '
        Me.blueAo100.AutoSize = True
        Me.blueAo100.Location = New System.Drawing.Point(708, 102)
        Me.blueAo100.Name = "blueAo100"
        Me.blueAo100.Size = New System.Drawing.Size(34, 13)
        Me.blueAo100.TabIndex = 73
        Me.blueAo100.Text = "00.00"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(637, 102)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(41, 13)
        Me.Label42.TabIndex = 72
        Me.Label42.Text = "Ao100:"
        '
        'blueAo5
        '
        Me.blueAo5.AutoSize = True
        Me.blueAo5.Location = New System.Drawing.Point(708, 89)
        Me.blueAo5.Name = "blueAo5"
        Me.blueAo5.Size = New System.Drawing.Size(34, 13)
        Me.blueAo5.TabIndex = 71
        Me.blueAo5.Text = "00.00"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(637, 89)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(29, 13)
        Me.Label44.TabIndex = 70
        Me.Label44.Text = "Ao5:"
        '
        'blueBest
        '
        Me.blueBest.AutoSize = True
        Me.blueBest.Location = New System.Drawing.Point(708, 65)
        Me.blueBest.Name = "blueBest"
        Me.blueBest.Size = New System.Drawing.Size(34, 13)
        Me.blueBest.TabIndex = 69
        Me.blueBest.Text = "00.00"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(637, 65)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(34, 13)
        Me.Label46.TabIndex = 68
        Me.Label46.Text = "Best: "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.allsolvesPlotPG)
        Me.TabControl1.Controls.Add(Me.recentsolvesDataPG)
        Me.TabControl1.Location = New System.Drawing.Point(334, 254)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(457, 264)
        Me.TabControl1.TabIndex = 80
        '
        'allsolvesPlotPG
        '
        Me.allsolvesPlotPG.Controls.Add(Me.totalAvgChart)
        Me.allsolvesPlotPG.Location = New System.Drawing.Point(4, 22)
        Me.allsolvesPlotPG.Name = "allsolvesPlotPG"
        Me.allsolvesPlotPG.Padding = New System.Windows.Forms.Padding(3)
        Me.allsolvesPlotPG.Size = New System.Drawing.Size(449, 238)
        Me.allsolvesPlotPG.TabIndex = 0
        Me.allsolvesPlotPG.Text = "Plot-AllSolves"
        Me.allsolvesPlotPG.UseVisualStyleBackColor = True
        '
        'recentsolvesDataPG
        '
        Me.recentsolvesDataPG.Controls.Add(Me.recentSolvesDataGrid)
        Me.recentsolvesDataPG.Location = New System.Drawing.Point(4, 22)
        Me.recentsolvesDataPG.Name = "recentsolvesDataPG"
        Me.recentsolvesDataPG.Padding = New System.Windows.Forms.Padding(3)
        Me.recentsolvesDataPG.Size = New System.Drawing.Size(449, 238)
        Me.recentsolvesDataPG.TabIndex = 1
        Me.recentsolvesDataPG.Text = "Data-RecentSolves"
        Me.recentsolvesDataPG.UseVisualStyleBackColor = True
        '
        'recentSolvesDataGrid
        '
        Me.recentSolvesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.recentSolvesDataGrid.Location = New System.Drawing.Point(6, 6)
        Me.recentSolvesDataGrid.Name = "recentSolvesDataGrid"
        Me.recentSolvesDataGrid.Size = New System.Drawing.Size(440, 226)
        Me.recentSolvesDataGrid.TabIndex = 0
        '
        'recentSolves_Strip
        '
        Me.recentSolves_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateStartColorToolStripMenuItem, Me.DeleteSolveToolStripMenuItem})
        Me.recentSolves_Strip.Name = "recentSolves_Strip"
        Me.recentSolves_Strip.Size = New System.Drawing.Size(172, 48)
        '
        'UpdateStartColorToolStripMenuItem
        '
        Me.UpdateStartColorToolStripMenuItem.Name = "UpdateStartColorToolStripMenuItem"
        Me.UpdateStartColorToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.UpdateStartColorToolStripMenuItem.Text = "Update Start Color"
        '
        'DeleteSolveToolStripMenuItem
        '
        Me.DeleteSolveToolStripMenuItem.Name = "DeleteSolveToolStripMenuItem"
        Me.DeleteSolveToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.DeleteSolveToolStripMenuItem.Text = "Delete Solve"
        '
        'scrambleLabel
        '
        Me.scrambleLabel.AutoSize = True
        Me.scrambleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scrambleLabel.Location = New System.Drawing.Point(24, 18)
        Me.scrambleLabel.Name = "scrambleLabel"
        Me.scrambleLabel.Size = New System.Drawing.Size(51, 13)
        Me.scrambleLabel.TabIndex = 81
        Me.scrambleLabel.Text = "Scramble"
        '
        'scrambleButton
        '
        Me.scrambleButton.BackColor = System.Drawing.SystemColors.Control
        Me.scrambleButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.scrambleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.scrambleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.scrambleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scrambleButton.Location = New System.Drawing.Point(70, 212)
        Me.scrambleButton.Name = "scrambleButton"
        Me.scrambleButton.Size = New System.Drawing.Size(81, 29)
        Me.scrambleButton.TabIndex = 82
        Me.scrambleButton.Text = "Scramble"
        Me.scrambleButton.UseVisualStyleBackColor = False
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.SpeedSolvePage)
        Me.TabControl2.Controls.Add(Me.PLLPage)
        Me.TabControl2.Location = New System.Drawing.Point(12, 12)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(812, 562)
        Me.TabControl2.TabIndex = 83
        '
        'SpeedSolvePage
        '
        Me.SpeedSolvePage.Controls.Add(Me.scrambleLabel)
        Me.SpeedSolvePage.Controls.Add(Me.scrambleButton)
        Me.SpeedSolvePage.Controls.Add(Me.timerLabel)
        Me.SpeedSolvePage.Controls.Add(Me.timerButton)
        Me.SpeedSolvePage.Controls.Add(Me.GroupBox1)
        Me.SpeedSolvePage.Controls.Add(Me.TabControl1)
        Me.SpeedSolvePage.Controls.Add(Me.Label12)
        Me.SpeedSolvePage.Controls.Add(Me.blueTotal)
        Me.SpeedSolvePage.Controls.Add(Me.whiteCB)
        Me.SpeedSolvePage.Controls.Add(Me.blueToday)
        Me.SpeedSolvePage.Controls.Add(Me.whiteBest)
        Me.SpeedSolvePage.Controls.Add(Me.Label31)
        Me.SpeedSolvePage.Controls.Add(Me.greenCB)
        Me.SpeedSolvePage.Controls.Add(Me.Label35)
        Me.SpeedSolvePage.Controls.Add(Me.Label10)
        Me.SpeedSolvePage.Controls.Add(Me.blueWorst)
        Me.SpeedSolvePage.Controls.Add(Me.yellowCB)
        Me.SpeedSolvePage.Controls.Add(Me.Label39)
        Me.SpeedSolvePage.Controls.Add(Me.whiteAo5)
        Me.SpeedSolvePage.Controls.Add(Me.blueAo100)
        Me.SpeedSolvePage.Controls.Add(Me.orangeCB)
        Me.SpeedSolvePage.Controls.Add(Me.Label42)
        Me.SpeedSolvePage.Controls.Add(Me.Label8)
        Me.SpeedSolvePage.Controls.Add(Me.blueAo5)
        Me.SpeedSolvePage.Controls.Add(Me.blueCB)
        Me.SpeedSolvePage.Controls.Add(Me.Label44)
        Me.SpeedSolvePage.Controls.Add(Me.whiteAo100)
        Me.SpeedSolvePage.Controls.Add(Me.blueBest)
        Me.SpeedSolvePage.Controls.Add(Me.redCB)
        Me.SpeedSolvePage.Controls.Add(Me.Label46)
        Me.SpeedSolvePage.Controls.Add(Me.Label6)
        Me.SpeedSolvePage.Controls.Add(Me.orangeTotal)
        Me.SpeedSolvePage.Controls.Add(Me.whiteWorst)
        Me.SpeedSolvePage.Controls.Add(Me.orangeToday)
        Me.SpeedSolvePage.Controls.Add(Me.Label3)
        Me.SpeedSolvePage.Controls.Add(Me.Label25)
        Me.SpeedSolvePage.Controls.Add(Me.Label7)
        Me.SpeedSolvePage.Controls.Add(Me.Label29)
        Me.SpeedSolvePage.Controls.Add(Me.whiteToday)
        Me.SpeedSolvePage.Controls.Add(Me.orangeWorst)
        Me.SpeedSolvePage.Controls.Add(Me.whiteTotal)
        Me.SpeedSolvePage.Controls.Add(Me.Label33)
        Me.SpeedSolvePage.Controls.Add(Me.Label22)
        Me.SpeedSolvePage.Controls.Add(Me.orangeAo100)
        Me.SpeedSolvePage.Controls.Add(Me.yellowBest)
        Me.SpeedSolvePage.Controls.Add(Me.Label36)
        Me.SpeedSolvePage.Controls.Add(Me.Label20)
        Me.SpeedSolvePage.Controls.Add(Me.orangeAo5)
        Me.SpeedSolvePage.Controls.Add(Me.yellowAo5)
        Me.SpeedSolvePage.Controls.Add(Me.Label38)
        Me.SpeedSolvePage.Controls.Add(Me.Label18)
        Me.SpeedSolvePage.Controls.Add(Me.orangeBest)
        Me.SpeedSolvePage.Controls.Add(Me.yellowAo100)
        Me.SpeedSolvePage.Controls.Add(Me.Label40)
        Me.SpeedSolvePage.Controls.Add(Me.Label16)
        Me.SpeedSolvePage.Controls.Add(Me.greenTotal)
        Me.SpeedSolvePage.Controls.Add(Me.yellowWorst)
        Me.SpeedSolvePage.Controls.Add(Me.greenToday)
        Me.SpeedSolvePage.Controls.Add(Me.Label14)
        Me.SpeedSolvePage.Controls.Add(Me.Label19)
        Me.SpeedSolvePage.Controls.Add(Me.Label13)
        Me.SpeedSolvePage.Controls.Add(Me.Label23)
        Me.SpeedSolvePage.Controls.Add(Me.yellowToday)
        Me.SpeedSolvePage.Controls.Add(Me.greenWorst)
        Me.SpeedSolvePage.Controls.Add(Me.yellowTotal)
        Me.SpeedSolvePage.Controls.Add(Me.Label27)
        Me.SpeedSolvePage.Controls.Add(Me.Label28)
        Me.SpeedSolvePage.Controls.Add(Me.greenAo100)
        Me.SpeedSolvePage.Controls.Add(Me.redBest)
        Me.SpeedSolvePage.Controls.Add(Me.Label30)
        Me.SpeedSolvePage.Controls.Add(Me.Label26)
        Me.SpeedSolvePage.Controls.Add(Me.greenAo5)
        Me.SpeedSolvePage.Controls.Add(Me.redAo5)
        Me.SpeedSolvePage.Controls.Add(Me.Label32)
        Me.SpeedSolvePage.Controls.Add(Me.Label24)
        Me.SpeedSolvePage.Controls.Add(Me.greenBest)
        Me.SpeedSolvePage.Controls.Add(Me.redAo100)
        Me.SpeedSolvePage.Controls.Add(Me.Label34)
        Me.SpeedSolvePage.Controls.Add(Me.Label21)
        Me.SpeedSolvePage.Controls.Add(Me.redTotal)
        Me.SpeedSolvePage.Controls.Add(Me.redWorst)
        Me.SpeedSolvePage.Controls.Add(Me.redToday)
        Me.SpeedSolvePage.Controls.Add(Me.Label17)
        Me.SpeedSolvePage.Controls.Add(Me.Label15)
        Me.SpeedSolvePage.Location = New System.Drawing.Point(4, 22)
        Me.SpeedSolvePage.Name = "SpeedSolvePage"
        Me.SpeedSolvePage.Padding = New System.Windows.Forms.Padding(3)
        Me.SpeedSolvePage.Size = New System.Drawing.Size(804, 536)
        Me.SpeedSolvePage.TabIndex = 0
        Me.SpeedSolvePage.Text = "Speed Solve"
        Me.SpeedSolvePage.UseVisualStyleBackColor = True
        '
        'PLLPage
        '
        Me.PLLPage.Controls.Add(Me.TabControl3)
        Me.PLLPage.Controls.Add(Me.PLLScramble)
        Me.PLLPage.Controls.Add(Me.PLLScrambleButton)
        Me.PLLPage.Controls.Add(Me.PLLTimerLabel)
        Me.PLLPage.Controls.Add(Me.PLLTimerButton)
        Me.PLLPage.Controls.Add(Me.PLLAlg)
        Me.PLLPage.Controls.Add(Me.PLLPicture)
        Me.PLLPage.Controls.Add(Me.Label9)
        Me.PLLPage.Controls.Add(Me.PLLList)
        Me.PLLPage.Location = New System.Drawing.Point(4, 22)
        Me.PLLPage.Name = "PLLPage"
        Me.PLLPage.Padding = New System.Windows.Forms.Padding(3)
        Me.PLLPage.Size = New System.Drawing.Size(804, 536)
        Me.PLLPage.TabIndex = 1
        Me.PLLPage.Text = "PLL Practice"
        Me.PLLPage.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage1)
        Me.TabControl3.Controls.Add(Me.TabPage2)
        Me.TabControl3.Location = New System.Drawing.Point(334, 254)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(457, 264)
        Me.TabControl3.TabIndex = 88
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Chart1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(449, 238)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Plot-AllSolves"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(6, 17)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series3.Legend = "Legend1"
        Series3.Name = "AllTimes"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "HalfTimes"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Series.Add(Series4)
        Me.Chart1.Size = New System.Drawing.Size(436, 195)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(449, 238)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data-RecentSolves"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(440, 226)
        Me.DataGridView1.TabIndex = 0
        '
        'PLLScramble
        '
        Me.PLLScramble.AutoSize = True
        Me.PLLScramble.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLLScramble.Location = New System.Drawing.Point(18, 17)
        Me.PLLScramble.Name = "PLLScramble"
        Me.PLLScramble.Size = New System.Drawing.Size(67, 17)
        Me.PLLScramble.TabIndex = 86
        Me.PLLScramble.Text = "Scramble"
        '
        'PLLScrambleButton
        '
        Me.PLLScrambleButton.BackColor = System.Drawing.SystemColors.Control
        Me.PLLScrambleButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.PLLScrambleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.PLLScrambleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.PLLScrambleButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLLScrambleButton.Location = New System.Drawing.Point(70, 212)
        Me.PLLScrambleButton.Name = "PLLScrambleButton"
        Me.PLLScrambleButton.Size = New System.Drawing.Size(81, 29)
        Me.PLLScrambleButton.TabIndex = 85
        Me.PLLScrambleButton.Text = "Scramble"
        Me.PLLScrambleButton.UseVisualStyleBackColor = False
        '
        'PLLTimerLabel
        '
        Me.PLLTimerLabel.AutoSize = True
        Me.PLLTimerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLLTimerLabel.Location = New System.Drawing.Point(23, 39)
        Me.PLLTimerLabel.Name = "PLLTimerLabel"
        Me.PLLTimerLabel.Size = New System.Drawing.Size(200, 76)
        Me.PLLTimerLabel.TabIndex = 83
        Me.PLLTimerLabel.Text = "00.00"
        '
        'PLLTimerButton
        '
        Me.PLLTimerButton.BackColor = System.Drawing.Color.Yellow
        Me.PLLTimerButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow
        Me.PLLTimerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.PLLTimerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow
        Me.PLLTimerButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PLLTimerButton.Location = New System.Drawing.Point(36, 123)
        Me.PLLTimerButton.Name = "PLLTimerButton"
        Me.PLLTimerButton.Size = New System.Drawing.Size(158, 83)
        Me.PLLTimerButton.TabIndex = 84
        Me.PLLTimerButton.Text = "Ready!"
        Me.PLLTimerButton.UseVisualStyleBackColor = False
        '
        'PLLAlg
        '
        Me.PLLAlg.AutoSize = True
        Me.PLLAlg.Location = New System.Drawing.Point(479, 161)
        Me.PLLAlg.Name = "PLLAlg"
        Me.PLLAlg.Size = New System.Drawing.Size(41, 13)
        Me.PLLAlg.TabIndex = 3
        Me.PLLAlg.Text = "PLLAlg"
        '
        'PLLPicture
        '
        Me.PLLPicture.Location = New System.Drawing.Point(482, 46)
        Me.PLLPicture.Name = "PLLPicture"
        Me.PLLPicture.Size = New System.Drawing.Size(136, 97)
        Me.PLLPicture.TabIndex = 2
        Me.PLLPicture.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(226, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "PLLs:"
        '
        'PLLList
        '
        Me.PLLList.FormattingEnabled = True
        Me.PLLList.Items.AddRange(New Object() {"All", "A (a)", "A (b)", "E", "F", "G (a)", "G (b)", "G (c)", "G (d)", "H", "J (a)", "J (b)", "N (a)", "N (b)", "R (a)", "R (b)", "T", "U (a)", "U (b)", "V", "Y", "Z"})
        Me.PLLList.Location = New System.Drawing.Point(229, 62)
        Me.PLLList.Name = "PLLList"
        Me.PLLList.Size = New System.Drawing.Size(80, 334)
        Me.PLLList.TabIndex = 0
        '
        'PLLImageList
        '
        Me.PLLImageList.ImageStream = CType(resources.GetObject("PLLImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.PLLImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.PLLImageList.Images.SetKeyName(0, "Aa.gif")
        Me.PLLImageList.Images.SetKeyName(1, "Ab.gif")
        Me.PLLImageList.Images.SetKeyName(2, "E.gif")
        Me.PLLImageList.Images.SetKeyName(3, "F.gif")
        Me.PLLImageList.Images.SetKeyName(4, "Ga.gif")
        Me.PLLImageList.Images.SetKeyName(5, "Gb.gif")
        Me.PLLImageList.Images.SetKeyName(6, "Gc.gif")
        Me.PLLImageList.Images.SetKeyName(7, "Gd.gif")
        Me.PLLImageList.Images.SetKeyName(8, "H.gif")
        Me.PLLImageList.Images.SetKeyName(9, "Ja.gif")
        Me.PLLImageList.Images.SetKeyName(10, "Jb.gif")
        Me.PLLImageList.Images.SetKeyName(11, "Na.gif")
        Me.PLLImageList.Images.SetKeyName(12, "Nb.gif")
        Me.PLLImageList.Images.SetKeyName(13, "Ra.gif")
        Me.PLLImageList.Images.SetKeyName(14, "Rb.gif")
        Me.PLLImageList.Images.SetKeyName(15, "T.gif")
        Me.PLLImageList.Images.SetKeyName(16, "Ua.gif")
        Me.PLLImageList.Images.SetKeyName(17, "Ub.gif")
        Me.PLLImageList.Images.SetKeyName(18, "V.gif")
        Me.PLLImageList.Images.SetKeyName(19, "Y.gif")
        Me.PLLImageList.Images.SetKeyName(20, "Z.gif")
        '
        'UpdateAlgStrip
        '
        Me.UpdateAlgStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAlgorithmToolStripMenuItem})
        Me.UpdateAlgStrip.Name = "UpdateAlgStrip"
        Me.UpdateAlgStrip.Size = New System.Drawing.Size(154, 26)
        '
        'AddAlgorithmToolStripMenuItem
        '
        Me.AddAlgorithmToolStripMenuItem.Name = "AddAlgorithmToolStripMenuItem"
        Me.AddAlgorithmToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AddAlgorithmToolStripMenuItem.Text = "Add Algorithm"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(827, 578)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "mainForm"
        Me.Text = "SpeedTimer"
        CType(Me.totalAvgChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.allsolvesPlotPG.ResumeLayout(False)
        Me.recentsolvesDataPG.ResumeLayout(False)
        CType(Me.recentSolvesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.recentSolves_Strip.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.SpeedSolvePage.ResumeLayout(False)
        Me.SpeedSolvePage.PerformLayout()
        Me.PLLPage.ResumeLayout(False)
        Me.PLLPage.PerformLayout()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PLLPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UpdateAlgStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

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
    Friend WithEvents whiteCB As CheckBox
    Friend WithEvents greenCB As CheckBox
    Friend WithEvents yellowCB As CheckBox
    Friend WithEvents redCB As CheckBox
    Friend WithEvents blueCB As CheckBox
    Friend WithEvents orangeCB As CheckBox
    Friend WithEvents whiteWorst As Label
    Friend WithEvents whiteAo100 As Label
    Friend WithEvents whiteAo5 As Label
    Friend WithEvents whiteBest As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents whiteToday As Label
    Friend WithEvents whiteTotal As Label
    Friend WithEvents yellowTotal As Label
    Friend WithEvents yellowToday As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents yellowWorst As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents yellowAo100 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents yellowAo5 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents yellowBest As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents redTotal As Label
    Friend WithEvents redToday As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents redWorst As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents redAo100 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents redAo5 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents redBest As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents greenTotal As Label
    Friend WithEvents greenToday As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents greenWorst As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents greenAo100 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents greenAo5 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents greenBest As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents orangeTotal As Label
    Friend WithEvents orangeToday As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents orangeWorst As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents orangeAo100 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents orangeAo5 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents orangeBest As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents blueTotal As Label
    Friend WithEvents blueToday As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents blueWorst As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents blueAo100 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents blueAo5 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents blueBest As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents allsolvesPlotPG As TabPage
    Friend WithEvents recentsolvesDataPG As TabPage
    Friend WithEvents recentSolvesDataGrid As DataGridView
    Friend WithEvents recentSolves_Strip As ContextMenuStrip
    Friend WithEvents UpdateStartColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteSolveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents scrambleLabel As Label
    Friend WithEvents scrambleButton As Button
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents SpeedSolvePage As TabPage
    Friend WithEvents PLLPage As TabPage
    Friend WithEvents PLLList As CheckedListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PLLImageList As ImageList
    Friend WithEvents PLLPicture As PictureBox
    Friend WithEvents UpdateAlgStrip As ContextMenuStrip
    Friend WithEvents AddAlgorithmToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PLLAlg As Label
    Friend WithEvents PLLScrambleButton As Button
    Friend WithEvents PLLTimerLabel As Label
    Friend WithEvents PLLTimerButton As Button
    Friend WithEvents PLLScramble As Label
    Friend WithEvents TabControl3 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
End Class
