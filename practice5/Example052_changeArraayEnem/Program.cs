// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ChangeArraayEnem(int[] array)    //масив позволяет вернуть 2 эл-та
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;
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

int[] arr = CreateArrayRndInt(4, -10, 10);
PrintArray(arr);

int[] newArr = ChangeArraayEnem(arr);
PrintArray(newArr);

