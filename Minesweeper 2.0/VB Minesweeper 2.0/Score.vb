Public Class Score

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label2.Text = My.Settings.Btime
        Label7.Text = My.Settings.Itime
        Label10.Text = My.Settings.Etime
        Label13.Text = My.Settings.Mtime
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.first = True
        Label2.Text = 0
        Label7.Text = 0
        Label10.Text = 0
        Label13.Text = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class