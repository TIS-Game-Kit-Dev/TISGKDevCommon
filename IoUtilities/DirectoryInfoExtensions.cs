using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace TisGameKit.TisGameKitCommon.IoUtilities
{
    public static class DirectoryInfoExtensions
    {
        /// <summary>
        /// 从该目录解析相对路径
        /// </summary>
        /// <param name="relativePath"></param>
        /// <returns></returns>
        public static string ParseRelativePath(this DirectoryInfo currentDirectory, string relativePath)
        {
            return Path.Combine(currentDirectory.FullName, relativePath);
        }


        /// <summary>
        /// 如果不存在该子文件夹，新建该文件夹，返回该文件夹的DirectoryInfo
        /// </summary>
        /// <param name="relativePath">相对路径</param>
        public static DirectoryInfo GetOrCreateSubDirectory(this DirectoryInfo currentDirectory, string relativePath)
        {
            return Directory.CreateDirectory(currentDirectory.ParseRelativePath(relativePath));
        }

        /// <summary>
        /// 尝试获取该目录的直接子目录信息，如果不存在则返回空
        /// </summary>
        /// <param name="restrictLetterCase">是否严格大小写</param>
        /// <returns></returns>
        public static DirectoryInfo? TryGetSubDirectory(this DirectoryInfo currentDirectory, string subDirectoryName, bool restrictLetterCase = false)
        {
            if (restrictLetterCase)
            {
                subDirectoryName = subDirectoryName.ToLower();
            }
            var subDirectories = currentDirectory.GetDirectories();
            foreach (var subDirectory in subDirectories)
            {
                var subDirName = subDirectory.Name;
                if (restrictLetterCase)
                {
                    subDirName = subDirName.ToLower();
                }
                if (subDirName == subDirectoryName)
                {
                    return subDirectory;
                }
            }
            return null;
        }
    }
}
