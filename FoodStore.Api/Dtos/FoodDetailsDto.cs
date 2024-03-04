namespace FoodStore.Api.Dtos;

public record class FoodDetailsDto(
    int Id, 
    string Nama, 
    int JenisId, 
    decimal Harga,
    DateOnly ReleaseDate);

