// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

Console.Write("Enter the length of the matrix: ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the height of the matrix: ");
int columnMatrix = Convert.ToInt32(Console.ReadLine());

if (CheckNumForMatrix(rowMatrix, columnMatrix))
{
    int[,] matrixTester = CreateMatrixRndInt(rowMatrix, columnMatrix, 0, 10);
    PrintMatrix(matrixTester);
    Console.WriteLine();
    ReplaceFirstRowWithLast(matrixTester);
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

void ReplaceFirstRowWithLast(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[0, i];
        array[0, i] = array[rowMatrix - 1, i];
        array[rowMatrix - 1, i] = tmp;
    }
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