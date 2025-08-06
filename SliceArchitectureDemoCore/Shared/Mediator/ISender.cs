using Microsoft.AspNetCore.Identity.Data;

namespace SliceArchitectureDemoCore.Shared.Mediator;

public interface ISender
{
  Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default);

}