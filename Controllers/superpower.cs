using Microsoft.AspNetCore.Mvc;
using SuperHeroes.models;

namespace SuperHeroes.Controllers;

// SuperpowerController
public class SuperpowerController : ControllerBase
{
    // Obtener todos los superpoderes
    [HttpGet]
    public IActionResult GetAll()
    {
        // Lógica para obtener todos los superpoderes
        List<Superpower> superpowers = _superpowerService.GetAllSuperpowers();

        return Ok(superpowers);
    }

    // Obtener un superpoder por ID
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        // Lógica para obtener el superpoder por ID
        Superpower superpower = _superpowerService.GetSuperpowerById(id);

        if (superpower == null)
        {
            return NotFound();
        }

        return Ok(superpower);
    }

    // Crear un nuevo superpoder
    [HttpPost]
    public IActionResult Create([FromBody] Superpower superpower)
    {
        // Validar y guardar el nuevo superpoder en la base de datos
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _superpowerService.CreateSuperpower(superpower);

        return CreatedAtAction(nameof(Get), new { id = superpower.Id }, superpower);
    }

    // Actualizar un superpoder existente
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Superpower superpower)
    {
        // Validar y actualizar el superpoder en la base de datos
        if (id != superpower.Id || !ModelState.IsValid)
        {
            return BadRequest();
        }

        _superpowerService.UpdateSuperpower(superpower);

        return NoContent();
    }

    // Eliminar un superpoder por ID
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Eliminar el superpoder de la base de datos
        _superpowerService.DeleteSuperpower(id);

        return NoContent();
    }
}