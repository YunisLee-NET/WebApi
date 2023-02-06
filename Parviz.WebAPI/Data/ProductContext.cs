using Microsoft.EntityFrameworkCore;

namespace Parviz.WebAPI.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category[]
            {
                new(){ID=1,CategoryName="Notbuk"},
                new(){ID=2,CategoryName="Telefon"}
            });
            modelBuilder.Entity<Product>().Property(x => x.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new() { Id=1, Name="Lenovo Ideapad", Price=1600,Stock=15,CreatedTime=System.DateTime.Now.AddDays(-3),ImagePath="https://amazoncomp.az/wp-content/uploads/2021/02/879e1188ce55477baa8a6111c7a9e4bb.jpg",CategoryId=1},
                new() { Id=2, Name="Xiaomi 12", Price=1100,Stock=10,CreatedTime=System.DateTime.Now.AddDays(-2),ImagePath="https://kontakt.az/wp-content/uploads/gallery-tum/TM-DG-SBP-1105-SM-1849_25d3acf64c924d9482b1916e696cad69_w_png.webp",CategoryId=1},
                new() { Id=3, Name="Sony PlayStation 5", Price=1800,Stock=6,CreatedTime=System.DateTime.Now.AddDays(-5),ImagePath="https://kontakt.az/wp-content/uploads/2021/08/New-Project-48.jpg", CategoryId = 1}
            });
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
