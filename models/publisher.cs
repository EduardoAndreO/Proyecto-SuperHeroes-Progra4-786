// Modelo Publisher
using SuperHeroes.models;

public class Publisher
{
    public int? Id { get; set; }
    public string? PublisherName { get; set; }
    public List<Superhero>? Superheroes { get; set; }
}