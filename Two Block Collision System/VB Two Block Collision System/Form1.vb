Public Class Form1

    Dim v1 As Double = 0
    Dim v2 As Double = 5
    Dim m As Double = 1

    Private Sub startbtn_Click(sender As Object, e As EventArgs) Handles startbtn.Click
        m = Val(mass.Text)
        v2 = Val(bgspeed.Text)
        Timer1.Start()
    End Sub

    Private Sub stopbtn_Click(sender As Object, e As EventArgs) Handles stopbtn.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        smBox.Left -= v1
        bgBox.Left -= v2

        If smBox.Bounds.IntersectsWith(bgBox.Bounds) Then
            Dim speed1 As Double = ((1 - m) * v1 + 2 * m * v2) / (1 + m)
            Dim speed2 As Double = (v1 + m * v2 - speed1) / m

            v1 = speed1
            v2 = speed2

            collisions.Text = Val(collisions.Text) + 1
        End If

        If smBox.Bounds.IntersectsWith(wall.Bounds) Then
            v1 = -v1
            collisions.Text = Val(collisions.Text) + 1
        End If
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        smBox.Left = 200
        bgBox.Left = 400
        v1 = 0
        v2 = 5
        collisions.Text = 0
    End Sub
End Class