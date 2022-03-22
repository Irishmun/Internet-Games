using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InternetGames.Util;

namespace InternetGames.Game
{
    class CheckersGame
    {//X=117 Y=27, width&height = 303
        const string BaseFEN = "p1p1p1p1/1p1p1p1p/p1p1p1p1/8/8/1P1P1P1P/P1P1P1P1/1P1P1P1P w 0 1";
        const byte BoardWidth = 8, BoardHeight = 8;

        internal int HalfTurns { get; private set; }
        internal int WholeTurns { get; private set; }
        internal bool WhiteToPlay { get; private set; }//does not account for if the user is white or not, need to check that as well


        /// <summary>
        /// Decodes the FEN string and returns the board layout section. Applies the other sections to the <see cref="CheckersGame"/> instance
        /// </summary>
        /// <param name="FEN">The entire FEN string</param>
        /// <returns>the board layout part of the FEN string</returns>
        public string DecodeFEN(string FEN)
        {
            string[] fen = FEN.Split(' ');
            string layout = string.Empty;
            if (fen.Length > 0)
            {
                layout = fen[0];
                if (fen.Length > 1)
                {
                    WhiteToPlay = string.Equals(fen[1].ToLower(), "w");
                    if (fen.Length > 2)
                    {
                        HalfTurns = int.Parse(fen[2]);
                        if (fen.Length > 3)
                        {
                            WholeTurns = int.Parse(fen[3]);
                        }
                    }
                }
            }
            return layout;
        }

        /// <summary>
        /// Generates an array of checkerpieces from the first section of a FEN string. spacers will be <see cref="null"/>
        /// </summary>
        /// <param name="FEN">the first section of the FEN strin, for full FEN decoding use <see cref="DecodeFEN(string)"></see></param>
        /// <returns>an array of <see cref="CheckerPiece"/>s</returns>
        public CheckerPiece[,] GenerateBoard(string FEN)
        {
            string fen = FEN;
            CheckerPiece[,] board = new CheckerPiece[BoardWidth, BoardHeight];//board is always 8 by 8
            if (FEN.Contains(' '))//not board section of FEN, but most likely entire FEN string
            {
                fen = FEN.Split(' ')[0];//get only first item and use that, as it is probably the board part of FEN
            }
            //Actually decode FEN board layout
            int X = 0, Y = 0;
            for (int i = 0; i < fen.Length; i++)
            {

                if (fen[i].Equals('/'))//go to new row if row seperator is met
                {
                    X = 0;
                    Y++;
                }
                else
                {
                    //test P1P1P1P1/1P1P1P1P/P1P1P1P1/8/8/1p1p1p1p/p1p1p1p1/1p1p1p1p/8 w 0 1 solved
                    //test P1P1P1P1/1P1P1P1P/P1P1P1P1/8/8/1p1p1p1p/p1p1p1p1p/1p1p1p1p w 0 1 solved
                    if (X < BoardWidth && Y < BoardHeight)//skips overflowing FEN values
                    {

                        int.TryParse(fen[i].ToString(), out int spacing);
                        if (spacing > 0)//if number, don't create checkerpiece
                        {
                            for (int space = 0; space < spacing || space > BoardWidth; space++)
                            {
                                board[X, Y] = null;
                                X++;
                            }
                        }
                        else
                        {
                            CheckerPiece piece;
                            switch (fen[i])//check which piece it is, else it's null for wrong characters
                            {
                                case (char)PieceType.Piece_White:
                                    piece = new WhiteCheckerPiece(false);
                                    break;
                                case (char)PieceType.Piece_Red:
                                    piece = new RedCheckerPiece(false);
                                    break;
                                case (char)PieceType.King_White:
                                    piece = new WhiteCheckerPiece(true);
                                    break;
                                case (char)PieceType.King_Red:
                                    piece = new RedCheckerPiece(true);
                                    break;
                                default:
                                    piece = null;
                                    break;
                            }
                            board[X, Y] = piece;
                            X++;
                        }
                    }
                }
            }
            return board;
        }

        /// <summary>
        /// Generates the FEN string from the given <see cref="CheckerPiece"/> array and the game state from the <see cref="CheckersGame"/> instance
        /// </summary>
        /// <param name="pieces">game board array consisting of <see cref="CheckerPiece"/>s. if set to default, returns starting position FEN</param>
        /// <returns>a complete FEN string</returns>
        public string GenerateFEN(CheckerPiece[,] pieces = default)
        {
            if (pieces == default)
            {
                return BaseFEN;
            }
            return null;
        }

        /// <summary>
        /// flips the board layout of the local FEN
        /// </summary>
        /// <param name="FEN"></param>
        /// <returns></returns>
        public string invertFEN(string FEN)
        {
            string[] all = FEN.Split(' ');
            string revFEN = all[0].Reversed();
            all[0] = revFEN;
            string res = string.Join(' ', all);
            return res;
        }
    }
}
