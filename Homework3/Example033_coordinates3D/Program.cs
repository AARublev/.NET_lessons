Console.Write("Enter x for the first point: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y for the first point: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter z for the first point: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Enter x for the second point: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter y for the second point: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter z for the second point: ");
int z2 = Convert.ToInt32(Console.ReadLine());

void Distance(int xx1, int yy1, int zz1, int xx2, int yy2, int zz2)
{
    double cord = Math.Sqrt(Math.Pow(xx2 - xx1, 2) +
                            Math.Pow(yy2 - yy1, 2) +
                            Math.Pow(zz2 - zz1, 2));
    Console.WriteLine(Math.Round(cord,2));
}

Distance(x1, y1, z1, x2, y2, z2);