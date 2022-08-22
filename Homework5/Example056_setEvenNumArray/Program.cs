// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("size array: ");
int sizer = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("enter a range of three-digit numbers for the array");
Console.Write("from: ");
int numberFrom = int.Parse(Console.ReadLine());
Console.Write("before: ");
int numberBefore = int.Parse(Console.ReadLine());

var tmp = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGray;

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int SetEvenNumArray(int[] array)
{
    int set = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) set++;
    }
    return set;
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[^1]}]");
}


Console.Clear();
if (sizer <= 0 || numberFrom < 100 || numberFrom >= 1000
               || numberBefore < 100 || numberBefore >= 1000
               || numberBefore <= numberFrom) Console.WriteLine("enter a positive three digit number");
else
{
    int[] massiv = CreateArrayRndInt(sizer, numberFrom, numberBefore);
    int resultat = SetEvenNumArray(massiv);
    PrintArray(massiv);

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($" --> {resultat}");
    Console.ForegroundColor = tmp;
}