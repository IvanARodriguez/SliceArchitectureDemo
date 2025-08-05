using MediatR;
using SliceArchitectureDemoCore.Shared;

namespace SliceArchitectureDemoCore.Features.Product.DeleteProduct;

public record DeleteProductCommand(int Id) : IRequest<ServiceResponse>
{

}