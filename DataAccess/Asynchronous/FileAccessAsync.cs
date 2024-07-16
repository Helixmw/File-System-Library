using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.DataAccess.Asynchronous
{
    public abstract class FileAccessAsync
    {
        public async Task<string> OpenFileAsync(string path)
        {
            FileValidation.CheckFileExistsOnOpen(path);
            var result = await FileReadWriteAsync.ReadFileAsync(path);
            return result;
        }


        public async void CreateAndWriteFileAsync(string path, byte[] buffer)
        {
            FileValidation.CheckFileExistsOnWrite(path);
            await FileReadWriteAsync.CreateWriteFileAsync(path, buffer);
        }

        public void DeleteFileAsync(string path)
        {
            FileValidation.CheckFileExistsOnOpen(path);
            File.Delete(path);
        }

        public async Task SaveFileChangesAsync(string path, byte[] buffer)
        {
            FileValidation.CheckFileExistsOnOpen(path);
            await FileReadWriteAsync.SaveChangesAsync(path, buffer);
        }
    }
}
