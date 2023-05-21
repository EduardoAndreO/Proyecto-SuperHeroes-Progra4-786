// Modelo Race
using SuperHeroes.models;

public class Race
{
    public int Id { get; set; }
    public string? RaceName { get; set; }
    public List<Superhero>? Superheroes { get; set; }
}