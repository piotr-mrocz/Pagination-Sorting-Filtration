using Microsoft.AspNetCore.Mvc;
using Sieve.Models;
using Sieve.Services;
using WebApi.Data;
using WebApi.Models.Entities;
using WebApi.Models.Responses;
using WebApi.Services.Iterfaces;

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

    [HttpPost]
    public async Task<PagedResult<Country>> GetAllCountries([FromBody] SieveModel query)
        => await _countryService.GetAllCountries(query);
}
