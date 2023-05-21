using Microsoft.AspNetCore.Mvc;
using SuperHeroes.models;

namespace SuperHeroes.Controllers;

// RaceController
public class RaceController : ControllerBase
{
    // Obtener todas las razas
    [HttpGet]
    public IActionResult GetAll()
    {
        // Lógica para obtener todas las razas
        List<Race> races = _raceService.GetAllRaces();

        return Ok(races);
    }

    // Obtener una raza por ID
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        // Lógica para obtener la raza por ID
        Race race = _raceService.GetRaceById(id);

        if (race == null)
        {
            return NotFound();
        }

        return Ok(race);
    }

    // Crear una nueva raza
    [HttpPost]
    public IActionResult Create([FromBody] Race race)
    {
        // Validar y guardar la nueva raza en la base de datos
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _raceService.CreateRace(race);

        return CreatedAtAction(nameof(Get), new { id = race.Id }, race);
    }

    // Actualizar una raza existente
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Race race)
    {
        // Validar y actualizar la raza en la base de datos
        if (id != race.Id || !ModelState.IsValid)
        {
            return BadRequest();
        }

        _raceService.UpdateRace(race);

        return NoContent();
    }

    // Eliminar una raza por ID
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Eliminar la raza de la base de datos
        _raceService.DeleteRace(id);

        return NoContent();
    }
}
