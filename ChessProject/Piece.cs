using System.Drawing;

namespace ChessProject
{
    public class Piece
    {
        public string pieceType;                            // Stores the type of piece
        public string colour;                               // Stores the colour of the piece
        public int xGridPos;                                // Stores the x-ordinate of the piece (0 - 7)
        public int yGridPos;                                // Stores the y-ordinate of the piece (0 - 7)
        public int newX;                                    // Stores the new x-ordinate when moving
        public int newY;                                    // Stores the new y-ordinate when moving
        public int strength;                                // Used to determine the relative strength of each piece type
        
        public virtual bool[,] PossibleMoves(bool[,] possibleMoves, Piece[,] board)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    possibleMoves[i, j] = false;
                }
            }

            return possibleMoves;
        }

        public bool DifferentColour(int x, int y, Piece[,] board)
        {
            if (colour != board[x, y].colour)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddPiece(Piece piece, Piece[,] board)
        {
            board[xGridPos, yGridPos] = piece;
        }

        public void RemovePiece(Piece piece)
        {
            Globals.grid[piece.xGridPos, piece.yGridPos] = null;
            Globals.pieceImages[piece.xGridPos, piece.yGridPos].Visible = false;
            Globals.pieceImages[piece.xGridPos, piece.yGridPos] = null;
            Globals.takenPiece = piece;
        }

        public void UpdatePosition(Piece piece, int currentX, int currentY, int newX, int newY)
        {
            if (Globals.IsPositionEmpty(newX, newY, Globals.grid))
            {
                Globals.grid[currentX, currentY] = null;
                Globals.grid[newX, newY] = piece;
            }
            else
            {
                RemovePiece(Globals.grid[newX, newY]);
                Globals.grid[currentX, currentY] = null;
                Globals.grid[newX, newY] = piece;
            }

            Globals.pieceImages[newX, newY] = Globals.pieceImages[currentX, currentY];
            Globals.pieceImages[currentX, currentY] = null;
            Globals.pieceImages[newX, newY].Location = new Point(100 + (150 * newX), 100 + (150 * newY));
            
            if ((newX == 0 || newX == 2 || newX == 4 || newX == 6) && (newY == 0 || newY == 2 || newY == 4 || newY == 6))
            {
                Globals.pieceImages[newX, newY].BackColor = Color.LightYellow;
            }
            else if ((newX == 1 || newX == 3 || newX == 5 || newX == 7) && (newY == 1 || newY == 3 || newY == 5 || newY == 7))
            {
                Globals.pieceImages[newX, newY].BackColor = Color.LightYellow;
            }
            else
            {
                Globals.pieceImages[newX, newY].BackColor = Color.Brown;
            }

            piece.xGridPos = newX;
            piece.yGridPos = newY;
        }                                      
    }
}