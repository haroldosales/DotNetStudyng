using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExemploRotas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RotassController : ControllerBase
    {
        public string retorno() => "sucesso";
    }
}
