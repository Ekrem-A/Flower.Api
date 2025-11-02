using Flower.Application.Products.Dtos;

namespace Flower.Application.Products.Interfaces;

public interface IProductService
{
    Task<List<FlowerProductDto>> GetAllAsync();
    Task<FlowerProductDto?> GetByIdAsync(int id);
    Task<FlowerProductDto> CreateAsync(CreateProductRequest request);
    Task<FlowerProductDto?> UpdateAsync(int id, UpdateProductRequest request);
    Task<bool> DeleteAsync(int id);
}
