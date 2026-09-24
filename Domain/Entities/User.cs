using Domain.Enums.User;

namespace Domain.Entities;

public class User : Entity
{
    public string Name { get; set; } = string.Empty;
    public UserRole Role { get; set; }
    public decimal? Rating { get; set; }
}
