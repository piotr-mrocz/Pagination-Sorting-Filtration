using Microsoft.Extensions.Options;
using Sieve.Models;
using Sieve.Services;
using WebApi.Models.Entities;

namespace WebApi.Sieve;

public class AplicationSieveProcessor : SieveProcessor
{
    public AplicationSieveProcessor(IOptions<SieveOptions> options) : base(options)
    {
    }

    // Sort and filtr
    protected override SievePropertyMapper MapProperties(SievePropertyMapper mapper)
    {
        mapper.Property<Country>(c => c.Id)
            .CanSort()
            .CanFilter();

        mapper.Property<Country>(c => c.CountryName)
            .CanSort()
            .CanFilter();

        mapper.Property<Country>(c => c.CountryCode)
            .CanSort()
            .CanFilter();

        mapper.Property<Country>(c => c.CapitalCity)
            .CanSort()
            .CanFilter();

        mapper.Property<Country>(c => c.Continent)
            .CanSort()
            .CanFilter();

        mapper.Property<Country>(c => c.Population)
            .CanSort()
            .CanFilter();

        return mapper;
    }
}
