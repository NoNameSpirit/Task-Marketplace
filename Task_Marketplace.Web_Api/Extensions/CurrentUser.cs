using Application.Interfaces;
using System.Security.Claims;

namespace Web_Api.Extensions;

public class CurrentUser : ICurrentUser
{
    private readonly IHttpContextAccessor _contextAccessor;

    public CurrentUser(IHttpContextAccessor contextAccessor)
    {
        _contextAccessor = contextAccessor;
    }

    public Guid Id
    {
        get
        {
            var value = _contextAccessor.HttpContext?.User
                .FindFirstValue(ClaimTypes.NameIdentifier);

            return Guid.TryParse(value, out var id) ? id : Guid.Empty;
        }
    }

    public bool IsInRole(string role)
    {
        return _contextAccessor.HttpContext?.User
            .IsInRole(role) ?? false;
    }
}
