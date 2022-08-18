// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int FactorNum(int num)
{
    int fact = 1;
    for (int i = 1; i <= num; i++)
    {
        fact *= i;
    }
    return fact;
}

int result = FactorNum(number);
Console.WriteLine($"Factorial of a number ({number})! = {result}");