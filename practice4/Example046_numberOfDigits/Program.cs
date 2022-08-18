// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int NumDigit(int num)
{
int sum = 0;
if (num==0) return 1;
else for (int i = 1; num > 0; i++)
{
    num=num/10;
    sum=i;
}
return sum;
}

int result = NumDigit(number);
Console.WriteLine($"number of digits {number} ==> {result}");