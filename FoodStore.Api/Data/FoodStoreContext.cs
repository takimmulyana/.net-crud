using FoodStore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodStore.Api.Data;

public class FoodStoreContext(DbContextOptions<FoodStoreContext> options)
    : DbContext(options)
{
    public DbSet<Food> Foods => Set<Food>();

    public DbSet<Jenis> Jeniss => Set<Jenis>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Jenis>().HasData(
            new {Id = 1, Nama = "Sayuran"},
            new {Id = 2, Nama = "Buah"},
            new {Id = 3, Nama = "Meal"},
            new {Id = 4, Nama = "Meat"},
            new {Id = 5, Nama = "Fish"}
        );
    }
}
