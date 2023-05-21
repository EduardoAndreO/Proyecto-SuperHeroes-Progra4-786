using SuperHeroes.models;

// Modelo HeroAttribute
public class HeroAttribute
{
    public int HeroId { get; set; }
    public int AttributeId { get; set; }
    public string? AttributeValue { get; set; }

    // Relaciones con otras entidades
    public Superhero? Superhero { get; set; }
    public Attribute? Attribute { get; set; }
}
