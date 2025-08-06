namespace SliceArchitectureDemoCore.Features.Product.UpdateProduct;

public record UpdateProductRequest(int Id, string Name, string Description, decimal Price, int CategoryId);