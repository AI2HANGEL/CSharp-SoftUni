string[] strings = Console.ReadLine().Split(" ");

string result = "";


for (int i = 0; i < strings.Length; i++)
{
    string current = strings[i];

    for (int j = 0; j < current.Length; j+= 1)
    {
        result += current;
    }
}

Console.WriteLine(result);