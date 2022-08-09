// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Enter number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Multiplicity(int number1, int number2) //pseudo bool
{
    int boo = -1;
    int nov = number1 % number2;
    if (nov==0) boo = 1;
    else boo = 0;
    return boo;
}

int remains = num1%num2;
if (Multiplicity(num1,num2) == 0) Console.WriteLine($"{num1},{num2} -> не кратно, остаток {remains}");
else Console.WriteLine($"{num1},{num2} -> кратно");