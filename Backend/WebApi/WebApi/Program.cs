using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Extensions;
using WebApi.Models.Settings;
using WebApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICountryService, CountryService>();

#region Database
builder.Services.AddDbContext<ApplicationDbContext>(x =>
    x.UseSqlServer(builder.Configuration.GetConnectionString(nameof(ConnectionString.LearningDatabase))));

builder.Services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
builder.Services.AddScoped<DatabaseSeeder>();
#endregion Database

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseHttpsRedirection();
app.MapControllers();
DatabaseSeederExtension.SeedDatabase(app.Services.CreateScope());

app.Run();
