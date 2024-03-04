using Microsoft.EntityFrameworkCore;

namespace FoodStore.Api.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<FoodStoreContext>();
        await dbContext.Database.MigrateAsync();
    }
}
