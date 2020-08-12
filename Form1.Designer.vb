<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbtSimple = New System.Windows.Forms.RadioButton()
        Me.rbtCompunded = New System.Windows.Forms.RadioButton()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblResultA = New System.Windows.Forms.Label()
        Me.lblResultB = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SimpleInterestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.spnTime = New System.Windows.Forms.NumericUpDown()
        Me.cmdClearPA = New System.Windows.Forms.Button()
        Me.cmdClearIR = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chtGraph = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.cmdReset = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.spnTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chtGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCalculate
        '
        Me.cmdCalculate.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmdCalculate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalculate.ForeColor = System.Drawing.Color.Black
        Me.cmdCalculate.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdCalculate.Location = New System.Drawing.Point(100, 371)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(129, 36)
        Me.cmdCalculate.TabIndex = 8
        Me.cmdCalculate.Text = "Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Principal Amount ($)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 181)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Interest Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(95, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Time (years)"
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(173, 175)
        Me.txtRate.MaxLength = 3
        Me.txtRate.Multiline = True
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(56, 25)
        Me.txtRate.TabIndex = 2
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrincipal.Location = New System.Drawing.Point(175, 111)
        Me.txtPrincipal.Multiline = True
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(164, 25)
        Me.txtPrincipal.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(382, 286)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 1
        '
        'rbtSimple
        '
        Me.rbtSimple.AutoSize = True
        Me.rbtSimple.Checked = True
        Me.rbtSimple.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtSimple.Location = New System.Drawing.Point(175, 304)
        Me.rbtSimple.Name = "rbtSimple"
        Me.rbtSimple.Size = New System.Drawing.Size(63, 18)
        Me.rbtSimple.TabIndex = 4
        Me.rbtSimple.TabStop = True
        Me.rbtSimple.Text = "Simple"
        Me.rbtSimple.UseVisualStyleBackColor = True
        '
        'rbtCompunded
        '
        Me.rbtCompunded.AutoSize = True
        Me.rbtCompunded.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCompunded.Location = New System.Drawing.Point(175, 327)
        Me.rbtCompunded.Name = "rbtCompunded"
        Me.rbtCompunded.Size = New System.Drawing.Size(97, 18)
        Me.rbtCompunded.TabIndex = 5
        Me.rbtCompunded.TabStop = True
        Me.rbtCompunded.Text = "Compounded"
        Me.rbtCompunded.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmdExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.Black
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdExit.Location = New System.Drawing.Point(370, 371)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(129, 36)
        Me.cmdExit.TabIndex = 10
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'lblResultA
        '
        Me.lblResultA.AutoSize = True
        Me.lblResultA.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultA.Location = New System.Drawing.Point(12, 466)
        Me.lblResultA.Name = "lblResultA"
        Me.lblResultA.Size = New System.Drawing.Size(29, 15)
        Me.lblResultA.TabIndex = 13
        Me.lblResultA.Text = "lblA"
        '
        'lblResultB
        '
        Me.lblResultB.AutoSize = True
        Me.lblResultB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultB.Location = New System.Drawing.Point(12, 499)
        Me.lblResultB.Name = "lblResultB"
        Me.lblResultB.Size = New System.Drawing.Size(29, 15)
        Me.lblResultB.TabIndex = 13
        Me.lblResultB.Text = "lblB"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(237, 180)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(13, 11)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimpleInterestToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1223, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SimpleInterestToolStripMenuItem
        '
        Me.SimpleInterestToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.CreditsToolStripMenuItem1, Me.QuitToolStripMenuItem})
        Me.SimpleInterestToolStripMenuItem.Name = "SimpleInterestToolStripMenuItem"
        Me.SimpleInterestToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.SimpleInterestToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'CreditsToolStripMenuItem1
        '
        Me.CreditsToolStripMenuItem1.Name = "CreditsToolStripMenuItem1"
        Me.CreditsToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.CreditsToolStripMenuItem1.Text = "Credits"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'spnTime
        '
        Me.spnTime.Location = New System.Drawing.Point(175, 247)
        Me.spnTime.Name = "spnTime"
        Me.spnTime.Size = New System.Drawing.Size(120, 20)
        Me.spnTime.TabIndex = 3
        '
        'cmdClearPA
        '
        Me.cmdClearPA.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearPA.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdClearPA.Location = New System.Drawing.Point(353, 112)
        Me.cmdClearPA.Name = "cmdClearPA"
        Me.cmdClearPA.Size = New System.Drawing.Size(47, 25)
        Me.cmdClearPA.TabIndex = 6
        Me.cmdClearPA.Text = "Clear"
        Me.cmdClearPA.UseVisualStyleBackColor = True
        '
        'cmdClearIR
        '
        Me.cmdClearIR.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearIR.Location = New System.Drawing.Point(353, 175)
        Me.cmdClearIR.Name = "cmdClearIR"
        Me.cmdClearIR.Size = New System.Drawing.Size(47, 25)
        Me.cmdClearIR.TabIndex = 7
        Me.cmdClearIR.Text = "Clear"
        Me.cmdClearIR.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(487, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 14)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Interest ($)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(860, 447)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 14)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Years"
        '
        'chtGraph
        '
        ChartArea1.Name = "ChartArea1"
        Me.chtGraph.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chtGraph.Legends.Add(Legend1)
        Me.chtGraph.Location = New System.Drawing.Point(571, 55)
        Me.chtGraph.Name = "chtGraph"
        Me.chtGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chtGraph.Series.Add(Series1)
        Me.chtGraph.Size = New System.Drawing.Size(627, 375)
        Me.chtGraph.TabIndex = 17
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(560, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(651, 399)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'cmdReset
        '
        Me.cmdReset.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmdReset.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.ForeColor = System.Drawing.Color.Black
        Me.cmdReset.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdReset.Location = New System.Drawing.Point(235, 371)
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(129, 36)
        Me.cmdReset.TabIndex = 9
        Me.cmdReset.Text = "Reset"
        Me.cmdReset.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1223, 542)
        Me.Controls.Add(Me.cmdReset)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdClearIR)
        Me.Controls.Add(Me.cmdClearPA)
        Me.Controls.Add(Me.spnTime)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.rbtCompunded)
        Me.Controls.Add(Me.rbtSimple)
        Me.Controls.Add(Me.lblResultB)
        Me.Controls.Add(Me.lblResultA)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdCalculate)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.chtGraph)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Interest Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.spnTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chtGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rbtSimple As RadioButton
    Friend WithEvents rbtCompunded As RadioButton
    Friend WithEvents cmdExit As Button
    Friend WithEvents lblResultA As Label
    Friend WithEvents lblResultB As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SimpleInterestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents spnTime As NumericUpDown
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmdClearPA As Button
    Friend WithEvents cmdClearIR As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chtGraph As DataVisualization.Charting.Chart
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmdReset As Button
End Class
