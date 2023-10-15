static void ValueCompare(string a, string b, string type)
{
    if (type == "int")
    {
        int numberA = int.Parse(a);
        int numberB = int.Parse(b);

        if (numberA > numberB)
        {
            Console.WriteLine(numberA);
        }
        else
        {
            Console.WriteLine(numberB);
        }
    }
    else if (type == "char")
    {
        char letterA = char.Parse(a);
        char letterB = char.Parse(b);

        if (letterA > letterB)
        {
            Console.WriteLine(letterA);
        }
        else
        {
            Console.WriteLine(letterB);
        }
    }
    else if (type == "string")
    {
        int compResult = string.Compare(a, b);

        if (compResult > 0)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }

}


string type = Console.ReadLine();
string lineA = Console.ReadLine();
string lineB = Console.ReadLine();

ValueCompare(lineA, lineB, type);