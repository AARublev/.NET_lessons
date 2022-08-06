Console.WriteLine("a series of even numbers");
Console.WriteLine("enter a natural number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1 - num1 + 1;

if (num1>0)
{
while (num2<=num1)
{
   if (num2 % 2 == 0)
   {
      Console.Write($"{num2} ");
   }
   num2+=1;
}
Console.Write("\n");
}
else
   Console.WriteLine("enter a natural number");
