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
    }
}