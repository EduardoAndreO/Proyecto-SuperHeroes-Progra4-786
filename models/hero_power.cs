// Modelo HeroPower
using SuperHeroes.models;

public class HeroPower
{
    public int HeroId { get; set; }
    public int PowerId { get; set; }

    // Relaciones con otras entidades
    public Superhero? Superhero { get; set; }
    public Superpower? Superpower { get; set; }
}