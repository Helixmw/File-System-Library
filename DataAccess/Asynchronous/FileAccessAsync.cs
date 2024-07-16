using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.DataAccess.Asynchronous
{
    public abstract class FileAccessAsync
    {
        public string OpenFileAsync(string path)
        {
            FileValidation.CheckFileExistsOnOpen(path);
            var result = FileReadWrite.ReadFile(path);
            return result;
        }


        public void CreateAndWriteFileAsync(string path, byte[] buffer)
        {
            FileValidation.CheckFileExistsOnWrite(path);
            FileReadWrite.CreateWriteFile(path, buffer);
        }

        public void DeleteFileAsync(string path)
        {
            FileValidation.CheckFileExistsOnOpen(path);
            File.Delete(path);
        }

        public void SaveFileChangesAsync(string path, byte[] buffer)
        {
            FileValidation.CheckFileExistsOnOpen(path);
            FileReadWrite.SaveChanges(path, buffer);
        }
    }
}
