Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim June, July, August, Total, Average As Double

        Double.TryParse(txtJune.Text, June)
        Double.TryParse(txtJuly.Text, July)
        Double.TryParse(txtAugust.Text, August)


        Total = June + July + August
        Average = Total / 3

        txtTotal.Text = Total.ToString
        txtAverage.Text = Average.ToString

        If (Average > 1500) Then
            MessageBox.Show("Expenses are too high !", "Expenses Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        Else
            MessageBox.Show("Expenses are normal !", "Expenses Application", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtJune.Clear()
        txtJuly.Clear()
        txtAugust.Clear()
        txtTotal.Clear()
        txtAverage.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
