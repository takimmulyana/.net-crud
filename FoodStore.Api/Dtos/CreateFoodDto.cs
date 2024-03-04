using System.ComponentModel.DataAnnotations;

namespace FoodStore.Api.Dtos;

public record class CreateFoodDto
(
    [Required][StringLength(50)] string Nama, 
    int JenisId, 
    [Range(1,100)] decimal Harga,
    DateOnly ReleaseDate
);
