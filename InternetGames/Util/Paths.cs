using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InternetGames.Util
{
    internal static class Paths
    {
        /// <summary>
        /// The absolute path to the application's folder
        /// </summary>
        internal static readonly string APPLICATION_PATH = Path.GetDirectoryName(new System.Uri(Assembly.GetEntryAssembly().Location).AbsolutePath);

        /// <summary>
        /// Creates an absolute path from the application location and the given relative path
        /// </summary>
        /// <param name="relativePath">relative file path</param>
        /// <returns></returns>
        internal static string Absolute(string relativePath)
        {
            return Path.Combine(APPLICATION_PATH, relativePath);
        }
    }
}
