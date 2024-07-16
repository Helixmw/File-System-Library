using FileSystemLib.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.DataAccess
{
    internal static class FileValidation
    {
       internal static void CheckFileExistsOnOpen(string path)
       {
            if (!File.Exists(path))
               throw new DirectoryOrFileException("This file or folder does not exist.");
       }

       internal static void CheckFileExistsOnWrite(string path)
        {
            if (File.Exists(path))
                throw new DirectoryOrFileException("A file with this name already exists.");

        }





    }
}
