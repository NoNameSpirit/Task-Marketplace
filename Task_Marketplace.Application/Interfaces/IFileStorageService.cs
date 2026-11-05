using Shared.Dtos.Responses;

namespace Task_Marketplace.Application.Interfaces;

public interface IFileStorageService
{
    Task<Result> SaveAsync(Stream stream, string relativePath, CancellationToken cancellationToken = default);
    Task<Result<Stream>> OpenReadAsync(string relativePath, CancellationToken cancellationToken = default);
    Task<Result> DeleteAsync(string relativePath, CancellationToken cancellationToken = default);
}