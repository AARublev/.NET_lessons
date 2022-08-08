void FillArray(int[] collection) //метод
{
    int lenght = collection.Length; // lenght = кол-во эл-в в массиве
    int index = 0;
    while (index<lenght)
    {
        collection[index] = new Random().Next(1,20); //кладем целое число из дипазона [1,20] в массив на место index
        index++;
    }
}

//void методы - это методы которые ничего не возвращают

void PrintArray(int[] col)  //метод void который будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index=0;
    int position=-1;
    while(index<count)
    {
        if (collection[index]==find) 
        {
            position=index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // Создал и массив array и у казали, что в нем 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
