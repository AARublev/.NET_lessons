void Method1()
{
    Console.WriteLine("Hello ");
}

Method1();

void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("Text message");

void Method21(string msg, int count)
{
    int i=0;
    while (i<count)
    {
    Console.WriteLine(msg);
    i++;
    }
}

Method21("Hello", 4);
Method21(count:3, msg:"new text"); //именованные аргументы, порядок не важен