using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace locadoraDeVeiculos
{
    

    public class Veiculo : IVeiculo
    {
        public Veiculo(string modelo, string marca, int ano, decimal valorBase)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            this.valorBase = valorBase;
        }

        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public decimal valorBase {get; set; }

        public virtual decimal CalcularAluguel(int dias)
        {
            return valorBase * dias;
        }
    }


}
