Public Class Form1
  Private Sub btntrianglearea_Click(sender As Object, e As EventArgs) Handles btntrianglearea.Click
    Dim intBase, intHeight, intArea As Integer
    intBase = txtbaseprompt.Text
    intHeight = txtheightprompt.Text
    intArea = (0.5 * intBase * intHeight)
    MessageBox.Show("The area of a triangle is " & intArea)
  End Sub

  Private Sub btnrectanglearea_Click(sender As Object, e As EventArgs) Handles btnrectanglearea.Click
    Dim intLength, intWidth, intArea As Integer
    intLength = txtlengthprompt.Text
    intWidth = txtwidthprompt.Text
    intArea = (intLength * intWidth)
    MessageBox.Show("The area of a rectangle is " & intArea)
  End Sub
End Class
