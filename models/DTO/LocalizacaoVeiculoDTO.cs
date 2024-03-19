using System.ComponentModel.DataAnnotations.Schema;

namespace ligeirao.models.DTO
{
    public class LocalizacaoVeiculoDTO
    {
        public int Id { get; set; }
        public int IdVeiculo { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
