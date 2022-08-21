using Microsoft.EntityFrameworkCore;
using Sieve.Models;
using Sieve.Services;
using WebApi.Data;
using WebApi.Extensions;
using WebApi.Models.Settings;
using WebApi.Services;
using WebApi.Services.Iterfaces;
using WebApi.Sieve;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IAppSettingsService, AppSettingsService>();
builder.Services.AddScoped<ISieveProcessor, AplicationSieveProcessor>();

builder.Services.Configure<SieveOptions>(builder.Configuration.GetSection(nameof(Sieve)));

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
