using FileSystemLib.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.DataAccess
{
    public static class FileValidation
    {
       public static void CheckFileExistsOnOpen(string path)
       {
            if (!File.Exists(path))
               throw new DirectoryOrFileException("This file or folder does not exist.");
       }

        public static void CheckFileExistsOnWrite(string path)
        {
            if (File.Exists(path))
                throw new DirectoryOrFileException("A file with this name already exists.");

        }





    }
}
