//PolyToInt32 - число палиндром то возвращает само число, если число не палиндром то -1
//Возвращает число, если палиндром, чтобы с ним можно было работать после вызова метода.


Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());


int PolyToInt32(int num)
{
    if (num > 10)
    {
        double rightNumber = 0;
        double newLeftNumber = 0; //перевертыш
        double leftNumber = 0;
        int count = 1;
        int num1 = num; //чтобы не потерять значение num

        while (num1 > 10)   //счеитаем кол-во цифр
        {
            num1 = num1 / 10;
            count++;
        }

        int countHalf = count / 2;
        leftNumber = num / (Math.Pow(10, countHalf));   //12345 -> 12345/1000 -> 12
        rightNumber = num % (Math.Pow(10, countHalf));  //12345 -> 12345%100 -> 45

        if (count % 2 != 0) leftNumber = (int)leftNumber / 10;
        else leftNumber = (int)leftNumber;

        while (countHalf > 0)   //создаем перевертыш для leftNumber
        {
            countHalf--;
            int num3 = (int)leftNumber % 10;    // 123 -> 3 
            leftNumber = (int)leftNumber / 10;  // 123 -> 12 
            newLeftNumber += num3 * (Math.Pow(10, countHalf));  //3*10^2=300 
        }

        if (newLeftNumber == rightNumber) return num;
        else return -1;
    }
    if (num >= 0 && num < 10) return num;
    else return -1;
}


int result = PolyToInt32(number);
if (result == number) Console.WriteLine($"this {result} is palindrome");
else Console.WriteLine($"this {number} is not a palindrome");




