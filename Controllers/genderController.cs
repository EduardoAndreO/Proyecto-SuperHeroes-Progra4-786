using Microsoft.AspNetCore.Mvc;
using SuperHeroes.models;

namespace SuperHeroes.Controllers;

// GenderController
public class GenderController : ControllerBase
{
    // Obtener todos los géneros
    [HttpGet]
    public IActionResult GetAll()
    {
        // Lógica para obtener todos los géneros
        List<Gender> genders = _genderService.GetAllGenders();

        return Ok(genders);
    }

    // Obtener un género por ID
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        // Lógica para obtener el género por ID
        Gender gender = _genderService.GetGenderById(id);

        if (gender == null)
        {
            return NotFound();
        }

        return Ok(gender);
    }

    // Crear un nuevo género
    [HttpPost]
    public IActionResult Create([FromBody] Gender gender)
    {
        // Validar y guardar el nuevo género en la base de datos
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _genderService.CreateGender(gender);

        return CreatedAtAction(nameof(Get), new { id = gender.Id }, gender);
    }

    // Actualizar un género existente
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Gender gender)
    {
        // Validar y actualizar el género en la base de datos
        if (id != gender.Id || !ModelState.IsValid)
        {
            return BadRequest();
        }

        _genderService.UpdateGender(gender);

        return NoContent();
    }

    // Eliminar un género por ID
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Eliminar el género de la base de datos
        _genderService.DeleteGender(id);

        return NoContent();
    }
}