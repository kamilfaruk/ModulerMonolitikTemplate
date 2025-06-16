using BuildingBlocks.Domain;

namespace Location.Domain.Entities;

public class Dealer : Entity
{
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string AddressType { get; set; } = string.Empty;
    public Guid AddressId { get; set; }
    public bool IsActive { get; set; }
}
