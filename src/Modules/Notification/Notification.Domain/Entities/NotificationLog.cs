using BuildingBlocks.Domain;

namespace Notification.Domain.Entities;

public class NotificationLog : Entity
{
    public string NotificationTypeEnum { get; set; } = string.Empty;
    public Guid NotificationRequestId { get; set; }
    public int AttemptNo { get; set; }
    public DateTime AttemptTime { get; set; }
    public bool Success { get; set; }
    public string Response { get; set; } = string.Empty;
}
