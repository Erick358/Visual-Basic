Public Class Form1
    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        myList.Items.Add(txtItem.Text)
        myList.SelectedIndex = myList.SelectedIndex + 1
        txtItem.Clear()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        myList.Items.Clear()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        IO.Directory.CreateDirectory("C:\OUTPUT")
        Dim w As New IO.StreamWriter("C:\OUTPUT\mylist.txt")
        Dim i As Integer
        For i = 0 To myList.Items.Count - 1
            w.WriteLine(myList.Items(i))
        Next
        w.Close()
        MessageBox.Show("Your list elements has been saved successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnretrieve.Click
        Dim r As New IO.StreamReader("C:\OUTPUT\mylist.txt")
        While (r.Peek() > -1)
            myList.Items.Add(r.ReadLine)
        End While
        r.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myList.Items.Remove(myList.SelectedItem)
    End Sub
End Class
