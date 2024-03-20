using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.models
{
    [Table("LocalizacaoVeiculo")]
    public class LocalizacaoVeiculo
    {
        [Key]
        public int Id {get; set;}
        public int IdVeiculo {get; set;}
        public decimal Latitude {get; set;}
        [Column(TypeName = "decimal(11,8)")]
        public decimal Longitude {get; set;}
        [Column(TypeName = "datetime")]
        public DateTime Horario { get; set; }
        public Veiculo? Veiculo { get; set;}
    }
}