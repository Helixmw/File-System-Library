using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSystemLib.DataAccess;

namespace FileSystemLib.DataAccess
{
    public class FileAccess
    {
        public void OpenFile(string path)
        {
          FileValidation.CheckFileExists(path);
         


        }

        
    }
}
