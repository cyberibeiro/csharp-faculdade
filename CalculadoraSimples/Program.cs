Console.WriteLine("--Calculadora Simples--");

Console.Write("Digite o primeiro número inteiro: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número inteiro: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Soma = {n1 + n2}");
Console.WriteLine($"Subtração = {n1 - n2}");
Console.WriteLine($"Multiplicação = {n1 * n2}");
Console.WriteLine($"Divisão = {n1 / n2}");

Console.ReadKey();