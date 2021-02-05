Public Class levelscr1

    Dim time As Integer = 0

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        time += 1
        If time > 2 Then
            Level1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub levelscr1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label4.Text = My.Settings.lives
        Timer1.Enabled = True
    End Sub
End Class
