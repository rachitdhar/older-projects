<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.wall = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.smBox = New System.Windows.Forms.Button()
        Me.bgBox = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mass = New System.Windows.Forms.TextBox()
        Me.startbtn = New System.Windows.Forms.Button()
        Me.stopbtn = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.collisions = New System.Windows.Forms.Label()
        Me.bgspeed = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'wall
        '
        Me.wall.BackColor = System.Drawing.Color.SteelBlue
        Me.wall.Location = New System.Drawing.Point(-62, 12)
        Me.wall.Name = "wall"
        Me.wall.Size = New System.Drawing.Size(129, 301)
        Me.wall.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel2.Location = New System.Drawing.Point(64, 263)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(735, 50)
        Me.Panel2.TabIndex = 1
        '
        'smBox
        '
        Me.smBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.smBox.Location = New System.Drawing.Point(200, 222)
        Me.smBox.Name = "smBox"
        Me.smBox.Size = New System.Drawing.Size(46, 42)
        Me.smBox.TabIndex = 2
        Me.smBox.UseVisualStyleBackColor = False
        '
        'bgBox
        '
        Me.bgBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bgBox.Location = New System.Drawing.Point(400, 195)
        Me.bgBox.Name = "bgBox"
        Me.bgBox.Size = New System.Drawing.Size(75, 69)
        Me.bgBox.TabIndex = 3
        Me.bgBox.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(539, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Mass Of Large Block: "
        '
        'mass
        '
        Me.mass.Location = New System.Drawing.Point(648, 19)
        Me.mass.Name = "mass"
        Me.mass.Size = New System.Drawing.Size(100, 20)
        Me.mass.TabIndex = 5
        Me.mass.Text = "1"
        Me.mass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'startbtn
        '
        Me.startbtn.Location = New System.Drawing.Point(542, 49)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.Size = New System.Drawing.Size(75, 23)
        Me.startbtn.TabIndex = 6
        Me.startbtn.Text = "Start"
        Me.startbtn.UseVisualStyleBackColor = True
        '
        'stopbtn
        '
        Me.stopbtn.Location = New System.Drawing.Point(623, 49)
        Me.stopbtn.Name = "stopbtn"
        Me.stopbtn.Size = New System.Drawing.Size(75, 23)
        Me.stopbtn.TabIndex = 7
        Me.stopbtn.Text = "Stop"
        Me.stopbtn.UseVisualStyleBackColor = True
        '
        'reset
        '
        Me.reset.Location = New System.Drawing.Point(704, 49)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(75, 23)
        Me.reset.TabIndex = 8
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(119, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Number of Collisions: "
        '
        'collisions
        '
        Me.collisions.AutoSize = True
        Me.collisions.ForeColor = System.Drawing.Color.White
        Me.collisions.Location = New System.Drawing.Point(233, 22)
        Me.collisions.Name = "collisions"
        Me.collisions.Size = New System.Drawing.Size(13, 13)
        Me.collisions.TabIndex = 10
        Me.collisions.Text = "0"
        '
        'bgspeed
        '
        Me.bgspeed.Location = New System.Drawing.Point(402, 19)
        Me.bgspeed.Name = "bgspeed"
        Me.bgspeed.Size = New System.Drawing.Size(100, 20)
        Me.bgspeed.TabIndex = 12
        Me.bgspeed.Text = "5"
        Me.bgspeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(278, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Speed Of Large Block: "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(797, 325)
        Me.Controls.Add(Me.bgspeed)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.collisions)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.stopbtn)
        Me.Controls.Add(Me.startbtn)
        Me.Controls.Add(Me.mass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bgBox)
        Me.Controls.Add(Me.smBox)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.wall)
        Me.Name = "Form1"
        Me.Text = "Two Block Collision System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wall As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents smBox As System.Windows.Forms.Button
    Friend WithEvents bgBox As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mass As System.Windows.Forms.TextBox
    Friend WithEvents startbtn As System.Windows.Forms.Button
    Friend WithEvents stopbtn As System.Windows.Forms.Button
    Friend WithEvents reset As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents collisions As System.Windows.Forms.Label
    Friend WithEvents bgspeed As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
