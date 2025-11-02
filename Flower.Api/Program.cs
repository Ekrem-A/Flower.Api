using Flower.Application.Products.Dtos;
using Flower.Application.Products.Interfaces;
using Flower.Infrastructure.Persistence;
using Flower.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// DB (in-memory)
builder.Services.AddDbContext<FlowerDbContext>(options =>
    options.UseInMemoryDatabase("FloristDb"));

// DI
builder.Services.AddScoped<IProductService, ProductService>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// (istersen) MVC
builder.Services.AddControllers();

var app = builder.Build();

// Swagger sadece dev'de
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// docker'da https yoksa yoruma al
// app.UseHttpsRedirection();

app.UseAuthorization();

// controller'lar
app.MapControllers();

// minimal endpoints
app.MapGet("/", () => " Florist Shop API (Layered) is running");

app.MapGet("/api/health", () =>
    Results.Ok(new { status = "ok", time = DateTime.UtcNow }));

app.MapGet("/api/products", async (IProductService service) =>
{
    var result = await service.GetAllAsync();
    return Results.Ok(result);
});

app.MapGet("/api/products/{id:int}", async (int id, IProductService service) =>
{
    var product = await service.GetByIdAsync(id);
    return product is not null ? Results.Ok(product) : Results.NotFound();
});

app.MapPost("/api/products", async (CreateProductRequest request, IProductService service) =>
{
    var created = await service.CreateAsync(request);
    return Results.Created($"/api/products/{created.Id}", created);
});

app.MapPut("/api/products/{id:int}", async (int id, UpdateProductRequest request, IProductService service) =>
{
    var updated = await service.UpdateAsync(id, request);
    return updated is not null ? Results.Ok(updated) : Results.NotFound();
});

app.MapDelete("/api/products/{id:int}", async (int id, IProductService service) =>
{
    var deleted = await service.DeleteAsync(id);
    return deleted ? Results.NoContent() : Results.NotFound();
});

app.Run();
