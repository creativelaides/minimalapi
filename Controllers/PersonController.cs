using Microsoft.AspNetCore.Mvc;

namespace minimalapi.Entities;

public class PersonController : ControllerBase
{
    private readonly ILogger<PersonController> _logger;
    private readonly List<Person> _people;

    public PersonController(ILogger<PersonController> logger)
    {
        _logger = logger;
        _people = new List<Person>();
    }

    [HttpGet("api/people")]
    public ActionResult<IEnumerable<Person>> GetPeople()
    {
        return Ok(_people);
    }

    [HttpGet("api/people/{id}")]
    public ActionResult<Person> GetPerson(int id)
    {
        var person = _people.FirstOrDefault(p => p.Id == id);
        if (person == null)
            return NotFound();

        return Ok(person);
    }

    [HttpPost("api/people")]
    public ActionResult<Person> CreatePerson(Person person)
    {
        person.Id = _people.Count > 0 ? _people.Max(p => p.Id) + 1 : 1;
        _people.Add(person);
        return CreatedAtAction(nameof(GetPerson), new { id = person.Id }, person);
    }
}