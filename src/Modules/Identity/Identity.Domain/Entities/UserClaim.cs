using BuildingBlocks.Domain;

namespace Identity.Domain.Entities;

public class UserClaim : Entity
{
    public Guid ClaimId { get; set; }
    public Guid UserId { get; set; }

    public Claim? Claim { get; set; }
    public User? User { get; set; }
}
