Console.WriteLine("--Inversão de String--");

Console.Write("\nDigite uma palavra: ");
string palavra = Console.ReadLine();

string palavraInvertida = "";

for (int i = palavra.Length - 1; i >= 0; i--)
{
    palavraInvertida += palavra[i];
}

Console.WriteLine($"Palavra invertida: {palavraInvertida}");