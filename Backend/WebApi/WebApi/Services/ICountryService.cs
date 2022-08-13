using WebApi.Models.Entities;

namespace WebApi.Services;

public interface ICountryService
{
    Task<List<Country>> GetAllCountries();
}
