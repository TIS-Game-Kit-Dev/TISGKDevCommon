using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace TisGameKit.TisGameKitCommon.StringUtilities
{
    public static class StringExtensions
    {
        /// <summary>
        /// 文件系统分隔符的数组，可能为空，访问请用<see cref="DirectorySeperators"/>
        /// </summary>
        private static char[]? s_DirectorySeperators;

        /// <summary>
        /// 文件系统分隔符的数组
        /// </summary>
        public static char[] DirectorySeperators
        {
            get
            {
                s_DirectorySeperators ??= new char[]
                    {
                        Path.DirectorySeparatorChar,
                        Path.AltDirectorySeparatorChar,
                    };
                return s_DirectorySeperators;
            }
        }

        /// <summary>
        /// 返回该字符串根据文件分隔符分割后的数组
        /// </summary>
        public static string[] SeperateAsPath(this string pathString, StringSplitOptions options = StringSplitOptions.None)
        {
            return pathString.Split(DirectorySeperators, options);
        }
    }
}
