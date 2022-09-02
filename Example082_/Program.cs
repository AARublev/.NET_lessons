// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.Write("Введите положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void NaturalNumber(int num)
// {
//     if (num == 0) return;  //обязательно условие выхода
//     NaturalNumber(num - 1);
//     Console.Write($"{num} ");    //$ - интерполяция
// }

// NaturalNumber(number);


// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.Write("Введите первое положительное число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите последнее положительное число: ");
// int endtNumber = Convert.ToInt32(Console.ReadLine());


// void NaturalNumber(int firstNum, int endNum)
// {
//     if (endNum > firstNum)
//     {
//         if (endNum == firstNum - 1) return;
//         NaturalNumber(firstNum, endNum - 1);
//         Console.Write($"{endNum} ");
//     }
//     else
//     {
//         if (endNum == firstNum - 1) return;
//         NaturalNumber(firstNum+1, endNum);
//         Console.Write($"{firstNum} ");
//     }
// }

// NaturalNumber(firstNumber, endtNumber);


// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9


// Console.Write("Введите первое положительное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int RecNum(int num)
// {
// int sum=num%10;
// if(num>0)
// {
// sum+=RecNum(num/10);  //12345
// }
// return sum;
// }

// int result = RecNum(number);
// Console.WriteLine(result);



// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и 
// возводит число А в целую степень B с помощью рекурсии. 
// A = 3; B = 5 -> 243 (3⁵) A = 2; B = 3 -> 8

Console.Write("Введите первое положительное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите первое положительное число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int SqrtNum(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * SqrtNum(numA, numB - 1);
    //numA = numA * SqrtNum(numA, numB - 1);

    //return numA;
}

int result = SqrtNum(numberA, numberB);
Console.WriteLine($" {numberA}^{numberB} --> {result}");