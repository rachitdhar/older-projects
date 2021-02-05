Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label2.Text = My.Settings.time
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.first = True
        Label2.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
