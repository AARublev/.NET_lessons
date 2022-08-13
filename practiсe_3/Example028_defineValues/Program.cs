Console.Write("Введите четверть от 1 до 4: ");
int number = Convert.ToInt32(Console.ReadLine());

string GetQuater(int num)
{
    if (num == 1) return "X>0 и Y>0";
    if (num == 2) return "X<0 и Y>0"; //else не нужен т.к. return прерывает
    if (num == 3) return "X<0 и Y<0"; //else не нужен т.к. return прерывает
    if (num == 4) return "X>0 и Y<0"; //else не нужен т.к. return прерывает
    else return "Некоректный ввод, введите от 1 до 4";
}

string result = GetQuater(number);
Console.WriteLine(result);