using System;
using System.Collections.Generic;
using System.Linq;

// Minimal Student API (net9.0) - endpoints are simple and include comments
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// In-memory list used for demo; patterns are demonstrated separately under `Patterns/`
var students = new List<Student>();

app.MapGet("/students", () => Results.Ok(students));
app.MapGet("/students/{id}", (Guid id) =>
{
    var s = students.FirstOrDefault(x => x.Id == id);
    return s is null ? Results.NotFound() : Results.Ok(s);
});

app.MapPost("/students", (StudentCreateDto dto) =>
{
    var s = new Student { Name = dto.Name, Age = dto.Age, Email = dto.Email };
    students.Add(s);
    return Results.Created($"/students/{s.Id}", s);
});

app.MapDelete("/students/{id}", (Guid id) =>
{
    var s = students.FirstOrDefault(x => x.Id == id);
    if (s is null) return Results.NotFound();
    students.Remove(s);
    return Results.NoContent();
});

app.Run();

// DTO and model kept in same file for simplicity; patterns live in `Patterns/` folders
public record StudentCreateDto(string Name, int Age, string Email);

public class Student
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Email { get; set; } = string.Empty;
}
