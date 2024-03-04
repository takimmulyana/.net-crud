using FoodStore.Api.Data;
using FoodStore.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connstring = builder.Configuration.GetConnectionString("FoodStore");
builder.Services.AddSqlite<FoodStoreContext>(connstring);

var app = builder.Build();

app.MapFoodEndpoints();
app.MapJenissEndpoints();

await app.MigrateDbAsync();

app.Run();
