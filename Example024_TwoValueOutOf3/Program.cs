// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


int number = 0;

while (number<100 || number>999)    //пока пользователь не введет 3-х значное
{
    Console.Write("Enter 3 digit number: ");
    number = Convert.ToInt32(Console.ReadLine());
}

int Average(int num)    //метод ради метода
{
    num = (num % 100)/10;
    return num;
}

Console.WriteLine($"Average number: {Average(number)}");