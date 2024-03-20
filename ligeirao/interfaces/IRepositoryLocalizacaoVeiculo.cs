using ligeirao.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.interfaces
{
    public interface IRepositoryLocalizacaoVeiculo : IRepositoryBase<LocalizacaoVeiculo>
    {
        List<LocalizacaoVeiculo> UltimasLocalizacoes();
        List<LocalizacaoVeiculo> UltimasLocalizacoes(int IdVeiculo);
    }
}