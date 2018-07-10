Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        txtResult.Text = Val(txtNumber1.Text) + Val(txtNumber2.Text)
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        txtResult.Text = Val(txtNumber1.Text) - Val(txtNumber2.Text)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        txtResult.Text = Val(txtNumber1.Text) * Val(txtNumber2.Text)
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        txtResult.Text = Val(txtNumber1.Text) / Val(txtNumber2.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtNumber1.Clear()
        txtNumber2.Clear()
        txtResult.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
