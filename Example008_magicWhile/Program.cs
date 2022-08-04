//фрактальное изображение треугольника серпинского

Console.Clear();
int xA=20, yA=1,     //координаты
    xB=1, yB=20,    
    xC=40, yC=20;   

Console.SetCursorPosition(xA, yA);
Console.WriteLine("+");

Console.SetCursorPosition(xB, yB);
Console.WriteLine("+");

Console.SetCursorPosition(xC, yC);
Console.WriteLine("+");

int x=xA, y=xB;     //первая точка 
int count = 0;     //счетчик


while(count<10000)    //оператор цикла while выполн пока < Slch
{
    int Slch = new Random().Next(0, 3);            //генерируем случайное число из (0;3]
    if(Slch == 0)
    {
        x=(x+xA)/2;    
        y=(y+yA)/2;    
    }

    if (Slch == 1)
    {
        x=(x+xB)/2;
        y=(y+yB)/2;
    }

    if (Slch == 2)
    {
        x=(x+xC)/2;
        y=(y+yC)/2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count+=1;           //count++

}
