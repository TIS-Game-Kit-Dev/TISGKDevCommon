using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TisGameKit.TisGameKitCommon.IoUtilities
{
    public static class FileStreamExtensions
    {
        public static FileStream OpenOrCreateFile(string path, FileMode fileMode = FileMode.OpenOrCreate)
        {
            return File.Open(path, fileMode);
        }
    }
}
