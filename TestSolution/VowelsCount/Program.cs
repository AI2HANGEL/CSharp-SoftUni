string line = Console.ReadLine();

static void GetVowelsCount(string line)
{
    int count = 0;

    for (int position = 0; position <= line.Length - 1; position++)
    {
        char symbol = line[position];
        switch (symbol)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                count++;
                break;
        }
        Console.WriteLine(count);
    }

}


string word = Console.ReadLine();
GetVowelsCount(word);
