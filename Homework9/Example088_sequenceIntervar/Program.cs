// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Enter number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

void SequenceIntervar(int n)
{
    if(n>1) Console.Write($"{n}, ");
    else Console.WriteLine(n);

    if (n == 1) return;
    if (n > 1) SequenceIntervar(n - 1);
}


if (numberN > 0) 
{
Console.Write($"N = {numberN} --> ");
SequenceIntervar(numberN);
}
else Console.WriteLine("Enter a natural number");
