// Importa a classe Estacionamento do namespace DesafioFundamentos.Models
using DesafioFundamentos.Models;

// Configura a codificação de saída para UTF-8 para exibir caracteres especiais
Console.OutputEncoding = System.Text.Encoding.UTF8;

// Declaração de variáveis para adicionar preços do estacionamento
decimal precoInicial = 0;
decimal precoPorHora = 0;

// Exibe uma mensagem de boas-vindas e solicita o preço inicial ao usuário
Console.WriteLine("Seja bem-vindo ao Estacionamento Central Park!\n" +
                  "Digite o preço de entrada:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

// Solicita o preço por hora
Console.WriteLine("Agora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, passando os valores obtidos do usuário
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

// Início das variáveis para controlar o menu de opções
string opcao = string.Empty;
bool exibirMenu = true;

// Loop principal do menu
while (exibirMenu)
{
    // Limpa a tela do usuário e exibe as opções do menu
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    // Obtém a escolha do usuário e executa a ação correspondente usando switch
    switch (Console.ReadLine())
    {
        case "1":
            // Chama o método AdicionarVeiculo da instância da classe Estacionamento
            es.AdicionarVeiculo();
            break;

        case "2":
            // Chama o método RemoverVeiculo da instância da classe Estacionamento
            es.RemoverVeiculo();
            break;

        case "3":
            // Chama o método ListarVeiculos da instância da classe Estacionamento
            es.ListarVeiculos();
            break;

        case "4":
            // Encerra o loop do menu definindo exibirMenu como falso
            exibirMenu = false;
            break;

        default:
            // Mensagem de "opção inválida" caso usuário insira algo fora do esperado
            Console.WriteLine("Opção inválida. Digite uma nova opção");
            break;
    }

    // Aguarda que o usuário pressione uma tecla para continuar
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

// Mensagem final de agradecimento ao usuário
Console.WriteLine("Obrigado por usar nossos serviços. Volte sempre!");
