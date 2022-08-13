namespace WebApi.Extensions;

public static class DatabaseSeederExtension
{
    public static void SeedDatabase(this IServiceScope scope)
    {
        var databaseSeeder = scope.ServiceProvider.GetService<DatabaseSeeder>();

        if (databaseSeeder is not null)
        {
            databaseSeeder.Seed();
        }
    }
}
