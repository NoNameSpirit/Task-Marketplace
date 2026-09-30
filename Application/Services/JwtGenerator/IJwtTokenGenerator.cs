using Domain.Entities;

namespace Application.Services.JwtGenerator;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
