// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы 
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Enter the length of the matrix: ");
int rowMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the height of the matrix: ");
int columnMatrix = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the diagonal of the matrix: ");
int diagonalMatrix = Convert.ToInt32(Console.ReadLine());

if (CheckNumForMatrix(rowMatrix, columnMatrix, diagonalMatrix))
{
    int[] arr = CreateArrayNoReplayRndInt(rowMatrix, columnMatrix, diagonalMatrix);
    PrintArray(arr);

    SortedArray(arr); //Для демонстрации рабтоспособности
    PrintArray(arr);

    int[,,] matrixTester = IncreasingMatrixThreVal(arr, rowMatrix, columnMatrix, diagonalMatrix);
    Console.WriteLine();
    PrintMatrixThreVal(matrixTester);
    Console.WriteLine();
}
else if ((rowMatrix * columnMatrix * diagonalMatrix) > 100) Console.WriteLine("Enter a smaller matrix size");
else Console.WriteLine("Enter a positive number other than 0");


bool CheckNumForMatrix(int row, int col, int diag)
{
    return row > 0 && col > 0 && diag > 0 && (row * col * diag) < 100;
}


int[] CreateArrayNoReplayRndInt(int row, int col, int diag, int min = 10, int max = 50)
{
    int[] array = new int[row * col * diag];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max);
    }


    int count = 1;
    while (count != 0)     //будет просматривать ВЕСЬ массив и заменять повторы до тех пор пока count!=0
    {
        count = 0;
        for (int k = 0; k < array.Length - 1; k++)
        {
            for (int i = k + 1; i < array.Length; i++)
            {
                if (array[k] == array[i])
                {
                    array[i] = new Random().Next(min, max * 2); //беру весь диапазон 2-х значных, в случае если не задействены какие-то номера из первого деапазона (10-50)
                    count++;
                }
            }
        }
    }
    return array;
}


int[,,] IncreasingMatrixThreVal(int[] arrayNoRepl, int row, int col, int diag)
{
    int k = 0;
    int[,,] matrix = new int[row, col, diag];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                matrix[i, j, z] = arrayNoRepl[k];
                k++;
            }
        }
    }
    return matrix;
}


int[] SortedArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}


void PrintMatrixThreVal(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix.GetLength(2); z++)
            {
                Console.Write($"{matrix[i, j, z],4}({i},{j},{z})");
            }
            Console.WriteLine();
        }
    }
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