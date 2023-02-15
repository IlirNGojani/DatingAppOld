using API.Extensions;
using API.Middleware;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddApplicationServcices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

WebApplication app = builder.Build();
// Configure the HTTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();