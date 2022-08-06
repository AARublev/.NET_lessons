Console.Write("Enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1<num2)
{
    Console.WriteLine($"max number: {num2} \nmin number: {num1}");
}
else
    Console.WriteLine($"max number: {num1} \nmin number: {num2}");