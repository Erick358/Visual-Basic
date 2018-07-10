Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtExam1.Clear()
        txtExam3.Clear()
        txtAverage.Clear()
        txtFinal.Clear()
        txtMidterm.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim exam1, exam3, final, midterm As Double

        Double.TryParse(txtExam1.Text, exam1)
        Double.TryParse(txtExam3.Text, exam3)
        Double.TryParse(txtFinal.Text, final)
        Double.TryParse(txtMidterm.Text, midterm)

        txtAverage.Text = exam1 + exam3 + final + midterm / 4


    End Sub
End Class
