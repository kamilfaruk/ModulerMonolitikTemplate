using BuildingBlocks.Domain;

namespace Location.Domain.Entities;

public class Region : Entity
{
    public string AddressType { get; set; } = string.Empty;
    public Guid AddressId { get; set; }
}
