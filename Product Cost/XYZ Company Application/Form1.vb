Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim price, quantity, total, discount As Double
        total = 0
        discount = 0

        Double.TryParse(txtPrice.Text, price)
        Double.TryParse(txtQuantity.Text, quantity)

        If (quantity <= 10) Then
            discount = 0
            total = price * quantity - discount
        End If
        If (quantity > 10 And quantity <= 20) Then
            discount = price * quantity * 0.1
            total = price * quantity - discount
        End If
        If (quantity > 20) Then
            discount = price * quantity * 0.2
            total = price * quantity - discount
        End If

        txtTotal.Text = FormatCurrency(total)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtPrice.Clear()
        txtQuantity.Clear()
        txtTotal.Clear()

    End Sub
End Class
