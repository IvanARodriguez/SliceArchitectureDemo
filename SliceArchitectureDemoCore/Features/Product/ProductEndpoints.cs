using MediatR;
using SliceArchitectureDemoCore.Features.Product.CreateProduct;
using SliceArchitectureDemoCore.Features.Product.DeleteProduct;
using SliceArchitectureDemoCore.Features.Product.UpdateProduct;

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
    productGroup.MapPut("/update", async (UpdateProductRequest product, ISender sender) =>
    {
      var response = await sender.Send(new UpdateProductCommand(product));
      return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    });
    productGroup.MapDelete("/delete/{id}", async (int id, ISender sender) =>
    {
      var response = await sender.Send(new DeleteProductCommand(id));
      return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    });
    return productGroup;
  }
}