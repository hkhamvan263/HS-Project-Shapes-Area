Public Class Form2
    Dim strTitle As String
    Private Sub btntrapezoidarea_Click(sender As Object, e As EventArgs) Handles btntrapezoidarea.Click
        Dim intBaseA, intBaseB, intHeight, intArea As Integer
        Try
            intBaseA = txtbaseaprompt.Text
            intBaseB = txtbasebprompt.Text
            intHeight = txtheightprompt.Text
            intArea = (((intBaseA + intBaseB) / 2) * intHeight)
            strTitle = "Area: Trapezoid"
            MessageBox.Show("The area of a trapezoid is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Your Input is Invalid", strTitle)
        End Try
    End Sub
    Private Sub btnformula_Click(sender As Object, e As EventArgs) Handles btnformula.Click
        strTitle = "Trapezoid Area Formula"
        MessageBox.Show("Trapezoid: ((a + b) / 2) * h", strTitle)
    End Sub
End Class