using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemLib.DataAccess
{
    public static class FileReadWrite
    {
        public static string ReadFile(string path)
        {
            FileStream fileStream = new FileStream(path,FileMode.Open);     //Creating the file stream
            var buffer = new byte[fileStream.Length];                 //converting the file into bytes array for the array to be read
            fileStream.Read(buffer);                            //Reading the bytes array
            var result = Encoding.UTF8.GetString(buffer);           //Converting to readable format
            fileStream.Flush();
            fileStream.Close();
            return result;

        }

        public static void WriteFile(string path, byte[] buffer)
        {
            FileStream fileStream = new FileStream(path,FileMode.Create);
            fileStream.Write(buffer);          //Gets bytes and puts them in the file
        }

       
    }
}
