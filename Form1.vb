Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click

        Dim dInterest As Double
        Dim dPrinciple, dRate As Double
        Dim dTime As Integer



        'Call pValidate
        If pValidate(bThumbsUp:=False) Then Exit Sub



        'Make sure fields are populated

        dPrinciple = Me.txtPrincipal.Text
        dRate = Me.txtRate.Text
        dTime = Me.spnTime.Text

        'See if the user wants simple of compounded interest. Let's see which radio button is selected.
        If Me.rbtSimple.Checked = True Then
            'Simple Interest

            dInterest = ((dPrinciple * (dRate / 100)) * dTime)
            Me.lblResultA.Text = "At the interest rate of " + dRate.ToString + "%, over the duration of " + dTime.ToString + " years, the total simple interest is $" + dInterest.ToString + "."
            Me.lblResultB.Text = "Therefore the total principal amount with simple interest is $" + (dInterest + dPrinciple).ToString + "."


        Else
        End If
        'Componded Interest
        If Me.rbtCompunded.Checked = True Then
            dInterest = dPrinciple * (1 + dRate / 100) ^ (dTime) - dPrinciple
            Me.lblResultA.Text = "At the interest rate of " + dRate.ToString + "%, over the duration of " + dTime.ToString + " years, the total compounded interest is $" + dInterest.ToString + "."
            Me.lblResultB.Text = "Therefore the total principal amount with compounded interest is $" + (dInterest + dPrinciple).ToString + "."



        End If



        'Show the graph
        pShowGraph()



    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Reset all
        pResetAll()

        'Clear the display labels A & B
        Me.lblResultA.Text = ""
        Me.lblResultB.Text = ""

        'Load the years in the combo box
        Dim iItem As Integer
        For iItem = 1 To 50



        Next iItem

        chtGraph.ChartAreas(0).AxisY.LabelStyle.Format = "$#,###,###"

    End Sub
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        'Exit button in order to exit application
        End
    End Sub

    Private Sub txtPrincipal_TextChanged(sender As Object, e As EventArgs) Handles txtPrincipal.TextChanged
        If Me.txtPrincipal.Text = "" Then Exit Sub
        txtPrincipal.Text = CDbl(txtPrincipal.Text).ToString("N")
        txtPrincipal.SelectionStart = txtPrincipal.Text.IndexOf(".")

    End Sub


    Private Sub CreditsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CreditsToolStripMenuItem1.Click
        MessageBox.Show("This calculator was designed and built by Zain")
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Zain - A student currently taking Computer Science! This is his final project")
    End Sub

    Private Sub SimpleInterestToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPrincipal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrincipal.KeyPress

        e.Handled = Not Char.IsDigit(e.KeyChar)

    End Sub


    Private Sub cmdClearPA_Click(sender As Object, e As EventArgs) Handles cmdClearPA.Click
        Me.txtPrincipal.Clear()
        Me.txtPrincipal.Focus()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdClearIR.Click
        Me.txtRate.Clear()
        Me.txtRate.Focus()
    End Sub
    Private Sub txtRate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRate.KeyPress
        e.Handled = Not Char.IsDigit(e.KeyChar)
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("Simple interest is money you can earn by initially investing some money (the principal). A percentage (the interest) of the principal is added to the principal, making your initial investment grow!")
    End Sub
    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged

    End Sub
    Private Function pShowGraph()
        Dim dInterest As Double
        Dim dPrinciple, dRate As Double
        Dim dTime As Integer
        Dim dValue As Double

        'Before doing anything, reset the grpah to 0,0
        Me.chtGraph.Series.Clear()
        Me.chtGraph.Series.Add("Series1")

        dPrinciple = Me.txtPrincipal.Text
        dRate = Me.txtRate.Text
        dTime = Me.spnTime.Text

        'See if the user wants simple of compounded interest. Let's see which radio button is selected.
        If Me.rbtSimple.Checked = True Then
            'Simple Interest

            dInterest = ((dPrinciple * (dRate / 100)) * dTime)
            dValue = (dPrinciple + (dInterest / dTime))
            For i = 1 To dTime

                chtGraph.Series("Series1").Points.AddXY(i, dValue)

                dValue = dValue + (dInterest / dTime)
            Next i

        Else
            'Compounded Interest
            dInterest = dPrinciple * (1 + dRate / 100) ^ (dTime) - dPrinciple
            dValue = (dPrinciple + (dInterest / dTime))
            For i = 1 To dTime

                chtGraph.Series("Series1").Points.AddXY(i, dValue)

                dValue = dValue + (dInterest / dTime)
            Next i
        End If

    End Function
    Private Function pValidate(bThumbsUp As Boolean)
        'Validate all inputs are present and proper

        If Me.txtPrincipal.Text = "" Then
            MsgBox("Principal amount cannot be blank. Please enter an amount.", MsgBoxStyle.Information)
            Me.txtPrincipal.Focus()
            Return bThumbsUp = False
        End If
        If Me.txtRate.Text = "" Then
            MsgBox("Interest rate cannot be blank. Please enter an amount.", MsgBoxStyle.Information)
            Me.txtRate.Focus()
            Return bThumbsUp = False
        End If
        If Me.txtRate.Text > 100 Then
            MsgBox("Interest rate cannot exceed 100 percent.", MsgBoxStyle.Information)
            Me.txtRate.Focus()
            Return bThumbsUp = False
        End If
        If Me.spnTime.Text = "0" Then
            MsgBox("Time cannot be blank. Please enter an amount.", MsgBoxStyle.Information)
            Me.spnTime.Focus()
            Return bThumbsUp = False
        End If
        If Me.spnTime.Text = "" Then
            MsgBox("Time cannot be blank. Please enter an amount.", MsgBoxStyle.Information)
            Me.spnTime.Focus()
            Return bThumbsUp = False
        End If
        Return bThumbsUp = True

    End Function

    Private Sub cmdReset_Click(sender As Object, e As EventArgs) Handles cmdReset.Click
        pResetAll()
    End Sub
    Private Sub pResetAll()
        Me.txtPrincipal.ResetText()
        Me.txtRate.ResetText()
        Me.spnTime.ResetText()
        Me.chtGraph.Series.Clear()
        Me.lblResultA.Text = ""
        Me.lblResultB.Text = ""
        Me.txtPrincipal.Focus()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub

    Private Sub rbtCompunded_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCompunded.CheckedChanged

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub
End Class

