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
        public string OpenFile(string path)
        {
          FileValidation.CheckFileExists(path);
          var result = FileReadWrite.ReadFile(path);
          return result;
        }

        public void WriteFile(string path, byte[] buffer)
        {
            FileReadWrite.WriteFile(path, buffer);
        }

        public void DeleteFile(string path)
        {
            FileValidation.CheckFileExists(path);
            File.Delete(path);
        }

        
    }
}
