using FileSystemLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.Utilities
{
    public static class AccessDirectory
    {
        public static List<IFileInfo> GetFilesAndFolders(string path)
        {
            return Loaders.LoadFilesAndFolders(path);
        }
    }
}
