using Shared.Dtos.Responses;

namespace Task_Marketplace.Application.Interfaces;

public interface IPasswordHasher
{
    Result<string> Hash(string password);
    Result Verify(string password, string passwordHash);
}
