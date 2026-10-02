namespace Shared.Dtos.Responses.Users;

public record class AuthDto
{
    public string Id { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;

    public AuthDto() { }

    public AuthDto(
        string token,
        string name,
        string role,
        string id)
    {
        Token = token;
        Name = name;
        Role = role;
        Id = id;
    }
}
