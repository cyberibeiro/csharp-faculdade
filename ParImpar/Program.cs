Console.WriteLine("--Par ou Ímpar--");

Console.Write("\nDigite um número inteiro: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine(x % 2 == 0 ? $"O {x} é par." : $"O {x} é ímpar.");

Console.ReadKey();