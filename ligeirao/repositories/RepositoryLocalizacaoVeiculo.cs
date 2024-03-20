using ligeirao.interfaces;
using ligeirao.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.repositories
{
    public class RepositoryLocalizacaoVeiculo : RepositoryBase<LocalizacaoVeiculo>, IRepositoryLocalizacaoVeiculo   
    {
        public RepositoryLocalizacaoVeiculo(bool SaveChanges = true) : base(SaveChanges)
        {
        }

        public List<LocalizacaoVeiculo> UltimasLocalizacoes ()
        {
            var localizacoes = _context.Set<LocalizacaoVeiculo>().OrderByDescending(lv => lv.Horario).Take(10).ToList();
            return localizacoes;
        }

        public List<LocalizacaoVeiculo> UltimasLocalizacoes(int idVeiculo)
        {
            var localizacoes = _context.Set<LocalizacaoVeiculo>().Where(lv => lv.IdVeiculo == idVeiculo).OrderByDescending(lv => lv.Horario).Take(10).ToList();
            return localizacoes;
        }
    }
}