// Задача 27: Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Enter a natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigit(int num)
{
    int sum = 0;
    if (num == 0) return 1;
    if (num < 0) num = num * (-1);

    for (int i = 1; num > 0; i++)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}

int result = SumDigit(number);
Console.WriteLine($"The sum of the digits of the number {number} --> {result}");