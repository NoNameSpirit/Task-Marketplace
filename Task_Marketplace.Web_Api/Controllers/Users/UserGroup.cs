using FastEndpoints;

namespace Web_Api.Controllers.Users;

public class UserGroup : Group
{
    public UserGroup()
    {
        Configure("api/user", ep =>
        {
            ep.Description(b => b.WithTags("Users"));
        });
    }
}