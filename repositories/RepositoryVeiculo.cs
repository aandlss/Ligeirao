using ligeirao.interfaces;
using ligeirao.models;
using ligeirao.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.repositories
{
    public class RepositoryVeiculo : RepositoryBase<Veiculo>, IRepositoryVeiculo
    {
        public RepositoryVeiculo(bool SaveChanges = true) : base(SaveChanges)
        {
        }
        public bool ExisteVeiculo(int idVeiculo)
        {
            var veiculo = new ServiceVeiculo().Repository.GetById(idVeiculo);
            return veiculo != null ? true : false;
        }
    }
}