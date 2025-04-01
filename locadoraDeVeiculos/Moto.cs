using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoraDeVeiculos
{
    public class Moto : Veiculo, IVeiculo
    {
        public override decimal CalcularAluguel(int dias)
        {
            decimal persentualDesconto = 0.9m;
            return base.CalcularAluguel(dias) * persentualDesconto;
        }
        public Moto(string modelo, string marca, int ano, decimal valorbase) : base (modelo, marca, ano, valorbase)
        {

        }
    }
}
