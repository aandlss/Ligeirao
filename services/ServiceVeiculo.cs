using ligeirao.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ligeirao.services
{
    public class ServiceVeiculo
    {
        public RepositoryVeiculo Repository { get; set; }
        public ServiceVeiculo()
        {
            Repository = new();
        }

        public bool placaIsValid(string placa)
        {
            if (placa.Length != 7)
            {
                return false;
            }

            //validar se a placa possui caracteres diferentes de números e letras
            for (int i = 0; i < placa.Length; i++)
            {
                if (!char.IsLetterOrDigit(placa[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}