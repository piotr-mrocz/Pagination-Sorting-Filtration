using Sieve.Models;
using Sieve.Services;
using WebApi.Data;
using WebApi.Models.Entities;
using WebApi.Models.Responses;

namespace WebApi.Services.Iterfaces;

public interface ICountryService
{
    Task<PagedResult<Country>> GetAllCountries(SieveModel query);
}
