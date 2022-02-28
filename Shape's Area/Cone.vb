Public Class Cone
    Dim intHeight, intRadius, intArea As Integer
    Const dblPI = 3.14159265359
    Dim strTitle As String
    Private Sub btnlateral_Click(sender As Object, e As EventArgs) Handles btnlateral.Click

        Try
            intRadius = txtradiusprompt.Text
            intHeight = txtheightprompt.Text
            intArea = (dblPI * intRadius * Math.Sqrt(((intRadius) ^ 2) + ((intHeight) ^ 2)))
            strTitle = "Lateral Surface Area"
            MessageBox.Show("The lateral surface area of a cone is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Invalid Input", strTitle)
        End Try
    End Sub

    Private Sub btnbasesurfacearea_Click(sender As Object, e As EventArgs) Handles btnbasesurfacearea.Click
        Try
            intRadius = txtradiusprompt.Text
            intArea = (dblPI * intRadius ^ 2)
            strTitle = "Base Surface Area"
            MessageBox.Show("The base surface area of a cone is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Invalid Input", strTitle)
        End Try
    End Sub

    Private Sub btntotalsurfacearea_Click(sender As Object, e As EventArgs) Handles btntotalsurfacearea.Click
        Try
            intRadius = txtradiusprompt.Text
            intHeight = txtheightprompt.Text
            intArea = (dblPI * intRadius * (intRadius + Math.Sqrt(intRadius ^ 2 + intHeight ^ 2)))
            strTitle = "Total Surface Area"
            MessageBox.Show("The total surface area of a cone is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Invalid Input", strTitle)
        End Try
    End Sub

    Private Sub btnformulas_Click(sender As Object, e As EventArgs) Handles btnformulas.Click
        Dim strLateral, strBaseSurface, strTotalSurface As String
        strLateral = "A = πr * sqrt(r^2 + h^2)"
        strBaseSurface = "A = πr√(r^2 + h^2)"
        strTotalSurface = "A = πr(r + √(r^2 + h^2))"
        strTitle = "Cone Surface Area Formulas"
        MessageBox.Show("Lateral Surface Area: " & strLateral & vbCrLf & "Base Surface Area: " & strBaseSurface & vbCrLf & "Total Surface Area" & strTotalSurface, strTitle)
    End Sub
End Class