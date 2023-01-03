using System;
namespace DesafioFundamentos.Models
{
    public class Parking
    {
        private decimal initialPrice = 0;
        private decimal pricePerHour = 0;
        private List<string> veículos = new List<string>();

        public Parking (decimal _initialPrice, decimal _pricePerHour)
        {
            this.initialPrice = _initialPrice;
            this.pricePerHour = _pricePerHour;
        }

        public void AdicionarVeiculo()
        {
    
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veículos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            string placa = Console.ReadLine();

            if (veículos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                decimal horas = 0;
                decimal valorTotal = 0; 
                horas = Convert.ToDecimal(Console.ReadLine());
                valorTotal = (initialPrice) + pricePerHour * horas;

                veículos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeículos()
        {
            if (veículos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                foreach(string item in veículos)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}