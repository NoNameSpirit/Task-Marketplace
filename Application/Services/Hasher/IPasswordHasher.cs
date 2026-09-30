using Shared.Dtos;

namespace Application.Services.Hasher;

public interface IPasswordHasher
{
    Result<string> Hash(string password);
    Result Verify(string password, string passwordHash);
}
