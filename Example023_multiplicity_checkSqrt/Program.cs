// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Sqrt(int number1, int number2)
{
    if (number1 * number1 == number2 || number1 == number2 * number2)
        Console.WriteLine($"{number1}, {number2} -> да");
    else Console.WriteLine($"{number1}, {number2} -> нет");
}
Sqrt(num1, num2);

