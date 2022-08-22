// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.Write("size array: ");
int sizer = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("enter any range for the array (may be valid)");
Console.Write("from: ");
double numberFrom = double.Parse(Console.ReadLine());
Console.Write("before: ");
double numberBefore = double.Parse(Console.ReadLine());

var tmp = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGray;

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min; //<--
        array[i] = Math.Round(array[i], 1);
    }
    return array;
}

double ModArray(double[] array)
{
    double min = array[0];
    double max = array[0];
    double razn = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    razn = Math.Round((max - min), 1);

    return razn;
}

void PrintArray(double[] array)
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
    double[] massiv = CreateArrayRndDouble(sizer, numberFrom, numberBefore);
    double resultat = ModArray(massiv);
    PrintArray(massiv);

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine($" --> {resultat}");
    Console.ForegroundColor = tmp;
}