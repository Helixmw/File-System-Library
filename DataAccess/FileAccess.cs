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
          FileValidation.CheckFileExistsOnOpen(path);
          var result = FileReadWrite.ReadFile(path);
          return result;
        }


        public void CreateAndWriteFile(string path, byte[] buffer)
        {
            FileValidation.CheckFileExistsOnWrite(path);
            FileReadWrite.CreateWriteFile(path, buffer);
        }

        public void DeleteFile(string path)
        {
            FileValidation.CheckFileExistsOnOpen(path);
            File.Delete(path);
        }

        public void SaveFileChanges(string path, byte[] buffer)
        {
            FileValidation.CheckFileExistsOnOpen(path);
            FileReadWrite.SaveChanges(path, buffer);
        }

        
    }
}
