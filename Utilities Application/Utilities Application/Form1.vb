Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtGas.Clear()
        txtElectricity.Clear()
        txtInternet.Clear()
        txtAverage.Clear()
        txtTotal.Clear()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Variable Declarations'
        Dim gas, electricity, internet, total, average As Double
        'Reading the inputs from the textboxes and convert them to double
        Double.TryParse(txtGas.Text, gas)
        Double.TryParse(txtElectricity.Text, electricity)
        Double.TryParse(txtInternet.Text, internet)

        'calculate the total and the average
        total = gas + electricity + internet
        average = total / 3

        ' display the total and the average
        txtTotal.Text = FormatCurrency(total)
        txtAverage.Text = FormatCurrency(average)

    End Sub
End Class
