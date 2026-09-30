using Blazor_Web_App.Services;
using Microsoft.AspNetCore.Components;
using Shared.Dtos.ProjectTasks;
using System.Collections.ObjectModel;

namespace Blazor_Web_App.Components.Pages;

public partial class ProjectTasks
{
    [Inject]
    public ApiService _apiService { get; set; } = null!;

    public ReadOnlyCollection<ProjectTaskDto> Tasks { get; private set; } = [];

    protected override async Task OnInitializedAsync()
    {
        var pagedResult = await _apiService.GetPublishedProjectTasksAsync();

        // Tasks = pagedResult.Collection;
    }
}
