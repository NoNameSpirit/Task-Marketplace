using MediatR;
using Shared.Dtos.Responses.ProjectTasks;
using System.Security.Claims;
using Task_Marketplace.Application.Handlers.ProjectTasks.Queries.GetById;
using Task_Marketplace.Shared.Dtos.Requests.ProjectTasks.Queries;

namespace Web_Api.Controllers.Projects;

public class GetByIdEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<GetByIdRequest, ProjectTaskDto>
{
    public override void Configure()
    {
        Get("{id}");
        Group<ProjectTaskGroup>();
        Claims(ClaimTypes.NameIdentifier);
    }

    public override async Task HandleAsync(
        GetByIdRequest request,
        CancellationToken cancellationToken = default)
    {
        var query = new GetProjectTaskByIdQuery(request.Id);

        var result = await _mediatr.Send(query, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}