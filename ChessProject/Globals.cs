using System.Windows.Forms;

namespace ChessProject
{
    public static class Globals
    {
        public static Piece[,] grid = new Piece[8, 8];                      // Stores the location of pieces
        public static Piece takenPiece;                                     // Stores a removed piece
        public static PictureBox[,] pieceImages = new PictureBox[8, 8];     // Stores the location of images
        public static bool whiteTurn = true;                                // Stores whose turn it is: true if white's turn, false if black's turn
        public static int kingX = 0;                                        // Stores the x position of the king which has been fetched
        public static int kingY = 0;                                        // Stores the y position of the king which has been fetched

        public static bool IsPositionEmpty(int x, int y, Piece[,] board)
        {
            if (board[x, y] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void GetKing(string colour, Piece[,] board)
        {
            // Fetches the king of either white or black and sets the global variables kingX and kingY to the co-ordinates of the king
            // These co-ordinates are used when checking for check and checkmate outside of the King class

            bool kingFound = false;

            do
            {
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (!IsPositionEmpty(i, j, board))
                        {
                            if (board[i, j].pieceType == "king" && board[i, j].colour == colour)
                            {
                                kingX = i;
                                kingY = j;
                                kingFound = true;
                            }
                        }
                        if (kingFound)
                        {
                            break;
                        }
                    }

                    if (kingFound)
                    {
                        break;
                    }
                }
            } while (!kingFound);            
        }

        public static int GetPieceCount(Piece[,] board)
        {
            int pieceCount = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!IsPositionEmpty(i, j, board))
                    {
                        pieceCount++;
                    }
                    if (pieceCount == 32)
                    {
                        break;
                    }
                }

                if (pieceCount == 32)
                {
                    break;
                }
            }

            return pieceCount;
        }
    }
}