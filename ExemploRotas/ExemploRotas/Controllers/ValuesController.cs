using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExemploRotas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return $"recebemos seu valor  do id {id}";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] VerbosVM value)
        {
            Console.WriteLine($"Inseriu o ID   {value:id} e nome {value.Nome}");
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] VerbosVM value)
        {
            Console.WriteLine($"Atualizou {value.Nome}");
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        public class VerbosVM
        {
            public string Nome { get; set; }
            public int id { get; set; }
        }
    }
}
