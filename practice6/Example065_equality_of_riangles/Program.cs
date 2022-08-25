// Напишите программу, которая принимает на вход три 
// числа и проверяет, может ли существовать 
// треугольник с сторонами такой длины

Console.Write("Введите сторону треугольника a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону треугольника b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите сторону треугольника c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool TrianInequa(int ax, int bx, int cx)
{
    if (ax < bx + cx && bx < ax + cx && cx < ax + bx) return true;
    else return false;
}

if (TrianInequa(a, b, c) == true) Console.WriteLine("да, треугольник существует");
else Console.WriteLine("Нет, треугольник не существует");
