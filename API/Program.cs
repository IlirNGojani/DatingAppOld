using API.Data;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt => { opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")); });

WebApplication app = builder.Build();
// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();