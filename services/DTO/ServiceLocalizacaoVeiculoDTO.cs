using ligeirao.models;
using ligeirao.models.DTO;

namespace ligeirao.services.DTO
{
    public class ServiceLocalizacaoVeiculoDTO
    {
        public ServiceLocalizacaoVeiculoDTO()
        {
        }

        public LocalizacaoVeiculo ConvertToClass (LocalizacaoVeiculoDTO localizacao)
        {
            return new LocalizacaoVeiculo
            {
                Id = localizacao.Id,
                IdVeiculo = localizacao.IdVeiculo,
                Latitude = localizacao.Latitude,
                Longitude = localizacao.Longitude,
                Horario = localizacao.Horario
            };
        }

        public LocalizacaoVeiculoDTO ConvertToDTO (LocalizacaoVeiculo localizacao)
        {
            return new LocalizacaoVeiculoDTO
            {
                Id = localizacao.Id,
                IdVeiculo = localizacao.IdVeiculo,
                Latitude = localizacao.Latitude,
                Longitude = localizacao.Longitude
            };
        }

        public List<LocalizacaoVeiculoDTO> ConvertToDTO(List<LocalizacaoVeiculo> localizacoes)
        {
            var localizacoesDTO = new List<LocalizacaoVeiculoDTO>();
            foreach(var localizacao in localizacoes)
            {
                localizacoesDTO.Add(new LocalizacaoVeiculoDTO { 
                    Id = localizacao.Id,
                    IdVeiculo = localizacao.IdVeiculo,
                    Latitude = localizacao.Latitude,
                    Longitude = localizacao.Longitude
                });
            }

            return localizacoesDTO;
        }
    }
}
