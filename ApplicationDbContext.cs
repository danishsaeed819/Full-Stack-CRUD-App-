using CrudApp.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Category> Categories => Set<Category>();
    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasIndex(c => c.Name).IsUnique();
            entity.Property(c => c.Name).IsRequired().HasMaxLength(100);
            entity.Property(c => c.Description).HasMaxLength(500);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(p => p.Name).IsRequired().HasMaxLength(150);
            entity.Property(p => p.Description).HasMaxLength(1000);
            entity.Property(p => p.Price).HasColumnType("decimal(18,2)");

            entity.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        });

        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electronics", Description = "Devices and gadgets" },
            new Category { Id = 2, Name = "Books", Description = "Printed and digital books" },
            new Category { Id = 3, Name = "Clothing", Description = "Apparel and accessories" }
        );
    }
}
