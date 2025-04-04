using locadoraDeVeiculos;
using System;
class Program
{
    static void Main(string[] args)
    {
        List<Veiculo> veiculos = new List<Veiculo>
        {
            new Carro("Corolla", "Toyota", 2022, 300m),
            new Moto("XRE 300", "Honda", 2021, 150m),
            new Caminhao("Scania R450", "Scania", 2020, 500m)
        };
        int dias = 5;
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine($"Veículo: {veiculo.Modelo} | Marca: {veiculo.Marca} | Ano: {veiculo.Ano} | Custo por {dias} dias: R$ {veiculo.CalcularAluguel(dias):F2}");
        }
            
    }
}