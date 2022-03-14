using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGames.Game
{
    class CheckersGame
    {//X=117 Y=27, width&height = 303
        const string BaseFEN = "p1p1p1p1/1p1p1p1p/p1p1p1p1/8/8/1P1P1P1P/P1P1P1P1/1P1P1P1P w 0 1";
        const byte BoardWidth = 8, BoardHeight = 8;
        private int Width, Height, X, Y, PieceSpacing;
        public CheckersGame(int Width, int Height, int X, int Y, int PieceSpacing = 1)
        {
            this.Width = Width;
            this.Height = Height;
            this.X = X;
            this.Y = Y;
            this.PieceSpacing = PieceSpacing;
        }

        public CheckerPiece[] GenerateBoard(string FEN)
        {
            return null;
        }

        public string GenerateFEN(CheckerPiece[] pieces = default)
        {
            if (pieces == default)
            {
                return BaseFEN;
            }
            return null;
        }
    }
}
