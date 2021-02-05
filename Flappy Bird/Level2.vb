Public Class Level2

    Dim fall As Single = 0
    Dim Gravity As Single = 2
    Dim pipe(2) As PictureBox
    Dim topPipe(2) As PictureBox
    Dim gapBetweenPipes As Integer = 460
    Dim pipeSpeed As Integer = 4
    Dim score As Integer = 0
    Dim pipeDistance As Integer = 250
    Dim pipesToCross As Integer = 10

    Private Sub Level2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Space Then
            fall = -15
        ElseIf e.KeyCode = Keys.Escape Then
            bird.Enabled = False
            fall = 0
            Gravity = 0
            pipeSpeed = 0
            Startscr.Label3.Text = score
            If score > Startscr.Label2.Text Then
                Startscr.Label2.Text = score
            End If
            MsgBox("Game Exited", MsgBoxStyle.OkOnly, "Flappy Bird")
            My.Settings.lives = 3
            Me.Close()
        End If
    End Sub

    Private Sub Level2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Randomize()
        Timer1.Enabled = True
        MakePipes(1)
        MakeTopPipes(1)
        My.Settings.lives = My.Settings.lives
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        fall += Gravity
        bird.Top += fall
        For i = 0 To 1
            pipe(i).Left -= pipeSpeed
            topPipe(i).Left -= pipeSpeed
            If bird.Enabled = True Then
                If Collision(pipe(i), bird) = True Then
                    My.Settings.lives -= 1
                    If Not My.Settings.lives < 0 Then
                        bird.Enabled = False
                        fall = 0
                        Gravity = 0
                        pipeSpeed = 0
                        Startscr.Label3.Text = score
                        If score > Startscr.Label2.Text Then
                            Startscr.Label2.Text = score
                        End If
                        MsgBox("You Lost 1 Life", MsgBoxStyle.OkOnly, "Flappy Bird")
                        levelscr2.Show()
                        Me.Close()
                    Else
                        bird.Enabled = False
                        fall = 0
                        Gravity = 0
                        pipeSpeed = 0
                        Startscr.Label3.Text = score
                        If score > Startscr.Label2.Text Then
                            Startscr.Label2.Text = score
                        End If
                        MsgBox("Game Over!", MsgBoxStyle.OkOnly, "Flappy Bird")
                        My.Settings.lives = 3
                        Me.Close()
                    End If
                ElseIf Collision(topPipe(i), bird) = True Then
                    My.Settings.lives -= 1
                    If Not My.Settings.lives < 0 Then
                        bird.Enabled = False
                        fall = 0
                        Gravity = 0
                        pipeSpeed = 0
                        Startscr.Label3.Text = score
                        If score > Startscr.Label2.Text Then
                            Startscr.Label2.Text = score
                        End If
                        MsgBox("You Lost 1 Life", MsgBoxStyle.OkOnly, "Flappy Bird")
                        levelscr2.Show()
                        Me.Close()
                    Else
                        bird.Enabled = False
                        fall = 0
                        Gravity = 0
                        pipeSpeed = 0
                        Startscr.Label3.Text = score
                        If score > Startscr.Label2.Text Then
                            Startscr.Label2.Text = score
                        End If
                        MsgBox("Game Over!", MsgBoxStyle.OkOnly, "Flappy Bird")
                        My.Settings.lives = 3
                        Me.Close()
                    End If
                ElseIf bird.Top > 440 Then
                    My.Settings.lives -= 1
                    If Not My.Settings.lives < 0 Then
                        bird.Enabled = False
                        fall = 0
                        Gravity = 0
                        pipeSpeed = 0
                        Startscr.Label3.Text = score
                        If score > Startscr.Label2.Text Then
                            Startscr.Label2.Text = score
                        End If
                        MsgBox("You Lost 1 Life", MsgBoxStyle.OkOnly, "Flappy Bird")
                        levelscr2.Show()
                        Me.Close()
                    Else
                        bird.Enabled = False
                        fall = 0
                        Gravity = 0
                        pipeSpeed = 0
                        Startscr.Label3.Text = score
                        If score > Startscr.Label2.Text Then
                            Startscr.Label2.Text = score
                        End If
                        MsgBox("Game Over!", MsgBoxStyle.OkOnly, "Flappy Bird")
                        My.Settings.lives = 3
                        Me.Close()
                    End If
                End If
                If score = pipesToCross Then
                    bird.Enabled = False
                    fall = 0
                    Gravity = 0
                    pipeSpeed = 0
                    Startscr.Label3.Text = score
                    If score > Startscr.Label2.Text Then
                        Startscr.Label2.Text = score
                    End If
                    MsgBox("Level1 Complete!", MsgBoxStyle.OkOnly, "Flappy Bird")
                    levelscr3.Show()
                    If Startscr.Label7.Text < 3 Then
                        Startscr.Label7.Text = 3
                    End If
                    Me.Close()
                End If
            End If
            If pipe(i).Left < 0 Then
                pipe(i).Left += pipeDistance * 2
                pipe(i).Top = 70 + 300 * Rnd()
                topPipe(i).Left = pipe(i).Left
                topPipe(i).Top = pipe(i).Top - gapBetweenPipes
                score += 1
            End If
        Next
    End Sub

    Public Sub MakePipes(ByVal Num As Integer)
        Dim i As Integer
        For i = 0 To Num
            Dim p As New PictureBox
            Me.Controls.Add(p)
            p.Height = 350
            p.Width = 50
            p.Top = 70 + 300 * Rnd()
            p.Left = (i * pipeDistance) + 300
            p.BorderStyle = BorderStyle.FixedSingle
            p.BackColor = Color.White
            pipe(i) = p
            pipe(i).Visible = True
        Next
    End Sub

    Public Sub MakeTopPipes(ByVal Num As Integer)
        Dim i As Integer
        For i = 0 To Num
            Dim p As New PictureBox
            Me.Controls.Add(p)
            p.Height = 350
            p.Width = 50
            p.Top = pipe(i).Top - gapBetweenPipes
            p.Left = (i * pipeDistance) + 300
            p.BorderStyle = BorderStyle.FixedSingle
            p.BackColor = Color.White
            topPipe(i) = p
            topPipe(i).Visible = True
        Next
    End Sub

    Private Function Collision(ByVal Object1 As PictureBox, ByVal Object2 As PictureBox) As Boolean
        Dim detected As Boolean = False
        If Object1.Bounds.IntersectsWith(Object2.Bounds) Then
            detected = True
        End If
        Return detected
    End Function

End Class
