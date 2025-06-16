using Location.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Location.Infrastructure;

public class LocationDbContext : DbContext
{
    public LocationDbContext(DbContextOptions<LocationDbContext> options) : base(options) { }

    public DbSet<Location.Domain.Entities.Location> Locations => Set<Location.Domain.Entities.Location>();
    public DbSet<Dealer> Dealers => Set<Dealer>();
    public DbSet<Company> Companies => Set<Company>();
    public DbSet<Region> Regions => Set<Region>();
    public DbSet<Area> Areas => Set<Area>();
    public DbSet<Room> Rooms => Set<Room>();
    public DbSet<Address> Addresses => Set<Address>();
    public DbSet<Country> Countries => Set<Country>();
    public DbSet<City> Cities => Set<City>();
    public DbSet<District> Districts => Set<District>();
    public DbSet<UserLocation> UserLocations => Set<UserLocation>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("location");
    }
}
