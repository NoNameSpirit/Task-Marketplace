using Blazor_Web_App.Services;
using Microsoft.AspNetCore.Components;
using Shared.Dtos.Requests.ProjectTasks;

namespace Blazor_Web_App.Components.Pages;

public partial class CreateTaskModal : ComponentBase
{
    [Parameter] public bool IsVisible { get; set; }
    [Parameter] public EventCallback OnCreated { get; set; }
    [Parameter] public EventCallback OnClose { get; set; }
    [Inject] public ApiService ApiService { get; set; } = null!;

    private const int DefaultDurationDays = 7;

    private string Title = string.Empty;
    private string Description = string.Empty;
    private decimal Price;
    private DateTimeOffset StartsAt = DateTimeOffset.Now;
    private DateTimeOffset EndsAt = DateTimeOffset.Now.AddDays(DefaultDurationDays);
    private bool IsSubmitting;
    private string ErrorMessage = string.Empty;

    private async Task SubmitTask()
    {
        IsSubmitting = true;
        ErrorMessage = string.Empty;

        var dto = new CreateProjectTaskDto
        {
            Title = Title,
            Description = Description,
            Price = Price,
            StartsAt = StartsAt,
            EndsAt = EndsAt
        };

        var result = await ApiService.CreateTaskAsync(dto);

        if (result.IsSuccess)
        {
            await OnCreated.InvokeAsync();
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