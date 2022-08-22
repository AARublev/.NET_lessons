// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

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

int[] GetSumPosElem(int[] array)    //масив позволяет вернуть 2 эл-та
{
    int sumNeg = 0;
    int sumPos = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNeg += array[i];
        else sumPos += array[i];
    }

    // int[] arr = {1,2,3,4,5} // оператор new не нежен т.к. массив заполняем в ручную и памяять соотв. выделяется под заполненное кол-во эл-ов

    // int[] arr = new int[2];
    // arr[0]=sumNeg;
    // arr[1]=sumPos;
    // return arr;

    return new int[] { sumNeg, sumPos }; //сокращенная запись
}

void PrintArray(int[] array)
{
    Console.Clear();
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine($"{array[^1]}]"); //^1 первый с конца
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);    //вывод для проверки метода

int[] sumPosElem = GetSumPosElem(arr);
Console.WriteLine($"Сумма отрицательных чисел: {sumPosElem[0]}");
Console.WriteLine($"Сумма положительных чисел: {sumPosElem[1]}");