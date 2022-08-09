int number = new Random().Next(10,100);
Console.WriteLine($"Случайное число из диапазона (10,99) ==> {number}");

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit == secondDigit) 
{
    Console.WriteLine("Числа равны");
}

else if (firstDigit > secondDigit) 
{
    Console.WriteLine($"Максимальная цифра числа {number} ==> {firstDigit}");
}

else 
{
    Console.WriteLine($"Максимальная цифра числа {number} ==> {secondDigit}"); 
}
