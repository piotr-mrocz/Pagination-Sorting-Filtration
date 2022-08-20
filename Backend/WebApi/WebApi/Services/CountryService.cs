using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models.Entities;

namespace WebApi.Services;

public class CountryService : ICountryService
{
    private readonly IApplicationDbContext _dbContext;

    public CountryService(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<Country> GetAllCountries()
    {
        var countriesList = _dbContext.Countries.ToList();
        return countriesList;
    }
}
