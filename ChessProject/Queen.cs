namespace ChessProject
{
    class Queen : Piece 
    {
        public override bool[,] PossibleMoves(bool[,] possibleMoves, Piece[,] board)
        {
            King king = new King();
            Globals.GetKing(colour, board);
            king.xGridPos = Globals.kingX;
            king.yGridPos = Globals.kingY;
            king = (King)board[Globals.kingX, Globals.kingY];

            for (int i = 1; i < 8; i++) // diagonals
            {
                if (xGridPos + i <= 7 && yGridPos + i <= 7) // diagonal down and right
                {
                    if (Globals.IsPositionEmpty(xGridPos + i, yGridPos + i, board) || (!Globals.IsPositionEmpty(xGridPos + i, yGridPos + i, board) && DifferentColour(xGridPos + i, yGridPos + i, board)))
                    {
                        Piece[,] duplicateBoard = new Piece[8, 8];
                        duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                        AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos + i, yGridPos + i, duplicateBoard);

                        if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                        {
                            possibleMoves[xGridPos + i, yGridPos + i] = true;
                        }
                        if (!Globals.IsPositionEmpty(xGridPos + i, yGridPos + i, board) && possibleMoves[xGridPos + i, yGridPos + i])
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 8; i++)
            {
                if (xGridPos + i <= 7 && yGridPos - i >= 0) // diagonal up and right
                {
                    if (Globals.IsPositionEmpty(xGridPos + i, yGridPos - i, board) || (!Globals.IsPositionEmpty(xGridPos + i, yGridPos - i, board) && DifferentColour(xGridPos + i, yGridPos - i, board)))
                    {
                        Piece[,] duplicateBoard = new Piece[8, 8];
                        duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                        AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos + i, yGridPos - i, duplicateBoard);

                        if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                        {
                            possibleMoves[xGridPos + i, yGridPos - i] = true;
                        }
                        if (!Globals.IsPositionEmpty(xGridPos + i, yGridPos - i, board) && possibleMoves[xGridPos + i, yGridPos - i])
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 8; i++)
            {
                if (xGridPos - i >= 0 && yGridPos - i >= 0) // diagonal up and left
                {
                    if (Globals.IsPositionEmpty(xGridPos - i, yGridPos - i, board) || (!Globals.IsPositionEmpty(xGridPos - i, yGridPos - i, board) && DifferentColour(xGridPos - i, yGridPos - i, board)))
                    {
                        Piece[,] duplicateBoard = new Piece[8, 8];
                        duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                        AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos - i, yGridPos - i, duplicateBoard);

                        if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                        {
                            possibleMoves[xGridPos - i, yGridPos - i] = true;
                        }
                        if (!Globals.IsPositionEmpty(xGridPos - i, yGridPos - i, board) && possibleMoves[xGridPos - i, yGridPos - i])
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 8; i++)
            {
                if (xGridPos - i >= 0 && yGridPos + i <= 7) // diagonal up and right
                {
                    if (Globals.IsPositionEmpty(xGridPos - i, yGridPos + i, board) || (!Globals.IsPositionEmpty(xGridPos - i, yGridPos + i, board) && DifferentColour(xGridPos - i, yGridPos + i, board)))
                    {
                        Piece[,] duplicateBoard = new Piece[8, 8];
                        duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                        AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos - i, yGridPos + i, duplicateBoard);

                        if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                        {
                            possibleMoves[xGridPos - i, yGridPos + i] = true;                            
                        }
                        if (!Globals.IsPositionEmpty(xGridPos -i, yGridPos + i, board) && possibleMoves[xGridPos - i, yGridPos + i])
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 8; i++) // horizontals
            {
                if (xGridPos - i >= 0) // left
                {
                    if (Globals.IsPositionEmpty(xGridPos - i, yGridPos, board) || (!Globals.IsPositionEmpty(xGridPos - i, yGridPos, board) && DifferentColour(xGridPos - i, yGridPos, board)))
                    {
                        Piece[,] duplicateBoard = new Piece[8, 8];
                        duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                        AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos - i, yGridPos, duplicateBoard);

                        if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                        {
                            possibleMoves[xGridPos - i, yGridPos] = true;
                        }
                        if (!Globals.IsPositionEmpty(xGridPos - i, yGridPos, board) && possibleMoves[xGridPos - i, yGridPos])
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 8; i++)
            {
                if (xGridPos + i <= 7) // right
                {
                    if (Globals.IsPositionEmpty(xGridPos + i, yGridPos, board) || (!Globals.IsPositionEmpty(xGridPos + i, yGridPos, board) && DifferentColour(xGridPos + i, yGridPos, board)))
                    {
                        Piece[,] duplicateBoard = new Piece[8, 8];
                        duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                        AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos + i, yGridPos, duplicateBoard);

                        if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                        {
                            possibleMoves[xGridPos + i, yGridPos] = true;                            
                        }
                        if (!Globals.IsPositionEmpty(xGridPos + i, yGridPos, board) && possibleMoves[xGridPos + i, yGridPos])
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 8; i++) // verticals
            {
                if (yGridPos - i >= 0) // up
                {
                    if (Globals.IsPositionEmpty(xGridPos, yGridPos - i, board) || (!Globals.IsPositionEmpty(xGridPos, yGridPos - i, board) && DifferentColour(xGridPos, yGridPos - i, board)))
                    {
                        Piece[,] duplicateBoard = new Piece[8, 8];
                        duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                        AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos, yGridPos - i, duplicateBoard);

                        if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                        {
                            possibleMoves[xGridPos, yGridPos - i] = true;
                        }
                        if (!Globals.IsPositionEmpty(xGridPos, yGridPos - i, board) && possibleMoves[xGridPos, yGridPos - i])
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            for (int i = 1; i < 8; i++)
            {
                if (yGridPos + i <= 7) // down
                {
                    if (Globals.IsPositionEmpty(xGridPos, yGridPos + i, board) || (!Globals.IsPositionEmpty(xGridPos, yGridPos + i, board) && DifferentColour(xGridPos, yGridPos + i, board)))
                    {
                        Piece[,] duplicateBoard = new Piece[8, 8];
                        duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                        AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos, yGridPos + i, duplicateBoard);

                        if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                        {
                            possibleMoves[xGridPos, yGridPos + i] = true;                            
                        }
                        if (!Globals.IsPositionEmpty(xGridPos, yGridPos + i, board) && possibleMoves[xGridPos, yGridPos + i])
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            return possibleMoves;
        }
    }
}