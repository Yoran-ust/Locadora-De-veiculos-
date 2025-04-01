using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoraDeVeiculos
{
    public class Caminhao : Veiculo, IVeiculo
    {
        public Caminhao(string modelo, string marca, int ano, double valorBase) : base (modelo, marca, ano, valorBase) { }
    }
}
