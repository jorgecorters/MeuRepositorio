using Exercicio2;

Retangulo ret = new Retangulo();

Console.WriteLine("Entre com altura e largura do objeto: ");
ret.Largura = double.Parse(Console.ReadLine());
ret.Altura  = double.Parse(Console.ReadLine());

Console.WriteLine("AREA = " + ret.Area().ToString("F2"));
Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2"));
Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2"));


