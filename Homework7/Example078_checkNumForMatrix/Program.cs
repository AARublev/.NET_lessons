// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Enter the length of the matrix: ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the height of the matrix: ");
int columnMatrix = Convert.ToInt32(Console.ReadLine());

if (CheckNumForMatrix(rowMatrix, columnMatrix))
{
    int[,] matrixTester = CreateMatrixInt(rowMatrix, columnMatrix, 0, 10);
    PrintMatrix(matrixTester);
    Console.WriteLine();
    AverageNumColMatrix(matrixTester);
}
else Console.WriteLine("Enter a positive number other than 0");

bool CheckNumForMatrix(int row, int col)
{
    return row > 0 && col > 0;
}

int[,] CreateMatrixInt(int row, int col, int min, int max)
{
    int[,] userMatrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < userMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < userMatrix.GetLength(1); j++)
        {
            userMatrix[i, j] = rnd.Next(min, max);
        }
    }
    return userMatrix;
}

void AverageNumColMatrix(int[,] matrix)
{
    double result = 0;
    Console.Write($"Arithmetic mean of each column: ");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result += matrix[i, j];
        }
        result /= matrix.GetLength(0);
        result=Math.Round(result,2);
        if (j < matrix.GetLength(1) - 1) Console.Write($"{result};  ");
        else Console.Write(result);
        result = 0;
    }
    Console.WriteLine();
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}