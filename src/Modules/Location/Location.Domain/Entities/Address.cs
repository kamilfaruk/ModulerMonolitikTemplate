using BuildingBlocks.Domain;

namespace Location.Domain.Entities;

public class Address : Entity
{
    public Guid CountryId { get; set; }
    public Guid CityId { get; set; }
    public Guid DistrictId { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
}
