<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSnake
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSnake))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlGameArea = New System.Windows.Forms.Panel()
        Me.picFood = New System.Windows.Forms.PictureBox()
        Me.picSnakePiece = New System.Windows.Forms.PictureBox()
        Me.tmrGame = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.pnlGameArea.SuspendLayout()
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnakePiece, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.EndToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(64, 29)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'EndToolStripMenuItem
        '
        Me.EndToolStripMenuItem.Name = "EndToolStripMenuItem"
        Me.EndToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EndToolStripMenuItem.Text = "End"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(658, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Score!"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblScore.Location = New System.Drawing.Point(681, 173)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(55, 63)
        Me.lblScore.TabIndex = 2
        Me.lblScore.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(208, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(375, 63)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Classic Snake!"
        '
        'pnlGameArea
        '
        Me.pnlGameArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pnlGameArea.Controls.Add(Me.picFood)
        Me.pnlGameArea.Location = New System.Drawing.Point(12, 118)
        Me.pnlGameArea.Name = "pnlGameArea"
        Me.pnlGameArea.Size = New System.Drawing.Size(631, 320)
        Me.pnlGameArea.TabIndex = 4
        '
        'picFood
        '
        Me.picFood.Image = CType(resources.GetObject("picFood.Image"), System.Drawing.Image)
        Me.picFood.Location = New System.Drawing.Point(70, 82)
        Me.picFood.Name = "picFood"
        Me.picFood.Size = New System.Drawing.Size(34, 36)
        Me.picFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFood.TabIndex = 1
        Me.picFood.TabStop = False
        '
        'picSnakePiece
        '
        Me.picSnakePiece.Image = Global.Classic_Snake_.My.Resources.Resources.BALL
        Me.picSnakePiece.Location = New System.Drawing.Point(658, 319)
        Me.picSnakePiece.Name = "picSnakePiece"
        Me.picSnakePiece.Size = New System.Drawing.Size(35, 36)
        Me.picSnakePiece.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSnakePiece.TabIndex = 0
        Me.picSnakePiece.TabStop = False
        '
        'tmrGame
        '
        Me.tmrGame.Interval = 200
        '
        'frmSnake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlGameArea)
        Me.Controls.Add(Me.picSnakePiece)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSnake"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlGameArea.ResumeLayout(False)
        CType(Me.picFood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnakePiece, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EndToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pnlGameArea As Panel
    Friend WithEvents picSnakePiece As PictureBox
    Friend WithEvents picFood As PictureBox
    Friend WithEvents tmrGame As Timer
End Class
