using Domain.Config;
using Domain.Constants;
using Microsoft.Extensions.Options;
using Shared.Dtos.Responses;

namespace Application.Services.FileStorage;

public class FileStorageService : IFileStorageService
{
    private readonly string _root;

    public FileStorageService(IOptions<FileSettings> fileSettings)
    {
        _root = fileSettings.Value.FullPath;
        Directory.CreateDirectory(_root);
    }

    private Result<string> FullPath(string relativePath)
    {
        var combined = Path.Combine(_root, relativePath.Replace('/', Path.DirectorySeparatorChar));

        var fullPath = Path.GetFullPath(combined);

        var rootFullPath = Path.GetFullPath(_root);

        if (!fullPath.StartsWith(rootFullPath, StringComparison.OrdinalIgnoreCase))
        {
            return Result<string>.Failure(ErrorMessages.InvalidFilePath);
        }

        return Result<string>.Success(fullPath);
    }

    public async Task<Result> SaveAsync(
        Stream stream,
        string relativePath,
        CancellationToken cancellationToken = default)
    {
        var pathResult = FullPath(relativePath);

        if (!pathResult.IsSuccess || pathResult.Value is null)
        {
            return Result.Failure(pathResult.Message);
        }

        var fullPath = pathResult.Value;

        Directory.CreateDirectory(Path.GetDirectoryName(fullPath)!);

        await using var fileStream = new FileStream(
            fullPath,
            FileMode.Create,
            FileAccess.Write,
            FileShare.None,
            bufferSize: 81920,
            useAsync: true);

        await stream.CopyToAsync(fileStream, cancellationToken);

        return Result.Success();
    }

    public async Task<Result<Stream>> OpenReadAsync(
        string relativePath,
        CancellationToken cancellationToken = default)
    {
        var pathResult = FullPath(relativePath);

        if (!pathResult.IsSuccess || pathResult.Value is null)
        {
            return Result<Stream>.Failure(pathResult.Message);
        }

        var fullPath = pathResult.Value;

        if (!File.Exists(fullPath))
        {
            return Result<Stream>.Failure(ErrorMessages.TaskAttachmentNotFound);
        }

        Stream stream = new FileStream(
            fullPath,
            FileMode.Open,
            FileAccess.Read,
            FileShare.Read,
            bufferSize: 81920,
            useAsync: true);

        return Result<Stream>.Success(stream);
    }

    public Task<Result> DeleteAsync(
        string relativePath,
        CancellationToken cancellationToken = default)
    {
        var pathResult = FullPath(relativePath);

        if (!pathResult.IsSuccess || pathResult.Value is null)
        {
            return Task.FromResult(Result.Failure(pathResult.Message));
        }

        var fullPath = pathResult.Value;

        if (File.Exists(fullPath))
        {
            File.Delete(fullPath);
        }

        return Task.FromResult(Result.Success());
    }
}
