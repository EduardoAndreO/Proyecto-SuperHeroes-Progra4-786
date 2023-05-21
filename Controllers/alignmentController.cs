using Microsoft.AspNetCore.Mvc;
using SuperHeroes.models;

namespace SuperHeroes.Controllers;

// AlignmentController
public class AlignmentController : ControllerBase
{
    // Obtener todos los alineamientos
    [HttpGet]
    public IActionResult GetAll()
    {
        // Lógica para obtener todos los alineamientos
        List<Alignment> alignments = _alignmentService.GetAllAlignments();

        return Ok(alignments);
    }

    // Obtener un alineamiento por ID
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        // Lógica para obtener el alineamiento por ID
        Alignment alignment = _alignmentService.GetAlignmentById(id);

        if (alignment == null)
        {
            return NotFound();
        }

        return Ok(alignment);
    }

    // Crear un nuevo alineamiento
    [HttpPost]
    public IActionResult Create([FromBody] Alignment alignment)
    {
        // Validar y guardar el nuevo alineamiento en la base de datos
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _alignmentService.CreateAlignment(alignment);

        return CreatedAtAction(nameof(Get), new { id = alignment.Id }, alignment);
    }

    // Actualizar un alineamiento existente
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Alignment alignment)
    {
        // Validar y actualizar el alineamiento en la base de datos
        if (id != alignment.Id || !ModelState.IsValid)
        {
            return BadRequest();
        }

        _alignmentService.UpdateAlignment(alignment);

        return NoContent();
    }

    // Eliminar un alineamiento por ID
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Eliminar el alineamiento de la base de datos
        _alignmentService.DeleteAlignment(id);

        return NoContent();
    }
}