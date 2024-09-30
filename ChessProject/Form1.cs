using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ChessProject
{
    public partial class Form1 : Form
    {
        public string fileSave = "savedGame.txt";               // The name of the file which will store saved games
        public bool whiteWin = false;                           // Stores whether white has won
        public bool timeEnabled = false;                        // Stores whether the users are playing against the clock
        public bool gamePaused = false;                         // Stores whether the game is paused
        public bool gameOver = false;                           // Stores whether the game has finished
        public bool playerVComputer = false;                    // Stores whether the game is one or two player
        public bool stalemate = false;                          // Stores whether the game has resulted in stalemate
        public bool checkmate = false;                          // Stores whether the game has resulted in checkmate
        public int whiteTimer;                                  // Stores the time the white player has left
        public int blackTimer;                                  // Stores the time the black player has left
        public int timeLimit;                                   // Stores the time limit for each player
        public Stopwatch whiteStopwatch = new Stopwatch();      // Stopwatch to measure white's time
        public Stopwatch blackStopwatch = new Stopwatch();      // Stopwatch to measure black's time
        public Piece movedPiece;                                // Stores the piece which moved most recently

        public Form1()
        {
            InitializeComponent();
        }

        public void CreatePawn(int i, int j)
        {
            Pawn newPawn = new Pawn();
            newPawn.pieceType = "pawn";
            PictureBox newPictureBox = new PictureBox();

            if (i == 0)
            {
                newPawn.colour = "white";
                newPawn.xGridPos = j;
                newPawn.yGridPos = 6;
                newPawn.strength = 10;
            }
            else
            {
                newPawn.colour = "black";
                newPawn.xGridPos = j;
                newPawn.yGridPos = 1;
                newPawn.strength = -10;
            }

            newPawn.AddPiece(newPawn, Globals.grid);
            CreatePieceImages(newPawn, newPictureBox, newPawn.colour);
        }

        public void CreateKnight(int i, int j)
        {
            Knight newKnight = new Knight();
            newKnight.pieceType = "knight";
            PictureBox newPictureBox = new PictureBox();

            if (i == 0)
            {
                if (j == 0)
                {
                    newKnight.colour = "white";
                    newKnight.xGridPos = 1;
                    newKnight.yGridPos = 7;
                }
                else
                {
                    newKnight.colour = "white";
                    newKnight.xGridPos = 6;
                    newKnight.yGridPos = 7;
                }

                newKnight.strength = 30;
            }
            else
            {
                if (j == 0)
                {
                    newKnight.colour = "black";
                    newKnight.xGridPos = 1;
                    newKnight.yGridPos = 0;
                }
                else
                {
                    newKnight.colour = "black";
                    newKnight.xGridPos = 6;
                    newKnight.yGridPos = 0;
                }

                newKnight.strength = -30;
            }

            newKnight.AddPiece(newKnight, Globals.grid);
            CreatePieceImages(newKnight, newPictureBox, newKnight.colour);
        }

        public void CreateRook(int i, int j)
        {
            Rook newRook = new Rook();
            newRook.pieceType = "rook";
            PictureBox newPictureBox = new PictureBox();

            if (i == 0)
            {
                if (j == 0)
                {
                    newRook.colour = "white";
                    newRook.xGridPos = 0;
                    newRook.yGridPos = 7;
                }
                else
                {
                    newRook.colour = "white";
                    newRook.xGridPos = 7;
                    newRook.yGridPos = 7;
                }

                newRook.strength = 50;
            }
            else
            {
                if (j == 0)
                {
                    newRook.colour = "black";
                    newRook.xGridPos = 0;
                    newRook.yGridPos = 0;
                }
                else
                {
                    newRook.colour = "black";
                    newRook.xGridPos = 7;
                    newRook.yGridPos = 0;
                }

                newRook.strength = -50;
            }

            newRook.AddPiece(newRook, Globals.grid);
            CreatePieceImages(newRook, newPictureBox, newRook.colour);
        }
        
        public void CreateBishop(int i, int j)
        {
            Bishop newBishop = new Bishop();
            newBishop.pieceType = "bishop";
            PictureBox newPictureBox = new PictureBox();

            if (i == 0)
            {
                if (j == 0)
                {
                    newBishop.colour = "white";
                    newBishop.xGridPos = 2;
                    newBishop.yGridPos = 7;
                }
                else
                {
                    newBishop.colour = "white";
                    newBishop.xGridPos = 5;
                    newBishop.yGridPos = 7;
                }

                newBishop.strength = 30;
            }
            else
            {
                if (j == 0)
                {
                    newBishop.colour = "black";
                    newBishop.xGridPos = 2;
                    newBishop.yGridPos = 0;
                }
                else
                {
                    newBishop.colour = "black";
                    newBishop.xGridPos = 5;
                    newBishop.yGridPos = 0;
                }

                newBishop.strength = -30;
            }

            newBishop.AddPiece(newBishop, Globals.grid);
            CreatePieceImages(newBishop, newPictureBox, newBishop.colour);
        }

        public void CreateKing(int i)
        {
            King newKing = new King();
            newKing.pieceType = "king";
            PictureBox newPictureBox = new PictureBox();

            if (i == 0)
            {
                newKing.colour = "white";
                newKing.xGridPos = 4;
                newKing.yGridPos = 7;
                newKing.strength = 900;
            }
            else
            {
                newKing.colour = "black";
                newKing.xGridPos = 4;
                newKing.yGridPos = 0;
                newKing.strength = -900;
            }

            newKing.AddPiece(newKing, Globals.grid);
            CreatePieceImages(newKing, newPictureBox, newKing.colour);
        }

        public void CreateQueen(int i)
        {
            Queen newQueen = new Queen();
            newQueen.pieceType = "queen";
            PictureBox newPictureBox = new PictureBox();

            if (i == 0)
            {
                newQueen.colour = "white";
                newQueen.xGridPos = 3;
                newQueen.yGridPos = 7;
                newQueen.strength = 90;
            }
            else
            {
                newQueen.colour = "black";
                newQueen.xGridPos = 3;
                newQueen.yGridPos = 0;
                newQueen.strength = -90;
            }

            newQueen.AddPiece(newQueen, Globals.grid);
            CreatePieceImages(newQueen, newPictureBox, newQueen.colour);
        }

        public void CreatePieces()
        {
            for (int i = 0; i < 2; i++)
            {
                CreateQueen(i);
                CreateKing(i);
                
                for (int j = 0; j < 2; j++)
                {
                    CreateRook(i, j);
                    CreateKnight(i, j);
                    CreateBishop(i, j);
                }

                for (int j = 0; j < 8; j++)
                {
                    CreatePawn(i, j);
                }
            }
        }

        public void CreatePieceImages(Piece piece, PictureBox newPictureBox, string colour)
        {
            if (piece.pieceType == "king")
            {
                if (colour == "white")
                {
                    newPictureBox.Image = PieceImages.king_white;
                }
                else if (colour == "black")
                {
                    newPictureBox.Image = PieceImages.king_black;
                }
            }
            else if (piece.pieceType == "queen")
            {
                if (colour == "white")
                {
                    newPictureBox.Image = PieceImages.queen_white;
                }
                else if (colour == "black")
                {
                    newPictureBox.Image = PieceImages.queen_black;
                }
            }
            else if (piece.pieceType == "bishop")
            {
                if (colour == "white")
                {
                    newPictureBox.Image = PieceImages.bishop_white;
                }
                else if (colour == "black")
                {
                    newPictureBox.Image = PieceImages.bishop_black;
                }
            }
            else if (piece.pieceType == "knight")
            {
                if (colour == "white")
                {
                    newPictureBox.Image = PieceImages.knight_white;
                }
                else if (colour == "black")
                {
                    newPictureBox.Image = PieceImages.knight_black;
                }
            }
            else if (piece.pieceType == "rook")
            {
                if (colour == "white")
                {
                    newPictureBox.Image = PieceImages.rook_white;
                }
                else if (colour == "black")
                {
                    newPictureBox.Image = PieceImages.rook_black;
                }
            }
            else if (piece.pieceType == "pawn")
            {
                if (colour == "white")
                {
                    newPictureBox.Image = PieceImages.pawn_white;
                }
                else if (colour == "black")
                {
                    newPictureBox.Image = PieceImages.pawn_black;
                }
            }

            newPictureBox.Location = new Point(100 + (150 * piece.xGridPos), 100 + (150 * piece.yGridPos));

            Controls.Add(newPictureBox);
            newPictureBox.BringToFront();
            newPictureBox.Size = new Size(150, 150);
            Globals.pieceImages[piece.xGridPos, piece.yGridPos] = newPictureBox;

            if ((piece.xGridPos == 0 || piece.xGridPos == 2 || piece.xGridPos == 4 || piece.xGridPos == 6) && (piece.yGridPos == 0 || piece.yGridPos == 2 || piece.yGridPos == 4 || piece.yGridPos == 6))
            {
                newPictureBox.BackColor = Color.LightYellow;
            }
            else if ((piece.xGridPos == 1 || piece.xGridPos == 3 || piece.xGridPos == 5 || piece.xGridPos == 7) && (piece.yGridPos == 1 || piece.yGridPos == 3 || piece.yGridPos == 5 || piece.yGridPos == 7))
            {
                newPictureBox.BackColor = Color.LightYellow;
            }
            else
            {
                newPictureBox.BackColor = Color.Brown;
            }
        }

        private void AddLabel(int i)
        {
            Label newLabelX = new Label();
            newLabelX.Text = Convert.ToString(i + 1);
            newLabelX.Location = new Point(150 + (150 * i), (150 * 8) + 125);
            newLabelX.Size = new Size(50, 50);

            Label newLabelY = new Label();
            newLabelY.Text = Convert.ToString(i + 1);
            newLabelY.Location = new Point(50, 150 + (150 * i));
            newLabelY.Size = new Size(50, 50);

            Controls.Add(newLabelX);
            Controls.Add(newLabelY);
        }

        private void AddPanel(int i, int j)
        {
            Panel newPanel = new Panel();
            newPanel.Size = new Size(150, 150);
            newPanel.Location = new Point(100 + (150 * i), 100 + (150 * j));

            Controls.Add(newPanel);

            if (i % 2 == 0)
            {
                if (j % 2 != 0)
                {
                    newPanel.BackColor = Color.Brown;
                }
                else
                {
                    newPanel.BackColor = Color.LightYellow;
                }
            }
            else
            {
                if (j % 2 != 0)
                {
                    newPanel.BackColor = Color.LightYellow;
                }
                else
                {
                    newPanel.BackColor = Color.Brown;
                }
            }
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                AddLabel(i);

                for (int j = 0; j < 8; j++)
                {
                    AddPanel(i, j);
                }
            }

            WindowState = FormWindowState.Maximized;
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            CreatePieces();
            Globals.whiteTurn = true;
            SetModeButton.Enabled = true;
            ModeGroupBox.Enabled = true;
            OnePlayerRadioButton.Enabled = true;
            TwoPlayerRadioButton.Enabled = true;
            WhiteTakenListBox.Items.Clear();
            BlackTakenListBox.Items.Clear();
        }

        private void SaveGameButton_Click(object sender, EventArgs e)
        {
            // This saves the state of the game to a file called saveGame.txt
            // The file stores each piece and its colour and location
            // The data is stored in this order as this is the order it will be read in when loading a game
            // If the game is being played against the clock, the timers for each player will also be saved
            // The mode will also be saved (one player or two player)

            if (!gameOver)
            {
                StreamWriter sw = new StreamWriter(fileSave);

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        if (!Globals.IsPositionEmpty(i, j, Globals.grid))
                        {
                            Piece piece = Globals.grid[i, j];
                            sw.WriteLine(piece.pieceType);
                            sw.WriteLine(piece.colour);
                            sw.WriteLine(Convert.ToString(piece.xGridPos));
                            sw.WriteLine(Convert.ToString(piece.yGridPos));
                        }
                    }
                }

                if (timeEnabled)
                {
                    sw.WriteLine(Convert.ToString(whiteTimer));
                    sw.WriteLine(Convert.ToString(blackTimer));
                }

                if (playerVComputer)
                {
                    sw.WriteLine("One player");
                }
                else
                {
                    sw.WriteLine("Two players");
                }

                if (Globals.whiteTurn)
                {
                    sw.WriteLine("White");
                }
                else
                {
                    sw.WriteLine("Black");
                }

                sw.Close();
            }
        }

        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            // This reads from the file savedGame.txt until it reaches an empty line
            // It reads in the order: piece type, colour, x-ordinate, y-ordinate
            // It then creates a new piece and an image and adds them to the game
            // After loading the pieces it loads whether the game is being played against the clock
            // If it is, the timers for the game will be loaded, and the timeEnabled variable will be set to true
            // Then it loads the game mode (one player or two player) and sets the game accordingly

            if (File.Exists(fileSave))
            {
                StreamReader sr = new StreamReader(fileSave);
                string line;
                int i = 0;

                do
                {
                    line = sr.ReadLine();

                    if (line == "pawn")
                    {
                        Pawn newPawn = new Pawn();
                        newPawn.pieceType = line;
                        line = sr.ReadLine();
                        newPawn.colour = line;
                        line = sr.ReadLine();
                        newPawn.xGridPos = Convert.ToInt32(line);
                        line = sr.ReadLine();
                        newPawn.yGridPos = Convert.ToInt32(line);
                        PictureBox newPictureBox = new PictureBox();
                        newPawn.AddPiece(newPawn, Globals.grid);
                        CreatePieceImages(newPawn, newPictureBox, newPawn.colour);

                        if (newPawn.colour == "white")
                        {
                            newPawn.strength = 10;
                        }
                        else
                        {
                            newPawn.strength = -10;
                        }
                    }
                    else if (line == "king")
                    {
                        King newKing = new King();
                        newKing.pieceType = line;
                        line = sr.ReadLine();
                        newKing.colour = line;
                        line = sr.ReadLine();
                        newKing.xGridPos = Convert.ToInt32(line);
                        line = sr.ReadLine();
                        newKing.yGridPos = Convert.ToInt32(line);
                        PictureBox newPictureBox = new PictureBox();
                        newKing.AddPiece(newKing, Globals.grid);
                        CreatePieceImages(newKing, newPictureBox, newKing.colour);

                        if (newKing.colour == "white")
                        {
                            newKing.strength = 900;
                        }
                        else
                        {
                            newKing.strength = -900;
                        }
                    }
                    else if (line == "queen")
                    {
                        Queen newQueen = new Queen();
                        newQueen.pieceType = line;
                        line = sr.ReadLine();
                        newQueen.colour = line;
                        line = sr.ReadLine();
                        newQueen.xGridPos = Convert.ToInt32(line);
                        line = sr.ReadLine();
                        newQueen.yGridPos = Convert.ToInt32(line);
                        PictureBox newPictureBox = new PictureBox();
                        newQueen.AddPiece(newQueen, Globals.grid);
                        CreatePieceImages(newQueen, newPictureBox, newQueen.colour);

                        if (newQueen.colour == "white")
                        {
                            newQueen.strength = 90;
                        }
                        else
                        {
                            newQueen.strength = -90;
                        }
                    }
                    else if (line == "bishop")
                    {
                        Bishop newBishop = new Bishop();
                        newBishop.pieceType = line;
                        line = sr.ReadLine();
                        newBishop.colour = line;
                        line = sr.ReadLine();
                        newBishop.xGridPos = Convert.ToInt32(line);
                        line = sr.ReadLine();
                        newBishop.yGridPos = Convert.ToInt32(line);
                        PictureBox newPictureBox = new PictureBox();
                        newBishop.AddPiece(newBishop, Globals.grid);
                        CreatePieceImages(newBishop, newPictureBox, newBishop.colour);

                        if (newBishop.colour == "white")
                        {
                            newBishop.strength = 30;
                        }
                        else
                        {
                            newBishop.strength = -30;
                        }
                    }
                    else if (line == "rook")
                    {
                        Rook newRook = new Rook();
                        newRook.pieceType = line;
                        line = sr.ReadLine();
                        newRook.colour = line;
                        line = sr.ReadLine();
                        newRook.xGridPos = Convert.ToInt32(line);
                        line = sr.ReadLine();
                        newRook.yGridPos = Convert.ToInt32(line);
                        PictureBox newPictureBox = new PictureBox();
                        newRook.AddPiece(newRook, Globals.grid);
                        CreatePieceImages(newRook, newPictureBox, newRook.colour);

                        if (newRook.colour == "white")
                        {
                            newRook.strength = 50;
                        }
                        else
                        {
                            newRook.strength = -50;
                        }
                    }
                    else if (line == "knight")
                    {
                        Knight newKnight = new Knight();
                        newKnight.pieceType = line;
                        line = sr.ReadLine();
                        newKnight.colour = line;
                        line = sr.ReadLine();
                        newKnight.xGridPos = Convert.ToInt32(line);
                        line = sr.ReadLine();
                        newKnight.yGridPos = Convert.ToInt32(line);
                        PictureBox newPictureBox = new PictureBox();
                        newKnight.AddPiece(newKnight, Globals.grid);
                        CreatePieceImages(newKnight, newPictureBox, newKnight.colour);

                        if (newKnight.colour == "white")
                        {
                            newKnight.strength = 30;
                        }
                        else
                        {
                            newKnight.strength = -30;
                        }
                    }
                    else if (Int32.TryParse(line, out i))
                    {
                        whiteTimer = Convert.ToInt32(line);
                        line = sr.ReadLine();
                        blackTimer = Convert.ToInt32(line);
                    }
                    else if (line == "One player")
                    {
                        playerVComputer = true;
                    }
                    else if (line == "Two players")
                    {
                        playerVComputer = false;
                    }
                    else if (line == "White")
                    {
                        Globals.whiteTurn = true;
                    }
                    else if (line == "Black")
                    {
                        Globals.whiteTurn = false;
                    }
                } while (line != null);

                sr.Close();
                StartGameButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("There is no saved game.");
            }
        }

        private void SetTimerButton_Click(object sender, EventArgs e)
        {
            timeEnabled = true;

            if (OneMinRadioButton.Checked)
            {
                timeLimit = 60;
                WhiteTimer.Text = "1:00";
                BlackTimer.Text = "1:00";
            }
            else if (FiveMinRadioButton.Checked)
            {
                timeLimit = 300;
                WhiteTimer.Text = "5:00";
                BlackTimer.Text = "5:00";
            }
            else if (TenMinRadioButton.Checked)
            {
                timeLimit = 600;
                WhiteTimer.Text = "10:00";
                BlackTimer.Text = "10:00";
            }

            WhiteTimer.Visible = true;
            BlackTimer.Visible = true;
            WhiteTimer.ForeColor = Color.Green;
            BlackTimer.ForeColor = Color.Green;
            whiteTimer = timeLimit;
            blackTimer = timeLimit;

            StartGameButton.Enabled = true;
        }

        private void SetModeButton_Click(object sender, EventArgs e)
        {
            if (OnePlayerRadioButton.Checked)
            {
                playerVComputer = true;
                StartGameButton.Enabled = true;
            }
            else if (TwoPlayerRadioButton.Checked)
            {
                playerVComputer = false;
                StartGameButton.Enabled = true;
                SetTimerButton.Enabled = true;
                TimeGroupBox.Enabled = true;
                OneMinRadioButton.Enabled = true;
                FiveMinRadioButton.Enabled = true;
                TenMinRadioButton.Enabled = true;
            }
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            StartGameButton.Enabled = false;
            PauseGameButton.Enabled = true;
            gameOver = false;
            gamePaused = false;
            NewGameButton.Enabled = false;
            LoadGameButton.Enabled = false;
            SaveGameButton.Enabled = true;
            SetTimerButton.Enabled = false;
            TimeGroupBox.Enabled = false;
            SetModeButton.Enabled = false;
            ModeGroupBox.Enabled = false;
            MoveLabel.Visible = true;
            TurnLabel.Visible = true;
            CurrentXTextBox.Enabled = true;
            CurrentYTextBox.Enabled = true;
            NewXTextBox.Enabled = true;
            NewYTextBox.Enabled = true;
            MoveButton.Enabled = true;

            if (timeEnabled)
            {
                whiteStopwatch.Start();
                WhiteTimer.ForeColor = Color.Red;
            }
        }

        private void PauseGameButton_Click(object sender, EventArgs e)
        {
            gamePaused = true;

            if (timeEnabled)
            {
                if (Globals.whiteTurn)
                {
                    whiteStopwatch.Stop();
                    WhiteTimer.Text = Convert.ToString(whiteTimer / 60) + ":" + Convert.ToString(whiteTimer % 60);
                }
                else
                {
                    blackStopwatch.Stop();
                    BlackTimer.Text = Convert.ToString(blackTimer / 60) + ":" + Convert.ToString(blackTimer % 60);
                }
            }

            StartGameButton.Enabled = true;
            PauseGameButton.Enabled = false;
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            string currentXStr = CurrentXTextBox.Text;
            string currentYStr = CurrentYTextBox.Text;
            string newXStr = NewXTextBox.Text;
            string newYStr = NewYTextBox.Text;
            string colour;

            CurrentXTextBox.Clear();
            CurrentYTextBox.Clear();
            NewXTextBox.Clear();
            NewYTextBox.Clear();

            if (Globals.whiteTurn)
            {
                colour = "white";
            }
            else
            {
                colour = "black";
            }

            if (currentXStr == "" || currentYStr == "" || newXStr == "" || newYStr == "")
            {
                MoveLabel.Text = "Please enter a number in all boxes.";
            }
            else if (currentXStr.Length > 1 || currentYStr.Length > 1 || newXStr.Length > 1 || newYStr.Length > 1)
            {
                MoveLabel.Text = "Please enter a single digit from 1 to 8 in all boxes.";
            }
            else
            {
                if (!(Convert.ToChar(currentXStr) >= 49 && Convert.ToChar(currentXStr) <= 56) && (Convert.ToChar(currentYStr) >= 49 && Convert.ToChar(currentYStr) <= 56) && (Convert.ToChar(newXStr) >= 49 && Convert.ToChar(newXStr) <= 56) && (Convert.ToChar(newYStr) >= 49 && Convert.ToChar(newYStr) <= 56))
                {
                    MoveLabel.Text = "Please enter a single digit from 1 to 8 in all boxes.";
                }
                else
                {
                    int currentX = Convert.ToInt32(currentXStr) - 1;
                    int currentY = Convert.ToInt32(currentYStr) - 1;

                    if (!Globals.IsPositionEmpty(currentX, currentY, Globals.grid))
                    {
                        if (Globals.grid[currentX, currentY].colour == colour)
                        {
                            int newX = Convert.ToInt32(newXStr) - 1;
                            int newY = Convert.ToInt32(newYStr) - 1;

                            Piece piece = Globals.grid[currentX, currentY];
                            bool[,] possibleMoves = new bool[8, 8];
                            possibleMoves = piece.PossibleMoves(possibleMoves, Globals.grid);

                            if (possibleMoves[newX, newY])
                            {
                                piece.UpdatePosition(piece, currentX, currentY, newX, newY);

                                if (colour == "white")
                                {
                                    MoveLabel.Text = string.Format("White has moved a white {0} to ({1}, {2}).", piece.pieceType, newX + 1, newY + 1);
                                }
                                else
                                {
                                    MoveLabel.Text = string.Format("Black has moved a black {0} to ({1}, {2}).", piece.pieceType, newX + 1, newY + 1);
                                }

                                movedPiece = piece;
                                EndOfTurn();

                                if (playerVComputer)
                                {
                                    Thread.Sleep(2000);
                                    Piece movedPiece = AI.Turn();
                                    MoveLabel.Text = string.Format("Black has moved a black {0} to ({1}, {2}).", movedPiece.pieceType, movedPiece.newX + 1, movedPiece.newY + 1);
                                    Thread.Sleep(2000);
                                    EndOfTurn();
                                }
                            }
                            else
                            {
                                MoveLabel.Text = "Please make a legal move.";
                            }
                        }
                        else
                        {
                            MoveLabel.Text = string.Format("Please select a {0} piece.", colour);
                        }
                    }
                    else
                    {
                        MoveLabel.Text = "Please select a piece.";
                    }                    
                }
            }
        }

        public bool EndOfTurn()
        {
            if (movedPiece.pieceType == "pawn")
            {
                if (movedPiece.colour == "white")
                {
                    if (movedPiece.yGridPos == 0)
                    {
                        QueenConvert(movedPiece);
                    }
                }
                else
                {
                    if (movedPiece.yGridPos == 7)
                    {
                        QueenConvert(movedPiece);
                    }
                }
            }

            Globals.GetKing("white", Globals.grid);
            King whiteKing = new King();
            whiteKing.xGridPos = Globals.kingX;
            whiteKing.yGridPos = Globals.kingY;
            whiteKing.colour = "white";

            Globals.GetKing("black", Globals.grid);
            King blackKing = new King();
            blackKing.xGridPos = Globals.kingX;
            blackKing.yGridPos = Globals.kingY;
            blackKing.colour = "black";

            if (whiteKing.Checkmate(whiteKing.xGridPos, whiteKing.yGridPos, Globals.grid) || blackKing.Checkmate(blackKing.xGridPos, blackKing.yGridPos, Globals.grid) || Stalemate(Globals.grid))
            {
                if (whiteKing.Checkmate(whiteKing.xGridPos, whiteKing.yGridPos, Globals.grid))
                {
                    whiteWin = false;
                    checkmate = true;
                    stalemate = false;
                    gameOver = true;
                    StateOfGameLabel.Text = "Checkmate!";
                }
                else if (blackKing.Checkmate(blackKing.xGridPos, blackKing.yGridPos, Globals.grid))
                {
                    whiteWin = true;
                    checkmate = true;
                    stalemate = false;
                    gameOver = true;
                    StateOfGameLabel.Text = "Checkmate!";
                }
                else if (Stalemate(Globals.grid))
                {
                    whiteWin = false;
                    checkmate = false;
                    stalemate = true;
                    gameOver = true;
                    StateOfGameLabel.Text = "Stalemate!";
                }

                StateOfGameLabel.Visible = true;
                GameOver();
                return gameOver;
            }

            if (whiteKing.Check(whiteKing.xGridPos, whiteKing.yGridPos, Globals.grid) || blackKing.Check(blackKing.xGridPos, blackKing.yGridPos, Globals.grid))
            {
                StateOfGameLabel.Text = "Check!";
                StateOfGameLabel.Visible = true;
            }
            else
            {
                StateOfGameLabel.Visible = false;
            }

            if (Globals.whiteTurn)
            {
                if (timeEnabled)
                {
                    whiteStopwatch.Stop();
                    WhiteTimer.ForeColor = Color.Green;
                    UpdateTimer();

                    if (whiteTimer <= 0)
                    {
                        gameOver = true;
                        whiteWin = false;
                        stalemate = false;
                        checkmate = false;
                        GameOver();
                        return gameOver;
                    }
                }

                Globals.whiteTurn = false;
                TurnLabel.Text = "Black's Turn";
            }
            else
            {
                if (timeEnabled)
                {
                    blackStopwatch.Stop();
                    BlackTimer.ForeColor = Color.Green;
                    UpdateTimer();

                    if (blackTimer <= 0)
                    {
                        gameOver = true;
                        whiteWin = true;
                        stalemate = false;
                        checkmate = false;
                        GameOver();
                        return gameOver;
                    }
                }

                Globals.whiteTurn = true;
                TurnLabel.Text = "White's Turn";
            }

            if (Globals.takenPiece != null)
            {
                if (Globals.takenPiece.colour == "white")
                {
                    WhiteTakenListBox.Items.Add(Globals.takenPiece.pieceType);
                }
                else
                {
                    BlackTakenListBox.Items.Add(Globals.takenPiece.pieceType);
                }

                Globals.takenPiece = null;
            }

            return gameOver;
        }

        public void QueenConvert(Piece pawn)
        {
            pawn.RemovePiece(pawn);
            
            Queen newQueen = new Queen();
            newQueen.colour = pawn.colour;
            newQueen.pieceType = "queen";
            newQueen.xGridPos = pawn.xGridPos;
            newQueen.yGridPos = pawn.yGridPos;
            newQueen.AddPiece(newQueen, Globals.grid);
            PictureBox newPictureBox = new PictureBox();
            CreatePieceImages(newQueen, newPictureBox, newQueen.colour);
        }

        public void UpdateTimer()
        {
            if (Globals.whiteTurn)
            {
                TimeSpan ts = whiteStopwatch.Elapsed;
                whiteTimer -= ((ts.Minutes * 60) + ts.Seconds);

                if (whiteTimer % 60 >= 10)
                {
                    WhiteTimer.Text = Convert.ToString(whiteTimer / 60) + ":" + Convert.ToString(whiteTimer % 60);
                }
                else
                {
                    WhiteTimer.Text = Convert.ToString(whiteTimer / 60) + ":0" + Convert.ToString(whiteTimer % 60);
                }

                whiteStopwatch.Reset();
            }
            else
            {
                TimeSpan ts = blackStopwatch.Elapsed;
                blackTimer -= ((ts.Minutes * 60) + ts.Seconds);

                if (blackTimer % 60 >= 10)
                {
                    BlackTimer.Text = Convert.ToString(blackTimer / 60) + ":" + Convert.ToString(blackTimer % 60);
                }
                else
                {
                    BlackTimer.Text = Convert.ToString(blackTimer / 60) + ":0" + Convert.ToString(blackTimer % 60);
                }

                blackStopwatch.Reset();
            }
        }
        
        private void GameOver()
        {
            if (checkmate)
            {
                if (whiteWin)
                {
                    MessageBox.Show("Checkmate! White wins!");
                }
                else
                {
                    MessageBox.Show("Checkmate! Black wins!");
                }
            }
            else if (stalemate)
            {
                MessageBox.Show("Stalemate");
            }
            else if (whiteTimer <= 0)
            {
                MessageBox.Show("White ran out of time. Black wins!");
            }
            else if (blackTimer <= 0)
            {
                MessageBox.Show("Black ran out of time. White wins!");
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!Globals.IsPositionEmpty(i, j, Globals.grid))
                    {
                        Globals.grid[i, j].RemovePiece(Globals.grid[i, j]);
                    }
                }
            }

            NewGameButton.Enabled = true;
            LoadGameButton.Enabled = true;
            SaveGameButton.Enabled = false;

            if (timeEnabled)
            {
                WhiteTimer.Text = "0:00";
                BlackTimer.Text = "0:00";
                WhiteTimer.Visible = false;
                BlackTimer.Visible = false;
            }
        }

        public bool Stalemate(Piece[,] board)
        {
            // Check for certain piece combinations which result in stalemate

            bool whiteStalemateCombination = StalemateCombinations("white", board);
            bool blackStalemateCombination = StalemateCombinations("black", board);

            if (whiteStalemateCombination && blackStalemateCombination)
            {
                stalemate = true;
                return stalemate;
            }

            // From here, if both of the other conditions are false, it is stalemate

            Globals.GetKing("white", board);
            King whiteKing = new King();
            whiteKing.xGridPos = Globals.kingX;
            whiteKing.yGridPos = Globals.kingY;

            Globals.GetKing("black", board);
            King blackKing = new King();
            blackKing.xGridPos = Globals.kingX;
            blackKing.yGridPos = Globals.kingY;

            // If there are any possible moves it is not stalemate

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!Globals.IsPositionEmpty(i, j, board))
                    {
                        for (int k = 0; k < 8; k++)
                        {
                            for (int l = 0; l < 8; l++)
                            {
                                bool[,] possibleMoves = new bool[8, 8];
                                possibleMoves = board[i, j].PossibleMoves(possibleMoves, board);

                                if (possibleMoves[k, l])
                                {
                                    stalemate = false;
                                    return stalemate;
                                }
                            }
                        }
                    }
                }
            }

            // If the king is in check it is not stalemate

            if (whiteKing.Check(whiteKing.xGridPos, whiteKing.yGridPos, board) || blackKing.Check(blackKing.xGridPos, blackKing.yGridPos, board))
            {
                stalemate = false;
                return stalemate;
            }

            // If both of the previous conditions are false it is stalemate

            stalemate = true;
            return stalemate;
        }

        public bool StalemateCombinations(string colour, Piece[,] board)
        {
            // There are three different combinations of pieces that cannot checkmate a king:
            // A king and a knight
            // A king and two knights
            // A king and a bishop
            // Therefore, if both sides have any of these three combinations, the game is stalemate

            int pawnCount = 0;
            int bishopCount = 0;
            int knightCount = 0;
            int rookCount = 0;
            int kingCount = 0;
            int queenCount = 0;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!Globals.IsPositionEmpty(i, j, board))
                    {
                        if (board[i, j].colour == colour)
                        {
                            if (board[i, j].pieceType == "pawn")
                            {
                                pawnCount++;
                            }
                            else if (board[i, j].pieceType == "bishop")
                            {
                                bishopCount++;
                            }
                            else if (board[i, j].pieceType == "knight")
                            {
                                knightCount++;
                            }
                            else if (board[i, j].pieceType == "rook")
                            {
                                rookCount++;
                            }
                            else if (board[i, j].pieceType == "king")
                            {
                                kingCount++;
                            }
                            else if (board[i, j].pieceType == "queen")
                            {
                                queenCount++;
                            }
                        }
                    }
                }
            }

            if (kingCount == 1 && knightCount == 1 && pawnCount == 0 && bishopCount == 0 && rookCount == 0 && queenCount == 0)
            {
                return true;
            }
            else if (kingCount == 1 && knightCount == 2 && pawnCount == 0 && bishopCount == 0 && rookCount == 0 && queenCount == 0)
            {
                return true;
            }
            else if (kingCount == 1 && knightCount == 0 && pawnCount == 0 && bishopCount == 1 && rookCount == 0 && queenCount == 0)
            {
                return true;
            }

            return false;
        }
    }
}