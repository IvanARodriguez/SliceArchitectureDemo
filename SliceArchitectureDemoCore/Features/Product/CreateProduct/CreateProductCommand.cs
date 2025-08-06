using SliceArchitectureDemoCore.Shared;
using SliceArchitectureDemoCore.Shared.Mediator;

namespace SliceArchitectureDemoCore.Features.Product.CreateProduct;

public record CreateProductCommand(CreateProductRequest Product) : IRequest<ServiceResponse>;