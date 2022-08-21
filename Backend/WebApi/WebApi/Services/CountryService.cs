using Microsoft.EntityFrameworkCore;
using Sieve.Models;
using Sieve.Services;
using WebApi.Data;
using WebApi.Models.Entities;
using WebApi.Models.Responses;
using WebApi.Services.Iterfaces;

namespace WebApi.Services;

public class CountryService : ICountryService
{
    private readonly IApplicationDbContext _dbContext;
    private readonly ISieveProcessor _sieveProcessor;
    private readonly IAppSettingsService _configuration;

    public CountryService(
        IApplicationDbContext dbContext,
        ISieveProcessor sieveProcessor,
        IAppSettingsService configuration)
    {
        _dbContext = dbContext;
        _sieveProcessor = sieveProcessor;
        _configuration = configuration;
    }

    public async Task<PagedResult<Country>> GetAllCountries(SieveModel query)
    {
        var countriesList = _dbContext.Countries.AsQueryable();

        var countryListPage = await _sieveProcessor.Apply(query, countriesList).ToListAsync();
        var total = await _sieveProcessor.Apply(query, countriesList, applyPagination: false, applySorting: false).CountAsync();

        var pageSize = query.PageSize.HasValue ? query.PageSize.Value : _configuration.GetDefaultPageSize();
        var page = query.Page.HasValue ? query.Page.Value : 1;

        var result = new PagedResult<Country>(total, pageSize, page, countryListPage);

        return result;
    }
}
