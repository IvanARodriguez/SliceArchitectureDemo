using SliceArchitectureDemoCore.Shared;
using SliceArchitectureDemoCore.Shared.Mediator;

namespace SliceArchitectureDemoCore.Features.Product.DeleteProduct;

public record DeleteProductCommand(int Id) : IRequest<ServiceResponse>
{

}