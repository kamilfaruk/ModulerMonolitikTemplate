using BuildingBlocks.Domain;

namespace Identity.Domain.Entities;

public class RefreshToken : Entity
{
    public Guid UserId { get; set; }
    public string Token { get; set; } = string.Empty;
    public DateTime ExpiresAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsRevoked { get; set; }
    public string? ReplacedByToken { get; set; }

    public User? User { get; set; }
}
