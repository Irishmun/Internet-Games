using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGames.Game
{
    abstract class CheckerPiece
    {
        internal PieceType PType;
        internal bool Kinged { get; private set; }

        internal virtual void KingMe()
        {
            Kinged = true;
        }
    }
}
