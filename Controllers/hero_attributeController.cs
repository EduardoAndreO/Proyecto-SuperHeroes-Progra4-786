using Microsoft.AspNetCore.Mvc;
using SuperHeroes.models;

namespace SuperHeroes.Controllers;

// HeroAttributeController
public class HeroAttributeController : ControllerBase
{
    // Obtener atributos de un héroe por ID
    [HttpGet("{heroId}")]
    public IActionResult GetByHeroId(int heroId)
    {
        // Lógica para obtener los atributos de un héroe por ID
        List<HeroAttribute> heroAttributes = _heroAttributeService.GetHeroAttributesByHeroId(heroId);

        return Ok(heroAttributes);
    }

    // Agregar un nuevo atributo a un héroe
    [HttpPost]
    public IActionResult Create([FromBody] HeroAttribute heroAttribute)
    {
        // Validar y guardar el nuevo atributo del héroe en la base de datos
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _heroAttributeService.CreateHeroAttribute(heroAttribute);

        return CreatedAtAction(nameof(GetByHeroId), new { heroId = heroAttribute.HeroId }, heroAttribute);
    }

    // Actualizar un atributo existente de un héroe
    [HttpPut("{heroId}/{attributeId}")]
    public IActionResult Update(int heroId, int attributeId, [FromBody] HeroAttribute heroAttribute)
    {
        // Validar y actualizar el atributo del héroe en la base de datos
        if (heroId != heroAttribute.HeroId || attributeId != heroAttribute.AttributeId || !ModelState.IsValid)
        {
            return BadRequest();
        }

        _heroAttributeService.UpdateHeroAttribute(heroAttribute);

        return NoContent();
    }

    // Eliminar un atributo de un héroe por ID
    [HttpDelete("{heroId}/{attributeId}")]
    public IActionResult Delete(int heroId, int attributeId)
    {
        // Eliminar el atributo del héroe de la base de datos
        _heroAttributeService.DeleteHeroAttribute(heroId, attributeId);

        return NoContent();
    }
}
