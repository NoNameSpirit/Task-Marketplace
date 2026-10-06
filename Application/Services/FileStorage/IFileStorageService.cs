namespace Application.Services.FileStorage;

public interface IFileStorageService
{
    Task SaveAsync(Stream stream, string relativePath, CancellationToken cancellationToken = default);
    Task<Stream> OpenReadAsync(string relativePath, CancellationToken cancellationToken = default);
    Task DeleteAsync(string relativePath, CancellationToken cancellationToken = default);
}
