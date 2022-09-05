// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

Console.Write("Enter the length of the matrix (row): ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the height of the matrix (column): ");
int columnMatrix = Convert.ToInt32(Console.ReadLine());


if (CheckNumForMatrix(rowMatrix, columnMatrix))
{
    if (CheckRectangle(rowMatrix, columnMatrix))
    {
        int[,] matrixTester = CreateMatrixRndInt(rowMatrix, columnMatrix, 0, 10);
        PrintMatrix(matrixTester);
        Console.WriteLine();
        int[] testarray = SumRowMatrix(matrixTester);
        PrintArray(testarray); //для промежуточного вывода
        Console.WriteLine();
        Comparison(testarray);
    }
    else Console.WriteLine("The matrix must be rectangular");
}
else Console.WriteLine("Enter a positive number other than 0");


bool CheckNumForMatrix(int row, int col)
{
    return row > 0 && col > 0;
}

bool CheckRectangle(int row, int col)
{
    return col != row;
}


int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }

    return matrix;
}

int[] SumRowMatrix(int[,] matrix)
{
    int[] sumArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

void Comparison(int[] array)
{
    int minPosition = 0;
    for (int i = 0; i < array.Length - 1; i++) //-1 чтобы на втором цикле j  не залезла за границы массива
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
    }
    Console.WriteLine($"The string with the smallest sum of numbers: {minPosition + 1}\n");
}


void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4},");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}
