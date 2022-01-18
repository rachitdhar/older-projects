Public Class PolyGraph

    Dim lncol As Color = Color.Red

    Private Sub Coord_Axes()
        Dim p As New Pen(Color.Black, 3)
        Dim graph As Graphics
        p.EndCap = Drawing2D.LineCap.ArrowAnchor
        p.StartCap = Drawing2D.LineCap.ArrowAnchor
        graph = Graphics.FromHwnd(hwnd:=Me.Handle)
        graph.DrawLine(p, 330, 15, 330, 630)
        graph.DrawLine(p, 15, 330, 630, 330)
    End Sub

    Private Function xcoord(ByVal x As Single) As Single
        Dim xcor As Single = 0
        xcor = (x - 330) * Val(adjustx.Text) * 0.1
        Return xcor
    End Function

    Private Function ycoord(ByVal y As Single)
        Dim ycor As Single = 0
        ycor = (330 - (y / (Val(adjusty.Text) * 0.1)))
        Return ycor
    End Function

    Private Sub PolyGraph_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If c0.Text = "" Then
            c0.Text = 0
        End If
        If c1.Text = "" Then
            c1.Text = 0
        End If
        If c2.Text = "" Then
            c2.Text = 0
        End If
        If c3.Text = "" Then
            c3.Text = 0
        End If
        If c4.Text = "" Then
            c4.Text = 0
        End If
        If c5.Text = "" Then
            c5.Text = 0
        End If
        If pow0.Text = "" Then
            pow0.Text = 0
        End If
        If pow1.Text = "" Then
            pow1.Text = 1
        End If
        If pow2.Text = "" Then
            pow2.Text = 2
        End If
        If pow3.Text = "" Then
            pow3.Text = 3
        End If
        If pow4.Text = "" Then
            pow4.Text = 4
        End If
        If pow5.Text = "" Then
            pow5.Text = 5
        End If
        If adjusty.Text = "" Then
            adjusty.Text = 1
        End If
        If adjustx.Text = "" Then
            adjustx.Text = 1
        End If
        If colourline.Text = "Red" Then
            lncol = Color.Red
        ElseIf colourline.Text = "Blue" Then
            lncol = Color.Blue
        ElseIf colourline.Text = "Green" Then
            lncol = Color.Green
        ElseIf colourline.Text = "Black" Then
            lncol = Color.Black
        ElseIf colourline.Text = "Violet" Then
            lncol = Color.Purple
        ElseIf colourline.Text = "Yellow" Then
            lncol = Color.Orange
        ElseIf colourline.Text = "Cyan" Then
            lncol = Color.Cyan
        ElseIf colourline.Text = "Pink" Then
            lncol = Color.Violet
        ElseIf colourline.Text = "Gray" Then
            lncol = Color.Gray
        ElseIf colourline.Text = "Orange" Then
            lncol = Color.Coral
        Else
            lncol = Color.Red
        End If
        Coord_Axes()
    End Sub

    Private Function Calculate_y(ByVal x As Double) As Single
        Dim y As Single = 0
        y = Val(c0.Text) * (x ^ Val(pow0.Text)) + Val(c1.Text) * (x ^ Val(pow1.Text)) + Val(c2.Text) * (x ^ Val(pow2.Text)) + Val(c3.Text) * (x ^ Val(pow3.Text)) + Val(c4.Text) * (x ^ Val(pow4.Text)) + Val(c5.Text) * (x ^ Val(pow5.Text))
        Return y
    End Function

    Private Sub Graph_Click(sender As Object, e As EventArgs) Handles Graph.Click
        Dim p As New Pen(lncol, 2)
        Dim graph As Graphics
        graph = Graphics.FromHwnd(hwnd:=Me.Handle)
        Dim x1 As Integer = 15
        Dim x2 As Integer = 16
        For x1 = 15 To 629
            Try
                graph.DrawLine(p, x1, ycoord(Calculate_y(xcoord(x1))), x2, ycoord(Calculate_y(xcoord(x2))))
            Catch ex As Exception
            End Try
            x2 += 1
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Dim p As New Pen(Me.BackColor, 3)
        Dim graph As Graphics
        graph = Graphics.FromHwnd(hwnd:=Me.Handle)
        Dim x As Integer = 0
        For x = 0 To 640
            graph.DrawLine(p, x, 0, x, 800)
        Next
    End Sub
End Class