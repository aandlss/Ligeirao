using ligeirao.models;
using ligeirao.models.DTO;
using ligeirao.services;
using ligeirao.services.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ligeirao.controllers
{
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        [HttpGet]
        [Route("api/[controller]/Todos")]
        public IActionResult Get()
        {
            ServiceVeiculo serviceVeiculo = new();
            return Ok(serviceVeiculo.Repository.GetAll());
        }

        [HttpPost]
        [Route("api/[controller]/Cadastrar")]
        public IActionResult AdicionaVeiculo([FromBody] VeiculoDTO veiculo)
        {
            Veiculo veiculoClass = new ServiceVeiculoDTO().ConvertToClass(veiculo);
            

            ServiceVeiculo serviceVeiculo = new();

            if (veiculoClass == null)
                return BadRequest("Veiculo inválido");

            if (veiculoClass.Placa == null)
                return BadRequest("Placa inválida");

            if (veiculoClass.Id != 0)
                return BadRequest("Id deve ser zero");

            if(serviceVeiculo.PlacaIsValid(veiculoClass.Placa) == false)
                return BadRequest("Placa inválida");

            veiculoClass.LocalizacoesVeiculo = null;
            serviceVeiculo.Repository.Create(veiculoClass);

            if (veiculoClass.Id == 0)
                return BadRequest("Falha ao incluir veiculo");

            return Ok("Veiculo incluído com sucesso");
        }
    }
}
