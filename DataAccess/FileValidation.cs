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
       public static void CheckFileExists(string path)
       {
            if (File.Exists(path))
               throw new DirectoryOrFileException("This file or folder does not exist");
       }


        
    }
}
