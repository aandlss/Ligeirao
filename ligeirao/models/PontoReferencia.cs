using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.models
{
    [Table("PontoReferencia")]
    public class PontoReferencia
    {
        [Key]
        public int Id {get; set;}
        [Column(TypeName = "varchar(max)")]
        public string Descricao {get; set;}
        [Column(TypeName = "decimal(10,8)")]
        public decimal Latitude {get; set;}
        [Column(TypeName = "decimal(11,8)")]
        public decimal Longitude {get; set;}
    }
}