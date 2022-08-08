int[] array = {1,23,4,6,3,2,4,55,43,323, 55};
int n = array.Length;   //возвращает кол-во элементов массива или его длину. Т.е. n=длина array 
int find = 55;

int index=0;
while (index<n)
{
    if (array[index]==find) 
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

