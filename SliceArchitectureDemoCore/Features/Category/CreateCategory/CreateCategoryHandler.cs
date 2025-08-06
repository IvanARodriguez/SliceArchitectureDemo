using Mapster;
using SliceArchitectureDemoCore.Infrastructure;
using SliceArchitectureDemoCore.Shared;
using SliceArchitectureDemoCore.Shared.Mediator;

namespace SliceArchitectureDemoCore.Features.Category.CreateCategory;

public class CreateCategoryHandler(AppDBContext context) : IRequestHandler<CreateCategoryCommand, ServiceResponse>
{
  public async Task<ServiceResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
  {
    var category = request.Category.Adapt<Domain.Category>();
    context.Categories.Add(category);
    await context.SaveChangesAsync(cancellationToken);
    return new ServiceResponse(true, "Category created");
  }
}
