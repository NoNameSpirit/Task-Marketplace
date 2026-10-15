using Blazor_Web_App.Services.Receivers;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using Shared.Dtos.Responses.ProjectTasks;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class AttachmentsModal : ComponentBase
{
    private const long MaxSizeBytes = 50L * 1024 * 1024;
    private const int MaxSizeMb = (int)(MaxSizeBytes / (1024 * 1024));

    [Parameter] public bool IsVisible { get; set; }
    [Parameter] public Guid TaskId { get; set; }
    [Parameter] public Guid CurrentUserId { get; set; }
    [Parameter] public bool CanUpload { get; set; } = true;
    [Parameter] public EventCallback OnClose { get; set; }

    [Inject] public BaseService ApiService { get; set; } = null!;
    [Inject] public IJSRuntime JS { get; set; } = null!;

    private List<TaskAttachmentDto>? Attachments;
    private string TaskTitle = string.Empty;
    private string ErrorMessage = string.Empty;
    private bool IsLoading;
    private bool IsUploading;
    private bool IsDeleting;

    protected override async Task OnParametersSetAsync()
    {
        if (!IsVisible || TaskId == Guid.Empty) return;

        await LoadTitle();
        await LoadAttachments();
    }

    private async Task LoadTitle()
    {
        var result = await ApiService.GetTaskByIdAsync(TaskId);

        if (result.IsSuccess && result.Value is not null)
            TaskTitle = result.Value.Title;
    }

    private async Task LoadAttachments()
    {
        IsLoading = true;
        ErrorMessage = string.Empty;

        var result = await ApiService.GetTaskAttachmentsAsync(TaskId);

        if (result.IsSuccess && result.Value is not null)
        {
            Attachments = result.Value;
        }
        else
        {
            ErrorMessage = result.Message ?? "Failed to load attachments";
            Attachments = new List<TaskAttachmentDto>();
        }

        IsLoading = false;
    }

    private async Task HandleFileSelected(InputFileChangeEventArgs e)
    {
        ErrorMessage = string.Empty;

        var file = e.File;

        if (file is null) return;

        if (file.Size > MaxSizeBytes)
        {
            ErrorMessage = $"File size exceeds the allowed limit of {MaxSizeMb} MB.";
            return;
        }

        IsUploading = true;

        try
        {
            await using var stream = file.OpenReadStream(MaxSizeBytes);

            var result = await ApiService.UploadAttachmentAsync(
                TaskId,
                stream,
                file.Name,
                file.ContentType);

            if (result.IsSuccess)
            {
                await LoadAttachments();
            }
            else
            {
                ErrorMessage = result.Message ?? "Failed to upload attachment";
            }
        }
        catch (Exception ex)
        {
            ErrorMessage = ex.Message;
        }
        finally
        {
            IsUploading = false;
        }
    }

    private async Task Download(TaskAttachmentDto attachment)
    {
        ErrorMessage = string.Empty;

        var result = await ApiService.DownloadAttachmentAsync(TaskId, attachment.Id);

        if (!result.IsSuccess || result.Value is null)
        {
            ErrorMessage = result.Message ?? "Failed to download attachment";
            return;
        }

        var file = result.Value;

        await JS.InvokeVoidAsync(
            "downloadFileFromBytes",
            file.FileName,
            file.ContentType,
            file.Content);
    }

    private async Task Delete(TaskAttachmentDto attachment)
    {
        IsDeleting = true;
        ErrorMessage = string.Empty;

        var result = await ApiService.DeleteAttachmentAsync(TaskId, attachment.Id);

        if (result.IsSuccess)
        {
            await LoadAttachments();
        }
        else
        {
            ErrorMessage = result.Message ?? "Failed to delete attachment";
        }

        IsDeleting = false;
    }

    private async Task Close()
    {
        IsVisible = false;
        await OnClose.InvokeAsync();
    }

    private static string FormatSize(long bytes)
    {
        if (bytes < 1024) return $"{bytes} B";
        if (bytes < 1024 * 1024) return $"{bytes / 1024.0:0.##} KB";
        return $"{bytes / (1024.0 * 1024.0):0.##} MB";
    }
}