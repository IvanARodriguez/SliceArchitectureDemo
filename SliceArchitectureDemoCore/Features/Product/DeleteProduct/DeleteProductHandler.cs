

using MediatR;
using SliceArchitectureDemoCore.Infrastructure;
using SliceArchitectureDemoCore.Shared;

namespace SliceArchitectureDemoCore.Features.Product.DeleteProduct;

public class DeleteProductHandler(AppDBContext context) : IRequestHandler<DeleteProductCommand, ServiceResponse>
{
    public async Task<ServiceResponse> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = await context.Products.FindAsync([request.Id], cancellationToken: cancellationToken) ?? throw new ArgumentException("Product could not be found");
        context.Products.Remove(product);
        await context.SaveChangesAsync(cancellationToken);
        return new ServiceResponse(true, "Product deleted");
    }
}
