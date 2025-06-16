using BuildingBlocks.Domain;

namespace Location.Domain.Entities;

public class District : Entity
{
    public Guid CityId { get; set; }
    public string I18n_Name { get; set; } = string.Empty;
}
