using Hotel.Models;

Console.WriteLine("Hospedagem Araujo");

Reserva reserva = new Reserva();

Console.WriteLine("Quantas Pessoas se hospedaram?");
int numero;
bool sucesso = int.TryParse(Console.ReadLine(), out numero);

//Menu simples para escolher a acomodação e input para seleção da acomodação
Console.WriteLine("Em qual acomodação deseja ficar? \n" +
                    "Econômica [1] \n" +
                    "Normal    [2] \n" +
                    "Premium   [3]");

int escolha;
sucesso = int.TryParse(Console.ReadLine(), out escolha);
string quarto = reserva.CadastrarSuite(escolha);


string qtyHospede = reserva.ObterQuantidadeHospides(numero);
//Esse comando para o código caso o seja selecionado uma suite que não comporte a quantidade de hospedes.
if (qtyHospede.Equals("Quantidade de hopedes ultrapassada."))
    {
    Console.WriteLine(qtyHospede);
    Environment.Exit(0); // Encerra o programa com código de saída 1 (erro)
    }

//Entrada do ou dos hopedes, são armazenados na lista mas motrados tambem no input
for (int c = 0; c < numero; c++)
{
    Console.WriteLine("Informe seu Nome:");
    string nome = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Informe seu Sobrenome:");
    string sobreNome = Console.ReadLine() ?? string.Empty;

    Pessoa pessoa = new Pessoa
        {
            Nome = nome,
            SobreNome = sobreNome
        };

    reserva.CadastrarHospedes(pessoa);
    Console.WriteLine($"Hospede {pessoa.Nome} {pessoa.SobreNome} cadastrado.");
}

//Coleta a quantidade de dias, para ter o retorno do calculo do custo total.
Console.WriteLine("Quantos dias ficará hospedado?");
int estadia;
sucesso = int.TryParse(Console.ReadLine(), out estadia);
decimal valorF = reserva.CalcularValorDiaria(estadia);

//Saída resumindo a operação de hopedagem.
Console.WriteLine($"Hospedagem realizada na suite {quarto}, seram {numero} hospede(s) e o valor da sua estadia será de R$ {valorF} para {estadia} dias.");