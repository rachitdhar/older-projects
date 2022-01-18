Public Class Form1

    Dim num As Integer = 1
    Dim xSpeed(200) As Integer
    Dim ySpeed(200) As Integer
    Dim first_start As Boolean = True
    Dim crossed_limit(200) As Boolean

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Dim Pos = MousePosition()
        Dim particle As New Button
        Me.Controls.Add(particle)
        particle.Left = Pos.X - Me.Left - 10
        particle.Top = Pos.Y - Me.Top - 35
        If colorOpt.Text = "Blue" Then
            particle.BackColor = Color.LightSkyBlue
        ElseIf colorOpt.Text = "Red" Then
            particle.BackColor = Color.Coral
        ElseIf colorOpt.Text = "Yellow" Then
            particle.BackColor = Color.Gold
        End If
        particle.FlatStyle = FlatStyle.Flat
        particle.Name = "P" + num.ToString
        particle.Tag = num
        num += 1
        particle.Width = 12
        particle.Height = 12
        particle.Enabled = False
        particle.Visible = True
        part_n.Text = Val(part_n.Text) + 1
    End Sub

    Private Sub Init_Brownian_Motion()
        Randomize()
        For Each obj As Object In Me.Controls
            If obj.GetType() Is GetType(Button) Then
                If Not DirectCast(obj, Button).Name = "Button1" Then
                    If Not DirectCast(obj, Button).Name = "Button2" Then
                        Dim particle As Button = DirectCast(obj, Button)
                        If speed.Text = "" Then
                            speed.Text = "15"
                        ElseIf Val(speed.Text) > 15 Or Val(speed.Text) < 5 Then
                            speed.Text = "15"
                        End If
                        Dim sp As Integer = Val(speed.Text)
                        xSpeed(particle.Tag) = CInt(Int(Rnd() * sp) + 1)
                        ySpeed(particle.Tag) = CInt(Int(Rnd() * sp) + 1)
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub particles_collide(ByVal p As Button, ByVal p2 As Button)
        Dim c1x As Double = (p.Left + p.Right) / 2
        Dim c2x As Double = (p2.Left + p2.Right) / 2
        Dim c1y As Double = (p.Top + p.Bottom) / 2
        Dim c2y As Double = (p2.Top + p2.Bottom) / 2

        Dim s As Double = Math.Sqrt(Math.Pow((c1x - c2x), 2) + Math.Pow((c1y - c2y), 2))
        Dim normx As Double = (c2x - c1x) / s
        Dim normy As Double = (c2y - c1y) / s

        Dim v1x = xSpeed(p.Tag)
        Dim v2x = xSpeed(p2.Tag)
        Dim v1y = ySpeed(p.Tag)
        Dim v2y = ySpeed(p2.Tag)

        xSpeed(p.Tag) = v1x - normx * (v1x * normx + v1y * normy - v2x * normx - v2y * normy)
        ySpeed(p.Tag) = v1y - normy * (v1x * normx + v1y * normy - v2x * normx - v2y * normy)
        xSpeed(p2.Tag) = v2x + normx * (v1x * normx + v1y * normy - v2x * normx - v2y * normy)
        ySpeed(p2.Tag) = v2y + normy * (v1x * normx + v1y * normy - v2x * normx - v2y * normy)
    End Sub

    Private Sub check_Collision(ByVal p As Button)
        For Each obj As Object In Me.Controls
            If obj.GetType Is GetType(Button) Then
                If Not DirectCast(obj, Button).Name = p.Name Then
                    If Not DirectCast(obj, Button).Name = "Button1" Or Not DirectCast(obj, Button).Name = "Button2" Then
                        Dim p2 As Button = DirectCast(obj, Button)
                        If p.Bounds.IntersectsWith(p2.Bounds) Then
                            particles_collide(p, p2)
                        End If
                    End If
                End If
            ElseIf obj.GetType Is GetType(Panel) Then
                Dim p2 As Panel = DirectCast(obj, Panel)
                If p.Bounds.IntersectsWith(p2.Bounds) Then
                    If p2.Name = "Panel1" Or p2.Name = "Panel2" Then
                        xSpeed(p.Tag) = -(xSpeed(p.Tag))
                    ElseIf p2.Name = "Panel5" Or p2.Name = "Panel6" Then
                        If crossed_limit(p.Tag) = True Then
                            ySpeed(p.Tag) = -(ySpeed(p.Tag))
                        Else
                            xSpeed(p.Tag) = -(xSpeed(p.Tag))
                        End If
                    Else
                        ySpeed(p.Tag) = -(ySpeed(p.Tag))
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If first_start = True Then
            Init_Brownian_Motion()
            first_start = False
        End If

        For Each obj As Object In Me.Controls
            If obj.GetType() Is GetType(Button) Then
                If Not DirectCast(obj, Button).Name = "Button1" Or Not DirectCast(obj, Button).Name = "Button2" Then
                    Dim particle As Button = DirectCast(obj, Button)
                    Dim n As Integer = CInt(particle.Tag)
                    particle.Left += xSpeed(n)
                    particle.Top += ySpeed(n)
                    check_Collision(particle)
                    If particle.Right > Panel5.Left And particle.Left < Panel5.Right Then
                        If particle.Top > Panel5.Bottom And particle.Bottom < Panel6.Top Then
                            crossed_limit(particle.Tag) = True
                        Else
                            crossed_limit(particle.Tag) = False
                        End If
                    Else
                        crossed_limit(particle.Tag) = False
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        speed.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub
End Class