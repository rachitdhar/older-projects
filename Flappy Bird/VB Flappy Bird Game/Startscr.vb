Public Class Startscr

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Game.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        levelscr1.Show()
        If Me.Label7.Text < 1 Then
            Me.Label7.Text = 1
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Bonus.Show()
    End Sub

    Private Sub Startscr_Load(sender As Object, e As EventArgs) Handles Me.Load
        My.Settings.lives = 3
    End Sub
End Class