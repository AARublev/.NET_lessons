int func(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2>result) result = arg2;
    if (arg3>result) result = arg3;
    return result;
}

int[] newArray = {41,26,37,4,35,46,721,928,49};
newArray[1]=0; //обратились к массиву и записали значение 0 в 1-й индекс массива
//Console.WriteLine(newArray[4]); - обратились к массиву и получили значение под 4-м индексом

int max = func(func(newArray[0], newArray[1], newArray[2]),
               func(newArray[3], newArray[4], newArray[5]),
               func(newArray[6], newArray[7], newArray[8]));

Console.WriteLine(max);

 