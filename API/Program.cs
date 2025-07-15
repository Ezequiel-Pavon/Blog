using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddDbContext<BlogContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();