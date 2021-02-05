Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label4.Text = My.Settings.tot
        Label5.Text = My.Settings.won
        Label6.Text = My.Settings.lost
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = 0
        Label5.Text = 0
        Label6.Text = 0
        My.Settings.tot = 0
        My.Settings.won = 0
        My.Settings.lost = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
