// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Enter b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

void IntersectionPoint(double bb1, double kk1, double bb2, double kk2)
{
    double x = Math.Round(((bb2 - bb1) / (kk1 - kk2)),1); //Math.Round - т.к. на одном примере(3,2,4,5) очень много цифр вылездл после запятой
    double y = Math.Round((kk2 * x + bb2),1);

    if (bb1==bb2 && kk1==kk2) Console.WriteLine("straight lines match");
    else if (kk1==kk2 && bb2!=bb1) Console.WriteLine("parallel lines");
    else Console.WriteLine($"({x}; {y})");
}

IntersectionPoint(b1, k1, b2, k2);
