Public Class Custom

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles t1.TextChanged
        Try
            If t1.Text = "" Then
                t1.Text = 9
            ElseIf t1.Text < 9 Then
                t1.Text = 9
            ElseIf t1.Text > 24 Then
                t1.Text = 24
            End If
        Catch ex As Exception
            t1.Text = 9
        End Try
    End Sub

    Private Sub t2_TextChanged(sender As Object, e As EventArgs) Handles t2.TextChanged
        Try
            If t2.Text = "" Then
                t2.Text = 9
            ElseIf t2.Text < 9 Then
                t2.Text = 9
            ElseIf t2.Text > 30 Then
                t2.Text = 30
            End If
        Catch ex As Exception
            t2.Text = 9
        End Try
    End Sub

    Private Sub t3_TextChanged(sender As Object, e As EventArgs) Handles t3.TextChanged
        Try
            If t3.Text = "" Then
                t3.Text = 10
            ElseIf t3.Text < 11 Then
                t3.Text = 10
            ElseIf t3.Text > Val(maxmines.Text) Then
                t3.Text = Val(maxmines.Text)
            End If
        Catch ex As Exception
            t3.Text = 10
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.rows = t1.Text
        My.Settings.cols = t2.Text
        My.Settings.mines = t3.Text
        My.Settings.custom = True
        Me.Close()
    End Sub

    Private Sub Custom_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        My.Settings.custom = True
        Timer1.Stop()
    End Sub

    Private Sub Custom_Load(sender As Object, e As EventArgs) Handles Me.Load
        t1.Text = My.Settings.rows
        t2.Text = My.Settings.cols
        t3.Text = My.Settings.mines
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        maxmines.Text = (Val(t1.Text) * Val(t2.Text)) - 10
        If Val(maxmines.Text) > 150 Then
            maxmines.Text = 150
        End If
        If t3.Text > Val(maxmines.Text) Then
            t3.Text = Val(maxmines.Text)
        End If
    End Sub
End Class
