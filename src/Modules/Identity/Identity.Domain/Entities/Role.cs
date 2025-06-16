using BuildingBlocks.Domain;

namespace Identity.Domain.Entities;

public class Role : Entity
{
    public string I18n_Name { get; set; } = string.Empty;
    public string I18n_Description { get; set; } = string.Empty;

    public ICollection<RoleClaim> RoleClaims { get; set; } = new List<RoleClaim>();
}
