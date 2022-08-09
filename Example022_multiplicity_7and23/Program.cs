
Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

void Crat(int number) // num параметр
{
    if (number % 7 == 0 && number % 23 == 0) Console.WriteLine($"{number} -> да");
    else Console.WriteLine($"{number} -> нет");
}

Crat(num); //num аргумент