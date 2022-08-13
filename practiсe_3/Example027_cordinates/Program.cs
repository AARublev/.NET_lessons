// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("введите значение x для 1 точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение y для 1 точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите значение x для 2 точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите значение y для 2 точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double cord = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));

Console.WriteLine(Math.Round(cord, 2, MidpointRounding.ToZero)); //Метода Math с параметром Round - делает округление до определенного значения после запятой
//MidpointRounding.ToZero - Стратегия направленного округления к нулю, с результатом, ближайшим к и не превышающим бесконечно точный результат
//подробнее - https://docs.microsoft.com/ru-ru/dotnet/api/system.midpointrounding?view=net-6.0