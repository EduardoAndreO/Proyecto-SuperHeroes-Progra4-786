using Microsoft.AspNetCore.Mvc;
using SuperHeroes.models;

namespace SuperHeroes.Controllers;

// AttributeController
public class AttributeController : ControllerBase
{
    // Obtener todos los atributos
    [HttpGet]
    public IActionResult GetAll()
    {
        // Lógica para obtener todos los atributos
        List<Attribute> attributes = _attributeService.GetAllAttributes();

        return Ok(attributes);
    }

    // Obtener un atributo por ID
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        // Lógica para obtener el atributo por ID
        Attribute attribute = _attributeService.GetAttributeById(id);

        if (attribute == null)
        {
            return NotFound();
        }

        return Ok(attribute);
    }

    // Crear un nuevo atributo
    [HttpPost]
    public IActionResult Create([FromBody] Attribute attribute)
    {
        // Validar y guardar el nuevo atributo en la base de datos
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _attributeService.CreateAttribute(attribute);

        return CreatedAtAction(nameof(Get), new { id = attribute.Id }, attribute);
    }

    // Actualizar un atributo existente
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Attribute attribute)
    {
        // Validar y actualizar el atributo en la base de datos
        if (id != attribute.Id || !ModelState.IsValid)
        {
            return BadRequest();
        }

        _attributeService.UpdateAttribute(attribute);

        return NoContent();
    }

    // Eliminar un atributo por ID
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Eliminar el atributo de la base de datos
        _attributeService.DeleteAttribute(id);

        return NoContent();
    }
}