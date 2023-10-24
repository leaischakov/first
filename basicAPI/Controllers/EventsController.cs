using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace basicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
       // DateTime dt1 = new DateTime(2004, 10, 12);
        Event e1 = new Event(DateTime.Now);


        // GET: api/<EventController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EventController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return e1.Title;
        }

        // POST api/<EventController>
        [HttpPost]
        public void Post(string value)//הוספה
        {
            e1.Title+=value;
        }

        // PUT api/<EventController>/5
        [HttpPut("{id}")]
        public void Put(string value)//עדכון
        {
            e1.Title="i change this";
        }

        // DELETE api/<EventController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Console.WriteLine(id);
        }
    }
}
