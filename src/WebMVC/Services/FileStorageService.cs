using System.Globalization;
using WebMVC.Services.Base;
using WebMVC.Utils;

namespace WebMVC.Services;

public class FileStorageService:IFileStorageService
{
    private readonly string _webRootPath;

    public FileStorageService(IWebHostEnvironment webHostEnvironment)
    {
        _webRootPath = webHostEnvironment.WebRootPath;
    }

    public async Task<string> SaveFileAsync(IFormFile file, string resourceDirectory = "")
    {
        var fileName = await GenerateFileName(file);
        var filePathInWebRoot = GetFilePathInWebRoot(fileName, resourceDirectory);
        var filePathFromRoot = await CreateFilePath(filePathInWebRoot);
        await using var output = new FileStream(filePathFromRoot, FileMode.Create);
        await file.CopyToAsync(output);
        return filePathInWebRoot;
    }

    public bool DeleteFile(string filePath)
    {
        throw new NotImplementedException();
    }

    public string GetFilePathInWebRoot(string fileName, string resourceDirectory = "")
    {
        return $"/{resourceDirectory}/{fileName}";
    }

    private async Task<string> GenerateFileName(IFormFile file)
    {
        var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
        return uniqueFileName;
    }

    private async Task<string> CreateFilePath(string pathInWebRoot)
    {
        var filePath = _webRootPath + pathInWebRoot;
        return filePath;
    }
}