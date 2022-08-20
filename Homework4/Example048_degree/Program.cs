// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Также работает с отрицательными основаниями. Результат зависит от четности степени: -2^2=4, -2^3=-8
// Частный случай 4334^0=1
// Чтобы не выводить ошибку, если покозатель степени не натуральноечисло я создал метод для 
// отрицательных степеней с отрицательным покозвтелем: 5^(-3)=0,008

Console.Write("Enter the basis for the degree: ");
int footing = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the exponent: ");
int exponent = Convert.ToInt32(Console.ReadLine());

int Degree(int foot, int exp)
{
    int comp = 1;
    for (int i = 1; i <= exp; i++)
    {
        comp *= foot;
    }
    return comp;
}

void DegreeMinus(int foot, int exp)
{
    double comp = 1;
    exp = exp * (-1);
    for (int i = 1; i <= exp; i++)
    {
        comp *= (double)foot;
    }
    comp = 1 / comp;
    Console.WriteLine($"{footing}^({exponent}) = {comp}");
}

if (exponent >= 0)
{
    int result = Degree(footing, exponent);
    Console.WriteLine($"{footing}^({exponent}) = {result}");
}
else DegreeMinus(footing, exponent);

