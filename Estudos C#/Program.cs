using System.Data.Common;
using Estudos_C_.Models;
using Newtonsoft.Json;

// Utilizando Exceptions em C# com try - catch.
/*
try
{
    string [] linhas = File.ReadAllLines ("Arquivos/arquivoLeitura.txt");

    foreach (string line in linhas) 
    {
        Console.WriteLine (line);
    }
} 

catch(FileNotFoundException ex)
{
    Console.WriteLine ($"Ocorreu um erro na leitura do arquivo. {ex.Message}");
}

catch(DirectoryNotFoundException ex)
{
    Console.WriteLine ($"Caminho do arquivo não localizado. {ex.Message}");
}

catch (Exception ex)
{
    Console.WriteLine ($"Ocorreu um exceção genérica. {ex.Message}");
}
//Executa um bloco de código mesmo que o try de certo e principalmente quando não der certo, ele irá processar.
finally
{
    Console.WriteLine ("Chegou até aqui!");
}
*/

//new ExemploExcecao().Metodo1();

//Utilizando Filas
/*Queue<int> fila = new Queue<int>();

fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);
fila.Enqueue(5);

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); // sempre remove o primeiro elemento da fila.

foreach (var item in fila)
{
    Console.WriteLine(item);
}*/

//Utilizando Pilhas - Ordem LIFO - Last in firts out.
/*Stack<int> pilha = new Stack<int>();

pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (var item in pilha)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine($"Removendo elemento do topo da pilha {pilha.Pop()}");

pilha.Push(20);

foreach (var item in pilha)
{
    Console.WriteLine(item.ToString());
}*/

//Utilizando Dictionary.
//Instanciando um dictionary, ele tem sempre dois tipos, elementos unicos com base na chave, sendo o primeiro tipo a chave e o segundo o tipo do valor.
/*Dictionary<string, string> estados = new Dictionary<string, string>(); 
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");*/

//Acessando o valor de uma das chaves
/*Console.WriteLine(estados["SP"]);

foreach (var estad in estados)
{
    Console.WriteLine($"Chave {estad.Key}, valor {estad.Value}");
}

Console.WriteLine("Após remover");
estados.Remove("SP");

foreach (var estad in estados)
{
    Console.WriteLine($"Chave {estad.Key}, valor {estad.Value}");
}

Console.WriteLine("Após fazer uma alteração");

estados["SP"] = "Barueri - valor alterado";

foreach (var estad in estados)
{
    Console.WriteLine($"Chave {estad.Key}, valor {estad.Value}");
}

Console.WriteLine("Avaliando se a chave ja está no Dictionary");

string check = "BA";

if (estados.ContainsKey(check))
{
    Console.WriteLine("A chave está presente.");
}
else
{
    Console.WriteLine("A chave não está presente.");
}*/

//Tuplas na pática, e está primeira forma é a mais recomendada a ser usada.
/*(int, string, string, decimal) tupla = (1, "Fernando", "Araujo", 1.85M);
Console.WriteLine($"id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");

//Outras formas de declarar uma tupla.
ValueTuple<int, string, string, decimal> tupla2 = (1, "Fernando", "Araujo", 1.85M);
var tupla3 = Tuple.Create(1, "Fernando", "Araujo", 1.85M);

LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhas, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

if(sucesso)
{
    Console.WriteLine("Quantidade de linhas do arquivo " + quantidadeLinhas);
    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo.");
}*/

//IF ternário

//int numero = 15;
//bool ehPar = false;

//IF tradicional.
/*if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar");
}*/

//IF Ternário
//ehPar = numero % 2 == 0;
//Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

//Montagem de um Objeto e serialização em um arquivo JSON
/*
DateTime dataAtual = DateTime.Now;

List<Venda> listVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listVendas.Add(v1);
listVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listVendas);

File.WriteAllText("Arquivos/vendas.json", serializado);
*/

//Deserializando um objeto JSON.
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<DesVenda> listaVenda = JsonConvert.DeserializeObject<List<DesVenda>>(conteudoArquivo);

foreach (DesVenda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" +
                $", Preço R${venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy")}");
}