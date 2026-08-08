using Exercicio3;

Funcionario funcionario1 = new Funcionario();



Console.WriteLine("Digite o nome, salario bruto e imposto do funcionario: ");
funcionario1.Nome = Console.ReadLine();
funcionario1.SalarioBruto = double.Parse(Console.ReadLine());
funcionario1.Imposto = double.Parse(Console.ReadLine());

Console.WriteLine("Funcionario: " + funcionario1.Nome + ", $ " + funcionario1.SalarioLiquido().ToString("F3"));
Console.WriteLine();

Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
double porcent = double.Parse(Console.ReadLine());
funcionario1.AumentarSalario(porcent);

Console.WriteLine();
Console.WriteLine("DADOS ATUALIZADOS: " + funcionario1.Nome + ", $ " + funcionario1.SalarioBruto.ToString("F3"));


