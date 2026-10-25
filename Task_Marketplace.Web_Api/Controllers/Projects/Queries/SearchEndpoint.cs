using Application.Interfaces;
using MediatR;
using Shared.Dtos.Responses;
using Shared.Dtos.Responses.ProjectTasks;
using Shared.Enums;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Queries.SearchTasks;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Queries;

namespace Web_Api.Controllers.Projects;

public class SearchEndpoint
    (IMediator _mediatr, ICurrentUser _currentUser)
    : BaseEndpoint<SearchRequest, PagedResult<ProjectTaskDto>>
{
    public override void Configure()
    {
        Get("search");
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        SearchRequest request,
        CancellationToken cancellationToken = default)
    {
        var isCustomer = _currentUser.IsInRole(nameof(UserRole.Customer));

        var searchQuery = SearchTasksQueryFactory.Create(
            _currentUser,
            isCustomer,
            request.Query,
            request.Page,
            request.PageSize);

        var result = await _mediatr.Send(searchQuery, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}