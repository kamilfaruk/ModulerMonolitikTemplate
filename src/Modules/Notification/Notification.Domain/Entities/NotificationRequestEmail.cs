using BuildingBlocks.Domain;

namespace Notification.Domain.Entities;

public class NotificationRequestEmail : Entity
{
    public Guid NotificationInboxId { get; set; }
    public string EmailTo { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public string StatusEnum { get; set; } = "Pending";
    public int RetryCount { get; set; }
    public int MaxRetry { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? ProcessedAt { get; set; }
    public DateTime? SentAt { get; set; }
}
