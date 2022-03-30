using InternetGames.Game;
using InternetGames.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace InternetGames
{
    public partial class CheckersWindow : Form
    {
        CheckersGame Game = new CheckersGame();
        private int RealWidth = 303, RealHeight = 303, X = 117, Y = 27, PieceSpacing = 1, PieceSize = 37;//checked beforehand, magic numbers are fun
        private static Point thousand = new Point(1000, 1000);
        List<Control> boardPieces = new List<Control>();
        private bool PieceSelected = false;
        private Point MouseOffset;
        public CheckersWindow()
        {
            InitializeComponent();
#if !DEBUG
            TSMI_Debug.Visible = false;
#endif
            LB_OpponentColor.Parent = PB_CheckersField;
            LB_YourColor.Parent = PB_CheckersField;
            pictureBox2.Parent = PB_CheckersField;//checker piece //TODO: destroy this one
            PB_HoveredField.Parent = PB_CheckersField;//Selected object
            PB_HoveredField.Location = thousand;
            LB_OpponentColor.Text = "Red";
            LB_YourColor.Text = "White";
            GeneratePieces(Game.DecodeFEN(Game.GenerateFEN()));//TODO: change to FEN of online opponent
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //declare resignation to oponent
            Close();
        }

        private void TSMIDebug_SetFEN_Click(object sender, EventArgs e)
        {
            string newFEN = "";
            PopUps.DebugInsertFEN DebugFEN = new PopUps.DebugInsertFEN();
            if (DebugFEN.ShowDialog(this) == DialogResult.OK)
            {
                newFEN = DebugFEN.TB_NewFEN.Text;
                GeneratePieces(newFEN);
            }

        }



        private void TSMI_ViewHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Paths.Absolute(".\\Resources\\chkr.chm"));
        }



        private void GeneratePieces(string FEN)
        {
            if (boardPieces.Count > 0)
            {
                for (int i = 0; i < boardPieces.Count; i++)
                {
                    boardPieces[i].Parent = null;
                    Controls.Remove(boardPieces[i]);
                }
            }
            CheckerPiece[,] board = Game.GenerateBoard(FEN);
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (board[x, y] != null)
                    {
                        PictureBox piece = new PictureBox();
                        piece.Size = new Size(PieceSize, PieceSize);
                        piece.BackColor = Color.Transparent;
                        piece.BorderStyle = BorderStyle.None;
                        piece.Padding = new Padding(0);
                        piece.Location = new Point(X + ((PieceSize + PieceSpacing) * x), Y + ((PieceSize + PieceSpacing) * y));
                        switch (board[x, y].PType)
                        {
                            case PieceType.Piece_White:
                                piece.Image = Images.WHITE_PIECE_GRAPHIC;
                                break;
                            case PieceType.Piece_Red:
                                piece.Image = Images.RED_PIECE_GRAPHIC;
                                break;
                            case PieceType.King_White:
                                piece.Image = Images.WHITE_KING_GRAPHIC;
                                break;
                            case PieceType.King_Red:
                                piece.Image = Images.RED_KING_GRAPHIC;
                                break;
                            default:
                                break;
                        }

                        boardPieces.Add(piece);
                        Controls.Add(piece);
                        piece.Parent = PB_CheckersField;
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PieceSelected = true;
            Point formMouse = this.PointToClient(MousePosition);
            MouseOffset = new Point(formMouse.X - pictureBox2.Location.X, formMouse.Y - pictureBox2.Location.Y);
        }

        private void PB_CheckersField_MouseMove(object sender, MouseEventArgs e)
        {
            if (PieceSelected)
            {
                Point formMouse = this.PointToClient(MousePosition);
                PB_HoveredField.Location = SnapToGrid(formMouse,true);
            }
        }

        private void PB_HoveredField_MouseClick(object sender, MouseEventArgs e)
        {
            if (PieceSelected)
            {
                Point formMouse = this.PointToClient(MousePosition);


                pictureBox2.Location = SnapToGrid(formMouse); //new Point(formMouse.X - MouseOffset.X, formMouse.Y - MouseOffset.Y);
                PB_HoveredField.Location = thousand;
                PieceSelected = false;
            }
        }
        private Point SnapToGrid(Point p, bool isHover = false)
        {
            double x = Math.Round((double)(p.X) / 38) * 38;
            double y = Math.Round((double)(p.Y) / 38) * 38;
            if (isHover)//hovergrid sprite is 39x39
            {
                return new Point((int)x + 2, (int)y -50);//magic numbered through trial and error
            }
            else//checkerpiece is 37x37
            {
                return new Point((int)x + 3, (int)y - 49);
            }
        }
    }
}
