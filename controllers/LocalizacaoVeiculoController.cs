using ligeirao.models;
using ligeirao.services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ligeirao.controllers
{
    [ApiController]
    public class LocalizacaoVeiculoController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]")]
        public ActionResult<string> Get()
        {
            return Ok("Teste feito com sucesso");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Post([FromBody] LocalizacaoVeiculo localizacao)
        {
            if(localizacao == null)
                return BadRequest("Localização inválida");
            
            if(localizacao.IdVeiculo == 0)
                return BadRequest("Veículo inválido");

            if(localizacao.Latitude == 0)
                return BadRequest("Latitude inválida");

            if(localizacao.Longitude == 0)
                return BadRequest("Longitude inválida");

            if(localizacao.Id != 0)
                return BadRequest("Id deve ser zero");

            ServiceLocalizacaoVeiculo serviceLocalizacaoVeiculo = new();
            serviceLocalizacaoVeiculo.Repository.Create(localizacao);

            if (localizacao.Id == 0)
                return BadRequest("Falha ao incluir localizacao");

            return Ok("Localização incluída com sucesso");
        }
        
    }
}
