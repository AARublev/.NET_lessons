// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Write("Введите число элементов массива: ");
int number = int.Parse(Console.ReadLine());
if (number == 0)
{
    Console.WriteLine("Вы ввели недопустимое значение");
    return;
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random(); //для создания псевдослучайных чисел без привязки к системному времени
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}
int[] result = GetArray(number);

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.WriteLine($"{array[array.Length - 1]}]");
   
}

PrintArray(result);