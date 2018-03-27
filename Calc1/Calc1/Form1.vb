Public Class Form1
    Dim operater_on As Boolean = False
    Dim operater As String = ""
    Dim val1, val2 As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler btn0.Click, AddressOf buttonClick
        AddHandler btn1.Click, AddressOf buttonClick
        AddHandler btn2.Click, AddressOf buttonClick
        AddHandler btn3.Click, AddressOf buttonClick
        AddHandler btn4.Click, AddressOf buttonClick
        AddHandler btn5.Click, AddressOf buttonClick
        AddHandler btn6.Click, AddressOf buttonClick
        AddHandler btn7.Click, AddressOf buttonClick
        AddHandler btn8.Click, AddressOf buttonClick
        AddHandler btn9.Click, AddressOf buttonClick
    End Sub
    Private Sub buttonClick(sender As Object, e As EventArgs)

        Dim btn As Button = DirectCast(sender, System.Windows.Forms.Button)
        If lblDisplay.Text = "0" Or operater_on = True Then
            lblDisplay.Text = btn.Text
            operater_on = False
        Else
            lblDisplay.Text = lblDisplay.Text & btn.Text
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        operater_on = True
        operater = "+"
        val1 = Val(lblDisplay.Text)
    End Sub


    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        operater_on = True
        operater = "-"
        val1 = Val(lblDisplay.Text)
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        val2 = Val(lblDisplay.Text)
        If operater = "+" Then
            lblDisplay.Text = val1 + val2
        ElseIf operater = "-"
            lblDisplay.Text = val1 - val2
        Else
            lblDisplay.Text = lblDisplay.Text
        End If
        operater = ""
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        lblDisplay.Text = "0"
        operater_on = False
        operater = ""
    End Sub
End Class
