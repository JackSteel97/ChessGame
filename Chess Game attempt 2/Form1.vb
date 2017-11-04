Imports System.Drawing.Image
Imports System.Math

Public Class board

#Region "Global Varibles"
	Dim gameboard(7, 7) As String
	Dim GameImageBoard(7, 7) As Button

	Dim x1 As Integer
	Dim x2 As Integer

	Dim whitesTurn As Boolean = True

	Dim whiteInCheck As Boolean = False
	Dim blackInCheck As Boolean = False

	Dim y1 As Integer
	Dim y2 As Integer
	Dim isFirst As Boolean = True
	Dim firstButton As Button
	Dim firstColor As Color
#End Region

#Region "Piece Images"
	Dim wP As Image = FromFile("White P.png")
	Dim bP As Image = FromFile("black P.png")

	Dim wR As Image = FromFile("white r.png")
	Dim bR As Image = FromFile("black r.png")

	Dim wN As Image = FromFile("white n.png")
	Dim bN As Image = FromFile("black n.png")

	Dim wB As Image = FromFile("white b.png")
	Dim bB As Image = FromFile("black b.png")

	Dim wQ As Image = FromFile("white q.png")
	Dim bQ As Image = FromFile("black q.png")

	Dim wK As Image = FromFile("white k.png")
	Dim bK As Image = FromFile("black k.png")
#End Region

	Private Sub board_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        spawnpieces()


        LoadBoxArray()
        ResetBackcolours()



	End Sub


	Public Sub spawnpieces()
		'Spawn White Pawns
		A2.Image = wP
		A2.Tag = "White Pawn"
		B2.Image = wP
		B2.Tag = "White Pawn"
		C2.Image = wP
		C2.Tag = "White Pawn"
		D2.Image = wP
		D2.Tag = "White Pawn"
		E2.Image = wP
		E2.Tag = "White Pawn"
		F2.Image = wP
		F2.Tag = "White Pawn"
		G2.Image = wP
		G2.Tag = "White Pawn"
		H2.Image = wP
		H2.Tag = "White Pawn"

		'Spawn Black Pawns
		A7.Image = bP
		A7.Tag = "Black Pawn"
		B7.Image = bP
		B7.Tag = "Black Pawn"
		C7.Image = bP
		C7.Tag = "Black Pawn"
		D7.Image = bP
		D7.Tag = "Black Pawn"
		E7.Image = bP
		E7.Tag = "Black Pawn"
		F7.Image = bP
		F7.Tag = "Black Pawn"
		G7.Image = bP
		G7.Tag = "Black Pawn"
		H7.Image = bP
		H7.Tag = "Black Pawn"

		'Spawn white knights
		B1.Image = wN
		B1.Tag = "White Knight"
		G1.Image = wN
		G1.Tag = "White Knight"

		'spawn black knights
		B8.Image = bN
		B8.Tag = "Black Knight"
		G8.Image = bN
		G8.Tag = "Black Knight"

		'Spawn white Bishops
		C1.Image = wB
		C1.Tag = "White Bishop"
		F1.Image = wB
		F1.Tag = "White Bishop"

		'spawn Black Bishops
		C8.Image = bB
		C8.Tag = "Black Bishop"
		F8.Image = bB
		F8.Tag = "Black Bishop"

		'spawn white rooks
		A1.Image = wR
		A1.Tag = "White Rook"
		H1.Image = wR
		H1.Tag = "White Rook"

		'spawn black rooks
		A8.Image = bR
		A8.Tag = "Black Rook"
		H8.Image = bR
		H8.Tag = "Black Rook"

		'spawn white majors
		D1.Image = wQ
		D1.Tag = "White Queen"
		E1.Image = wK
		E1.Tag = "White King"

		'spawn black majors

		D8.Image = bQ
		D8.Tag = "Black Queen"
		E8.Image = bK
		E8.Tag = "Black King"

		'Load Arrays
        LoadGameArray()


	End Sub
	Private Sub LoadBoxArray()
		GameImageBoard(0, 0) = A1
		GameImageBoard(1, 0) = B1
		GameImageBoard(2, 0) = C1
		GameImageBoard(3, 0) = D1
		GameImageBoard(4, 0) = E1
		GameImageBoard(5, 0) = F1
		GameImageBoard(6, 0) = G1
		GameImageBoard(7, 0) = H1

		GameImageBoard(0, 1) = A2
		GameImageBoard(1, 1) = B2
		GameImageBoard(2, 1) = C2
		GameImageBoard(3, 1) = D2
		GameImageBoard(4, 1) = E2
		GameImageBoard(5, 1) = F2
		GameImageBoard(6, 1) = G2
		GameImageBoard(7, 1) = H2

		GameImageBoard(0, 2) = A3
		GameImageBoard(1, 2) = B3
		GameImageBoard(2, 2) = C3
		GameImageBoard(3, 2) = D3
		GameImageBoard(4, 2) = E3
		GameImageBoard(5, 2) = F3
		GameImageBoard(6, 2) = G3
		GameImageBoard(7, 2) = H3

		GameImageBoard(0, 3) = A4
		GameImageBoard(1, 3) = B4
		GameImageBoard(2, 3) = C4
		GameImageBoard(3, 3) = D4
		GameImageBoard(4, 3) = E4
		GameImageBoard(5, 3) = F4
		GameImageBoard(6, 3) = G4
		GameImageBoard(7, 3) = H4

		GameImageBoard(0, 4) = A5
		GameImageBoard(1, 4) = B5
		GameImageBoard(2, 4) = C5
		GameImageBoard(3, 4) = D5
		GameImageBoard(4, 4) = E5
		GameImageBoard(5, 4) = F5
		GameImageBoard(6, 4) = G5
		GameImageBoard(7, 4) = H5

		GameImageBoard(0, 5) = A6
		GameImageBoard(1, 5) = B6
		GameImageBoard(2, 5) = C6
		GameImageBoard(3, 5) = D6
		GameImageBoard(4, 5) = E6
		GameImageBoard(5, 5) = F6
		GameImageBoard(6, 5) = G6
		GameImageBoard(7, 5) = H6

		GameImageBoard(0, 6) = A7
		GameImageBoard(1, 6) = B7
		GameImageBoard(2, 6) = C7
		GameImageBoard(3, 6) = D7
		GameImageBoard(4, 6) = E7
		GameImageBoard(5, 6) = F7
		GameImageBoard(6, 6) = G7
		GameImageBoard(7, 6) = H7

		GameImageBoard(0, 7) = A8
		GameImageBoard(1, 7) = B8
		GameImageBoard(2, 7) = C8
		GameImageBoard(3, 7) = D8
		GameImageBoard(4, 7) = E8
		GameImageBoard(5, 7) = F8
		GameImageBoard(6, 7) = G8
		GameImageBoard(7, 7) = H8
	End Sub
	Private Sub LoadGameArray()
		For y = 0 To 7
			For x = 0 To 7
				If y = 0 Then
					gameboard(x, y) = "W"
				ElseIf y = 7 Then
					gameboard(x, y) = "B"
				ElseIf y = 1 Then
					gameboard(x, y) = "WP"
				ElseIf y = 6 Then
					gameboard(x, y) = "BP"
				Else
					gameboard(x, y) = ""
				End If

				If y = 0 Or y = 7 Then
					Select Case x
						Case 0, 7
							gameboard(x, y) += "R"
						Case 1, 6
							gameboard(x, y) += "N"
						Case 2, 5
							gameboard(x, y) += "B"
						Case 3
							gameboard(x, y) += "Q"
						Case 4
							gameboard(x, y) += "K"
					End Select
				End If
			Next
		Next



	End Sub

	Private Function GetPieceType(XCoord As Integer, YCoord As Integer) As Char
		If XCoord < 8 And XCoord >= 0 And YCoord < 8 And YCoord >= 0 Then
			If gameboard(XCoord, YCoord) <> "" Then
				Return gameboard(XCoord, YCoord)(1)
			End If
		End If

	End Function

	Private Function GetPieceColour(XCoord As Integer, YCoord As Integer) As Char
		If XCoord < 8 And XCoord >= 0 And YCoord < 8 And YCoord >= 0 Then
			If gameboard(XCoord, YCoord) <> "" Then
				Return gameboard(XCoord, YCoord)(0)
			End If
		End If

	End Function

    Private Function CheckPawnMoveIsValid(StartX As Integer, StartY As Integer, EndX As Integer, EndY As Integer, Colour As Char)
        Dim YDiff As Integer
        Dim XDiff As Integer

        YDiff = EndY - StartY
        XDiff = EndX - StartX

		'White Pawn
		If Colour = "W" Then
			If YDiff < 0 Then
				Return False
			End If
			'First Move?
			If StartY = 1 Then

				If XDiff = 0 And YDiff <= 2 And (GetPieceColour(EndX, EndY) <> "B") Then
					If YDiff = 2 Then
						If GameImageBoard(EndX, EndY - 1).Tag = "" Then
							Return True
						End If
					Else
						Return True
					End If

				End If
				If Abs(XDiff) = 1 And YDiff = 1 And (GetPieceColour(EndX, EndY) = "B") Then
					Return True
				End If
			Else
				If XDiff = 0 And YDiff = 1 And (GetPieceColour(EndX, EndY) <> "B") Then
					Return True
				End If
				If Abs(XDiff) = 1 And YDiff = 1 And (GetPieceColour(EndX, EndY) = "B") Then
					Return True
				End If
			End If

		ElseIf Colour = "B" Then
			If YDiff > 0 Then
				Return False
			End If

			If StartY = 6 Then
				If XDiff = 0 And YDiff >= -2 And GetPieceColour(EndX, EndY) <> "W" Then
					If YDiff = -2 Then
						If GameImageBoard(EndX, EndY + 1).Tag = "" Then
							Return True
						End If
					Else
						Return True
					End If
					If Abs(XDiff) = 1 And YDiff = -1 And (GetPieceColour(EndX, EndY) = "W") Then
						Return True
					End If

				End If

			Else
				If XDiff = 0 And YDiff = -1 And (GetPieceColour(EndX, EndY) <> "W") Then
					Return True
				End If
				If Abs(XDiff) = 1 And YDiff = -1 And (GetPieceColour(EndX, EndY) = "W") Then
					Return True
				End If
			End If


			End If

			Return False



	End Function

    Private Sub ResetBackcolours()
        Dim White As Color
        Dim Black As Color
        Dim CurBlack As Boolean

        White = Color.FromArgb(24, 240, 240, 240)
        Black = Color.FromArgb(128, 0, 0, 0)

        For y = 0 To 7

            If y = 0 Or y = 2 Or y = 4 Or y = 6 Then
                CurBlack = True
                For x = 0 To 7
                    If CurBlack = True Then
                        GameImageBoard(x, y).BackColor = Black
                        CurBlack = False
                    Else
                        GameImageBoard(x, y).BackColor = White
                        CurBlack = True
                    End If

                Next
            End If

            If y = 1 Or y = 3 Or y = 5 Or y = 7 Then
                CurBlack = False
                For x = 0 To 7
                    If CurBlack = True Then
                        GameImageBoard(x, y).BackColor = Black
                        CurBlack = False
                    Else
                        GameImageBoard(x, y).BackColor = White
                        CurBlack = True
                    End If

                Next
            End If

        Next

	End Sub

	Private Function CheckRookMoveIsValid(StartX As Integer, StartY As Integer, EndX As Integer, EndY As Integer) As Boolean

		Dim YDiff As Integer
		Dim XDiff As Integer

		YDiff = EndY - StartY
		XDiff = EndX - StartX
		If Abs(YDiff) > 0 And Abs(XDiff) > 0 Then
			Return False
		End If

		'Vertical
		If YDiff > 0 Then
			'Up
			For y = StartY + 1 To StartY + Abs(YDiff) - 1
				If GameImageBoard(StartX, y).Tag <> "" Then
					Return False
				End If
			Next
		Else
			'Down
			For y = StartY - 1 To StartY - Abs(YDiff) + 1 Step -1
				If GameImageBoard(StartX, y).Tag <> "" Then
					Return False
				End If

			Next
		End If

		'Horizontal
		If XDiff > 0 Then
			'Right
			For x = StartX + 1 To StartX + Abs(XDiff) - 1
				If GameImageBoard(x, StartY).Tag <> "" Then
					Return False
				End If
			Next
		Else
			'down
			For x = StartX - 1 To StartX - Abs(XDiff) + 1 Step -1
				If GameImageBoard(x, StartY).Tag <> "" Then
					Return False
				End If
			Next
		End If

		Return True
	End Function

	Private Function CheckKnigntMoveIsValid(StartX As Integer, StartY As Integer, EndX As Integer, EndY As Integer) As Boolean
		Dim YDiff As Integer
		Dim XDiff As Integer

		YDiff = EndY - StartY
		XDiff = EndX - StartX

		If (Abs(YDiff) = 2 And Abs(XDiff) = 1) Or (Abs(YDiff) = 1 And Abs(XDiff) = 2) Then
			Return True
		Else
			Return False
		End If
	End Function

	Private Function CheckBishopMoveIsValid(StartX As Integer, StartY As Integer, EndX As Integer, EndY As Integer) As Boolean
		Dim YDiff As Integer
		Dim XDiff As Integer

		YDiff = EndY - StartY
		XDiff = EndX - StartX

		If Abs(XDiff) <> Abs(YDiff) Then
			Return False
		End If

		'up
		If YDiff > 0 Then
			If XDiff > 0 Then
				'right
				For k = 1 To XDiff - 1
					For n = 1 To YDiff - 1
						If n <> k Then
							Continue For
						Else
							For i = 1 To YDiff - 1
								If GameImageBoard(StartX + i, StartY + i).Tag <> "" Then
									Return False

								End If
							Next
						End If
					Next
				Next
			Else
				'left
				For k = 1 To XDiff + 1 Step -1
					For n = 1 To YDiff - 1
						If n <> k Then
							Continue For
						Else
							For i = 1 To YDiff - 1
								If GameImageBoard(StartX - i, StartY + i).Tag <> "" Then
									Return False
								End If
							Next
						End If
					Next
				Next
			End If
		End If

        'down
		If YDiff < 0 Then
			If XDiff > 0 Then
				'right
				For k = 1 To XDiff
                    For n = 1 To Abs(YDiff)
                        If n <> k Then
                            Continue For
                        Else
                            For i = -1 To YDiff + 1 Step -1
                                If GameImageBoard(StartX + Abs(i), StartY + i).Tag <> "" Then
                                    Return False
                                End If
                            Next
                        End If
                    Next
				Next
			Else
				'left
                For k = 1 To Abs(XDiff)
                    For n = 1 To Abs(YDiff)
                        If n <> k Then
                            Continue For
                        Else
                            For i = -1 To YDiff + 1 Step -1
                                If GameImageBoard(StartX + i, StartY + i).Tag <> "" Then
                                    Return False
                                End If
                            Next
                        End If
                    Next
                Next
			End If


		End If


        Return True
    End Function

    Private Function CheckKingMoveIsValid(StartX As Integer, StartY As Integer, EndX As Integer, EndY As Integer) As Boolean
        Dim YDiff As Integer
        Dim XDiff As Integer

        YDiff = EndY - StartY
        XDiff = EndX - StartX
       
        If (Abs(XDiff) = 0 And Abs(YDiff) = 1) Or (Abs(YDiff) = 0 And Abs(XDiff) = 1) Or (Abs(XDiff) = 1 And Abs(YDiff) = 1) Then
            Return True
        Else
            Return False
        End If
    End Function

	Private Function CheckQueenMoveIsValid(StartX As Integer, StartY As Integer, EndX As Integer, EndY As Integer) As Boolean
		Dim YDiff As Integer
		Dim XDiff As Integer

		YDiff = EndY - StartY
		XDiff = EndX - StartX


		If Abs(XDiff) <> Abs(YDiff) Then
			If Abs(YDiff) > 0 And Abs(XDiff) > 0 Then
				Return False
			End If

			If YDiff > 0 Then
				'Up
				For y = StartY + 1 To StartY + Abs(YDiff) - 1
					If GameImageBoard(StartX, y).Tag <> "" Then
						Return False
					End If
				Next
			Else
				'Down
				For y = StartY - 1 To StartY - Abs(YDiff) + 1 Step -1
					If GameImageBoard(StartX, y).Tag <> "" Then
						Return False
					End If

				Next
			End If

			'Horizontal
			If XDiff > 0 Then
				'Right
				For x = StartX + 1 To StartX + Abs(XDiff) - 1
					If GameImageBoard(x, StartY).Tag <> "" Then
						Return False
					End If
				Next
            Else
                'down
                For x = StartX - 1 To StartX - Abs(XDiff) + 1 Step -1
                    If GameImageBoard(x, StartY).Tag <> "" Then
                        Return False
                    End If
                Next
			End If

		Else
			If YDiff > 0 Then
				If XDiff > 0 Then
					'right
					For k = 1 To XDiff - 1
						For n = 1 To YDiff - 1
							If n <> k Then
								Continue For
							Else
								For i = 1 To YDiff - 1
									If GameImageBoard(StartX + i, StartY + i).Tag <> "" Then
										Return False

									End If
								Next
							End If
						Next
					Next
				Else
					'left
					For k = 1 To XDiff + 1 Step -1
						For n = 1 To YDiff - 1
							If n <> k Then
								Continue For
							Else
								For i = 1 To YDiff - 1
									If GameImageBoard(StartX - i, StartY + i).Tag <> "" Then
										Return False
									End If
								Next
							End If
						Next
					Next
				End If
			End If

			'down
			If YDiff < 0 Then
				If XDiff > 0 Then
					'right
					For k = 1 To XDiff
						For n = 1 To Abs(YDiff)
							If n <> k Then
								Continue For
							Else
								For i = -1 To YDiff + 1 Step -1
									If GameImageBoard(StartX + Abs(i), StartY + i).Tag <> "" Then
										Return False
									End If
								Next
							End If
						Next
					Next
				Else
					'left
					For k = 1 To Abs(XDiff)
						For n = 1 To Abs(YDiff)
							If n <> k Then
								Continue For
							Else
								For i = -1 To YDiff + 1 Step -1
									If GameImageBoard(StartX + i, StartY + i).Tag <> "" Then
										Return False
									End If
								Next
							End If
						Next
					Next
				End If
			End If
		End If


		Return True
	End Function



	Private Function CheckValidMove(StartX As Integer, StartY As Integer, EndX As Integer, EndY As Integer) As Boolean

		Dim PieceType As Char
		Dim PieceColour As Char

		PieceType = GetPieceType(StartX, StartY)
		PieceColour = GetPieceColour(StartX, StartY)

		'Check Piece Colours
		If PieceColour = "W" Then
			If whitesTurn = False Then
				Return False
			End If
			If GetPieceColour(EndX, EndY) = "W" Then
				Return False
			End If
		Else
			If whitesTurn = True Then
				Return False
			End If
			If GetPieceColour(EndX, EndY) = "B" Then
				Return False
			End If
		End If

		'Non Move?
		If StartX = EndX And StartY = EndY Then
			Return False
		End If

        If blackInCheck And whitesTurn = False Then
            If GetPieceType(StartX, StartY) <> "K" Then
                Return False
            End If
        ElseIf whiteInCheck And whitesTurn = True Then
            If GetPieceType(StartX, StartY) <> "K" Then
                Return False
            End If
        End If
        'Check Piece Type
        Select Case GetPieceType(StartX, StartY)
            Case "P"
                Return CheckPawnMoveIsValid(StartX, StartY, EndX, EndY, GetPieceColour(StartX, StartY))
            Case "R"
                Return CheckRookMoveIsValid(StartX, StartY, EndX, EndY)
            Case "N"
                Return CheckKnigntMoveIsValid(StartX, StartY, EndX, EndY)
            Case "B"
                Return CheckBishopMoveIsValid(StartX, StartY, EndX, EndY)
            Case "Q"
                Return CheckQueenMoveIsValid(StartX, StartY, EndX, EndY)
            Case "K"
                Return CheckKingMoveIsValid(StartX, StartY, EndX, EndY)
        End Select





	End Function


    Private Sub MakeMove(StartX As Integer, StartY As Integer, EndX As Integer, EndY As Integer)


        If GetPieceColour(StartX, StartY) = "W" And GetPieceType(EndX, EndY) = "K" Then

            GameImageBoard(EndX, EndY).Image = GameImageBoard(StartX, StartY).Image
            GameImageBoard(EndX, EndY).Tag = GameImageBoard(StartX, StartY).Tag
            gameboard(EndX, EndY) = gameboard(StartX, StartY)

            gameboard(StartX, StartY) = ""
            GameImageBoard(StartX, StartY).Image = Nothing
            GameImageBoard(StartX, StartY).Tag = ""

            ResetBackcolours()
            GameOver(False, "W")
        ElseIf GetPieceColour(StartX, StartY) = "B" And GetPieceType(EndX, EndY) = "K" Then

            GameImageBoard(EndX, EndY).Image = GameImageBoard(StartX, StartY).Image
            GameImageBoard(EndX, EndY).Tag = GameImageBoard(StartX, StartY).Tag
            gameboard(EndX, EndY) = gameboard(StartX, StartY)

            gameboard(StartX, StartY) = ""
            GameImageBoard(StartX, StartY).Image = Nothing
            GameImageBoard(StartX, StartY).Tag = ""
            ResetBackcolours()
            GameOver(False, "B")
        Else
            GameImageBoard(EndX, EndY).Image = GameImageBoard(StartX, StartY).Image
            GameImageBoard(EndX, EndY).Tag = GameImageBoard(StartX, StartY).Tag
            gameboard(EndX, EndY) = gameboard(StartX, StartY)

            gameboard(StartX, StartY) = ""
            GameImageBoard(StartX, StartY).Image = Nothing
            GameImageBoard(StartX, StartY).Tag = ""

            ResetBackcolours()


            If whitesTurn = True Then
                ActivityLbl.Text = "Black's Turn"
            Else
                ActivityLbl.Text = "Whites's Turn"
            End If
            If whitesTurn = True Then
                whitesTurn = False
            Else
                whitesTurn = True
            End If

            CheckForCheck(GameImageBoard)
        End If




    End Sub
    Private Sub ResetAllBoxes()
        For x = 0 To 7
            For y = 0 To 7
                GameImageBoard(x, y).Tag = ""
                GameImageBoard(x, y).Image = Nothing
            Next
        Next
    End Sub
    Private Sub CheckForCheck(ByVal Board(,) As Button)
        'Copy Board

        Dim SwitchTracker As Boolean

        Dim BlackKingXPos As Byte
        Dim BlackKingYPos As Byte
        Dim WhiteKingXPos As Byte
        Dim WhiteKingYPos As Byte

        Dim PossibleEscapes As Integer
        blackInCheck = False
        whiteInCheck = False

        'Find Kings
        For x = 0 To 7
            For y = 0 To 7
                If Board(x, y).Tag = "Black King" Then
                    BlackKingXPos = x
                    BlackKingYPos = y
                ElseIf Board(x, y).Tag = "White King" Then
                    WhiteKingXPos = x
                    WhiteKingYPos = y
                End If
            Next
        Next


        For x = 0 To 7
            For y = 0 To 7
                If Board(x, y).Tag <> "" Then
                    If Board(x, y).Tag.ToString.Contains("White") Then
                        If whitesTurn = False Then
                            whitesTurn = True
                            SwitchTracker = True
                        End If
                        If CheckValidMove(x, y, BlackKingXPos, BlackKingYPos) Then
                            ActivityLbl.Text += Chr(13) & "Black's King is in Check"
                            blackInCheck = True
                            whitesTurn = False
                            'check for Checkmate
                            PossibleEscapes = 8
                            If Not (BlackKingXPos + 1 >= 0 And BlackKingXPos + 1 < 8) Then
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(BlackKingXPos, BlackKingYPos, BlackKingXPos + 1, BlackKingYPos) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, BlackKingXPos + 1, BlackKingYPos) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If Not (BlackKingXPos - 1 >= 0 And BlackKingXPos - 1 < 8) Then
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(BlackKingXPos, BlackKingYPos, BlackKingXPos - 1, BlackKingYPos) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, BlackKingXPos - 1, BlackKingYPos) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If Not (BlackKingYPos + 1 >= 0 And BlackKingYPos + 1 < 8) Then
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(BlackKingXPos, BlackKingYPos, BlackKingXPos, BlackKingYPos + 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, BlackKingXPos, BlackKingYPos + 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If Not (BlackKingYPos - 1 >= 0 And BlackKingYPos - 1 < 8) Then
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(BlackKingXPos, BlackKingYPos, BlackKingXPos, BlackKingYPos - 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, BlackKingXPos, BlackKingYPos - 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If Not (BlackKingYPos + 1 >= 0 And BlackKingYPos + 1 < 8) Or Not (BlackKingXPos + 1 >= 0 And BlackKingXPos + 1 < 8) Then
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(BlackKingXPos, BlackKingYPos, BlackKingXPos + 1, BlackKingYPos + 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, BlackKingXPos + 1, BlackKingYPos + 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If Not (BlackKingYPos + 1 >= 0 And BlackKingYPos + 1 < 8) Or Not (BlackKingXPos - 1 >= 0 And BlackKingXPos - 1 < 8) Then
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(BlackKingXPos, BlackKingYPos, BlackKingXPos - 1, BlackKingYPos + 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, BlackKingXPos - 1, BlackKingYPos + 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If Not (BlackKingYPos - 1 >= 0 And BlackKingYPos - 1 < 8) Or Not (BlackKingXPos + 1 >= 0 And BlackKingXPos + 1 < 8) Then
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(BlackKingXPos, BlackKingYPos, BlackKingXPos + 1, BlackKingYPos - 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, BlackKingXPos + 1, BlackKingYPos - 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If Not (BlackKingYPos - 1 >= 0 And BlackKingYPos - 1 < 8) Or Not (BlackKingXPos - 1 >= 0 And BlackKingXPos - 1 < 8) Then
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(BlackKingXPos, BlackKingYPos, BlackKingXPos - 1, BlackKingYPos - 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, BlackKingXPos - 1, BlackKingYPos - 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            whitesTurn = True
                            If PossibleEscapes <= 0 Then
                                GameOver(True, "W")
                                ActivityLbl.Text += Chr(13) & "White Has Checkmated Black"
                            End If
                        End If
                        If SwitchTracker = True Then
                            SwitchTracker = False
                            whitesTurn = False
                        End If


                    ElseIf Board(x, y).Tag.ToString.Contains("Black") Then
                        If whitesTurn = True Then
                            whitesTurn = False
                            SwitchTracker = True
                        End If
                        If CheckValidMove(x, y, WhiteKingXPos, WhiteKingYPos) Then
                            ActivityLbl.Text += Chr(13) & "White's King is in Check"
                            whiteInCheck = True

                            'check for Checkmate
                            PossibleEscapes = 8
                            whitesTurn = True

                            If CheckValidMove(WhiteKingXPos, WhiteKingYPos, WhiteKingXPos + 1, WhiteKingYPos) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, WhiteKingXPos + 1, WhiteKingYPos) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(WhiteKingXPos, WhiteKingYPos, WhiteKingXPos - 1, WhiteKingYPos) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, WhiteKingXPos - 1, WhiteKingYPos) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(WhiteKingXPos, WhiteKingYPos, WhiteKingXPos, WhiteKingYPos + 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, WhiteKingXPos, WhiteKingYPos + 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(WhiteKingXPos, WhiteKingYPos, WhiteKingXPos, WhiteKingYPos - 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, WhiteKingXPos, WhiteKingYPos - 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(WhiteKingXPos, WhiteKingYPos, WhiteKingXPos + 1, WhiteKingYPos + 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, WhiteKingXPos + 1, WhiteKingYPos + 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(WhiteKingXPos, WhiteKingYPos, WhiteKingXPos - 1, WhiteKingYPos + 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, WhiteKingXPos - 1, WhiteKingYPos + 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(WhiteKingXPos, WhiteKingYPos, WhiteKingXPos + 1, WhiteKingYPos - 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, WhiteKingXPos + 1, WhiteKingYPos - 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            If CheckValidMove(WhiteKingXPos, WhiteKingYPos, WhiteKingXPos - 1, WhiteKingYPos - 1) = True Then
                                For r = 0 To 7
                                    For f = 0 To 7
                                        If CheckValidMove(r, f, WhiteKingXPos - 1, WhiteKingYPos - 1) = True Then
                                            PossibleEscapes -= 1
                                        End If
                                    Next
                                Next
                            Else
                                PossibleEscapes -= 1
                            End If
                            whitesTurn = False
                            If PossibleEscapes = 0 Then
                                GameOver(True, "W")
                                ActivityLbl.Text += Chr(13) & "Black Has Checkmated White"
                            End If
                        End If
                        If SwitchTracker = True Then
                            whitesTurn = True
                            SwitchTracker = False
                        End If
                    End If
                End If

            Next
        Next
    End Sub

    Private Sub GameOver(Checkmate As Boolean, Winner As Char)
        If Winner = "W" Then
            MsgBox("White has captured Black's King and wins the game!")
        Else
            MsgBox("Black has captured Whites's King and wins the game!")
        End If

        ActivityLbl.Text = "New Game"
        ResetAllBoxes()

        spawnpieces()
        ResetBackcolours()
    End Sub
	Private Sub takeInput(button As Button)

		If isFirst Then
			'Find Button Coords
			For x = 0 To 7
				For y = 0 To 7
					If GameImageBoard(x, y).Name = button.Name Then
						x1 = x
						y1 = y
						Exit For
					End If
				Next
			Next

			firstColor = button.BackColor
			firstButton = button
			button.BackColor = Color.DarkGreen
			isFirst = False

			For y = 0 To 7
				For x = 0 To 7
					If CheckValidMove(x1, y1, x, y) Then
						GameImageBoard(x, y).BackColor = Color.Green
					End If
				Next
			Next
        Else
           
            'Find Button Coords
            For x = 0 To 7
                For y = 0 To 7
                    If GameImageBoard(x, y).Name = button.Name Then
                        x2 = x
                        y2 = y
                        Exit For
                    End If
                Next
            Next

            If CheckValidMove(x1, y1, x2, y2) = False Then
                firstButton.BackColor = firstColor
                ResetBackcolours()
            Else
                MakeMove(x1, y1, x2, y2)
                firstButton.BackColor = firstColor
            End If
            isFirst = True
		End If

	End Sub

#Region "BoxClicks"
	Private Sub A1_Click(sender As Object, e As EventArgs) Handles A1.Click
		takeInput(sender)
	End Sub

	Private Sub A2_Click(sender As Object, e As EventArgs) Handles A2.Click
		takeInput(sender)
	End Sub

	Private Sub A3_Click(sender As Object, e As EventArgs) Handles A3.Click
		takeInput(sender)
	End Sub

	Private Sub A4_Click(sender As Object, e As EventArgs) Handles A4.Click
		takeInput(sender)
	End Sub

	Private Sub A5_Click(sender As Object, e As EventArgs) Handles A5.Click
		takeInput(sender)
	End Sub

	Private Sub A6_Click(sender As Object, e As EventArgs) Handles A6.Click
		takeInput(sender)
	End Sub

	Private Sub A7_Click(sender As Object, e As EventArgs) Handles A7.Click
		takeInput(sender)
	End Sub

	Private Sub A8_Click(sender As Object, e As EventArgs) Handles A8.Click
		takeInput(sender)
	End Sub

	Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
		takeInput(sender)
	End Sub

	Private Sub B2_Click(sender As Object, e As EventArgs) Handles B2.Click
		takeInput(sender)
	End Sub

	Private Sub B3_Click(sender As Object, e As EventArgs) Handles B3.Click
		takeInput(sender)
	End Sub

	Private Sub B4_Click(sender As Object, e As EventArgs) Handles B4.Click
		takeInput(sender)
	End Sub

	Private Sub B5_Click(sender As Object, e As EventArgs) Handles B5.Click
		takeInput(sender)
	End Sub

	Private Sub B6_Click(sender As Object, e As EventArgs) Handles B6.Click
		takeInput(sender)
	End Sub

	Private Sub B7_Click(sender As Object, e As EventArgs) Handles B7.Click
		takeInput(sender)
	End Sub

	Private Sub B8_Click(sender As Object, e As EventArgs) Handles B8.Click
		takeInput(sender)
	End Sub

	Private Sub C1_Click(sender As Object, e As EventArgs) Handles C1.Click
		takeInput(sender)
	End Sub

	Private Sub C2_Click(sender As Object, e As EventArgs) Handles C2.Click
		takeInput(sender)
	End Sub

	Private Sub C3_Click(sender As Object, e As EventArgs) Handles C3.Click
		takeInput(sender)
	End Sub

	Private Sub C4_Click(sender As Object, e As EventArgs) Handles C4.Click
		takeInput(sender)
	End Sub

	Private Sub C5_Click(sender As Object, e As EventArgs) Handles C5.Click
		takeInput(sender)
	End Sub

	Private Sub C6_Click(sender As Object, e As EventArgs) Handles C6.Click
		takeInput(sender)
	End Sub

	Private Sub C7_Click(sender As Object, e As EventArgs) Handles C7.Click
		takeInput(sender)
	End Sub

	Private Sub C8_Click(sender As Object, e As EventArgs) Handles C8.Click
		takeInput(sender)
	End Sub

	Private Sub D1_Click(sender As Object, e As EventArgs) Handles D1.Click
		takeInput(sender)
	End Sub

	Private Sub D2_Click(sender As Object, e As EventArgs) Handles D2.Click
		takeInput(sender)
	End Sub

	Private Sub D3_Click(sender As Object, e As EventArgs) Handles D3.Click
		takeInput(sender)
	End Sub

	Private Sub D4_Click(sender As Object, e As EventArgs) Handles D4.Click
		takeInput(sender)
	End Sub

	Private Sub D5_Click(sender As Object, e As EventArgs) Handles D5.Click
		takeInput(sender)
	End Sub

	Private Sub D6_Click(sender As Object, e As EventArgs) Handles D6.Click
		takeInput(sender)
	End Sub

	Private Sub D7_Click(sender As Object, e As EventArgs) Handles D7.Click
		takeInput(sender)
	End Sub

	Private Sub D8_Click(sender As Object, e As EventArgs) Handles D8.Click
		takeInput(sender)
	End Sub

	Private Sub E1_Click(sender As Object, e As EventArgs) Handles E1.Click
		takeInput(sender)
	End Sub

	Private Sub E2_Click(sender As Object, e As EventArgs) Handles E2.Click
		takeInput(sender)
	End Sub

	Private Sub E3_Click(sender As Object, e As EventArgs) Handles E3.Click
		takeInput(sender)
	End Sub

	Private Sub E4_Click(sender As Object, e As EventArgs) Handles E4.Click
		takeInput(sender)
	End Sub

	Private Sub E5_Click(sender As Object, e As EventArgs) Handles E5.Click
		takeInput(sender)
	End Sub

	Private Sub E6_Click(sender As Object, e As EventArgs) Handles E6.Click
		takeInput(sender)
	End Sub

	Private Sub E7_Click(sender As Object, e As EventArgs) Handles E7.Click
		takeInput(sender)
	End Sub

	Private Sub E8_Click(sender As Object, e As EventArgs) Handles E8.Click
		takeInput(sender)
	End Sub

	Private Sub F1_Click(sender As Object, e As EventArgs) Handles F1.Click
		takeInput(sender)
	End Sub

	Private Sub F2_Click(sender As Object, e As EventArgs) Handles F2.Click
		takeInput(sender)
	End Sub

	Private Sub F3_Click(sender As Object, e As EventArgs) Handles F3.Click
		takeInput(sender)
	End Sub

	Private Sub F4_Click(sender As Object, e As EventArgs) Handles F4.Click
		takeInput(sender)
	End Sub

	Private Sub F5_Click(sender As Object, e As EventArgs) Handles F5.Click
		takeInput(sender)
	End Sub

	Private Sub F6_Click(sender As Object, e As EventArgs) Handles F6.Click
		takeInput(sender)
	End Sub

	Private Sub F7_Click(sender As Object, e As EventArgs) Handles F7.Click
		takeInput(sender)
	End Sub

	Private Sub F8_Click(sender As Object, e As EventArgs) Handles F8.Click
		takeInput(sender)
	End Sub

	Private Sub G1_Click(sender As Object, e As EventArgs) Handles G1.Click
		takeInput(sender)
	End Sub

	Private Sub G2_Click(sender As Object, e As EventArgs) Handles G2.Click
		takeInput(sender)
	End Sub

	Private Sub G3_Click(sender As Object, e As EventArgs) Handles G3.Click
		takeInput(sender)
	End Sub

	Private Sub G4_Click(sender As Object, e As EventArgs) Handles G4.Click
		takeInput(sender)
	End Sub

	Private Sub G5_Click(sender As Object, e As EventArgs) Handles G5.Click
		takeInput(sender)
	End Sub

	Private Sub G6_Click(sender As Object, e As EventArgs) Handles G6.Click
		takeInput(sender)
	End Sub

	Private Sub G7_Click(sender As Object, e As EventArgs) Handles G7.Click
		takeInput(sender)
	End Sub

	Private Sub G8_Click(sender As Object, e As EventArgs) Handles G8.Click
		takeInput(sender)
	End Sub

	Private Sub H1_Click(sender As Object, e As EventArgs) Handles H1.Click
		takeInput(sender)
	End Sub

	Private Sub H2_Click(sender As Object, e As EventArgs) Handles H2.Click
		takeInput(sender)
	End Sub

	Private Sub H3_Click(sender As Object, e As EventArgs) Handles H3.Click
		takeInput(sender)
	End Sub

	Private Sub H4_Click(sender As Object, e As EventArgs) Handles H4.Click
		takeInput(sender)
	End Sub

	Private Sub H5_Click(sender As Object, e As EventArgs) Handles H5.Click
		takeInput(sender)
	End Sub

	Private Sub H6_Click(sender As Object, e As EventArgs) Handles H6.Click
		takeInput(sender)
	End Sub

	Private Sub H7_Click(sender As Object, e As EventArgs) Handles H7.Click
		takeInput(sender)
	End Sub

	Private Sub H8_Click(sender As Object, e As EventArgs) Handles H8.Click
		takeInput(sender)
	End Sub
#End Region

End Class
