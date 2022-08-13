using Microsoft.AspNetCore.Mvc;
using WebApi.Models.Entities;
using WebApi.Services;

namespace WebApi.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CountryController : ControllerBase
{
    private readonly ICountryService _countryService;

    public CountryController(ICountryService countryService)
    {
        _countryService = countryService;
    }

    [HttpGet]
    public List<Country> GetAllCountries()
        => _countryService.GetAllCountries();
}
