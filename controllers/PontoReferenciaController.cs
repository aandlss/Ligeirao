using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace controllers
{
    [ApiController]
    public class PontoReferenciaController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]")]
        public ActionResult<string> Get(){
            return Ok("Teste feito com sucesso");
        }
        
    }
}
