using Microsoft.EntityFrameworkCore;
using SliceArchitectureDemoCore.Exceptions;
using SliceArchitectureDemoCore.Features.Product;
using SliceArchitectureDemoCore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDBContext>(option => option.UseSqlite(builder.Configuration.GetConnectionString("Connection")));
builder.Services.AddExceptionHandler<GlobalExceptionsHandler>();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(Program).Assembly));
var app = builder.Build();
app.MapGet("/test", (HttpRequest request, HttpResponse response) =>
{
    throw new Exception("Failed");
});
app.UseExceptionHandler(_ => { });
app.UseHttpsRedirection();
app.MapProductEndpoints();
app.Run();