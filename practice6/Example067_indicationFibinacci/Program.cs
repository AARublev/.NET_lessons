// Не используя рекурсию, выведите первые N чисел Фибоначи
// Первые 2 числа Фибоначи: 0 и 1

// Если N = 5 -> 0 1 1 2 3
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n <= 0)
{
    Console.Write("Введите положительное число больше 0: ");
    n = Convert.ToInt32(Console.ReadLine());
}

int[] FibonacciBeforeN(int N)
{
    int[] fibonacciN = new int[N];

    for (int i = 0; i < N; i++)
    {
        if (i == 0) fibonacciN[i] = 0;
        else if (i == 1 || i == 2) fibonacciN[i] = 1;
        else fibonacciN[i] = fibonacciN[i - 1] + fibonacciN[i - 2];
    }
    return fibonacciN;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


int[] result = FibonacciBeforeN(n);
PrintArray(result);