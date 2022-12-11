using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace PracticingHotelListing.API.Data
{
    public class PracticingHotelListingDbContext : DbContext
    {
        public PracticingHotelListingDbContext(DbContextOptions options) : base(options) 
        { 
                
        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name= "Jamaica",
                    shortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    shortName = "BM"
                },
                new Country
                {
                    Id = 3,
                    Name = "Cayman Islands",
                    shortName = "CI"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort and SPA",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4
                }
             );
        }

    }
}
