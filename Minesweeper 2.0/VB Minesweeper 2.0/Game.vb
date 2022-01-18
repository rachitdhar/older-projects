Public Class Game

    Dim has_mine(1800) As Boolean
    Dim first_click As Boolean = True
    Dim mines As Integer = 0
    Dim b_completed As Integer = 0
    Dim btn_check As Button
    Dim b_code As Button
    Dim num_clr(8) As Color

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles Me.Load
        Randomize()
        ttime.Text = 0
        tmines.Text = 0
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()

        MakeTiles(My.Settings.cols, My.Settings.rows)
        num_clr(0) = Drawing.Color.Blue
        num_clr(1) = Drawing.Color.Green
        num_clr(2) = Drawing.Color.Red
        num_clr(3) = Drawing.Color.DarkBlue
        num_clr(4) = Drawing.Color.Maroon
        num_clr(5) = Drawing.Color.LightSeaGreen
        num_clr(6) = Drawing.Color.Black
        num_clr(7) = Drawing.Color.Gray
    End Sub

    Sub MakeTiles(ByVal cols As Integer, ByVal rows As Integer)
        Dim i As Integer = 1
        For R = 0 To rows - 1
            For C = 0 To cols - 1
                Dim btn As New Button
                Me.Panel1.Controls.Add(btn)
                btn.Width = 26
                btn.Height = 26
                btn.Left = (btn.Width * C) - C
                btn.Top = (btn.Height * R) - R
                btn.FlatStyle = FlatStyle.Popup
                btn.BackColor = My.Settings.clr_code
                btn.Font = New Font("Courier", 13, FontStyle.Bold)
                btn.Name = "b" + (i).ToString
                btn.BackgroundImageLayout = ImageLayout.Stretch
                AddHandler btn.MouseDown, AddressOf btn_MouseDown
                i += 1
            Next
        Next
        Panel1.Width = 25 * My.Settings.cols
        Panel1.Height = 25 * My.Settings.rows
        Me.Width = Panel1.Width + 40
        Me.Height = Panel1.Height + 100
        ttime.Left = 15 + (Panel1.Width / 2)
        tmines.Left = ttime.Left - tmines.Width - 3
        Label1.Left = tmines.Left - Label1.Width - 2
        Label2.Left = ttime.Left + ttime.Width + 2
        My.Settings.mine_constant = (cols * rows) / My.Settings.mines
    End Sub

    Private Sub click_SafeSqrs(ByVal bt As Button)
        For Each Obj As Object In Me.Panel1.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            Dim btn = DirectCast(Obj, Button)
                            If Not btn.Name = bt.Name Then
                                If Not btn.BackColor = Drawing.Color.LightGray Then
                                    If bt.Bounds.IntersectsWith(btn.Bounds) Then
                                        If Not btn.BackgroundImage Is b_flag.BackgroundImage Then
                                            btn.BackColor = Drawing.Color.LightGray
                                            b_num(btn)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub check_AllFound(ByVal num As Integer, ByVal bt As Button)
        Dim ch_num As Integer = 0
        For Each Obj As Object In Me.Panel1.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            Dim btn = DirectCast(Obj, Button)
                            If Not btn.Name = bt.Name Then
                                If Not btn.BackColor = Drawing.Color.LightGray Then
                                    If bt.Bounds.IntersectsWith(btn.Bounds) Then
                                        If btn.BackgroundImage Is b_flag.BackgroundImage Then
                                            If has_mine(b_completed) = True Then
                                                ch_num += 1
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        b_completed += 1
                    End If
                End If
            End If
        Next
        b_completed = 0

        If ch_num = num Then
            click_SafeSqrs(bt)
        End If
    End Sub

    Private Sub btn_MouseDown(sender As Object, e As MouseEventArgs)
        Dim btn As Button = DirectCast(sender, Button)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            If Not btn.BackgroundImage Is b_flag.BackgroundImage Then
                btn.BackColor = Drawing.Color.LightGray
                If first_click = True Then
                    b_code = btn
                    Deploy_Mines()
                    Timer1.Start()
                    Timer2.Start()
                    Timer3.Start()
                    NumbersToolStripMenuItem1.Enabled = False
                    DifficultyToolStripMenuItem1.Enabled = False
                    first_click = False
                End If
                btn_check = btn
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            If Not btn.BackColor = Drawing.Color.LightGray Then
                If Not btn.BackgroundImage Is b_flag.BackgroundImage Then
                    btn.BackgroundImage = b_flag.BackgroundImage
                    btn.FlatStyle = FlatStyle.Flat
                    btn.FlatAppearance.BorderColor = My.Settings.clr_code
                    btn.BackColor = Drawing.Color.Orange
                    tmines.Text -= 1
                Else
                    btn.BackgroundImage = non_image.BackgroundImage
                    btn.FlatStyle = FlatStyle.Popup
                    btn.FlatAppearance.BorderColor = Drawing.Color.Black
                    btn.BackColor = My.Settings.clr_code
                    tmines.Text += 1
                End If
            End If
        ElseIf e.Button = Windows.Forms.MouseButtons.Middle Then
            If btn.BackColor = Drawing.Color.LightGray Then
                If Not btn.Text = "" Then
                    check_AllFound(CInt(btn.Text), btn)
                End If
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ttime.Text += 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For Each Obj As Object In Me.Panel1.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            If DirectCast(Obj, Button).Name = btn_check.Name Then
                                If has_mine(b_completed) = True Then
                                    Timer1.Stop()
                                    Timer2.Stop()
                                    Timer3.Stop()

                                    DirectCast(Obj, Button).BackgroundImage = b_image.BackgroundImage
                                    MsgBox("You Lose!", MsgBoxStyle.OkOnly, "Minesweeper")
                                    game_over()
                                Else
                                    b_num(btn_check)
                                End If
                            End If
                            b_completed += 1
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Dim check As Integer = 0
        b_completed = 0
        For Each obj As Object In Me.Panel1.Controls
            If obj.GetType Is GetType(Button) Then
                If Not DirectCast(obj, Button).Name = "b_image" Then
                    If Not DirectCast(obj, Button).Name = "non_image" Then
                        If Not DirectCast(obj, Button).Name = "b_flag" Then
                            If has_mine(b_completed) = False Then
                                If DirectCast(obj, Button).BackColor = My.Settings.clr_code Then
                                    check += 1
                                End If
                            End If
                            b_completed += 1
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
        If check = 0 Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()

            MsgBox("You Win!", MsgBoxStyle.OkOnly, "Minesweeper")
            game_won()
        End If
        check = 0
    End Sub

    Sub b_num(ByVal btn As Button)
        Dim num As Integer = 0
        b_completed = 0
        For Each Obj As Object In Me.Panel1.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            If Not DirectCast(Obj, Button).Name = btn.Name Then
                                If btn.Bounds.IntersectsWith(DirectCast(Obj, Button).Bounds) Then
                                    If has_mine(b_completed) = True Then
                                        num += 1
                                    End If
                                End If
                            End If
                            b_completed += 1
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
        If Not num = 0 Then
            btn.Text = num
            If num = 1 Then
                btn.ForeColor = num_clr(0)
            ElseIf num = 2 Then
                btn.ForeColor = num_clr(1)
            ElseIf num = 3 Then
                btn.ForeColor = num_clr(2)
            ElseIf num = 4 Then
                btn.ForeColor = num_clr(3)
            ElseIf num = 5 Then
                btn.ForeColor = num_clr(4)
            ElseIf num = 6 Then
                btn.ForeColor = num_clr(5)
            ElseIf num = 7 Then
                btn.ForeColor = num_clr(6)
            ElseIf num = 8 Then
                btn.ForeColor = num_clr(7)
            End If
        Else
            zeromine(btn)
        End If
    End Sub

    Sub game_over()
        b_completed = 0
        For Each Obj As Object In Me.Panel1.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            If has_mine(b_completed) = True Then
                                If Not DirectCast(Obj, Button).BackgroundImage Is b_flag.BackgroundImage Then
                                    DirectCast(Obj, Button).BackgroundImage = b_image.BackgroundImage
                                End If
                            Else
                                If DirectCast(Obj, Button).BackgroundImage Is b_flag.BackgroundImage Then
                                    DirectCast(Obj, Button).BackColor = Drawing.Color.Cyan
                                End If
                            End If
                            If DirectCast(Obj, Button).BackColor = My.Settings.clr_code Then
                                DirectCast(Obj, Button).Enabled = False
                            ElseIf DirectCast(Obj, Button).BackgroundImage Is b_flag.BackgroundImage Then
                                DirectCast(Obj, Button).Enabled = False
                            End If
                            b_completed += 1
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
        My.Settings.tot += 1
        My.Settings.lose += 1
    End Sub

    Sub game_won()
        b_completed = 0
        For Each Obj As Object In Me.Panel1.Controls
            If Obj.GetType Is GetType(Button) Then
                If DirectCast(Obj, Button).Enabled = True Then
                    If Not DirectCast(Obj, Button).Name = "b_image" Then
                        If Not DirectCast(Obj, Button).Name = "non_image" Then
                            If Not DirectCast(Obj, Button).Name = "b_flag" Then
                                If DirectCast(Obj, Button).BackColor = My.Settings.clr_code Then
                                    DirectCast(Obj, Button).Enabled = False
                                ElseIf DirectCast(Obj, Button).BackgroundImage Is b_flag.BackgroundImage Then
                                    DirectCast(Obj, Button).Enabled = False
                                End If
                                b_completed += 1
                            End If
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
        My.Settings.tot += 1
        My.Settings.win += 1
        If My.Settings.first = True Then
            My.Settings.first = False
            If My.Settings.mines = 10 Then
                My.Settings.Btime = ttime.Text
            ElseIf My.Settings.mines = 40 Then
                My.Settings.Itime = ttime.Text
            ElseIf My.Settings.mines = 99 Then
                My.Settings.Etime = ttime.Text
            Else
                My.Settings.Mtime = ttime.Text
            End If
        Else
            If My.Settings.mines = 10 Then
                If My.Settings.Btime > ttime.Text Then
                    My.Settings.Btime = ttime.Text
                End If
            ElseIf My.Settings.mines = 40 Then
                If My.Settings.Itime > ttime.Text Then
                    My.Settings.Itime = ttime.Text
                End If
            ElseIf My.Settings.mines = 99 Then
                If My.Settings.Etime > ttime.Text Then
                    My.Settings.Etime = ttime.Text
                End If
            Else
                If My.Settings.Mtime > ttime.Text Then
                    My.Settings.Mtime = ttime.Text
                End If
            End If
        End If
    End Sub

    Sub Deploy_Mines()
this:   new_mines()
        If mines < My.Settings.mines Then
            mines = 0
            b_completed = 0
            GoTo this
        End If
        b_completed = 0
        tmines.Text = mines
    End Sub

    Sub new_mines()
        discard()
        b_completed = 0
        For Each obj As Object In Me.Panel1.Controls
            If obj.GetType Is GetType(Button) Then
                If Not DirectCast(obj, Button).Name = "b_image" Then
                    If Not DirectCast(obj, Button).Name = "non_image" Then
                        If Not DirectCast(obj, Button).Name = "b_flag" Then
                            Dim r As Integer = CInt(Int(My.Settings.mine_constant * Rnd()) + 0)
                            If r = 4 Then
                                If Not DirectCast(obj, Button).Name = b_code.Name Then
                                    has_mine(b_completed) = True
                                    mines += 1
                                Else
                                    has_mine(b_completed) = False
                                End If
                            Else
                                has_mine(b_completed) = False
                            End If
                            b_completed += 1
                        End If
                    End If
                End If
            End If
        Next
        b_completed = 0
    End Sub

    Sub discard()
        Dim i As Integer
        For i = 0 To 1799
            If has_mine(i) = True Then
                has_mine(i) = False
            End If
        Next
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub RecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecordsToolStripMenuItem.Click
        Records.Show()
    End Sub

    Private Sub HighScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighScoreToolStripMenuItem.Click
        Score.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Game Created By Rachit Dhar. Project Started On March 30, 2016 And Game Completed Fully By April 1, 2016 And Improved by March 29, 2017. Enjoy!", MsgBoxStyle.OkOnly, "Minesweeper")
    End Sub

    Private Sub HowToPlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HowToPlayToolStripMenuItem.Click
        MsgBox("Minesweeper is a well known and a very famous Game. It Consists of Squares that are to be clicked. Under the Squares are either Numbers From 1 to 8 or Mines which when clicked would Explode and You Will Lose. The Numbers Indicate How Many Mines Are Around that Square and this Allows You To Pridict the Correct Squares. One who manages to click all the Safe Squares will Win!", MsgBoxStyle.OkOnly, "Minesweeper")
    End Sub

    Sub color(ByVal clr As System.Drawing.Color)
        For Each Obj As Object In Me.Panel1.Controls
            If Obj.GetType Is GetType(Button) Then
                If DirectCast(Obj, Button).BackColor = My.Settings.clr_code Then
                    DirectCast(Obj, Button).BackColor = clr
                End If
            End If
        Next
    End Sub

    Private Sub EasyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EasyToolStripMenuItem.Click
        Me.Panel1.Controls.Clear()
        My.Settings.rows = 9
        My.Settings.cols = 9
        My.Settings.mines = 10
        MakeTiles(My.Settings.cols, My.Settings.rows)
    End Sub

    Private Sub IntermediateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles IntermediateToolStripMenuItem1.Click
        Me.Panel1.Controls.Clear()
        My.Settings.rows = 16
        My.Settings.cols = 16
        My.Settings.mines = 40
        MakeTiles(My.Settings.cols, My.Settings.rows)
    End Sub

    Private Sub ExpertToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExpertToolStripMenuItem1.Click
        Me.Panel1.Controls.Clear()
        My.Settings.rows = 16
        My.Settings.cols = 30
        My.Settings.mines = 99
        MakeTiles(My.Settings.cols, My.Settings.rows)
    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        color(Drawing.Color.DodgerBlue)
        My.Settings.clr_code = Drawing.Color.DodgerBlue
    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        color(Drawing.Color.Red)
        My.Settings.clr_code = Drawing.Color.Red
    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        color(Drawing.Color.Green)
        My.Settings.clr_code = Drawing.Color.Green
    End Sub

    Private Sub YellowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YellowToolStripMenuItem.Click
        color(Drawing.Color.Yellow)
        My.Settings.clr_code = Drawing.Color.Yellow
    End Sub

    Private Sub OriginalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OriginalToolStripMenuItem1.Click
        color(Drawing.Color.FromArgb(160, 160, 160, 160))
        My.Settings.clr_code = Drawing.Color.FromArgb(160, 160, 160, 160)
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click

        Timer3.Stop()
        Timer2.Stop()
        Timer1.Stop()
        ttime.Text = 0
        tmines.Text = 0
        first_click = True
        mines = 0
        b_completed = 0
        NumbersToolStripMenuItem1.Enabled = True
        DifficultyToolStripMenuItem1.Enabled = True
        For Each Obj As Object In Me.Panel1.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            DirectCast(Obj, Button).Enabled = True
                            DirectCast(Obj, Button).BackColor = My.Settings.clr_code
                            DirectCast(Obj, Button).Text = ""
                            DirectCast(Obj, Button).FlatStyle = FlatStyle.Popup
                            DirectCast(Obj, Button).BackgroundImage = non_image.BackgroundImage
                        End If
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub OriginalToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles OriginalToolStripMenuItem2.Click
        num_clr(0) = Drawing.Color.Blue
        num_clr(1) = Drawing.Color.Green
        num_clr(2) = Drawing.Color.Red
        num_clr(3) = Drawing.Color.DarkBlue
        num_clr(4) = Drawing.Color.Maroon
        num_clr(5) = Drawing.Color.LightSeaGreen
        num_clr(6) = Drawing.Color.Black
        num_clr(7) = Drawing.Color.Gray
    End Sub

    Private Sub ClassicToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClassicToolStripMenuItem1.Click
        num_clr(0) = Drawing.Color.Black
        num_clr(1) = Drawing.Color.Gray
        num_clr(2) = Drawing.Color.Orange
        num_clr(3) = Drawing.Color.Green
        num_clr(4) = Drawing.Color.Blue
        num_clr(5) = Drawing.Color.Red
        num_clr(6) = Drawing.Color.Yellow
        num_clr(7) = Drawing.Color.Maroon
    End Sub

    Private Sub SpecialToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SpecialToolStripMenuItem1.Click
        num_clr(0) = Drawing.Color.Orange
        num_clr(1) = Drawing.Color.HotPink
        num_clr(2) = Drawing.Color.Purple
        num_clr(3) = Drawing.Color.SeaGreen
        num_clr(4) = Drawing.Color.Red
        num_clr(5) = Drawing.Color.Blue
        num_clr(6) = Drawing.Color.White
        num_clr(7) = Drawing.Color.Black
    End Sub

    Private Sub CustomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomToolStripMenuItem.Click
        Custom.Show()
        Timer4.Start()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If My.Settings.custom = True Then
            Me.Panel1.Controls.Clear()
            MakeTiles(My.Settings.cols, My.Settings.rows)
            My.Settings.custom = False
            Timer4.Stop()
        End If
    End Sub

    Private Sub PinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PinkToolStripMenuItem.Click
        color(Drawing.Color.HotPink)
        My.Settings.clr_code = Drawing.Color.HotPink
    End Sub

    Private Sub WaterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WaterToolStripMenuItem.Click
        color(Drawing.Color.MediumTurquoise)
        My.Settings.clr_code = Drawing.Color.MediumTurquoise
    End Sub

    Private Sub GrassToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GrassToolStripMenuItem.Click
        color(Drawing.Color.LimeGreen)
        My.Settings.clr_code = Drawing.Color.LimeGreen
    End Sub

    Private Sub LavaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LavaToolStripMenuItem.Click
        color(Drawing.Color.OrangeRed)
        My.Settings.clr_code = Drawing.Color.OrangeRed
    End Sub

    Private Sub OrangeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrangeToolStripMenuItem.Click
        color(Drawing.Color.DarkOrange)
        My.Settings.clr_code = Drawing.Color.DarkOrange
    End Sub

    Private Sub BlackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlackToolStripMenuItem.Click
        color(Drawing.Color.Black)
        My.Settings.clr_code = Drawing.Color.Black
    End Sub

    Private Sub zeromine(ByVal bt As Button)
        For Each Obj As Object In Me.Panel1.Controls
            If Obj.GetType Is GetType(Button) Then
                If Not DirectCast(Obj, Button).Name = "b_image" Then
                    If Not DirectCast(Obj, Button).Name = "non_image" Then
                        If Not DirectCast(Obj, Button).Name = "b_flag" Then
                            Dim btn = DirectCast(Obj, Button)
                            If Not btn.Name = bt.Name Then
                                If Not btn.BackColor = Drawing.Color.LightGray Then
                                    If bt.Bounds.IntersectsWith(btn.Bounds) Then
                                        btn.BackColor = Drawing.Color.LightGray
                                        btn.BackgroundImage = non_image.BackgroundImage
                                        b_num(btn)
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub
End Class