using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SliceArchitectureDemoCore.Shared;
using SliceArchitectureDemoCore.Shared.Mediator;

namespace SliceArchitectureDemoCore.Features.Category.CreateCategory
{
    public record CreateCategoryCommand(CreateCategoryRequest Category) : IRequest<ServiceResponse>;
}