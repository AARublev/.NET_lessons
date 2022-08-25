// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Enter any number of digits. Enter 606 to stop");

int number;
int[] startArray = new int[] { };

while (true)
{
    Console.Write("Enter number: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == 606) break;
    else startArray = startArray.Concat(new int[] { number }).ToArray(); //ToArray() - копирует элементы в новый массив
}                                                                        //Concat - метод объеденмет элементы массива

int ScorePositiveNumArray(int[] array)
{
    int sum=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0) sum++;
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[^1]}");
}

int resul = ScorePositiveNumArray(startArray);

PrintArray(startArray);
Console.WriteLine($" --> {resul}");