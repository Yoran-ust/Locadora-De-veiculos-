using locadoraDeVeiculos;
using System;
class Program
{
    static void Main(string[] args)
    {
        List<Veiculo> veiculos = new List<Veiculo>
    {
        
        new Moto("XRE 300", "Honda", 2021, 150),
        new Caminhao("Scania R450", "Scania", 2020, 500),
        new Carro("Civic", "Honda", 2023, 320)
    };
        while (true)
        {
            Console.WriteLine("\n============== LOCADORA J.R =========== ");
            Console.WriteLine("1 - Exebir veiculos veículos");
            Console.WriteLine("2 -Calcular aluguel");
            Console.WriteLine("0 - Sair");
            Console.Write("\n escolhar:");
            string op = Console.ReadLine();

            if (op == "1") 
            {
                for (int i = 0; i < veiculos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {veiculos[i].Modelo} - {veiculos[i].Marca} - R${veiculos[i].valorBase}/dia");
                }
            } 
            else if (op == "2")
            {
                Console.Write("Número do veículo: ");
                int indice = int.Parse(Console.ReadLine()) - 1;

                Console.Write("Dias de aluguel: ");
                int dias = int.Parse(Console.ReadLine());

                decimal total = veiculos[indice].CalcularAluguel(dias);
                Console.WriteLine($"Total a pagar: R${total:F2}");
            }
            else if (op == "0")
            {
                break;
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}