using System;

Console.Write("Adivinhe o número: ");
var number = int.Parse(Console.ReadLine()!);

Random numberAleatorio = new();

int num = numberAleatorio.Next(1, 20);

while (number != num)
{
    if (number > num)
    {
        Console.WriteLine($"\nO {number} é maior que o número aleatório, tente novamente!");
            return;
    }
    else if (number > num)
    {
        Console.WriteLine($"O {number} é menor que o número aleatório, tente novamente!");
    }
    else
    {
        Console.WriteLine($"Você acertou! O número aleatório é {num}.");
    }
}



Console.ReadKey();

#region (Outra forma)
//var numberAleatorio = new Randon();
#endregion