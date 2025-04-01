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
        public decimal valorBase {get; set; }
        public decimal CalcularAluguel(int dias);
    }
}
