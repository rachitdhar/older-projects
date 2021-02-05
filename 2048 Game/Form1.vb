Public Class Form1

    Dim pause As Boolean = False

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If pause = False Then
            If e.KeyCode = Keys.Up Then
                Dim x As Integer = 0
                'Row 1
                If Val(b1.Tag) = Val(a1.Tag) Then
                    a1.Tag = Val(a1.Tag) + Val(b1.Tag)
                    b1.Tag = "0"
                    x += 1
                    score.Text += (Val(a1.Tag) + Val(b1.Tag))
                ElseIf a1.Tag = "0" Then
                    a1.Tag = b1.Tag
                    b1.Tag = "0"
                    x += 1
                End If
                If Val(c1.Tag) = Val(b1.Tag) Then
                    b1.Tag = Val(b1.Tag) + Val(c1.Tag)
                    c1.Tag = "0"
                    x += 1
                    score.Text += (Val(b1.Tag) + Val(c1.Tag))
                ElseIf b1.Tag = "0" Then
                    If Val(c1.Tag) = Val(a1.Tag) Then
                        a1.Tag = Val(a1.Tag) + Val(c1.Tag)
                        c1.Tag = "0"
                        x += 1
                        score.Text += (Val(a1.Tag) + Val(c1.Tag))
                    Else
                        If a1.Tag = "0" Then
                            a1.Tag = c1.Tag
                            c1.Tag = "0"
                            x += 1
                        Else
                            b1.Tag = c1.Tag
                            c1.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(d1.Tag) = Val(c1.Tag) Then
                    c1.Tag = Val(c1.Tag) + Val(d1.Tag)
                    d1.Tag = "0"
                    x += 1
                    score.Text += (Val(c1.Tag) + Val(d1.Tag))
                Else
                    If c1.Tag = "0" Then
                        If Val(d1.Tag) = Val(b1.Tag) Then
                            b1.Tag = Val(b1.Tag) + Val(d1.Tag)
                            d1.Tag = "0"
                            x += 1
                            score.Text += (Val(b1.Tag) + Val(d1.Tag))
                        Else
                            If b1.Tag = "0" Then
                                If Val(d1.Tag) = Val(a1.Tag) Then
                                    a1.Tag = Val(a1.Tag) + Val(d1.Tag)
                                    d1.Tag = "0"
                                    x += 1
                                    score.Text += (Val(a1.Tag) + Val(d1.Tag))
                                Else
                                    If a1.Tag = "0" Then
                                        a1.Tag = d1.Tag
                                        d1.Tag = "0"
                                        x += 1
                                    Else
                                        b1.Tag = d1.Tag
                                        d1.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                c1.Tag = d1.Tag
                                d1.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 2
                If Val(b2.Tag) = Val(a2.Tag) Then
                    a2.Tag = Val(a2.Tag) + Val(b2.Tag)
                    b2.Tag = "0"
                    x += 1
                    score.Text += (Val(a2.Tag) + Val(b2.Tag))
                ElseIf a2.Tag = "0" Then
                    a2.Tag = b2.Tag
                    b2.Tag = "0"
                    x += 1
                End If
                If Val(c2.Tag) = Val(b2.Tag) Then
                    b2.Tag = Val(b2.Tag) + Val(c2.Tag)
                    c2.Tag = "0"
                    x += 1
                    score.Text += (Val(b2.Tag) + Val(c2.Tag))
                ElseIf b2.Tag = "0" Then
                    If Val(c2.Tag) = Val(a2.Tag) Then
                        a2.Tag = Val(a2.Tag) + Val(c2.Tag)
                        c2.Tag = "0"
                        x += 1
                        score.Text += (Val(a2.Tag) + Val(c2.Tag))
                    Else
                        If a2.Tag = "0" Then
                            a2.Tag = c2.Tag
                            c2.Tag = "0"
                            x += 1
                        Else
                            b2.Tag = c2.Tag
                            c2.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(d2.Tag) = Val(c2.Tag) Then
                    c2.Tag = Val(c2.Tag) + Val(d2.Tag)
                    d2.Tag = "0"
                    x += 1
                    score.Text += (Val(c2.Tag) + Val(d2.Tag))
                Else
                    If c2.Tag = "0" Then
                        If Val(d2.Tag) = Val(b2.Tag) Then
                            b2.Tag = Val(b2.Tag) + Val(d2.Tag)
                            d2.Tag = "0"
                            x += 1
                            score.Text += (Val(b2.Tag) + Val(d2.Tag))
                        Else
                            If b2.Tag = "0" Then
                                If Val(d2.Tag) = Val(a2.Tag) Then
                                    a2.Tag = Val(a2.Tag) + Val(d2.Tag)
                                    d2.Tag = "0"
                                    x += 1
                                    score.Text += (Val(a2.Tag) + Val(d2.Tag))
                                Else
                                    If a2.Tag = "0" Then
                                        a2.Tag = d2.Tag
                                        d2.Tag = "0"
                                        x += 1
                                    Else
                                        b2.Tag = d2.Tag
                                        d2.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                c2.Tag = d2.Tag
                                d2.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 3
                If Val(b3.Tag) = Val(a3.Tag) Then
                    a3.Tag = Val(a3.Tag) + Val(b3.Tag)
                    b3.Tag = "0"
                    x += 1
                    score.Text += (Val(a3.Tag) + Val(b3.Tag))
                ElseIf a3.Tag = "0" Then
                    a3.Tag = b3.Tag
                    b3.Tag = "0"
                    x += 1
                End If
                If Val(c3.Tag) = Val(b3.Tag) Then
                    b3.Tag = Val(b3.Tag) + Val(c3.Tag)
                    c3.Tag = "0"
                    x += 1
                    score.Text += (Val(b3.Tag) + Val(c3.Tag))
                ElseIf b3.Tag = "0" Then
                    If Val(c3.Tag) = Val(a3.Tag) Then
                        a3.Tag = Val(a3.Tag) + Val(c3.Tag)
                        c3.Tag = "0"
                        x += 1
                        score.Text += (Val(a3.Tag) + Val(c3.Tag))
                    Else
                        If a3.Tag = "0" Then
                            a3.Tag = c3.Tag
                            c3.Tag = "0"
                            x += 1
                        Else
                            b3.Tag = c3.Tag
                            c3.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(d3.Tag) = Val(c3.Tag) Then
                    c3.Tag = Val(c3.Tag) + Val(d3.Tag)
                    d3.Tag = "0"
                    x += 1
                    score.Text += (Val(c3.Tag) + Val(d3.Tag))
                Else
                    If c3.Tag = "0" Then
                        If Val(d3.Tag) = Val(b3.Tag) Then
                            b3.Tag = Val(b3.Tag) + Val(d3.Tag)
                            d3.Tag = "0"
                            x += 1
                            score.Text += (Val(b3.Tag) + Val(d3.Tag))
                        Else
                            If b3.Tag = "0" Then
                                If Val(d3.Tag) = Val(a3.Tag) Then
                                    a3.Tag = Val(a3.Tag) + Val(d3.Tag)
                                    d3.Tag = "0"
                                    x += 1
                                    score.Text += (Val(a3.Tag) + Val(d3.Tag))
                                Else
                                    If a3.Tag = "0" Then
                                        a3.Tag = d3.Tag
                                        d3.Tag = "0"
                                        x += 1
                                    Else
                                        b3.Tag = d3.Tag
                                        d3.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                c3.Tag = d3.Tag
                                d3.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 4
                If Val(b4.Tag) = Val(a4.Tag) Then
                    a4.Tag = Val(a4.Tag) + Val(b4.Tag)
                    b4.Tag = "0"
                    x += 1
                    score.Text += (Val(a4.Tag) + Val(b4.Tag))
                ElseIf a4.Tag = "0" Then
                    a4.Tag = b4.Tag
                    b4.Tag = "0"
                    x += 1
                End If
                If Val(c4.Tag) = Val(b4.Tag) Then
                    b4.Tag = Val(b4.Tag) + Val(c4.Tag)
                    c4.Tag = "0"
                    x += 1
                    score.Text += (Val(b4.Tag) + Val(c4.Tag))
                ElseIf b4.Tag = "0" Then
                    If Val(c4.Tag) = Val(a4.Tag) Then
                        a4.Tag = Val(a4.Tag) + Val(c4.Tag)
                        c4.Tag = "0"
                        x += 1
                    Else
                        If a4.Tag = "0" Then
                            a4.Tag = c4.Tag
                            c4.Tag = "0"
                            x += 1
                        Else
                            b4.Tag = c4.Tag
                            c4.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(d4.Tag) = Val(c4.Tag) Then
                    c4.Tag = Val(c4.Tag) + Val(d4.Tag)
                    d4.Tag = "0"
                    x += 1
                    score.Text += (Val(c4.Tag) + Val(d4.Tag))
                Else
                    If c4.Tag = "0" Then
                        If Val(d4.Tag) = Val(b4.Tag) Then
                            b4.Tag = Val(b4.Tag) + Val(d4.Tag)
                            d4.Tag = "0"
                            x += 1
                            score.Text += (Val(b4.Tag) + Val(d4.Tag))
                        Else
                            If b4.Tag = "0" Then
                                If Val(d4.Tag) = Val(a4.Tag) Then
                                    a4.Tag = Val(a4.Tag) + Val(d4.Tag)
                                    d4.Tag = "0"
                                    x += 1
                                    score.Text += (Val(a4.Tag) + Val(d4.Tag))
                                Else
                                    If a4.Tag = "0" Then
                                        a4.Tag = d4.Tag
                                        d4.Tag = "0"
                                        x += 1
                                    Else
                                        b4.Tag = d4.Tag
                                        d4.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                c4.Tag = d4.Tag
                                d4.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Make New Tile if possible
                If x > 0 Then
                    Create_Tile()
                End If
            ElseIf e.KeyCode = Keys.Down Then
                Dim x As Integer = 0
                'Row 1
                If Val(c1.Tag) = Val(d1.Tag) Then
                    d1.Tag = Val(c1.Tag) + Val(d1.Tag)
                    c1.Tag = "0"
                    x += 1
                    score.Text += (Val(c1.Tag) + Val(d1.Tag))
                ElseIf d1.Tag = "0" Then
                    d1.Tag = c1.Tag
                    c1.Tag = "0"
                    x += 1
                End If
                If Val(b1.Tag) = Val(c1.Tag) Then
                    c1.Tag = Val(b1.Tag) + Val(c1.Tag)
                    b1.Tag = "0"
                    x += 1
                    score.Text += (Val(c1.Tag) + Val(b1.Tag))
                ElseIf c1.Tag = "0" Then
                    If Val(b1.Tag) = Val(d1.Tag) Then
                        d1.Tag = Val(d1.Tag) + Val(b1.Tag)
                        b1.Tag = "0"
                        x += 1
                    Else
                        If d1.Tag = "0" Then
                            d1.Tag = b1.Tag
                            b1.Tag = "0"
                            x += 1
                        Else
                            c1.Tag = b1.Tag
                            b1.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(a1.Tag) = Val(b1.Tag) Then
                    b1.Tag = Val(a1.Tag) + Val(b1.Tag)
                    a1.Tag = "0"
                    x += 1
                    score.Text += (Val(a1.Tag) + Val(b1.Tag))
                Else
                    If b1.Tag = "0" Then
                        If Val(a1.Tag) = Val(c1.Tag) Then
                            c1.Tag = Val(a1.Tag) + Val(c1.Tag)
                            a1.Tag = "0"
                            x += 1
                            score.Text += (Val(a1.Tag) + Val(c1.Tag))
                        Else
                            If c1.Tag = "0" Then
                                If Val(a1.Tag) = Val(d1.Tag) Then
                                    d1.Tag = Val(a1.Tag) + Val(d1.Tag)
                                    a1.Tag = "0"
                                    x += 1
                                    score.Text += (Val(a1.Tag) + Val(d1.Tag))
                                Else
                                    If d1.Tag = "0" Then
                                        d1.Tag = a1.Tag
                                        a1.Tag = "0"
                                        x += 1
                                    Else
                                        c1.Tag = a1.Tag
                                        a1.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                b1.Tag = a1.Tag
                                a1.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 2
                If Val(c2.Tag) = Val(d2.Tag) Then
                    d2.Tag = Val(c2.Tag) + Val(d2.Tag)
                    c2.Tag = "0"
                    x += 1
                    score.Text += (Val(c2.Tag) + Val(d2.Tag))
                ElseIf d2.Tag = "0" Then
                    d2.Tag = c2.Tag
                    c2.Tag = "0"
                    x += 1
                End If
                If Val(b2.Tag) = Val(c2.Tag) Then
                    c2.Tag = Val(b2.Tag) + Val(c2.Tag)
                    b2.Tag = "0"
                    x += 1
                    score.Text += (Val(b2.Tag) + Val(c2.Tag))
                ElseIf c2.Tag = "0" Then
                    If Val(b2.Tag) = Val(d2.Tag) Then
                        d2.Tag = Val(d2.Tag) + Val(b2.Tag)
                        b2.Tag = "0"
                        x += 1
                        score.Text += (Val(d2.Tag) + Val(b2.Tag))
                    Else
                        If d2.Tag = "0" Then
                            d2.Tag = b2.Tag
                            b2.Tag = "0"
                            x += 1
                        Else
                            c2.Tag = b2.Tag
                            b2.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(a2.Tag) = Val(b2.Tag) Then
                    b2.Tag = Val(a2.Tag) + Val(b2.Tag)
                    a2.Tag = "0"
                    x += 1
                    score.Text += (Val(a2.Tag) + Val(b2.Tag))
                Else
                    If b2.Tag = "0" Then
                        If Val(a2.Tag) = Val(c2.Tag) Then
                            c2.Tag = Val(a2.Tag) + Val(c2.Tag)
                            a2.Tag = "0"
                            x += 1
                            score.Text += (Val(a2.Tag) + Val(c2.Tag))
                        Else
                            If c2.Tag = "0" Then
                                If Val(a2.Tag) = Val(d2.Tag) Then
                                    d2.Tag = Val(a2.Tag) + Val(d2.Tag)
                                    a2.Tag = "0"
                                    x += 1
                                    score.Text += (Val(a2.Tag) + Val(d2.Tag))
                                Else
                                    If d2.Tag = "0" Then
                                        d2.Tag = a2.Tag
                                        a2.Tag = "0"
                                        x += 1
                                    Else
                                        c2.Tag = a2.Tag
                                        a2.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                b2.Tag = a2.Tag
                                a2.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 3
                If Val(c3.Tag) = Val(d3.Tag) Then
                    d3.Tag = Val(c3.Tag) + Val(d3.Tag)
                    c3.Tag = "0"
                    x += 1
                    score.Text += (Val(c3.Tag) + Val(d3.Tag))
                ElseIf d3.Tag = "0" Then
                    d3.Tag = c3.Tag
                    c3.Tag = "0"
                    x += 1
                End If
                If Val(b3.Tag) = Val(c3.Tag) Then
                    c3.Tag = Val(b3.Tag) + Val(c3.Tag)
                    b3.Tag = "0"
                    x += 1
                    score.Text += (Val(b3.Tag) + Val(c3.Tag))
                ElseIf c3.Tag = "0" Then
                    If Val(b3.Tag) = Val(d3.Tag) Then
                        d3.Tag = Val(d3.Tag) + Val(b3.Tag)
                        b3.Tag = "0"
                        x += 1
                        score.Text += (Val(d3.Tag) + Val(b3.Tag))
                    Else
                        If d3.Tag = "0" Then
                            d3.Tag = b3.Tag
                            b3.Tag = "0"
                            x += 1
                        Else
                            c3.Tag = b3.Tag
                            b3.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(a3.Tag) = Val(b3.Tag) Then
                    b3.Tag = Val(a3.Tag) + Val(b3.Tag)
                    a3.Tag = "0"
                    x += 1
                    score.Text += (Val(a3.Tag) + Val(b3.Tag))
                Else
                    If b3.Tag = "0" Then
                        If Val(a3.Tag) = Val(c3.Tag) Then
                            c3.Tag = Val(a3.Tag) + Val(c3.Tag)
                            a3.Tag = "0"
                            x += 1
                            score.Text += (Val(a3.Tag) + Val(c3.Tag))
                        Else
                            If c3.Tag = "0" Then
                                If Val(a3.Tag) = Val(d3.Tag) Then
                                    d3.Tag = Val(a3.Tag) + Val(d3.Tag)
                                    a3.Tag = "0"
                                    x += 1
                                    score.Text += (Val(a3.Tag) + Val(d3.Tag))
                                Else
                                    If d3.Tag = "0" Then
                                        d3.Tag = a3.Tag
                                        a3.Tag = "0"
                                        x += 1
                                    Else
                                        c3.Tag = a3.Tag
                                        a3.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                b3.Tag = a3.Tag
                                a3.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 4
                If Val(c4.Tag) = Val(d4.Tag) Then
                    d4.Tag = Val(c4.Tag) + Val(d4.Tag)
                    c4.Tag = "0"
                    x += 1
                    score.Text += (Val(c4.Tag) + Val(d4.Tag))
                ElseIf d4.Tag = "0" Then
                    d4.Tag = c4.Tag
                    c4.Tag = "0"
                    x += 1
                End If
                If Val(b4.Tag) = Val(c4.Tag) Then
                    c4.Tag = Val(b4.Tag) + Val(c4.Tag)
                    b4.Tag = "0"
                    x += 1
                    score.Text += (Val(b4.Tag) + Val(c4.Tag))
                ElseIf c4.Tag = "0" Then
                    If Val(b4.Tag) = Val(d4.Tag) Then
                        d4.Tag = Val(d4.Tag) + Val(b4.Tag)
                        b4.Tag = "0"
                        x += 1
                        score.Text += (Val(d4.Tag) + Val(b4.Tag))
                    Else
                        If d4.Tag = "0" Then
                            d4.Tag = b4.Tag
                            b4.Tag = "0"
                            x += 1
                        Else
                            c4.Tag = b4.Tag
                            b4.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(a4.Tag) = Val(b4.Tag) Then
                    b4.Tag = Val(a4.Tag) + Val(b4.Tag)
                    a4.Tag = "0"
                    x += 1
                    score.Text += (Val(a4.Tag) + Val(b4.Tag))
                Else
                    If b4.Tag = "0" Then
                        If Val(a4.Tag) = Val(c4.Tag) Then
                            c4.Tag = Val(a4.Tag) + Val(c4.Tag)
                            a4.Tag = "0"
                            x += 1
                            score.Text += (Val(a4.Tag) + Val(c4.Tag))
                        Else
                            If c4.Tag = "0" Then
                                If Val(a4.Tag) = Val(d4.Tag) Then
                                    d4.Tag = Val(a4.Tag) + Val(d4.Tag)
                                    a4.Tag = "0"
                                    x += 1
                                    score.Text += (Val(a4.Tag) + Val(d4.Tag))
                                Else
                                    If d4.Tag = "0" Then
                                        d4.Tag = a4.Tag
                                        a4.Tag = "0"
                                        x += 1
                                    Else
                                        c4.Tag = a4.Tag
                                        a4.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                b4.Tag = a4.Tag
                                a4.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Make New Tile if possible
                If x > 0 Then
                    Create_Tile()
                End If
            ElseIf e.KeyCode = Keys.Left Then
                Dim x As Integer = 0
                'Row 1
                If Val(a1.Tag) = Val(a2.Tag) Then
                    a1.Tag = Val(a1.Tag) + Val(a2.Tag)
                    a2.Tag = "0"
                    x += 1
                    score.Text += (Val(a1.Tag) + Val(a2.Tag))
                ElseIf a1.Tag = "0" Then
                    a1.Tag = a2.Tag
                    a2.Tag = "0"
                    x += 1
                End If
                If Val(a2.Tag) = Val(a3.Tag) Then
                    a2.Tag = Val(a2.Tag) + Val(a3.Tag)
                    a3.Tag = "0"
                    x += 1
                    score.Text += (Val(a2.Tag) + Val(a3.Tag))
                ElseIf a2.Tag = "0" Then
                    If Val(a1.Tag) = Val(a3.Tag) Then
                        a1.Tag = Val(a1.Tag) + Val(a3.Tag)
                        a3.Tag = "0"
                        x += 1
                        score.Text += (Val(a1.Tag) + Val(a3.Tag))
                    Else
                        If a1.Tag = "0" Then
                            a1.Tag = a3.Tag
                            a3.Tag = "0"
                            x += 1
                        Else
                            a2.Tag = a3.Tag
                            a3.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(a3.Tag) = Val(a4.Tag) Then
                    a3.Tag = Val(a3.Tag) + Val(a4.Tag)
                    a4.Tag = "0"
                    x += 1
                    score.Text += (Val(a3.Tag) + Val(a4.Tag))
                Else
                    If a3.Tag = "0" Then
                        If Val(a2.Tag) = Val(a4.Tag) Then
                            a2.Tag = Val(a2.Tag) + Val(a4.Tag)
                            a4.Tag = "0"
                            x += 1
                            score.Text += (Val(a2.Tag) + Val(a4.Tag))
                        Else
                            If a2.Tag = "0" Then
                                If Val(a1.Tag) = Val(a4.Tag) Then
                                    a1.Tag = Val(a1.Tag) + Val(a4.Tag)
                                    a4.Tag = "0"
                                    x += 1
                                    score.Text += (Val(a1.Tag) + Val(a4.Tag))
                                Else
                                    If a1.Tag = "0" Then
                                        a1.Tag = a4.Tag
                                        a4.Tag = "0"
                                        x += 1
                                    Else
                                        a2.Tag = a4.Tag
                                        a4.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                a3.Tag = a4.Tag
                                a4.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 2
                If Val(b1.Tag) = Val(b2.Tag) Then
                    b1.Tag = Val(b1.Tag) + Val(b2.Tag)
                    b2.Tag = "0"
                    x += 1
                    score.Text += (Val(b1.Tag) + Val(b2.Tag))
                ElseIf b1.Tag = "0" Then
                    b1.Tag = b2.Tag
                    b2.Tag = "0"
                    x += 1
                End If
                If Val(b2.Tag) = Val(b3.Tag) Then
                    b2.Tag = Val(b2.Tag) + Val(b3.Tag)
                    b3.Tag = "0"
                    x += 1
                    score.Text += (Val(b2.Tag) + Val(b3.Tag))
                ElseIf b2.Tag = "0" Then
                    If Val(b1.Tag) = Val(b3.Tag) Then
                        b1.Tag = Val(b1.Tag) + Val(b3.Tag)
                        b3.Tag = "0"
                        x += 1
                        score.Text += (Val(b1.Tag) + Val(b3.Tag))
                    Else
                        If b1.Tag = "0" Then
                            b1.Tag = b3.Tag
                            b3.Tag = "0"
                            x += 1
                        Else
                            b2.Tag = b3.Tag
                            b3.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(b3.Tag) = Val(b4.Tag) Then
                    b3.Tag = Val(b3.Tag) + Val(b4.Tag)
                    b4.Tag = "0"
                    x += 1
                    score.Text += (Val(b3.Tag) + Val(b4.Tag))
                Else
                    If b3.Tag = "0" Then
                        If Val(b2.Tag) = Val(b4.Tag) Then
                            b2.Tag = Val(b2.Tag) + Val(b4.Tag)
                            b4.Tag = "0"
                            x += 1
                            score.Text += (Val(b2.Tag) + Val(b4.Tag))
                        Else
                            If b2.Tag = "0" Then
                                If Val(b1.Tag) = Val(b4.Tag) Then
                                    b1.Tag = Val(b1.Tag) + Val(b4.Tag)
                                    b4.Tag = "0"
                                    x += 1
                                    score.Text += (Val(b1.Tag) + Val(b4.Tag))
                                Else
                                    If b1.Tag = "0" Then
                                        b1.Tag = b4.Tag
                                        b4.Tag = "0"
                                        x += 1
                                    Else
                                        b2.Tag = b4.Tag
                                        b4.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                b3.Tag = b4.Tag
                                b4.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 3
                If Val(c1.Tag) = Val(c2.Tag) Then
                    c1.Tag = Val(c1.Tag) + Val(c2.Tag)
                    c2.Tag = "0"
                    x += 1
                    score.Text += (Val(c1.Tag) + Val(c2.Tag))
                ElseIf c1.Tag = "0" Then
                    c1.Tag = c2.Tag
                    c2.Tag = "0"
                    x += 1
                End If
                If Val(c2.Tag) = Val(c3.Tag) Then
                    c2.Tag = Val(c2.Tag) + Val(c3.Tag)
                    c3.Tag = "0"
                    x += 1
                    score.Text += (Val(c2.Tag) + Val(c3.Tag))
                ElseIf c2.Tag = "0" Then
                    If Val(c1.Tag) = Val(c3.Tag) Then
                        c1.Tag = Val(c1.Tag) + Val(c3.Tag)
                        c3.Tag = "0"
                        x += 1
                        score.Text += (Val(c1.Tag) + Val(c3.Tag))
                    Else
                        If c1.Tag = "0" Then
                            c1.Tag = c3.Tag
                            c3.Tag = "0"
                            x += 1
                        Else
                            c2.Tag = c3.Tag
                            c3.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(c3.Tag) = Val(c4.Tag) Then
                    c3.Tag = Val(c3.Tag) + Val(c4.Tag)
                    c4.Tag = "0"
                    x += 1
                    score.Text += (Val(c3.Tag) + Val(c4.Tag))
                Else
                    If c3.Tag = "0" Then
                        If Val(c2.Tag) = Val(c4.Tag) Then
                            c2.Tag = Val(c2.Tag) + Val(c4.Tag)
                            c4.Tag = "0"
                            x += 1
                            score.Text += (Val(c2.Tag) + Val(c4.Tag))
                        Else
                            If c2.Tag = "0" Then
                                If Val(c1.Tag) = Val(c4.Tag) Then
                                    c1.Tag = Val(c1.Tag) + Val(c4.Tag)
                                    c4.Tag = "0"
                                    x += 1
                                    score.Text += (Val(c1.Tag) + Val(c4.Tag))
                                Else
                                    If c1.Tag = "0" Then
                                        c1.Tag = c4.Tag
                                        c4.Tag = "0"
                                        x += 1
                                    Else
                                        c2.Tag = c4.Tag
                                        c4.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                c3.Tag = c4.Tag
                                c4.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 4
                If Val(d1.Tag) = Val(d2.Tag) Then
                    d1.Tag = Val(d1.Tag) + Val(d2.Tag)
                    d2.Tag = "0"
                    x += 1
                    score.Text += (Val(d1.Tag) + Val(d2.Tag))
                ElseIf d1.Tag = "0" Then
                    d1.Tag = d2.Tag
                    d2.Tag = "0"
                    x += 1
                End If
                If Val(d2.Tag) = Val(d3.Tag) Then
                    d2.Tag = Val(d2.Tag) + Val(d3.Tag)
                    d3.Tag = "0"
                    x += 1
                    score.Text += (Val(d2.Tag) + Val(d3.Tag))
                ElseIf d2.Tag = "0" Then
                    If Val(d1.Tag) = Val(d3.Tag) Then
                        d1.Tag = Val(d1.Tag) + Val(d3.Tag)
                        d3.Tag = "0"
                        x += 1
                        score.Text += (Val(d1.Tag) + Val(d3.Tag))
                    Else
                        If d1.Tag = "0" Then
                            d1.Tag = d3.Tag
                            d3.Tag = "0"
                            x += 1
                        Else
                            d2.Tag = d3.Tag
                            d3.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(d3.Tag) = Val(d4.Tag) Then
                    d3.Tag = Val(d3.Tag) + Val(d4.Tag)
                    d4.Tag = "0"
                    x += 1
                    score.Text += (Val(d3.Tag) + Val(d4.Tag))
                Else
                    If d3.Tag = "0" Then
                        If Val(d2.Tag) = Val(d4.Tag) Then
                            d2.Tag = Val(d2.Tag) + Val(d4.Tag)
                            d4.Tag = "0"
                            x += 1
                            score.Text += (Val(d2.Tag) + Val(d4.Tag))
                        Else
                            If d2.Tag = "0" Then
                                If Val(d1.Tag) = Val(d4.Tag) Then
                                    d1.Tag = Val(d1.Tag) + Val(d4.Tag)
                                    d4.Tag = "0"
                                    x += 1
                                    score.Text += (Val(d1.Tag) + Val(d4.Tag))
                                Else
                                    If d1.Tag = "0" Then
                                        d1.Tag = d4.Tag
                                        d4.Tag = "0"
                                        x += 1
                                    Else
                                        d2.Tag = d4.Tag
                                        d4.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                d3.Tag = d4.Tag
                                d4.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Make New Tile if possible
                If x > 0 Then
                    Create_Tile()
                End If
            ElseIf e.KeyCode = Keys.Right Then
                Dim x As Integer = 0
                'Row 1
                If Val(a4.Tag) = Val(a3.Tag) Then
                    a4.Tag = Val(a4.Tag) + Val(a3.Tag)
                    a3.Tag = "0"
                    x += 1
                    score.Text += (Val(a4.Tag) + Val(a3.Tag))
                ElseIf a4.Tag = "0" Then
                    a4.Tag = a3.Tag
                    a3.Tag = "0"
                    x += 1
                End If
                If Val(a2.Tag) = Val(a3.Tag) Then
                    a3.Tag = Val(a2.Tag) + Val(a3.Tag)
                    a2.Tag = "0"
                    x += 1
                    score.Text += (Val(a2.Tag) + Val(a3.Tag))
                ElseIf a3.Tag = "0" Then
                    If Val(a2.Tag) = Val(a4.Tag) Then
                        a4.Tag = Val(a4.Tag) + Val(a2.Tag)
                        a2.Tag = "0"
                        x += 1
                        score.Text += (Val(a4.Tag) + Val(a2.Tag))
                    Else
                        If a4.Tag = "0" Then
                            a4.Tag = a2.Tag
                            a2.Tag = "0"
                            x += 1
                        Else
                            a3.Tag = a2.Tag
                            a2.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(a1.Tag) = Val(a2.Tag) Then
                    a2.Tag = Val(a2.Tag) + Val(a1.Tag)
                    a1.Tag = "0"
                    x += 1
                    score.Text += (Val(a2.Tag) + Val(a1.Tag))
                Else
                    If a2.Tag = "0" Then
                        If Val(a1.Tag) = Val(a3.Tag) Then
                            a3.Tag = Val(a3.Tag) + Val(a1.Tag)
                            a1.Tag = "0"
                            x += 1
                            score.Text += (Val(a3.Tag) + Val(a1.Tag))
                        Else
                            If a3.Tag = "0" Then
                                If Val(a1.Tag) = Val(a4.Tag) Then
                                    a4.Tag = Val(a1.Tag) + Val(a4.Tag)
                                    a1.Tag = "0"
                                    x += 1
                                    score.Text += (Val(a1.Tag) + Val(a4.Tag))
                                Else
                                    If a4.Tag = "0" Then
                                        a4.Tag = a1.Tag
                                        a1.Tag = "0"
                                        x += 1
                                    Else
                                        a3.Tag = a1.Tag
                                        a1.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                a2.Tag = a1.Tag
                                a1.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 2
                If Val(b4.Tag) = Val(b3.Tag) Then
                    b4.Tag = Val(b4.Tag) + Val(b3.Tag)
                    b3.Tag = "0"
                    x += 1
                    score.Text += (Val(b4.Tag) + Val(b3.Tag))
                ElseIf b4.Tag = "0" Then
                    b4.Tag = b3.Tag
                    b3.Tag = "0"
                    x += 1
                End If
                If Val(b2.Tag) = Val(b3.Tag) Then
                    b3.Tag = Val(b2.Tag) + Val(b3.Tag)
                    b2.Tag = "0"
                    x += 1
                    score.Text += (Val(b2.Tag) + Val(b3.Tag))
                ElseIf b3.Tag = "0" Then
                    If Val(b2.Tag) = Val(b4.Tag) Then
                        b4.Tag = Val(b4.Tag) + Val(b2.Tag)
                        b2.Tag = "0"
                        x += 1
                        score.Text += (Val(b4.Tag) + Val(b2.Tag))
                    Else
                        If b4.Tag = "0" Then
                            b4.Tag = b2.Tag
                            b2.Tag = "0"
                            x += 1
                        Else
                            b3.Tag = b2.Tag
                            b2.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(b1.Tag) = Val(b2.Tag) Then
                    b2.Tag = Val(b2.Tag) + Val(b1.Tag)
                    b1.Tag = "0"
                    x += 1
                    score.Text += (Val(b1.Tag) + Val(b2.Tag))
                Else
                    If b2.Tag = "0" Then
                        If Val(b1.Tag) = Val(b3.Tag) Then
                            b3.Tag = Val(b3.Tag) + Val(b1.Tag)
                            b1.Tag = "0"
                            x += 1
                            score.Text += (Val(b3.Tag) + Val(b1.Tag))
                        Else
                            If b3.Tag = "0" Then
                                If Val(b1.Tag) = Val(b4.Tag) Then
                                    b4.Tag = Val(b1.Tag) + Val(b4.Tag)
                                    b1.Tag = "0"
                                    x += 1
                                    score.Text += (Val(b1.Tag) + Val(b4.Tag))
                                Else
                                    If b4.Tag = "0" Then
                                        b4.Tag = b1.Tag
                                        b1.Tag = "0"
                                        x += 1
                                    Else
                                        b3.Tag = b1.Tag
                                        b1.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                b2.Tag = b1.Tag
                                b1.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 3
                If Val(c4.Tag) = Val(c3.Tag) Then
                    c4.Tag = Val(c4.Tag) + Val(c3.Tag)
                    c3.Tag = "0"
                    x += 1
                    score.Text += (Val(c4.Tag) + Val(c3.Tag))
                ElseIf c4.Tag = "0" Then
                    c4.Tag = c3.Tag
                    c3.Tag = "0"
                    x += 1
                End If
                If Val(c2.Tag) = Val(c3.Tag) Then
                    c3.Tag = Val(c2.Tag) + Val(c3.Tag)
                    c2.Tag = "0"
                    x += 1
                    score.Text += (Val(c2.Tag) + Val(c3.Tag))
                ElseIf c3.Tag = "0" Then
                    If Val(c2.Tag) = Val(c4.Tag) Then
                        c4.Tag = Val(c4.Tag) + Val(c2.Tag)
                        c2.Tag = "0"
                        x += 1
                        score.Text += (Val(c4.Tag) + Val(c2.Tag))
                    Else
                        If c4.Tag = "0" Then
                            c4.Tag = c2.Tag
                            c2.Tag = "0"
                            x += 1
                        Else
                            c3.Tag = c2.Tag
                            c2.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(c1.Tag) = Val(c2.Tag) Then
                    c2.Tag = Val(c2.Tag) + Val(c1.Tag)
                    c1.Tag = "0"
                    x += 1
                    score.Text += (Val(c2.Tag) + Val(c1.Tag))
                Else
                    If c2.Tag = "0" Then
                        If Val(c1.Tag) = Val(c3.Tag) Then
                            c3.Tag = Val(c3.Tag) + Val(c1.Tag)
                            c1.Tag = "0"
                            x += 1
                            score.Text += (Val(c3.Tag) + Val(c1.Tag))
                        Else
                            If c3.Tag = "0" Then
                                If Val(c1.Tag) = Val(c4.Tag) Then
                                    c4.Tag = Val(c1.Tag) + Val(c4.Tag)
                                    c1.Tag = "0"
                                    x += 1
                                    score.Text += (Val(c1.Tag) + Val(c4.Tag))
                                Else
                                    If c4.Tag = "0" Then
                                        c4.Tag = c1.Tag
                                        c1.Tag = "0"
                                        x += 1
                                    Else
                                        c3.Tag = c1.Tag
                                        c1.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                c2.Tag = c1.Tag
                                c1.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Row 4
                If Val(d4.Tag) = Val(d3.Tag) Then
                    d4.Tag = Val(d4.Tag) + Val(d3.Tag)
                    d3.Tag = "0"
                    x += 1
                    score.Text += (Val(d4.Tag) + Val(d3.Tag))
                ElseIf d4.Tag = "0" Then
                    d4.Tag = d3.Tag
                    d3.Tag = "0"
                    x += 1
                End If
                If Val(d2.Tag) = Val(d3.Tag) Then
                    d3.Tag = Val(d2.Tag) + Val(d3.Tag)
                    d2.Tag = "0"
                    x += 1
                    score.Text += (Val(d2.Tag) + Val(d3.Tag))
                ElseIf d3.Tag = "0" Then
                    If Val(d2.Tag) = Val(d4.Tag) Then
                        d4.Tag = Val(d4.Tag) + Val(d2.Tag)
                        d2.Tag = "0"
                        x += 1
                        score.Text += (Val(d4.Tag) + Val(d2.Tag))
                    Else
                        If d4.Tag = "0" Then
                            d4.Tag = d2.Tag
                            d2.Tag = "0"
                            x += 1
                        Else
                            d3.Tag = d2.Tag
                            d2.Tag = "0"
                            x += 1
                        End If
                    End If
                End If
                If Val(d1.Tag) = Val(d2.Tag) Then
                    d2.Tag = Val(d2.Tag) + Val(d1.Tag)
                    d1.Tag = "0"
                    x += 1
                    score.Text += (Val(d2.Tag) + Val(d1.Tag))
                Else
                    If d2.Tag = "0" Then
                        If Val(d1.Tag) = Val(d3.Tag) Then
                            d3.Tag = Val(d3.Tag) + Val(d1.Tag)
                            d1.Tag = "0"
                            x += 1
                            score.Text += (Val(d3.Tag) + Val(d1.Tag))
                        Else
                            If d3.Tag = "0" Then
                                If Val(d1.Tag) = Val(d4.Tag) Then
                                    d4.Tag = Val(d1.Tag) + Val(d4.Tag)
                                    d1.Tag = "0"
                                    x += 1
                                    score.Text += (Val(d1.Tag) + Val(d4.Tag))
                                Else
                                    If d4.Tag = "0" Then
                                        d4.Tag = d1.Tag
                                        d1.Tag = "0"
                                        x += 1
                                    Else
                                        d3.Tag = d1.Tag
                                        d1.Tag = "0"
                                        x += 1
                                    End If
                                End If
                            Else
                                d2.Tag = d1.Tag
                                d1.Tag = "0"
                                x += 1
                            End If
                        End If
                    End If
                End If
                'Make New Tile if possible
                If x > 0 Then
                    Create_Tile()
                End If
            End If
        End If
    End Sub

    Private Sub Create_Tile()
        Dim i As Integer = 0
        Dim r As Integer = CInt(Int(Rnd() * 4) + 0)
        Dim op As Integer = CInt(Int(Rnd() * 2) + 0)
        Dim limit As Boolean = False
        Do Until limit = True
            For Each obj As Object In Me.Panel1.Controls
                If obj.GetType Is GetType(Button) Then
                    Dim btn = DirectCast(obj, Button)
                    If btn.Tag = "0" Then
                        If limit = False Then
                            If i = r Then
                                If op = 1 Then
                                    btn.Tag = "2"
                                Else
                                    btn.Tag = "4"
                                End If
                                limit = True
                            Else
                                i += 1
                            End If
                        End If
                    End If
                End If
            Next
        Loop
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        Me.KeyPreview = True
        best.Text = My.Settings.best
        Dim limit As Boolean = False
        Dim r As Integer
        r = CInt(Int(Rnd() * 16) + 0)
        Dim i As Integer = 0
        For Each obj As Object In Me.Panel1.Controls
            If obj.GetType Is GetType(Button) Then
                DirectCast(obj, Button).FlatAppearance.BorderColor = DirectCast(obj, Button).BackColor
                If limit = False Then
                    If i = r Then
                        limit = True
                        Dim rn As Integer
                        rn = CInt(Int(Rnd() * 2) + 0)
                        If rn = 0 Then
                            DirectCast(obj, Button).Tag = "2"
                        Else
                            DirectCast(obj, Button).Tag = "4"
                        End If
                    Else
                        i += 1
                    End If
                End If
            End If
        Next
        Dim a As Integer
        Do While a = r
            a = CInt(Int(Rnd() * 16) + 0)
        Loop
        Dim n As Integer = 0
        limit = False
        For Each obj As Object In Me.Panel1.Controls
            If obj.GetType Is GetType(Button) Then
                If limit = False Then
                    If n = a Then
                        limit = True
                        Dim rn As Integer
                        rn = CInt(Int(Rnd() * 2) + 0)
                        If rn = 0 Then
                            DirectCast(obj, Button).Tag = "2"
                        Else
                            DirectCast(obj, Button).Tag = "4"
                        End If
                    Else
                        n += 1
                    End If
                End If
            End If
        Next
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim x As Integer = 0
        For Each obj As Object In Me.Panel1.Controls
            If obj.GetType = GetType(Button) Then
                Dim btn = DirectCast(obj, Button)
                If btn.Tag = "0" Then
                    btn.BackgroundImage = i0.BackgroundImage
                ElseIf btn.Tag = "2" Then
                    btn.BackgroundImage = i2.BackgroundImage
                ElseIf btn.Tag = "4" Then
                    btn.BackgroundImage = i4.BackgroundImage
                ElseIf btn.Tag = "8" Then
                    btn.BackgroundImage = i8.BackgroundImage
                ElseIf btn.Tag = "16" Then
                    btn.BackgroundImage = i16.BackgroundImage
                ElseIf btn.Tag = "32" Then
                    btn.BackgroundImage = i32.BackgroundImage
                ElseIf btn.Tag = "64" Then
                    btn.BackgroundImage = i64.BackgroundImage
                ElseIf btn.Tag = "128" Then
                    btn.BackgroundImage = i128.BackgroundImage
                ElseIf btn.Tag = "256" Then
                    btn.BackgroundImage = i256.BackgroundImage
                ElseIf btn.Tag = "512" Then
                    btn.BackgroundImage = i512.BackgroundImage
                ElseIf btn.Tag = "1024" Then
                    btn.BackgroundImage = i1024.BackgroundImage
                ElseIf btn.Tag = "2048" Then
                    btn.BackgroundImage = i2048.BackgroundImage
                ElseIf btn.Tag = "4096" Then
                    btn.BackgroundImage = i4096.BackgroundImage
                ElseIf btn.Tag = "8192" Then
                    btn.BackgroundImage = i8192.BackgroundImage
                ElseIf btn.Tag = "16384" Then
                    btn.BackgroundImage = i16384.BackgroundImage
                ElseIf btn.Tag = "32768" Then
                    btn.BackgroundImage = i32768.BackgroundImage
                ElseIf btn.Tag = "65536" Then
                    btn.BackgroundImage = i65536.BackgroundImage
                ElseIf btn.Tag = "131072" Then
                    btn.BackgroundImage = i131072.BackgroundImage
                End If
            End If
        Next
        If x = 25 Then
            a1.Tag = "2"
            a2.Tag = "2"
        ElseIf x = 24 Then
            If a1.Tag = "" Then
                a1.Tag = "2"
            Else
                a2.Tag = "2"
            End If
        End If
    End Sub

    Private Sub newgame_Click(sender As Object, e As EventArgs) Handles newgame.Click
        new_game()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For Each obj As Object In Me.Panel1.Controls
            If obj.GetType Is GetType(Button) Then
                If DirectCast(obj, Button).Tag = "2048" Then
                    Timer2.Stop()
                    pause = True
                    newgame.Visible = False
                    Panel4.Location = Panel1.Location
                End If
            End If
        Next
    End Sub

    Private Sub new_game()
        For Each obj As Object In Me.Panel1.Controls
            If obj.GetType = GetType(Button) Then
                DirectCast(obj, Button).Tag = "0"
            End If
        Next
        Dim limit As Boolean = False
        Dim r As Integer = New Random().Next(0, 16)
        Dim i As Integer = 0
        For Each obj As Object In Me.Panel1.Controls
            If obj.GetType = GetType(Button) Then
                If limit = False Then
                    If i = r Then
                        limit = True
                        Dim rn As Integer = New Random().Next(0, 2)
                        If rn = 0 Then
                            DirectCast(obj, Button).Tag = "2"
                        Else
                            DirectCast(obj, Button).Tag = "4"
                        End If
                    Else
                        i += 1
                    End If
                End If
            End If
        Next
        Dim a As Integer = 0
        Do
            a = New Random().Next(0, 16)
        Loop While a = r
        Dim n As Integer = 0
        limit = False
        For Each obj As Object In Me.Panel1.Controls
            If obj.GetType = GetType(Button) Then
                If limit = False Then
                    If n = a Then
                        limit = True
                        Dim rn As Integer = New Random().Next(0, 2)
                        If rn = 0 Then
                            DirectCast(obj, Button).Tag = "2"
                        Else
                            DirectCast(obj, Button).Tag = "4"
                        End If
                    Else
                        n += 1
                    End If
                End If
            End If
        Next
        Timer2.Start()
    End Sub

    Private Sub tryag_Click(sender As Object, e As EventArgs) Handles tryag.Click
        new_game()
    End Sub

    Private Sub conti_Click(sender As Object, e As EventArgs) Handles conti.Click
        pause = False
        newgame.Visible = True
        Panel4.Location = New Point(754, 12)
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Val(score.Text) > Val(best.Text) Then
            best.Text = score.Text
        End If
        If My.Settings.best < Val(best.Text) Then
            My.Settings.best = best.Text
        End If
        sc.Left = (Panel2.Width / 2) - (sc.Width / 2)
        score.Left = (Panel2.Width / 2) - (score.Width / 2)
        be.Left = (Panel3.Width / 2) - (be.Width / 2)
        best.Left = (Panel3.Width / 2) - (best.Width / 2)
    End Sub
End Class

Public Class TransparentGroupBox
    Inherits GroupBox

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.BackColor = Color.FromArgb(0, Me.BackColor)
    End Sub

    Protected Overrides ReadOnly Property CreateParams() As System.Windows.Forms.CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = &H20
            Return cp
        End Get
    End Property
End Class
