namespace FoodStore.Api.Entities;

public class Food
{
    public int Id { get; set; }

    public required string Nama { get; set; }

    public int JenisId { get; set; }

    public Jenis? Jenis { get; set; }

    public decimal Harga { get; set; }

    public DateOnly ReleaseDate { get; set; }
}
