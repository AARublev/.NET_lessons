int[,] pic = new int[,]
{
    {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
    {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
};

void PrintImage(int[,] image)   //метод вывода картинки
{
    for (int i = 0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            //Console.Write($"imsge[i,j] ");
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}

void FillImage(int row, int col)    //метод закрашивания картинки; выбираем тек точку ---> row - строка, col - столбец
{
    if (pic[row, col] == 0) //текущий пиксель с указанной позицией
    {
        pic[row, col] = 1;
        FillImage(row - 1, col);    //FillImage вызывает сам себя. На строчку выше
        FillImage(row, col - 1);    //влево
        FillImage(row + 1, col);    //вниз
        FillImage(row, col + 1);    //вправо
    }
}


PrintImage(pic); //array wich image
FillImage(7,3);
Console.WriteLine();
PrintImage(pic);
Console.WriteLine();