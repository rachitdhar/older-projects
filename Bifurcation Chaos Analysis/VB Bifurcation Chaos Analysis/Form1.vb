Public Class Form1

    Dim lncol As Color = Color.Red
    Dim s As Integer = 15
    Dim last As Integer = 685

    Private Sub Coord_Axes()
        Dim p As New Pen(Color.Black, 3)
        Dim graph As Graphics
        p.EndCap = Drawing2D.LineCap.ArrowAnchor
        p.StartCap = Drawing2D.LineCap.Round
        graph = Graphics.FromHwnd(hwnd:=Me.Handle)
        graph.DrawLine(p, 15, 600, 15, 15)
        graph.DrawLine(p, 15, 600, last, 600)
    End Sub

    Private Sub clear()
        Dim p As New Pen(Me.BackColor, 3)
        Dim graph As Graphics
        graph = Graphics.FromHwnd(hwnd:=Me.Handle)
        Dim x As Integer = 0
        For x = 0 To (last + 15)
            graph.DrawLine(p, x, 0, x, 700)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        clear()
        s = 15
        last = ((335 * Val(TextBox1.Text)) / 4) + 15
        Coord_Axes()
        Timer1.Start()
    End Sub

    Private Function f(ByVal y As Double) As Double
        Dim n As Double
        n = y * (1 - y)
        Return n
    End Function

    Private Sub DrawXY(ByVal x As Integer)
        Try
            Dim lambda As Double = 0
            lambda = ((x - 15) / 335) * 4
            Dim y As Double = 0.5
            For i = 1 To 600
                y = lambda * f(y)
            Next
            For i = 1 To 512
                Dim ycor As Integer = 0
                ycor = CInt(30 + (570 * (1 - y)))
                Dim p As New Pen(lncol, 3)
                Dim graph As Graphics
                graph = Graphics.FromHwnd(hwnd:=Me.Handle)
                graph.DrawLine(p, x, ycor, x + 1, ycor)
                y = lambda * f(y)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If s < (last + 1) Then
            DrawXY(s)
            s += 1
        Else
            Timer1.Stop()
        End If
        Label1.Text = Val(Label1.Text) + 1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        last = ((335 * Val(TextBox1.Text)) / 4) + 15
        Coord_Axes()
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub
End Class
