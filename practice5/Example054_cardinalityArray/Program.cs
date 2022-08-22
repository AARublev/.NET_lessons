// Задайте одномерный массив из 123 случайных чисел
// Найдите количество элеменотов массива, значения которых лежат в отрезке [10,99]

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);     //метод rnd + метод целых чисел Next()
    }
    return array;
}

int LotSegmArray(int[] array)
{
    int lot = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99) lot++;

    }
    return lot;
}

int[] CardinalityArray(int[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++) // для определения памяти под массив
    {
        if (array[i] >= 10 && array[i] <= 99) size++;
    }

    int count = 0;
    int[] newArray = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}

void PrintArray(int[] array)
{

    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine($"{array[^1]}]"); //^1 первый с конца
}

Console.Clear();
int[] massiv = CreateArrayRndInt(123, -100, 100);
int result = LotSegmArray(massiv);
int[] a = CardinalityArray(massiv);

Console.Write("В массиве: ");
PrintArray(a);
Console.WriteLine($"количество элементов лежащих  в отрезке [10,99] = {result};");