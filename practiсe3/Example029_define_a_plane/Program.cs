// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.Clear();
Console.Write("введите x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("введите y: ");
int y = Convert.ToInt32(Console.ReadLine());


string GetQuater(int xc, int yc)
{
    if (xc > 0 && yc > 0) return "Четверть 1";
    if (xc > 0 && yc < 0) return "Четверть 4"; //else не нужен т.к. return прерывает
    if (xc < 0 && yc > 0) return "Четверть 2"; //else не нужен т.к. return прерывает
    if (xc < 0 && yc < 0) return "Четверть 3"; //else не нужен т.к. return прерывает
    else return "Начало координат";
}

string result = GetQuater(x,y);
Console.WriteLine(result);