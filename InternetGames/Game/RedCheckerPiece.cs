using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGames.Game
{
    internal class RedCheckerPiece: CheckerPiece
    {
        public RedCheckerPiece()
        {
            PType = PieceType.Piece_Red;
        }

        internal override void KingMe()
        {
            PType = PieceType.King_Red;
            base.KingMe();
        }
    }
}
