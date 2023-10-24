using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace basicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EveController : ControllerBase
    {

        Event e=new Event(DateTime.Now);
        // GET: api/<EveController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EveController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return e.Title;
        }

        // POST api/<EveController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            e.Title+=value;
        }

        // PUT api/<EveController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            e.Id = id;
            e.Title=value;  
        }

        // DELETE api/<EveController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine(id);
        }
    }
}
