using BuildingBlocks.Domain;

namespace Location.Domain.Entities;

public class Location : Entity
{
    public string TypeEnum { get; set; } = string.Empty;
    public string I18n_Name { get; set; } = string.Empty;
    public string I18n_Description { get; set; } = string.Empty;
    public Guid? ParentId { get; set; }

    public Location? Parent { get; set; }
}
