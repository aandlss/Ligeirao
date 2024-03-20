using ligeirao.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.interfaces
{
    public interface IRepositoryLocalizacaoVeiculo : IRepositoryBase<LocalizacaoVeiculo>
    {
        IEnumerable<LocalizacaoVeiculo> UltimasLocalizacoes();
        IEnumerable<LocalizacaoVeiculo> UltimasLocalizacoes(int IdVeiculo);
    }
}