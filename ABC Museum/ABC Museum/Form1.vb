Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age, price As Double

        Dim s As String

        s = InputBox("Enter the visitor Age", "Visitor Age")

        Double.TryParse(s, age)

        txtAge.Text = age


        If (age >= 62) Then
            price = 10
        End If
        If (age < 62 And age >= 15) Then
            price = 20
        End If
        If (age <= 14 And age >= 3) Then
            price = 14
        End If
        If (age >= 0 And age < 3) Then
            price = 0
        End If
        If (age < 0) Then
            MessageBox.Show("Wrong Age Value", "Error")
        End If
        MessageBox.Show("The tickets price is $" & price,
            "Ticket Price", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        txtPrice.Text = price.ToString("C2")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtAge.Clear()
        txtPrice.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
