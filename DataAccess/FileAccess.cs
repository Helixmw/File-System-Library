using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSystemLib.DataAccess.Asynchronous;

namespace FileSystemLib.DataAccess
{
    public abstract class FileAccess : FileAccessAsync
    {
        private protected string OpenFile(string path)
        {
          FileValidation.CheckFileExistsOnOpen(path);
          var result = FileReadWrite.ReadFile(path);
          return result;
        }


        private protected void CreateAndWriteFile(string path, byte[] buffer)
        {
            FileValidation.CheckFileExistsOnWrite(path);
            FileReadWrite.CreateWriteFile(path, buffer);
        }

        private protected void DeleteFile(string path)
        {
            FileValidation.CheckFileExistsOnOpen(path);
            File.Delete(path);
        }

        private protected void SaveFileChanges(string path, byte[] buffer)
        {
            FileValidation.CheckFileExistsOnOpen(path);
            FileReadWrite.SaveChanges(path, buffer);
        }

        
    }
}
