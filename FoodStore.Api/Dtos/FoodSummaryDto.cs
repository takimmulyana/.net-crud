namespace FoodStore.Api.Dtos;

public record class FoodSummaryDto(
    int Id, 
    string Nama, 
    string Jenis, 
    decimal Harga,
    DateOnly ReleaseDate);

