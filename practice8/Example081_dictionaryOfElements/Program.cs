// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных


Console.Write("Enter the length of the matrix: ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the height of the matrix: ");
int columnMatrix = Convert.ToInt32(Console.ReadLine());

if (CheckNumForMatrix(rowMatrix, columnMatrix))
{
    int[] arr = new int[rowMatrix * columnMatrix];
    int[,] matrixTester = CreateMatrixRndInt(rowMatrix, columnMatrix, 0, 10);
    PrintMatrix(matrixTester);
    Console.WriteLine();

    ConverMatrixToArray(matrixTester, arr);

    PrintArray(arr);
    Console.WriteLine();

    Array.Sort(arr);
    PrintArray(arr);
    Console.WriteLine();
    
    CountEvenElemet(arr);
}
else Console.WriteLine("Enter a positive number other than 0");


bool CheckNumForMatrix(int row, int col)
{
    return (row > 0 && col > 0);
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

void ConverMatrixToArray(int[,] matrix, int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
}

void CountEvenElemet(int[] array)
{
    int tmp = array[0];
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (tmp == array[i])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{tmp} встречается {count} раз");
            tmp = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{tmp} встречается {count} раз");
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

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}