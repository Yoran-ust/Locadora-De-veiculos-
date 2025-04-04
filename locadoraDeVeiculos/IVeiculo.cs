using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoraDeVeiculos
{
    public interface IVeiculo
    {
        public decimal CalcularAluguel(int dias);
    }
}
