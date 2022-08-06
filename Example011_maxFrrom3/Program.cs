Console.Write("Enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2>max)
{
   max = num2;
}
if (num3>max)
{
    max = num3;
}

Console.WriteLine($"Max number: {max}");