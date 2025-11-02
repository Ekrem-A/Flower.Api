using Flower.Application.Products.Dtos;
using Flower.Application.Products.Interfaces;
using Flower.Domain.Entities;
using Flower.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Flower.Infrastructure.Services;

public class ProductService : IProductService
{
    private readonly FlowerDbContext _context;

    public ProductService(FlowerDbContext context)
    {
        _context = context;
    }

    public async Task<List<FlowerProductDto>> GetAllAsync()
    {
        return await _context.FlowerProducts
            .Select(p => new FlowerProductDto
            {
                Id = p.Id,
                Code = p.Code,
                Name = p.Name,
                Category = p.Category,
                Price = p.Price
            })
            .ToListAsync();
    }

    public async Task<FlowerProductDto?> GetByIdAsync(int id)
    {
        var p = await _context.FlowerProducts.FindAsync(id);
        if (p is null) return null;

        return new FlowerProductDto
        {
            Id = p.Id,
            Code = p.Code,
            Name = p.Name,
            Category = p.Category,
            Price = p.Price
        };
    }

    public async Task<FlowerProductDto> CreateAsync(CreateProductRequest request)
    {
        var entity = new FlowerProduct
        {
            Code = request.Code,
            Name = request.Name,
            Category = request.Category,
            Price = request.Price,
            Description = request.Description,
            ImageUrl = request.ImageUrl
        };

        _context.FlowerProducts.Add(entity);
        await _context.SaveChangesAsync();

        return new FlowerProductDto
        {
            Id = entity.Id,
            Code = entity.Code,
            Name = entity.Name,
            Category = entity.Category,
            Price = entity.Price
        };
    }

    public async Task<FlowerProductDto?> UpdateAsync(int id, UpdateProductRequest request)
    {
        var entity = await _context.FlowerProducts.FindAsync(id);
        if (entity is null) return null;

        entity.Code = request.Code;
        entity.Name = request.Name;
        entity.Category = request.Category;
        entity.Price = request.Price;
        entity.Description = request.Description;
        entity.ImageUrl = request.ImageUrl;
        entity.IsAvailable = request.IsAvailable;

        await _context.SaveChangesAsync();

        return new FlowerProductDto
        {
            Id = entity.Id,
            Code = entity.Code,
            Name = entity.Name,
            Category = entity.Category,
            Price = entity.Price
        };
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.FlowerProducts.FindAsync(id);
        if (entity is null) return false;

        _context.FlowerProducts.Remove(entity);
        await _context.SaveChangesAsync();
        return true;
    }
}
