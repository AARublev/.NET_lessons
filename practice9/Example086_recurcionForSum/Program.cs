// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите первое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int RecNum(int num)
{
int sum=num%10;
if(num>0)
{
sum+=RecNum(num/10);  //12345
}
return sum;
}

int result = RecNum(number);
Console.WriteLine($"{number}  --> {result}");