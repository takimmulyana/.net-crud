using FoodStore.Api.Dtos;
using FoodStore.Api.Entities;

namespace FoodStore.Api.Mapping;

public static class JenisMapping
{
    public static JenisDto ToDto(this Jenis jenis)
    {
        return new JenisDto(jenis.Id, jenis.Nama);
    }
}
