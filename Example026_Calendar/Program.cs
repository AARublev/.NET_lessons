Console.Write("Enter number of the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

bool Calend(int num)
{
    return num==6 || num==7; //rtue
}

if (Calend(number)) Console.WriteLine("Yes");
else Console.WriteLine("No");