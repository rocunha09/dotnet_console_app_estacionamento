namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado!!!!!
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            veiculos.Add(Console.ReadLine());
        }

        public void RemoverVeiculo()
        {
            //DONE: Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                int horas = 0;
                decimal valorTotal = 0; 
                // DONE: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // DONE: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                horas = Int32.Parse(Console.ReadLine());
                valorTotal = (precoInicial + (precoPorHora * horas));

                // DONE: Remover a placa digitada da lista de veículos
                for (int i = 0; i < veiculos.Count; i++)
                {
                    if(veiculos[i].ToUpper() == placa.ToUpper())
                    {
                        veiculos.RemoveAt(i);
                        break;
                    }
                }

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // DONE: Realizar um laço de repetição, exibindo os veículos estacionados
                foreach (var veiculo in veiculos)
                    Console.WriteLine($"{veiculo}");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
