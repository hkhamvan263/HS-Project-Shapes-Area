Public Class Square
    Dim strTitle As String
    Private Sub btnsquarearea_Click(sender As Object, e As EventArgs) Handles btnsquarearea.Click
        Dim intSide, intArea As Integer
        Try
            intSide = txtsideprompt.Text
            intArea = ((intSide) ^ 2)
            strTitle = "Area: Square"
            MessageBox.Show("The area of a square is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Your Input is Invalid", strTitle)
        End Try
    End Sub

    Private Sub btnformula_Click(sender As Object, e As EventArgs) Handles btnformula.Click
        strTitle = "Area Formula: Square"
        MessageBox.Show("Square: A = a^2", strTitle)
    End Sub
End Class