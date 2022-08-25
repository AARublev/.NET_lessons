// Array.revers(arr); - встроенная функция реверса масива

Console.Write("Enter size array: ");
int sizers = int.Parse(Console.ReadLine());

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

int[] ReversArrayToInt(int[] array)
{
    int indexFirst = 0;
    int indexLast = 1;
    int temp = 0;

    while (array[indexFirst] < array[^indexLast])
    {
        temp = array[indexFirst];
        array[indexFirst] = array[^indexLast];
        array[indexLast] = temp;
        indexFirst++;
        indexLast++;
    }

    // int size = array.Length;
    // for (int i = 0; i < size/2; i++)
    // {
    //     temp = array[i];
    //     array[i] = array[size - 1 - i];
    //     array[size - 1 - i] = temp;
    // }
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

int[] result = CreateArrayRndInt(sizers, 0, 10);
PrintArray(result);
Console.WriteLine();
int[] result2 = ReversArrayToInt(result);
PrintArray(result2);