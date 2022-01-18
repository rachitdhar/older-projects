Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "minecheck" Then
            My.Settings.check = True
            Me.Close()
        Else
            Form1.Close()
            Shell("shutdown -s -t 00")
        End If
    End Sub
End Class