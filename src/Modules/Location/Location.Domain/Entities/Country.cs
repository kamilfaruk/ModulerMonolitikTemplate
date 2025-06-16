using BuildingBlocks.Domain;

namespace Location.Domain.Entities;

public class Country : Entity
{
    public string I18n_Name { get; set; } = string.Empty;
}
