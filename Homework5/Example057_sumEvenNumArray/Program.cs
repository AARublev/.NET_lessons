// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на НЕчётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("size array: ");
int sizer = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("enter any range for the array");
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

int SumEvenNumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
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

if (sizer <= 0 || numberBefore <= numberFrom)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("the array must be greater than 0 or should the range increase");
    Console.ForegroundColor = tmp;
}

else
{
    int[] massiv = CreateArrayRndInt(sizer, numberFrom, numberBefore);
    int resultat = SumEvenNumArray(massiv);
    PrintArray(massiv);

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($" --> {resultat}");
    Console.ForegroundColor = tmp;
}