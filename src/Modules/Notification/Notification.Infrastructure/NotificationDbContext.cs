using Microsoft.EntityFrameworkCore;
using Notification.Domain.Entities;

namespace Notification.Infrastructure;

public class NotificationDbContext : DbContext
{
    public NotificationDbContext(DbContextOptions<NotificationDbContext> options) : base(options) { }

    public DbSet<NotificationInbox> NotificationInbox => Set<NotificationInbox>();
    public DbSet<NotificationRequestEmail> NotificationRequestEmails => Set<NotificationRequestEmail>();
    public DbSet<NotificationRequestSms> NotificationRequestSms => Set<NotificationRequestSms>();
    public DbSet<NotificationLog> NotificationLogs => Set<NotificationLog>();
    public DbSet<NotificationProvider> NotificationProviders => Set<NotificationProvider>();
    public DbSet<NotificationOutbox> NotificationOutbox => Set<NotificationOutbox>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("notification");
    }
}
