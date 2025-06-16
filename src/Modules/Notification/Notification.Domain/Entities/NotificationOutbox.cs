using BuildingBlocks.Domain;

namespace Notification.Domain.Entities;

public class NotificationOutbox : Entity
{
    public string CorrelationId { get; set; } = string.Empty;
    public string EventTypeEnum { get; set; } = string.Empty;
    public string Payload { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public bool Published { get; set; }
    public DateTime? PublishedAt { get; set; }
}
