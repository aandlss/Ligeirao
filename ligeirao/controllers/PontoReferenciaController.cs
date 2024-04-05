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
        public ActionResult<List<PontoReferencia>> Add([FromBody] List<PontoReferencia> pontosReferencia) {


            foreach (var pontoReferencia in pontosReferencia)
            {
                pontoReferencia.Id = 0;
                if (pontoReferencia == null)
                    return BadRequest("Ponto de referência inválido");

                if (string.IsNullOrEmpty(pontoReferencia.Descricao))
                    return BadRequest("Descrição inválida");

                new ServicePontoReferencia().Repository.Create(pontoReferencia);

            }

            return pontosReferencia;
        }
        
        
    }
}
