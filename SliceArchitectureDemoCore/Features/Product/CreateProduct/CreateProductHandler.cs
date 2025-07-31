using Mapster;
using MediatR;
using SliceArchitectureDemoCore.Infrastructure;
using SliceArchitectureDemoCore.Shared;

namespace SliceArchitectureDemoCore.Features.Product.CreateProduct;

public class CreateProductHandler(AppDBContext context) : IRequestHandler<CreateProductCommand, ServiceResponse>
{
  public async Task<ServiceResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
  {
    var product = request.Product.Adapt<Domain.Product>();
    context.Products.Add(product);
    await context.SaveChangesAsync(cancellationToken);
    return new ServiceResponse(true, "Saved");
  }
}