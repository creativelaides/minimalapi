using System.Text.Json;
using minimalapi.Entities;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();


app.UseHttpsRedirection();

app.MapGet("/person", () => 
{
    IReadOnlyCollection<Person> persons = 
    [
        new()
        {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@example.com" 
        }, 
        new()
            {
                Id = 1,
                FirstName = "Jane",
                LastName = "Doe",
                Email = "janedoe@example.com"
            },
        ];
        return JsonSerializer.Serialize(persons);
    });


app.Run();

