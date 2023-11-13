static string WordRemover(string keyword, string word)
{
    while (word.Contains(keyword))

    {
        word = word.Replace(keyword, "");
    }

    return word;
}

string keyword = Console.ReadLine();
string word = Console.ReadLine();

word = WordRemover(keyword, word);

Console.WriteLine(word);

