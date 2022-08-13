using System.ComponentModel;

namespace WebApi.Models.Enums;

public enum Continents
{
    [Description("Ameryka północna")]
    NorthAmerica = 1,

    [Description("Ameryka południowa")]
    SouthAmerica = 2,

    [Description("Antarktyda")]
    Antarctica = 3,

    [Description("Australia i Oceania")]
    AustraliaOceania = 4,

    [Description("Europa")]
    Europe = 5,

    [Description("Afryka")]
    Africa = 6,

    [Description("Azja")]
    Asia = 7
}
