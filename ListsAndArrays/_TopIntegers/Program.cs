static List<int> FindTopIntegers(List<int> numbers)
{
    List<int> topIntegers = new List<int>();
    int maxRight = int.MinValue;

    for (int i = numbers.Count - 1; i >= 0; i--)
    {
        if (numbers[i] > maxRight)
        {
            topIntegers.Add(numbers[i]);
            maxRight = numbers[i];
        }
    }

    topIntegers.Reverse();
    return topIntegers;
}

List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

Console.WriteLine(string.Join(" ", FindTopIntegers(numbers)));