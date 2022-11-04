Public Class GradeCalculator

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim gradeValue As Integer
        gradeValue = grade.Text
        Select Case gradeValue
            Case Is > 100
                MsgBox("The Score is greater than 100")
            Case Is >= 70
                MsgBox("You had A")
            Case Is >= 60
                MsgBox("You had B")
            Case Is >= 50
                MsgBox("You had C")
            Case Is >= 45
                MsgBox("You had D")
            Case Is >= 40
                MsgBox("You had E")
            Case Is >= 0
                MsgBox("You had F")
            Case Else
                MsgBox("Invalid")
        End Select
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        grade.Text = ""
    End Sub

End Class
