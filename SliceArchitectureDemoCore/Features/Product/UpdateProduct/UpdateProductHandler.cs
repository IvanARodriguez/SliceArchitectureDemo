using Mapster;
using MediatR;
using SliceArchitectureDemoCore.Infrastructure;
using SliceArchitectureDemoCore.Shared;

namespace SliceArchitectureDemoCore.Features.Product.UpdateProduct;

public class UpdateProductHandler(AppDBContext context) : IRequestHandler<UpdateProductCommand, ServiceResponse>
{
  public async Task<ServiceResponse> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
  {
    var product = request.Product.Adapt<Domain.Product>();
    context.Products.Update(product);
    await context.SaveChangesAsync(cancellationToken);
    return new ServiceResponse(true, "Product updated");
  }
}