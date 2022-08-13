using WebApi.Models.Entities;

namespace WebApi.Extensions;

public static class Endpoints
{
    public static WebApplication RegisterEndpoints(this WebApplication app)
    {
        // Poprawa zapisu w swaggerze
        app.MapGet("/countries", ToDoRequests.GetAll)
            .Produces<List<Country>>();


        return app;
    }
}
