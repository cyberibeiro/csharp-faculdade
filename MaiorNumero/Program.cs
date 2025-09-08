Console.WriteLine("--Maior Número--");

Console.Write("Digite o primeiro número inteiro: ");
int n1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número inteiro: ");
int n2 = int.Parse(Console.ReadLine());

Console.WriteLine(n1 < n2 ? $"O número {n2} é maior." : $"O número {n1} é maior.");

Console.ReadKey();