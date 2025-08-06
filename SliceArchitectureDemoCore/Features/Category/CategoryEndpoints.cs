using SliceArchitectureDemoCore.Features.Category.CreateCategory;
using SliceArchitectureDemoCore.Shared.Mediator;

namespace SliceArchitectureDemoCore.Features.Category;

public static class CategoryEndpoints
{
  public static IEndpointConventionBuilder MapCategoryEndpoints(this IEndpointRouteBuilder endpoint)
  {
    var categoryEndpoints = endpoint.MapGroup("/category");

    categoryEndpoints.MapPost("", async (CreateCategoryRequest category, ISender sender) =>
    {
      var response = await sender.Send(new CreateCategoryCommand(category));
      return response.Success ? Results.Ok(response) : Results.BadRequest(response);
    });

    return categoryEndpoints;
  }
}