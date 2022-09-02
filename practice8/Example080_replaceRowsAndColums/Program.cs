// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


Console.Write("Enter the length of the matrix: ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the height of the matrix: ");
int columnMatrix = Convert.ToInt32(Console.ReadLine());

if (CheckNumForMatrix(rowMatrix, columnMatrix))
{
    int[,] matrixTester = CreateMatrixRndInt(rowMatrix, columnMatrix, 0, 10);
    PrintMatrix(matrixTester);
    Console.WriteLine();
    int[,] replacearr = ReplaceRowsAndColums(matrixTester, rowMatrix, columnMatrix);
    PrintMatrix(replacearr);
}
else Console.WriteLine("It is not possible to replace rows with columns");


bool CheckNumForMatrix(int row, int col)
{
    return (row > 0 && col > 0 && row == col);

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

int[,] ReplaceRowsAndColums(int[,] array, int rows, int colums)
{
    int size = array.GetLength(1);

    int[,] arrayTmp = new int[rows, colums];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            arrayTmp[i, j] = array[j, i];
        }
    }
    return arrayTmp;
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