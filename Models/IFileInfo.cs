using FileSystemLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.Models
{
    public interface IFileInfo
    {
        string Name { get; }
        string FullPath { get; }
        FileType FileType { get; }


    }
}
