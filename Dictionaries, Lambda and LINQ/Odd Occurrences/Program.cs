string[] input = Console.ReadLine().Split(" ");

Dictionary<string, int> WordsCounter = new Dictionary<string, int>();


foreach (string word in input)
{
    string toLower = word.ToLower();

    if (WordsCounter.ContainsKey(toLower))
    {
        WordsCounter[toLower]++;
    }

    else
    {
        WordsCounter.Add(toLower, 1);
    }
}

foreach (KeyValuePair<string, int> pair in WordsCounter)
{
    if (pair.Value % 2 != 0)
    {
        Console.Write($"{pair.Key} ");
    }

}
