using FoodStore.Api.Data;
using FoodStore.Api.Dtos;
using FoodStore.Api.Entities;
using FoodStore.Api.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FoodStore.Api.Endpoints;

public static class FoodsEndpoints
{
    const string GetFoodEndpointName = "GetFood";

    public static RouteGroupBuilder MapFoodEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("foods")
                       .WithParameterValidation();
        
    //GET /foods
    group.MapGet("/", async (FoodStoreContext dbContext) => 
        await dbContext.Foods
                 .Include(food => food.Jenis)
                 .Select(food => food.ToFoodSummaryDto())
                 .AsNoTracking()
                 .ToListAsync());

    //GET /foods/1
    group.MapGet("/{id}", async (int id, FoodStoreContext dbContext) => 
    {
    Food? food = await dbContext.Foods.FindAsync(id);

    return food is null ? 
        Results.NotFound() : Results.Ok(food.ToFoodDetailsDto());
    })
    .WithName(GetFoodEndpointName);

    // POST /foods
    group.MapPost("/", async (CreateFoodDto newFood, FoodStoreContext dbContext) => 
    {
        Food food = newFood.ToEntity();

        dbContext.Foods.Add(food);
        await dbContext.SaveChangesAsync();

    return Results.CreatedAtRoute(
        GetFoodEndpointName, 
        new { id = food.Id}, 
        food.ToFoodDetailsDto());
    });

    //PUT foods
    group.MapPut("/{id}", async (int id, UpdateFoodDto updatedFood, FoodStoreContext dbContext) => 
    {
    var existingFood = await dbContext.Foods.FindAsync(id);

    if(existingFood is null)
    {
        return Results.NotFound();
    }

    dbContext.Entry(existingFood)
             .CurrentValues
             .SetValues(updatedFood.ToEntity(id));

    await dbContext.SaveChangesAsync();

    return Results.NoContent();
    });

    //DELETE /foods/1
    group.MapDelete("/{id}", async (int id, FoodStoreContext dbContext) => 
    {
    await dbContext.Foods.Where(food => food.Id == id)
                   .ExecuteDeleteAsync();

    return Results.NoContent();
    });

    return group;
    }
}
