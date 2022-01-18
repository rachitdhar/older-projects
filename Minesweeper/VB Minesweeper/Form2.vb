Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label5.Text = 0
        Label6.Text = 0
        Label7.Text = 0
        My.Settings.tot = 0
        My.Settings.win = 0
        My.Settings.lose = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label5.Text = My.Settings.tot
        Label6.Text = My.Settings.win
        Label7.Text = My.Settings.lose
    End Sub
End Class