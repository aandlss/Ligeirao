using ligeirao.models;
using ligeirao.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace controllers
{
    [ApiController]
    public class PontoReferenciaController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]/Todos")]
        public ActionResult<IEnumerable<PontoReferencia>> GetAll(){
            var pontosReferencia = new ServicePontoReferencia().Repository.GetAll();
            return Ok(pontosReferencia);
        }

        [HttpPost]
        [Route("api/[controller]/Cadastrar")]
        public ActionResult<PontoReferencia> Add([FromBody] PontoReferencia pontoReferencia) {
            pontoReferencia.Id = 0;
            if(pontoReferencia == null)
                return BadRequest("Ponto de refer�ncia inv�lido");

            if(string.IsNullOrEmpty(pontoReferencia.Descricao))
                return BadRequest("Descri��o inv�lida");

            pontoReferencia = new ServicePontoReferencia().Repository.Create(pontoReferencia);

            return pontoReferencia;
        }
        
        
    }
}
