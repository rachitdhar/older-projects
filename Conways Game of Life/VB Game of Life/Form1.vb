Public Class Form1

    Private Shadows size As Integer = 20
    Private length As Integer = 40
    Private neigh(length * length) As Integer
    Private max As Button

    Private Sub btn_Click(sender As Object, e As EventArgs)
        Dim sq As Button = sender
        If sq.BackColor = Color.YellowGreen Then
            sq.BackColor = Color.Black
        ElseIf sq.BackColor = Color.Black Then
            sq.BackColor = Color.YellowGreen
        End If
    End Sub

    Private Sub create_world()
        For i = 1 To length
            For j = 1 To length
                Dim btn As New Button
                Me.Controls.Add(btn)
                btn.Height = size
                btn.Width = size
                btn.BackColor = Color.Black
                btn.ForeColor = Color.Green
                btn.Left = 20 + (size * (j - 1)) - (j - 1)
                btn.Top = 20 + (size * (i - 1)) - (i - 1)
                btn.FlatStyle = FlatStyle.Flat
                btn.Name = "x" & ((length * (i - 1)) + j)
                AddHandler btn.Click, AddressOf btn_Click
                If i = length And j = length Then
                    max = btn
                End If
            Next
        Next
        Me.Width = 35 + max.Right
        Me.Height = 100 + max.Bottom
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        create_world()
        Dim x = max.Bottom + 15
        start_btn.Top = x
        stop_btn.Top = x
        clear_btn.Top = x
        Label1.Top = x
        gen.Top = x
        gen.Left = Me.Width - gen.Width - 40
        Label1.Left = gen.Left - Label1.Width - 10
    End Sub

    Private Sub start_btn_Click(sender As Object, e As EventArgs) Handles start_btn.Click
        Timer1.Start()
    End Sub

    Private Sub stop_btn_Click(sender As Object, e As EventArgs) Handles stop_btn.Click
        Timer1.Stop()
    End Sub

    Function find_neighbours(ByVal bt As Button) As Integer
        Dim num As Integer = 0
        For Each obj As Object In Me.Controls
            If obj.GetType Is GetType(Button) Then
                Dim btn = DirectCast(obj, Button)
                If Not btn.Name = bt.Name Then
                    If bt.Bounds.IntersectsWith(btn.Bounds) Then
                        If btn.BackColor = Color.YellowGreen Then
                            num += 1
                        End If
                    End If
                End If
            End If
        Next
        Return num
    End Function

    Private Sub list_neighbours()
        Dim i As Integer = 0
        For Each obj As Object In Me.Controls
            If obj.GetType Is GetType(Button) Then
                Dim btn = DirectCast(obj, Button)
                If btn.Name = "x" & (i + 1) Then
                    neigh(i) = find_neighbours(btn)
                    i += 1
                End If
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        list_neighbours()
        Dim i As Integer = 0
        For Each obj As Object In Me.Controls
            If obj.GetType Is GetType(Button) Then
                Dim btn = DirectCast(obj, Button)
                If Not btn.Name = "start_btn" Then
                    If Not btn.Name = "stop_btn" Then
                        If Not btn.Name = "clear_btn" Then
                            If btn.BackColor = Color.YellowGreen Then
                                If neigh(i) = 2 Or neigh(i) = 3 Then
                                    btn.BackColor = Color.YellowGreen
                                ElseIf neigh(i) < 2 Then
                                    btn.BackColor = Color.Black
                                ElseIf neigh(i) > 3 Then
                                    btn.BackColor = Color.Black
                                End If
                            ElseIf btn.BackColor = Color.Black Then
                                If neigh(i) = 3 Then
                                    btn.BackColor = Color.YellowGreen
                                End If
                            End If
                            i += 1
                        End If
                    End If
                End If
            End If
        Next
        gen.Text = Val(gen.Text) + 1
        gen.Left = Me.Width - gen.Width - 40
        Label1.Left = gen.Left - Label1.Width - 10
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        For Each obj As Object In Me.Controls
            If obj.GetType Is GetType(Button) Then
                Dim btn = DirectCast(obj, Button)
                If Not btn.Name = "start_btn" Then
                    If Not btn.Name = "stop_btn" Then
                        If Not btn.Name = "clear_btn" Then
                            btn.BackColor = Color.Black
                        End If
                    End If
                End If
            End If
        Next
        gen.Text = 0
        gen.Left = Me.Width - gen.Width - 40
        Label1.Left = gen.Left - Label1.Width - 10
    End Sub
End Class