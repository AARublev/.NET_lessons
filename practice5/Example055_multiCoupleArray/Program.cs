// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [67  3 6] -> 36 21

Console.Clear();

int[] CreateArrayRndInt(int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[rnd.Next(4, 7)];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }

    return array;
}

int[] NewArray(int[] array)
{
    int size = array.Length / 2;    //размер для четного
    if (array.Length % 2 != 0) size++; //размер для нечетного
    int[] result = new int[size];   //новый массив
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
    }

    if (array.Length % 2 != 0) result[size - 1] = array[array.Length / 2]; //положили в последнее значение нового массива положили среднее число пред. массива

    return result;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int[] arr = CreateArrayRndInt(1, 9);

int[] newarray = NewArray(arr);

PrintArray(arr);
Console.Write("->");
PrintArray(newarray);
Console.WriteLine();