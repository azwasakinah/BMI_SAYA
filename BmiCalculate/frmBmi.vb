Public Class frmBmi
    Private Function BMI(Height As Single, weight As Single) As Double
        BMI = weight / Height ^ 2
    End Function

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        Dim h As Single, w As Single
        h = Val(TextBox1.Text)
        w = Val(TextBox2.Text)
        lblBmi.Text = BMI(h, w)
    End Sub
End Class
