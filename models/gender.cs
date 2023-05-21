// Modelo Gender
using SuperHeroes.models;

public class Gender
{
    public int Id { get; set; }
    public string? GenderName { get; set; }
    public List<Superhero>? Superheroes { get; set; }
}