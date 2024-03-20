using ligeirao.models;
using ligeirao.models.DTO;

namespace ligeirao.services.DTO
{
    public class ServiceVeiculoDTO
    {
        public ServiceVeiculoDTO() { }
        public Veiculo ConvertToClass(VeiculoDTO veiculoDTO) => new Veiculo
        {
            Id = (int)veiculoDTO.Id,
            Descricao = veiculoDTO.Descricao,
            Placa = veiculoDTO.Placa
        };

        public VeiculoDTO ConvertToDTO(Veiculo veiculo) => new VeiculoDTO
        {
            Id = veiculo.Id,
            Descricao = veiculo.Descricao,
            Placa = veiculo.Placa
        };
    }
}
