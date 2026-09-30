using Shared.Dtos;
using Shared.Dtos.ProjectTasks;

namespace Blazor_Web_App.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<PagedResult<ProjectTaskDto>> GetPublishedProjectTasksAsync()
    {
        //var projectTasks = await _httpClient.GetFromJsonAsync<PagedResult<ProjectTaskDto>>("api/projecttask/published");

        return PagedResult<ProjectTaskDto>.Empty(1, 1);//projectTasks!;
    }
}
