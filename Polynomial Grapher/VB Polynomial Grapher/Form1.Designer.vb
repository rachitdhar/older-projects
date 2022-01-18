<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PolyGraph
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c5 = New System.Windows.Forms.TextBox()
        Me.c4 = New System.Windows.Forms.TextBox()
        Me.c3 = New System.Windows.Forms.TextBox()
        Me.c2 = New System.Windows.Forms.TextBox()
        Me.c1 = New System.Windows.Forms.TextBox()
        Me.c0 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Graph = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.adjusty = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.adjustx = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pow5 = New System.Windows.Forms.TextBox()
        Me.pow4 = New System.Windows.Forms.TextBox()
        Me.pow3 = New System.Windows.Forms.TextBox()
        Me.pow2 = New System.Windows.Forms.TextBox()
        Me.pow1 = New System.Windows.Forms.TextBox()
        Me.pow0 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.colourline = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(135, 667)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Coefficients:"
        '
        'c5
        '
        Me.c5.Location = New System.Drawing.Point(206, 664)
        Me.c5.Name = "c5"
        Me.c5.Size = New System.Drawing.Size(46, 20)
        Me.c5.TabIndex = 1
        Me.c5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c4
        '
        Me.c4.Location = New System.Drawing.Point(258, 664)
        Me.c4.Name = "c4"
        Me.c4.Size = New System.Drawing.Size(46, 20)
        Me.c4.TabIndex = 2
        Me.c4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c3
        '
        Me.c3.Location = New System.Drawing.Point(310, 664)
        Me.c3.Name = "c3"
        Me.c3.Size = New System.Drawing.Size(46, 20)
        Me.c3.TabIndex = 3
        Me.c3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c2
        '
        Me.c2.Location = New System.Drawing.Point(362, 664)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(46, 20)
        Me.c2.TabIndex = 4
        Me.c2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c1
        '
        Me.c1.Location = New System.Drawing.Point(414, 664)
        Me.c1.Name = "c1"
        Me.c1.Size = New System.Drawing.Size(46, 20)
        Me.c1.TabIndex = 5
        Me.c1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'c0
        '
        Me.c0.Location = New System.Drawing.Point(466, 664)
        Me.c0.Name = "c0"
        Me.c0.Size = New System.Drawing.Size(46, 20)
        Me.c0.TabIndex = 6
        Me.c0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 641)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Power of x:"
        '
        'Graph
        '
        Me.Graph.Location = New System.Drawing.Point(152, 691)
        Me.Graph.Name = "Graph"
        Me.Graph.Size = New System.Drawing.Size(75, 23)
        Me.Graph.TabIndex = 13
        Me.Graph.Text = "Graph"
        Me.Graph.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(338, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Y"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(633, 330)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "X"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(233, 696)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Adjust y axis scale: "
        '
        'adjusty
        '
        Me.adjusty.Location = New System.Drawing.Point(338, 693)
        Me.adjusty.Name = "adjusty"
        Me.adjusty.Size = New System.Drawing.Size(48, 20)
        Me.adjusty.TabIndex = 17
        Me.adjusty.Text = "1"
        Me.adjusty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(392, 696)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "times"
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(152, 717)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(75, 23)
        Me.Clear.TabIndex = 19
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(392, 722)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "times"
        '
        'adjustx
        '
        Me.adjustx.Location = New System.Drawing.Point(338, 719)
        Me.adjustx.Name = "adjustx"
        Me.adjustx.Size = New System.Drawing.Size(48, 20)
        Me.adjustx.TabIndex = 21
        Me.adjustx.Text = "1"
        Me.adjustx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(233, 722)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Adjust x axis scale: "
        '
        'pow5
        '
        Me.pow5.Location = New System.Drawing.Point(218, 638)
        Me.pow5.Name = "pow5"
        Me.pow5.Size = New System.Drawing.Size(34, 20)
        Me.pow5.TabIndex = 23
        Me.pow5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pow4
        '
        Me.pow4.Location = New System.Drawing.Point(270, 638)
        Me.pow4.Name = "pow4"
        Me.pow4.Size = New System.Drawing.Size(34, 20)
        Me.pow4.TabIndex = 24
        Me.pow4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pow3
        '
        Me.pow3.Location = New System.Drawing.Point(322, 638)
        Me.pow3.Name = "pow3"
        Me.pow3.Size = New System.Drawing.Size(34, 20)
        Me.pow3.TabIndex = 25
        Me.pow3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pow2
        '
        Me.pow2.Location = New System.Drawing.Point(374, 638)
        Me.pow2.Name = "pow2"
        Me.pow2.Size = New System.Drawing.Size(34, 20)
        Me.pow2.TabIndex = 26
        Me.pow2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pow1
        '
        Me.pow1.Location = New System.Drawing.Point(426, 638)
        Me.pow1.Name = "pow1"
        Me.pow1.Size = New System.Drawing.Size(34, 20)
        Me.pow1.TabIndex = 27
        Me.pow1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pow0
        '
        Me.pow0.Location = New System.Drawing.Point(478, 638)
        Me.pow0.Name = "pow0"
        Me.pow0.Size = New System.Drawing.Size(34, 20)
        Me.pow0.TabIndex = 28
        Me.pow0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(451, 696)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Colour:"
        '
        'colourline
        '
        Me.colourline.FormattingEnabled = True
        Me.colourline.Items.AddRange(New Object() {"Red", "Blue", "Green", "Black", "Violet", "Yellow", "Cyan", "Pink", "Gray", "Orange"})
        Me.colourline.Location = New System.Drawing.Point(432, 718)
        Me.colourline.Name = "colourline"
        Me.colourline.Size = New System.Drawing.Size(81, 21)
        Me.colourline.TabIndex = 30
        Me.colourline.Text = "Red"
        '
        'PolyGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 749)
        Me.Controls.Add(Me.colourline)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pow0)
        Me.Controls.Add(Me.pow1)
        Me.Controls.Add(Me.pow2)
        Me.Controls.Add(Me.pow3)
        Me.Controls.Add(Me.pow4)
        Me.Controls.Add(Me.pow5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.adjustx)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.adjusty)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Graph)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.c0)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.c2)
        Me.Controls.Add(Me.c3)
        Me.Controls.Add(Me.c4)
        Me.Controls.Add(Me.c5)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "PolyGraph"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Polynomial (and Related Functions) Grapher"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents c5 As TextBox
    Friend WithEvents c4 As TextBox
    Friend WithEvents c3 As TextBox
    Friend WithEvents c2 As TextBox
    Friend WithEvents c1 As TextBox
    Friend WithEvents c0 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Graph As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents adjusty As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Clear As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents adjustx As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents pow5 As TextBox
    Friend WithEvents pow4 As TextBox
    Friend WithEvents pow3 As TextBox
    Friend WithEvents pow2 As TextBox
    Friend WithEvents pow1 As TextBox
    Friend WithEvents pow0 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents colourline As ComboBox
End Class
