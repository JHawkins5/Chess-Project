namespace ChessProject
{
    class Pawn : Piece
    {
        public override bool[,] PossibleMoves(bool[,] possibleMoves, Piece[,] board)
        {
            King king = new King();
            Globals.GetKing(colour, board);
            king.xGridPos = Globals.kingX;
            king.yGridPos = Globals.kingY;
            king = (King)board[Globals.kingX, Globals.kingY];

            if (colour == "white")
            {
                if (yGridPos > 0)
                {
                    if (Globals.IsPositionEmpty(xGridPos, yGridPos - 1, board)) // up one
                    {
                        Piece[,] duplicateBoard = new Piece[8, 8];
                        duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                        AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos, yGridPos - 1, duplicateBoard);

                        if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                        {
                            possibleMoves[xGridPos, yGridPos - 1] = true;
                        }

                        if (yGridPos == 6)
                        {
                            AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos - 1], xGridPos, yGridPos, xGridPos, yGridPos - 2, duplicateBoard);

                            if (Globals.IsPositionEmpty(xGridPos, yGridPos - 2, board) && !king.Check(king.xGridPos, king.yGridPos, duplicateBoard)) // up two
                            {
                                possibleMoves[xGridPos, yGridPos - 2] = true;
                            }
                        }
                    }
                }
                
                if (xGridPos > 0 && yGridPos > 0)
                {
                    if (!Globals.IsPositionEmpty(xGridPos - 1, yGridPos - 1, board)) // take left
                    {                        
                        if (DifferentColour(xGridPos - 1, yGridPos - 1, board))
                        {
                            Piece[,] duplicateBoard = new Piece[8, 8];
                            duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                            AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos - 1, yGridPos - 1, duplicateBoard);

                            if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                            {
                                possibleMoves[xGridPos - 1, yGridPos - 1] = true;
                            }
                        }
                    }
                }
                if (xGridPos < 7 && yGridPos > 0)
                {
                    if (!Globals.IsPositionEmpty(xGridPos + 1, yGridPos - 1, board)) // take right
                    {                        
                        if (DifferentColour(xGridPos + 1, yGridPos - 1, board))
                        {
                            Piece[,] duplicateBoard = new Piece[8, 8];
                            duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                            AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos + 1, yGridPos + 1, duplicateBoard);

                            if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                            {
                                possibleMoves[xGridPos + 1, yGridPos - 1] = true;
                            }
                        }
                    }
                }
            }
            else if (colour == "black")
            {
                if (yGridPos < 7)
                {
                    if (Globals.IsPositionEmpty(xGridPos, yGridPos + 1, board) && yGridPos < 7) // down one
                    {
                        Piece[,] duplicateBoard = new Piece[8, 8];
                        duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                        AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos, yGridPos + 1, duplicateBoard);

                        if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                        {
                            possibleMoves[xGridPos, yGridPos + 1] = true;
                        }

                        if (yGridPos == 1)
                        {
                            AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos + 1], xGridPos, yGridPos, xGridPos, yGridPos + 2, duplicateBoard);

                            if (Globals.IsPositionEmpty(xGridPos, yGridPos + 2, board) && !king.Check(king.xGridPos, king.yGridPos, duplicateBoard)) // down two
                            {
                                possibleMoves[xGridPos, yGridPos + 2] = true;
                            }
                        }
                    }
                }
                
                if (xGridPos > 0 && yGridPos < 7)
                {
                    if (!Globals.IsPositionEmpty(xGridPos - 1, yGridPos + 1, board)) // take left
                    {                        
                        if (DifferentColour(xGridPos - 1, yGridPos + 1, board))
                        {
                            Piece[,] duplicateBoard = new Piece[8, 8];
                            duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                            AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos - 1, yGridPos + 1, duplicateBoard);

                            if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                            {
                                possibleMoves[xGridPos - 1, yGridPos + 1] = true;
                            }
                        }
                    }
                }
                if (xGridPos < 7 && yGridPos < 7)
                {
                    if (!Globals.IsPositionEmpty(xGridPos + 1, yGridPos + 1, board)) // take right
                    {
                        if (DifferentColour(xGridPos + 1, yGridPos + 1, board))
                        {
                            Piece[,] duplicateBoard = new Piece[8, 8];
                            duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                            AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos + 1, yGridPos + 1, duplicateBoard);
                            
                            if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                            {
                                possibleMoves[xGridPos + 1, yGridPos + 1] = true;
                            }
                        }
                    }
                }
            }

            return possibleMoves;
        }
    }
}