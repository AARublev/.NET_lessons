// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Программа работает с целыми числами: в методе исключаются неподъодящие числа

Console.Write("Enter number N (from): ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number M (before): ");
int numberM = Convert.ToInt32(Console.ReadLine());


int SequenceIntervar(int firstNum, int endNum)
{
    if (firstNum == endNum) return firstNum;
    else
    {
        if (firstNum <= 0 || endNum <= 0)
        {
            if (firstNum > endNum) return SequenceIntervar(firstNum, endNum + 1); // 4 3 2 1 0 -1
            else return SequenceIntervar(firstNum + 1, endNum);     // -1 0 1 2 3 4 
        }
        else
        {
            if (firstNum > endNum) return firstNum = firstNum + SequenceIntervar(firstNum - 1, endNum);
            else return firstNum = firstNum + SequenceIntervar(firstNum + 1, endNum);  // 1 2 3 4 5
        }
    }
}

if (numberM <= 0 && numberN <= 0) Console.WriteLine("At least 1 number must be natural");
else
{
    int resultat = SequenceIntervar(numberN, numberM);
    Console.WriteLine(resultat);
}