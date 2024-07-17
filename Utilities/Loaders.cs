using FileSystemLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.Utilities
{
    public static class Loaders
    {
        public static List<IFileInfo> LoadFolders(string path)
        {
            var folders = Directory.GetDirectories(path); //gets folders/directories under base path

            var folders_list = new List<IFileInfo>(); //Creates list for folders

            foreach (var folder in folders) //add folders/directories to list
            {
                var name = Path.GetFileName(folder);
                if (name is not null)
                {
                    var _folder = new Folder
                    {
                        Name = name,
                        FullPath = folder,
                        FileType = Enums.FileType.Folder,
                    };
                    folders_list.Add(_folder);
                }

            }
            return folders_list; //returns folders list

        }

        public static List<IFileInfo> LoadFiles(string path)
        {
            var files = Directory.GetFiles(path); //gets files under base path

            var files_list = new List<IFileInfo>(); //Creates list for files

            foreach (var file in files) //add files to list
            {
                var filename = Path.GetFileName(file);
                var fullpath = file;
                var extension = Path.GetExtension(fullpath);
                var _file = new Files()
                {
                    Name = filename,
                    FullPath = fullpath,
                    FileExtenstion = extension,
                    FileType= Enums.FileType.File,
                };
                files_list.Add(_file);

            }
            return files_list; //returns list of files
        }

        public static List<IFileInfo> LoadFilesAndFolders(string path)
        {
            List<IFileInfo> files_and_folders = new List<IFileInfo>();
            files_and_folders.AddRange(LoadFolders(path));
            files_and_folders.AddRange(LoadFiles(path));
            return files_and_folders;
        }

    

        
    }
}
