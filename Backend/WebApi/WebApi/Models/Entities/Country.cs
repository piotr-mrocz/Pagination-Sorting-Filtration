namespace WebApi.Models.Entities;

public class Country
{
    public int Id { get; set; }
    public string CountryName { get; set; } = null!;
    public string CountryCode { get; set; } = null!;
    public string CapitalCity { get; set; } = null!;
    public string Continent { get; set; } = null!;
    public int Population { get; set; }
}
