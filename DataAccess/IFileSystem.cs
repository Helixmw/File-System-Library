
namespace FileSystemLib.DataAccess
{
    public interface IFileSystem
    {
        void CreateAppDirectory(string path);
        List<string> ReadDirectory(string path);
    }
}