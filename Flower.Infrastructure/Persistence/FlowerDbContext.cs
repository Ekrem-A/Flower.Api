using Flower.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Flower.Infrastructure.Persistence;

public class FlowerDbContext : DbContext
{
    public FlowerDbContext(DbContextOptions<FlowerDbContext> options) : base(options)
    {
    }

    public DbSet<FlowerProduct> FlowerProducts => Set<FlowerProduct>();
    public DbSet<Order> Orders => Set<Order>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<FlowerProduct>().HasData(
            new FlowerProduct
            {
                Id = 1,
                Code = "FLR-001",
                Name = "Pembe Gül Buketi",
                Category = "bouquet",
                Price = 850,
                ImageUrl = "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200"
            },
            new FlowerProduct
            {
                Id = 2,
                Code = "FLR-002",
                Name = "Beyaz Orkide",
                Category = "orchid",
                Price = 1200,
                ImageUrl = "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200"
            
            },
            new FlowerProduct
            {
                Id = 3,
                Code = "FLR-003",
                Name = "Kırmızı Güller 11’li",
                Category = "bouquet",
                Price = 690,
                ImageUrl = "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200"
            },
            new FlowerProduct
            {
                Id = 4,
                Code = "FLR-004",
                Name = "Mevsim Çiçekleri Vazoda",
                Category = "mixed",
                Price = 540,
                ImageUrl = "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200"
            },
            new FlowerProduct
            {
                Id = 5,
                Code = "FLR-005",
                Name = "Saksı Orkide Çift Dal",
                Category = "orchid",
                Price = 1450,
                ImageUrl = "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200"
            },
            new FlowerProduct
            {
                Id = 6,
                Code = "FLR-006",
                Name = "Teraryum Küçük Dünya",
                Category = "terrarium",
                Price = 820,
                ImageUrl = "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200"
            },
            new FlowerProduct
            {
                Id = 7,
                Code = "FLR-007",
                Name = "Söz – Nişan Masası Çiçeği",
                Category = "ceremony",
                Price = 1950,
                ImageUrl = "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200"
            },
            new FlowerProduct
            {
                Id = 8,
                Code = "FLR-008",
                Name = "Doğum Günü Pembe Aranjman",
                Category = "birthday",
                Price = 780,
                ImageUrl = "https://images.unsplash.com/photo-1519681393784-d120267933ba?q=80&w=1200"
            }
        );
    }

}
