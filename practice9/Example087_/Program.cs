// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии. 
// A = 3; B = 5 -> 243 (3⁵) A = 2; B = 3 -> 8

Console.Write("Введите основание для степени: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите степень: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int SqrtNum(int numA, int numB)
{
    if (numB == 0) return 1;
    if (numB<0) return -1;
    return numA * SqrtNum(numA, numB - 1);
}

int result = SqrtNum(numberA, numberB);
if (result==-1) Console.WriteLine("Такого метода для вычисления еще нет, попробуйте поздее");
else Console.WriteLine($" {numberA}^{numberB} --> {result}");