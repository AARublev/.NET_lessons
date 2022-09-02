// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите первое положительное число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите последнее положительное число: ");
int endtNumber = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int firstNum, int endNum)
{
    Console.Write($"{firstNum} ");
    if (firstNum == endNum) return;
    {
        if (firstNum > endNum) NaturalNumber(firstNum - 1, endNum);
        else NaturalNumber(firstNum+1, endNum);
    }
}

NaturalNumber(firstNumber, endtNumber);