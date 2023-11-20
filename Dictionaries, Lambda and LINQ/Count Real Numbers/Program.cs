int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

SortedDictionary<int, int> numberOccurance = new();

foreach  (int number in numbers)
{
    if (numberOccurance.ContainsKey(number))
    {
        numberOccurance[number] = numberOccurance[number] + 1;
    }

    else
    {
        numberOccurance.Add(number, 1);
    }
}

foreach (KeyValuePair<int, int> pair in numberOccurance)
{
    Console.WriteLine($"{pair.Key} -> {pair.Value}");
}