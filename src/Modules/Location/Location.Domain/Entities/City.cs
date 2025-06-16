using BuildingBlocks.Domain;

namespace Location.Domain.Entities;

public class City : Entity
{
    public Guid CountryId { get; set; }
    public string I18n_Name { get; set; } = string.Empty;
}
