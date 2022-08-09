int number = new Random().Next(10,100);

int MaxDigit(int num)
{
    int result = 0;
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if(firstDigit == secondDigit) result = -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int result = MaxDigit(number);
string res = result == -1 ? "Цифры одинаковые" : result.ToString();
Console.WriteLine($"{number} => {result}");

// int res = firstDigit > secondDigit ? firstDigit : secondDigit; тернарный оператор

