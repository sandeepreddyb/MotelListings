using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotelListings.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country> Countries{ get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "India",
                    ShortName = "IN"
                },
                new Country
                {
                    Id = 2,
                    Name = "NewZealand",
                    ShortName = "NZ"
                },
                new Country
                {
                    Id = 3,
                    Name = "America",
                    ShortName = "US"
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Reddy Group Of Hotels",
                    Address = "Andhra",
                    CountryId = 1,
                    Rating = 5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "LemonTree",
                    Address = "Wellington",
                    CountryId = 2,
                    Rating = 4
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Parrys",
                    Address = "Los Angels",
                    CountryId = 3,
                    Rating = 4.5
                }
                );
        }
    }
}
