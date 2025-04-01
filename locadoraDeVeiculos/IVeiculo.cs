using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoraDeVeiculos
{
    public interface IVeiculo
    {
    
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public double valorBase {get; set; }
        double CalcularAluguel(int dias);
    }
}
