//11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//456 -> 46 **
//782 -> 72
//918 -> 98

int number = new Random().Next(100, 1000);

int RemoveSecond(int num)
{
    int number1 = num / 100;
    int number2 = num % 10;
    int nov = number1 * 10 + number2;
    return nov;
}

int result = RemoveSecond(number);
Console.WriteLine($"{number} ==> {result}");
