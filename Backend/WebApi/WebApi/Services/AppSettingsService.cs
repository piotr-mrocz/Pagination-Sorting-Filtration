using WebApi.Services.Iterfaces;

namespace WebApi.Services;

public class AppSettingsService : IAppSettingsService
{
    private readonly IConfiguration _configuration;

    public AppSettingsService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public int GetDefaultPageSize()
    {
        var defaultPageSizeString = _configuration["Sieve:DefaultPageSize"];
        int defaultPageSize = int.TryParse(defaultPageSizeString, out defaultPageSize) ? defaultPageSize : default;
        return defaultPageSize;
    }

    public int GetMaxPageSize()
    {
        var defaultMaxPageSizeString = _configuration["Sieve:MaxPageSize"];
        int defaultMaxPageSize = int.TryParse(defaultMaxPageSizeString, out defaultMaxPageSize) ? defaultMaxPageSize : default;
        return defaultMaxPageSize;
    }
}