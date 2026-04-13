using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using project_net.Model;
using project_net.Services;

namespace project_net.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : ControllerBase
    {
        private IPersonServices _personServices;
        public PersonController(IPersonServices personServices)
        {
            _personServices = personServices;
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personServices.findAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personServices.findById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }
        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            var createdPerson = _personServices.Create(person);
            if (createdPerson == null) return BadRequest();
            return Ok(createdPerson);
        }
        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
            var createdPerson = _personServices.Updadate(person);
            if (createdPerson == null) return BadRequest();
            return Ok(createdPerson);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _personServices.Delete(id);
            return NoContent();
        }
    }
}
