using SliceArchitectureDemoCore.Shared;
using SliceArchitectureDemoCore.Shared.Mediator;

namespace SliceArchitectureDemoCore.Features.Product.UpdateProduct;

public record UpdateProductCommand(UpdateProductRequest Product) : IRequest<ServiceResponse>
{

}
