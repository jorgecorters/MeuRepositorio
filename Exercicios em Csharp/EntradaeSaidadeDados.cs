
using System.Globalization;

string nome;
int quartos;
double preco;


Console.WriteLine("Entre com seu nome completo: ");
nome = Console.ReadLine();
Console.WriteLine("Quantos quartos tem na sua casa? ");
quartos = int.Parse(Console.ReadLine());
Console.WriteLine("Entre com o preco do produto: ");
preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Entre com seu ultimo nome, idade e altura(mesma linha)");

string[] vet = Console.ReadLine().Split(' ');
string nome2 = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2]);

Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(preco.ToString("F2"), CultureInfo.InvariantCulture);
Console.WriteLine(nome2);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2"), CultureInfo.InvariantCulture);





