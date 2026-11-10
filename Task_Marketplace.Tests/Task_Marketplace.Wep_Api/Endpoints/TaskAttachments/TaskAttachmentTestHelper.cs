using Shared.Dtos.Responses.ProjectTasks;
using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace Task_Marketplace.Tests.Integration.Infrastructure;

public static class TaskAttachmentTestHelper
{
    public static MultipartFormDataContent CreateFileContent(
        string fileName = "test.txt",
        byte[]? content = null)
    {
        var form = new MultipartFormDataContent();
        var file = new ByteArrayContent(content ?? "Test file content"u8.ToArray());

        file.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
        form.Add(file, "file", fileName);

        return form;
    }

    public static async Task<TaskAttachmentDto> CreateAttachmentAsync(
        HttpClient client,
        Guid taskId)
    {
        using var content = CreateFileContent();

        var response = await client.PostAsync(
            $"/api/tasks/{taskId}/attachments", content);

        response.EnsureSuccessStatusCode();

        return (await response.Content.ReadFromJsonAsync<TaskAttachmentDto>())!;
    }
}