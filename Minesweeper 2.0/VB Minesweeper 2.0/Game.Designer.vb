<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Game))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewGameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YellowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OriginalToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PinkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WaterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GrassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LavaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrangeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumbersToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OriginalToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassicToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpecialToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DifficultyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IntermediateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpertToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HowToPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tmines = New System.Windows.Forms.TextBox()
        Me.ttime = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.b_flag = New System.Windows.Forms.Button()
        Me.non_image = New System.Windows.Forms.Button()
        Me.b_image = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.GameToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(288, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGameToolStripMenuItem, Me.RestartToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewGameToolStripMenuItem
        '
        Me.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem"
        Me.NewGameToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.NewGameToolStripMenuItem.Text = "New Game"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GameToolStripMenuItem
        '
        Me.GameToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.NumbersToolStripMenuItem1, Me.DifficultyToolStripMenuItem1, Me.RecordsToolStripMenuItem, Me.HighScoreToolStripMenuItem})
        Me.GameToolStripMenuItem.Name = "GameToolStripMenuItem"
        Me.GameToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.GameToolStripMenuItem.Text = "Game"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BlueToolStripMenuItem, Me.RedToolStripMenuItem, Me.GreenToolStripMenuItem, Me.YellowToolStripMenuItem, Me.OriginalToolStripMenuItem1, Me.SpecialToolStripMenuItem})
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.ColorToolStripMenuItem.Text = "Tiles"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'GreenToolStripMenuItem
        '
        Me.GreenToolStripMenuItem.Name = "GreenToolStripMenuItem"
        Me.GreenToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.GreenToolStripMenuItem.Text = "Green"
        '
        'YellowToolStripMenuItem
        '
        Me.YellowToolStripMenuItem.Name = "YellowToolStripMenuItem"
        Me.YellowToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.YellowToolStripMenuItem.Text = "Yellow"
        '
        'OriginalToolStripMenuItem1
        '
        Me.OriginalToolStripMenuItem1.Name = "OriginalToolStripMenuItem1"
        Me.OriginalToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.OriginalToolStripMenuItem1.Text = "Original"
        '
        'SpecialToolStripMenuItem
        '
        Me.SpecialToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PinkToolStripMenuItem, Me.WaterToolStripMenuItem, Me.GrassToolStripMenuItem, Me.LavaToolStripMenuItem, Me.OrangeToolStripMenuItem, Me.BlackToolStripMenuItem})
        Me.SpecialToolStripMenuItem.Name = "SpecialToolStripMenuItem"
        Me.SpecialToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SpecialToolStripMenuItem.Text = "Special"
        '
        'PinkToolStripMenuItem
        '
        Me.PinkToolStripMenuItem.Name = "PinkToolStripMenuItem"
        Me.PinkToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.PinkToolStripMenuItem.Text = "Rose"
        '
        'WaterToolStripMenuItem
        '
        Me.WaterToolStripMenuItem.Name = "WaterToolStripMenuItem"
        Me.WaterToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.WaterToolStripMenuItem.Text = "Water"
        '
        'GrassToolStripMenuItem
        '
        Me.GrassToolStripMenuItem.Name = "GrassToolStripMenuItem"
        Me.GrassToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.GrassToolStripMenuItem.Text = "Grass"
        '
        'LavaToolStripMenuItem
        '
        Me.LavaToolStripMenuItem.Name = "LavaToolStripMenuItem"
        Me.LavaToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.LavaToolStripMenuItem.Text = "Lava"
        '
        'OrangeToolStripMenuItem
        '
        Me.OrangeToolStripMenuItem.Name = "OrangeToolStripMenuItem"
        Me.OrangeToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.OrangeToolStripMenuItem.Text = "Sun"
        '
        'BlackToolStripMenuItem
        '
        Me.BlackToolStripMenuItem.Name = "BlackToolStripMenuItem"
        Me.BlackToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.BlackToolStripMenuItem.Text = "Dark"
        '
        'NumbersToolStripMenuItem1
        '
        Me.NumbersToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OriginalToolStripMenuItem2, Me.ClassicToolStripMenuItem1, Me.SpecialToolStripMenuItem1})
        Me.NumbersToolStripMenuItem1.Name = "NumbersToolStripMenuItem1"
        Me.NumbersToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.NumbersToolStripMenuItem1.Text = "Numbers"
        '
        'OriginalToolStripMenuItem2
        '
        Me.OriginalToolStripMenuItem2.Name = "OriginalToolStripMenuItem2"
        Me.OriginalToolStripMenuItem2.Size = New System.Drawing.Size(116, 22)
        Me.OriginalToolStripMenuItem2.Text = "Original"
        '
        'ClassicToolStripMenuItem1
        '
        Me.ClassicToolStripMenuItem1.Name = "ClassicToolStripMenuItem1"
        Me.ClassicToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.ClassicToolStripMenuItem1.Text = "Classic"
        '
        'SpecialToolStripMenuItem1
        '
        Me.SpecialToolStripMenuItem1.Name = "SpecialToolStripMenuItem1"
        Me.SpecialToolStripMenuItem1.Size = New System.Drawing.Size(116, 22)
        Me.SpecialToolStripMenuItem1.Text = "Special"
        '
        'DifficultyToolStripMenuItem1
        '
        Me.DifficultyToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EasyToolStripMenuItem, Me.IntermediateToolStripMenuItem1, Me.ExpertToolStripMenuItem1, Me.CustomToolStripMenuItem})
        Me.DifficultyToolStripMenuItem1.Name = "DifficultyToolStripMenuItem1"
        Me.DifficultyToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.DifficultyToolStripMenuItem1.Text = "Difficulty"
        '
        'EasyToolStripMenuItem
        '
        Me.EasyToolStripMenuItem.Name = "EasyToolStripMenuItem"
        Me.EasyToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.EasyToolStripMenuItem.Text = "Begginer"
        '
        'IntermediateToolStripMenuItem1
        '
        Me.IntermediateToolStripMenuItem1.Name = "IntermediateToolStripMenuItem1"
        Me.IntermediateToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.IntermediateToolStripMenuItem1.Text = "Intermediate"
        '
        'ExpertToolStripMenuItem1
        '
        Me.ExpertToolStripMenuItem1.Name = "ExpertToolStripMenuItem1"
        Me.ExpertToolStripMenuItem1.Size = New System.Drawing.Size(141, 22)
        Me.ExpertToolStripMenuItem1.Text = "Expert"
        '
        'CustomToolStripMenuItem
        '
        Me.CustomToolStripMenuItem.Name = "CustomToolStripMenuItem"
        Me.CustomToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.CustomToolStripMenuItem.Text = "Custom"
        '
        'RecordsToolStripMenuItem
        '
        Me.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem"
        Me.RecordsToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.RecordsToolStripMenuItem.Text = "Records"
        '
        'HighScoreToolStripMenuItem
        '
        Me.HighScoreToolStripMenuItem.Name = "HighScoreToolStripMenuItem"
        Me.HighScoreToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.HighScoreToolStripMenuItem.Text = "High Score"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.HowToPlayToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HowToPlayToolStripMenuItem
        '
        Me.HowToPlayToolStripMenuItem.Name = "HowToPlayToolStripMenuItem"
        Me.HowToPlayToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.HowToPlayToolStripMenuItem.Text = "How To Play"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(12, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 224)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mines"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'tmines
        '
        Me.tmines.Location = New System.Drawing.Point(73, 27)
        Me.tmines.Multiline = True
        Me.tmines.Name = "tmines"
        Me.tmines.ReadOnly = True
        Me.tmines.Size = New System.Drawing.Size(66, 20)
        Me.tmines.TabIndex = 3
        Me.tmines.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ttime
        '
        Me.ttime.Location = New System.Drawing.Point(145, 27)
        Me.ttime.Multiline = True
        Me.ttime.Name = "ttime"
        Me.ttime.ReadOnly = True
        Me.ttime.Size = New System.Drawing.Size(66, 20)
        Me.ttime.TabIndex = 4
        Me.ttime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Time"
        '
        'b_flag
        '
        Me.b_flag.BackgroundImage = CType(resources.GetObject("b_flag.BackgroundImage"), System.Drawing.Image)
        Me.b_flag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_flag.Location = New System.Drawing.Point(347, 115)
        Me.b_flag.Name = "b_flag"
        Me.b_flag.Size = New System.Drawing.Size(25, 25)
        Me.b_flag.TabIndex = 722
        Me.b_flag.UseVisualStyleBackColor = True
        Me.b_flag.Visible = False
        '
        'non_image
        '
        Me.non_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.non_image.ForeColor = System.Drawing.SystemColors.ControlText
        Me.non_image.Location = New System.Drawing.Point(347, 84)
        Me.non_image.Name = "non_image"
        Me.non_image.Size = New System.Drawing.Size(25, 25)
        Me.non_image.TabIndex = 721
        Me.non_image.UseVisualStyleBackColor = True
        Me.non_image.Visible = False
        '
        'b_image
        '
        Me.b_image.BackgroundImage = CType(resources.GetObject("b_image.BackgroundImage"), System.Drawing.Image)
        Me.b_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_image.Location = New System.Drawing.Point(347, 53)
        Me.b_image.Name = "b_image"
        Me.b_image.Size = New System.Drawing.Size(25, 25)
        Me.b_image.TabIndex = 720
        Me.b_image.UseVisualStyleBackColor = True
        Me.b_image.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Timer3
        '
        Me.Timer3.Interval = 10
        '
        'Timer4
        '
        Me.Timer4.Interval = 10
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 289)
        Me.Controls.Add(Me.b_flag)
        Me.Controls.Add(Me.non_image)
        Me.Controls.Add(Me.b_image)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ttime)
        Me.Controls.Add(Me.tmines)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Game"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minesweeper"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewGameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents YellowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OriginalToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HighScoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowToPlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumbersToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OriginalToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassicToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpecialToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DifficultyToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EasyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IntermediateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExpertToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tmines As System.Windows.Forms.TextBox
    Friend WithEvents ttime As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents b_flag As System.Windows.Forms.Button
    Friend WithEvents non_image As System.Windows.Forms.Button
    Friend WithEvents b_image As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents CustomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents SpecialToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PinkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WaterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GrassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LavaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrangeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BlackToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
