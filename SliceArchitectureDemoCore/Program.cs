using Microsoft.EntityFrameworkCore;
using SliceArchitectureDemoCore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddOpenApi();
builder.Services.AddDbContext<AppDBContext>(option => option.UseSqlite(builder.Configuration.GetConnectionString("Connection")));
var app = builder.Build();
app.UseHttpsRedirection();
app.Run();