Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim number As Double
        Dim subtotal As Double = 0
        Dim total As Double = 0

        Double.TryParse(txtNop.Text, number)

        If (rbMember.Checked = True) Then
            If (rbWeekday.Checked = True) Then
                subtotal = 35 * number
                total = subtotal + (subtotal * 0.0875) + 20
            End If
        End If

        If (rbMember.Checked = True) Then
            If (rbWeekened.Checked = True) Then
                subtotal = 50 * number
                total = subtotal + (subtotal * 0.0875) + 20
            End If
        End If
        If (rbNonmember.Checked = True) Then
            If (rbWeekday.Checked = True) Then
                subtotal = 50 * number
                total = subtotal + (subtotal * 0.0875) + 20
            End If
            If (rbWeekened.Checked = True) Then
                subtotal = 75 * number
                total = subtotal + (subtotal * 0.0875) + 20
            End If

        End If

        txtsubtotal.Text = FormatCurrency(subtotal)
        txttotal.Text = FormatCurrency(total)

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNop.Clear()
        txtsubtotal.Clear()
        txttotal.Clear()
        rbMember.Checked = False
        rbNonmember.Checked = False
        rbWeekday.Checked = False
        rbWeekened.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
