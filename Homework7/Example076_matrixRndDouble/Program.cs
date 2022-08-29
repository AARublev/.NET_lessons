//  Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
//  вещественными числами.

//  m = 3, n = 4.
//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9

Console.Write("Enter the length of the matrix: ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the height of the matrix: ");
int columnMatrix = Convert.ToInt32(Console.ReadLine());

bool CheckNumForMatrix(int row, int col)
{
    return row > 0 && col > 0;
}

double[,] CteateMatrixRndDouble(int row, int col, double min, double max)
{
    double[,] matrix = new double[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1)) Console.Write($"{matrix[i, j],6}");
        }
        Console.WriteLine();
    }
}

if(CheckNumForMatrix(rowMatrix, columnMatrix))
{
Console.WriteLine();
Console.WriteLine($"m={rowMatrix}, n={columnMatrix}");
Console.WriteLine();
double[,] resultat = CteateMatrixRndDouble(columnMatrix, rowMatrix, 0, 10);
PrintMatrix(resultat);
}
else Console.WriteLine("Enter a positive number other than 0");
