'=======================================================================
' Snake Game - frmSnake Class
' Made by Dario Gerald
' 13/11/23 9:19am
' GitHub: https://github.com/Pinkk-Flag
'=======================================================================

Public Class frmSnake

    ' Variables for movement and game state
    Dim deltaX As Integer
    Dim deltaY As Integer
    Dim SnakeLoop = 0
    Dim SnakeLength As Integer
    Dim LastX As Integer = 0
    Dim Lasty As Integer = 0
    Dim finished As Boolean
    Dim picSnake(99) As PictureBox

    ' Handles arrow key input for snake movement
    Private Sub frmSnake_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Adjusts the movement direction based on the pressed key
        If e.KeyCode = Keys.Right Then
            deltaX = 35
            deltaY = 0
        ElseIf e.KeyCode = Keys.Left Then
            deltaX = -35
            deltaY = 0
        ElseIf e.KeyCode = Keys.Up Then
            deltaY = -35
            deltaX = 0
        ElseIf e.KeyCode = Keys.Down Then
            deltaY = 35
            deltaX = 0
        End If
    End Sub

    ' Updates the game state on each timer tick
    Private Sub tmrGame_Tick(sender As Object, e As EventArgs) Handles tmrGame.Tick
        ' Stores the position of the last snake piece
        LastX = picSnake(SnakeLength - 1).Left
        Lasty = picSnake(SnakeLength - 1).Top

        ' Moves each snake piece to the position of the preceding piece
        If SnakeLength > 1 Then
            For SnakeLoop = SnakeLength - 1 To 1 Step -1
                picSnake(SnakeLoop).Left = picSnake(SnakeLoop - 1).Left
                picSnake(SnakeLoop).Top = picSnake(SnakeLoop - 1).Top
            Next SnakeLoop
        End If

        ' Moves the head of the snake based on the current direction
        picSnake(0).Left = picSnake(0).Left + deltaX
        picSnake(0).Top = picSnake(0).Top + deltaY

        ' Handles collision with food and adjusts snake length
        If Collide(picSnake(0), picFood) Then
            lblScore.Text = Val(lblScore.Text) + 1
            ' Randomly places new food within the game area
            picFood.Top = Rnd() * (pnlGameArea.Height - picFood.Height)
            picFood.Left = Rnd() * (pnlGameArea.Width - picFood.Width)
            ' Increases snake length and makes the new piece visible
            If SnakeLength <= 100 Then
                SnakeLength = SnakeLength + 1
                picSnake(SnakeLength - 1).Visible = True
                picSnake(SnakeLength - 1).Left = LastX
                picSnake(SnakeLength - 1).Top = Lasty
            End If
        End If

        ' Checks for collisions with the snake's body or game boundaries
        For SnakeLoop = SnakeLength - 1 To 1 Step -1
            If Collide(picSnake(SnakeLoop), picSnake(0)) Then
                finished = True
            End If
        Next
        If picSnake(0).Left < 0 Or picSnake(0).Left + picSnake(0).Width > pnlGameArea.Width Or
            picSnake(0).Top < 0 Or picSnake(0).Top + picSnake(0).Height > pnlGameArea.Height Then
            finished = True
        End If

        ' Ends the game if a collision occurs
        If finished Then
            tmrGame.Enabled = False
            MsgBox("Game over")
        End If
    End Sub

    ' Initializes the snake on form validation change
    Private Sub frmSnake_CausesValidationChanged(sender As Object, e As EventArgs) Handles Me.CausesValidationChanged
        If picSnakePiece IsNot Nothing Then ' Add this check
            InitializeSnake()
        End If
    End Sub

    ' Checks for collision between two objects
    Private Function Collide(ByVal ObjA As Object, ByVal ObjB As Object) As Boolean
        If ObjA.Bounds.IntersectsWith(ObjB.Bounds) Then
            Collide = True
        Else
            Collide = False
        End If
    End Function

    ' Exits the application when the "End" menu item is clicked
    Private Sub EndToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EndToolStripMenuItem.Click
        End
    End Sub

    ' Starts the game when the "Start" menu item is clicked
    Private Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click
        tmrGame.Enabled = True
        lblScore.Text = "0"
        finished = False
        picSnake(0).Left = 200
        picSnake(0).Top = 200
        picSnake(0).Visible = True
        For SnakeLoop = 1 To 99
            picSnake(SnakeLoop).Visible = False
        Next SnakeLoop
        SnakeLength = 1
        deltaX = 35
        deltaY = 0
    End Sub

    ' Initializes the snake on form load
    Private Sub frmSnake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeSnake()
    End Sub

    ' Initializes the snake array of picture boxes
    Private Sub InitializeSnake()
        For SnakeLoop = 0 To 99
            picSnake(SnakeLoop) = New PictureBox()
            picSnake(SnakeLoop).SizeMode = PictureBoxSizeMode.AutoSize
            picSnake(SnakeLoop).Left = 200
            picSnake(SnakeLoop).Top = 200
            picSnake(SnakeLoop).Image = picSnakePiece.Image
            If SnakeLoop = 0 Then
                picSnake(SnakeLoop).Visible = True
            Else
                picSnake(SnakeLoop).Visible = False
            End If
            pnlGameArea.Controls.Add(picSnake(SnakeLoop))
        Next SnakeLoop
    End Sub

End Class
