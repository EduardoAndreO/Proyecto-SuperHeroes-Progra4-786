namespace SuperHeroes.models

// Modelo Superhero
public class Superhero
{
    public int Id { get; set; }
    public string? SuperheroName { get; set; }
    public string? FullName { get; set; }
    public int GenderId { get; set; }
    public int EyeColourId { get; set; }
    public int HairColourId { get; set; }
    public int SkinColourId { get; set; }
    public int RaceId { get; set; }
    public int PublisherId { get; set; }
    public int AlignmentId { get; set; }
    public decimal HeightCm { get; set; }
    public decimal WeightKg { get; set; }

    // Relaciones con otras entidades
    public Gender? Gender { get; set; }
    public EyeColour EyeColour { get; set; }
    public HairColour HairColour { get; set; }
    public SkinColour SkinColour { get; set; }
    public Race? Race { get; set; }
    public Publisher? Publisher { get; set; }
    public Alignment? Alignment { get; set; }
    public List<HeroPower>? HeroPowers { get; set; }
}