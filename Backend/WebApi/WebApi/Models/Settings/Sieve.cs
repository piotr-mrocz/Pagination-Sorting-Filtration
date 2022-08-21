namespace WebApi.Models.Settings;

public class Sieve
{
    public int DefaultPageSize { get; set; }
    public int MaxPageSize { get; set; }
    public bool ThrowExceptions { get; set; }
    public bool IgnoreNullsOnNotEqual { get; set; }
    public bool DisableNullableTypeExpressionForSorting { get; set; }
}
