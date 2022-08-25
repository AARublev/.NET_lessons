// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования

Console.Write("введите число N: ");
int sizers = Convert.ToInt32(Console.ReadLine());

while (sizers <= 0)
{
    Console.Write("Введите положительное число больше 0: ");
    sizers = Convert.ToInt32(Console.ReadLine());
}

//new int[]{} - пустой массив

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

int[] CopyArray(int[] array, int size)
{
    int[] copyArray = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[^1]}]");
    Console.WriteLine();
}

int[] arrold = CreateArrayRndInt(sizers, 0, 10);
PrintArray(arrold);
Console.WriteLine("print cope array:");
int[] result = CopyArray(arrold, sizers);
PrintArray(result);
