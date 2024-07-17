using FileSystemLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.Models
{
    public class Files : IFileInfo
    {
        public string Name { get; set; } = null!;

        public string FullPath { get; set; } = null!;

        public string FileExtenstion { get; set; } = null!;

        public FileType FileType { get; set; }
    }
}
