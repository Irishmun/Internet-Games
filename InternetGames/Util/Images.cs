using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGames.Util
{
    internal static class Images
    {
        internal static Image WHITE_PIECE_GRAPHIC = GetImageSection(Properties.Resources.Checkers_Pieces, 37, 37, 0, 0);
        internal static Image RED_PIECE_GRAPHIC = GetImageSection(Properties.Resources.Checkers_Pieces, 37, 37, 74, 0);
        internal static Image WHITE_KING_GRAPHIC = GetImageSection(Properties.Resources.Checkers_Pieces, 37, 37, 37, 0);
        internal static Image RED_KING_GRAPHIC = GetImageSection(Properties.Resources.Checkers_Pieces, 37, 37, 111, 0);
        internal static Image GetImageSection(Image source, int Width, int Height, int X, int Y)
        {
            Image img = new Bitmap(Width, Height);
            using (Graphics gr = Graphics.FromImage(img))
            {
                gr.DrawImage(source, new Rectangle(0, 0, img.Width, img.Height), new Rectangle(X, Y, Width, Height), GraphicsUnit.Pixel);
            }
            return img;
        }
    }
}
