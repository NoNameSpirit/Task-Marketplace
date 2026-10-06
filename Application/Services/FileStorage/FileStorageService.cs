using Domain.Config;
using Microsoft.Extensions.Options;

namespace Application.Services.FileStorage;

public class FileStorageService : IFileStorageService
{
    private readonly string _root;

    public FileStorageService(
        IOptions<FileSettings> fileSettings)
    {
        _root = fileSettings.Value.FullPath;

        Directory.CreateDirectory(_root);
    }

    private string FullPath(string relativePath)
    {
        var fullPath = Path.Combine(_root, relativePath.Replace('/', Path.DirectorySeparatorChar));

        return fullPath;
    }

    public async Task SaveAsync(
        Stream stream,
        string relativePath,
        CancellationToken cancellationToken = default)
    {
        var fullPath = FullPath(relativePath);

        Directory.CreateDirectory(Path.GetDirectoryName(fullPath)!);

        await using var fileStream = new FileStream(
            fullPath,
            FileMode.Create,
            FileAccess.Write,
            FileShare.None,
            bufferSize: 81920,
            useAsync: true);

        await stream.CopyToAsync(fileStream, cancellationToken);
    }

    public Task<Stream> OpenReadAsync(
        string relativePath,
        CancellationToken cancellationToken = default)
    {
        var fullPath = FullPath(relativePath);

        if (!File.Exists(fullPath))
        {
            throw new FileNotFoundException(relativePath);
        }

        Stream stream = new FileStream(
            fullPath,
            FileMode.Open,
            FileAccess.Read,
            FileShare.Read,
            bufferSize: 81920,
            useAsync: true);

        return Task.FromResult(stream);
    }

    public Task DeleteAsync(
        string relativePath,
        CancellationToken cancellationToken = default)
    {
        var fullPath = FullPath(relativePath);

        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }

        return Task.CompletedTask;
    }
}
