using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.Exceptions
{
    public class DirectoryOrFileException : Exception
    {
        public DirectoryOrFileException(string message):base(message)
        {
            
        }

        public DirectoryOrFileException()
        {
            
        }
    }
}
