using Application.Users.Commands.Login;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web_Api.Dtos.Users;
using Web_Api.Extensions;

namespace Web_Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediatr;

    public AuthController(IMediator mediatr)
    {
        _mediatr = mediatr;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(
        [FromBody] RegisterUserDto request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterUserCommand(
            request.Name,
            request.Password,
            request.Role);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(
        [FromBody] LoginDto request,
        CancellationToken cancellationToken)
    {
        var command = new LoginUserCommand(
            request.Name,
            request.Password);

        var result = await _mediatr.Send(command, cancellationToken);

        return result.ToResponse(this);
    }
}
