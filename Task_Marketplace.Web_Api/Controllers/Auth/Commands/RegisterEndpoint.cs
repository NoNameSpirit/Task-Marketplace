using MediatR;
using Shared.Dtos.Responses.Users;
using Task_Marketplace.Application.Handlers.Auth.Commands.Register;
using Task_Marketplace.Shared.Dtos.Requests.Auth.Commands;

namespace Web_Api.Controllers.Auth.Commands;

public class RegisterEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<RegisterRequest, AuthDto>
{
    public override void Configure()
    {
        Post("register");
        Group<AuthGroup>();
        AllowAnonymous();
    }

    public override async Task HandleAsync(
        RegisterRequest request,
        CancellationToken cancellationToken = default)
    {
        var command = new RegisterUserCommand(
            request.Name,
            request.Password,
            request.Role);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}