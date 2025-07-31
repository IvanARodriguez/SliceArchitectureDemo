namespace SliceArchitectureDemoCore.Features.Product.CreateProduct;

public record CreateProductRequest(string Name, decimal Price, int CategoryId);