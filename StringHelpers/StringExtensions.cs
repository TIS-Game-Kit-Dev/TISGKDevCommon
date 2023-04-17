using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace TisGameKit.TisGameKitCommon.StringHelpers
{
    public static class StringExtensions
    {
        private static char[]? m_DirectorySeperators;
        public static char[] DirectorySeperators
        {
            get
            {
                m_DirectorySeperators ??= new char[]
                    {
                        Path.DirectorySeparatorChar,
                        Path.AltDirectorySeparatorChar,
                    };
                return m_DirectorySeperators;
            }
        }
        public static string[] SeperateAsPath(this string pathString)
        {
            return pathString.Split(DirectorySeperators);
        }
    }
}
