using BuildingBlocks.Domain;

namespace Location.Domain.Entities;

public class UserLocation : Entity
{
    public Guid IdentityMs_UserId { get; set; }
    public Guid LocationId { get; set; }
    public DateTime CreatedAt { get; set; }
}
