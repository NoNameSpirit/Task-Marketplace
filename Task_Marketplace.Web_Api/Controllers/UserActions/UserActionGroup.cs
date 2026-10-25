using FastEndpoints;

namespace Web_Api.Controllers.UserActions;

public class UserActionGroup : Group
{
    public UserActionGroup()
    {
        Configure("api/useraction", _ => { });
    }
}