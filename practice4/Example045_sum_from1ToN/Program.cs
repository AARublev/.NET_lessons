// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNum(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        count += i;
    }
    return count;
}

int result = SumNum(number);
Console.WriteLine($"The sum of the numbers from 1 to {number} -> {result}");