namespace DesafioFundamentos.Models
{
    // Define a classe Estacionamento no namespace DesafioFundamentos.Models
    public class Estacionamento
    {
        // Variável onde ficam os preços e listas de veículos
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        // Método que recebe os preços iniciais como parâmetros
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            // Método que adiciona os preços iniciais às variáveis
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        // Método para adicionar um veículo à lista
        public void AdicionarVeiculo()
        {
            // Foi onde implementei Console.ReadLine para receber a entrada dos dados do usuário
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            // E aqui adicionei a variável veiculos.Add(placa) para adicionar a placa à lista de veículos
            veiculos.Add(placa);

            // Exibe mensagem de conclusão caso adicionado corretamente
            Console.WriteLine($"Veículo {placa} adicionado com sucesso.");
        }

        // Método para remover um veículo da lista
        public void RemoverVeiculo()
        {
                // Solicita ao usuário a placa do veículo que irá ser removida
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            /* Verifica se a placa está na lista. Aqui adicionei "veiculos.Any(x => x.ToUpper() == 
            placa.ToUpper())" para verificar a existência do veículo */
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                // Se a placa estiver na lista, solicita o tempo que o veículo permaneceu no local
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());

                // Calcula o total com base no tempo e preços informados
                decimal valorTotal = precoInicial + precoPorHora * horas;

                /* Remove o veículo da lista. Aqui eu adicionei veiculos.Remove(placa)
                para removê-lo da lista após o cálculo do valor total. */
                veiculos.Remove(placa);

                // Exibe uma mensagem com o preço total e confirma a remoção do veículo
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                // Se a placa não estiver na lista, exibe uma mensagem de erro
                Console.WriteLine("Desculpe, veículo não encontrado. Verifique se digitou a placa corretamente");
            }
        }

        // Método para listar os veículos estacionados
        public void ListarVeiculos()
        {
            // Verifica se há veículos na lista
            if (veiculos.Any())
            {
                // Se houver veículos, exibe a mensagem e verifica a lista exibindo cada placa
                Console.WriteLine("Os veículos estacionados são:");
                
                /*Aqui implementei um loop foreach para percorrer a lista veiculos e exibir cada placa,
                usando Console.WriteLine para mostrar as informações no console.*/
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                // Se não houver veículo estacionado, exibe uma mensagem informando que não há veículo no momento
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
