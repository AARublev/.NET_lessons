//Дан текст. В тексе пробелы заменить четрочками, маленькие "к" заменить на большие "К"
//большие "С" заменить на маленькаие "с".


string text = "– Я думаю, – сказал князь, улыбаясь, что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красночерчивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result=String.Empty; //иициализировали пустую строку

    int length = text.Length; //свойство Lenght показывающее кол-во символов строки
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}"; //в result кладем новое значение 
        else result = result + $"{text[i]}"; //если совподения не обнаружены, то в result добавим текущий символ
    }

    return result;
}

string newText = Replace(text, ' ', '|');

newText = Replace(newText, 'к', 'К');

newText = Replace(newText, 'с', 'С');

Console.Clear();
Console.WriteLine(newText);