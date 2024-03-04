using FoodStore.Api.Data;
using FoodStore.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FoodStore.Api.Endpoints;

public static class JenissEndpoints
{
    public static RouteGroupBuilder MapJenissEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("jeniss");

        group.MapGet("/", async (FoodStoreContext dbContext) =>
        await dbContext.Jeniss
                       .Select(jenis => jenis.ToDto())
                       .AsNoTracking()
                       .ToListAsync());
        return group;
    }
}
