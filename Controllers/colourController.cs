using Microsoft.AspNetCore.Mvc;
using SuperHeroes.models;

namespace SuperHeroes.Controllers;

// ColourController
public class ColourController : ControllerBase
{
    // Obtener todos los colores
    [HttpGet]
    public IActionResult GetAll()
    {
        // Lógica para obtener todos los colores
        List<Colour> colours = _colourService.GetAllColours();

        return Ok(colours);
    }

    // Obtener un color por ID
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        // Lógica para obtener el color por ID
        Colour colour = _colourService.GetColourById(id);

        if (colour == null)
        {
            return NotFound();
        }

        return Ok(colour);
    }

    // Crear un nuevo color
    [HttpPost]
    public IActionResult Create([FromBody] Colour colour)
    {
        // Validar y guardar el nuevo color en la base de datos
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _colourService.CreateColour(colour);

        return CreatedAtAction(nameof(Get), new { id = colour.Id }, colour);
    }

    // Actualizar un color existente
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Colour colour)
    {
        // Validar y actualizar el color en la base de datos
        if (id != colour.Id || !ModelState.IsValid)
        {
            return BadRequest();
        }

        _colourService.UpdateColour(colour);

        return NoContent();
    }

    // Eliminar un color por ID
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Eliminar el color de la base de datos
        _colourService.DeleteColour(id);

        return NoContent();
    }
}