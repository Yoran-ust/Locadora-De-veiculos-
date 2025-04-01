using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoraDeVeiculos
{
    public class Carro : Veiculo, IVeiculo
    {

        public Carro(string modelo, string marca, int ano, decimal valorbase) : base(modelo, marca, ano, valorbase)
        {

        }
    }
}
