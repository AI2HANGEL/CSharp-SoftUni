static void RepeatString(string text, int repeatCount)
{
    string newStr = "";
    for (int i = 0; i < repeatCount; i++)
    {
        newStr += text;
    }
    Console.WriteLine(newStr); 
}

string inputStr = Console.ReadLine();
int repeat = int.Parse(Console.ReadLine());

RepeatString(inputStr, repeat);