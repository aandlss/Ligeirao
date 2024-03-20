using System.ComponentModel.DataAnnotations.Schema;

namespace ligeirao.models.DTO
{
    public class VeiculoDTO
    {
        public int? Id { get; set; }
        public string? Descricao { get; set; }
        public string? Placa { get; set; }
    }
}
