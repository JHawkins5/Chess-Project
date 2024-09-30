using System;
using System.Collections.Generic;

namespace ChessProject
{
    class AI
    {
        public static int searchDepth = 3;                                  // Sets the default search depth. This is decremented during the minimax search
        public static List<int> moveScores = new List<int>();               // Stores the scores of each move to determine the best move
        public static List<Piece> movedPieces = new List<Piece>();          // Stores the pieces which make the moves in the search       
        public static int resultPos;                                        // Stores the position of the result in movedPieces

        public static Piece[,] DuplicateBoard(Piece[,] newBoard, Piece[,] oldBoard) // Duplicates a board to use in move generation or checking
        {
            int pieceCount = Globals.GetPieceCount(oldBoard);
            int piecesDuplicated = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!Globals.IsPositionEmpty(i, j, oldBoard))
                    {
                        newBoard[i, j] = oldBoard[i, j];
                        piecesDuplicated++;
                    }
                    if (pieceCount == piecesDuplicated)
                    {
                        break;
                    }
                }

                if (pieceCount == piecesDuplicated)
                {
                    break;
                }
            }

            return newBoard;
        }

        public static List<Piece[,]> GenerateMoves(Piece[,] board, int depth, bool whiteTurn) // Generates all possible moves for every piece of a specified colour
        {
            bool[,] possibleMoves = new bool[8, 8];
            List<Piece[,]> moves = new List<Piece[,]>();
            int pieceCount = Globals.GetPieceCount(board);
            int piecesChecked = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (whiteTurn)
                    {
                        if (!Globals.IsPositionEmpty(i, j, board) && board[i, j].colour == "white")
                        {
                            possibleMoves = board[i, j].PossibleMoves(possibleMoves, board);
                            piecesChecked++;
                        }
                    }
                    else
                    {
                        if (!Globals.IsPositionEmpty(i, j, board) && board[i, j].colour == "black")
                        {
                            possibleMoves = board[i, j].PossibleMoves(possibleMoves, board);
                            piecesChecked++;
                        }
                    }

                    for (int k = 0; k < 8; k++)
                    {
                        for (int l = 0; l < 8; l++)
                        {
                            if (possibleMoves[k, l])
                            {
                                if (!Globals.IsPositionEmpty(i, j, board))
                                {
                                    Piece[,] move = new Piece[8, 8];
                                    move = DuplicateBoard(move, board);
                                    AIUpdatePosition(move[i, j], i, j, k, l, move);                                    
                                    moves.Add(move);
                                    board[i, j].newX = k;
                                    board[i, j].newY = l;

                                    if (depth == searchDepth && board[i, j].colour == "black")
                                    {
                                        movedPieces.Add(board[i, j]);
                                    }
                                }
                            }
                        }
                    }

                    if (pieceCount == piecesChecked)
                    {
                        break;
                    }
                }

                if (pieceCount == piecesChecked)
                {
                    break;
                }
            }

            return moves;
        }

        public static int Evaluation(Piece[,] board, bool checkForWhite) // Calculates the balance of play
        {
            int evaluation = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!Globals.IsPositionEmpty(i, j, board))
                    {
                        if (board[i, j].colour == "white")
                        {
                            evaluation += board[i, j].strength;
                        }
                        else
                        {
                            evaluation -= board[i, j].strength;
                        }
                    }
                }
            }

            if (checkForWhite)
            {
                return evaluation;
            }
            else
            {
                return evaluation * -1;
            }
        }

        public static int Minimax(Piece[,] board, int depth, bool maximisingPlayer, bool whiteTurn, int alpha, int beta) // Searches through the possible moves to find the best one
        {
            // This code is taken from a stackoverflow user called foRei
            // I have added alpha-beta pruning to their algorithm to optimise the search
            // The code used is the solution at the bottom of this webpage:
            // https://stackoverflow.com/questions/66082633/minimax-algorithm-with-chess-in-c-sharp-not-working-properly

            if (depth == 0) // Base case, evaluates the board passed into the minimax algorithm and returns the result
            {
                int result = Evaluation(board, whiteTurn);
                return result;
            }

            List<Piece[,]> moves = GenerateMoves(board, depth, whiteTurn);

            if (maximisingPlayer)
            {
                int value = -1290;

                foreach (Piece[,] move in moves)
                {
                    int minimaxResult = Minimax(move, depth - 1, false, !whiteTurn, alpha, beta);
                    value = Math.Max(value, minimaxResult);
                    alpha = Math.Max(alpha, value);

                    if (beta <= alpha)
                    {
                        break; // No need to continue searching
                    }

                    if (depth == searchDepth)
                    {
                        moveScores.Add(minimaxResult); // If this is the first layer of the search, add the score to the list to access later
                        resultPos = moveScores.IndexOf(minimaxResult);
                    }
                }

                return value;
            }
            else
            {
                int value = 1290;

                foreach (Piece[,] move in moves)
                {
                    int minimaxResult = Minimax(move, depth - 1, true, !whiteTurn, alpha, beta);
                    value = Math.Min(value, minimaxResult);
                    beta = Math.Min(beta, value);

                    if (beta <= alpha)
                    {
                        break;
                    }

                    if (depth == searchDepth)
                    {
                        moveScores.Add(minimaxResult);
                        resultPos = moveScores.IndexOf(minimaxResult);
                    }
                }

                return value;
            }
        }

        public static void AIRemovePiece(Piece piece, Piece[,] board)
        {
            board[piece.xGridPos, piece.yGridPos] = null;
        }

        public static void AIUpdatePosition(Piece piece, int currentX, int currentY, int newX, int newY, Piece[,] board)
        {
            if (piece != null)
            {
                if (Globals.IsPositionEmpty(newX, newY, board))
                {
                    board[currentX, currentY] = null;
                    board[newX, newY] = piece;
                }
                else
                {
                    AIRemovePiece(board[newX, newY], board);
                    board[currentX, currentY] = null;
                    board[newX, newY] = piece;
                }

                if (piece.pieceType == "pawn")
                {
                    Pawn pawnConvert = (Pawn)piece;

                    if (pawnConvert.colour == "white")
                    {
                        if (pawnConvert.yGridPos == 0)
                        {
                            AIQueenConvert(pawnConvert, board);
                        }
                    }
                    else
                    {
                        if (pawnConvert.yGridPos == 7)
                        {
                            AIQueenConvert(pawnConvert, board);
                        }
                    }
                }
            }
        }

        public static void AIQueenConvert(Pawn pawn, Piece[,] board)
        {
            AIRemovePiece(pawn, board);
            Queen newQueen = new Queen();
            newQueen.colour = pawn.colour;
            newQueen.pieceType = "queen";
            newQueen.xGridPos = pawn.xGridPos;
            newQueen.yGridPos = pawn.yGridPos;
        }

        public static Piece Turn()
        {
            if (moveScores.Count > 0)
            {
                moveScores.Clear();
            }
            if (movedPieces.Count > 0)
            {
                movedPieces.Clear();
            }

            Piece[,] board = new Piece[8, 8]; 
            board = DuplicateBoard(board, Globals.grid);
            Minimax(board, searchDepth, false, false, -1290, 1290);
            Piece movingPiece = movedPieces[resultPos];

            bool[,] possibleMoves = new bool[8, 8];
            possibleMoves = movingPiece.PossibleMoves(possibleMoves, Globals.grid);
            Globals.grid[movingPiece.xGridPos, movingPiece.yGridPos].UpdatePosition(movingPiece, movingPiece.xGridPos, movingPiece.yGridPos, movingPiece.newX, movingPiece.newY);
            return movingPiece;
        }
    }
}