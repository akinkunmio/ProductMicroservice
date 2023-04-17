using Microsoft.EntityFrameworkCore;
using ProductMicroservice.Models;

namespace ProductMicroservice.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);


            base.OnModelCreating(modelBuilder);
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
             new Category() { CategoryID = 1, CategoryName = "MusicNFT", Description = "Music NFT" },
             new Category() { CategoryID = 2, CategoryName = "GenerativeNFT", Description = "Generative NFT" },
             new Category() { CategoryID = 3, CategoryName = "DigiArtNFT", Description = "DigiArt NFT" },
             new Category() { CategoryID = 4, CategoryName = "CollectablesNFT", Description = "Collectables NFT" }
             );
        }
    }
}
