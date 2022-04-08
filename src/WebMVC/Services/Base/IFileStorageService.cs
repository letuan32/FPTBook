namespace WebMVC.Services.Base;

public interface IFileStorageService
{
    Task<string> SaveFileAsync(IFormFile file, string resourceDirectory = "");

    bool DeleteFile(string filePath);

    string GetFilePathInWebRoot(string fileName, string resourceDirectory = "");
}