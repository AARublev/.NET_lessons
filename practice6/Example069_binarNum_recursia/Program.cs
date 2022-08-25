// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное

Console.Write("Number for conversion: ");
int number = Convert.ToInt32(Console.ReadLine());

void DecToBin(int num)
{
    if (num == 0) return; //вышли из метода
    DecToBin(num / 2); // например для числа 13, работает стек: 13, 6, 3, 1
    Console.Write(num % 2); //теперь берет значения из стека: 1%2=1  3%2=1  6%2=0  13%2=1
}

DecToBin(number);
Console.WriteLine();
