namespace ChessProject
{
    class Knight : Piece
    {
        public override bool[,] PossibleMoves(bool[,] possibleMoves, Piece[,] board)
        {
            King king = new King();
            Globals.GetKing(colour, board);
            king.xGridPos = Globals.kingX;
            king.yGridPos = Globals.kingY;
            king = (King)board[Globals.kingX, Globals.kingY];

            if (xGridPos != 7 && yGridPos < 6) // right one, down two
            {
                if (Globals.IsPositionEmpty(xGridPos + 1, yGridPos + 2, board) || (!Globals.IsPositionEmpty(xGridPos + 1, yGridPos + 2, board) && DifferentColour(xGridPos + 1, yGridPos + 2, board)))
                {
                    Piece[,] duplicateBoard = new Piece[8, 8];
                    duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                    AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos + 1, yGridPos + 2, duplicateBoard);

                    if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                    {
                        possibleMoves[xGridPos + 1, yGridPos + 2] = true;
                    }
                }
            }
            if (xGridPos < 6 && yGridPos != 7) // right two, down one
            {
                if (Globals.IsPositionEmpty(xGridPos + 2, yGridPos + 1, board) || (!Globals.IsPositionEmpty(xGridPos + 2, yGridPos + 1, board) && DifferentColour(xGridPos + 2, yGridPos + 1, board)))
                {
                    Piece[,] duplicateBoard = new Piece[8, 8];
                    duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                    AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos + 2, yGridPos + 1, duplicateBoard);

                    if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                    {
                        possibleMoves[xGridPos + 2, yGridPos + 1] = true;
                    }
                }
            }
            if (xGridPos < 6 && yGridPos != 0) // right two, up one
            {
                if (Globals.IsPositionEmpty(xGridPos + 2, yGridPos - 1, board) || (!Globals.IsPositionEmpty(xGridPos + 2, yGridPos - 1, board) && DifferentColour(xGridPos + 2, yGridPos - 1, board)))
                {
                    Piece[,] duplicateBoard = new Piece[8, 8];
                    duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                    AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos + 2, yGridPos - 1, duplicateBoard);

                    if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                    {
                        possibleMoves[xGridPos + 2, yGridPos - 1] = true;
                    }
                }
            }
            if (xGridPos != 7 && yGridPos > 1) // right one, up two
            {
                if (Globals.IsPositionEmpty(xGridPos + 1, yGridPos - 2, board) || (!Globals.IsPositionEmpty(xGridPos + 1, yGridPos - 2, board) && DifferentColour(xGridPos + 1, yGridPos - 2, board)))
                {
                    Piece[,] duplicateBoard = new Piece[8, 8];
                    duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                    AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos + 1, yGridPos - 2, duplicateBoard);

                    if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                    {
                        possibleMoves[xGridPos + 1, yGridPos - 2] = true;
                    }
                }
            }
            if (xGridPos != 0 && yGridPos > 1) // left one, up two
            {
                if (Globals.IsPositionEmpty(xGridPos - 1, yGridPos - 2, board) || (!Globals.IsPositionEmpty(xGridPos - 1, yGridPos - 2, board) && DifferentColour(xGridPos - 1, yGridPos - 2, board)))
                {
                    Piece[,] duplicateBoard = new Piece[8, 8];
                    duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                    AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos - 1, yGridPos - 2, duplicateBoard);

                    if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                    {
                        possibleMoves[xGridPos - 1, yGridPos - 2] = true;
                    }
                }
            }
            if (xGridPos > 1 && yGridPos != 0) // left two, up one
            {
                if (Globals.IsPositionEmpty(xGridPos - 2, yGridPos - 1, board) || (!Globals.IsPositionEmpty(xGridPos - 2, yGridPos - 1, board) && DifferentColour(xGridPos - 2, yGridPos - 1, board)))
                {
                    Piece[,] duplicateBoard = new Piece[8, 8];
                    duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                    AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos - 2, yGridPos - 1, duplicateBoard);

                    if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                    {
                        possibleMoves[xGridPos - 2, yGridPos - 1] = true;
                    }
                }
            }
            if (xGridPos > 1 && yGridPos != 7) // left two, down one
            {
                if (Globals.IsPositionEmpty(xGridPos - 2, yGridPos + 1, board) || (!Globals.IsPositionEmpty(xGridPos - 2, yGridPos + 1, board) && DifferentColour(xGridPos - 2, yGridPos + 1, board)))
                {
                    Piece[,] duplicateBoard = new Piece[8, 8];
                    duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                    AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos - 2, yGridPos + 1, duplicateBoard);

                    if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                    {
                        possibleMoves[xGridPos - 2, yGridPos + 1] = true;
                    }
                }
            }
            if (xGridPos != 0 && yGridPos < 6) // left one, down two
            {
                if (Globals.IsPositionEmpty(xGridPos - 1, yGridPos + 2, board) || (!Globals.IsPositionEmpty(xGridPos - 1, yGridPos + 2, board) && DifferentColour(xGridPos - 1, yGridPos + 2, board)))
                {
                    Piece[,] duplicateBoard = new Piece[8, 8];
                    duplicateBoard = AI.DuplicateBoard(duplicateBoard, board);
                    AI.AIUpdatePosition(duplicateBoard[xGridPos, yGridPos], xGridPos, yGridPos, xGridPos - 1, yGridPos + 2, duplicateBoard);

                    if (!king.Check(king.xGridPos, king.yGridPos, duplicateBoard))
                    {
                        possibleMoves[xGridPos - 1, yGridPos + 2] = true;
                    }
                }
            }

            return possibleMoves;
        }
    }
}