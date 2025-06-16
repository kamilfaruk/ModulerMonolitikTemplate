using BuildingBlocks.Domain;

namespace Notification.Domain.Entities;

public class NotificationProvider : Entity
{
    public string Type { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Config { get; set; } = string.Empty;
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
}
