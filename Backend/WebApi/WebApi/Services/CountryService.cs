using Microsoft.EntityFrameworkCore;
using Sieve.Models;
using Sieve.Services;
using WebApi.Data;
using WebApi.Models.Entities;
using WebApi.Models.Responses;

namespace WebApi.Services;

public class CountryService : ICountryService
{
    private readonly IApplicationDbContext _dbContext;

    public CountryService(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<PagedResult<Country>> GetAllCountries(SieveModel query, ISieveProcessor sieveProcessor)
    {
        var countriesList = _dbContext.Countries.AsQueryable();

        var countryListPage = await sieveProcessor.Apply(query, countriesList).ToListAsync();
        var total = await sieveProcessor.Apply(query, countriesList, applyFiltering: false, applySorting: false).CountAsync();

        var result = new PagedResult<Country>(total, query.PageSize.Value, query.Page.Value, countryListPage);

        return result;
    }
}
