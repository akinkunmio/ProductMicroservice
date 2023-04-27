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

            modelBuilder.Entity<Product>().HasData(
             new Product() {ProductId = 1, CategoryID = 1, ImageBase64 = "nft1.webp", ProductName = "nft1", UnitPrice = 20, },
             new Product() { ProductId = 2, CategoryID = 2, ImageBase64 = "nft2.webp", ProductName = "nft2", UnitPrice = 50 },
             new Product() { ProductId = 3, CategoryID = 3, ImageBase64 = "nft3.webp", ProductName = "nft3", UnitPrice = 55 },
             new Product() { ProductId = 4, CategoryID = 4, ImageBase64 = "nft4.webp", ProductName = "nft4", UnitPrice = 30 },
             new Product() { ProductId = 5, CategoryID = 1, ImageBase64 = "nft5.webp", ProductName = "nft5", UnitPrice = 20 },
             new Product() { ProductId = 6, CategoryID = 2, ImageBase64 = "nft6.webp", ProductName = "nft6", UnitPrice = 10 },
             new Product() { ProductId = 7, CategoryID = 3, ImageBase64 = "nft7.webp", ProductName = "nft7", UnitPrice = 20 },
             new Product() {ProductId = 8, CategoryID = 4, ImageBase64 = "nft8.jpg", ProductName = "nft8", UnitPrice = 20 },
             new Product() {ProductId = 9, CategoryID = 1, ImageBase64 = "nft9.webp", ProductName = "nft9", UnitPrice = 25 },
             new Product() {ProductId = 10, CategoryID = 2, ImageBase64 = "nft10.webp", ProductName = "nft10", UnitPrice = 30 },
             new Product() {ProductId = 11, CategoryID = 3, ImageBase64 = "nft11.webp", ProductName = "nft11", UnitPrice = 40 },
             new Product() {ProductId = 12, CategoryID = 4, ImageBase64 = "nft12.webp", ProductName = "nft12", UnitPrice = 20 },
             new Product() {ProductId = 13, CategoryID = 1, ImageBase64 = "nft13.webp", ProductName = "nft13", UnitPrice = 30 },
             new Product() {ProductId = 14, CategoryID = 2, ImageBase64 = "nft14.webp", ProductName = "nft14", UnitPrice = 50 },
             new Product() {ProductId = 15, CategoryID = 3, ImageBase64 = "nft15.webp", ProductName = "nft15", UnitPrice = 20 },
             new Product() {ProductId = 16, CategoryID = 4, ImageBase64 = "nft16.webp", ProductName = "nft16", UnitPrice = 20 },
             new Product() { ProductId = 17, CategoryID = 1, ImageBase64 = "nft18.webp", ProductName = "nft18", UnitPrice = 20 },
             new Product() { ProductId = 18, CategoryID = 2, ImageBase64 = "nft19.webp", ProductName = "nft19", UnitPrice = 20 },
             new Product() { ProductId = 19, CategoryID = 3, ImageBase64 = "nft20.webp", ProductName = "nft20", UnitPrice = 20 },
             new Product() { ProductId = 20, CategoryID = 4, ImageBase64 = "nft21.webp", ProductName = "nft21", UnitPrice = 20 },
             new Product() { ProductId = 21, CategoryID = 1, ImageBase64 = "nft17.webp", ProductName = "nft17", UnitPrice = 28 }
             );
        }
    }
}
