using Microsoft.AspNetCore.Mvc;
using SuperHeroes.models;

namespace SuperHeroes.Controllers;

// PublisherController
public class PublisherController : ControllerBase
{
    // Obtener todos los editores
    [HttpGet]
    public IActionResult GetAll()
    {
        // Lógica para obtener todos los editores
        List<Publisher> publishers = _publisherService.GetAllPublishers();

        return Ok(publishers);
    }

    // Obtener un editor por ID
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        // Lógica para obtener el editor por ID
        Publisher publisher = _publisherService.GetPublisherById(id);

        if (publisher == null)
        {
            return NotFound();
        }

        return Ok(publisher);
    }

    // Crear un nuevo editor
    [HttpPost]
    public IActionResult Create([FromBody] Publisher publisher)
    {
        // Validar y guardar el nuevo editor en la base de datos
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        _publisherService.CreatePublisher(publisher);

        return CreatedAtAction(nameof(Get), new { id = publisher.Id }, publisher);
    }

    // Actualizar un editor existente
    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody] Publisher publisher)
    {
        // Validar y actualizar el editor en la base de datos
        if (id != publisher.Id || !ModelState.IsValid)
        {
            return BadRequest();
        }

        _publisherService.UpdatePublisher(publisher);

        return NoContent();
    }

    // Eliminar un editor por ID
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Eliminar el editor de la base de datos
        _publisherService.DeletePublisher(id);

        return NoContent();
    }
}