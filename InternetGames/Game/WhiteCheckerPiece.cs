using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGames.Game
{
    internal class WhiteCheckerPiece : CheckerPiece
    {
        public WhiteCheckerPiece(bool kinged)
        {
            if (kinged)
            {
                KingMe();
            }
            else
            {
                PType = PieceType.Piece_White;
            }
            
        }

        internal override void KingMe()
        {
            PType = PieceType.King_White;
            base.KingMe();
        }
    }
}
