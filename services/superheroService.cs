using System;
using SuperHeroes.models;

namespace SuperHeroes.Service
// SuperheroService
public class SuperheroService
{
    private readonly IRepository<Superhero> _superheroRepository;

    public SuperheroService(IRepository<Superhero> superheroRepository)
    {
        _superheroRepository = superheroRepository;
    }

    public List<Superhero> GetAllSuperheroes()
    {
        return _superheroRepository.GetAll().ToList();
    }

    public Superhero GetSuperheroById(int id)
    {
        return _superheroRepository.GetById(id);
    }

    public void CreateSuperhero(Superhero superhero)
    {
        _superheroRepository.Create(superhero);
    }

    public void UpdateSuperhero(Superhero superhero)
    {
        _superheroRepository.Update(superhero);
    }

    public void DeleteSuperhero(int id)
    {
        _superheroRepository.Delete(id);
    }
}

// HeroAttributeService
public class HeroAttributeService
{
    private readonly IRepository<HeroAttribute> _heroAttributeRepository;

    public HeroAttributeService(IRepository<HeroAttribute> heroAttributeRepository)
    {
        _heroAttributeRepository = heroAttributeRepository;
    }

    public List<HeroAttribute> GetAllHeroAttributes()
    {
        return _heroAttributeRepository.GetAll().ToList();
    }

    public HeroAttribute GetHeroAttributeById(int heroId, int attributeId)
    {
        return _heroAttributeRepository.GetById(heroId, attributeId);
    }

    public void CreateHeroAttribute(HeroAttribute heroAttribute)
    {
        _heroAttributeRepository.Create(heroAttribute);
    }

    public void UpdateHeroAttribute(HeroAttribute heroAttribute)
    {
        _heroAttributeRepository.Update(heroAttribute);
    }

    public void DeleteHeroAttribute(int heroId, int attributeId)
    {
        _heroAttributeRepository.Delete(heroId, attributeId);
    }
}

// AttributeService
public class AttributeService
{
    private readonly IRepository<Attribute> _attributeRepository;

    public AttributeService(IRepository<Attribute> attributeRepository)
    {
        _attributeRepository = attributeRepository;
    }

    public List<Attribute> GetAllAttributes()
    {
        return _attributeRepository.GetAll().ToList();
    }

    public Attribute GetAttributeById(int id)
    {
        return _attributeRepository.GetById(id);
    }

    public void CreateAttribute(Attribute attribute)
    {
        _attributeRepository.Create(attribute);
    }

    public void UpdateAttribute(Attribute attribute)
    {
        _attributeRepository.Update(attribute);
    }

    public void DeleteAttribute(int id)
    {
        _attributeRepository.Delete(id);
    }
}

// ColourService
public class ColourService
{
    private readonly IRepository<Colour> _colourRepository;

    public ColourService(IRepository<Colour> colourRepository)
    {
        _colourRepository = colourRepository;
    }

    public List<Colour> GetAllColours()
    {
        return _colourRepository.GetAll().ToList();
    }

    public Colour GetColourById(int id)
    {
        return _colourRepository.GetById(id);
    }

    public void CreateColour(Colour colour)
    {
        _colourRepository.Create(colour);
    }

    public void UpdateColour(Colour colour)
    {
        _colourRepository.Update(colour);
    }

    public void DeleteColour(int id)
    {
        _colourRepository.Delete(id);
    }
}

// AlignmentService
public class AlignmentService
{
    private readonly IRepository<Alignment> _alignmentRepository;

    public AlignmentService(IRepository<Alignment> alignmentRepository)
    {
        _alignmentRepository = alignmentRepository;
    }

    public List<Alignment> GetAllAlignments()
    {
        return _alignmentRepository.GetAll().ToList();
    }

    public Alignment Get
