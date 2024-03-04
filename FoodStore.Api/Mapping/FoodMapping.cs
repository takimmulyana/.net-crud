using FoodStore.Api.Dtos;
using FoodStore.Api.Entities;

namespace FoodStore.Api.Mapping;

public static class FoodMapping
{
    public static Food ToEntity(this CreateFoodDto food)
    {
        return new Food()
    {
        Nama = food.Nama,
        JenisId = food.JenisId,
        Harga = food.Harga,
        ReleaseDate = food.ReleaseDate
    };
    }
    public static Food ToEntity(this UpdateFoodDto food, int id)
    {
        return new Food()
    {
        Id = id,
        Nama = food.Nama,
        JenisId = food.JenisId,
        Harga = food.Harga,
        ReleaseDate = food.ReleaseDate
    };
    }

    public static FoodSummaryDto ToFoodSummaryDto(this Food food)
    {
        return new(
        food.Id,
        food.Nama,
        food.Jenis!.Nama,
        food.Harga,
        food.ReleaseDate
        );
    }
    public static FoodDetailsDto ToFoodDetailsDto(this Food food)
    {
        return new(
        food.Id,
        food.Nama,
        food.JenisId,
        food.Harga,
        food.ReleaseDate
        );
    }
}
