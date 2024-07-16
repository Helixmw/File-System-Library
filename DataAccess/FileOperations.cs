using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.DataAccess
{
    public class FileOperations
    {
        public void CopyFile(string source, string destination)
        {
            FileValidation.CheckFileExistsOnOpen(source);
            File.Copy(source, destination);
        }

        public void MoveFile(string source, string destination)
        {
            FileValidation.CheckFileExistsOnOpen(source);
            File.Move(source, destination);
        }
    }
}
