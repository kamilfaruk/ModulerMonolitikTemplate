using BuildingBlocks.Domain;

namespace Identity.Domain.Entities;

public class RoleClaim : Entity
{
    public Guid ClaimId { get; set; }
    public Guid RoleId { get; set; }

    public Claim? Claim { get; set; }
    public Role? Role { get; set; }
}
