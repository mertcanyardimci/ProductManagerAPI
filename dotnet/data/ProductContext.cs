using dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            for (int i = 1; i <= 50; i++)
            {
                modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = i,
                        memberId = new Bogus.Randomizer().Number(123456, 123459),
                        cityId = new Bogus.Randomizer().Number(1, 81),
                        CityName = new Bogus.DataSets.Lorem().Word(),
                        TownName = new Bogus.DataSets.Lorem().Word(),
                        ModelName = new Bogus.DataSets.Lorem().Word(),
                        Year = new Bogus.Randomizer().Number(1990, 2023),
                        Price = new Bogus.Randomizer().Number(100000, 1000000),
                        Km = new Bogus.Randomizer().Number(100, 100000),
                        Title = new Bogus.DataSets.Lorem().Word(),
                        Text = new Bogus.DataSets.Lorem().Paragraph(),
                    }
                );
            }
        
        }
    }
}