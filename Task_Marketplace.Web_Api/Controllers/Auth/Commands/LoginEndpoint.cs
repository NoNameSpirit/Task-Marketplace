using MediatR;
using Shared.Dtos.Responses.Users;
using Task_Marketplace.Application.Handlers.Auth.Commands.Login;
using Task_Marketplace.Shared.Dtos.Requests.Auth.Commands;

namespace Web_Api.Controllers.Auth.Commands;

public class LoginEndpoint
    (IMediator _mediatr)
    : BaseEndpoint<LoginRequest, AuthDto>
{
    public override void Configure()
    {
        Post("login");
        Group<AuthGroup>();
        AllowAnonymous();
    }

    public override async Task HandleAsync(
        LoginRequest request,
        CancellationToken cancellationToken = default)
    {
        var command = new LoginUserCommand(
            request.Name,
            request.Password);

        var result = await _mediatr.Send(command, cancellationToken);

        if (await SendIfFailureAsync(result, cancellationToken))
        {
            return;
        }

        await Send.OkAsync(result.Value!, cancellationToken);
    }
}