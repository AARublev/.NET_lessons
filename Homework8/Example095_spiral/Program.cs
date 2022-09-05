// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Enter the size of the matrix: ");
int sizeMatrix = Convert.ToInt32(Console.ReadLine());

if (CheckNumForMatrix(sizeMatrix))
{
    int[,] spiralResult = SpiralArray(sizeMatrix);
    PrintMatrix(spiralResult);
}
else Console.WriteLine("Enter a positive number other than 0");


bool CheckNumForMatrix(int size)
{
    return size > 0;
}

int[,] SpiralArray(int size)
{
    
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