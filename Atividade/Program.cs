// See https://aka.ms/new-console-template for more information

//Qual foi o maior número digitado (independentemente se é par ou ímpar).
//Qual foi o menor número digitado (idependentemente se é par ou ímpar).
//Exibir todos os elementos da lista de números pares
//Exibir todoso os elementos da lista de número impares.

int numeroInserido = 0;
int maiorNumeroDigitado = 0;
int menorNumeroInserido = 0;
bool primeiroNumero = true;

List<int> Pares = new List<int>();
List<int> Impares = new List<int>();

do
{
    Console.Write("Insira um número inteiro: ");
    if (!int.TryParse(Console.ReadLine(), out numeroInserido))
    {
        Console.WriteLine("Número inválido! Tente novamente.");
        continue;
    }

    if (primeiroNumero)
    {
        maiorNumeroDigitado = numeroInserido;
        menorNumeroInserido = numeroInserido;
        primeiroNumero = false;
    }
    else
    {
        if (numeroInserido > maiorNumeroDigitado)
            maiorNumeroDigitado = numeroInserido;

        if (numeroInserido < menorNumeroInserido)
            menorNumeroInserido = numeroInserido;
    }

    if (numeroInserido % 2 == 0)
        Pares.Add(numeroInserido);
    else
        Impares.Add(numeroInserido);

    Console.Write("Digite ENTER para continuar: ");
    Console.Clear();

} while (numeroInserido != 100);

Console.WriteLine($"O maior número é {maiorNumeroDigitado}.");
Console.WriteLine($"O menor número é {menorNumeroInserido}.");

Console.Write("\nLista de Pares: ");
foreach (int numberPar in Pares)
{
    Console.Write(numberPar);
    Console.Write(" ");
}

Console.Write("\nLista de Impares: ");
foreach (int numberImpar in Impares)
{
    Console.Write(numberImpar);
    Console.Write(" ");
}

Console.WriteLine("\n\nDigite ENTER para encerrar: ");
Console.ReadKey();
