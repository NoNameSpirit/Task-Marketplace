using Blazor_Web_App.Resources;
using Blazor_Web_App.Services.Receivers.ProjectTasks;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Commands;

namespace Blazor_Web_App.Components.Pages.TasksModals;

public partial class CreateTaskModal : ComponentBase
{
    [Inject] public IProjectTaskService ProjectTaskService { get; set; } = null!;
    [Inject] public IStringLocalizer<SharedResources> Localizer { get; set; } = null!;

    private const int DefaultDurationDays = 7;

    [Parameter] public bool IsVisible { get; set; }

    [Parameter] public EventCallback OnCreated { get; set; }

    [Parameter] public EventCallback OnClose { get; set; }

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

        var dto = new CreateRequest
        {
            Title = Title,
            Description = Description,
            Price = Price,
            StartsAt = StartsAt,
            EndsAt = EndsAt
        };

        var result = await ProjectTaskService.CreateTaskAsync(dto);

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