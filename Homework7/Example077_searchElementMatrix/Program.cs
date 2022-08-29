// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

DateTime then = DateTime.Now;

Console.Write("Enter the length of the matrix: ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the height of the matrix: ");
int columnMatrix = Convert.ToInt32(Console.ReadLine());

if (CheckNumForMatrix(rowMatrix, columnMatrix))
{
    int[,] resultat = CreateMatrixInt(rowMatrix, columnMatrix, 0, 10);
    PrintMatrix(resultat);

    Console.WriteLine("searching for an element in the matrix");
    Console.Write("Enter row: "); // Ряд.
    int rowLook = int.Parse(Console.ReadLine());
    Console.Write("Enter column: "); // Колонка.
    int columnLook = int.Parse(Console.ReadLine());

    FastSearchElementMatrix(resultat, rowLook, columnLook);
}
else Console.WriteLine("Enter a positive number other than 0");

Console.WriteLine();
DateTime now = DateTime.Now;
Console.WriteLine($"ms {now.Millisecond - then.Millisecond}");

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

void FastSearchElementMatrix(int[,] matrix, int rowL, int colL)
{
    if (rowL >= matrix.GetLength(0) || colL >= matrix.GetLength(1)) Console.WriteLine($"{rowL},{colL} --> the element is missing in the array");
    else
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (i == rowL)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == colL)
                    {
                        Console.WriteLine($"requested element: {matrix[i, j],2}");
                        break;
                    }
                }
            }
        }
    }
}
