Public Class SurfaceArea
    Dim intArea, intLength, intHeight, intWidth, intRadius As Integer
    Const dblPI = 3.14159265359
    Dim strTitle As String
    Private Sub btnsurfaceareacylinder_Click(sender As Object, e As EventArgs) Handles btnsurfaceareacylinder.Click
        Try
            intRadius = txtradiusprompt.Text
            intArea = ((2 * dblPI * intRadius * intHeight) + (2 * dblPI * (intRadius) ^ 2))
            strTitle = "Surface Area: Cylinder"
            MessageBox.Show("The surface area of a cylinder is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Your Input is Invalid", strTitle)
        End Try
    End Sub
    Private Sub btnformulas_Click(sender As Object, e As EventArgs) Handles btnformulas.Click
        Dim saCylinder, saRectPrism, saSphere As String
        saCylinder = "A = 2πrh + 2πr^2"
        saRectPrism = "A = 2(wl + hl + hw)"
        saSphere = "A = (b * h) / 2"
        strTitle = "Surface Area Formulas"
        MessageBox.Show("Cylinder: " & saCylinder & vbCrLf & "Rectangular Prism: " & saRectPrism & vbCrLf & "Sphere: " & saSphere, strTitle)
    End Sub

    Private Sub btnpyramid_Click(sender As Object, e As EventArgs) Handles btnpyramid.Click
        Pyramid.Show()
    End Sub
    Private Sub btnsurfacearearectprism_Click(sender As Object, e As EventArgs) Handles btnsurfacearearectprism.Click
        Try
            intLength = txtlengthprompt.Text
            intWidth = txtwidthprompt.Text
            intHeight = txtheightprompt.Text
            intArea = (2 * ((intWidth * intLength) + (intHeight * intLength) + (intHeight * intWidth)))
            strTitle = "Surface Area: Rectangular Prism"
            MessageBox.Show("The surface area of a Rectangular Prism is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Your Input is Invalid", strTitle)
        End Try
    End Sub
    Private Sub btncube_Click(sender As Object, e As EventArgs) Handles btncube.Click
        Cube.Show()
    End Sub
    Private Sub btnsurfaceareacone_Click(sender As Object, e As EventArgs) Handles btncone.Click
        Cone.Show()
    End Sub
    Private Sub btnsurfaceareasphere_Click(sender As Object, e As EventArgs) Handles btnsurfaceareasphere.Click
        Try
            intRadius = txtradiusprompt.Text
            intArea = (4 * (dblPI * (intRadius) ^ 2))
            strTitle = "Surface Area: Sphere"
            MessageBox.Show("The surface area of a sphere is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Your Input is Invalid", strTitle)
        End Try
    End Sub
End Class