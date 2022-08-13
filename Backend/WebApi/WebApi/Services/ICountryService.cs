using WebApi.Models.Entities;

namespace WebApi.Services;

public interface ICountryService
{
    List<Country> GetAllCountries();
}
