using FastEndpoints;

namespace Web_Api.Controllers.Projects;

public class ProjectTaskGroup : Group
{
    public ProjectTaskGroup()
    {
        Configure("api/projecttask", _ => { });
    }
}
