// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное

Console.Write("Number for conversion: ");
long number = Convert.ToInt32(Console.ReadLine());

/* рабочий участок кода
long b = 0;
long newnumber = 0;
long c = 1;

long BinarNum(long num)
{
while(num != 0)
{
    b = number % 2;
    number = number / 2;
    c = c * 10;
    newnumber = newnumber + b * c;
}
return newnumber/10;
}

long result = BinarNum(number);
Console.WriteLine($"Number in BIN: {result}");
*/

//лучший вариант -->
long BinarNum(long num)
{
    long result = 0;
    long i = 10;

    while (num > 0)
    {
        result += num % 2 * i;
        num /= 2;
        i *= 10;
    }
    return result;
    // for (long i = 1; num > 0; i * 10)
    // {
    //     result += num % 2 * i;
    //     num /= 2;
    // }
    // return result;
}

long resultat = BinarNum(number);

Console.WriteLine($"Number in BIN: {resultat}");