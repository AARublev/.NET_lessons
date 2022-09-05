// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Data for 1 matrix");
Console.Write("Enter the height of the matrix for 1 (row): ");
int rowMatrixOne = Convert.ToInt32(Console.ReadLine()); //#кол-во строк в 1 матрице
Console.Write("Enter the length of the matrix for 1 (column): ");
int columnMatrixOne = Convert.ToInt32(Console.ReadLine()); //кол-во столбцов 
Console.WriteLine("Data for 1 matrix");
Console.Write("Enter the height of the matrix for 2 (row): ");
int rowMatrixTwo = Convert.ToInt32(Console.ReadLine()); //кол-во строк 
Console.Write("Enter the length of the matrix for 2 (column): ");
int columnMatrixTwo = Convert.ToInt32(Console.ReadLine()); //№количество столбцов во второй матрице


if (CheckNumForMatrix(rowMatrixOne, columnMatrixOne, rowMatrixTwo, columnMatrixTwo))
{
    int[,] matrixTesterOne = CreateMatrixRndInt(rowMatrixOne, columnMatrixOne, 1, 5);
    PrintMatrix(matrixTesterOne);
    Console.WriteLine($"\n      X\n");
    int[,] matrixTesterTwo = CreateMatrixRndInt(rowMatrixTwo, columnMatrixTwo, 1, 5);
    PrintMatrix(matrixTesterTwo);
    Console.WriteLine("\n      =\n");
    int[,] resultatMatrix = MultiTwoIntMatrix(matrixTesterOne, matrixTesterTwo);
    PrintMatrix(resultatMatrix);
    Console.WriteLine();
}
else if (columnMatrixOne != rowMatrixTwo) Console.WriteLine("You can't multiply matrices");
else Console.WriteLine("Enter a positive number other than 0");


bool CheckNumForMatrix(int row1, int col1, int row2, int col2)
{
    return row1 > 0 && col1 > 0 && row2 > 0 && col2 > 0 && col1 == row2;
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


int[,] MultiTwoIntMatrix(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] MultiMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];

    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0; j < matrixTwo.GetLength(1); j++)
        {
            {
                for (int q = 0; q < matrixTwo.GetLength(0); q++)
                {
                    MultiMatrix[i, j] += matrixOne[i, q] * matrixTwo[q, j];
                }
            }
        }
    }
    return MultiMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("(");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) System.Console.Write($"{matrix[i, j],4}  |");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine(")");
    }
}