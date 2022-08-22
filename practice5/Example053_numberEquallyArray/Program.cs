// Задайте массив. напишите программу, которая определяет, 
// присутсввует ли заданное число в массиве.
// 4; массив [6,7,19, 345,3] -> нет;
// 3; массив [6,7,19,345,3] -> да;

Console.Write("Ведите число: ");
int number = int.Parse(Console.ReadLine());

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

bool NumberEquallyArray(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) return true;
    }
    return false;
}

void PrintArray(int[] arr)
{

    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write($"{arr[^1]}]"); //^1 первый с конца
}

int[] arr = CreateArrayRndInt(5, 0, 10);
PrintArray(arr);
string answer = NumberEquallyArray(number, arr) ? "Да" : "Нет";
Console.WriteLine($" --> {answer}");

