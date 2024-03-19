using ligeirao.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.services
{
    public class ServiceLocalizacaoVeiculo
    {
        public RepositoryLocalizacaoVeiculo Repository { get; set; }

        public ServiceLocalizacaoVeiculo()
        {
            Repository = new();
        }
    }
}