using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.Models
{
    public interface IFileInfo
    {
        public string Name { get; }
        public string FullPath { get; }
    }
}
