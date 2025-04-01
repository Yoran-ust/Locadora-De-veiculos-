using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoraDeVeiculos
{
    

    public class Veiculo : IVeiculo
    {
        public Veiculo(string modelo, string marca, int ano, double valorBase)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            this.valorBase = valorBase;
        }

        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public double valorBase {get; set; }

        public double CalcularAluguel(int dias)
        {
            return 0;
        }
    }


}
