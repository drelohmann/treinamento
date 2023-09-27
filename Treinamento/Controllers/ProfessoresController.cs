using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Treinamento.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ProfessoresController : ControllerBase {
        // GET: api/<ProfessoresController>
        [HttpGet]
        public IEnumerable<string> Get() {
            return new string[] { "Professor1", "Professor2" };
        }

        // GET api/<ProfessoresController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<ProfessoresController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<ProfessoresController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<ProfessoresController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
