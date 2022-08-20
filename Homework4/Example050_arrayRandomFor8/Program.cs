// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Set the range for the Random number generator");

Console.Write("From: ");
int numberFrom = int.Parse(Console.ReadLine()); //int.Parse преобразует строку (string) в int
                                                //Convert.ToInt32 преобразует в int значение любого типа, из перечисленных здесь. boolean, double, float и т.д. 
Console.Write("Before: ");
int numberBefore = int.Parse(Console.ReadLine());

int[] RandonArray(int from, int before)
{
    int[] array = new int[8]; //создали длину массива
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(from, before + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]} --> [");
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}]");
    }

    Console.WriteLine();
}

int[] result = RandonArray(numberFrom, numberBefore);
PrintArray(result);