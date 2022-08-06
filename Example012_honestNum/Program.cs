Console.WriteLine("Definition the number is even");
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%2 == 0)
{
    Console.WriteLine("Yes, this number is even");
}
else
    Console.WriteLine("No, this number is not even");