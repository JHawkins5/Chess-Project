namespace ChessProject
{
    public class King : Piece 
    {
        public override bool[,] PossibleMoves(bool[,] possibleMoves, Piece[,] board)
        {
            if (yGridPos != 7) // down one
            {
                if ((Globals.IsPositionEmpty(xGridPos, yGridPos + 1, board) || (!Globals.IsPositionEmpty(xGridPos, yGridPos + 1, board) && DifferentColour(xGridPos, yGridPos + 1, board))) && !Check(xGridPos, yGridPos + 1, board))
                {
                    possibleMoves[xGridPos, yGridPos + 1] = true;
                }
            }
            if (xGridPos != 7 && yGridPos != 7) // right one, down one
            {
                if ((Globals.IsPositionEmpty(xGridPos + 1, yGridPos + 1, board) || (!Globals.IsPositionEmpty(xGridPos + 1, yGridPos + 1, board) && DifferentColour(xGridPos + 1, yGridPos + 1, board))) && !Check(xGridPos + 1, yGridPos + 1, board))
                {
                    possibleMoves[xGridPos + 1, yGridPos + 1] = true;
                }
            }
            if (xGridPos != 7) // right one
            {
                if ((Globals.IsPositionEmpty(xGridPos + 1, yGridPos, board) || (!Globals.IsPositionEmpty(xGridPos + 1, yGridPos, board) && DifferentColour(xGridPos + 1, yGridPos, board))) && !Check(xGridPos + 1, yGridPos, board))
                {
                    possibleMoves[xGridPos + 1, yGridPos] = true;
                }
            }
            if (xGridPos != 7 && yGridPos != 0) // right one, up one
            {
                if ((Globals.IsPositionEmpty(xGridPos + 1, yGridPos - 1, board) || (!Globals.IsPositionEmpty(xGridPos + 1, yGridPos - 1, board) && DifferentColour(xGridPos + 1, yGridPos - 1, board))) && !Check(xGridPos + 1, yGridPos - 1, board))
                {
                    possibleMoves[xGridPos + 1, yGridPos - 1] = true;
                }
            }
            if (yGridPos != 0) // up one
            {
                if ((Globals.IsPositionEmpty(xGridPos, yGridPos - 1, board) || (!Globals.IsPositionEmpty(xGridPos, yGridPos - 1, board) && DifferentColour(xGridPos, yGridPos - 1, board))) && !Check(xGridPos, yGridPos - 1, board))
                {
                    possibleMoves[xGridPos, yGridPos - 1] = true;
                }
            }
            if (xGridPos != 0 && yGridPos != 0) // left one, up one
            {
                if ((Globals.IsPositionEmpty(xGridPos - 1, yGridPos - 1, board) || (!Globals.IsPositionEmpty(xGridPos - 1, yGridPos - 1, board) && DifferentColour(xGridPos - 1, yGridPos - 1, board))) && !Check(xGridPos - 1, yGridPos - 1, board))
                {
                    possibleMoves[xGridPos - 1, yGridPos - 1] = true;
                }
            }
            if (xGridPos != 0) // left one
            {
                if ((Globals.IsPositionEmpty(xGridPos - 1, yGridPos, board) || (!Globals.IsPositionEmpty(xGridPos - 1, yGridPos, board) && DifferentColour(xGridPos - 1, yGridPos, board))) && !Check(xGridPos - 1, yGridPos, board))
                {
                    possibleMoves[xGridPos - 1, yGridPos] = true;
                }
            }
            if (xGridPos != 0 && yGridPos != 7) // left one, down one
            {
                if ((Globals.IsPositionEmpty(xGridPos - 1, yGridPos + 1, board) || (!Globals.IsPositionEmpty(xGridPos - 1, yGridPos + 1, board) && DifferentColour(xGridPos - 1, yGridPos + 1, board))) && !Check(xGridPos - 1, yGridPos + 1, board))
                {
                    possibleMoves[xGridPos - 1, yGridPos + 1] = true;
                }
            }
            
            return possibleMoves;
        }

        public bool Check(int x, int y, Piece[,] board)
        {
            //diagonals
            for (int i = x + 1; i < 8; i++) //down right
            {
                bool breakLoop = false;

                for (int j = y + 1; j < 8; j++)
                {
                    if (i - x == j - y)
                    {
                        if (!Globals.IsPositionEmpty(i, j, board))
                        {
                            if (DifferentColour(i, j, board))
                            {
                                if (board[i, j].pieceType == "bishop" || board[i, j].pieceType == "queen" || (board[i, j].pieceType == "pawn" && i == x + 1 && j == y + 1 && board[i, j].colour == "black"))
                                {
                                    return true;
                                }
                                else
                                {
                                    breakLoop = true;
                                    break;
                                }
                            }
                            else
                            {
                                breakLoop = true;
                                break;
                            }
                        }
                    }                    
                }

                if (breakLoop)
                {
                    break;
                }
            }
            for (int i = x - 1; i > -1; i--) // up left
            {
                bool breakLoop = false;

                for (int j = y - 1; j > -1; j--)
                {
                    if (i - x == j - y)
                    {
                        if (!Globals.IsPositionEmpty(i, j, board))
                        {
                            if (DifferentColour(i, j, board))
                            {
                                if (board[i, j].pieceType == "bishop" || board[i, j].pieceType == "queen" || (board[i, j].pieceType == "pawn" && i == x - 1 && j == y - 1 && board[i, j].colour == "white"))
                                {
                                    return true;
                                }
                                else
                                {
                                    breakLoop = true;
                                    break;
                                }
                            }
                            else
                            {
                                breakLoop = true;
                                break;
                            }
                        }
                    }
                }

                if (breakLoop)
                {
                    break;
                }
            }
            for (int i = x + 1; i < 8; i++) //down left
            {
                bool breakLoop = false;

                for (int j = y - 1; j > -1; j--)
                {
                    if (i - x == -(j - y))
                    {
                        if (!Globals.IsPositionEmpty(i, j, board))
                        {
                            if (DifferentColour(i, j, board))
                            {
                                if (board[i, j].pieceType == "bishop" || board[i, j].pieceType == "queen" || (board[i, j].pieceType == "pawn" && i == x + 1 && j == x - 1 && board[i, j].colour == "black"))
                                {
                                    return true;
                                }
                                else
                                {
                                    breakLoop = true;
                                    break;
                                }
                            }
                            else
                            {
                                breakLoop = true;
                                break;
                            }
                        }
                    }                    
                }

                if (breakLoop)
                {
                    break;
                }
            }
            for (int i = x - 1; i > -1; i--) //up right
            {
                bool breakLoop = false;

                for (int j = y + 1; j < 8; j++)
                {
                    if (-(i - x) == j - y)
                    {
                        if (!Globals.IsPositionEmpty(i, j, board))
                        {
                            if (DifferentColour(i, j, board))
                            {
                                if (board[i, j].pieceType == "bishop" || board[i, j].pieceType == "queen" || (board[i, j].pieceType == "pawn" && i == x - 1 && j == y + 1 && board[i, j].colour == "white"))
                                {
                                    return true;
                                }
                                else
                                {
                                    breakLoop = true;
                                    break;
                                }
                            }
                            else
                            {
                                breakLoop = true;
                                break;
                            }
                        }
                    }                    
                }

                if (breakLoop)
                {
                    break;
                }
            }

            //horizontals
            for (int i = x + 1; i < 8; i++) // right
            {
                if (!Globals.IsPositionEmpty(i, y, board))
                {
                    if (DifferentColour(i, y, board))
                    {
                        if (board[i, y].pieceType == "rook" || board[i, y].pieceType == "queen")
                        {
                            return true;
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
            }
            for (int i = x - 1; i > -1; i--) // left
            {
                if (!Globals.IsPositionEmpty(i, y, board))
                {
                    if (DifferentColour(i, y, board))
                    {
                        if (board[i, y].pieceType == "rook" || board[i, y].pieceType == "queen")
                        {
                            return true;
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
            }

            //verticals
            for (int i = y + 1; i < 8; i++) // down
            {
                if (!Globals.IsPositionEmpty(x, i, board))
                {
                    if (DifferentColour(x, i, board))
                    {
                        if (board[x, i].pieceType == "rook" || board[x, i].pieceType == "queen")
                        {
                            return true;
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
            }
            for (int i = y - 1; i > -1; i--) // up
            {
                if (!Globals.IsPositionEmpty(x, i, board))
                {
                    if (DifferentColour(x, i, board))
                    {
                        if (board[x, i].pieceType == "rook" || board[x, i].pieceType == "queen")
                        {
                            return true;
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
            }

            //knights
            if (x < 7 && y < 6)
            {
                if (!Globals.IsPositionEmpty(x + 1, y + 2, board))
                {
                    if (DifferentColour(x + 1, y + 2, board))
                    {
                        if (board[x + 1, y + 2].pieceType == "knight")
                        {
                            return true;
                        }
                    }                    
                }                
            }
            if (x < 7 && y > 1)
            {
                if (!Globals.IsPositionEmpty(x + 1, y - 2, board))
                {
                    if (DifferentColour(x + 1, y - 2, board))
                    {
                        if (board[x + 1, y - 2].pieceType == "knight")
                        {
                            return true;
                        }
                    }
                }                
            }
            if (x > 0 && y < 6)
            {
                if (!Globals.IsPositionEmpty(x - 1, y + 2, board))
                {
                    if (DifferentColour(x - 1, y + 2, board))
                    {
                        if (board[x - 1, y + 2].pieceType == "knight")
                        {
                            return true;
                        }
                    }
                }                
            }
            if (x > 0 && y > 1)
            {
                if (!Globals.IsPositionEmpty(x - 1, y - 2, board))
                {
                    if (DifferentColour(x - 1, y - 2, board))
                    {
                        if (board[x - 1, y - 2].pieceType == "knight")
                        {
                            return true;
                        }
                    }
                }                
            }
            if (x > 1 && y < 7)
            {
                if (!Globals.IsPositionEmpty(x - 2, y + 1, board))
                {
                    if (DifferentColour(x - 2, y + 1, board))
                    {
                        if (board[x - 2, y + 1].pieceType == "knight")
                        {
                            return true;
                        }
                    }                    
                }                
            }
            if (x > 1 && y > 0)
            {
                if (!Globals.IsPositionEmpty(x - 2, y - 1, board))
                {
                    if (DifferentColour(x - 2, y - 1, board))
                    {
                        if (board[x - 2, y - 1].pieceType == "knight")
                        {
                            return true;
                        }
                    }                    
                }                
            }
            if (x < 6 && y > 0)
            {
                if (!Globals.IsPositionEmpty(x + 2, y - 1, board))
                {
                    if (DifferentColour(x + 2, y - 1, board))
                    {
                        if (board[x + 2, y - 1].pieceType == "knight")
                        {
                            return true;
                        }
                    }                    
                }
            }
            if (x < 6 && y < 7)
            {
                if (!Globals.IsPositionEmpty(x + 2, y + 1, board))
                {
                    if (DifferentColour(x + 2, y + 1, board))
                    {
                        if (board[x + 2, y + 1].pieceType == "knight")
                        {
                            return true;
                        }
                    }
                }                
            }

            return false;
        }

        public bool Checkmate(int x, int y, Piece[,] board)
        {
            if (!Check(x, y, board))
            {
                return false; // if the king is not in check it is impossible for it to be checkmate
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!Globals.IsPositionEmpty(i, j, board))
                    {
                        if (!DifferentColour(i, j, board))
                        {
                            bool[,] possibleMoves = new bool[8, 8];
                            possibleMoves = board[i, j].PossibleMoves(possibleMoves, board);

                            for (int k = 0; k < 8; k++)
                            {
                                for (int l = 0; l < 8; l++)
                                {
                                    if (possibleMoves[k, l])
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            return true; // no pieces can move legally and the king is in check therefore it is checkmate
        }
    }
}