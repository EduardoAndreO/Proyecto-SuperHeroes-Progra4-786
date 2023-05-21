// Modelo Alignment
using SuperHeroes.models;

public class Alignment
{
    public int Id { get; set; }
    public string? AlignmentName { get; set; }
    public List<Superhero>? Superheroes { get; set; }
}