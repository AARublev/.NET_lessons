Console.Write("Enter a number from 1: ");
int number = Convert.ToInt32(Console.ReadLine());

void CubesNum(int num)
{
Console.Clear();
Console.WriteLine();
for (int i = 1; i <= num; i++)
{
    double cubes=Math.Pow(i,3);
    Console.WriteLine($"  {i} |  {cubes}   ");
    Console.WriteLine("------------");
}
Console.WriteLine();
}

if(number>=1) CubesNum(number);
else Console.WriteLine("Enter a natural number");
