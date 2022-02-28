Public Class Form1
    Dim intArea, intLength, intHeight, intWidth, intRadius As Integer
    Const dblPI = 3.14159265359
    Dim strTitle As String
    Private Sub btntrianglearea_Click(sender As Object, e As EventArgs) Handles btntrianglearea.Click
        Dim intBase As Integer
        Try
            intBase = txtbaseprompt.Text
            intHeight = txtheightprompt.Text
            intArea = ((intBase * intHeight) / 2)
            strTitle = "Area of a Triangle"
            MessageBox.Show("The area of a triangle is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Your Input is Invalid", strTitle)
        End Try
    End Sub
    Private Sub btnrectanglearea_Click(sender As Object, e As EventArgs) Handles btnrectanglearea.Click
        Try
            intLength = txtlengthprompt.Text
            intWidth = txtwidthprompt.Text
            intArea = (intLength * intWidth)
            strTitle = "Area of a Rectangle"
            MessageBox.Show("The area of a rectangle is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Your Input is Invalid", strTitle)
        End Try
    End Sub
    Private Sub btnformulas_Click(sender As Object, e As EventArgs) Handles btnformulas.Click
        Dim AreaRect, AreaCirc, AreaTriangle As String
        AreaRect = "A = L * W"
        AreaCirc = "A = π * r^2"
        AreaTriangle = "A = (b * h) / 2"
        strTitle = "Area Formulas"
        MessageBox.Show("Rectangle: " & AreaRect & vbCrLf & "Triangle: " & AreaTriangle & vbCrLf & "Circle: " & AreaCirc, strTitle)
    End Sub
    Private Sub btnothershapes_Click(sender As Object, e As EventArgs) Handles btnothershapes.Click
        OtherShapes.Show()
    End Sub

    Private Sub btnsurfacearea_Click(sender As Object, e As EventArgs) Handles btnsurfacearea.Click
        SurfaceArea.Show()
    End Sub

    Private Sub btninfo_Click(sender As Object, e As EventArgs) Handles btninfo.Click
        strTitle = "Information About This Application"
        MessageBox.Show("The area for each shape is automatically rounded up or down.", strTitle)
    End Sub
    Private Sub btncirclearea_Click(sender As Object, e As EventArgs) Handles btncirclearea.Click
        Try
            intRadius = txtradiusprompt.Text
            intArea = (dblPI * (intRadius) ^ 2)
            strTitle = "Area: Circle"
            MessageBox.Show("The area of a circle is " & intArea, strTitle)
        Catch ex As Exception
            strTitle = "Error"
            MessageBox.Show("Your Input is Invalid", strTitle)
        End Try
    End Sub
End Class