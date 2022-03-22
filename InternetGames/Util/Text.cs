using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetGames.Util
{
    internal static class Text
    {
        internal static string Reversed(this string original)
        {
            char[] chars = original.ToArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}
