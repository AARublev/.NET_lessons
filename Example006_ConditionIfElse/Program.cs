Console.WriteLine("What you name? ");
string username = Console.ReadLine();

if (username.ToLower() == "anna")  // операция ToLower() позволяет все символы 
{                                  // в нижний регистр
    Console.WriteLine("I love you");
}
else
{
    Console.WriteLine("Hello!");
    Console.WriteLine(username); // added
}