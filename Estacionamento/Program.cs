using DIO.models;

Estacionamento estacionamento = new Estacionamento();

bool exec = true;

Console.WriteLine("--Bem vindo ao Estacionamento Araujo--");

Console.WriteLine("Digite o preço inicial:");
string entrada = Console.ReadLine() ?? string.Empty; // Operador de coalescência para tratar campos de entrada vazios, o mesmo retorna um valor nulo.
// Converte a string para um double.
double numeroEntrada;
bool conversaoEntrada = double.TryParse(entrada, out numeroEntrada);

Console.WriteLine("Agora digite o preço por hora:");
string hora = Console.ReadLine() ?? string.Empty;
// Converte a string para um double.
double precoHora;
bool conversaohora = double.TryParse(hora, out precoHora);

while(exec)
{
    string carro;

    Console.WriteLine("Digite a sua opção:  \n" +
                    "1 -- Cadastrar veículo \n" +
                    "2 -- Remover veículo   \n" +
                    "3 -- Listar veículo    \n" +
                    "4 -- Encerrar");

    // Obter opção do usuário.
    int opcao;
        if (!int.TryParse(Console.ReadLine(), out opcao))
        {
            Console.WriteLine("Entrada inválida. Tente novamente.");
            continue; // Recomeça o loop se a entrada for inválida.
        }

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite a placa do veículo para estacionar");
            carro = Console.ReadLine() ?? string.Empty;
            estacionamento.addCarro(carro);
            break;

        case 2:
            Console.WriteLine("Digite a placa do veículo para retirar");
            carro = Console.ReadLine() ?? string.Empty;
            estacionamento.RemoveCarro(carro);
            
            Console.WriteLine("Agora digite o preço por hora:");
            string horas = Console.ReadLine() ?? string.Empty;
            // Converte a string para um inteiro.
            int tempoHora;
            bool conversaotempo = int.TryParse(horas, out tempoHora);
            Console.WriteLine($"O veículo {carro} foi removido e o preço total foi de: R${estacionamento.CustoFinal(numeroEntrada, precoHora, tempoHora)}");
            break;

        case 3:
            Console.WriteLine("Lista de Carro");
            estacionamento.ImprimirCarros();
            break;

        case 4:
            exec = false;
            Console.WriteLine("Programa Encerrado");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}