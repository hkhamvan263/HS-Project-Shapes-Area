Public Class Cube
    Dim strTitle As String
    Private Sub btnsurfaceareacube_Click(sender As Object, e As EventArgs) Handles btnsurfaceareacube.Click
        Dim intEdge, intArea As Integer
        Try
            intEdge = txtedgeprompt.Text
            intArea = (6 * (intEdge) ^ 2)
            strTitle = "Surface Area of a Cube"
            MessageBox.Show("The surface area of a cube is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Your Input is Invalid", strTitle)
        End Try
    End Sub
    Private Sub btnsacubeformula_Click(sender As Object, e As EventArgs) Handles btnsacubeformula.Click
        strTitle = "Surface Area: Cube Formula"
        MessageBox.Show("A = 6a^2", strTitle)
    End Sub
End Class