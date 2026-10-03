using Blazor_Web_App.Services;
using Microsoft.AspNetCore.Components;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class RateExecutorModal : ComponentBase
{
    [Parameter] public bool IsVisible { get; set; }
    [Parameter] public Guid TaskId { get; set; }
    [Parameter] public EventCallback OnCompleted { get; set; }
    [Parameter] public EventCallback OnClose { get; set; }
    [Inject] public ApiService ApiService { get; set; } = null!;

    private const int MinRating = 1;
    private const int MaxRating = 5;

    private int SelectedRating = MinRating;
    private bool IsSubmitting;
    private string ErrorMessage = string.Empty;

    private async Task Submit()
    {
        await Send(SelectedRating);
    }

    private async Task Skip()
    {
        await Send(null);
    }

    private async Task Send(int? rating)
    {
        IsSubmitting = true;
        ErrorMessage = string.Empty;

        var result = await ApiService.MarkAsDoneAsync(TaskId, rating);

        if (result.IsSuccess)
        {
            await OnCompleted.InvokeAsync();
            await CloseModal();
        }
        else
        {
            ErrorMessage = result.Message;
        }

        IsSubmitting = false;
    }

    private async Task CloseModal()
    {
        IsVisible = false;
        await OnClose.InvokeAsync();
    }
}