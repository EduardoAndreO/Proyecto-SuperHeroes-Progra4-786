using Microsoft.AspNetCore.Mvc;
using SuperHeroes.models;

namespace SuperHeroes.Controllers;

// SuperheroController
public class SuperheroController : ControllerBase
{
    // Obtener un superhéroe por ID
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        // Lógica para obtener el superhéroe por ID
        Superhero superhero = _superheroService.GetSuperheroById(id);

        if (superhero == null)
        {
            return NotFound();
        }

        return Ok(superhero);
    }

    // Crear un nuevo superhéroe
    [HttpPost]
    public IActionResult Create([FromBody] Superhero superhero)
    {
        // Validar y guardar el nuevo superhéroe en la base de datos
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _superheroService.CreateSuperhero(superhero);

        return CreatedAtAction(nameof(Get), new { id = superhero.Id }, superhero);
    }

    // Actualizar un superhéroe existente
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Superhero superhero)
    {
        // Validar y actualizar el superhéroe en la base de datos
        if (id != superhero.Id || !ModelState.IsValid)
        {
            return BadRequest();
        }

        _superheroService.UpdateSuperhero(superhero);

        return NoContent();
    }

    // Eliminar un superhéroe por ID
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Eliminar el superhéroe de la base de datos
        _superheroService.DeleteSuperhero(id);

        return NoContent();
    }
}