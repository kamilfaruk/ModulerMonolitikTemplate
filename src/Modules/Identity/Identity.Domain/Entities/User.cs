using BuildingBlocks.Domain;

namespace Identity.Domain.Entities;

public class User : Entity
{
    public string Username { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string TimeZone { get; set; } = string.Empty;
    public string LanguageCode { get; set; } = string.Empty;
    public Guid RoleId { get; set; }
    public DateTime? ExpireDate { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }

    public Role? Role { get; set; }
}
