// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Enter the length of the matrix: ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the height of the matrix: ");
int columnMatrix = Convert.ToInt32(Console.ReadLine());

if (CheckNumForMatrix(rowMatrix, columnMatrix))
{
    int[,] matrixTester = CreateMatrixRndInt(rowMatrix, columnMatrix, 0, 10);
    PrintMatrix(matrixTester);
    Console.WriteLine();
    SortingRow(matrixTester);
    PrintMatrix(matrixTester);
}
else Console.WriteLine("Enter a positive number other than 0");


bool CheckNumForMatrix(int row, int col)
{
    return row > 0 && col > 0;
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

int[,] SortingRow(int[,] matrix)
{
    int buf = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int maxNum = j;
            for (int g = j + 1; g < matrix.GetLength(1); g++)
            {
                if (matrix[i, g] > matrix[i, maxNum]) maxNum = g;
            }
            buf = matrix[i, j];
            matrix[i, j] = matrix[i, maxNum];
            matrix[i, maxNum] = buf;
        }
    }
    return matrix;
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