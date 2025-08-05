using MediatR;
using SliceArchitectureDemoCore.Shared;

namespace SliceArchitectureDemoCore.Features.Product.UpdateProduct;

public record UpdateProductCommand(UpdateProductRequest Product) : IRequest<ServiceResponse>
{

}
