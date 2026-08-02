using ExerciciosPropostos;

Produto p = new Produto();

Console.WriteLine("Entre os dados do produto: ");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preco: ");
p.Preco = double.Parse(Console.ReadLine());
Console.Write("Quantidade: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados do produto: " + p);
Console.WriteLine("Digite o numero de produtos a ser armaezenados no estoque: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine("Dados atualizados: " + p);
Console.WriteLine("Digite o numero de produtos a serem removidos do estoque: ");
int qtd = int.Parse(Console.ReadLine());
p.RemoverProdutos(qtd);
Console.WriteLine("Dados atualizados: " + p);