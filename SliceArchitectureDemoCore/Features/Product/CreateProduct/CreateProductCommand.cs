using MediatR;
using SliceArchitectureDemoCore.Shared;

namespace SliceArchitectureDemoCore.Features.Product.CreateProduct;

public record CreateProductCommand(CreateProductRequest Product) : IRequest<ServiceResponse>
{

}