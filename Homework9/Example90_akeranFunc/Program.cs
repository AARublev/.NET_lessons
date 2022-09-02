// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Enter number m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number n: ");
int numberN = Convert.ToInt32(Console.ReadLine());


int AkeranFunc(int m, int n)
{
    if (m == 0) return n+1;
    if (m > 0 && n > 0) return AkeranFunc(m - 1, AkeranFunc(m, n - 1));
    else if (m > 0 && n == 0) return AkeranFunc(m - 1, 1);

    return n;
}


if(numberM>=0 && numberN>=0)
{
int result = AkeranFunc(numberM, numberN);
Console.WriteLine($"m = {numberM}, n = {numberN} -> A(m,n) = {result}");
}
else Console.WriteLine("enter a positive integer");