int func(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

Console.Write("Enter number 1: ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 3: ");
int c1 = Convert.ToInt32(Console.ReadLine());
int a2 = 0;
int b2 = 100;
int c2 = -49;
int a3 = 2;
int b3 = -2;
int c3 = 87;

int sravn = func(func(a1,b1,c1),func(a2,b2,c2), func(a3,b3,c3));
Console.WriteLine(sravn);

