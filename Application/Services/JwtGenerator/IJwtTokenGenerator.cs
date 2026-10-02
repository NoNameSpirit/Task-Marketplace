using Domain.Entities;
using Shared.Dtos.Responses.Users;

namespace Application.Services.JwtGenerator;

public interface IJwtTokenGenerator
{
    AuthDto GenerateToken(User user);
}
