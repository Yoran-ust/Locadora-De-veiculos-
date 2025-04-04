using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoraDeVeiculos
{
    public class Caminhao : Veiculo, IVeiculo
    {
        public Caminhao(string modelo, string marca, int ano, decimal valorBase)
           : base(modelo, marca, ano, valorBase) { }
        
        public override decimal CalcularAluguel(int dias)
        {
            return base.CalcularAluguel(dias) * 1.2m;
        }
    }
}
