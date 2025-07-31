using MediatR;
using SliceArchitectureDemoCore.Features.Product.CreateProduct;

namespace SliceArchitectureDemoCore.Features.Product;

public static class ProductEndpoints
{
  public static IEndpointConventionBuilder MapProductEndpoints(this IEndpointRouteBuilder endpoint)
  {
    var productGroup = endpoint.MapGroup("/product");
    productGroup.MapPost("/create", async (CreateProductRequest product, ISender sender) =>
    {
      var response = await sender.Send(new CreateProductCommand(product));
      return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    });
    return productGroup;
  }
}