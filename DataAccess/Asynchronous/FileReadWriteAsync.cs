using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.DataAccess.Asynchronous
{
    internal class FileReadWriteAsync
    {
        internal async static Task<string> ReadFileAsync(string path)
        {
            FileStream fileStream = new FileStream(path, FileMode.Open);     //Creating the file stream
            var buffer = new byte[fileStream.Length];                 //converting the file into bytes array for the array to be read
            await fileStream.ReadAsync(buffer);                           //Reading the bytes array
            var result = Encoding.UTF8.GetString(buffer);           //Converting to readable format
            fileStream.Flush();
            fileStream.Close();
            return result;

        }

        internal async static Task WriteFileAsync(string path, byte[] buffer)
        {
            FileStream fileStream = new FileStream(path, FileMode.Create);
            await fileStream.WriteAsync(buffer);          //Gets bytes and puts them in the file
        }

        internal async static Task CreateWriteFileAsync(string path, byte[] buffer)
        {
            FileStream fileStream = new FileStream(path, FileMode.CreateNew); //Create new file
            await fileStream.WriteAsync(buffer);
        }

        internal async static Task SaveChangesAsync(string path, byte[] buffer)
        {
            FileStream fileStream = new FileStream(path, FileMode.Truncate);
            await fileStream.WriteAsync(buffer);
        }
    }
}
