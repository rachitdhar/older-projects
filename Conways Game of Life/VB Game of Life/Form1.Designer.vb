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
        Me.start_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.stop_btn = New System.Windows.Forms.Button()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gen = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'start_btn
        '
        Me.start_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.start_btn.Location = New System.Drawing.Point(24, 608)
        Me.start_btn.Name = "start_btn"
        Me.start_btn.Size = New System.Drawing.Size(150, 30)
        Me.start_btn.TabIndex = 0
        Me.start_btn.Text = "Start"
        Me.start_btn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'stop_btn
        '
        Me.stop_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stop_btn.Location = New System.Drawing.Point(182, 608)
        Me.stop_btn.Name = "stop_btn"
        Me.stop_btn.Size = New System.Drawing.Size(150, 30)
        Me.stop_btn.TabIndex = 1
        Me.stop_btn.Text = "Stop"
        Me.stop_btn.UseVisualStyleBackColor = True
        '
        'clear_btn
        '
        Me.clear_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clear_btn.Location = New System.Drawing.Point(340, 608)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(150, 30)
        Me.clear_btn.TabIndex = 2
        Me.clear_btn.Text = "Clear"
        Me.clear_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(496, 611)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Generation:"
        '
        'gen
        '
        Me.gen.AutoSize = True
        Me.gen.Font = New System.Drawing.Font("Comic Sans MS", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gen.Location = New System.Drawing.Point(595, 611)
        Me.gen.Name = "gen"
        Me.gen.Size = New System.Drawing.Size(19, 21)
        Me.gen.TabIndex = 4
        Me.gen.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 651)
        Me.Controls.Add(Me.gen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.clear_btn)
        Me.Controls.Add(Me.stop_btn)
        Me.Controls.Add(Me.start_btn)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conway's Game Of Life"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents start_btn As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents stop_btn As System.Windows.Forms.Button
    Friend WithEvents clear_btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gen As System.Windows.Forms.Label

End Class
