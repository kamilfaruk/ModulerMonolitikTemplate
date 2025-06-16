using BuildingBlocks.Domain;

namespace Notification.Domain.Entities;

public class NotificationInbox : Entity
{
    public string CorrelationId { get; set; } = string.Empty;
    public string MessageType { get; set; } = string.Empty;
    public string Payload { get; set; } = string.Empty;
    public DateTime ReceivedAt { get; set; }
    public bool Processed { get; set; }
    public DateTime? ProcessedAt { get; set; }
}
