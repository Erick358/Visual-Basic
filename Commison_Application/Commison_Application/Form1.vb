Public Class Form1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Const COMM_RATE As Double = 0.05
        Dim sales As Double
        Dim commission As Double
        Dim s As String

        'Getting the Sales from the user using an InputBox
        s = InputBox("Enter the Sales Amount", "Sales")

        Double.TryParse(s, sales)

        ' Start of the loop, stop when a negative sales is 
        Do
            commission = sales * COMM_RATE
            MessageBox.Show(commission.ToString("C2"), "Commission",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            s = InputBox("Enter the sales Amount", "Sales")
            Double.TryParse(s, sales)

        Loop Until sales <= 0


    End Sub
End Class
