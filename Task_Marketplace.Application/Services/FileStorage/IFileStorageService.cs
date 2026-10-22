using Shared.Dtos.Responses;

namespace Application.Services.FileStorage;

public interface IFileStorageService
{
    Task<Result> SaveAsync(Stream stream, string relativePath, CancellationToken cancellationToken = default);
    Task<Result<Stream>> OpenReadAsync(string relativePath, CancellationToken cancellationToken = default);
    Task<Result> DeleteAsync(string relativePath, CancellationToken cancellationToken = default);
}