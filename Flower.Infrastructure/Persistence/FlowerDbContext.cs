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
            new FlowerProduct { Id = 1, Code = "FLR-001", Name = "Pembe Gül Buketi", Category = "bouquet", Price = 850 },
            new FlowerProduct { Id = 2, Code = "FLR-002", Name = "Beyaz Orkide", Category = "orchid", Price = 1200 }
        );
    }
}
