Public Class Form1

    Dim xSpeed As Short = 0
    Dim ySpeed As Short = 0
    Dim Start As Boolean = True

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ball.Top < 24 Then
            Dim check As Integer = 0
            For Each ctrl As Control In Me.Controls
                If ctrl.Name = "Brick" Then
                    check += 1
                End If
            Next
            If check = 0 Then
                Timer1.Stop()
                MsgBox("You Win!", MsgBoxStyle.OkOnly, "Brick Breaker")
                My.Settings.tot += 1
                My.Settings.won += 1
            Else
                ySpeed = -ySpeed
            End If
            check = 0
        End If
        If ball.Left < 0 Then
            xSpeed = -xSpeed
        End If
        If ball.Right > Me.ClientRectangle.Width Then
            xSpeed = -xSpeed
        End If
        If ball.Bottom > Me.ClientRectangle.Height Then
            Timer1.Stop()
            MsgBox("Game Over!", MsgBoxStyle.OkOnly, "Brick Breaker")
            My.Settings.lost += 1
            My.Settings.tot += 1
        End If
        Dim ball_center As Single = ball.Left + ball.Width / 2
        Dim bat_center As Single = bat.Left + bat.Width / 2
        If ball_center > bat.Left And ball_center < bat.Right And ySpeed > 0 And ball.Bottom > bat.Top And ball.Top < bat.Bottom Then
            ySpeed = -ySpeed
            Dim off As Single = ball_center - bat_center
            Dim distant As Single = off / (bat.Width / 2)
            xSpeed += 5 * distant
        End If
        For Each ctrl As Control In Me.Controls
            If ctrl.Name = "Brick" Then
                If collision(ctrl, ball) = True Then
                    If ctrl.BackColor = Color.Red Then
                        ctrl.Visible = False
                    ElseIf ctrl.BackColor = Color.Firebrick Then
                        ctrl.BackColor = Color.Red
                    ElseIf ctrl.BackColor = Color.Maroon Then
                        ctrl.BackColor = Color.Firebrick
                    ElseIf ctrl.BackColor = Color.Gray Then
                        ctrl.BackColor = Color.Maroon
                    ElseIf ctrl.BackColor = Color.LightGray Then
                        ctrl.BackColor = Color.Gray
                    End If
                End If
            End If
        Next
        ball.Left += xSpeed
        ball.Top += ySpeed
    End Sub

    Private Function collision(Brick As Button, Ball As Button)
        Dim collided As Boolean = False
        Dim ball_center As Single = Ball.Left + Ball.Width / 2
        Dim brick_center As Single = Brick.Left + Brick.Width / 2
        If Brick.Visible = True Then
            If ball_center > Brick.Left And ySpeed > 0 And ball_center < Brick.Right And Ball.Bottom > Brick.Top And Ball.Top < Brick.Top Then
                ySpeed = -ySpeed
                Dim off As Single = ball_center - brick_center
                Dim distant As Single = off / (Brick.Width / 2)
                xSpeed += 5 * distant
                collided = True
            End If
            If ball_center > Brick.Left And ySpeed < 0 And ball_center < Brick.Right And Ball.Top < Brick.Bottom And Ball.Bottom > Brick.Bottom Then
                ySpeed = -ySpeed
                Dim off As Single = ball_center - brick_center
                Dim distant As Single = off / (Brick.Width / 2)
                xSpeed += 5 * distant
                collided = True
            End If
            ball_center = Ball.Top + Ball.Height / 2
            brick_center = Brick.Top + Brick.Height / 2
            If ball_center > Brick.Top And xSpeed < 0 And ball_center < Brick.Bottom And Ball.Right > Brick.Left And Ball.Left < Brick.Left Then
                xSpeed = -xSpeed
                Dim off As Single = ball_center - brick_center
                Dim distant As Single = off / (Brick.Height / 2)
                ySpeed += 5 * distant
                collided = True
            End If
            If ball_center > Brick.Top And xSpeed > 0 And ball_center < Brick.Bottom And Ball.Left < Brick.Right And Ball.Right > Brick.Right Then
                xSpeed = -xSpeed
                Dim off As Single = ball_center - brick_center
                Dim distant As Single = off / (Brick.Height / 2)
                ySpeed += 5 * distant
                collided = True
            End If
        End If
        Return collided
    End Function

    Private Sub MakeBricks(rows As Integer, cols As Integer)
        For R = 0 To rows - 1
            For C = 0 To cols - 1
                Dim B As New Button
                Me.Controls.Add(B)
                    B.Width = Me.ClientRectangle.Width / cols
                    B.Height = (Me.ClientRectangle.Height / 2.5) / rows
                    B.Top = 54 + B.Height * R
                    B.Left = B.Width * C
                    B.FlatStyle = FlatStyle.Flat
                    B.Name = "Brick"
                    Dim rn As Integer
                    rn = CInt(Int(Rnd() * 5) + 1)
                    If rn = 1 Then
                        B.BackColor = Color.Red
                    ElseIf rn = 2 Then
                        B.BackColor = Color.Firebrick
                    ElseIf rn = 3 Then
                        B.BackColor = Color.Maroon
                    ElseIf rn = 4 Then
                        B.BackColor = Color.Gray
                    ElseIf rn = 5 Then
                        B.BackColor = Color.LightGray
                    End If
            Next
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Randomize()
        Timer1.Start()
        MakeBricks(8, 18)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        bat.Left = e.X - (bat.Width / 2)
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("This Game has been Created by Rachit Dhar. Project Started And Completed On March 24, 2016", MsgBoxStyle.OkOnly, "Brick Breaker")
    End Sub

    Private Sub HowToPlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToPlayToolStripMenuItem.Click
        MsgBox("This Game is a Copy Of The Original Brick Breaker On Mobile Phones. The Object Of This Game is to Break All The Bricks Using the Ball and The Launcher. Click The Launcher at the Start To Launch the Ball Initially. There Are 5 Types Of Bricks, in the Order of Light to Dark: Steel, Stone, Maroon, FireBrick And Red. The Order Of Strength from Weak to Strong: Red, FireBrick, Maroon, Stone And Steel. Enjoy Playing!", MsgBoxStyle.OkOnly, "Brick Breaker")
    End Sub

    Private Sub bat_Click(sender As Object, e As EventArgs) Handles bat.Click
        If Start = True Then
            ySpeed -= 5
            xSpeed -= 5
            Start = False
        End If
    End Sub

    Private Sub RecordsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RecordsToolStripMenuItem1.Click
        Form2.Show()
    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        Me.BackColor = Color.DimGray
    End Sub

    Private Sub LightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightToolStripMenuItem.Click
        Me.BackColor = Color.LightGray
    End Sub
End Class