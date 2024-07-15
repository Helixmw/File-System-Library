using FileSystemLib.Enums;
using FileSystemLib.Models;
using FileSystemLib.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.DataAccess
{
    public class FileSystem
    {
        

        List<IFileInfo> files_and_folders = new();
        public FileSystem()
        {
            
        }

        public void CreateAppDirectory(string path) //Creates new home directory if it doesnt exist. Leaves already existing
        {
            Directory.CreateDirectory(path);          
        }
        public List<IFileInfo> LoadDirectoryFiles(string path, DirectoryFilter? filter) //Loads all files and/or folders in home directory
        {
            ClearFilesAndFoldersIfSet();
            switch (filter)
            {
                case DirectoryFilter.Files:
                files_and_folders.AddRange(Loaders.LoadFiles(path));
                break;
                case DirectoryFilter.Folders:
                files_and_folders.AddRange(Loaders.LoadFolders(path));
                break;
                case DirectoryFilter.All:
                files_and_folders.AddRange(Loaders.LoadFilesAndFolders(path));
                break;
                default:
                files_and_folders.AddRange(Loaders.LoadFilesAndFolders(path));
                 break;
            }
            return files_and_folders;
        }

        public List<IFileInfo> CreateAndLoadAppDirectory(string path, DirectoryFilter? filter) //Creates new home dir and loads all files and folders if home dir already exists
        {
            CreateAppDirectory(path);
            return LoadDirectoryFiles(path, filter);
        }

        private void ClearFilesAndFoldersIfSet()
        {
            files_and_folders.Clear();
        }

        public FileAccess FileAccess = new();
        
        
    }
}
