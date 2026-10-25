using FastEndpoints;

namespace Web_Api.Controllers.Auth;

public class AuthGroup : Group
{
    public AuthGroup()
    {
        Configure("api/auth", _ => { });
    }
}