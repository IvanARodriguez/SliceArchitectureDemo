using Microsoft.EntityFrameworkCore;
using SliceArchitectureDemoCore.Exceptions;
using SliceArchitectureDemoCore.Features.Category;
using SliceArchitectureDemoCore.Features.Product;
using SliceArchitectureDemoCore.Infrastructure;
using SliceArchitectureDemoCore.Shared.Mediator;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDBContext>(option => option.UseSqlite(builder.Configuration.GetConnectionString("Connection")));
builder.Services.AddExceptionHandler<GlobalExceptionsHandler>();
builder.Services.AddMediator();
var app = builder.Build();
app.MapGet("/test", (HttpRequest request, HttpResponse response) =>
{
    throw new Exception("Failed");
});
app.UseExceptionHandler(_ => { });
app.UseHttpsRedirection();
app.MapProductEndpoints();
app.MapCategoryEndpoints();
app.Run();