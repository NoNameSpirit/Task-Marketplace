using Blazor_Web_App.Services.LocalStorage;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using System.Net.Http.Headers;

namespace Blazor_Web_App.Services.Receivers.TaskAttachments;

public class TaskAttachmentService(
    HttpClient _httpClient,
    ILocalStorageService _localStorage)
    : BaseService(_httpClient, _localStorage), ITaskAttachmentService
{
    public async Task<Result<List<TaskAttachmentDto>>> GetTaskAttachmentsAsync(
        Guid taskId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"{taskId}/attachments",
            cancellationToken);

        var result = await HandleResponseAsync<List<TaskAttachmentDto>>(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result<TaskAttachmentDto>> UploadAttachmentAsync(
        Guid taskId,
        Stream content,
        string fileName,
        string contentType,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        using var form = new MultipartFormDataContent();

        using var fileContent = new StreamContent(content);

        fileContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);

        form.Add(fileContent, "file", fileName);

        var response = await _httpClient.PostAsync(
            $"{taskId}/attachments",
            form,
            cancellationToken);

        var result = await HandleResponseAsync<TaskAttachmentDto>(
            response,
            cancellationToken);

        return result;

    }

    public async Task<Result> DeleteAttachmentAsync(
        Guid taskId,
        Guid attachmentId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.DeleteAsync(
            $"{taskId}/attachments/{attachmentId}",
            cancellationToken);

        var result = await HandleResponseAsync(
            response,
            cancellationToken);

        return result;
    }

    public async Task<Result<AttachmentFileResult>> DownloadAttachmentAsync(
        Guid taskId,
        Guid attachmentId,
        CancellationToken cancellationToken = default)
    {
        await SetAuthHeaderAsync(cancellationToken);

        var response = await _httpClient.GetAsync(
            $"{taskId}/attachments/{attachmentId}/download",
            cancellationToken);

        var result = await HandleResponseAsync<AttachmentFileResult>(
           response,
           cancellationToken);

        return result;
    }
}
