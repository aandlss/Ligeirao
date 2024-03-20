using ligeirao.models;
using ligeirao.models.DTO;
using ligeirao.services;
using ligeirao.services.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ligeirao.controllers
{
    [ApiController]
    public class LocalizacaoVeiculoController : ControllerBase
    {

        [HttpGet]
        [Route("api/[controller]/Ultimas")]
        public ActionResult<List<LocalizacaoVeiculoDTO>> Get()
        {
            var localizacoes = new ServiceLocalizacaoVeiculo().Repository.UltimasLocalizacoes().ToList();
            var localizacoesDTO = new ServiceLocalizacaoVeiculoDTO().ConvertToDTO(localizacoes);
            return Ok(localizacoesDTO);
        }

        [HttpGet]
        [Route("api/[controller]/Veiculo/{idVeiculo}")]
        public ActionResult<IEnumerable<LocalizacaoVeiculoDTO>> Get(int idVeiculo)
        {
            if (!new ServiceVeiculo().Repository.ExisteVeiculo(idVeiculo))
                return BadRequest("Veiculo não encontrado");

            var localizacoes = new ServiceLocalizacaoVeiculo().Repository.UltimasLocalizacoes(idVeiculo);
            var localizacoesDTO = new ServiceLocalizacaoVeiculoDTO().ConvertToDTO(localizacoes.ToList());
            return Ok(localizacoesDTO);
        }

        [HttpPost]
        [Route("api/[controller]/Cadastrar")]
        public IActionResult Post([FromBody] LocalizacaoVeiculoDTO localizacao)
        {
            if(localizacao == null)
                return BadRequest("Localização inválida");
            
            if(localizacao.IdVeiculo == 0)
                return BadRequest("Veículo inválido");

            localizacao.Id = 0;

            LocalizacaoVeiculo localizacaoClass = new ServiceLocalizacaoVeiculoDTO().ConvertToClass(localizacao);
            ServiceLocalizacaoVeiculo serviceLocalizacaoVeiculo = new();
            serviceLocalizacaoVeiculo.Repository.Create(localizacaoClass);

            if (localizacaoClass.Id == 0)
                return BadRequest("Falha ao incluir localizacao");

            localizacao.Id = localizacaoClass.Id;
            
            return Ok(localizacao);
        }
        
    }
}
