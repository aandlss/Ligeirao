using ligeirao.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.services
{
    public class ServicePontoReferencia
    {
        public RepositoryPontoReferencia Repository { get; set; }

        public ServicePontoReferencia()
        {
            Repository = new();
        }
    }
}