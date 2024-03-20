using ligeirao.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.interfaces
{
    public interface IRepositoryVeiculo : IRepositoryBase<Veiculo>
    {
        bool ExisteVeiculo(int idVeiculo);
    }
}