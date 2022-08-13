using WebApi.Data;
using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entities;
using WebApi.Helpers;
using WebApi.Models.Enums;

namespace WebApi.Extensions;

public class DatabaseSeeder
{
    private readonly ApplicationDbContext _dbContext;

    public DatabaseSeeder(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Seed()
    {
        if (_dbContext.Database.CanConnect())
        {
            if (!_dbContext.Countries.Any())
            {
                var countries = GetCountries();
                _dbContext.Countries.AddRange(countries);
                _dbContext.SaveChanges();
            }
        }
    }

    private List<Country> GetCountries()
    {
        var countries = new List<Country>();

        #region North America

        countries.Add(
           new Country()
           {
               CountryName = "Kanada",
               CapitalCity = "Ottawa",
               Continent = EnumHelper.GetEnumDescription(Continents.NorthAmerica),
               CountryCode = "CA",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "USA",
               CapitalCity = "Waszyngton",
               Continent = EnumHelper.GetEnumDescription(Continents.NorthAmerica),
               CountryCode = "US",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Meksyk",
               CapitalCity = "Meksyk",
               Continent = EnumHelper.GetEnumDescription(Continents.NorthAmerica),
               CountryCode = "MX",
               Population = GeneratePopulation()
           });

        #endregion North America

        #region South America

        countries.Add(
            new Country()
            {
                CountryName = "Kolumbia",
                CapitalCity = "Bogota",
                Continent = EnumHelper.GetEnumDescription(Continents.SouthAmerica),
                CountryCode = "CO",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Wenezuela",
                CapitalCity = "Caracas",
                Continent = EnumHelper.GetEnumDescription(Continents.SouthAmerica),
                CountryCode = "VE",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Gujana",
                CapitalCity = "Georgetown",
                Continent = EnumHelper.GetEnumDescription(Continents.SouthAmerica),
                CountryCode = "GY",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Peru",
                CapitalCity = "Lima",
                Continent = EnumHelper.GetEnumDescription(Continents.SouthAmerica),
                CountryCode = "PE",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Brazylia",
                CapitalCity = "Brasilia",
                Continent = EnumHelper.GetEnumDescription(Continents.SouthAmerica),
                CountryCode = "BR",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Argentyna",
                CapitalCity = "Buenos Aires",
                Continent = EnumHelper.GetEnumDescription(Continents.SouthAmerica),
                CountryCode = "AR",
                Population = GeneratePopulation()
            });

        #endregion South America

        #region Europe

        countries.Add(
            new Country()
            {
                CountryName = "Islandia",
                CapitalCity = "Rejkiawik",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "IS",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Irlandia",
                CapitalCity = "Dublin",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "IE",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Portugalia",
                CapitalCity = "Lisbona",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "PT",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Hiszpania",
                CapitalCity = "Madryt",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "ES",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Wielka Brytania",
                CapitalCity = "Londyn",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "GB",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Francja",
                CapitalCity = "Paryż",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "FR",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Holandia",
                CapitalCity = "Amsterdam",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "NL",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Belgia",
                CapitalCity = "Bruksela",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "BE",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Szwajcaria",
                CapitalCity = "Berno",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "CH",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Włochy",
                CapitalCity = "Rzym",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "IT",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Norwegia",
                CapitalCity = "Oslo",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "NO",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Szwecja",
                CapitalCity = "Sztokholm",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "SE",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Dania",
                CapitalCity = "Kopenhaga",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "DK",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Niemcy",
                CapitalCity = "Berlin",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "DE",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Polska",
                CapitalCity = "Warszawa",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "PL",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Austria",
                CapitalCity = "Wiedeń",
                Continent = EnumHelper.GetEnumDescription(Continents.Europe),
                CountryCode = "AT",
                Population = GeneratePopulation()
            });

        #endregion Europe

        #region Asia

        countries.Add(
            new Country()
            {
                CountryName = "Izrael",
                CapitalCity = "Jerozolima",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "IL",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Syria",
                CapitalCity = "Damaszek",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "SY",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Gruzja",
                CapitalCity = "Tbilisi",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "GE",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Irak",
                CapitalCity = "Bagdad",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "IQ",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Arabia Saudyjska",
                CapitalCity = "Rijad",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "SA",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Kuwejt",
                CapitalCity = "Kuwejt",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "KW",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Afganistan",
                CapitalCity = "Kabul",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "AF",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Pakistan",
                CapitalCity = "Islamabad",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "PK",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Indie",
                CapitalCity = "Delhi",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "IN",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Chiny",
                CapitalCity = "Pekin",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "CN",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Mongolia",
                CapitalCity = "Ułan - Bator",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "MN",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Japonia",
                CapitalCity = "Tokio",
                Continent = EnumHelper.GetEnumDescription(Continents.Asia),
                CountryCode = "JP",
                Population = GeneratePopulation()
            });

        #endregion Asia

        #region Africa

        countries.Add(
           new Country()
           {
               CountryName = "Maroko",
               CapitalCity = "Rabat",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "MA",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Algieria",
               CapitalCity = "Algier",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "DZ",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Tunezja",
               CapitalCity = "Tunis",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "TN",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Libia",
               CapitalCity = "Trypolis",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "LY",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Egipt",
               CapitalCity = "Kair",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "EG",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Niger",
               CapitalCity = "Niamej",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "NE",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Sudan",
               CapitalCity = "Chartum",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "SD",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Senegal",
               CapitalCity = "Dakar",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "SN",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Erytrea",
               CapitalCity = "Asmara",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "ER",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Angola",
               CapitalCity = "Luanada",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "AO",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Zambia",
               CapitalCity = "Lusaka",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "ZM",
               Population = GeneratePopulation()
           });

        countries.Add(
           new Country()
           {
               CountryName = "Malawi",
               CapitalCity = "Lilongwe",
               Continent = EnumHelper.GetEnumDescription(Continents.Africa),
               CountryCode = "MW",
               Population = GeneratePopulation()
           });

        #endregion Africa

        #region Australia

        countries.Add(
            new Country()
            {
                CountryName = "Australia",
                CapitalCity = "Canberra",
                Continent = EnumHelper.GetEnumDescription(Continents.AustraliaOceania),
                CountryCode = "AU",
                Population = GeneratePopulation()
            });

        countries.Add(
            new Country()
            {
                CountryName = "Nowa Zelandia",
                CapitalCity = "Wellington",
                Continent = EnumHelper.GetEnumDescription(Continents.AustraliaOceania),
                CountryCode = "NZ",
                Population = GeneratePopulation()
            });

        #endregion Australia

        return countries;
    }

    private int GeneratePopulation()
    {
        var random = new Random();
        return random.Next(100, 1000);
    }
}
