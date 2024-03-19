using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.models
{
    [Table("Veiculo")]
    public class Veiculo
    {
        [Key]
        public int Id {get; set;}
        public string? Descricao {get; set;}
        [Column(TypeName = "char(7)")]
        public string? Placa {get; set;}
        public List<LocalizacaoVeiculo>? LocalizacoesVeiculo { get; set;}
    }
}