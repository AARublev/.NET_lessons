// Постановка задачи
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int TherdNuber(int num)
{
    if (num <= 0) num = -1;  // Чтобы избежать случая 3-х значных отрицательных чисел
    else if (num >= 1 && num < 100) num = -2;

    else
    {
        while (num >= 1000)
        {
            num = num / 10;
        }
        num = num % 10;
    }
    return num;
}

int result = TherdNuber(number);
if (result == -2) Console.WriteLine($"{number} -> There is no third digit");
else if (result == -1) Console.WriteLine($"{number} -> Enter a natural 3-digit number");
else Console.WriteLine($"{number} -> {result}");


