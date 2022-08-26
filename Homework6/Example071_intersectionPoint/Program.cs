// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//2 прямые могут:
//быть паралельны
//совподать
//пересекаться в единственной точке - для этой программы исключающее исловие для первых 2-х случаев

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
    double x = 0;
    double y1 = 0;
    double y2 = 0;

    x = (bb2 - bb1) / (kk1 - kk2);
    y1 = kk1 * x + bb1;
    y2 = kk2 * x + bb2;

    //коэффициенты для проверки совпадения прямых
    // double l1 = bb2 / bb1;
    // double l2 = kk2 / kk1; 
    //double l3 = y2 / y1; //необязательно

    if (bb1==bb2 && kk1==kk2) Console.WriteLine("straight lines match");
    if (kk1==kk2 && bb2!=bb1) Console.WriteLine("parallel lines");
    else Console.WriteLine($"({y1}; {y2})");
}

IntersectionPoint(b1, k1, b2, k2);
