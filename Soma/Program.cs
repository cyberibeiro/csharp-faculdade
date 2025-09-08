Console.WriteLine("--Soma--");

Console.Write("\nDigite um número: ");
int N = int.Parse(Console.ReadLine());

int soma = 0;

Console.WriteLine();

for (int i = 1; i <= N; i++)
{
    soma += i;
}

Console.WriteLine($"A soma de 1 até {N} é: {soma}");

Console.ReadKey();