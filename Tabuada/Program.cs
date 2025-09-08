Console.WriteLine("--Tabuada--");

Console.Write("\nDigite o número para ver sua tabuada: ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine();

//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine($"{number} x {i} = {number * i}");
//}

int i = 0;

while (i <= 10)
    {
    Console.WriteLine($"{number} x {i} = {number * i}");
    i++;
    }

Console.ReadKey();