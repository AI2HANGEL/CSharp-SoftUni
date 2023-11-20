string input = Console.ReadLine();

Dictionary<char, int> charOccurrence = new();

foreach (char character in input)
{
    if (character != ' ')
    {
        if (charOccurrence.ContainsKey(character))
        {
            charOccurrence[character]++;
        }
        else
        {
            charOccurrence.Add(character, 1);
        }
    }
}

foreach (KeyValuePair<char, int> pair in charOccurrence)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}
