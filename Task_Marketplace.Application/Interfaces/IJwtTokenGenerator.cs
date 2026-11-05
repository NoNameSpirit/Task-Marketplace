using Domain.Entities;
using Shared.Dtos.Responses.Users;

namespace Task_Marketplace.Application.Interfaces;

public interface IJwtTokenGenerator
{
    AuthDto GenerateToken(User user);
}
