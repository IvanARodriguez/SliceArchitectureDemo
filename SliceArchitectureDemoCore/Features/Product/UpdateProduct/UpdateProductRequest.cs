namespace SliceArchitectureDemoCore.Features.Product.UpdateProduct;

public record UpdateProductRequest(int id, string name, string description, decimal price, int categoryId);