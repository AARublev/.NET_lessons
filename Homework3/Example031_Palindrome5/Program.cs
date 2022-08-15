// Задача 19 (постановка задания)
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int number = 0;
while (number<10000 || number>99999)
{
Console.Write("Enter 5-digit number: ");
number = Convert.ToInt32(Console.ReadLine());
}

bool Poly(int num)
{
    int num1=num%100; //23432 -> 32
    int num2=num/1000; //23432 -> 23
    num2 = (num2%10)*10+num2/10; //23 -> 32
    return num1==num2; //true
}
if (Poly(number)) Console.WriteLine($"This {number} is a polyndrome number");
else Console.WriteLine($"This {number} is not polyndrome number");
