using System;
using System.Net.NetworkInformation;

namespace InternetGames.Util
{
    internal static class Internet
    {
        [System.Runtime.InteropServices.DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int connectionDescription, int reservedValue);
        internal static bool Connected()
        {
            int Description = 0;
            return InternetGetConnectedState(out Description, 0);
        }
    }
}
