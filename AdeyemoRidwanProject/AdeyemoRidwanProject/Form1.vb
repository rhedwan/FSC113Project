Public Class QuadraticEquation
    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim valueX1 As Double
        Dim valueX2 As Double
        Dim det As Double

        a = valueA.Text
        b = valueB.Text
        c = valueC.Text
        det = (b ^ 2) - (4 * a * c)
        Select Case det
            Case Is > 0
                valueX1 = (-b + Math.Sqrt(det)) / (2 * a)
                valueX2 = (-b - Math.Sqrt(det)) / (2 * a)
                MsgBox("Value X1 is " & valueX1)
                MsgBox("Value X2 is " & valueX2)
            Case Is = 0
                valueX1 = (-b) / (2 * a)
                MsgBox("Value X1 is " & valueX1)
                MsgBox("Value X2 is " & valueX1)
            Case Else
                Dim real As Double
                Dim imaginary As Double
                real = -b / (2 * a)
                imaginary = Math.Sqrt(-det) / (2 * a)
                MsgBox("Value X1 is " & real & -imaginary & "i")
                MsgBox("Value X2 is " & real & "+" & imaginary & "i")
        End Select
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        valueA.Text = ""
        valueB.Text = ""
        valueC.Text = ""
    End Sub

    'This sub ensure the Text Box Accept Numbers Only
   
End Class
